<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uploadOPSTOCK
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
        Me.measure2 = New System.Windows.Forms.TextBox
        Me.measure1 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.items = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.addnew = New System.Windows.Forms.Button
        Me.doj = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.m2 = New System.Windows.Forms.Label
        Me.ext = New System.Windows.Forms.Button
        Me.m1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.measure2)
        Me.GroupBox1.Controls.Add(Me.measure1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.items)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.addnew)
        Me.GroupBox1.Controls.Add(Me.doj)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.m2)
        Me.GroupBox1.Controls.Add(Me.ext)
        Me.GroupBox1.Controls.Add(Me.m1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(504, 405)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'measure2
        '
        Me.measure2.Location = New System.Drawing.Point(168, 307)
        Me.measure2.Name = "measure2"
        Me.measure2.Size = New System.Drawing.Size(72, 20)
        Me.measure2.TabIndex = 32
        '
        'measure1
        '
        Me.measure1.Location = New System.Drawing.Point(168, 270)
        Me.measure1.Name = "measure1"
        Me.measure1.Size = New System.Drawing.Size(72, 20)
        Me.measure1.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 273)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Opening Stock :"
        '
        'items
        '
        Me.items.FormattingEnabled = True
        Me.items.Location = New System.Drawing.Point(163, 85)
        Me.items.Name = "items"
        Me.items.Size = New System.Drawing.Size(221, 173)
        Me.items.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Select Item :"
        '
        'addnew
        '
        Me.addnew.Enabled = False
        Me.addnew.Location = New System.Drawing.Point(163, 365)
        Me.addnew.Name = "addnew"
        Me.addnew.Size = New System.Drawing.Size(181, 29)
        Me.addnew.TabIndex = 24
        Me.addnew.Text = "Save"
        Me.addnew.UseVisualStyleBackColor = True
        '
        'doj
        '
        Me.doj.CustomFormat = "DD/MM/YYYY"
        Me.doj.Location = New System.Drawing.Point(161, 39)
        Me.doj.Name = "doj"
        Me.doj.Size = New System.Drawing.Size(223, 20)
        Me.doj.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "OP Balance as on:"
        '
        'm2
        '
        Me.m2.AutoSize = True
        Me.m2.Location = New System.Drawing.Point(255, 310)
        Me.m2.Name = "m2"
        Me.m2.Size = New System.Drawing.Size(23, 13)
        Me.m2.TabIndex = 20
        Me.m2.Text = "m2"
        '
        'ext
        '
        Me.ext.Location = New System.Drawing.Point(379, 365)
        Me.ext.Name = "ext"
        Me.ext.Size = New System.Drawing.Size(103, 29)
        Me.ext.TabIndex = 19
        Me.ext.Text = "E&xit"
        Me.ext.UseVisualStyleBackColor = True
        '
        'm1
        '
        Me.m1.AutoSize = True
        Me.m1.Location = New System.Drawing.Point(255, 277)
        Me.m1.Name = "m1"
        Me.m1.Size = New System.Drawing.Size(23, 13)
        Me.m1.TabIndex = 13
        Me.m1.Text = "m1"
        '
        'uploadOPSTOCK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 436)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "uploadOPSTOCK"
        Me.Text = "UPLOAD OPENING BALANCE :"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents items As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents addnew As System.Windows.Forms.Button
    Friend WithEvents doj As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents m2 As System.Windows.Forms.Label
    Friend WithEvents ext As System.Windows.Forms.Button
    Friend WithEvents m1 As System.Windows.Forms.Label
    Friend WithEvents measure1 As System.Windows.Forms.TextBox
    Friend WithEvents measure2 As System.Windows.Forms.TextBox
End Class
