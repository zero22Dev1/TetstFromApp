For row As Integer = C1FlexGrid1.Rows.Fixed To C1FlexGrid1.Rows.Count - 1
    Dim isChecked As Boolean = CBool(C1FlexGrid1(row, 0))
    If isChecked Then
        ' チェックされている行の処理
        Dim itemName As String = C1FlexGrid1(row, 1).ToString()
        Debug.Print("チェックされた商品: " & itemName)
    End If
Next



For row As Integer = C1FlexGrid1.Rows.Fixed To C1FlexGrid1.Rows.Count - 1
    For col As Integer = C1FlexGrid1.Cols.Fixed To C1FlexGrid1.Cols.Count - 1
        Dim cellValue As Object = C1FlexGrid1(row, col)

        If TypeOf cellValue Is String Then
            Dim text As String = cellValue.ToString()

            ' 文字列で「-」から始まる値をチェック
            If text.StartsWith("-") Then
                ' マイナス記号を取り除いて表示
                C1FlexGrid1(row, col) = text.Substring(1)

                ' 赤色のスタイルを設定
                Dim redStyle = C1FlexGrid1.Styles.Add("NegativeRed_" & row & "_" & col)
                redStyle.ForeColor = Color.Red
                C1FlexGrid1.SetCellStyle(row, col, redStyle)
            End If
        End If
    Next
Next