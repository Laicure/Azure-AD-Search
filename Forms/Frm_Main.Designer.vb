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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Main))
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Tx_Input = New System.Windows.Forms.TextBox()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.Ch_DisplayName = New System.Windows.Forms.CheckBox()
		Me.Tx_EmpNumEmail = New System.Windows.Forms.TextBox()
		Me.Bg_LDAP = New System.ComponentModel.BackgroundWorker()
		Me.Lb_Generate = New System.Windows.Forms.Label()
		Me.Tipper = New System.Windows.Forms.ToolTip(Me.components)
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
		Me.GroupBox1.Size = New System.Drawing.Size(300, 432)
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
		Me.Tx_Input.Size = New System.Drawing.Size(294, 410)
		Me.Tx_Input.TabIndex = 1
		Me.Tx_Input.TabStop = False
		Me.Tipper.SetToolTip(Me.Tx_Input, resources.GetString("Tx_Input.ToolTip"))
		Me.Tx_Input.WordWrap = False
		'
		'GroupBox2
		'
		Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GroupBox2.Controls.Add(Me.Ch_DisplayName)
		Me.GroupBox2.Controls.Add(Me.Tx_EmpNumEmail)
		Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.GroupBox2.Location = New System.Drawing.Point(302, 1)
		Me.GroupBox2.Margin = New System.Windows.Forms.Padding(0)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(381, 432)
		Me.GroupBox2.TabIndex = 1
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Output: Emp ID/Email"
		'
		'Ch_DisplayName
		'
		Me.Ch_DisplayName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Ch_DisplayName.Location = New System.Drawing.Point(248, 0)
		Me.Ch_DisplayName.Margin = New System.Windows.Forms.Padding(0)
		Me.Ch_DisplayName.Name = "Ch_DisplayName"
		Me.Ch_DisplayName.Size = New System.Drawing.Size(130, 19)
		Me.Ch_DisplayName.TabIndex = 3
		Me.Ch_DisplayName.TabStop = False
		Me.Ch_DisplayName.Text = "Add DisplayName"
		Me.Ch_DisplayName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Ch_DisplayName.UseVisualStyleBackColor = True
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
		Me.Tx_EmpNumEmail.Size = New System.Drawing.Size(375, 410)
		Me.Tx_EmpNumEmail.TabIndex = 2
		Me.Tx_EmpNumEmail.TabStop = False
		Me.Tx_EmpNumEmail.WordWrap = False
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
		Me.Lb_Generate.Location = New System.Drawing.Point(1, 437)
		Me.Lb_Generate.Margin = New System.Windows.Forms.Padding(0)
		Me.Lb_Generate.Name = "Lb_Generate"
		Me.Lb_Generate.Size = New System.Drawing.Size(682, 23)
		Me.Lb_Generate.TabIndex = 5
		Me.Lb_Generate.Text = "Search Counterpart"
		Me.Lb_Generate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Tipper
		'
		Me.Tipper.AutomaticDelay = 250
		Me.Tipper.AutoPopDelay = 7777
		Me.Tipper.BackColor = System.Drawing.Color.White
		Me.Tipper.ForeColor = System.Drawing.Color.Black
		Me.Tipper.InitialDelay = 250
		Me.Tipper.IsBalloon = True
		Me.Tipper.ReshowDelay = 250
		Me.Tipper.UseAnimation = False
		Me.Tipper.UseFading = False
		'
		'Frm_Main
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(684, 461)
		Me.Controls.Add(Me.Lb_Generate)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.DoubleBuffered = True
		Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ForeColor = System.Drawing.Color.Black
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.MaximizeBox = False
		Me.MaximumSize = New System.Drawing.Size(700, 500)
		Me.MinimumSize = New System.Drawing.Size(700, 500)
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
    Friend WithEvents Tipper As ToolTip
    Friend WithEvents Ch_DisplayName As CheckBox
End Class
