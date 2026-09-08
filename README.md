# 💻 Praktikum Pemrograman Visual

<p align="center">
  <i>Learning • Creating • Documenting • Growing</i>
</p>

---

## 👨‍💻 About Me

Halo! Saya **Aditya Fahreza**, mahasiswa Program Studi **D-III Teknik Informatika, Fakultas Vokasi, Universitas Sumatera Utara**.

Repository ini saya buat sebagai bagian dari perjalanan pembelajaran saya dalam mengikuti mata kuliah **Praktikum Pemrograman Visual** pada Semester 5.

Bagi saya, proses belajar pemrograman bukan hanya tentang menulis kode dan membuat sebuah program dapat berjalan. Lebih dari itu, setiap proses mencoba, menemukan kesalahan, melakukan perbaikan, dan memahami bagaimana sebuah program bekerja merupakan bagian penting dari perjalanan untuk terus berkembang.

Repository ini menjadi tempat saya untuk **mencatat, menyimpan, dan mendokumentasikan berbagai hal yang saya pelajari selama praktikum**.

---

## 🎓 Student Information

| 📌 Information | 📝 Details |
|:---|:---|
| 👤 **Nama** | Aditya Fahreza |
| 🆔 **NIM** | 241712013 |
| 🏫 **KOM** | A'1 |
| 💻 **Program Studi** | D-III Teknik Informatika |
| 🎓 **Fakultas** | Fakultas Vokasi |
| 🏛️ **Universitas** | Universitas Sumatera Utara |
| 📚 **Semester** | 5 |
| 💡 **Mata Kuliah** | Praktikum Pemrograman Visual |

---

## 📖 About This Repository

Repository ini merupakan **catatan dan dokumentasi pembelajaran** selama mengikuti Praktikum Pemrograman Visual.

Berbagai materi, source code, hasil praktikum, maupun hal-hal penting yang saya temukan selama proses pembelajaran akan disimpan dan disusun di dalam repository ini.

Tujuan utamanya adalah agar setiap proses pembelajaran tidak hanya selesai ketika praktikum berakhir, tetapi juga dapat **didokumentasikan, dipelajari kembali, dan menjadi referensi untuk pengembangan kemampuan di masa mendatang.**

> **"What we learn today becomes the foundation of what we create tomorrow."** 🚀

---

## 🎯 What I Aim to Learn

Melalui praktikum ini, saya ingin lebih memahami bagaimana konsep-konsep Pemrograman Visual dapat diterapkan dalam proses pengembangan sebuah aplikasi.

Beberapa hal yang ingin saya kembangkan melalui proses pembelajaran ini antara lain:

- 🧠 Memahami konsep dasar Pemrograman Visual
- 💻 Meningkatkan kemampuan dalam menulis dan memahami source code
- 🖥️ Memahami pembuatan aplikasi berbasis antarmuka visual
- 🛠️ Melatih kemampuan problem solving dan debugging
- 📚 Membiasakan diri mendokumentasikan proses pembelajaran
- 🚀 Mengembangkan pola berpikir yang lebih terstruktur dalam membangun sebuah aplikasi

---

## 🌱 Learning Journey

Setiap kode yang ditulis memiliki proses di baliknya.

Ada saat ketika program berjalan dengan baik, ada saat ketika muncul error yang tidak terduga, dan ada pula saat ketika harus mencoba berkali-kali untuk mendapatkan hasil yang diinginkan.

Namun, justru dari proses tersebut pembelajaran terjadi.

Repository ini menjadi bagian kecil dari **learning journey** saya dalam memahami dunia pemrograman — dari sekadar mencoba, kemudian memahami, hingga akhirnya mampu menciptakan sesuatu.

> **Learn → Practice → Explore → Build → Improve.** 💡

---

## ⚡ Repository Philosophy

Saya percaya bahwa dokumentasi yang baik dapat membuat proses belajar menjadi lebih berarti.

Karena itu, repository ini tidak hanya berisi hasil akhir dari praktikum, tetapi juga menjadi **rekam jejak proses belajar dan perkembangan kemampuan saya selama mempelajari Pemrograman Visual.**

Semoga setiap catatan dan project yang ada di dalam repository ini dapat menjadi pengingat tentang apa yang telah dipelajari dan sejauh mana proses perkembangan yang telah dilalui.

---

<p align="center">
  <b>💻 Keep Learning. Keep Building. Keep Growing. 🚀</b>
</p>

<p align="center">
  <sub>Praktikum Pemrograman Visual • Semester 5 • 2026</sub>
</p>



# Panduan Lengkap: Membuat Aplikasi Login dan Perhitungan Pajak (VB.NET)

