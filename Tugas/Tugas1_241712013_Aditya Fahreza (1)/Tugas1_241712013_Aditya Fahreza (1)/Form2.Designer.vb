<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPajak
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblLimaJuta = New Label()
        lblTigaPuluhJuta = New Label()
        lblSeratusJuta = New Label()
        lblPendapatan = New Label()
        lblRupiah = New Label()
        txtPendapatan = New TextBox()
        btnHitung = New Button()
        btnKeluar = New Button()
        SuspendLayout()
        ' 
        ' lblLimaJuta
        ' 
        lblLimaJuta.AutoSize = True
        lblLimaJuta.Location = New Point(318, 83)
        lblLimaJuta.Name = "lblLimaJuta"
        lblLimaJuta.Size = New Size(213, 15)
        lblLimaJuta.TabIndex = 0
        lblLimaJuta.Text = "Pendapatan lebih dari 5 juta, 10% Pajak"
        ' 
        ' lblTigaPuluhJuta
        ' 
        lblTigaPuluhJuta.AutoSize = True
        lblTigaPuluhJuta.Location = New Point(318, 120)
        lblTigaPuluhJuta.Name = "lblTigaPuluhJuta"
        lblTigaPuluhJuta.Size = New Size(219, 15)
        lblTigaPuluhJuta.TabIndex = 1
        lblTigaPuluhJuta.Text = "Pendapatan lebih dari 30 juta, 20% Pajak"
        ' 
        ' lblSeratusJuta
        ' 
        lblSeratusJuta.AutoSize = True
        lblSeratusJuta.Location = New Point(318, 158)
        lblSeratusJuta.Name = "lblSeratusJuta"
        lblSeratusJuta.Size = New Size(225, 15)
        lblSeratusJuta.TabIndex = 2
        lblSeratusJuta.Text = "Pendapatan lebih dari 100 juta, 30% Pajak"
        ' 
        ' lblPendapatan
        ' 
        lblPendapatan.AutoSize = True
        lblPendapatan.Location = New Point(364, 224)
        lblPendapatan.Name = "lblPendapatan"
        lblPendapatan.Size = New Size(127, 15)
        lblPendapatan.TabIndex = 3
        lblPendapatan.Text = "Masukkan pendapatan"
        ' 
        ' lblRupiah
        ' 
        lblRupiah.AutoSize = True
        lblRupiah.Location = New Point(334, 255)
        lblRupiah.Name = "lblRupiah"
        lblRupiah.Size = New Size(24, 15)
        lblRupiah.TabIndex = 4
        lblRupiah.Text = "Rp."
        ' 
        ' txtPendapatan
        ' 
        txtPendapatan.Location = New Point(364, 252)
        txtPendapatan.Name = "txtPendapatan"
        txtPendapatan.Size = New Size(127, 23)
        txtPendapatan.TabIndex = 5
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(390, 293)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(75, 23)
        btnHitung.TabIndex = 6
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(390, 336)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(75, 23)
        btnKeluar.TabIndex = 7
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' FrmPajak
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnKeluar)
        Controls.Add(btnHitung)
        Controls.Add(txtPendapatan)
        Controls.Add(lblRupiah)
        Controls.Add(lblPendapatan)
        Controls.Add(lblSeratusJuta)
        Controls.Add(lblTigaPuluhJuta)
        Controls.Add(lblLimaJuta)
        Name = "FrmPajak"
        Text = "Pajak"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblLimaJuta As Label
    Friend WithEvents lblTigaPuluhJuta As Label
    Friend WithEvents lblSeratusJuta As Label
    Friend WithEvents lblPendapatan As Label
    Friend WithEvents lblRupiah As Label
    Friend WithEvents txtPendapatan As TextBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents btnKeluar As Button
End Class
