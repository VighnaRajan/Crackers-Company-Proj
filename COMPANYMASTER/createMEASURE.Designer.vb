<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class createMEASURE
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
        Me.measure = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ext)
        Me.GroupBox1.Controls.Add(Me.editt)
        Me.GroupBox1.Controls.Add(Me.addnew)
        Me.GroupBox1.Controls.Add(Me.measure)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(511, 395)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ext
        '
        Me.ext.Location = New System.Drawing.Point(242, 329)
        Me.ext.Name = "ext"
        Me.ext.Size = New System.Drawing.Size(88, 29)
        Me.ext.TabIndex = 15
        Me.ext.Text = "E&xit"
        Me.ext.UseVisualStyleBackColor = True
        '
        'editt
        '
        Me.editt.Location = New System.Drawing.Point(304, 257)
        Me.editt.Name = "editt"
        Me.editt.Size = New System.Drawing.Size(88, 29)
        Me.editt.TabIndex = 14
        Me.editt.Text = "&Edit"
        Me.editt.UseVisualStyleBackColor = True
        '
        'addnew
        '
        Me.addnew.Location = New System.Drawing.Point(182, 257)
        Me.addnew.Name = "addnew"
        Me.addnew.Size = New System.Drawing.Size(88, 29)
        Me.addnew.TabIndex = 13
        Me.addnew.Text = "&Add New"
        Me.addnew.UseVisualStyleBackColor = True
        '
        'measure
        '
        Me.measure.FormattingEnabled = True
        Me.measure.Location = New System.Drawing.Point(183, 33)
        Me.measure.Name = "measure"
        Me.measure.Size = New System.Drawing.Size(161, 199)
        Me.measure.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Existing Measurements :"
        '
        'createMEASURE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 411)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "createMEASURE"
        Me.Text = "ADD NEW MEASUREMENT"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ext As System.Windows.Forms.Button
    Friend WithEvents editt As System.Windows.Forms.Button
    Friend WithEvents addnew As System.Windows.Forms.Button
    Friend WithEvents measure As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
