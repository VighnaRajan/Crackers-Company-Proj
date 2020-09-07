<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class createJOB
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
        Me.hourlypay = New System.Windows.Forms.TextBox
        Me.jobname = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.jobs = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cb = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cb)
        Me.GroupBox1.Controls.Add(Me.ext)
        Me.GroupBox1.Controls.Add(Me.editt)
        Me.GroupBox1.Controls.Add(Me.addnew)
        Me.GroupBox1.Controls.Add(Me.hourlypay)
        Me.GroupBox1.Controls.Add(Me.jobname)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.jobs)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(621, 433)
        Me.GroupBox1.TabIndex = 1
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
        Me.editt.Text = "&Change Salary"
        Me.editt.UseVisualStyleBackColor = True
        '
        'addnew
        '
        Me.addnew.Location = New System.Drawing.Point(170, 277)
        Me.addnew.Name = "addnew"
        Me.addnew.Size = New System.Drawing.Size(155, 29)
        Me.addnew.TabIndex = 17
        Me.addnew.Text = "&Add New Job"
        Me.addnew.UseVisualStyleBackColor = True
        '
        'hourlypay
        '
        Me.hourlypay.Location = New System.Drawing.Point(469, 85)
        Me.hourlypay.Name = "hourlypay"
        Me.hourlypay.ReadOnly = True
        Me.hourlypay.Size = New System.Drawing.Size(61, 20)
        Me.hourlypay.TabIndex = 16
        '
        'jobname
        '
        Me.jobname.Location = New System.Drawing.Point(469, 46)
        Me.jobname.Name = "jobname"
        Me.jobname.ReadOnly = True
        Me.jobname.Size = New System.Drawing.Size(145, 20)
        Me.jobname.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(350, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Hourly Pay : Rs."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(350, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Job Name :"
        '
        'jobs
        '
        Me.jobs.FormattingEnabled = True
        Me.jobs.Location = New System.Drawing.Point(171, 53)
        Me.jobs.Name = "jobs"
        Me.jobs.Size = New System.Drawing.Size(161, 199)
        Me.jobs.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Existing Jobs :"
        '
        'cb
        '
        Me.cb.AutoSize = True
        Me.cb.Location = New System.Drawing.Point(369, 139)
        Me.cb.Name = "cb"
        Me.cb.Size = New System.Drawing.Size(231, 17)
        Me.cb.TabIndex = 20
        Me.cb.Text = "This Job Creates a Finished Product"
        Me.cb.UseVisualStyleBackColor = True
        '
        'createJOB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 441)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "createJOB"
        Me.Text = "Create New Job"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ext As System.Windows.Forms.Button
    Friend WithEvents editt As System.Windows.Forms.Button
    Friend WithEvents addnew As System.Windows.Forms.Button
    Friend WithEvents hourlypay As System.Windows.Forms.TextBox
    Friend WithEvents jobname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents jobs As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cb As System.Windows.Forms.CheckBox
End Class
