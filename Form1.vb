Public Class Form1
    Dim harga, subtot As Single
    Dim nsub, tagihan, n1, n2, n3, n4, n5, n6 As Single


    Private Sub cb1_CheckedChanged(sender As Object, e As EventArgs) Handles cb1.CheckedChanged
        If cb1.Checked = True Then
            txharga1.BackColor = Color.White
            txharga1.Text = Format(12000, "#,##")
            harga = 12000
            byr1.Focus()
        Else
            txharga1.BackColor = Color.Gray
            txharga1.Text = ""
            byr1.Text = ""
        End If
    End Sub
    Private Sub cb2_CheckedChanged(sender As Object, e As EventArgs) Handles cb2.CheckedChanged
        If cb2.Checked = True Then
            txharga2.BackColor = Color.White
            txharga2.Text = Format(10000, "#,##")
            harga = 10000
            byr2.Focus()
        Else
            txharga2.BackColor = Color.Gray
            txharga2.Text = ""
            byr2.Text = ""
        End If
    End Sub
    Private Sub cb3_CheckedChanged(sender As Object, e As EventArgs) Handles cb3.CheckedChanged
        If cb1.Checked = True Then
            txharga3.BackColor = Color.White
            txharga3.Text = Format(15000, "#,##")
            harga = 15000
            byr3.Focus()
        Else
            txharga3.BackColor = Color.Gray
            txharga3.Text = ""
            byr3.Text = ""
        End If
    End Sub
    Private Sub cb4_CheckedChanged(sender As Object, e As EventArgs) Handles cb4.CheckedChanged
        If cb4.Checked = True Then
            txharga4.BackColor = Color.White
            txharga4.Text = Format(14000, "#,##")
            harga = 14000
            byr4.Focus()
        Else
            txharga4.BackColor = Color.Gray
            txharga4.Text = ""
            byr4.Text = ""
        End If
    End Sub
    Private Sub cb5_CheckedChanged(sender As Object, e As EventArgs) Handles cb5.CheckedChanged
        If cb5.Checked = True Then
            txharga5.BackColor = Color.White
            txharga5.Text = Format(8000, "#,##")
            harga = 8000
            byr5.Focus()
        Else
            txharga5.BackColor = Color.Gray
            txharga5.Text = ""
            byr5.Text = ""
        End If
    End Sub


    Private Sub cb6_CheckedChanged(sender As Object, e As EventArgs) Handles cb6.CheckedChanged
        If cb6.Checked = True Then
            txharga6.BackColor = Color.White
            txharga6.Text = Format(3000, "#,##")
            harga = 3000
            byr6.Focus()
        Else
            txharga6.BackColor = Color.Gray
            txharga6.Text = ""
            byr6.Text = ""
        End If
    End Sub
    Private Sub byr1_TextChanged(sender As Object, e As EventArgs) Handles byr1.TextChanged
        subtot = Val(harga) * Val(byr1.Text)
        shrg1.Text = Format(subtot, "#,##")
        n1 = subtot
        Call hitung()
    End Sub
    Private Sub byr2_TextChanged(sender As Object, e As EventArgs) Handles byr2.TextChanged
        subtot = Val(harga) * Val(byr2.Text)
        shrg2.Text = Format(subtot, "#,##")
        n2 = subtot
        Call hitung()
    End Sub
    Private Sub byr3_TextChanged(sender As Object, e As EventArgs) Handles byr3.TextChanged
        subtot = Val(harga) * Val(byr3.Text)
        shrg3.Text = Format(subtot, "#,##")
        n3 = subtot
        Call hitung()
    End Sub
    Private Sub byr4_TextChanged(sender As Object, e As EventArgs) Handles byr4.TextChanged
        subtot = Val(harga) * Val(byr4.Text)
        shrg4.Text = Format(subtot, "#,##")
        n4 = subtot
        Call hitung()
    End Sub
    Private Sub byr5_TextChanged(sender As Object, e As EventArgs) Handles byr5.TextChanged
        subtot = Val(harga) * Val(byr5.Text)
        shrg5.Text = Format(subtot, "#,##")
        n5 = subtot
        Call hitung()
    End Sub

    Private Sub byr6_TextChanged(sender As Object, e As EventArgs) Handles byr6.TextChanged
        subtot = Val(harga) * Val(byr6.Text)
        shrg6.Text = Format(subtot, "#,##")
        n6 = subtot
        Call hitung()
    End Sub
    Sub hitung()
        nsub = n1 + n2 + n3 + n4 + n5 + n6
        txtotpem.Text = FormatCurrency(nsub)
        If nsub >= 200000 Then
            Dim nDis As Single
            nDis = nsub * 0.15
            txdiskon.Text = Format(nDis, "#,##")
            tagihan = nsub - nDis
        ElseIf nsub >= 100000 Then
            Dim nDis As Single
            nDis = nsub * 0.1
            txdiskon.Text = Format(nDis, "#,##")
            tagihan = nsub - nDis
        Else Dim nDis As Single
            nDis = nsub * 0
            txdiskon.Text = Format(nDis, "#,##")
            tagihan = nsub - nDis
            'MessageBox.Show("TOTAL PEMBELIAN KURANG DARI 100 RIBU TIDAK MENDAPAT DISKON")
        End If
        txtagihan.Text = FormatCurrency(tagihan)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cb1.Checked = False
        cb2.Checked = False
        cb3.Checked = False
        cb4.Checked = False
        cb5.Checked = False
        cb6.Checked = False
    End Sub
End Class
