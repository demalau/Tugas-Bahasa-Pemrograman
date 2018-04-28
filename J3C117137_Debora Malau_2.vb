Public Class Form6

    Private Sub hitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hitung.Click
        Dim a As String
        Dim b, c, d, f As Double

        a = nama.Text
        b = nilai1.Text
        c = nilai2.Text
        d = nilai3.Text
        f = (b + c + d) / 3
        rata.Text = f

        If rata.Text > 80 Then
            hadiah.Text = "Rp.10.000.000"
        ElseIf rata.Text > 75 Then
            hadiah.Text = "Rp.7.500.000"
        Else
            hadiah.Text = "Hanya dapat Sertifikat"
        End If

    End Sub

    Private Sub clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear.Click
        Close()
    End Sub
End Class
