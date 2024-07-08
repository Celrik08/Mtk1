Public Class Perhitungan

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "Tambah" Then
            TextBox3.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
        ElseIf ComboBox1.Text = "Kurang" Then
            TextBox3.Text = Val(TextBox1.Text) - Val(TextBox2.Text)
        ElseIf ComboBox1.Text = "Kali" Then
            TextBox3.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
        ElseIf ComboBox1.Text = "Bagi" Then
            TextBox3.Text = Val(TextBox1.Text) / Val(TextBox2.Text)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""
        TextBox3.Text = ""
    End Sub
End Class