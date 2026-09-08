Imports System.Drawing.Drawing2D
Imports System.IO

Public Class FrmLogin

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbRole.Items.AddRange({"Staff", "Manager"})
        AturGambarBulat()
    End Sub

    Private Sub AturGambarBulat()
        Dim path As New GraphicsPath()
        path.AddEllipse(0, 0, PicImage.Width, PicImage.Height)
        PicImage.Region = New Region(path)
        PicImage.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub cmbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRole.SelectedIndexChanged
        If cmbRole.Text = "" Then Return

        Dim folderGambar As String = Application.StartupPath & "\Assets\"
        Dim namaFile As String = If(cmbRole.Text = "Manager", "manager.png", "staff.png")
        Dim pathLengkap As String = folderGambar & namaFile

        If File.Exists(pathLengkap) Then
            If PicImage.Image IsNot Nothing Then
                PicImage.Image.Dispose()
                PicImage.Image = Nothing
            End If

            PicImage.Image = Image.FromFile(pathLengkap)
            AturGambarBulat()
        Else
            MessageBox.Show("File gambar " & namaFile & " tidak ditemukan di folder Assets!")
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNIM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIM.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim nama As String = txtNama.Text.Trim()
        Dim nim As String = txtNIM.Text.Trim()

        Dim isStaff As Boolean = (cmbRole.Text = "Staff" AndAlso nama = "Nadya" AndAlso nim = "241712051")
        Dim isManager As Boolean = (cmbRole.Text = "Manager" AndAlso nama = "Shata Diyaul Haq" AndAlso nim = "241712061")

        If isStaff OrElse isManager Then
            Dim frm As New FrmPajak()
            frm.Show()
            Me.Hide()

            txtNama.Clear()
            txtNIM.Clear()
        Else
            MessageBox.Show("Masukkan Akun dengan Benar")
            txtNIM.Focus()
        End If
    End Sub

End Class