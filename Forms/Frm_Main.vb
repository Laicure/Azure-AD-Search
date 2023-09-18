Imports System.DirectoryServices
Imports System.Globalization

Public Class Frm_Main

	Dim inputLines As New HashSet(Of String)
	Dim outputLines As New HashSet(Of String)
	Dim errx() As String = {}
	Dim startExec As DateTime = DateTime.UtcNow
	Dim glob As CultureInfo = CultureInfo.InvariantCulture

	Private Sub Frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		With Me
			.Text = "Azure AD Search v" & My.Application.Info.Version.ToString
			.Icon = My.Resources.Icon1
		End With

	End Sub

	Private Sub Frm_Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
		If MessageBox.Show("Are you sure to close the Azure AD Search app?", "Close?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then e.Cancel = True
	End Sub

	Private Sub Tx_Input_TextChanged(sender As Object, e As EventArgs) Handles Tx_Input.TextChanged
		inputLines = Tx_Input.Lines.Where(Function(x) Int64.TryParse(x, Nothing) OrElse x.Contains("@")).Select(Function(x) x.Replace(" ", "")).ToHashSet
		With Lb_Generate
			.Enabled = Not inputLines.LongCount = 0
			.Text = "Search Counterpart"
		End With
	End Sub

	Private Sub Lb_Generate_Click(sender As Object, e As EventArgs) Handles Lb_Generate.Click
		If Not Bg_LDAP.IsBusy Then
			startExec = DateTime.UtcNow

			Tx_Input.ReadOnly = True
			Tx_Output.Clear()
			With Lb_Generate
				.Enabled = False
				.Text = "Searching..."
			End With

			Bg_LDAP.RunWorkerAsync()
		End If

	End Sub

#Region "Background Worker"

	Private Sub Bg_LDAP_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Bg_LDAP.DoWork
		Try
			'@@@@@@ search by mail or employee number
			For Each str As String In inputLines
				Using adSearcher As New DirectorySearcher
					With adSearcher
						If Int64.TryParse(str, Nothing) Then
							.Filter = "employeeNumber=" & str
							.PropertiesToLoad.Add("mail")
						Else
							.Filter = "mail=" & str
							.PropertiesToLoad.Add("employeeNumber")
						End If

						Dim resul As SearchResult = .FindOne
						If Not IsNothing(resul) Then
							Dim user As DirectoryEntry = resul.GetDirectoryEntry

							If Int64.TryParse(str, Nothing) Then
								outputLines.Add(user.Properties("mail").Value.ToString.ToLowerInvariant)
							Else
								outputLines.Add(user.Properties("employeeNumber").Value.ToString)
							End If
						Else
							outputLines.Add("-")
						End If
					End With
				End Using
			Next

			'@@@@@@ search by Identity
			'Using ctx As New PrincipalContext(ContextType.Domain, "ap.cbre.net")
			'	Dim userPrin As UserPrincipal = UserPrincipal.FindByIdentity(ctx, IdentityType.SamAccountName, "LMillares")
			'	If Not IsNothing(userPrin) Then outputLines.Add(userPrin.Description)
			'End Using

			'@@@@@@ search all
			'Using ctx As New PrincipalContext(ContextType.Domain, "ap.cbre.net")
			'	Using userPrin As New UserPrincipal(ctx)
			'		Using sear As New PrincipalSearcher(userPrin)
			'			For Each domUser As Principal In sear.FindAll
			'				outputLines.Add(domUser.UserPrincipalName & " | " & domUser.SamAccountName & " | " & domUser.DisplayName & " | " & domUser.DistinguishedName & " | " & domUser.Name & " | " & domUser.SamAccountName & " | " & domUser.Sid.Value)
			'			Next
			'		End Using
			'	End Using
			'End Using

			errx = {}
		Catch ex As Exception
			errx = {Err.Description, Err.Source}
		End Try
	End Sub

	Private Sub Bg_LDAP_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Bg_LDAP.RunWorkerCompleted
		Dim timeCompleted As String = Microsoft.VisualBasic.Left(DateTime.UtcNow.Subtract(startExec).ToString, 11)
		If errx.Count = 2 Then
			Lb_Generate.Text = "Error @ " & timeCompleted
			MessageBox.Show(errx(0), errx(1), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
		Else
			Tx_Output.Lines = outputLines.ToArray
			Lb_Generate.Text = "Done @ " & timeCompleted

			MessageBox.Show("Took " & timeCompleted, "Successfully Generated!", MessageBoxButtons.OK, MessageBoxIcon.Information)

			Tx_Output.Focus()
		End If

		Tx_Input.ReadOnly = False
		Lb_Generate.Enabled = True

		With outputLines
			.Clear()
			.TrimExcess()
		End With
	End Sub

#End Region

End Class
