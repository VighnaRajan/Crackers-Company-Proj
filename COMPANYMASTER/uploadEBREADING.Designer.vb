<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uploadEBREADING
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
        Me.addnew = New System.Windows.Forms.Button
        Me.doj = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.endd = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.ext = New System.Windows.Forms.Button
        Me.start = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.addnew)
        Me.GroupBox1.Controls.Add(Me.doj)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.endd)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ext)
        Me.GroupBox1.Controls.Add(Me.start)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(410, 263)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'addnew
        '
        Me.addnew.Enabled = False
        Me.addnew.Location = New System.Drawing.Point(46, 213)
        Me.addnew.Name = "addnew"
        Me.addnew.Size = New System.Drawing.Size(181, 29)
        Me.addnew.TabIndex = 24
        Me.addnew.Text = "Save Reading"
        Me.addnew.UseVisualStyleBackColor = True
        '
        'doj
        '
        Me.doj.CustomFormat = "DD/MM/YYYY"
        Me.doj.Location = New System.Drawing.Point(161, 46)
        Me.doj.Name = "doj"
        Me.doj.Size = New System.Drawing.Size(223, 20)
        Me.doj.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Date of Reading  :"
        '
        'endd
        '
        Me.endd.Location = New System.Drawing.Point(161, 134)
        Me.endd.Name = "endd"
        Me.endd.ReadOnly = True
        Me.endd.Size = New System.Drawing.Size(168, 20)
        Me.endd.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Closing Reading :"
        '
        'ext
        '
        Me.ext.Location = New System.Drawing.Point(281, 213)
        Me.ext.Name = "ext"
        Me.ext.Size = New System.Drawing.Size(103, 29)
        Me.ext.TabIndex = 19
        Me.ext.Text = "E&xit"
        Me.ext.UseVisualStyleBackColor = True
        '
        'start
        '
        Me.start.Location = New System.Drawing.Point(161, 90)
        Me.start.Name = "start"
        Me.start.ReadOnly = True
        Me.start.Size = New System.Drawing.Size(168, 20)
        Me.start.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Starting Reading :"
        '
        'uploadEBREADING
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 280)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "uploadEBREADING"
        Me.Text = "UPLOAD EB READING"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents doj As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents endd As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ext As System.Windows.Forms.Button
    Friend WithEvents start As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents addnew As System.Windows.Forms.Button
End Class
