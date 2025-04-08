Imports System.Data.OleDb

Public Class UserDashboard
    Public currentUserID As Integer
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\thea\Documents\SystemLibrary.accdb"

    Private Sub btnSearchBook_Click(sender As Object, e As EventArgs) Handles btnsearchbook.Click
        Dim searchQuery As String = txtsearch.Text.Trim()

        If String.IsNullOrEmpty(searchQuery) Then
            MessageBox.Show("Please enter a search term.")
            Exit Sub
        End If

        Dim query As String = "SELECT ISBN, Title, Author, AvailableCopies FROM Books WHERE Title LIKE ? OR ISBN LIKE ?"

        Using conn As New OleDbConnection(connectionString)
            Dim da As New OleDbDataAdapter(query, conn)
            da.SelectCommand.Parameters.AddWithValue("?", "%" & searchQuery & "%")
            da.SelectCommand.Parameters.AddWithValue("?", "%" & searchQuery & "%")

            Dim dt As New DataTable()

            Try
                conn.Open()
                da.Fill(dt)

                If dgvbooks IsNot Nothing Then
                    dgvbooks.DataSource = Nothing
                    dgvbooks.DataSource = dt
                Else
                    MessageBox.Show("DataGridView is not initialized properly.")
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred while searching for the book: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LoadBooksData()
        Dim query As String = "SELECT ISBN, Title, Author, AvailableCopies, ImagePath FROM Books"

        Using conn As New OleDbConnection(connectionString)
            Dim da As New OleDbDataAdapter(query, conn)
            Dim dt As New DataTable()

            Try
                conn.Open()
                da.Fill(dt)

                If dgvbooks IsNot Nothing Then
                    dgvbooks.DataSource = Nothing
                    dgvbooks.DataSource = dt
                Else
                    MessageBox.Show("DataGridView is not initialized properly.")
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred while loading books data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub UserDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBooksData()
    End Sub

    Private Sub btnborrowbook_Click(sender As Object, e As EventArgs) Handles btnborrowbook.Click
        If dgvbooks.SelectedRows.Count > 0 Then
            Dim selectedBookISBN As String = dgvbooks.SelectedRows(0).Cells("ISBN").Value.ToString().Trim()

            If String.IsNullOrEmpty(selectedBookISBN) Then
                MessageBox.Show("ISBN is invalid or missing.")
                Exit Sub
            End If

            Dim availableCopies As Integer = Convert.ToInt32(dgvbooks.SelectedRows(0).Cells("AvailableCopies").Value)

            If availableCopies > 0 Then
                Dim updateQuery As String = "UPDATE Books SET AvailableCopies = AvailableCopies - 1 WHERE ISBN = ?"
                Dim issueQuery As String = "INSERT INTO IssuedBooks (ISBN, UserID, DateIssued, DateReturned) VALUES (?, ?, ?, ?)"

                Using conn As New OleDbConnection(connectionString)
                    conn.Open()

                    Dim transaction As OleDbTransaction = conn.BeginTransaction()

                    Try
                        Dim updateCmd As New OleDbCommand(updateQuery, conn, transaction)
                        updateCmd.Parameters.AddWithValue("?", selectedBookISBN)
                        updateCmd.ExecuteNonQuery()

                        Dim issueCmd As New OleDbCommand(issueQuery, conn, transaction)
                        issueCmd.Parameters.Add("?", OleDbType.VarChar).Value = selectedBookISBN
                        issueCmd.Parameters.Add("?", OleDbType.Integer).Value = currentUserID
                        issueCmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now
                        issueCmd.Parameters.Add("?", DBNull.Value)

                        issueCmd.ExecuteNonQuery()

                        transaction.Commit()

                        MessageBox.Show("Book borrowed successfully!")
                        LoadBooksData()
                    Catch ex As Exception
                        transaction.Rollback()
                        MessageBox.Show("An error occurred while borrowing the book: " & ex.Message)
                    End Try
                End Using
            Else
                MessageBox.Show("No available copies left to borrow.")
            End If
        Else
            MessageBox.Show("Please select a book to borrow.")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub btnreturnbook_Click(sender As Object, e As EventArgs) Handles btnreturnbook.Click
        If dgvbooks.SelectedRows.Count > 0 Then
            Dim selectedBookISBN As String = dgvbooks.SelectedRows(0).Cells("ISBN").Value.ToString()

            Dim updateQuery As String = "UPDATE Books SET AvailableCopies = AvailableCopies + 1 WHERE ISBN = ?"
            Dim returnQuery As String = "INSERT INTO ReturnedBooks (ISBN, UserID, DateReturned) VALUES (?, ?, ?)"

            Using conn As New OleDbConnection(connectionString)
                conn.Open()

                Dim transaction As OleDbTransaction = conn.BeginTransaction()

                Try
                    Dim updateCmd As New OleDbCommand(updateQuery, conn, transaction)
                    updateCmd.Parameters.AddWithValue("?", selectedBookISBN)
                    updateCmd.ExecuteNonQuery()

                    Dim returnCmd As New OleDbCommand(returnQuery, conn, transaction)

                    returnCmd.Parameters.Add("?", OleDbType.VarWChar).Value = selectedBookISBN
                    returnCmd.Parameters.Add("?", OleDbType.Integer).Value = currentUserID
                    returnCmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now

                    returnCmd.ExecuteNonQuery()

                    transaction.Commit()

                    MessageBox.Show("Book returned successfully!")
                    LoadBooksData()
                Catch ex As Exception
                    transaction.Rollback()
                    MessageBox.Show("An error occurred while returning the book: " & ex.Message)
                End Try
            End Using
        Else
            MessageBox.Show("Please select a book to return.")
        End If
    End Sub

    Private Sub btnissuebook_Click(sender As Object, e As EventArgs) Handles btnissuebook.Click
        Dim borrowHistoryQuery As String = "SELECT b.Title, COUNT(*) AS BorrowedCount " &
                                           "FROM IssuedBooks i INNER JOIN Books b ON i.ISBN = b.ISBN " &
                                           "WHERE i.UserID = ? GROUP BY b.Title"

        Dim returnHistoryQuery As String = "SELECT b.Title, COUNT(*) AS ReturnedCount " &
                                           "FROM ReturnedBooks r INNER JOIN Books b ON r.ISBN = b.ISBN " &
                                           "WHERE r.UserID = ? GROUP BY b.Title"

        Dim borrowHistoryTable As New DataTable()
        Dim returnHistoryTable As New DataTable()

        Using conn As New OleDbConnection(connectionString)
            Try
                conn.Open()

                Dim borrowHistoryCmd As New OleDbCommand(borrowHistoryQuery, conn)
                borrowHistoryCmd.Parameters.AddWithValue("?", currentUserID)
                Dim borrowHistoryAdapter As New OleDbDataAdapter(borrowHistoryCmd)
                borrowHistoryAdapter.Fill(borrowHistoryTable)

                Dim returnHistoryCmd As New OleDbCommand(returnHistoryQuery, conn)
                returnHistoryCmd.Parameters.AddWithValue("?", currentUserID)
                Dim returnHistoryAdapter As New OleDbDataAdapter(returnHistoryCmd)
                returnHistoryAdapter.Fill(returnHistoryTable)

                Dim borrowMessage As String = "Borrow History:" & vbCrLf
                For Each row As DataRow In borrowHistoryTable.Rows
                    borrowMessage &= "Book: " & row("Title") & " - Borrowed: " & row("BorrowedCount") & " times" & vbCrLf
                Next

                Dim returnMessage As String = "Return History:" & vbCrLf
                For Each row As DataRow In returnHistoryTable.Rows
                    returnMessage &= "Book: " & row("Title") & " - Returned: " & row("ReturnedCount") & " times" & vbCrLf
                Next

                MessageBox.Show(borrowMessage & vbCrLf & returnMessage)

            Catch ex As Exception
                MessageBox.Show("An error occurred while retrieving the history: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub PictureBoxBookImage_Click(sender As Object, e As EventArgs) Handles PictureBoxBookImage.Click

    End Sub

    Private Sub dgvbooks_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvbooks.CellContentClick
        If dgvbooks.SelectedRows.Count > 0 Then
            Dim selectedBookImagePath As String = dgvbooks.SelectedRows(0).Cells("ImagePath").Value.ToString()

            If Not String.IsNullOrEmpty(selectedBookImagePath) AndAlso System.IO.File.Exists(selectedBookImagePath) Then
                PictureBoxBookImage.Image = Image.FromFile(selectedBookImagePath)
            Else
                PictureBoxBookImage.Image = Nothing
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
