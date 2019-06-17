Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices
Imports System.Drawing
Imports System.Management
Imports System.Data.SqlClient
Imports System.Drawing.Image
Public Class frmMember
    Dim bool_Edit As Boolean
    Dim objMember As New DBLayer.clsMember
    Const WM_CAP As Short = &H400S

    Const WM_CAP_DRIVER_CONNECT As Integer = WM_CAP + 10
    Const WM_CAP_DRIVER_DISCONNECT As Integer = WM_CAP + 11
    Const WM_CAP_EDIT_COPY As Integer = WM_CAP + 30

    Const WM_CAP_SET_PREVIEW As Integer = WM_CAP + 50
    Const WM_CAP_SET_PREVIEWRATE As Integer = WM_CAP + 52
    Const WM_CAP_SET_SCALE As Integer = WM_CAP + 53
    Const WS_CHILD As Integer = &H40000000
    Const WS_VISIBLE As Integer = &H10000000
    Const SWP_NOMOVE As Short = &H2S
    Const SWP_NOSIZE As Short = 1
    Const SWP_NOZORDER As Short = &H4S
    Const HWND_BOTTOM As Short = 1

    Dim iDevice As Integer = 0 ' Current device ID
    Dim hHwnd As Integer ' Handle to preview window

    Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
        (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, _
        <MarshalAs(UnmanagedType.AsAny)> ByVal lParam As Object) As Integer

    Declare Function SetWindowPos Lib "user32" Alias "SetWindowPos" (ByVal hwnd As Integer, _
        ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, _
        ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer

    Declare Function DestroyWindow Lib "user32" (ByVal hndw As Integer) As Boolean

    Declare Function capCreateCaptureWindowA Lib "avicap32.dll" _
        (ByVal lpszWindowName As String, ByVal dwStyle As Integer, _
        ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, _
        ByVal nHeight As Short, ByVal hWndParent As Integer, _
        ByVal nID As Integer) As Integer

    Declare Function capGetDriverDescriptionA Lib "avicap32.dll" (ByVal wDriver As Short, _
        ByVal lpszName As String, ByVal cbName As Integer, ByVal lpszVer As String, _
        ByVal cbVer As Integer) As Boolean

    Public Sub Show_Edit(ByVal DataRow As DataGridViewRow)
        Try
            bool_Edit = True

            txtTDOpening.Enabled = False
            txtShareOpening.Enabled = False

            Dim objmember As DataTable = objDT("select * from tbl_member where MemberCode=" & DataRow.Cells("membercode").Value)

            txtMemberCode.Text = DataRow.Cells("MemberCode").Value
            txtNumber.Text = DataRow.Cells("Number").Value
            txtName.Text = IIf(IsDBNull(DataRow.Cells("MemberName").Value) = True, "", DataRow.Cells("MemberName").Value)
            txtMemberName_Tamil.Text = IIf(IsDBNull(DataRow.Cells("MemberName_Tamil").Value) = True, "", DataRow.Cells("MemberName_Tamil").Value)
            txtEmployeeNumber.Text = DataRow.Cells("EmployeeNumber").Value
            txtTDOpening.Text = DataRow.Cells("TDOpening").Value
            txtShareOpening.Text = DataRow.Cells("ShareOpening").Value
            txtAddress1.Text = IIf(IsDBNull(DataRow.Cells("Address1").Value) = True, "", DataRow.Cells("Address1").Value)
            txtAddress2.Text = IIf(IsDBNull(DataRow.Cells("Address2").Value) = True, "", DataRow.Cells("Address2").Value)
            txtAddress3.Text = IIf(IsDBNull(DataRow.Cells("Address3").Value) = True, "", DataRow.Cells("Address3").Value)
            txtAddress4.Text = IIf(IsDBNull(DataRow.Cells("Address4").Value) = True, "", DataRow.Cells("Address4").Value)
            txtAddress_Tamil1.Text = IIf(IsDBNull(DataRow.Cells("Address_Tamil1").Value) = True, "", DataRow.Cells("Address_Tamil1").Value)
            txtAddress_Tamil2.Text = IIf(IsDBNull(DataRow.Cells("Address_Tamil2").Value) = True, "", DataRow.Cells("Address_Tamil2").Value)
            txtAddress_Tamil3.Text = IIf(IsDBNull(DataRow.Cells("Address_Tamil3").Value) = True, "", DataRow.Cells("Address_Tamil3").Value)
            txtAddress_Tamil4.Text = IIf(IsDBNull(DataRow.Cells("Address_Tamil4").Value) = True, "", DataRow.Cells("Address_Tamil4").Value)
            txtMobileNo.Text = IIf(IsDBNull(DataRow.Cells("MobileNo").Value) = True, "", DataRow.Cells("MobileNo").Value)
            cmbStatus.SelectedIndex = IIf(DataRow.Cells("status").Value = True, 0, 1)
            CmbMemberType.Text = IIf(IsDBNull(DataRow.Cells("MemberType").Value), "STAFF", DataRow.Cells("MemberType").Value)
            If IsDBNull(objMember.Rows.Item(0)("Photo_Image")) = True Then
                pbImage.Image = LMW.My.Resources.white
            Else
                pbImage.Image = BytesToImage(objMember.Rows.Item(0)("photo_Image"))
            End If
            Me.ShowDialog()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Show_Add()
        bool_Edit = False
        txtTDOpening.Enabled = True
        txtShareOpening.Enabled = True
        'Dim objgetmember As DataTable = objMember.GetMemberNumber()
        'txtNumber.Text = objgetmember.Rows.Item(0)("Number")
        txtNumber.Focus()
        Me.ShowDialog()
    End Sub

    Private Sub frmMember_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad(Me, bool_Edit, "Member Details")
        txtNumber.Font = New Font(str_TamilFont, 12)
        txtName.Font = New Font(str_TamilFont, 12)
        txtEmployeeNumber.Font = New Font(str_TamilFont, 12)

        Try
            LoadDeviceList()
            If lstDevices.Items.Count > 0 Then
                btnStart.Enabled = True
                lstDevices.SelectedIndex = 0
                btnStart.Enabled = True
            Else
                PnlImage.Enabled = False
                btnStart.Enabled = False
                btnTakePhoto.Enabled = False
                'lstDevices.Items.Add("No Capture Device")
            End If
            btnTakePhoto.Enabled = False
            If bool_Edit = False Then
                pbImage.Image = LMW.My.Resources.white

            End If
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Mssg)
        End Try

        If bool_Edit = False Then
            btnClear_Click(sender, e)
        End If
    End Sub


    Private Sub LoadDeviceList()
        Dim strName As String = Space(100)
        Dim strVer As String = Space(100)
        Dim bReturn As Boolean
        Dim x As Integer = 0

        ' 
        ' Load name of all avialable devices into the lstDevices
        '

        Do
            '
            '   Get Driver name and version
            '
            bReturn = capGetDriverDescriptionA(x, strName, 100, strVer, 100)

            '
            ' If there was a device add device name to the list
            '
            If bReturn Then lstDevices.Items.Add(strName.Trim)
            x += 1
        Loop Until bReturn = False
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If Val(txtNumber.Text.Trim) = 0 Then
                MsgBox("Member should not be empty", MsgBoxStyle.Information, Mssg)
                txtNumber.Focus()
                Return
            End If
            'If txtName.Text.Trim = "" Then
            '    MsgBox("Type Member Name ", MsgBoxStyle.Information, Mssg)
            '    txtName.Focus()
            '    Return
            'End If

            'objMember.Number = Val(txtNumber.Text)
            'objMember.MemberName = txtName.Text.Trim
            'objMember.MemberName_Tamil = txtMemberName_Tamil.Text.Trim
            'objMember.EmployeeNumber = Val(txtEmployeeNumber.Text)
            'objMember.TDOpening = Val(txtTDOpening.Text)
            'objMember.status = IIf(cmbStatus.SelectedIndex = 0, 1, 0)
            'objMember.MemberType = CmbMemberType.Text
            'objMember.Address1 = txtAddress1.Text
            'objMember.Address2 = txtAddress2.Text
            'objMember.Address3 = txtAddress3.Text
            'objMember.Address4 = txtAddress4.Text
            'objMember.MobileNo = txtMobileNo.Text
            'objMember.Address_Tamil1 = txtAddress_Tamil1.Text
            'objMember.Address_Tamil2 = txtAddress_Tamil2.Text
            'objMember.Address_Tamil3 = txtAddress_Tamil3.Text
            'objMember.Address_Tamil4 = txtAddress_Tamil4.Text
            'objMember.ShareOpening = Val(txtShareOpening.Text)

            Dim photo As Byte() = Nothing
            If pnlImage.Enabled = True Then
                photo = BmpToBytes_MemStream(pbImage.Image)
            Else
                photo = Nothing
            End If
            If bool_Edit = False Then
                ' objMember.SaveRecords()
                Initialise_Connection()
                Dim objCommand As New SqlCommand("sp_Member_AddEdit", objSqlConnection)
                objCommand.CommandType = CommandType.StoredProcedure

                objCommand.Parameters.AddWithValue("@Number", Val(txtNumber.Text))
                objCommand.Parameters.AddWithValue("@MemberName", txtName.Text.Trim)
                objCommand.Parameters.AddWithValue("@MemberName_Tamil", txtMemberName_Tamil.Text.Trim)
                objCommand.Parameters.AddWithValue("@EmployeeNumber", Val(txtEmployeeNumber.Text))
                objCommand.Parameters.AddWithValue("@TdOpening", Val(txtTDOpening.Text))
                objCommand.Parameters.AddWithValue("@ShareOpening", Val(txtShareOpening.Text))
                objCommand.Parameters.AddWithValue("@status", IIf(cmbStatus.SelectedIndex = 0, 1, 0))
                objCommand.Parameters.AddWithValue("@MemberType", CmbMemberType.Text)
                objCommand.Parameters.AddWithValue("@Address1", txtAddress1.Text)
                objCommand.Parameters.AddWithValue("@Address2", txtAddress2.Text)
                objCommand.Parameters.AddWithValue("@Address3", txtAddress3.Text)
                objCommand.Parameters.AddWithValue("@Address4", txtAddress4.Text)
                objCommand.Parameters.AddWithValue("@Address_Tamil1", txtAddress_Tamil1.Text)
                objCommand.Parameters.AddWithValue("@Address_Tamil2", txtAddress_Tamil2.Text)
                objCommand.Parameters.AddWithValue("@Address_Tamil3", txtAddress_Tamil3.Text)
                objCommand.Parameters.AddWithValue("@Address_Tamil4", txtAddress_Tamil4.Text)
                objCommand.Parameters.AddWithValue("@MobileNo", txtMobileNo.Text)
                objCommand.Parameters.AddWithValue("@Photo_Image", SqlDbType.Image).Value = photo
                objCommand.Parameters.AddWithValue("Fycode", int_FYearCode)
                objCommand.Parameters.AddWithValue("@Node", int_NodeCode)
                objCommand.Parameters.AddWithValue("@user", int_UserCode)
                objCommand.ExecuteNonQuery()

                MessageBox.Show("The record is saved", Mssg, MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnClear_Click(sender, e)
                txtEmployeeNumber.Focus()
            Else
                'objMember.memberCode = txtMemberCode.Text.Trim
                'objMember.UpdateRecords()
                Dim objCommand As New SqlCommand("sp_Member_AddEdit", objSqlConnection)
                objCommand.CommandType = CommandType.StoredProcedure

                objCommand.Parameters.AddWithValue("@memberCode", Val(txtMemberCode.Text))
                objCommand.Parameters.AddWithValue("@Number", Val(txtNumber.Text))
                objCommand.Parameters.AddWithValue("@MemberName", txtName.Text.Trim)
                objCommand.Parameters.AddWithValue("@MemberName_Tamil", txtMemberName_Tamil.Text.Trim)
                objCommand.Parameters.AddWithValue("@EmployeeNumber", Val(txtEmployeeNumber.Text))
                objCommand.Parameters.AddWithValue("@TdOpening", Val(txtTDOpening.Text))
                objCommand.Parameters.AddWithValue("@ShareOpening", Val(txtShareOpening.Text))
                objCommand.Parameters.AddWithValue("@status", IIf(cmbStatus.SelectedIndex = 0, 1, 0))
                objCommand.Parameters.AddWithValue("@MemberType", CmbMemberType.Text)
                objCommand.Parameters.AddWithValue("@Address1", txtAddress1.Text)
                objCommand.Parameters.AddWithValue("@Address2", txtAddress2.Text)
                objCommand.Parameters.AddWithValue("@Address3", txtAddress3.Text)
                objCommand.Parameters.AddWithValue("@Address4", txtAddress4.Text)
                objCommand.Parameters.AddWithValue("@Address_Tamil1", txtAddress_Tamil1.Text)
                objCommand.Parameters.AddWithValue("@Address_Tamil2", txtAddress_Tamil2.Text)
                objCommand.Parameters.AddWithValue("@Address_Tamil3", txtAddress_Tamil3.Text)
                objCommand.Parameters.AddWithValue("@Address_Tamil4", txtAddress_Tamil4.Text)
                objCommand.Parameters.AddWithValue("@MobileNo", txtMobileNo.Text)
                objCommand.Parameters.AddWithValue("@Photo_Image", SqlDbType.Image).Value = photo
                objCommand.Parameters.AddWithValue("Fycode", int_FYearCode)
                objCommand.Parameters.AddWithValue("@Node", int_NodeCode)
                objCommand.Parameters.AddWithValue("@user", int_UserCode)
                objCommand.ExecuteNonQuery()
                MessageBox.Show("The record is updated", Mssg, MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnExit_Click(sender, e)
            End If
            frmMemberDetails.Grid.RecordSet(objMember.GetRecords(), "membercode,strEmpNo")
            frmMemberDetails.Grid.Columns("MemberName").Width = 200
        Catch ex As Exception
            If ex.Message.Contains("UK_tbl_Member") Then
                MessageBox.Show("Already exist the Member Name", Mssg, MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtNumber.Focus()
            Else
                MsgBox(ex.Message, MsgBoxStyle.Information, Mssg)
            End If
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        btnClear_Click(sender, e)
        frmMemberDetails.Grid.RecordSet(objMember.GetRecords(), "MemberCode")
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        PanelClear(Panel1)
        'PanelClear(PnlImage)
        llblClearImage_Click(sender, e)
        FormClear(Me)
        'Dim objgetmember As DataTable = objMember.GetMemberNumber()
        'txtNumber.Text = objgetmember.Rows.Item(0)("Number")
        txtNumber.Focus()
    End Sub

    Private Sub llbSelectlImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles llbSelectlImage.Click
        Try
            Dim fopen As New OpenFileDialog
            fopen.FileName = ""
            fopen.Filter = "Image Files (*.jpg)|*.jpg|(*.jpeg)|*.JPEG|(*.gif)|*.gif|(*.png)|*.png|All Files (*.*)|*.*"
            fopen.ShowDialog()
            txtImagePath.Text = fopen.FileName
            pbImage.Image = System.Drawing.Bitmap.FromFile(fopen.FileName)
            btnSave.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Mssg)
        End Try
    End Sub

    Private Sub llblClearImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles llblClearImage.Click
        pbImage.Image = LMW.My.Resources.Resources.white
        txtImagePath.Text = ""
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        iDevice = lstDevices.SelectedIndex
        OpenPreviewWindow()
    End Sub


    Private Sub ClosePreviewWindow()
        ' Disconnect from device
        SendMessage(hHwnd, WM_CAP_DRIVER_DISCONNECT, iDevice, 0)
        ' close window
        DestroyWindow(hHwnd)
    End Sub

    Private Sub OpenPreviewWindow()
        Dim iHeight As Integer = pbImage.Height
        Dim iWidth As Integer = pbImage.Width

        '
        ' Open Preview window in picturebox
        '
        hHwnd = capCreateCaptureWindowA(iDevice, WS_VISIBLE Or WS_CHILD, 0, 0, 640, _
            480, pbImage.Handle.ToInt32, 0)

        '
        ' Connect to device
        '
        If SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0) Then
            '
            'Set the preview scale
            '
            SendMessage(hHwnd, WM_CAP_SET_SCALE, True, 0)

            '
            'Set the preview rate in milliseconds
            '
            SendMessage(hHwnd, WM_CAP_SET_PREVIEWRATE, 66, 0)

            '
            'Start previewing the image from the camera
            '
            SendMessage(hHwnd, WM_CAP_SET_PREVIEW, True, 0)

            '
            ' Resize window to fit in picturebox
            '
            SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, pbImage.Width, pbImage.Height, _
                    SWP_NOMOVE Or SWP_NOZORDER)

            btnTakePhoto.Enabled = True
            'btnStop.Enabled = True
            btnStart.Enabled = False
        Else
            '
            ' Error connecting to device close window
            ' 
            DestroyWindow(hHwnd)

            btnTakePhoto.Enabled = False
        End If
    End Sub
    Private Sub btnTakePhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTakePhoto.Click
        Dim data As IDataObject
        Dim bmap As Image

        '
        ' Copy image to clipboard
        '
        SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0)

        '
        ' Get image from clipboard and convert it to a bitmap
        '
        data = Clipboard.GetDataObject()
        If data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
            'bmap = CType(data.GetData(GetType(System.Drawing.Bitmap)), Image)
            bmap = CType(data.GetData(GetType(System.Drawing.Bitmap)), Image)
            pbImage.Image = bmap
            ClosePreviewWindow()
            btnTakePhoto.Enabled = False
            'btnStop.Enabled = False
            btnStart.Enabled = True

            'If sfdImage.ShowDialog = DialogResult.OK Then
            '    bmap.Save(sfdImage.FileName, Imaging.ImageFormat.Bmp)
            'End If

        End If
    End Sub

End Class