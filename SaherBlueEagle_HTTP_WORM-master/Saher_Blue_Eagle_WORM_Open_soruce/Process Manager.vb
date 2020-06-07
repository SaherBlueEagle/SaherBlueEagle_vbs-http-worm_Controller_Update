Public Class Process_Manager
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
    Private Sub REFRESH_ALL()
        ListView1.Items.Clear()
        Form1.Send_to_Client("get_proc" & FUNC.SPL, key)
    End Sub
    Private Sub RenameFileToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RenameFileToolStripMenuItem.Click
        REFRESH_ALL()
    End Sub

    Private Sub KillToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KillToolStripMenuItem.Click
        For Each itm As ListViewItem In ListView1.SelectedItems
            Dim P_NAME As String = itm.Text
            'MsgBox(P_NAME)
            Form1.Send_to_Client("kill_pro" & FUNC.SPL & P_NAME & FUNC.SPL, key)
        Next

    End Sub

    Private Sub Process_Manager_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        REFRESH_ALL()
        Form1.Send_to_Client("get_proc" & FUNC.SPL, key)
    End Sub
End Class