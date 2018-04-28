Public Class Form4

    Private Sub hitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hitung.Click
        Dim a, b, c, d, eh, f, g, h, total, bobot As Integer
        Dim Grade As String
        a = txtntukel.Text
        b = txtntubes.Text
        c = txtnuts.Text
        d = txtnuas.Text
        eh = txtbtukel.Text
        f = txtbtubes.Text
        g = txtbuts.Text
        h = txtbuas.Text

        total = (((a * eh) / 100) + ((b * f) / 100) + ((c * g) / 100) + ((d * h) / 100))
        bobot = (eh + f + g + h)
        lbltotal.Text = total

        bobot = (eh + f + g + h)
        If bobot < 100 Then
            MsgBox("Bobot Salah !")
            lbltotal.Text = ""
        ElseIf bobot > 100 Then
            MsgBox("Bobot Salah !")
        End If

        If total > 80 Then
            Grade = "A"
        ElseIf total > 70 Then
            Grade = "B"
        ElseIf total > 60 Then
            Grade = "C"
        ElseIf total > 50 Then
            Grade = "D"
        Else
            Grade = "E"
        End If
        lblgrade.Text = Grade
    End Sub

    Private Sub bersih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bersih.Click
        Close()
    End Sub

End Class