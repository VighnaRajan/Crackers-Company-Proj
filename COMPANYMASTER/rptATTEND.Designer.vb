<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptATTEND
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
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.td = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.fd = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.rv = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.ATTEND1 = New COMPANYMASTER.ATTEND
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rv)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.td)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.fd)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(995, 608)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(54, 200)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 39)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(45, 135)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 41)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "View EB Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'td
        '
        Me.td.CustomFormat = "dd/MM/yyyy"
        Me.td.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.td.Location = New System.Drawing.Point(102, 85)
        Me.td.Name = "td"
        Me.td.Size = New System.Drawing.Size(98, 20)
        Me.td.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "To Date :"
        '
        'fd
        '
        Me.fd.CustomFormat = "dd/MM/yyyy"
        Me.fd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fd.Location = New System.Drawing.Point(102, 36)
        Me.fd.Name = "fd"
        Me.fd.Size = New System.Drawing.Size(98, 20)
        Me.fd.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "From Date :"
        '
        'rv
        '
        Me.rv.ActiveViewIndex = 0
        Me.rv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rv.DisplayGroupTree = False
        Me.rv.Location = New System.Drawing.Point(218, 17)
        Me.rv.Name = "rv"
        Me.rv.ReportSource = Me.ATTEND1
        Me.rv.Size = New System.Drawing.Size(771, 585)
        Me.rv.TabIndex = 12
        '
        'rptATTEND
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 627)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "rptATTEND"
        Me.Text = "ATTENDANCE REPORT"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents td As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ATTEND1 As COMPANYMASTER.ATTEND
End Class
