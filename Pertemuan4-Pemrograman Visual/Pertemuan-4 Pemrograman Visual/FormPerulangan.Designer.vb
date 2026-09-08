<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPerulangan
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
        lblNilaiAkhir = New Label()
        lblNilaiAwal = New Label()
        txtNilaiAwal = New TextBox()
        txtNilaiAkhir = New TextBox()
        btnInput = New Button()
        lstHasil = New ListBox()
        SuspendLayout()
        ' 
        ' lblNilaiAkhir
        ' 
        lblNilaiAkhir.AutoSize = True
        lblNilaiAkhir.Location = New Point(246, 185)
        lblNilaiAkhir.Name = "lblNilaiAkhir"
        lblNilaiAkhir.Size = New Size(68, 15)
        lblNilaiAkhir.TabIndex = 0
        lblNilaiAkhir.Text = "Nilai Akhir :"
        ' 
        ' lblNilaiAwal
        ' 
        lblNilaiAwal.AutoSize = True
        lblNilaiAwal.Location = New Point(246, 120)
        lblNilaiAwal.Name = "lblNilaiAwal"
        lblNilaiAwal.Size = New Size(66, 15)
        lblNilaiAwal.TabIndex = 1
        lblNilaiAwal.Text = "Nilai Awal :"
        ' 
        ' txtNilaiAwal
        ' 
        txtNilaiAwal.Location = New Point(318, 117)
        txtNilaiAwal.Name = "txtNilaiAwal"
        txtNilaiAwal.Size = New Size(100, 23)
        txtNilaiAwal.TabIndex = 2
        ' 
        ' txtNilaiAkhir
        ' 
        txtNilaiAkhir.Location = New Point(318, 182)
        txtNilaiAkhir.Name = "txtNilaiAkhir"
        txtNilaiAkhir.Size = New Size(100, 23)
        txtNilaiAkhir.TabIndex = 3
        ' 
        ' btnInput
        ' 
        btnInput.Location = New Point(331, 239)
        btnInput.Name = "btnInput"
        btnInput.Size = New Size(75, 23)
        btnInput.TabIndex = 4
        btnInput.Text = "Input"
        btnInput.UseVisualStyleBackColor = True
        ' 
        ' lstHasil
        ' 
        lstHasil.FormattingEnabled = True
        lstHasil.Location = New Point(225, 289)
        lstHasil.Name = "lstHasil"
        lstHasil.Size = New Size(225, 124)
        lstHasil.TabIndex = 5
        ' 
        ' FormPerulangan
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lstHasil)
        Controls.Add(btnInput)
        Controls.Add(txtNilaiAkhir)
        Controls.Add(txtNilaiAwal)
        Controls.Add(lblNilaiAwal)
        Controls.Add(lblNilaiAkhir)
        Name = "FormPerulangan"
        Text = "Form Perulangan"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNilaiAkhir As Label
    Friend WithEvents lblNilaiAwal As Label
    Friend WithEvents txtNilaiAwal As TextBox
    Friend WithEvents txtNilaiAkhir As TextBox
    Friend WithEvents btnInput As Button
    Friend WithEvents lstHasil As ListBox

End Class
