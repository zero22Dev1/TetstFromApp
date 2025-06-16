```vbnet
Private Sub C1FlexGrid1_CellChecked(sender As Object, e As RowColEventArgs) Handles C1FlexGrid1.CellChecked
    ' チェックボックス列の列インデックス取得（例："選択"列）
    Dim checkColIndex As Integer = -1
    For col As Integer = C1FlexGrid1.Cols.Fixed To C1FlexGrid1.Cols.Count - 1
        If C1FlexGrid1(0, col).ToString() = "選択" Then
            checkColIndex = col
            Exit For
        End If
    Next

    If checkColIndex = -1 Then Exit Sub

    Dim row As Integer = e.Row
    Dim isChecked As Boolean = C1FlexGrid1(row, checkColIndex)

    ' スタイルを作成または取得
    Dim checkedStyle = C1FlexGrid1.Styles("CheckedRow")
    If checkedStyle Is Nothing Then
        checkedStyle = C1FlexGrid1.Styles.Add("CheckedRow")
        checkedStyle.BackColor = Color.LightGreen
    End If

    ' チェックされたら背景色を変える
    If isChecked Then
        C1FlexGrid1.Rows(row).Style = checkedStyle
    Else
        ' チェックを外した場合はスタイルを戻す
        C1FlexGrid1.Rows(row).Style = Nothing
    End If
End Sub
```