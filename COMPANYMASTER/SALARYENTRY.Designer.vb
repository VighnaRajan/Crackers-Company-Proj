<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SALARYENTRY
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.fd = New System.Windows.Forms.DateTimePicker
        Me.td = New System.Windows.Forms.DateTimePicker
        Me.grid = New System.Windows.Forms.DataGridView
        Me.Button1 = New System.Windows.Forms.Button
        Me.jdate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.employee = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.job = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Timein = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Timeout = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.hrs = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.mins = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Salary = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.rb1 = New System.Windows.Forms.RadioButton
        Me.rb2 = New System.Windows.Forms.RadioButton
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.rb2)
        Me.GroupBox1.Controls.Add(Me.rb1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.grid)
        Me.GroupBox1.Controls.Add(Me.td)
        Me.GroupBox1.Controls.Add(Me.fd)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(892, 409)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "From :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "To :"
        '
        'fd
        '
        Me.fd.CustomFormat = "dd/MM/yyyy"
        Me.fd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fd.Location = New System.Drawing.Point(78, 16)
        Me.fd.Name = "fd"
        Me.fd.RightToLeftLayout = True
        Me.fd.Size = New System.Drawing.Size(101, 20)
        Me.fd.TabIndex = 2
        '
        'td
        '
        Me.td.CustomFormat = "dd/MM/yyyy"
        Me.td.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.td.Location = New System.Drawing.Point(78, 60)
        Me.td.Name = "td"
        Me.td.RightToLeftLayout = True
        Me.td.Size = New System.Drawing.Size(101, 20)
        Me.td.TabIndex = 3
        '
        'grid
        '
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.jdate, Me.employee, Me.job, Me.Timein, Me.Timeout, Me.hrs, Me.mins, Me.Salary})
        Me.grid.Location = New System.Drawing.Point(27, 109)
        Me.grid.Name = "grid"
        Me.grid.Size = New System.Drawing.Size(845, 249)
        Me.grid.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(469, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(198, 28)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Prepare Salary Sheet"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'jdate
        '
        Me.jdate.HeaderText = "Date"
        Me.jdate.Name = "jdate"
        '
        'employee
        '
        Me.employee.HeaderText = "EmployeeName"
        Me.employee.Name = "employee"
        '
        'job
        '
        Me.job.HeaderText = "Job"
        Me.job.Name = "job"
        '
        'Timein
        '
        Me.Timein.HeaderText = "TimeIn"
        Me.Timein.Name = "Timein"
        '
        'Timeout
        '
        Me.Timeout.HeaderText = "TimeOut"
        Me.Timeout.Name = "Timeout"
        '
        'hrs
        '
        Me.hrs.HeaderText = "Hours"
        Me.hrs.Name = "hrs"
        '
        'mins
        '
        Me.mins.HeaderText = "Minutes"
        Me.mins.Name = "mins"
        '
        'Salary
        '
        Me.Salary.HeaderText = "Salary"
        Me.Salary.Name = "Salary"
        '
        'rb1
        '
        Me.rb1.AutoSize = True
        Me.rb1.Location = New System.Drawing.Point(288, 23)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(84, 17)
        Me.rb1.TabIndex = 6
        Me.rb1.TabStop = True
        Me.rb1.Text = "Date-Wise"
        Me.rb1.UseVisualStyleBackColor = True
        '
        'rb2
        '
        Me.rb2.AutoSize = True
        Me.rb2.Checked = True
        Me.rb2.Location = New System.Drawing.Point(288, 62)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(111, 17)
        Me.rb2.TabIndex = 7
        Me.rb2.TabStop = True
        Me.rb2.Text = "Employee Wise"
        Me.rb2.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(327, 375)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(198, 28)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Upload Salary Information"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(784, 375)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 28)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'SALARYENTRY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 433)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "SALARYENTRY"
        Me.Text = "SALARY ENTRY"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents td As System.Windows.Forms.DateTimePicker
    Friend WithEvents fd As System.Windows.Forms.DateTimePicker
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents jdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents employee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents job As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Timein As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Timeout As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hrs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mins As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Salary As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rb2 As System.Windows.Forms.RadioButton
    Friend WithEvents rb1 As System.Windows.Forms.RadioButton
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
