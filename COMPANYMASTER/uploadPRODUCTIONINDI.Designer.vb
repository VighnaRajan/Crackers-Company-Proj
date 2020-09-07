<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uploadPRODUCTIONINDI
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
        Me.l3 = New System.Windows.Forms.ListBox
        Me.l2 = New System.Windows.Forms.ListBox
        Me.l1 = New System.Windows.Forms.ListBox
        Me.grid = New System.Windows.Forms.DataGridView
        Me.EmployeeName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Product = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Production = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.measure1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Production2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.measure2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.m4 = New System.Windows.Forms.Label
        Me.m3 = New System.Windows.Forms.Label
        Me.c2 = New System.Windows.Forms.TextBox
        Me.c1 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.doj = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.l3)
        Me.GroupBox1.Controls.Add(Me.l2)
        Me.GroupBox1.Controls.Add(Me.l1)
        Me.GroupBox1.Controls.Add(Me.grid)
        Me.GroupBox1.Controls.Add(Me.m4)
        Me.GroupBox1.Controls.Add(Me.m3)
        Me.GroupBox1.Controls.Add(Me.c2)
        Me.GroupBox1.Controls.Add(Me.c1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.doj)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(764, 572)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'l3
        '
        Me.l3.FormattingEnabled = True
        Me.l3.Location = New System.Drawing.Point(609, 311)
        Me.l3.Name = "l3"
        Me.l3.Size = New System.Drawing.Size(56, 173)
        Me.l3.TabIndex = 59
        '
        'l2
        '
        Me.l2.FormattingEnabled = True
        Me.l2.Location = New System.Drawing.Point(547, 311)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(56, 173)
        Me.l2.TabIndex = 58
        '
        'l1
        '
        Me.l1.FormattingEnabled = True
        Me.l1.Location = New System.Drawing.Point(376, 311)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(165, 173)
        Me.l1.TabIndex = 57
        '
        'grid
        '
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeName, Me.Product, Me.Production, Me.measure1, Me.Production2, Me.measure2})
        Me.grid.Location = New System.Drawing.Point(115, 81)
        Me.grid.Name = "grid"
        Me.grid.Size = New System.Drawing.Size(643, 211)
        Me.grid.TabIndex = 56
        '
        'EmployeeName
        '
        Me.EmployeeName.HeaderText = "EmployeeName"
        Me.EmployeeName.Name = "EmployeeName"
        Me.EmployeeName.ReadOnly = True
        '
        'Product
        '
        Me.Product.HeaderText = "Product"
        Me.Product.Name = "Product"
        '
        'Production
        '
        Me.Production.HeaderText = "Production1"
        Me.Production.Name = "Production"
        '
        'measure1
        '
        Me.measure1.HeaderText = "Measure1"
        Me.measure1.Name = "measure1"
        Me.measure1.ReadOnly = True
        '
        'Production2
        '
        Me.Production2.HeaderText = "production2"
        Me.Production2.Name = "Production2"
        '
        'measure2
        '
        Me.measure2.HeaderText = "Measure2"
        Me.measure2.Name = "measure2"
        Me.measure2.ReadOnly = True
        '
        'm4
        '
        Me.m4.AutoSize = True
        Me.m4.Location = New System.Drawing.Point(620, 295)
        Me.m4.Name = "m4"
        Me.m4.Size = New System.Drawing.Size(28, 13)
        Me.m4.TabIndex = 49
        Me.m4.Text = "___"
        '
        'm3
        '
        Me.m3.AutoSize = True
        Me.m3.Location = New System.Drawing.Point(561, 295)
        Me.m3.Name = "m3"
        Me.m3.Size = New System.Drawing.Size(28, 13)
        Me.m3.TabIndex = 48
        Me.m3.Text = "___"
        '
        'c2
        '
        Me.c2.Location = New System.Drawing.Point(610, 486)
        Me.c2.Name = "c2"
        Me.c2.Size = New System.Drawing.Size(55, 20)
        Me.c2.TabIndex = 47
        '
        'c1
        '
        Me.c1.Location = New System.Drawing.Point(547, 486)
        Me.c1.Name = "c1"
        Me.c1.Size = New System.Drawing.Size(55, 20)
        Me.c1.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(199, 311)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Today's Production :"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(680, 533)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 33)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(170, 527)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 29)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Upload Production"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Production details :"
        '
        'doj
        '
        Me.doj.CustomFormat = "DD/MM/YYYY"
        Me.doj.Location = New System.Drawing.Point(147, 31)
        Me.doj.Name = "doj"
        Me.doj.Size = New System.Drawing.Size(223, 20)
        Me.doj.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 17)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Date of Production :"
        Me.Label5.UseCompatibleTextRendering = True
        '
        'uploadPRODUCTIONINDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 592)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "uploadPRODUCTIONINDI"
        Me.Text = "UPLOAD PRODUCTION DETAILS OF INDIVIDUALS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents m4 As System.Windows.Forms.Label
    Friend WithEvents m3 As System.Windows.Forms.Label
    Friend WithEvents c2 As System.Windows.Forms.TextBox
    Friend WithEvents c1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents doj As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents EmployeeName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Product As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Production As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents measure1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Production2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents measure2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents l3 As System.Windows.Forms.ListBox
    Friend WithEvents l2 As System.Windows.Forms.ListBox
    Friend WithEvents l1 As System.Windows.Forms.ListBox
End Class
