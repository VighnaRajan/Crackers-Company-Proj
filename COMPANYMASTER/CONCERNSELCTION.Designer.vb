<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CONCERNSELCTION
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
        Me.concerns = New System.Windows.Forms.ListBox
        Me.proceed = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'concerns
        '
        Me.concerns.FormattingEnabled = True
        Me.concerns.Location = New System.Drawing.Point(34, 14)
        Me.concerns.Name = "concerns"
        Me.concerns.Size = New System.Drawing.Size(267, 225)
        Me.concerns.TabIndex = 0
        '
        'proceed
        '
        Me.proceed.Location = New System.Drawing.Point(270, 248)
        Me.proceed.Name = "proceed"
        Me.proceed.Size = New System.Drawing.Size(86, 23)
        Me.proceed.TabIndex = 1
        Me.proceed.Text = "Proceed"
        Me.proceed.UseVisualStyleBackColor = True
        '
        'CONCERNSELCTION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 279)
        Me.Controls.Add(Me.proceed)
        Me.Controls.Add(Me.concerns)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "CONCERNSELCTION"
        Me.Text = "CONCERN SELCTION"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents concerns As System.Windows.Forms.ListBox
    Friend WithEvents proceed As System.Windows.Forms.Button
End Class
