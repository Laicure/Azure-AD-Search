Imports System.DirectoryServices
Imports System.Globalization

Public Class Frm_Main

#Region "Init"

	Dim inputLines As New List(Of String)
	Dim outputLines As New List(Of String)
	Dim errx() As String = {}
	Dim startExec As DateTime = DateTime.Now
	Dim glob As CultureInfo = CultureInfo.InvariantCulture

	Dim reInputValid As Boolean = False
	Dim addDisplayName As Boolean = False
	Dim addManagerEmail As Boolean = False
	Dim addEmployeeID As Boolean = False
	Dim addEmployeeEmail As Boolean = False
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

		inputLines = Tx_Input.Lines.Where(Function(x) Int64.TryParse(x.Replace(" ", ""), Nothing) OrElse x.Replace(" ", "").Contains("@") OrElse Not String.IsNullOrWhiteSpace(x)).Select(Function(x) x.ToLowerInvariant).Distinct.ToList
		With Lb_Generate
			.Enabled = Not inputLines.Count = 0
			.Text = "Search Counterpart"
		End With
	End Sub

	Private Sub Lb_Generate_Click(sender As Object, e As EventArgs) Handles Lb_Generate.Click
		If Not Bg_LDAP.IsBusy Then
			startExec = DateTime.Now

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
			addManagerEmail = Ch_ManagerEmail.Checked
			addEmployeeID = Ch_EmpID.Checked
			addEmployeeEmail = Ch_EmpEmail.Checked

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
									If addEmployeeEmail Then .PropertiesToLoad.Add("mail")
									If addDisplayName Then .PropertiesToLoad.AddRange({"givenname", "sn"})
									If addManagerEmail Then .PropertiesToLoad.AddRange({"manager"})
								Case 2
									.Filter = "mail=" & strx
									If addEmployeeID Then .PropertiesToLoad.Add("employeeNumber")
									If addDisplayName Then .PropertiesToLoad.AddRange({"givenname", "sn"})
									If addManagerEmail Then .PropertiesToLoad.AddRange({"manager"})
								Case 3
									.Filter = "displayName=" & strx & "*"
									If addEmployeeID Then .PropertiesToLoad.Add("employeeNumber")
									If addEmployeeEmail Then .PropertiesToLoad.Add("mail")
									If addManagerEmail Then .PropertiesToLoad.AddRange({"manager"})
							End Select

							Dim resul As SearchResult = .FindOne
							If Not IsNothing(resul) Then
								Dim user As DirectoryEntry = resul.GetDirectoryEntry

								Dim sn As Object = user.Properties("sn").Value
								Dim givenName As Object = user.Properties("givenname").Value
								Dim manager As Object = user.Properties("manager").Value
								Dim empNumber As Object = user.Properties("employeeNumber").Value
								Dim mailObj As Object = user.Properties("mail").Value

								Dim displayName As String = "-"
								Dim managerEmail As String = "-"

								If addDisplayName Then displayName = IIf(sn Is Nothing, "-", sn).ToString & ", " & IIf(givenName Is Nothing, "-", givenName).ToString
								If addManagerEmail Then
									managerEmail = IIf(manager Is Nothing, "-", manager.ToString.Replace("\", "")).ToString
									managerEmail = IIf(managerEmail.Contains("@"), managerEmail.Substring(managerEmail.IndexOf("=") + 1, Convert.ToInt32(IIf(managerEmail.Contains("@"), managerEmail.IndexOf("@") - 4, managerEmail.IndexOf(",OU") - 3))), managerEmail).ToString
								End If

								Select Case byWhat '1=empnum,2=email,3=name
									Case 1
										outputLines.Add(
											IIf(empNumber Is Nothing, "-", empNumber).ToString &
											IIf(addEmployeeEmail, " | " & mailObj.ToString.ToLowerInvariant, "").ToString &
											IIf(addDisplayName, " | " & displayName, "").ToString &
											IIf(addManagerEmail, " | " & managerEmail, "").ToString
											)
									Case 2
										outputLines.Add(
											mailObj.ToString.ToLowerInvariant &
											IIf(addEmployeeID, " | " & IIf(empNumber Is Nothing, "-", empNumber).ToString, "").ToString &
											IIf(addDisplayName, " | " & displayName, "").ToString &
											IIf(addManagerEmail, " | " & managerEmail, "").ToString
											)
									Case 3
										outputLines.Add(
											displayName &
											IIf(addEmployeeID, " | " & IIf(empNumber Is Nothing, "-", empNumber).ToString, "").ToString &
											IIf(addEmployeeEmail, " | " & mailObj.ToString.ToLowerInvariant, "").ToString &
											IIf(addManagerEmail, " | " & managerEmail, "").ToString()
											)
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
		Dim timeCompleted As String = Microsoft.VisualBasic.Left(DateTime.Now.Subtract(startExec).ToString, 11)
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
