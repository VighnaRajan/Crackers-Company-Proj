<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class createFINISHEDPRODUCT
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
        Me.measure = New System.Windows.Forms.CheckedListBox
        Me.ext = New System.Windows.Forms.Button
        Me.editt = New System.Windows.Forms.Button
        Me.addnew = New System.Windows.Forms.Button
        Me.itemname = New System.Windows.Forms.TextBox
        Me.itemcode = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.raws = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.measure)
        Me.GroupBox1.Controls.Add(Me.ext)
        Me.GroupBox1.Controls.Add(Me.editt)
        Me.GroupBox1.Controls.Add(Me.addnew)
        Me.GroupBox1.Controls.Add(Me.itemname)
        Me.GroupBox1.Controls.Add(Me.itemcode)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.raws)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(614, 392)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'measure
        '
        Me.measure.FormattingEnabled = True
        Me.measure.Location = New System.Drawing.Point(463, 113)
        Me.measure.Name = "measure"
        Me.measure.Size = New System.Drawing.Size(119, 109)
        Me.measure.TabIndex = 11
        '
        'ext
        '
        Me.ext.Location = New System.Drawing.Point(495, 341)
        Me.ext.Name = "ext"
        Me.ext.Size = New System.Drawing.Size(88, 29)
        Me.ext.TabIndex = 10
        Me.ext.Text = "E&xit"
        Me.ext.UseVisualStyleBackColor = True
        '
        'editt
        '
        Me.editt.Location = New System.Drawing.Point(308, 260)
        Me.editt.Name = "editt"
        Me.editt.Size = New System.Drawing.Size(88, 29)
        Me.editt.TabIndex = 9
        Me.editt.Text = "&Edit"
        Me.editt.UseVisualStyleBackColor = True
        '
        'addnew
        '
        Me.addnew.Location = New System.Drawing.Point(186, 260)
        Me.addnew.Name = "addnew"
        Me.addnew.Size = New System.Drawing.Size(88, 29)
        Me.addnew.TabIndex = 8
        Me.addnew.Text = "&Add New"
        Me.addnew.UseVisualStyleBackColor = True
        '
        'itemname
        '
        Me.itemname.Location = New System.Drawing.Point(460, 68)
        Me.itemname.Name = "itemname"
        Me.itemname.ReadOnly = True
        Me.itemname.Size = New System.Drawing.Size(140, 20)
        Me.itemname.TabIndex = 6
        '
        'itemcode
        '
        Me.itemcode.Location = New System.Drawing.Point(460, 29)
        Me.itemcode.Name = "itemcode"
        Me.itemcode.ReadOnly = True
        Me.itemcode.Size = New System.Drawing.Size(90, 20)
        Me.itemcode.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(366, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Measured-In :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(366, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Item Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(366, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Item Code :"
        '
        'raws
        '
        Me.raws.FormattingEnabled = True
        Me.raws.Location = New System.Drawing.Point(187, 36)
        Me.raws.Name = "raws"
        Me.raws.Size = New System.Drawing.Size(161, 199)
        Me.raws.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Existing Products :"
        '
        'createFINISHEDPRODUCT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 412)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "createFINISHEDPRODUCT"
        Me.Text = "CREATE FINISHED PRODUCT"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents measure As System.Windows.Forms.CheckedListBox
    Friend WithEvents ext As System.Windows.Forms.Button
    Friend WithEvents editt As System.Windows.Forms.Button
    Friend WithEvents addnew As System.Windows.Forms.Button
    Friend WithEvents itemname As System.Windows.Forms.TextBox
    Friend WithEvents itemcode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents raws As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
