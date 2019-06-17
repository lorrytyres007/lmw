Imports System.Data.SqlClient
Public Class frmYearEndProcess
    Dim bool_Edit As Boolean

    Private Sub frmYearEndProcess_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad(Me, bool_Edit, "YearEndProcess Details")


    End Sub

    Private Sub BackupSqlDatabase()
        Dim str_FileName = "LMWBackup" + Str(Now.Day) + "-" + Str(Now.Month) + "-" + Str(Now.Year) + "_" + Str(Now.Hour) + "." + Str(Now.Minute) + "." + Str(Now.Second)
        objDT("BACKUP DATABASE [LMW] TO  DISK = N'D:\backups\" & str_FileName & "' WITH  EXPIREDATE = N'" & SD(Now) & "', NOFORMAT, NOINIT,  NAME = N'LMW-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10")
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackup.Click
        lblContent.Text = "Taking Backup Data...."
        BackupSqlDatabase()
        lblContent.Text = "Backup Data Completed...."
        MsgBox("Backup Completed ....", MsgBoxStyle.Information, Mssg)
        lblContent.Text = ""
    End Sub

    Private Sub btnEmpty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpty.Click
        If MsgBox("Confirm Please ? ", MsgBoxStyle.Information + MsgBoxStyle.YesNo, Mssg) = MsgBoxResult.Yes Then
            If MsgBox("Backup your data", MsgBoxStyle.Information + MsgBoxStyle.YesNo, Mssg) = MsgBoxResult.Yes Then
                lblContent.Text = "Taking Backup Data...."
                BackupSqlDatabase()
                lblContent.Text = "Backup Data Completed...."
            End If
            If MsgBox("ReConfirm Please ? ", MsgBoxStyle.Information + MsgBoxStyle.YesNo, Mssg) = MsgBoxResult.Yes Then
                lblContent.Text = "Data to be Delete Now...."
                objDT("sp_EmptyEntryFiles @CompanyCode=" & int_CompanyCode)
                lblContent.Text = "Datas Deleted Successfully...."
            End If
        End If
    End Sub

    Private Sub btnYearEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYearEnd.Click
        Dim intfycode As Integer = objDScal("select isnull(max(fycode),0) from tbl_Fyear")
        Dim strFyear As String = objDScal("select Fyear from tbl_FYear where FyCode=" & intfycode)
        Dim dtpfystart As DateTime = objDScal("select Fystart from tbl_FYear where FyCode=" & intfycode)
        Dim dtpfyend As DateTime = objDScal("select FyEnd from tbl_FYear where FyCode=" & intfycode)
        If MsgBox("Year End Completed. Generate Next Year Commencement", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, Mssg) = MsgBoxResult.Ok Then
            intfycode += 1
            dtpfystart = DateAdd(DateInterval.Day, 365, dtpfystart)
            dtpfyend = DateAdd(DateInterval.Day, 365, dtpfyend)
            strFyear = Str(Year(dtpfystart)) + "-" + Str(Year(dtpfyend))
        End If
        If MsgBox("Confirm to Generate Next Year Commencement", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, Mssg) = MsgBoxResult.Ok Then
            Try
                Initialise_Connection()
                objDT("insert into tbl_Fyear (FYcode,	FYear,	FYStart,	FYEnd) Values	(" & intfycode & ",'" & strFyear & "','" & CD(dtpfystart) & " 12:00:00 AM','" & CD(dtpfyend) & " 11:59:00 PM')")
                MsgBox("Next Year Commencement Completed", MsgBoxStyle.Information, Mssg)
                btnExit_Click(sender, e)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, Mssg)
            End Try

        End If

    End Sub
End Class