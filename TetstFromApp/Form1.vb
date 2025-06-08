Public Class Form1
    Inherits Form

    Private currentBorderColor As Color = Color.Blue

    Public Sub New()
        InitializeComponent()
        Me.Size = New Size(1280, 800)
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Padding = New Padding(5)
        Me.StartPosition = FormStartPosition.CenterScreen

        ' ボタン初期

        ' 初期状態を設定
        SetStatus("normal")
    End Sub

    Public Sub SetStatus(status As String)
        Select Case status.ToLower()
            Case "normal"
                currentBorderColor = Color.Blue
                OKButton.FlatAppearance.BorderColor = Color.Blue
                OKButton.Visible = False
                OKButton.FlatStyle = FlatStyle.Flat
                OKButton.FlatAppearance.BorderSize = 3
                ReturnButton.FlatAppearance.BorderColor = Color.Blue
                ReturnButton.Visible = True
                ReturnButton.FlatStyle = FlatStyle.Flat
                ReturnButton.FlatAppearance.BorderSize = 3
                NoButton.FlatAppearance.BorderColor = Color.Blue
                NoButton.Visible = False
                NoButton.FlatStyle = FlatStyle.Flat
                NoButton.FlatAppearance.BorderSize = 3
            Case "error"
                currentBorderColor = Color.Red
                OKButton.FlatAppearance.BorderColor = Color.Red
                OKButton.Visible = False
                ReturnButton.FlatAppearance.BorderColor = Color.Red
                ReturnButton.Visible = True
                NoButton.FlatAppearance.BorderColor = Color.Red
                NoButton.Visible = False
            Case Else
                currentBorderColor = Color.Blue
                OKButton.FlatAppearance.BorderColor = Color.Blue
                OKButton.Visible = True
                OKButton.FlatStyle = FlatStyle.Flat
                OKButton.FlatAppearance.BorderSize = 3
                ReturnButton.FlatAppearance.BorderColor = Color.Blue
                ReturnButton.Visible = False
                ReturnButton.FlatStyle = FlatStyle.Flat
                ReturnButton.FlatAppearance.BorderSize = 3
                NoButton.FlatAppearance.BorderColor = Color.Blue
                NoButton.Visible = True
                NoButton.FlatStyle = FlatStyle.Flat
                NoButton.FlatAppearance.BorderSize = 3
        End Select

        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Using pen As New Pen(currentBorderColor, 5)
            e.Graphics.DrawRectangle(pen, 0, 0, Me.ClientSize.Width - 1, Me.ClientSize.Height - 1)
        End Using
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        If MessageBox.Show("続けますか？", "確認", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            ' OKが押されたとき
        End If
        Me.Close()
    End Sub

    Private Sub ReturnButton_Click(sender As Object, e As EventArgs) Handles ReturnButton.Click
        If MessageBox.Show("続けますか？", "確認", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            ' Yesが押されたとき
        End If
        Me.Close()
    End Sub

    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        If MessageBox.Show("続けますか？", "確認", MessageBoxButtons.YesNo) = DialogResult.No Then
            ' NOが押されたとき  
            '    Me.DialogResult = DialogResult.Yes
            Me.Close()

        End If
        Me.Close()
    End Sub
End Class
