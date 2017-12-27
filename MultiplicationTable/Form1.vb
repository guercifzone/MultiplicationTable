Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n1, n2, i As Integer
        n1 = Val(TextBox1.Text)
        n2 = Val(TextBox2.Text)

        For i = 1 To n2
            Dim a As Integer
            a = n1 * i
            TextBox3.Text = TextBox3.Text & n1 & " * " & i & " = " & a
            TextBox3.Text = TextBox3.Text & vbCrLf
        Next

    End Sub
End Class
