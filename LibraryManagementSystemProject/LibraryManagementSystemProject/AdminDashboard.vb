Imports System.Data.OleDb
Imports System.IO

Public Class AdminDashboard
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\thea\Documents\SystemLibrary.accdb"

    Private Sub LoadBooksData()
        Dim query As String = "SELECT ISBN, Title, Author, AvailableCopies, ImagePath FROM Books"
        Using conn As New OleDbConnection(connectionString)
            Dim da As New OleDbDataAdapter(query, conn)
            Dim dt As New DataTable()

            Try
                conn.Open()
                da.Fill(dt)
                dgvbooks.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("An error occurred while loading books: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LoadBookHistory(isbn As String)
        Dim borrowCountQuery As String = "SELECT COUNT(*) FROM IssuedBooks WHERE ISBN = ?"
        Dim returnCountQuery As String = "SELECT COUNT(*) FROM ReturnedBooks WHERE ISBN = ?"
        Dim borrowedUsersQuery As String = "SELECT UserID, DateIssued FROM IssuedBooks WHERE ISBN = ?"
        Dim returnedUsersQuery As String = "SELECT UserID, DateReturned FROM ReturnedBooks WHERE ISBN = ?"

        Using conn As New OleDbConnection(connectionString)
            conn.Open()

            Dim borrowCountCmd As New OleDbCommand(borrowCountQuery, conn)
            borrowCountCmd.Parameters.AddWithValue("?", isbn)
            Dim borrowedBooksCount As Integer = Convert.ToInt32(borrowCountCmd.ExecuteScalar())

            Dim returnCountCmd As New OleDbCommand(returnCountQuery, conn)
            returnCountCmd.Parameters.AddWithValue("?", isbn)
            Dim returnedBooksCount As Integer = Convert.ToInt32(returnCountCmd.ExecuteScalar())

            lblBorrowedCount.Text = "Times Borrowed: " & borrowedBooksCount.ToString()
            lblReturnedCount.Text = "Times Returned: " & returnedBooksCount.ToString()

            Dim borrowedUsersCmd As New OleDbCommand(borrowedUsersQuery, conn)
            borrowedUsersCmd.Parameters.AddWithValue("?", isbn)
            Dim borrowedUsersAdapter As New OleDbDataAdapter(borrowedUsersCmd)
            Dim borrowedUsersTable As New DataTable()
            borrowedUsersAdapter.Fill(borrowedUsersTable)

            Dim returnedUsersCmd As New OleDbCommand(returnedUsersQuery, conn)
            returnedUsersCmd.Parameters.AddWithValue("?", isbn)
            Dim returnedUsersAdapter As New OleDbDataAdapter(returnedUsersCmd)
            Dim returnedUsersTable As New DataTable()
            returnedUsersAdapter.Fill(returnedUsersTable)

            dgvBorrowedUsers.DataSource = borrowedUsersTable
            dgvReturnedUsers.DataSource = returnedUsersTable
        End Using
    End Sub

    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click
        Dim isbn As String = txtisbn.Text.Trim()
        Dim title As String = txtTitle.Text.Trim()
        Dim author As String = txtAuthor.Text.Trim()
        Dim availableCopies As Integer = Convert.ToInt32(txtAvailableCopies.Text)

        Dim imagePath As String = ""
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                imagePath = openFileDialog.FileName
            End If
        End Using

        If String.IsNullOrEmpty(imagePath) Then
            MessageBox.Show("Please select an image for the book.")
            Return
        End If

        Dim query As String = "INSERT INTO Books (ISBN, Title, Author, AvailableCopies, ImagePath) VALUES (?, ?, ?, ?, ?)"

        Using conn As New OleDbConnection(connectionString)
            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("?", isbn)
            cmd.Parameters.AddWithValue("?", title)
            cmd.Parameters.AddWithValue("?", author)
            cmd.Parameters.AddWithValue("?", availableCopies)
            cmd.Parameters.AddWithValue("?", imagePath)

            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("New book added successfully!")
                LoadBooksData()
            Catch ex As Exception
                MessageBox.Show("An error occurred while adding the book: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnEditBook_Click(sender As Object, e As EventArgs) Handles btnEditBook.Click
        If dgvbooks.SelectedRows.Count > 0 Then
            Dim selectedBookISBN As String = dgvbooks.SelectedRows(0).Cells("ISBN").Value.ToString()
            Dim title As String = txtTitle.Text.Trim()
            Dim author As String = txtAuthor.Text.Trim()
            Dim availableCopies As Integer = Convert.ToInt32(txtAvailableCopies.Text)

            Dim imagePath As String = ""
            Using openFileDialog As New OpenFileDialog()
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
                If openFileDialog.ShowDialog() = DialogResult.OK Then
                    imagePath = openFileDialog.FileName
                End If
            End Using

            If String.IsNullOrEmpty(imagePath) Then
                imagePath = dgvbooks.SelectedRows(0).Cells("ImagePath").Value.ToString()
            End If

            Dim query As String = "UPDATE Books SET Title = ?, Author = ?, AvailableCopies = ?, ImagePath = ? WHERE ISBN = ?"

            Using conn As New OleDbConnection(connectionString)
                Dim cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("?", title)
                cmd.Parameters.AddWithValue("?", author)
                cmd.Parameters.AddWithValue("?", availableCopies)
                cmd.Parameters.AddWithValue("?", imagePath)
                cmd.Parameters.AddWithValue("?", selectedBookISBN)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Book details updated successfully!")
                    LoadBooksData()
                Catch ex As Exception
                    MessageBox.Show("An error occurred while updating the book: " & ex.Message)
                End Try
            End Using
        Else
            MessageBox.Show("Please select a book to edit.")
        End If
    End Sub

    Private Sub btnDeleteBook_Click(sender As Object, e As EventArgs) Handles btnDeleteBook.Click
        If dgvbooks.SelectedRows.Count > 0 Then
            Dim selectedBookISBN As String = dgvbooks.SelectedRows(0).Cells("ISBN").Value.ToString()
            Dim query As String = "DELETE FROM Books WHERE ISBN = ?"

            Using conn As New OleDbConnection(connectionString)
                Dim cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("?", selectedBookISBN)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Book deleted successfully!")
                    LoadBooksData()
                Catch ex As Exception
                    MessageBox.Show("An error occurred while deleting the book: " & ex.Message)
                End Try
            End Using
        Else
            MessageBox.Show("Please select a book to delete.")
        End If
    End Sub

    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBooksData()
    End Sub

    Private Sub dgvBooks_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvbooks.CellClick
        If dgvbooks.SelectedRows.Count > 0 Then
            Dim selectedBookISBN As String = dgvbooks.SelectedRows(0).Cells("ISBN").Value.ToString()
            LoadBookHistory(selectedBookISBN)

            Dim imagePath As String = dgvbooks.SelectedRows(0).Cells("ImagePath").Value.ToString()
            If Not String.IsNullOrEmpty(imagePath) AndAlso File.Exists(imagePath) Then
                PictureBoxBookImage.Image = Image.FromFile(imagePath)
            Else
                PictureBoxBookImage.Image = Nothing
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
