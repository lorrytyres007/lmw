
Public Class frmCompanyEdit
    Dim objCompany As New DBLayer.clsCompany

    Private Sub frmCompanyEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        objCompany.CompanyCode = int_CompanyCode
        Dim company As DataTable = objDT("Select * from tbl_Company where CompanyCode=" & int_CompanyCode)
        frmCompany.Show_Edit(company.Rows(0)(DataRowVersion.Current))
        'Grid.RecordSet(objCompany.GetRecords, "CompanyCode,CompanyCode,TypingFont,CompanyName")
        'Grid.DefaultCellStyle.Font = New Font(str_TamilFont, 12)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub frmCompanyEdit_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        FormShown(Me)
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class