For row As Integer = C1FlexGrid1.Rows.Fixed To C1FlexGrid1.Rows.Count - 1
    Dim isChecked As Boolean = CBool(C1FlexGrid1(row, 0))
    If isChecked Then
        ' チェックされている行の処理
        Dim itemName As String = C1FlexGrid1(row, 1).ToString()
        Debug.Print("チェックされた商品: " & itemName)
    End If
Next