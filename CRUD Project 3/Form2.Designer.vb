<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.fileTxt = New System.Windows.Forms.TextBox()
        Me.browse = New System.Windows.Forms.Button()
        Me.save = New System.Windows.Forms.Button()
        Me.fileData = New System.Windows.Forms.DataGridView()
        Me.open = New System.Windows.Forms.Button()
        CType(Me.fileData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 50)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "<< Kembali"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'fileTxt
        '
        Me.fileTxt.Location = New System.Drawing.Point(69, 79)
        Me.fileTxt.Name = "fileTxt"
        Me.fileTxt.Size = New System.Drawing.Size(448, 22)
        Me.fileTxt.TabIndex = 1
        '
        'browse
        '
        Me.browse.Location = New System.Drawing.Point(543, 79)
        Me.browse.Name = "browse"
        Me.browse.Size = New System.Drawing.Size(75, 23)
        Me.browse.TabIndex = 2
        Me.browse.Text = "Browse"
        Me.browse.UseVisualStyleBackColor = True
        '
        'save
        '
        Me.save.Location = New System.Drawing.Point(645, 79)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(75, 23)
        Me.save.TabIndex = 3
        Me.save.Text = "Save"
        Me.save.UseVisualStyleBackColor = True
        '
        'fileData
        '
        Me.fileData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.fileData.Location = New System.Drawing.Point(69, 151)
        Me.fileData.Name = "fileData"
        Me.fileData.RowHeadersWidth = 51
        Me.fileData.RowTemplate.Height = 24
        Me.fileData.Size = New System.Drawing.Size(651, 264)
        Me.fileData.TabIndex = 4
        '
        'open
        '
        Me.open.Location = New System.Drawing.Point(69, 108)
        Me.open.Name = "open"
        Me.open.Size = New System.Drawing.Size(98, 37)
        Me.open.TabIndex = 5
        Me.open.Text = "Open File"
        Me.open.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.open)
        Me.Controls.Add(Me.fileData)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.browse)
        Me.Controls.Add(Me.fileTxt)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.fileData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents fileTxt As TextBox
    Friend WithEvents browse As Button
    Friend WithEvents save As Button
    Friend WithEvents fileData As DataGridView
    Friend WithEvents open As Button
End Class
