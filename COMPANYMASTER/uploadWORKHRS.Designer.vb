<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uploadWORKHRS
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.extract = New System.Windows.Forms.Button
        Me.dgrid = New System.Windows.Forms.DataGridView
        Me.EmployeeName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Job = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.TimeIn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TimeOut = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.emps = New System.Windows.Forms.CheckedListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.doj = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.extract)
        Me.GroupBox1.Controls.Add(Me.dgrid)
        Me.GroupBox1.Controls.Add(Me.emps)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.doj)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(630, 540)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(228, 496)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 29)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Upload"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'extract
        '
        Me.extract.Location = New System.Drawing.Point(180, 275)
        Me.extract.Name = "extract"
        Me.extract.Size = New System.Drawing.Size(149, 30)
        Me.extract.TabIndex = 31
        Me.extract.Text = "Extract"
        Me.extract.UseVisualStyleBackColor = True
        '
        'dgrid
        '
        Me.dgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeName, Me.Job, Me.TimeIn, Me.TimeOut})
        Me.dgrid.Location = New System.Drawing.Point(146, 311)
        Me.dgrid.Name = "dgrid"
        Me.dgrid.Size = New System.Drawing.Size(462, 157)
        Me.dgrid.TabIndex = 30
        '
        'EmployeeName
        '
        Me.EmployeeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.EmployeeName.HeaderText = "EmployeeName"
        Me.EmployeeName.Name = "EmployeeName"
        Me.EmployeeName.Width = 118
        '
        'Job
        '
        Me.Job.HeaderText = "Job"
        Me.Job.Name = "Job"
        '
        'TimeIn
        '
        DataGridViewCellStyle7.Format = "t"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.TimeIn.DefaultCellStyle = DataGridViewCellStyle7
        Me.TimeIn.HeaderText = "TimeIn"
        Me.TimeIn.MaxInputLength = 8
        Me.TimeIn.Name = "TimeIn"
        '
        'TimeOut
        '
        DataGridViewCellStyle8.Format = "t"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.TimeOut.DefaultCellStyle = DataGridViewCellStyle8
        Me.TimeOut.HeaderText = "TimeOut"
        Me.TimeOut.MaxInputLength = 8
        Me.TimeOut.Name = "TimeOut"
        '
        'emps
        '
        Me.emps.FormattingEnabled = True
        Me.emps.Location = New System.Drawing.Point(149, 75)
        Me.emps.Name = "emps"
        Me.emps.Size = New System.Drawing.Size(219, 184)
        Me.emps.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Select Employees :"
        '
        'doj
        '
        Me.doj.CustomFormat = "DD/MM/YYYY"
        Me.doj.Location = New System.Drawing.Point(146, 30)
        Me.doj.Name = "doj"
        Me.doj.Size = New System.Drawing.Size(223, 20)
        Me.doj.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 17)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Date of Job :"
        Me.Label5.UseCompatibleTextRendering = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(542, 496)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 33)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 311)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Working Hours :"
        '
        'uploadWORKHRS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 560)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "uploadWORKHRS"
        Me.Text = "UPLOAD EMPLOYEE WORKING HOURS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents emps As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents doj As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgrid As System.Windows.Forms.DataGridView
    Friend WithEvents extract As System.Windows.Forms.Button
    Friend WithEvents EmployeeName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Job As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents TimeIn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeOut As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
