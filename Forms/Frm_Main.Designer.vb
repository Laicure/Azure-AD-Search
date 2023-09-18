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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Tx_Input = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Tx_Output = New System.Windows.Forms.TextBox()
        Me.Lb_Generate = New System.Windows.Forms.Label()
        Me.Bg_LDAP = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Lb_Generate)
        Me.GroupBox1.Controls.Add(Me.Tx_Input)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(1, 1)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 459)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input - Emp ID or Email per line"
        '
        'Tx_Input
        '
        Me.Tx_Input.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tx_Input.BackColor = System.Drawing.Color.White
        Me.Tx_Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tx_Input.ForeColor = System.Drawing.Color.Black
        Me.Tx_Input.Location = New System.Drawing.Point(3, 19)
        Me.Tx_Input.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Tx_Input.MaxLength = 0
        Me.Tx_Input.Multiline = True
        Me.Tx_Input.Name = "Tx_Input"
        Me.Tx_Input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Tx_Input.Size = New System.Drawing.Size(294, 413)
        Me.Tx_Input.TabIndex = 1
        Me.Tx_Input.TabStop = False
        Me.Tx_Input.WordWrap = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Tx_Output)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(302, 1)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(381, 459)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Output"
        '
        'Tx_Output
        '
        Me.Tx_Output.BackColor = System.Drawing.Color.White
        Me.Tx_Output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tx_Output.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tx_Output.ForeColor = System.Drawing.Color.Black
        Me.Tx_Output.Location = New System.Drawing.Point(3, 19)
        Me.Tx_Output.MaxLength = 0
        Me.Tx_Output.Multiline = True
        Me.Tx_Output.Name = "Tx_Output"
        Me.Tx_Output.ReadOnly = True
        Me.Tx_Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Tx_Output.Size = New System.Drawing.Size(375, 437)
        Me.Tx_Output.TabIndex = 2
        Me.Tx_Output.TabStop = False
        Me.Tx_Output.WordWrap = False
        '
        'Lb_Generate
        '
        Me.Lb_Generate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lb_Generate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lb_Generate.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Lb_Generate.Enabled = False
        Me.Lb_Generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lb_Generate.ForeColor = System.Drawing.Color.Blue
        Me.Lb_Generate.Location = New System.Drawing.Point(3, 433)
        Me.Lb_Generate.Margin = New System.Windows.Forms.Padding(0)
        Me.Lb_Generate.Name = "Lb_Generate"
        Me.Lb_Generate.Size = New System.Drawing.Size(294, 23)
        Me.Lb_Generate.TabIndex = 3
        Me.Lb_Generate.Text = "Search Counterpart"
        Me.Lb_Generate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Bg_LDAP
        '
        '
        'Frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 461)
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
    Friend WithEvents Tx_Output As TextBox
    Friend WithEvents Lb_Generate As Label
    Friend WithEvents Bg_LDAP As System.ComponentModel.BackgroundWorker
End Class
