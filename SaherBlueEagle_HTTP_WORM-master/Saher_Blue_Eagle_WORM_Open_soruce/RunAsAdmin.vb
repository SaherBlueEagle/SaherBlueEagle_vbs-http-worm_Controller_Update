Public Class RunAsAdmin
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
    Public Shared Function mainExists(ByVal exeName As String) As Boolean
        'This function double checks to make sure that the main Executable of the application does exist
        Try
            If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "/" + exeName) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Function adminExists() As Boolean
        'This function double checks to make sure that the RunAsAdmin executable file does exist
        Try
            If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "/RunAsAdmin.exe") Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Sub runAsAdmin(ByVal mainExeName As String, ByVal Command As String, ByVal sender As Object)
        Try
            If Command <> "launcher" Then
                If mainExists(mainExeName) = True Then
                    If adminExists() = True Then
                        Process.Start(My.Application.Info.DirectoryPath + "/RunAsAdmin.exe", mainExeName.ToString)
                        System.Threading.Thread.Sleep(3000)
                        CType(sender, System.Windows.Forms.Form).Close()
                    End If
                End If
            Else
                'The application was already started with the Launcher, it does not need to be rerun
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class