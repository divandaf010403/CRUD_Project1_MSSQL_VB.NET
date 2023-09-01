Imports System.Data.SqlClient
Public Class Form1
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dt As DataTable

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection("Data Source=LAPTOP-Q09I900I;Initial Catalog=crud1;Integrated Security=True")
        BindData()
    End Sub

    Sub kondisiAwal()
        nama.Text = ""
        email.Text = ""
        noTlp.Text = ""

        BindData()
    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        Dim query As String = "INSERT INTO userData (name, email, phone) VALUES (@nama, @email, @noTlp)"
        cmd = New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@nama", nama.Text)
        cmd.Parameters.AddWithValue("@email", email.Text)
        cmd.Parameters.AddWithValue("@noTlp", noTlp.Text)

        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()

        Call kondisiAwal()

        MessageBox.Show("Insert Data Success!")
        BindData()
    End Sub

    Public Sub BindData()
        Dim query As String = "SELECT * FROM userData order by id"
        cmd = New SqlCommand(query, conn)
        da = New SqlDataAdapter
        dt = New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)
        userData.DataSource = dt
    End Sub

    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        Dim query As String = "SELECT * FROM userData WHERE id = '" & searchField.Text & "'"
        cmd = New SqlCommand(query, conn)
        da = New SqlDataAdapter
        dt = New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            nama.Text = dt.Rows(0)(1).ToString()
            email.Text = dt.Rows(0)(2).ToString()
            noTlp.Text = dt.Rows(0)(3).ToString()
        Else
            Call kondisiAwal()
        End If
    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        If searchField.Text = "" Then
            MessageBox.Show("Id Harus DI isi")
        Else
            Dim query As String = "UPDATE userData set name = @nama, email = @email, phone = @noTlp where id = @id"
            cmd = New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@nama", nama.Text)
            cmd.Parameters.AddWithValue("@email", email.Text)
            cmd.Parameters.AddWithValue("@noTlp", noTlp.Text)
            cmd.Parameters.AddWithValue("@id", searchField.Text)

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

            Call kondisiAwal()

            MessageBox.Show("Update Data Success!")
            BindData()
        End If
    End Sub

    Private Sub hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        Dim query As String = "DELETE FROM userData WHERE id = @id"
        cmd = New SqlCommand(query, conn)
        If searchField.Text = "" Then
            MessageBox.Show("ID Harus Diisi")
        Else
            cmd.Parameters.AddWithValue("@id", searchField.Text)
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

            Call kondisiAwal()

            MessageBox.Show("Delete Data Success!")
        End If
    End Sub

    Private Sub uploadFile_Click(sender As Object, e As EventArgs) Handles uploadFile.Click
        Dim uploadPage = New Form2()
        uploadPage.Show()
        Me.Hide()
    End Sub

    Private Sub userData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles userData.CellContentClick
        Dim selectedData As DataGridViewRow
        selectedData = userData.Rows(e.RowIndex)
        searchField.Text = selectedData.Cells(0).Value
        nama.Text = selectedData.Cells(1).Value
        email.Text = selectedData.Cells(2).Value
        noTlp.Text = selectedData.Cells(3).Value
    End Sub
End Class
