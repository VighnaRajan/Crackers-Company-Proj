<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uploadEMPWORKHRS
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
        Me.timing = New System.Windows.Forms.ListBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.endd = New System.Windows.Forms.DateTimePicker
        Me.start = New System.Windows.Forms.DateTimePicker
        Me.jobs = New System.Windows.Forms.ListBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.emps = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.addnew = New System.Windows.Forms.Button
        Me.doj = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ext = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.timing)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.endd)
        Me.GroupBox1.Controls.Add(Me.start)
        Me.GroupBox1.Controls.Add(Me.jobs)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.emps)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.addnew)
        Me.GroupBox1.Controls.Add(Me.doj)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ext)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(833, 405)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'timing
        '
        Me.timing.FormattingEnabled = True
        Me.timing.Location = New System.Drawing.Point(580, 186)
        Me.timing.Name = "timing"
        Me.timing.Size = New System.Drawing.Size(155, 108)
        Me.timing.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(490, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Timings :"
        '
        'endd
        '
        Me.endd.CustomFormat = "HH:mm:ss"
        Me.endd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.endd.Location = New System.Drawing.Point(577, 135)
        Me.endd.Name = "endd"
        Me.endd.Size = New System.Drawing.Size(101, 20)
        Me.endd.TabIndex = 30
        '
        'start
        '
        Me.start.CustomFormat = "HH:mm:ss"
        Me.start.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.start.Location = New System.Drawing.Point(577, 91)
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(101, 20)
        Me.start.TabIndex = 29
        '
        'jobs
        '
        Me.jobs.FormattingEnabled = True
        Me.jobs.Location = New System.Drawing.Point(165, 273)
        Me.jobs.Name = "jobs"
        Me.jobs.Size = New System.Drawing.Size(218, 108)
        Me.jobs.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 288)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Select Job Nature :"
        '
        'emps
        '
        Me.emps.FormattingEnabled = True
        Me.emps.Location = New System.Drawing.Point(163, 98)
        Me.emps.Name = "emps"
        Me.emps.Size = New System.Drawing.Size(221, 160)
        Me.emps.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Select Employee :"
        '
        'addnew
        '
        Me.addnew.Enabled = False
        Me.addnew.Location = New System.Drawing.Point(528, 356)
        Me.addnew.Name = "addnew"
        Me.addnew.Size = New System.Drawing.Size(181, 29)
        Me.addnew.TabIndex = 24
        Me.addnew.Text = "Save Timing"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(461, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Closing Time :"
        '
        'ext
        '
        Me.ext.Location = New System.Drawing.Point(724, 356)
        Me.ext.Name = "ext"
        Me.ext.Size = New System.Drawing.Size(103, 29)
        Me.ext.TabIndex = 19
        Me.ext.Text = "E&xit"
        Me.ext.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(461, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Starting Time :"
        '
        'uploadEMPWORKHRS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 457)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "uploadEMPWORKHRS"
        Me.Text = "UPLOADING EMPLOYEE WORKING HOURS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents addnew As System.Windows.Forms.Button
    Friend WithEvents doj As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ext As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents emps As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents jobs As System.Windows.Forms.ListBox
    Friend WithEvents endd As System.Windows.Forms.DateTimePicker
    Friend WithEvents start As System.Windows.Forms.DateTimePicker
    Friend WithEvents timing As System.Windows.Forms.ListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
