<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PicImage = New PictureBox()
        lblRole = New Label()
        lblNama = New Label()
        lblNIM = New Label()
        btnLogin = New Button()
        txtNama = New TextBox()
        txtNIM = New TextBox()
        cmbRole = New ComboBox()
        CType(PicImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PicImage
        ' 
        PicImage.Location = New Point(298, 12)
        PicImage.Name = "PicImage"
        PicImage.Size = New Size(200, 200)
        PicImage.SizeMode = PictureBoxSizeMode.StretchImage
        PicImage.TabIndex = 0
        PicImage.TabStop = False
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Location = New Point(293, 244)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(36, 15)
        lblRole.TabIndex = 1
        lblRole.Text = "Role :"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(284, 287)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(45, 15)
        lblNama.TabIndex = 2
        lblNama.Text = "Nama :"
        ' 
        ' lblNIM
        ' 
        lblNIM.AutoSize = True
        lblNIM.Location = New Point(293, 319)
        lblNIM.Name = "lblNIM"
        lblNIM.Size = New Size(36, 15)
        lblNIM.TabIndex = 3
        lblNIM.Text = "NIM :"
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(359, 362)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(75, 23)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(335, 279)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(122, 23)
        txtNama.TabIndex = 5
        ' 
        ' txtNIM
        ' 
        txtNIM.Location = New Point(337, 316)
        txtNIM.Name = "txtNIM"
        txtNIM.Size = New Size(120, 23)
        txtNIM.TabIndex = 6
        ' 
        ' cmbRole
        ' 
        cmbRole.FormattingEnabled = True
        cmbRole.Location = New Point(336, 241)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(121, 23)
        cmbRole.TabIndex = 7
        ' 
        ' FrmLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(cmbRole)
        Controls.Add(txtNIM)
        Controls.Add(txtNama)
        Controls.Add(btnLogin)
        Controls.Add(lblNIM)
        Controls.Add(lblNama)
        Controls.Add(lblRole)
        Controls.Add(PicImage)
        Name = "FrmLogin"
        Text = "Login"
        CType(PicImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PicImage As PictureBox
    Friend WithEvents lblRole As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblNIM As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents cmbRole As ComboBox

End Class
