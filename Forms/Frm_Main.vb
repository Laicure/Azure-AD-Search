Imports System.DirectoryServices
Imports System.Globalization

Public Class Frm_Main

#Region "Init"

	Dim inputLines As New List(Of String)
	Dim outputLines As New List(Of String)
	Dim errx() As String = {}
	Dim startExec As DateTime = DateTime.UtcNow
	Dim glob As CultureInfo = CultureInfo.InvariantCulture

	Dim reInputValid As Boolean = False
	Dim addDisplayName As Boolean = False
	Dim breakState As Boolean = False

#End Region

#Region "Form"

	Private Sub Frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		With Me
			.Text = "Azure AD Search v" & My.Application.Info.Version.ToString
			.Icon = My.Resources.Icon1
		End With

	End Sub

	Private Sub Frm_Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
		If MessageBox.Show("Are you sure to close the Azure AD Search app?", "Close?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
			e.Cancel = True
		Else
			breakState = True
		End If
	End Sub

#End Region

#Region "Controls"

	Private Sub Tx_Input_Enter(sender As Object, e As EventArgs) Handles Tx_Input.Enter
		If Tx_Input.Text.StartsWith("Exact Match:") Then Tx_Input.Clear()
	End Sub

	Private Sub Tx_Input_TextChanged(sender As Object, e As EventArgs) Handles Tx_Input.TextChanged
		If reInputValid Then Exit Sub

		inputLines = Tx_Input.Lines.Where(Function(x) Int64.TryParse(x.Replace(" ", ""), Nothing) OrElse x.Replace(" ", "").Contains("@") OrElse Not String.IsNullOrWhiteSpace(x)).ToList
		With Lb_Generate
			.Enabled = Not inputLines.Count = 0
			.Text = "Search Counterpart"
		End With
	End Sub

	Private Sub Lb_Generate_Click(sender As Object, e As EventArgs) Handles Lb_Generate.Click
		If Not Bg_LDAP.IsBusy Then
			startExec = DateTime.UtcNow

			reInputValid = True
			With Tx_Input
				.Lines = inputLines.ToArray
				.ReadOnly = True
			End With
			reInputValid = False

			Tx_EmpNumEmail.Clear()
			Ch_DisplayName.Enabled = False
			With Lb_Generate
				.Enabled = False
				.Text = "Searching... (" & startExec.ToString("HH:mm:ss", glob) & ") @ " & inputLines.Count.ToString("#,0", glob) & " lines"
			End With

			addDisplayName = Ch_DisplayName.Checked

			Bg_LDAP.RunWorkerAsync()
		End If

	End Sub

#End Region

#Region "Background Worker"

	Private Sub Bg_LDAP_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Bg_LDAP.DoWork
		Dim inputLinesCount As Integer = inputLines.Count

		Try
			'@@@@@@ search by mail or employee number
			Parallel.ForEach(inputLines, New ParallelOptions With {.MaxDegreeOfParallelism = Convert.ToInt32(Math.Ceiling((Environment.ProcessorCount * 0.75) * 2.0))},
				Sub(x, state)
					If breakState Then
						state.Break()
						Exit Sub
					End If
					Dim strx As String = x.Trim
					Dim byWhat As Integer = 0 '1=empnum,2=email,3=name
					If Int64.TryParse(strx, Nothing) Then
						byWhat = 1
					ElseIf strx.Contains("@") Then
						byWhat = 2
					Else
						byWhat = 3
					End If

					Using adSearcher As New DirectorySearcher
						With adSearcher
							Select Case byWhat
								Case 1
									.Filter = "employeeNumber=" & strx
									.PropertiesToLoad.Add("mail")
									If addDisplayName Then .PropertiesToLoad.AddRange({"givenname", "sn"})
								Case 2
									.Filter = "mail=" & strx
									.PropertiesToLoad.Add("employeeNumber")
									If addDisplayName Then .PropertiesToLoad.AddRange({"givenname", "sn"})
								Case 3
									.Filter = "displayName=" & strx & "*"
									.PropertiesToLoad.AddRange({"employeeNumber", "mail"})
							End Select

							Dim resul As SearchResult = .FindOne
							If Not IsNothing(resul) Then
								Dim user As DirectoryEntry = resul.GetDirectoryEntry
								Dim displayName As String = "-"

								If addDisplayName Then displayName = user.Properties("sn").Value.ToString() & ", " & user.Properties("givenname").Value.ToString()

								Select Case byWhat
									Case 1
										outputLines.Add(user.Properties("employeeNumber").Value.ToString & " | " & user.Properties("mail").Value.ToString.ToLowerInvariant & IIf(addDisplayName, " | " & displayName, "").ToString)
									Case 2
										outputLines.Add(user.Properties("mail").Value.ToString.ToLowerInvariant & " | " & user.Properties("employeeNumber").Value.ToString & IIf(addDisplayName, " | " & displayName, "").ToString)
									Case 3
										outputLines.Add(displayName & " | " & user.Properties("employeeNumber").Value.ToString & " | " & user.Properties("mail").Value.ToString.ToLowerInvariant)
								End Select
							Else
								outputLines.Add(strx)
							End If
						End With
					End Using
				End Sub
			)
			errx = {}
		Catch ex As Exception
			errx = {Err.Description, Err.Source}
		End Try
	End Sub

	Private Sub Bg_LDAP_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Bg_LDAP.RunWorkerCompleted
		Dim timeCompleted As String = Microsoft.VisualBasic.Left(DateTime.UtcNow.Subtract(startExec).ToString, 11)
		If errx.Count = 2 Then
			Lb_Generate.Text = "Error @ " & timeCompleted & " (" & inputLines.Count.ToString("#,0", glob) & " lines)"
			MessageBox.Show(errx(0), errx(1), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
		Else
			Tx_EmpNumEmail.Lines = outputLines.ToArray
			Lb_Generate.Text = "Done @ " & timeCompleted & " (" & inputLines.Count.ToString("#,0", glob) & " lines)"

			Tx_EmpNumEmail.Focus()
		End If

		Tx_Input.ReadOnly = False
		Ch_DisplayName.Enabled = True
		Lb_Generate.Enabled = True

		With outputLines
			.Clear()
			.TrimExcess()
		End With
	End Sub

#End Region

End Class
