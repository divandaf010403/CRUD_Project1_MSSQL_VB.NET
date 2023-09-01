<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.noTlp = New System.Windows.Forms.TextBox()
        Me.simpan = New System.Windows.Forms.Button()
        Me.edit = New System.Windows.Forms.Button()
        Me.hapus = New System.Windows.Forms.Button()
        Me.userData = New System.Windows.Forms.DataGridView()
        Me.searchField = New System.Windows.Forms.TextBox()
        Me.searchBtn = New System.Windows.Forms.Button()
        Me.uploadFile = New System.Windows.Forms.Button()
        CType(Me.userData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'nama
        '
        Me.nama.Location = New System.Drawing.Point(134, 58)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(288, 22)
        Me.nama.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Email"
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(134, 102)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(288, 22)
        Me.email.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "No. Tlp"
        '
        'noTlp
        '
        Me.noTlp.Location = New System.Drawing.Point(134, 156)
        Me.noTlp.Name = "noTlp"
        Me.noTlp.Size = New System.Drawing.Size(288, 22)
        Me.noTlp.TabIndex = 5
        '
        'simpan
        '
        Me.simpan.Location = New System.Drawing.Point(48, 224)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(105, 44)
        Me.simpan.TabIndex = 6
        Me.simpan.Text = "Simpan"
        Me.simpan.UseVisualStyleBackColor = True
        '
        'edit
        '
        Me.edit.Location = New System.Drawing.Point(190, 224)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(97, 44)
        Me.edit.TabIndex = 7
        Me.edit.Text = "Edit"
        Me.edit.UseVisualStyleBackColor = True
        '
        'hapus
        '
        Me.hapus.Location = New System.Drawing.Point(322, 224)
        Me.hapus.Name = "hapus"
        Me.hapus.Size = New System.Drawing.Size(100, 44)
        Me.hapus.TabIndex = 8
        Me.hapus.Text = "Hapus"
        Me.hapus.UseVisualStyleBackColor = True
        '
        'userData
        '
        Me.userData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.userData.Location = New System.Drawing.Point(461, 102)
        Me.userData.Name = "userData"
        Me.userData.RowHeadersWidth = 51
        Me.userData.RowTemplate.Height = 24
        Me.userData.Size = New System.Drawing.Size(479, 310)
        Me.userData.TabIndex = 9
        '
        'searchField
        '
        Me.searchField.Location = New System.Drawing.Point(461, 58)
        Me.searchField.Name = "searchField"
        Me.searchField.Size = New System.Drawing.Size(398, 22)
        Me.searchField.TabIndex = 10
        '
        'searchBtn
        '
        Me.searchBtn.Location = New System.Drawing.Point(865, 58)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(75, 23)
        Me.searchBtn.TabIndex = 11
        Me.searchBtn.Text = "Cari"
        Me.searchBtn.UseVisualStyleBackColor = True
        '
        'uploadFile
        '
        Me.uploadFile.Location = New System.Drawing.Point(48, 300)
        Me.uploadFile.Name = "uploadFile"
        Me.uploadFile.Size = New System.Drawing.Size(374, 45)
        Me.uploadFile.TabIndex = 12
        Me.uploadFile.Text = "Upload File"
        Me.uploadFile.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 450)
        Me.Controls.Add(Me.uploadFile)
        Me.Controls.Add(Me.searchBtn)
        Me.Controls.Add(Me.searchField)
        Me.Controls.Add(Me.userData)
        Me.Controls.Add(Me.hapus)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.simpan)
        Me.Controls.Add(Me.noTlp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.userData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents nama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents email As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents noTlp As TextBox
    Friend WithEvents simpan As Button
    Friend WithEvents edit As Button
    Friend WithEvents hapus As Button
    Friend WithEvents userData As DataGridView
    Friend WithEvents searchField As TextBox
    Friend WithEvents searchBtn As Button
    Friend WithEvents uploadFile As Button
End Class
