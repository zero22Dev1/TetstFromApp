Public Class MaiinForm


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim subForm As New Form2()
        subForm.ReceivedText = TextBox1.Text  ' 子画面へ渡す

        If subForm.ShowDialog() = DialogResult.OK Then
            TextBox1.Text = subForm.ReturnedText  ' 子画面から戻されたデータを表示
        End If
    End Sub
End Class