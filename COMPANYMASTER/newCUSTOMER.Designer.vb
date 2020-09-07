<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newCUSTOMER
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
        Me.opbal = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.opbalason = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.phone = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.ext = New System.Windows.Forms.Button
        Me.editt = New System.Windows.Forms.Button
        Me.addnew = New System.Windows.Forms.Button
        Me.address = New System.Windows.Forms.TextBox
        Me.ename = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.emps = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dr = New System.Windows.Forms.RadioButton
        Me.cr = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.opbal)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.opbalason)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.phone)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ext)
        Me.GroupBox1.Controls.Add(Me.editt)
        Me.GroupBox1.Controls.Add(Me.addnew)
        Me.GroupBox1.Controls.Add(Me.address)
        Me.GroupBox1.Controls.Add(Me.ename)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.emps)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(756, 433)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'opbal
        '
        Me.opbal.Location = New System.Drawing.Point(483, 204)
        Me.opbal.Name = "opbal"
        Me.opbal.ReadOnly = True
        Me.opbal.Size = New System.Drawing.Size(111, 20)
        Me.opbal.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(363, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Op.Balance Rs.:"
        '
        'opbalason
        '
        Me.opbalason.CustomFormat = "DD/MM/YYYY"
        Me.opbalason.Location = New System.Drawing.Point(512, 165)
        Me.opbalason.Name = "opbalason"
        Me.opbalason.Size = New System.Drawing.Size(223, 20)
        Me.opbalason.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(363, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Opening Balance As On :"
        '
        'phone
        '
        Me.phone.Location = New System.Drawing.Point(483, 123)
        Me.phone.Name = "phone"
        Me.phone.ReadOnly = True
        Me.phone.Size = New System.Drawing.Size(168, 20)
        Me.phone.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(363, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Phone No. :"
        '
        'ext
        '
        Me.ext.Location = New System.Drawing.Point(632, 389)
        Me.ext.Name = "ext"
        Me.ext.Size = New System.Drawing.Size(103, 29)
        Me.ext.TabIndex = 19
        Me.ext.Text = "E&xit"
        Me.ext.UseVisualStyleBackColor = True
        '
        'editt
        '
        Me.editt.Location = New System.Drawing.Point(150, 334)
        Me.editt.Name = "editt"
        Me.editt.Size = New System.Drawing.Size(181, 29)
        Me.editt.TabIndex = 18
        Me.editt.Text = "&Change Details"
        Me.editt.UseVisualStyleBackColor = True
        '
        'addnew
        '
        Me.addnew.Location = New System.Drawing.Point(144, 277)
        Me.addnew.Name = "addnew"
        Me.addnew.Size = New System.Drawing.Size(181, 29)
        Me.addnew.TabIndex = 17
        Me.addnew.Text = "&Add New Customer"
        Me.addnew.UseVisualStyleBackColor = True
        '
        'address
        '
        Me.address.Location = New System.Drawing.Point(483, 85)
        Me.address.Name = "address"
        Me.address.ReadOnly = True
        Me.address.Size = New System.Drawing.Size(267, 20)
        Me.address.TabIndex = 16
        '
        'ename
        '
        Me.ename.Location = New System.Drawing.Point(483, 50)
        Me.ename.Name = "ename"
        Me.ename.ReadOnly = True
        Me.ename.Size = New System.Drawing.Size(168, 20)
        Me.ename.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(363, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Address :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(363, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Customer Name :"
        '
        'emps
        '
        Me.emps.FormattingEnabled = True
        Me.emps.Location = New System.Drawing.Point(144, 53)
        Me.emps.Name = "emps"
        Me.emps.Size = New System.Drawing.Size(187, 199)
        Me.emps.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Existing Customers :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(363, 257)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Op.Balance Type :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dr)
        Me.GroupBox2.Controls.Add(Me.cr)
        Me.GroupBox2.Location = New System.Drawing.Point(483, 246)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(111, 100)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        '
        'dr
        '
        Me.dr.AutoSize = True
        Me.dr.Location = New System.Drawing.Point(21, 61)
        Me.dr.Name = "dr"
        Me.dr.Size = New System.Drawing.Size(55, 17)
        Me.dr.TabIndex = 1
        Me.dr.TabStop = True
        Me.dr.Text = "Debit"
        Me.dr.UseVisualStyleBackColor = True
        '
        'cr
        '
        Me.cr.AutoSize = True
        Me.cr.Location = New System.Drawing.Point(18, 28)
        Me.cr.Name = "cr"
        Me.cr.Size = New System.Drawing.Size(58, 17)
        Me.cr.TabIndex = 0
        Me.cr.TabStop = True
        Me.cr.Text = "Credit"
        Me.cr.UseVisualStyleBackColor = True
        '
        'newCUSTOMER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 446)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "newCUSTOMER"
        Me.Text = "ADD NEW CUSTOMER"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents opbalason As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents phone As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ext As System.Windows.Forms.Button
    Friend WithEvents editt As System.Windows.Forms.Button
    Friend WithEvents addnew As System.Windows.Forms.Button
    Friend WithEvents address As System.Windows.Forms.TextBox
    Friend WithEvents ename As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents emps As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents opbal As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dr As System.Windows.Forms.RadioButton
    Friend WithEvents cr As System.Windows.Forms.RadioButton
End Class
