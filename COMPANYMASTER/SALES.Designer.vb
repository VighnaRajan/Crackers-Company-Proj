<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SALES
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
        Me.bno = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.addr = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.oldm2 = New System.Windows.Forms.Label
        Me.oldm1 = New System.Windows.Forms.Label
        Me.oldstk2 = New System.Windows.Forms.TextBox
        Me.oldstk1 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.rate = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.suppliers = New System.Windows.Forms.ListBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.m2 = New System.Windows.Forms.Label
        Me.m1 = New System.Windows.Forms.Label
        Me.q2 = New System.Windows.Forms.TextBox
        Me.q1 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.itms = New System.Windows.Forms.ListBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dop = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bno)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.addr)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.oldm2)
        Me.GroupBox1.Controls.Add(Me.oldm1)
        Me.GroupBox1.Controls.Add(Me.oldstk2)
        Me.GroupBox1.Controls.Add(Me.oldstk1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.rate)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.suppliers)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.m2)
        Me.GroupBox1.Controls.Add(Me.m1)
        Me.GroupBox1.Controls.Add(Me.q2)
        Me.GroupBox1.Controls.Add(Me.q1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.itms)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dop)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(825, 455)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sales Entry"
        '
        'bno
        '
        Me.bno.Location = New System.Drawing.Point(168, 64)
        Me.bno.Name = "bno"
        Me.bno.Size = New System.Drawing.Size(75, 20)
        Me.bno.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(56, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Bill Number :"
        '
        'addr
        '
        Me.addr.AutoSize = True
        Me.addr.ForeColor = System.Drawing.Color.Blue
        Me.addr.Location = New System.Drawing.Point(499, 257)
        Me.addr.Name = "addr"
        Me.addr.Size = New System.Drawing.Size(28, 13)
        Me.addr.TabIndex = 23
        Me.addr.Text = "___"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(382, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Address && Phone :"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(710, 419)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 30)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(534, 419)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 30)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'oldm2
        '
        Me.oldm2.AutoSize = True
        Me.oldm2.Location = New System.Drawing.Point(269, 339)
        Me.oldm2.Name = "oldm2"
        Me.oldm2.Size = New System.Drawing.Size(28, 13)
        Me.oldm2.TabIndex = 19
        Me.oldm2.Text = "___"
        '
        'oldm1
        '
        Me.oldm1.AutoSize = True
        Me.oldm1.Location = New System.Drawing.Point(197, 339)
        Me.oldm1.Name = "oldm1"
        Me.oldm1.Size = New System.Drawing.Size(28, 13)
        Me.oldm1.TabIndex = 18
        Me.oldm1.Text = "___"
        '
        'oldstk2
        '
        Me.oldstk2.Location = New System.Drawing.Point(249, 316)
        Me.oldstk2.Name = "oldstk2"
        Me.oldstk2.ReadOnly = True
        Me.oldstk2.Size = New System.Drawing.Size(75, 20)
        Me.oldstk2.TabIndex = 17
        '
        'oldstk1
        '
        Me.oldstk1.Location = New System.Drawing.Point(168, 316)
        Me.oldstk1.Name = "oldstk1"
        Me.oldstk1.ReadOnly = True
        Me.oldstk1.Size = New System.Drawing.Size(75, 20)
        Me.oldstk1.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(56, 323)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Existing Stock :"
        '
        'rate
        '
        Me.rate.Location = New System.Drawing.Point(482, 361)
        Me.rate.Name = "rate"
        Me.rate.Size = New System.Drawing.Size(114, 20)
        Me.rate.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(370, 368)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Bill Amount Rs. :"
        '
        'suppliers
        '
        Me.suppliers.FormattingEnabled = True
        Me.suppliers.Location = New System.Drawing.Point(484, 94)
        Me.suppliers.Name = "suppliers"
        Me.suppliers.Size = New System.Drawing.Size(189, 160)
        Me.suppliers.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(382, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Customer :"
        '
        'm2
        '
        Me.m2.AutoSize = True
        Me.m2.Location = New System.Drawing.Point(679, 317)
        Me.m2.Name = "m2"
        Me.m2.Size = New System.Drawing.Size(28, 13)
        Me.m2.TabIndex = 10
        Me.m2.Text = "___"
        '
        'm1
        '
        Me.m1.AutoSize = True
        Me.m1.Location = New System.Drawing.Point(564, 316)
        Me.m1.Name = "m1"
        Me.m1.Size = New System.Drawing.Size(28, 13)
        Me.m1.TabIndex = 9
        Me.m1.Text = "___"
        '
        'q2
        '
        Me.q2.Location = New System.Drawing.Point(598, 310)
        Me.q2.Name = "q2"
        Me.q2.Size = New System.Drawing.Size(75, 20)
        Me.q2.TabIndex = 5
        '
        'q1
        '
        Me.q1.Location = New System.Drawing.Point(482, 309)
        Me.q1.Name = "q1"
        Me.q1.Size = New System.Drawing.Size(75, 20)
        Me.q1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(395, 313)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Qty Sold :"
        '
        'itms
        '
        Me.itms.FormattingEnabled = True
        Me.itms.Location = New System.Drawing.Point(168, 94)
        Me.itms.Name = "itms"
        Me.itms.Size = New System.Drawing.Size(186, 199)
        Me.itms.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Item Sold :"
        '
        'dop
        '
        Me.dop.CustomFormat = "dd/MM/yyyy"
        Me.dop.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dop.Location = New System.Drawing.Point(168, 38)
        Me.dop.Name = "dop"
        Me.dop.Size = New System.Drawing.Size(98, 20)
        Me.dop.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date of Sales :"
        '
        'SALES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 472)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "SALES"
        Me.Text = "SALES"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents bno As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents addr As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents oldm2 As System.Windows.Forms.Label
    Friend WithEvents oldm1 As System.Windows.Forms.Label
    Friend WithEvents oldstk2 As System.Windows.Forms.TextBox
    Friend WithEvents oldstk1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents rate As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents suppliers As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents m2 As System.Windows.Forms.Label
    Friend WithEvents m1 As System.Windows.Forms.Label
    Friend WithEvents q2 As System.Windows.Forms.TextBox
    Friend WithEvents q1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents itms As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dop As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
