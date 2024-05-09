<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Main
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Main))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Tx_Input = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Tx_EmpNumEmail = New System.Windows.Forms.TextBox()
        Me.Ch_DisplayName = New System.Windows.Forms.CheckBox()
        Me.Bg_LDAP = New System.ComponentModel.BackgroundWorker()
        Me.Lb_Generate = New System.Windows.Forms.Label()
        Me.Ch_ManagerEmail = New System.Windows.Forms.CheckBox()
        Me.Ch_EmpID = New System.Windows.Forms.CheckBox()
        Me.Ch_EmpEmail = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Tx_Input)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(1, 1)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(275, 486)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input: Emp ID/Email or Display Name"
        '
        'Tx_Input
        '
        Me.Tx_Input.BackColor = System.Drawing.Color.White
        Me.Tx_Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tx_Input.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tx_Input.ForeColor = System.Drawing.Color.Black
        Me.Tx_Input.Location = New System.Drawing.Point(3, 19)
        Me.Tx_Input.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Tx_Input.MaxLength = 0
        Me.Tx_Input.Multiline = True
        Me.Tx_Input.Name = "Tx_Input"
        Me.Tx_Input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Tx_Input.Size = New System.Drawing.Size(269, 464)
        Me.Tx_Input.TabIndex = 1
        Me.Tx_Input.TabStop = False
        Me.Tx_Input.Text = resources.GetString("Tx_Input.Text")
        Me.Tx_Input.WordWrap = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Tx_EmpNumEmail)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(277, 1)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(506, 462)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Output"
        '
        'Tx_EmpNumEmail
        '
        Me.Tx_EmpNumEmail.BackColor = System.Drawing.Color.White
        Me.Tx_EmpNumEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tx_EmpNumEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tx_EmpNumEmail.ForeColor = System.Drawing.Color.Black
        Me.Tx_EmpNumEmail.Location = New System.Drawing.Point(3, 19)
        Me.Tx_EmpNumEmail.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Tx_EmpNumEmail.MaxLength = 0
        Me.Tx_EmpNumEmail.Multiline = True
        Me.Tx_EmpNumEmail.Name = "Tx_EmpNumEmail"
        Me.Tx_EmpNumEmail.ReadOnly = True
        Me.Tx_EmpNumEmail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Tx_EmpNumEmail.Size = New System.Drawing.Size(500, 440)
        Me.Tx_EmpNumEmail.TabIndex = 2
        Me.Tx_EmpNumEmail.TabStop = False
        Me.Tx_EmpNumEmail.WordWrap = False
        '
        'Ch_DisplayName
        '
        Me.Ch_DisplayName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ch_DisplayName.Location = New System.Drawing.Point(433, 463)
        Me.Ch_DisplayName.Margin = New System.Windows.Forms.Padding(0)
        Me.Ch_DisplayName.Name = "Ch_DisplayName"
        Me.Ch_DisplayName.Size = New System.Drawing.Size(100, 23)
        Me.Ch_DisplayName.TabIndex = 3
        Me.Ch_DisplayName.TabStop = False
        Me.Ch_DisplayName.Text = "DisplayName"
        Me.Ch_DisplayName.UseVisualStyleBackColor = True
        '
        'Bg_LDAP
        '
        '
        'Lb_Generate
        '
        Me.Lb_Generate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lb_Generate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lb_Generate.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Lb_Generate.Enabled = False
        Me.Lb_Generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lb_Generate.ForeColor = System.Drawing.Color.Blue
        Me.Lb_Generate.Location = New System.Drawing.Point(1, 487)
        Me.Lb_Generate.Margin = New System.Windows.Forms.Padding(0)
        Me.Lb_Generate.Name = "Lb_Generate"
        Me.Lb_Generate.Size = New System.Drawing.Size(782, 23)
        Me.Lb_Generate.TabIndex = 5
        Me.Lb_Generate.Text = "Search Counterpart"
        Me.Lb_Generate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Ch_ManagerEmail
        '
        Me.Ch_ManagerEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ch_ManagerEmail.Location = New System.Drawing.Point(533, 463)
        Me.Ch_ManagerEmail.Margin = New System.Windows.Forms.Padding(0)
        Me.Ch_ManagerEmail.Name = "Ch_ManagerEmail"
        Me.Ch_ManagerEmail.Size = New System.Drawing.Size(115, 23)
        Me.Ch_ManagerEmail.TabIndex = 6
        Me.Ch_ManagerEmail.TabStop = False
        Me.Ch_ManagerEmail.Text = "Manager Email"
        Me.Ch_ManagerEmail.UseVisualStyleBackColor = True
        '
        'Ch_EmpID
        '
        Me.Ch_EmpID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ch_EmpID.Location = New System.Drawing.Point(368, 463)
        Me.Ch_EmpID.Margin = New System.Windows.Forms.Padding(0)
        Me.Ch_EmpID.Name = "Ch_EmpID"
        Me.Ch_EmpID.Size = New System.Drawing.Size(65, 23)
        Me.Ch_EmpID.TabIndex = 7
        Me.Ch_EmpID.TabStop = False
        Me.Ch_EmpID.Text = "Emp ID"
        Me.Ch_EmpID.UseVisualStyleBackColor = True
        '
        'Ch_EmpEmail
        '
        Me.Ch_EmpEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ch_EmpEmail.Location = New System.Drawing.Point(278, 463)
        Me.Ch_EmpEmail.Margin = New System.Windows.Forms.Padding(0)
        Me.Ch_EmpEmail.Name = "Ch_EmpEmail"
        Me.Ch_EmpEmail.Size = New System.Drawing.Size(90, 23)
        Me.Ch_EmpEmail.TabIndex = 8
        Me.Ch_EmpEmail.TabStop = False
        Me.Ch_EmpEmail.Text = "Emp Email"
        Me.Ch_EmpEmail.UseVisualStyleBackColor = True
        '
        'Frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 511)
        Me.Controls.Add(Me.Ch_EmpEmail)
        Me.Controls.Add(Me.Ch_EmpID)
        Me.Controls.Add(Me.Ch_ManagerEmail)
        Me.Controls.Add(Me.Ch_DisplayName)
        Me.Controls.Add(Me.Lb_Generate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 550)
        Me.MinimumSize = New System.Drawing.Size(800, 550)
        Me.Name = "Frm_Main"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Main"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Tx_Input As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Tx_EmpNumEmail As TextBox
    Friend WithEvents Bg_LDAP As System.ComponentModel.BackgroundWorker
    Friend WithEvents Lb_Generate As Label
    Friend WithEvents Ch_DisplayName As CheckBox
    Friend WithEvents Ch_ManagerEmail As CheckBox
    Friend WithEvents Ch_EmpID As CheckBox
    Friend WithEvents Ch_EmpEmail As CheckBox
End Class
