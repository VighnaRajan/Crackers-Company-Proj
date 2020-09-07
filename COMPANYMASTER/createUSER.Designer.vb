<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class createUSER
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ext = New System.Windows.Forms.Button
        Me.editt = New System.Windows.Forms.Button
        Me.addnew = New System.Windows.Forms.Button
        Me.password = New System.Windows.Forms.TextBox
        Me.username = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.users = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.password1 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.password1)
        Me.GroupBox1.Controls.Add(Me.ext)
        Me.GroupBox1.Controls.Add(Me.editt)
        Me.GroupBox1.Controls.Add(Me.addnew)
        Me.GroupBox1.Controls.Add(Me.password)
        Me.GroupBox1.Controls.Add(Me.username)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.users)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(621, 433)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ext
        '
        Me.ext.Location = New System.Drawing.Point(479, 358)
        Me.ext.Name = "ext"
        Me.ext.Size = New System.Drawing.Size(88, 29)
        Me.ext.TabIndex = 19
        Me.ext.Text = "E&xit"
        Me.ext.UseVisualStyleBackColor = True
        '
        'editt
        '
        Me.editt.Location = New System.Drawing.Point(170, 325)
        Me.editt.Name = "editt"
        Me.editt.Size = New System.Drawing.Size(155, 29)
        Me.editt.TabIndex = 18
        Me.editt.Text = "&Change Password"
        Me.editt.UseVisualStyleBackColor = True
        '
        'addnew
        '
        Me.addnew.Location = New System.Drawing.Point(170, 277)
        Me.addnew.Name = "addnew"
        Me.addnew.Size = New System.Drawing.Size(155, 29)
        Me.addnew.TabIndex = 17
        Me.addnew.Text = "&Add New User"
        Me.addnew.UseVisualStyleBackColor = True
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(469, 85)
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password.ReadOnly = True
        Me.password.Size = New System.Drawing.Size(140, 20)
        Me.password.TabIndex = 16
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(469, 46)
        Me.username.Name = "username"
        Me.username.ReadOnly = True
        Me.username.Size = New System.Drawing.Size(90, 20)
        Me.username.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(350, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Password :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(350, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "User Name :"
        '
        'users
        '
        Me.users.FormattingEnabled = True
        Me.users.Location = New System.Drawing.Point(171, 53)
        Me.users.Name = "users"
        Me.users.Size = New System.Drawing.Size(161, 199)
        Me.users.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Existing Users :"
        '
        'password1
        '
        Me.password1.Location = New System.Drawing.Point(469, 127)
        Me.password1.Name = "password1"
        Me.password1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password1.ReadOnly = True
        Me.password1.Size = New System.Drawing.Size(140, 20)
        Me.password1.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(350, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Retype Password :"
        '
        'createUSER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 443)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "createUSER"
        Me.Text = "Create New User"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ext As System.Windows.Forms.Button
    Friend WithEvents editt As System.Windows.Forms.Button
    Friend WithEvents addnew As System.Windows.Forms.Button
    Friend WithEvents password As System.Windows.Forms.TextBox
    Friend WithEvents username As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents users As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents password1 As System.Windows.Forms.TextBox
End Class
