Public Class Form1

 



    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim a As Double
        Dim b As Double

        Dim c As Double
        a = TextBox1.Text
        b = TextBox2.Text
        c = TextBox3.Text
        ListBox1.Items.Add(Math.Cosh(a))

    End Sub
End Class
