<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LEDGER
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
        Me.suppliers = New System.Windows.Forms.ListBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.td = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.fd = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.customer = New System.Windows.Forms.RadioButton
        Me.supplier = New System.Windows.Forms.RadioButton
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.MyLEDGER1 = New COMPANYMASTER.MyLEDGER
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CrystalReportViewer1)
        Me.GroupBox1.Controls.Add(Me.suppliers)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1266, 682)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'suppliers
        '
        Me.suppliers.FormattingEnabled = True
        Me.suppliers.Location = New System.Drawing.Point(16, 153)
        Me.suppliers.Name = "suppliers"
        Me.suppliers.Size = New System.Drawing.Size(124, 186)
        Me.suppliers.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(23, 624)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 30)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(25, 551)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 30)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "View Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.td)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.fd)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 344)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(130, 155)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'td
        '
        Me.td.CustomFormat = "dd/MM/yyyy"
        Me.td.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.td.Location = New System.Drawing.Point(15, 106)
        Me.td.Name = "td"
        Me.td.Size = New System.Drawing.Size(103, 20)
        Me.td.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "To :"
        '
        'fd
        '
        Me.fd.CustomFormat = "dd/MM/yyyy"
        Me.fd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fd.Location = New System.Drawing.Point(12, 46)
        Me.fd.Name = "fd"
        Me.fd.Size = New System.Drawing.Size(103, 20)
        Me.fd.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "From :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.customer)
        Me.GroupBox2.Controls.Add(Me.supplier)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 18)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(128, 119)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'customer
        '
        Me.customer.AutoSize = True
        Me.customer.Location = New System.Drawing.Point(19, 61)
        Me.customer.Name = "customer"
        Me.customer.Size = New System.Drawing.Size(94, 17)
        Me.customer.TabIndex = 1
        Me.customer.Text = "CUSTOMER"
        Me.customer.UseVisualStyleBackColor = True
        '
        'supplier
        '
        Me.supplier.AutoSize = True
        Me.supplier.Checked = True
        Me.supplier.Location = New System.Drawing.Point(19, 29)
        Me.supplier.Name = "supplier"
        Me.supplier.Size = New System.Drawing.Size(86, 17)
        Me.supplier.TabIndex = 0
        Me.supplier.TabStop = True
        Me.supplier.Text = "SUPPLIER"
        Me.supplier.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(156, 19)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.MyLEDGER1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1104, 657)
        Me.CrystalReportViewer1.TabIndex = 5
        '
        'LEDGER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 698)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "LEDGER"
        Me.Text = "LEDGER"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents customer As System.Windows.Forms.RadioButton
    Friend WithEvents supplier As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents fd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents td As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents suppliers As System.Windows.Forms.ListBox
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents MyLEDGER1 As COMPANYMASTER.MyLEDGER
End Class
