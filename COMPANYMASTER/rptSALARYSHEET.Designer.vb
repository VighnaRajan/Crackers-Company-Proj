<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptSALARYSHEET
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
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rb2 = New System.Windows.Forms.RadioButton
        Me.rb1 = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.td = New System.Windows.Forms.DateTimePicker
        Me.fd = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SALARYREPORT1 = New COMPANYMASTER.SALARYREPORT
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CrystalReportViewer1)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1260, 684)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(47, 287)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 28)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(20, 235)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(156, 28)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Print Salary Sheet"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rb2)
        Me.GroupBox2.Controls.Add(Me.rb1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 115)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(175, 105)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        '
        'rb2
        '
        Me.rb2.AutoSize = True
        Me.rb2.Checked = True
        Me.rb2.Location = New System.Drawing.Point(32, 60)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(111, 17)
        Me.rb2.TabIndex = 9
        Me.rb2.TabStop = True
        Me.rb2.Text = "Employee Wise"
        Me.rb2.UseVisualStyleBackColor = True
        '
        'rb1
        '
        Me.rb1.AutoSize = True
        Me.rb1.Location = New System.Drawing.Point(32, 19)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(84, 17)
        Me.rb1.TabIndex = 8
        Me.rb1.Text = "Date-Wise"
        Me.rb1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.td)
        Me.GroupBox3.Controls.Add(Me.fd)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(4, 10)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(175, 99)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        '
        'td
        '
        Me.td.CustomFormat = "dd/MM/yyyy"
        Me.td.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.td.Location = New System.Drawing.Point(61, 61)
        Me.td.Name = "td"
        Me.td.RightToLeftLayout = True
        Me.td.Size = New System.Drawing.Size(101, 20)
        Me.td.TabIndex = 7
        '
        'fd
        '
        Me.fd.CustomFormat = "dd/MM/yyyy"
        Me.fd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fd.Location = New System.Drawing.Point(61, 17)
        Me.fd.Name = "fd"
        Me.fd.RightToLeftLayout = True
        Me.fd.Size = New System.Drawing.Size(101, 20)
        Me.fd.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "To :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "From :"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(197, 20)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.SALARYREPORT1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1057, 658)
        Me.CrystalReportViewer1.TabIndex = 12
        '
        'rptSALARYSHEET
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 698)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "rptSALARYSHEET"
        Me.Text = "SALARY SHEET PRINTING"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents td As System.Windows.Forms.DateTimePicker
    Friend WithEvents fd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rb2 As System.Windows.Forms.RadioButton
    Friend WithEvents rb1 As System.Windows.Forms.RadioButton
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SALARYREPORT1 As COMPANYMASTER.SALARYREPORT
End Class
