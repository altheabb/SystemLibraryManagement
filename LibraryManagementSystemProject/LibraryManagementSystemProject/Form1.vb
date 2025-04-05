Imports System.Data.OleDb

Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label3.Parent = PictureBox1
        Application.Exit()
    End Sub

    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\steph\OneDrive\Documents\SystemLibrary.accdb"

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim username As String = txtusername.Text
        Dim password As String = txtpassword.Text

        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            lblerror.Text = "Please enter both username and password."
            lblerror.Visible = True
            Return
        End If

        Dim query As String = "SELECT * FROM Users WHERE Username = ? AND Password = ?"

        Using conn As New OleDbConnection(connectionString)
            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("?", username)
            cmd.Parameters.AddWithValue("?", password)

            Try
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()

                If reader.HasRows Then
                    reader.Read()
                    Dim role As String = reader("Role").ToString()

                    If role = "Admin" Then
                        MessageBox.Show("Welcome Admin!")
                        AdminDashboard.Show()
                    Else
                        MessageBox.Show("Welcome User!")
                        UserDashboard.Show()
                    End If
                    Me.Hide()
                Else
                    lblerror.Text = "Invalid username or password."
                    lblerror.Visible = True
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtpassword.PasswordChar = "●"c
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtpassword.PasswordChar = Char.MinValue
        Else
            txtpassword.PasswordChar = "●"c
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
