Public Class Form1
    Dim ad, soyad, tc As String

    Private Sub kadinbtn_CheckedChanged(sender As Object, e As EventArgs) Handles kadinbtn.CheckedChanged
        GroupBox2.Visible = False
    End Sub

    Private Sub erkekbtn_CheckedChanged(sender As Object, e As EventArgs) Handles erkekbtn.CheckedChanged
        GroupBox2.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ad = TextBox1.Text
        soyad = TextBox2.Text

        tc = MaskedTextBox1.Text
        ListBox1.Items.Add("Ad Soyad: " & ad & " " & soyad)
        ListBox1.Items.Add("TC:" & tc)

        If kadinbtn.Checked = True Then
            ListBox1.Items.Add("Cinsiyeti: Kadın")

        ElseIf erkekbtn.Checked = True Then
            ListBox1.Items.Add("Cinsiyeti: Erkek")

            If yapti.Checked = True Then
                ListBox1.Items.Add("Askerlik: Yaptı")
            ElseIf yapmadi.Checked = True Then
                ListBox1.Items.Add("Askerlik: Yapmadı")
            ElseIf muaf.Checked = True Then
                ListBox1.Items.Add("Askerlik: Muaf")
            Else
                MsgBox("Asker Kaçağı", MsgBoxStyle.Critical, "Uyarı")
            End If


        Else
            MsgBox("Cinisyet belirt", MsgBoxStyle.Critical, "uyarı")
        End If
        ListBox1.Items.Add("******************************" & Chr(13))
    End Sub
End Class
