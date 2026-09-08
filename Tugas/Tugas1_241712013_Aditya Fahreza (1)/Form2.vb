Public Class FrmPajak

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim pendapatan As Decimal

        If Not Decimal.TryParse(txtPendapatan.Text, pendapatan) Then
            MessageBox.Show("Masukkan angka pendapatan yang valid!")
            txtPendapatan.Focus()
            Return
        End If

        Dim pajak As Decimal = 0

        If pendapatan > 100000000 Then
            pajak = pendapatan * 0.3D
        ElseIf pendapatan > 30000000 Then
            pajak = pendapatan * 0.2D
        ElseIf pendapatan > 5000000 Then
            pajak = pendapatan * 0.1D
        Else
            pajak = 0
        End If

        MessageBox.Show("Total Pajak: Rp " & pajak.ToString("N0"))
    End Sub

    Private Sub txtPendapatan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPendapatan.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
        FrmLogin.Show()
    End Sub

End Class