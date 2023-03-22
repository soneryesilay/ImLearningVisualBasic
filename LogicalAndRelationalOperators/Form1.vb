Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim iNot As Integer
        iNot = txtnot1.Text

        If iNot < 0 Or iNot > 100 Then
            MsgBox("Lütfen 0 ile 100 arasında bir not girin!")
            Exit Sub 'PROGRAMI DURDURDU'
        End If



        If iNot <= 100 And iNot >= 90 Then
            MsgBox("HARF NOTUNUZ AA")

        ElseIf iNot < 90 And iNot >= 80 Then
            MsgBox("HARF NOTUNUZ AB")

        ElseIf iNot < 80 And iNot >= 70 Then
            MsgBox("HARF NOTUNUZ BB")

        ElseIf iNot < 70 And iNot >= 60 Then
            MsgBox("HARF NOTUNUZ BC")

        ElseIf iNot < 60 And iNot >= 50 Then
            MsgBox("HARF NOTUNUZ CC")

        ElseIf iNot < 50 And iNot >= 40 Then
            MsgBox("HARF NOTUNUZ CD")

        ElseIf iNot < 40 And iNot >= 30 Then
            MsgBox("HARF NOTUNUZ DD")

        ElseIf iNot < 30 And iNot >= 20 Then
            MsgBox("HARF NOTUNUZ DF")

        ElseIf iNot < 20 And iNot >= 0 Then
            MsgBox("HARF NOTUNUZ FF")

        End If

        If iNot >= 50 Then
            MsgBox("DERSİ GEÇTİNİZ")

        Else
            MsgBox("DERSTEN KALDINIZ")
            Exit Sub
        End If


    End Sub
End Class