Catatan ini berisi langkah-langkah lengkap dari awal untuk mendesain form, menuliskan kode, hingga penjelasan baris per baris tentang fungsi dari kode yang digunakan. Gaya penulisan kode sudah disesuaikan agar lebih natural, mudah dibaca, dan umum digunakan oleh *programmer* saat sedang *coding*.

---

## TAHAP 1: Persiapan File Gambar (Sangat Penting)
Sebelum masuk ke Visual Studio, pastikan kamu sudah mengatur foldernya agar gambar bisa muncul saat di-*run*.

1. Buka project Visual Studio kamu.
2. Di layar **Solution Explorer** (sebelah kanan), klik kanan pada nama Project.
3. Pilih **Add** -> **New Folder**, lalu beri nama foldernya: **Assets**.
4. Masukkan file `manager.png` dan `staff.png` ke dalam folder **Assets** tersebut (klik kanan folder Assets -> **Add** -> **Existing Item** -> cari gambarmu).
5. Klik file gambarnya satu per satu di Solution Explorer, lalu lihat di jendela **Properties** (biasanya di bawah). Ubah opsi **Copy to Output Directory** menjadi **Copy always**.

---

## TAHAP 2: Pembuatan Form 1 (Login)

### 1. Langkah Desain (Form1.vb [Design])
1. Buka `Form1.vb [Design]`.
2. Dari **ToolBox**, tarik `PictureBox` ke form. Ubah namanya di *Properties* menjadi `PictureBox1`. Pastikan ukurannya persegi (misal: Size 150, 150) agar potongannya nanti bulat sempurna.
3. Tarik `Label` untuk membuat tulisan "Role :", "Nama :", dan "NIM :".
4. Tarik `ComboBox` letakkan di sebelah label Role. Ubah namanya menjadi `cmbRole`.
5. Tarik `TextBox` untuk input Nama, ubah namanya menjadi `txtNama`.
6. Tarik `TextBox` untuk input NIM, ubah namanya menjadi `txtNIM`.
7. Tarik `Button` untuk tombol masuk, ubah namanya menjadi `btnLogin` dan ubah `Text`-nya menjadi "Login".

### 2. Kode untuk Form 1 (Form1.vb)
Klik kanan area kosong di form, pilih **View Code**, lalu *paste* kode di bawah ini. Kode ini sudah ditulis dengan gaya yang lebih natural dan rapi.

