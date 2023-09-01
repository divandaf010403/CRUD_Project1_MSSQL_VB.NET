Imports System.Data.SqlClient
Imports System.IO

Public Class Form2

    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim ad As SqlDataAdapter
    Dim dt As DataTable

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection("Data Source=LAPTOP-Q09I900I;Initial Catalog=crud1;Integrated Security=True")
        loadData()
    End Sub

    Private Sub browse_Click(sender As Object, e As EventArgs) Handles browse.Click
        Dim fileDlg As OpenFileDialog = New OpenFileDialog()
        fileDlg.ShowDialog()
        fileTxt.Text = fileDlg.FileName
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        Call saveFile(fileTxt.Text)
        MessageBox.Show("Saved")
    End Sub

    Sub saveFile(filePath As String)
        Using stream As Stream = File.OpenRead(filePath)
            Dim buffer(stream.Length) As Byte
            stream.Read(buffer, 0, buffer.Length)

            Dim fi = New FileInfo(filePath)
            Dim extn As String = fi.Extension
            Dim fName As String = fi.Name
            Dim query As String = "INSERT INTO FileUpload(Data, Extension, FileName) VALUES (@data, @extn, @fName)"

            cmd = New SqlCommand(query, conn)
            cmd.Parameters.Add("@data", SqlDbType.VarBinary).Value = buffer
            cmd.Parameters.Add("@extn", SqlDbType.Char).Value = extn
            cmd.Parameters.Add("@fName", SqlDbType.VarChar).Value = fName
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
        End Using
    End Sub

    Sub loadData()
        Dim query As String = "SELECT Id, Extension, FileName FROM FileUpload"
        ad = New SqlDataAdapter(query, conn)
        dt = New DataTable
        ad.Fill(dt)

        If (dt.Rows.Count > 0) Then
            fileData.DataSource = dt
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim homePage = New Form1()
        homePage.Show()
        Me.Hide()
    End Sub

    Private Sub open_Click(sender As Object, e As EventArgs) Handles open.Click
        Dim selectedRow = fileData.SelectedRows
        For Each row In selectedRow
            Dim id As Integer = CInt(DirectCast(row, DataGridViewRow).Cells(0).Value)
            Call openFile(id)
        Next
    End Sub

    Private Sub openFile(id As Integer)
        Dim query As String = "SELECT Data, Extension, FileName FROM FileUpload WHERE Id = @id"
        cmd = New SqlCommand(query, conn)
        cmd.Parameters.Add("@id", SqlDbType.Int).Value = id
        conn.Open()
        Dim reader = cmd.ExecuteReader()
        If reader.Read() Then
            Dim name = reader("FileName").ToString()
            Dim data As Byte() = DirectCast(reader("Data"), Byte())
            Dim extn = reader("Extension").ToString()

            Dim newFileName = name.Replace(extn, DateTime.Now.ToString("ddMMyyyyhhmmss")) + extn
            File.WriteAllBytes(newFileName, data)
            System.Diagnostics.Process.Start(newFileName)
        End If
        conn.Close()
    End Sub
End Class