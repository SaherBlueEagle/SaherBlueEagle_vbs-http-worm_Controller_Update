Public Class Sql_login
    Public key As String

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'do_Sql_login
        If TextBox1.Text.Length > 2 Then
            If RadioButton1.Checked Then

                Form1.Send_to_Client("do_wind_auth_login" & FUNC.SPL & "" & FUNC.SPL & "" & FUNC.SPL & TextBox1.Text & FUNC.SPL, key)
                Exit Sub
            End If
            If TextBox2.Text.Length >= 2 Then

                Form1.Send_to_Client("do_Sql_login" & FUNC.SPL & TextBox2.Text & FUNC.SPL & TextBox3.Text & FUNC.SPL & TextBox1.Text & FUNC.SPL, key)

            Else

                MsgBox("Enter a valid Username ", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("Enter a valid Server name / local ip address", MsgBoxStyle.Critical)
        End If

    End Sub
    Protected Friend Sub login_success(ByVal constr As String)

        Form1.Send_to_Client("loginsuc_sql" & FUNC.SPL & constr & FUNC.SPL, key)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            RadioButton1.Checked = False
            TextBox3.Enabled = True
            TextBox2.Enabled = True
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            RadioButton2.Checked = False
            TextBox3.Enabled = False
            TextBox2.Enabled = False
        End If
    End Sub
End Class