Imports System.Drawing.Drawing2D

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim path As New GraphicsPath()
        path.AddEllipse(0, 0, PictureBox1.Width, PictureBox1.Height)
        PictureBox1.Region = New Region(path)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

        cmbRole.Items.Add("Manager")
        cmbRole.Items.Add("Staff")
    End Sub

    Private Sub cmbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRole.SelectedIndexChanged
        Dim role As String = If(cmbRole.SelectedItem IsNot Nothing, cmbRole.SelectedItem.ToString(), String.Empty)
        If String.IsNullOrEmpty(role) Then
            Return
        End If

        Dim assetsDir = System.IO.Path.Combine(Application.StartupPath, "Assets")
        Dim imgFile As String = If(role = "Manager", System.IO.Path.Combine(assetsDir, "manager.png"), System.IO.Path.Combine(assetsDir, "staff.png"))

        If System.IO.File.Exists(imgFile) Then
            ' Dispose previous image to avoid locking the file
            If PictureBox1.Image IsNot Nothing Then
                PictureBox1.Image.Dispose()
                PictureBox1.Image = Nothing
            End If
            PictureBox1.Image = Image.FromFile(imgFile)
        Else
            ' File missing: clear image or set a default placeholder
            PictureBox1.Image = Nothing
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True '
        End If
    End Sub

    Private Sub txtNIM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIM.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True '
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim validNamaManager As String = "Aditya Fahreza"
        Dim validNIMManager As String = "241712013"
        Dim validNamaStaff As String = "Auzan"
        Dim validNIMStaff As String = "241712015"

        Dim isValid As Boolean = False

        If cmbRole.SelectedItem IsNot Nothing Then
            If cmbRole.SelectedItem.ToString() = "Manager" AndAlso txtNama.Text = validNamaManager AndAlso txtNIM.Text = validNIMManager Then
                isValid = True
            ElseIf cmbRole.SelectedItem.ToString() = "Staff" AndAlso txtNama.Text = validNamaStaff AndAlso txtNIM.Text = validNIMStaff Then
                isValid = True
            End If
        End If

        If isValid Then
            Dim frmPajak As New Form2()
            frmPajak.Show()
            Me.Hide() '
        Else
            MessageBox.Show("Role, Nama, atau NIM tidak cocok!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class

TAHAP 3: Pembuatan Form 2 (Pajak Pendapatan)
1. Langkah Desain (Form2.vb [Design])
Ke menu Project -> Add Form (Windows Forms). Beri nama Form2.vb.

Tarik beberapa Label untuk menuliskan info syarat pajak dan teks "Masukkan Pendapatan" serta "Rp.".

Tarik TextBox untuk input nilai pendapatan, ubah namanya menjadi txtPendapatan.

Tarik Button, beri nama btnHitung dan ubah teksnya menjadi "Hitung".

2. Kode untuk Form 2 (Form2.vb)
Klik kanan form, pilih View Code, paste kode ini:

Public Class Form2

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim pendapatan As Double

        ' Mengecek apakah input yang dimasukkan adalah angka
        If Double.TryParse(txtPendapatan.Text, pendapatan) Then

            ' Logika Cek Pajak dari yang tertinggi ke terendah
            If pendapatan > 100000000 Then
                MessageBox.Show("Pendapatan anda lebih dari 100 juta, anda dikenakan pajak 30%", "Hasil Pajak", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf pendapatan > 30000000 Then
                MessageBox.Show("Pendapatan anda lebih dari 30 juta, anda dikenakan pajak 20%", "Hasil Pajak", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf pendapatan > 5000000 Then
                MessageBox.Show("Pendapatan anda lebih dari 5 juta, anda dikenakan pajak 10%", "Hasil Pajak", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                ' Jika 5 juta ke bawah (termasuk 3 juta)
                MessageBox.Show("Total pendapatan " & pendapatan.ToString("N0") & ", anda tidak dikenakan pajak", "Hasil Pajak", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Else
            MessageBox.Show("Harap masukkan nominal angka yang valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Tambahan: Agar textbox pendapatan hanya bisa diisi angka
    Private Sub txtPendapatan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPendapatan.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class

PENJELASAN FUNGSI KODE

Imports System.Drawing.Drawing2D dan Imports System.IO

Ini seperti memanggil "buku kamus" tambahan ke dalam program. Drawing2D dipanggil karena kita butuh alat bernama GraphicsPath untuk menggambar bentuk bulat. System.IO dipanggil agar program bisa membaca file di dalam folder komputer kita.

GraphicsPath & AddEllipse (di Form1_Load)

Secara bawaan (default), PictureBox di Visual Basic bentuknya kotak. Perintah ini membuat "jalur pemotongan" berbentuk elips/lingkaran sebesar ukuran kotaknya, lalu menerapkan potongan tersebut ke PictureBox. Hasilnya fotomu jadi bulat seperti foto profil kekinian.

Application.StartupPath

Ini adalah kode pencari alamat otomatis. Kode ini mencari tahu di folder mana program aplikasi (file .exe) ini sedang berjalan, lalu kita gabungkan (menggunakan tanda &) dengan tulisan "\Assets\manager.png" untuk menemukan posisi persis gambar tersebut disimpan.

PictureBox1.Image.Dispose()

Dispose artinya "membuang/melepas". Saat kita memuat gambar A, Windows kadang "mengunci" file gambar A tersebut. Jika kita ingin menggantinya ke gambar B (saat role diganti), program bisa error jika gambar lamanya masih terkunci. Dispose() bertugas melepaskan kuncian gambar lama sebelum memasukkan gambar baru.

e.Handled = True (di Event KeyPress)

e.KeyChar adalah tombol keyboard yang kamu pencet.

Char.IsDigit mengecek apakah itu angka.

Char.IsLetter mengecek apakah itu huruf.

e.Handled = True artinya "Tahan! Jangan teruskan ketikan ini ke layar". Itulah alasannya jika kamu mengetikkan angka di kolom Nama, angkanya tidak mau muncul, karena program langsung memblokirnya (e.Handled = True).

Double.TryParse(txtPendapatan.Text, totalPendapatan) (di Form 2)

Ini adalah cara aman untuk mengubah teks menjadi angka. Program akan mencoba (Try) membaca apa yang diketik pengguna di kolom pendapatan. Jika bentuknya valid (bisa diubah jadi angka), nilainya dimasukkan ke variabel totalPendapatan lalu lanjut ke proses hitung pajak. Kalau bentuknya ngawur (misalnya pengguna meng-copy paste teks), program tidak akan crash dan akan langsung memunculkan pesan peringatan di blok Else bawahnya.

Urutan Pengecekan If dari 100 Juta, 30 Juta, lalu 5 Juta (di Form 2)

Kenapa logikanya harus dari yang terbesar dulu? Bayangkan jika kamu cek 5 juta lebih dulu: Jika ada orang berpendapatan 150 juta, program akan bilang "Oh, 150 juta itu lebih besar dari 5 juta, berikan pajak 10%", dan kodenya berhenti di sana padahal seharusnya kena 30%. Dengan mengecek angka 100 juta lebih dulu, angka 150 juta akan langsung tersaring di baris paling atas dan tidak salah masuk.
