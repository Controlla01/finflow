Public Class Form1
    Dim a, b, c, d, f, g, h, i, j, k, x1, x2 As Double

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calc_btn.Click
        a = firstno_txt.Text
        b = secondno_txt.Text
        c = Thirdno_txt.Text
        d = b * b
        f = 4 * a * c
        g = d - f
        h = Math.Sqrt(g)
        i = 2 * a
        j = -b + g
        k = -b - g
        x1 = Math.Round((j / i), 3)
        x2 = Math.Round((k / i), 3)
        Results1_txt.Text = x1
        Results2_txt.Text = x2


    End Sub
End Class
