<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvbooks = New System.Windows.Forms.DataGridView()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.btnsearchbook = New System.Windows.Forms.Button()
        Me.btnborrowbook = New System.Windows.Forms.Button()
        Me.btnreturnbook = New System.Windows.Forms.Button()
        Me.btnissuebook = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBoxBookImage = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvbooks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxBookImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(735, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(65, 550)
        Me.Panel2.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(65, 550)
        Me.Panel3.TabIndex = 6
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Mongolian Baiti", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(703, 0)
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
        Me.Button2.Location = New System.Drawing.Point(671, 0)
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
        Me.Button1.Location = New System.Drawing.Point(639, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "-"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgvbooks
        '
        Me.dgvbooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbooks.Location = New System.Drawing.Point(267, 158)
        Me.dgvbooks.Name = "dgvbooks"
        Me.dgvbooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvbooks.Size = New System.Drawing.Size(436, 185)
        Me.dgvbooks.TabIndex = 15
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(395, 349)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(181, 20)
        Me.txtsearch.TabIndex = 16
        '
        'btnsearchbook
        '
        Me.btnsearchbook.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnsearchbook.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnsearchbook.FlatAppearance.BorderSize = 0
        Me.btnsearchbook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsearchbook.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearchbook.Location = New System.Drawing.Point(446, 373)
        Me.btnsearchbook.Name = "btnsearchbook"
        Me.btnsearchbook.Size = New System.Drawing.Size(75, 26)
        Me.btnsearchbook.TabIndex = 17
        Me.btnsearchbook.Text = "Search"
        Me.btnsearchbook.UseVisualStyleBackColor = False
        '
        'btnborrowbook
        '
        Me.btnborrowbook.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnborrowbook.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnborrowbook.FlatAppearance.BorderSize = 0
        Me.btnborrowbook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnborrowbook.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnborrowbook.Location = New System.Drawing.Point(303, 418)
        Me.btnborrowbook.Name = "btnborrowbook"
        Me.btnborrowbook.Size = New System.Drawing.Size(109, 45)
        Me.btnborrowbook.TabIndex = 18
        Me.btnborrowbook.Text = "Borrow Books"
        Me.btnborrowbook.UseVisualStyleBackColor = False
        '
        'btnreturnbook
        '
        Me.btnreturnbook.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnreturnbook.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnreturnbook.FlatAppearance.BorderSize = 0
        Me.btnreturnbook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreturnbook.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreturnbook.Location = New System.Drawing.Point(429, 418)
        Me.btnreturnbook.Name = "btnreturnbook"
        Me.btnreturnbook.Size = New System.Drawing.Size(109, 45)
        Me.btnreturnbook.TabIndex = 19
        Me.btnreturnbook.Text = "Return Book"
        Me.btnreturnbook.UseVisualStyleBackColor = False
        '
        'btnissuebook
        '
        Me.btnissuebook.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnissuebook.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnissuebook.FlatAppearance.BorderSize = 0
        Me.btnissuebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnissuebook.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnissuebook.Location = New System.Drawing.Point(556, 418)
        Me.btnissuebook.Name = "btnissuebook"
        Me.btnissuebook.Size = New System.Drawing.Size(109, 45)
        Me.btnissuebook.TabIndex = 20
        Me.btnissuebook.Text = "Issued Book"
        Me.btnissuebook.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Red
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(639, 509)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(90, 29)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "Logout"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'PictureBoxBookImage
        '
        Me.PictureBoxBookImage.Location = New System.Drawing.Point(82, 158)
        Me.PictureBoxBookImage.Name = "PictureBoxBookImage"
        Me.PictureBoxBookImage.Size = New System.Drawing.Size(155, 185)
        Me.PictureBoxBookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxBookImage.TabIndex = 22
        Me.PictureBoxBookImage.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(404, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 34)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "ShelfTrack"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LibraryManagementSystemProject.My.Resources.Resources._360_F_1333608735_5tz5n900JQlnWYgl9QGIUx59ZmVx6so7
        Me.PictureBox1.Location = New System.Drawing.Point(304, -35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(352, 193)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'UserDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 550)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBoxBookImage)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnissuebook)
        Me.Controls.Add(Me.btnreturnbook)
        Me.Controls.Add(Me.btnborrowbook)
        Me.Controls.Add(Me.btnsearchbook)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.dgvbooks)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UserDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserDashboard"
        CType(Me.dgvbooks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxBookImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvbooks As DataGridView
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents btnsearchbook As Button
    Friend WithEvents btnborrowbook As Button
    Friend WithEvents btnreturnbook As Button
    Friend WithEvents btnissuebook As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBoxBookImage As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
