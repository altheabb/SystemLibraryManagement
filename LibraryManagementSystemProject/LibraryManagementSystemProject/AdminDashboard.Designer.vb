<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvbooks = New System.Windows.Forms.DataGridView()
        Me.txtisbn = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtAvailableCopies = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAddBook = New System.Windows.Forms.Button()
        Me.btnEditBook = New System.Windows.Forms.Button()
        Me.btnDeleteBook = New System.Windows.Forms.Button()
        Me.dgvBorrowedUsers = New System.Windows.Forms.DataGridView()
        Me.dgvReturnedUsers = New System.Windows.Forms.DataGridView()
        Me.lblBorrowedCount = New System.Windows.Forms.Label()
        Me.lblReturnedCount = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBoxBookImage = New System.Windows.Forms.PictureBox()
        CType(Me.dgvbooks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBorrowedUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvReturnedUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxBookImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(767, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(33, 550)
        Me.Panel2.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(33, 550)
        Me.Panel1.TabIndex = 6
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Mongolian Baiti", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(734, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(32, 23)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "x"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(702, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(32, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "◼"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(670, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "-"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgvbooks
        '
        Me.dgvbooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbooks.Location = New System.Drawing.Point(235, 85)
        Me.dgvbooks.Name = "dgvbooks"
        Me.dgvbooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvbooks.Size = New System.Drawing.Size(441, 185)
        Me.dgvbooks.TabIndex = 16
        '
        'txtisbn
        '
        Me.txtisbn.Location = New System.Drawing.Point(89, 85)
        Me.txtisbn.Name = "txtisbn"
        Me.txtisbn.Size = New System.Drawing.Size(140, 20)
        Me.txtisbn.TabIndex = 17
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(89, 111)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(140, 20)
        Me.txtTitle.TabIndex = 18
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(89, 138)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(140, 20)
        Me.txtAuthor.TabIndex = 19
        '
        'txtAvailableCopies
        '
        Me.txtAvailableCopies.Location = New System.Drawing.Point(89, 164)
        Me.txtAvailableCopies.Name = "txtAvailableCopies"
        Me.txtAvailableCopies.Size = New System.Drawing.Size(140, 20)
        Me.txtAvailableCopies.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "ISBN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 16)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Title"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Author"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Copies"
        '
        'btnAddBook
        '
        Me.btnAddBook.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBook.Location = New System.Drawing.Point(172, 190)
        Me.btnAddBook.Name = "btnAddBook"
        Me.btnAddBook.Size = New System.Drawing.Size(57, 41)
        Me.btnAddBook.TabIndex = 25
        Me.btnAddBook.Text = "Add Book"
        Me.btnAddBook.UseVisualStyleBackColor = True
        '
        'btnEditBook
        '
        Me.btnEditBook.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditBook.Location = New System.Drawing.Point(59, 190)
        Me.btnEditBook.Name = "btnEditBook"
        Me.btnEditBook.Size = New System.Drawing.Size(56, 41)
        Me.btnEditBook.TabIndex = 26
        Me.btnEditBook.Text = "Edit Book"
        Me.btnEditBook.UseVisualStyleBackColor = True
        '
        'btnDeleteBook
        '
        Me.btnDeleteBook.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteBook.Location = New System.Drawing.Point(115, 190)
        Me.btnDeleteBook.Name = "btnDeleteBook"
        Me.btnDeleteBook.Size = New System.Drawing.Size(57, 41)
        Me.btnDeleteBook.TabIndex = 27
        Me.btnDeleteBook.Text = "Delete Book"
        Me.btnDeleteBook.UseVisualStyleBackColor = True
        '
        'dgvBorrowedUsers
        '
        Me.dgvBorrowedUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBorrowedUsers.Location = New System.Drawing.Point(235, 276)
        Me.dgvBorrowedUsers.Name = "dgvBorrowedUsers"
        Me.dgvBorrowedUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBorrowedUsers.Size = New System.Drawing.Size(261, 185)
        Me.dgvBorrowedUsers.TabIndex = 28
        '
        'dgvReturnedUsers
        '
        Me.dgvReturnedUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReturnedUsers.Location = New System.Drawing.Point(502, 276)
        Me.dgvReturnedUsers.Name = "dgvReturnedUsers"
        Me.dgvReturnedUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReturnedUsers.Size = New System.Drawing.Size(261, 185)
        Me.dgvReturnedUsers.TabIndex = 29
        '
        'lblBorrowedCount
        '
        Me.lblBorrowedCount.AutoSize = True
        Me.lblBorrowedCount.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrowedCount.Location = New System.Drawing.Point(307, 464)
        Me.lblBorrowedCount.Name = "lblBorrowedCount"
        Me.lblBorrowedCount.Size = New System.Drawing.Size(0, 14)
        Me.lblBorrowedCount.TabIndex = 30
        '
        'lblReturnedCount
        '
        Me.lblReturnedCount.AutoSize = True
        Me.lblReturnedCount.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReturnedCount.Location = New System.Drawing.Point(580, 464)
        Me.lblReturnedCount.Name = "lblReturnedCount"
        Me.lblReturnedCount.Size = New System.Drawing.Size(0, 14)
        Me.lblReturnedCount.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Mongolian Baiti", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(291, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(317, 30)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "CONTROL INTERFACE"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Red
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(379, 494)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(66, 29)
        Me.Button4.TabIndex = 34
        Me.Button4.Text = "Logout"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'PictureBoxBookImage
        '
        Me.PictureBoxBookImage.Location = New System.Drawing.Point(64, 276)
        Me.PictureBoxBookImage.Name = "PictureBoxBookImage"
        Me.PictureBoxBookImage.Size = New System.Drawing.Size(147, 185)
        Me.PictureBoxBookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxBookImage.TabIndex = 35
        Me.PictureBoxBookImage.TabStop = False
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 550)
        Me.Controls.Add(Me.PictureBoxBookImage)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblReturnedCount)
        Me.Controls.Add(Me.lblBorrowedCount)
        Me.Controls.Add(Me.dgvReturnedUsers)
        Me.Controls.Add(Me.dgvBorrowedUsers)
        Me.Controls.Add(Me.btnDeleteBook)
        Me.Controls.Add(Me.btnEditBook)
        Me.Controls.Add(Me.btnAddBook)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAvailableCopies)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.txtisbn)
        Me.Controls.Add(Me.dgvbooks)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminDashboard"
        CType(Me.dgvbooks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBorrowedUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvReturnedUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxBookImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvbooks As DataGridView
    Friend WithEvents txtisbn As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtAvailableCopies As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAddBook As Button
    Friend WithEvents btnEditBook As Button
    Friend WithEvents btnDeleteBook As Button
    Friend WithEvents dgvBorrowedUsers As DataGridView
    Friend WithEvents dgvReturnedUsers As DataGridView
    Friend WithEvents lblBorrowedCount As Label
    Friend WithEvents lblReturnedCount As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBoxBookImage As PictureBox
End Class
