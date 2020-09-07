Imports System.Windows.Forms
Imports System.IO
Public Class MDIParent1

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Global.System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticleToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer = 0
    Private Sub LOGOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGOUTToolStripMenuItem.Click
    End Sub
    Private Sub MDIParent1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = concern & " >>> Logged-in As : " & currentuser & " CONCERN : " & concern
        'writing to log file
        '===================

        logfile = String.Format(driv & "\COMPANY\LOGS\log_{0}.txt", DateTime.Today.ToString("dd-MMM-yyyy"))
        FileExists = File.Exists(logfile)

        Using writer As New StreamWriter(logfile, True)
            If Not FileExists Then
                writer.WriteLine("created at : " & DateTime.Now)
            End If
            writer.WriteLine(currentuser & " with concern code : " & ccode & " @ " & DateTime.Now)
            writer.WriteLine("------------------------------------------------------")
        End Using
        '============================================================================
        LoginForm1.Hide()
        CONCERNSELCTION.Hide()
    End Sub
    Private Sub CreateRawMaterialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateRawMaterialToolStripMenuItem.Click
        createRAWMATERIAL.Show()
    End Sub
    Private Sub CreateAddOnMaterialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateAddOnMaterialToolStripMenuItem.Click
        createADDON.Show()
    End Sub
    Private Sub CreateAMeasurementUnitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateAMeasurementUnitToolStripMenuItem.Click
        createMEASURE.Show()
    End Sub
    Private Sub CreateLoginuserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateLoginuserToolStripMenuItem.Click
        createUSER.Show()
    End Sub
    Private Sub CreateJobToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateJobToolStripMenuItem.Click
        createJOB.Show()
    End Sub
    Private Sub NewEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewEmployeeToolStripMenuItem.Click
        newEMPLOYEE.Show()
    End Sub
    Private Sub NewCustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewCustomerToolStripMenuItem.Click
        newCUSTOMER.Show()
    End Sub
    Private Sub NewSupplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewSupplierToolStripMenuItem.Click
        newSUPPLIER.Show()
    End Sub
    Private Sub TodaysEBReadingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TodaysEBReadingToolStripMenuItem.Click
        uploadEBREADING.Show()
    End Sub
    Private Sub UploadWorkingHoursToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UploadWorkingHoursToolStripMenuItem.Click
        uploadEMPWORKHRS.Show()
    End Sub
    Private Sub OpeningStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpeningStockToolStripMenuItem.Click
        uploadOPSTOCK.Show()
    End Sub
    Private Sub QuitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitToolStripMenuItem.Click
        'writing to log file
        '===================
        logfile = String.Format("D:\COMPANY\LOGS\log_{0}.txt", DateTime.Today.ToString("dd-MMM-yyyy"))
        FileExists = File.Exists(logfile)

        Using writer As New StreamWriter(logfile, True)
            If Not FileExists Then
                writer.WriteLine("created at : " & DateTime.Now)
            End If
            writer.WriteLine(currentuser & " logged out at : " & DateTime.Now)
            writer.WriteLine("------------------------------------------------------")
        End Using
        '============================================================================
        End
    End Sub
    Private Sub ChangeConcernToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeConcernToolStripMenuItem.Click
        'writing to log file
        '===================
        logfile = String.Format("D:\COMPANY\LOGS\log_{0}.txt", DateTime.Today.ToString("dd-MMM-yyyy"))
        FileExists = File.Exists(logfile)
        Using writer As New StreamWriter(logfile, True)
            If Not FileExists Then
                writer.WriteLine("created at : " & DateTime.Now)
            End If
            writer.WriteLine(currentuser & " --> change concern from " & ccode & " @ " & DateTime.Now)
            writer.WriteLine("------------------------------------------------------")
        End Using
        '============================================================================
        CONCERNSELCTION.Show()
        Me.Close()
    End Sub
    Private Sub TESTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TESTToolStripMenuItem.Click
        uploadWORKHRS.Show()
    End Sub
    Private Sub UploadConsumablesOfADayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UploadConsumablesOfADayToolStripMenuItem.Click
        uploadCONSUMPTIONDAILY.Show()
    End Sub
    Private Sub CreateFinishedProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateFinishedProductToolStripMenuItem.Click
        createFINISHEDPRODUCT.Show()
    End Sub
    Private Sub RecordProductionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecordProductionToolStripMenuItem.Click
        uploadPRODUCTION.Show()
    End Sub
    Private Sub RecordProductionIndividualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecordProductionIndividualToolStripMenuItem.Click
        uploadPRODUCTIONINDI.Show()
    End Sub
    Private Sub EBReadingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBReadingsToolStripMenuItem.Click
        rptEBREADING.Show()
    End Sub
    Private Sub AttendanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttendanceToolStripMenuItem.Click
        rptATTEND.Show()
    End Sub
    Private Sub StockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockToolStripMenuItem.Click
        rptSTOCK.Show()
    End Sub
    Private Sub CreateWasteMaterialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateWasteMaterialToolStripMenuItem.Click
        createWASTE.Show()
    End Sub
    Private Sub PurchaseConsumablesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseConsumablesToolStripMenuItem.Click
        PURCHASE.Show()
    End Sub
    Private Sub SaleOfProductsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleOfProductsToolStripMenuItem.Click
        SALES.Show()
    End Sub
    Private Sub RecordWastageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecordWastageToolStripMenuItem.Click
        recordWASTE.Show()
    End Sub
    Private Sub SalayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalayToolStripMenuItem.Click
        SALARYENTRY.Show()
    End Sub
    Private Sub SalaryNoteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalaryNoteToolStripMenuItem.Click
        rptSALARYSHEET.Show()
    End Sub
    Private Sub CashPaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashPaymentToolStripMenuItem.Click
        PAYMENT.Show()
    End Sub
    Private Sub CashReceiptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashReceiptToolStripMenuItem.Click
        RECEIPT.Show()
    End Sub
    Private Sub PartyReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PartyReportToolStripMenuItem.Click
        LEDGER.Show()
    End Sub

    Private Sub ConsumablesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsumablesToolStripMenuItem.Click

    End Sub
End Class
