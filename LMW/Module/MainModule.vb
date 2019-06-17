Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Drawing
Imports System.Management

Module MainModule
    '----------Project Variables------------------------
    Public str_PrjTitle As String
    Public str_PrjVer As String
    '----------Server Variables-------------------------
    Dim objReader As StreamReader = New StreamReader(Application.StartupPath() & "\DBConfig.db")
    Dim str_Reader() As String = objReader.ReadToEnd().Split(Chr(13))
    Public str_ServerName As String = str_Reader(0)      ' sql express
    Public str_DBName As String = str_Reader(1).Trim     '\dbname
    Public str_Company As String = str_Reader(2).Trim
    Public str_Branchname As String = str_Reader(3).Trim
    Public str_TamilFont As String = "RATam"
    Public str_SighningAuthority As String = ""
    Public objSqlConnection As New SqlConnection("Server=" & str_ServerName & ";Initial Catalog=" & str_DBName & ";User ID=sa;password=@dmin1305;Connect TimeOut=300")
    Public objSqlCommand As New SqlCommand
    Public objSqlCommand1 As New SqlCommand
    Public objSqlDataReader As SqlDataReader
    Public objSqlDataAdapter As SqlDataAdapter

    '----------User Variables---------------------------s
    Public int_UserCode As Integer
    Public int_UserLevel As String
    Public int_NodeCode As Integer
    Public int_CompanyCode As Integer
    Public int_SubCentre As Integer = 0
    Public int_FYearCode As Integer = 1
    Public Enter_Key As Boolean = False
    Public dbl_CostDiffer As Double
    Public str_UserName As String = "ADMIN"
    Public str_CompanyShortName As String
    Public AFONT As String = ""
    Public NodeSerial As String
    Public Serial As String
    Public serial2 As String
    Public Enc2 As String
    '----------General Variables------------------------
    Public Mssg As String
    Public CurDate As DateTime = System.DateTime.Today.ToShortDateString()
    Public _Company As New clsCompanyDetails
    '----------Common Settings-----------------------------
    Public _MultiCompany As Boolean
    Public _SoftType As String
    Public _EmployeeID As String
    Public _Branch As Boolean
    Public _Category As Boolean
    Public _Tamil As Boolean
    '----------------User Settings--------------------
    Public EntryWith As Integer
    Public smonLMW As String
    Public RateInIndividual As Boolean
    Public LSPourToCan As Boolean
    Public LastTestLr As Boolean
    Public RateDisp As Boolean
    Public LastUpDate As DateTime

    'Public Enum SQLServer
    '    ServerStart()
    '    ServerStop()
    'End Enum

    Public Function DecodeUser(ByVal objDTable As DataTable) As DataTable
        For RowIndex As Integer = 0 To objDTable.Rows.Count - 1
            objDTable.Rows(RowIndex)("UserName") = Decode(objDTable.Rows(RowIndex)("UserName"))
            objDTable.Rows(RowIndex)("Password") = Decode(objDTable.Rows(RowIndex)("Password"))
            objDTable.Rows(RowIndex)("UserLevel") = IIf(Decode(objDTable.Rows(RowIndex)("UserLevel")) = "1", "ADMINISTRATOR", "LIMITED")
        Next
        Return objDTable
    End Function

    Public Function FindUpdates()
        LastUpDate = objDScal("Select UpdationDate from tbl_LastUpdate")
        Return Nothing
    End Function

    'Public Sub SQLServerStart(ByVal Status As SQLServer)
    '    Try
    '        Dim SQL As New System.ServiceProcess.ServiceController("MSSQLSERVER", ".")
    '        'SQL.MachineName = str_ServerName
    '        'SQL.ServiceName = "MSSQLSERVER"
    '        Dim str_RunningStatus As String = SQL.Status.ToString()

    '        If Status = SQLServer.ServerStart Then
    '            If str_RunningStatus = "Stopped" Then SQL.Start()
    '        End If

    '        If Status = SQLServer.ServerStop Then
    '            If str_RunningStatus = "Running" Then SQL.Stop()
    '        End If
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    'Public Sub ReportDetails(ByVal Control As sControls.ViewControlvb, Optional ByVal Particulars As String = Nothing)
    '    Try
    '        Dim str_Address As String = ""
    '        Dim str_Others As String = ""

    '        If Trim(dt_CompanyDetails.Rows(0)("CompanyName")) <> "" Then Control.RptCompanyName = Trim(dt_CompanyDetails.Rows(0)("CompanyName"))

    '        If Trim(dt_CompanyDetails.Rows(0)("Address1")) <> "" Then str_Address = Trim(dt_CompanyDetails.Rows(0)("Address1"))
    '        If Trim(dt_CompanyDetails.Rows(0)("Address2")) <> "" Then
    '            If str_Address <> "" Then str_Address += ", "
    '            str_Address += Trim(dt_CompanyDetails.Rows(0)("Address2"))
    '        End If
    '        If Trim(dt_CompanyDetails.Rows(0)("City")) <> "" Then
    '            If str_Address <> "" Then str_Address += ", "
    '            str_Address += Trim(dt_CompanyDetails.Rows(0)("City"))
    '        End If
    '        Control.RptAddress = str_Address

    '        If Trim(dt_CompanyDetails.Rows(0)("CSTNO")) <> "" Then str_Others = "CST No: " & Trim(dt_CompanyDetails.Rows(0)("CSTNO"))
    '        If Trim(dt_CompanyDetails.Rows(0)("TINNO")) <> "" Then
    '            If str_Others <> "" Then str_Others += " - "
    '            str_Others += "TIN No: " & Trim(dt_CompanyDetails.Rows(0)("TINNO"))
    '        End If
    '        Control.RptOthers = str_Others

    '        If Particulars <> Nothing Then Control.RptParticulars = Particulars

    '        Control.RptFooterLeft = "General Manager"
    '        Control.RptFooterCenter = "Farm Manager"
    '        Control.RptFooterRight = "Supervisor"
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub
    Public Sub PanelClear(ByVal pnl As Control)
        Try
            Dim MyCon As Control
            For Each MyCon In pnl.Controls
                If (MyCon.GetType() Is GetType(sControls.TextBoxvb) Or MyCon.GetType() Is GetType(TextBox)) Then
                    Dim txt As sControls.TextBoxvb = CType(MyCon, sControls.TextBoxvb)
                    txt.Text = ""
                End If
                If MyCon.GetType() Is GetType(sControls.Labelvb) Then
                    Dim txt As sControls.Labelvb = CType(MyCon, sControls.Labelvb)
                    txt.Text = ""
                End If
                If (MyCon.GetType() Is GetType(sControls.ComboBoxvb)) Then
                    Dim cmb As sControls.ComboBoxvb = CType(MyCon, sControls.ComboBoxvb)
                    If cmb.Items.Count > 0 Then cmb.SelectedIndex = 0
                End If
                If (MyCon.GetType() Is GetType(sControls.ViewGrid)) Then
                    Dim Grid As sControls.ViewGrid = CType(MyCon, sControls.ViewGrid)
                    Grid.Rows.Clear()
                End If
                If (MyCon.GetType() Is GetType(sControls.Gridvb)) Then
                    Dim Grid As sControls.Gridvb = CType(MyCon, sControls.Gridvb)
                    Grid.Rows.Clear()
                End If
                If (MyCon.GetType() Is GetType(sControls.DateTimePickervb)) Then
                    Dim DTP As sControls.DateTimePickervb = CType(MyCon, sControls.DateTimePickervb)
                    DTP.CustomFormat = " "
                End If
                If (MyCon.GetType() Is GetType(System.Windows.Forms.MaskedTextBox) Or MyCon.GetType() Is GetType(sControls.DateTimeMaskvb)) Then
                    Dim MaskText As System.Windows.Forms.MaskedTextBox = CType(MyCon, System.Windows.Forms.MaskedTextBox)
                    Dim _Mask As String = MaskText.Mask
                    MaskText.Mask = ""
                    MaskText.Text = ""
                    MaskText.Mask = _Mask
                End If

                'If (MyCon.GetType() Is GetType(sControls.OutlookPanelEx)) Or (MyCon.GetType() Is GetType(Panel)) Or (MyCon.GetType() Is GetType(BSE.Windows.Forms.Panel)) Or (MyCon.GetType() Is GetType(BSE.Windows.Forms.XPanderPanelList)) Or (MyCon.GetType() Is GetType(BSE.Windows.Forms.XPanderPanel)) Then
                ' PanelClear(MyCon)
                ' End If
            Next
        Catch ex As Exception
            'Throw ex
        End Try
    End Sub
    Public Sub ShowForm(ByVal frm As Form)
        frm.MdiParent = MainForm
        frm.BringToFront()
        frm.Show()
    End Sub

    Public Sub FormLoad(ByVal frm As Form, ByVal Edit As Boolean, ByVal FormName As String, Optional ByVal Combo As Boolean = False)
        If Edit = False Then
            frm.Text = FormName & " [Add]"
            If Combo = True Then
                Dim cmbCombo As New ComboBox
                cmbCombo = frm.Controls("cmbStatus")
                cmbCombo.SelectedIndex = 0
            End If
        Else
            frm.Text = FormName & " [Edit]"
        End If
    End Sub
    Public Sub FormShown(ByVal frm As Form)
        frm.Left = 0
        frm.Top = 0
        frm.Width = MainForm.Width - MainForm.pnlLeft.Width - 12
        frm.Height = MainForm.Height - MainForm.pnlTop.Height - 60
    End Sub

    Public Sub FormClear(ByVal frm As Form)
        Try

            Dim MyCon As Control
            For Each MyCon In frm.Controls
                If MyCon.GetType() Is GetType(GroupBox) Then
                    For Each MyC In MyCon.Controls
                        If (MyC.GetType() Is GetType(sControls.TextBoxvb) Or MyC.GetType() Is GetType(TextBox)) Then
                            MyC.Text = ""
                            'Dim txt As sControls.TextBoxvb = CType(MyC, sControls.TextBoxvb)
                            'txt.Text = ""
                        End If
                        If (MyC.GetType() Is GetType(sControls.ComboBoxvb)) Then
                            Dim cmb As sControls.ComboBoxvb = CType(MyC, sControls.ComboBoxvb)
                            cmb.SelectedIndex = 0
                        End If
                        If (MyC.GetType() Is GetType(sControls.ViewGrid)) Then
                            Dim Grid As sControls.ViewGrid = CType(MyC, sControls.ViewGrid)
                            Grid.Rows.Clear()
                        End If

                        If MyC.GetType() Is GetType(GroupBox) Then
                            For Each MyC1 In MyC.Controls
                                If (MyC1.GetType() Is GetType(sControls.TextBoxvb) Or MyC1.GetType() Is GetType(TextBox)) Then
                                    MyC1.Text = ""
                                End If
                                If (MyC1.GetType() Is GetType(sControls.ComboBoxvb)) Then
                                    Dim cmb As sControls.ComboBoxvb = CType(MyC1, sControls.ComboBoxvb)
                                    cmb.SelectedIndex = 0
                                End If
                                If (MyC1.GetType() Is GetType(sControls.ViewGrid)) Then
                                    Dim Grid As sControls.ViewGrid = CType(MyC1, sControls.ViewGrid)
                                    Grid.Rows.Clear()
                                End If
                            Next
                        End If
                    Next
                End If
                If (MyCon.GetType() Is GetType(sControls.TextBoxvb) Or MyCon.GetType() Is GetType(TextBox)) Then
                    Dim txt As sControls.TextBoxvb = CType(MyCon, sControls.TextBoxvb)
                    txt.Text = ""
                End If
                If (MyCon.GetType() Is GetType(sControls.ComboBoxvb)) Then
                    Dim cmb As sControls.ComboBoxvb = CType(MyCon, sControls.ComboBoxvb)
                    cmb.SelectedIndex = 0
                End If
                If (MyCon.GetType() Is GetType(sControls.ViewGrid)) Then
                    Dim Grid As sControls.ViewGrid = CType(MyCon, sControls.ViewGrid)
                    Grid.Rows.Clear()
                End If

                If (MyCon.GetType() Is GetType(sControls.DateTimePickervb)) Then
                    Dim DTP As sControls.DateTimePickervb = CType(MyCon, sControls.DateTimePickervb)
                    DTP.CustomFormat = " "
                End If
                If (MyCon.GetType() Is GetType(System.Windows.Forms.MaskedTextBox)) Then
                    Dim MaskText As System.Windows.Forms.MaskedTextBox = CType(MyCon, System.Windows.Forms.MaskedTextBox)
                    Dim _Mask As String = MaskText.Mask
                    MaskText.Mask = ""
                    MaskText.Text = ""
                    MaskText.Mask = _Mask
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function SD(ByVal C_Date As Object) As String
        Try
            SD = Format(CDate(C_Date), "yyyy-MM-dd")
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CD(ByVal C_Date As Object) As String
        Try
            CD = Format(CDate(C_Date), "dd/MMM/yyyy")
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function objDScal(ByVal str As String) As Object
        Try
            Initialise_Connection()
            Dim scalarCommand As New SqlCommand(str, objSqlConnection)
            Return scalarCommand.ExecuteScalar()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function objDT(ByVal str As String) As DataTable
        Try
            Initialise_Connection()
            Dim objDataTable As New DataTable
            objSqlDataAdapter = New SqlDataAdapter(str, objSqlConnection)
            objSqlDataAdapter.Fill(objDataTable)
            objDT = objDataTable
            objSqlDataAdapter.Dispose()
            objDataTable.Dispose()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function objDT(ByVal cmd As SqlCommand) As DataTable
        Try
            Initialise_Connection()
            Dim objDataTable As New DataTable
            cmd.CommandTimeout = 300
            objSqlDataAdapter = New SqlDataAdapter(cmd)
            objSqlDataAdapter.Fill(objDataTable)
            objDT = objDataTable
            objSqlDataAdapter.Dispose()
            objDataTable.Dispose()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function objDS(ByVal str As String) As DataSet
        Try
            Initialise_Connection()
            Dim objDataSet As New DataSet
            objSqlDataAdapter = New SqlDataAdapter(str, objSqlConnection)
            objSqlDataAdapter.Fill(objDataSet)
            objDS = objDataSet
            objSqlDataAdapter.Dispose()
            objDataSet.Dispose()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function objDS(ByVal cmd As SqlCommand) As DataSet
        Try
            Initialise_Connection()
            Dim objDataSet As New DataSet
            objSqlDataAdapter = New SqlDataAdapter(cmd)
            objSqlDataAdapter.Fill(objDataSet)
            objDS = objDataSet
            objSqlDataAdapter.Dispose()
            objDataSet.Dispose()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Initialise_Connection()
        If objSqlConnection.State = ConnectionState.Broken Or objSqlConnection.State = ConnectionState.Closed Then
            objSqlConnection.Open()
        End If

    End Sub

    Public Function Encode(ByVal Value As String) As String
        Try
            Dim str_Value As String = Nothing
            For int_i As Integer = 0 To Value.Length - 1
                str_Value = str_Value & Convert.ToChar(Microsoft.VisualBasic.AscW(Value.Substring(int_i, 1)) + 10)
            Next
            Return str_Value
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Decode(ByVal Value As String) As String
        Try
            Dim str_Value As String = Nothing
            For int_i As Integer = 0 To Value.Length - 1
                str_Value = str_Value & Convert.ToChar(Microsoft.VisualBasic.AscW(Value.Substring(int_i, 1)) - 10)
            Next
            Return str_Value
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Conv_Mins(ByVal Hours As String) As Integer
        Dim _MinSplit As Object = Hours.Split(":")
        Return (Val(_MinSplit(0)) * 60) + Val(_MinSplit(1))
    End Function

    Public Function Conv_Hours(ByVal Mins As Integer) As String
        Return Format(Int(Mins / 60), "0#") & ":" & Format(Int(Mins Mod 60), "0#")
    End Function

    Public Function CheckMailID(ByVal MailID As String) As Boolean
        If MailID.Contains("@") = False Then
            Return False
        End If
        Return True
    End Function

    Public Function Select_Company()
        Try
            If objDScal("sp_Company_GetAll") = True And Val(objDScal("sp_Company_GetAll")) > 1 Then
                'frmCompany.ShowDialog()
            Else
                Dim objDTable As DataTable = objDT("sp_Company_GetAll")
                If objDTable.Rows.Count > 0 Then
                    _Company.CompanyName = objDTable.Rows(0)("CompanyName").ToString
                    _Company.ShortName = objDTable.Rows(0)("ShortName").ToString
                    _Company.Address1 = objDTable.Rows(0)("Address1").ToString
                    _Company.Address2 = objDTable.Rows(0)("Address2").ToString
                    _Company.City = objDTable.Rows(0)("City").ToString
                    _Company.District = objDTable.Rows(0)("District").ToString
                    _Company.PinCode = objDTable.Rows(0)("PinCode").ToString
                    _Company.PhoneNo = objDTable.Rows(0)("PhoneNo").ToString
                    _Company.MobileNo = objDTable.Rows(0)("MobileNo").ToString
                    _Company.Website = objDTable.Rows(0)("Website").ToString
                    _Company.EMail = objDTable.Rows(0)("EMail").ToString
                    _Company.TINNo = objDTable.Rows(0)("TINNo").ToString
                    _Company.CSTNo = objDTable.Rows(0)("CSTNo").ToString
                    str_TamilFont = objDTable.Rows(0)("TypingFont").ToString
                End If
            End If

            MainForm.lblCompanyName.Text = _Company.CompanyName

            If MainForm.lblCompanyName.Text = "SWAS TECHNOLOGIES" Then
                frmCompanyDetails.btnAdd.Visible = True
                ShowForm(frmCompany)
            Else
                frmCompanyDetails.btnAdd.Visible = False
                frmCompany.Dispose()
            End If

            Return _Company
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function CheckDate(ByVal givendate As Date) As Boolean
        If IsDate(givendate) = False Then
            Return False
        End If
        Dim objcheck As DataTable = objDT("sp_FYear_GetAll @FyCode=" & int_FYearCode)
        If SD(givendate) >= SD(objcheck.Rows.Item(0)("FyStart")) And SD(givendate) <= (objcheck.Rows.Item(0)("fyend")) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function BmpToBytes_MemStream(ByVal bmp As Bitmap) As Byte()
        Dim ms As MemoryStream = New MemoryStream()
        'Save to memory using the Jpeg format
        bmp.Save(ms, ImageFormat.Jpeg)
        'read to end
        Dim bmpBytes() As Byte = ms.GetBuffer()
        bmp.Dispose()
        ms.Close()
        Return bmpBytes
    End Function

    Public Function BytesToImage(ByVal bmpbytes As Byte()) As Image
        Dim ms As MemoryStream = New MemoryStream(bmpbytes)
        Dim img As Image = Image.FromStream(ms)
        Return (img)
    End Function

    Public Function BmpToBytes(ByVal bmp As Bitmap) As Byte()
        Dim ms As MemoryStream = New MemoryStream()
        bmp.Save(ms, ImageFormat.Jpeg)
        Dim bmpBytes() As Byte = ms.GetBuffer()
        ms.Close()
        Return bmpBytes
    End Function
    Public Function MaxDays(ByVal MM As Integer, ByVal YY As Integer) As Integer
        Try
            Return IIf(MM = 1 Or MM = 3 Or MM = 5 Or MM = 7 Or MM = 8 Or MM = 10 Or MM = 12, 31, IIf(MM = 4 Or MM = 6 Or MM = 9 Or MM = 11, 30, IIf((YY Mod 4) = 0, 29, 28)))
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function SI_Emi(ByVal P As Double, ByVal N As Integer, ByVal R As Double, Optional ByVal Roundoff As Boolean = False) As Double
        Try
            Dim MEMI As Double
            Dim ROI As Double = R / 1200
            MEMI = Math.Round((P * N * ROI) + 0.01, 0)
            'MEMI = P * N * ROI
            If Roundoff = True Then
                Dim EVU As Integer = Int(MEMI / 50)
                Dim MEE As Integer = (MEMI Mod 50)
                If MEE > 0 Then EVU = EVU + 1
                MEMI = Format(EVU * 50, "#0.00")
            End If
            Return MEMI
        Catch ex As Exception
            Throw ex
        End Try
    End Function

   
    Public Function SI_EmiDay(ByVal P As Double, ByVal N As Integer, ByVal R As Double, Optional ByVal Roundoff As Boolean = False) As Double
        Try
            Dim MEMI As Double
            Dim ROI As Double = R / 36500
            MEMI = Math.Round((P * N * ROI) + 0.01, 0)
            'MEMI = P * N * ROI
            If Roundoff = True Then
                Dim EVU As Integer = Int(MEMI / 50)
                Dim MEE As Integer = (MEMI Mod 50)
                If MEE > 0 Then EVU = EVU + 1
                MEMI = Format(EVU * 50, "#0.00")
            End If
            Return MEMI
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Module
