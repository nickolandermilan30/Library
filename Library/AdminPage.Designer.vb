<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPage
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
        Panel1 = New Panel()
        returnbooksbtn2 = New Button()
        users = New Button()
        viewbooks = New Button()
        logoutadmin = New Button()
        saved = New Button()
        clear = New Button()
        logout = New Button()
        list = New Button()
        Label2 = New Label()
        titleadmin = New TextBox()
        publisheradmin = New TextBox()
        Label3 = New Label()
        authoradmin = New TextBox()
        Label1 = New Label()
        rackadmin = New TextBox()
        Label4 = New Label()
        contentadmin = New TextBox()
        Label5 = New Label()
        donebook = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        Panel1.Controls.Add(returnbooksbtn2)
        Panel1.Controls.Add(users)
        Panel1.Controls.Add(viewbooks)
        Panel1.Controls.Add(logoutadmin)
        Panel1.Controls.Add(saved)
        Panel1.Controls.Add(clear)
        Panel1.Controls.Add(logout)
        Panel1.Controls.Add(list)
        Panel1.Location = New Point(-4, -4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(315, 726)
        Panel1.TabIndex = 2
        ' 
        ' returnbooksbtn2
        ' 
        returnbooksbtn2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        returnbooksbtn2.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        returnbooksbtn2.BackgroundImageLayout = ImageLayout.None
        returnbooksbtn2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        returnbooksbtn2.ForeColor = Color.Transparent
        returnbooksbtn2.Location = New Point(25, 553)
        returnbooksbtn2.Name = "returnbooksbtn2"
        returnbooksbtn2.Size = New Size(255, 61)
        returnbooksbtn2.TabIndex = 34
        returnbooksbtn2.Text = "Return books"
        returnbooksbtn2.UseVisualStyleBackColor = False
        ' 
        ' users
        ' 
        users.BackColor = Color.SeaGreen
        users.BackgroundImageLayout = ImageLayout.None
        users.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        users.ForeColor = Color.Transparent
        users.Location = New Point(25, 118)
        users.Name = "users"
        users.Size = New Size(255, 61)
        users.TabIndex = 33
        users.Text = "View User"
        users.UseVisualStyleBackColor = False
        ' 
        ' viewbooks
        ' 
        viewbooks.BackColor = Color.SeaGreen
        viewbooks.BackgroundImageLayout = ImageLayout.None
        viewbooks.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        viewbooks.ForeColor = Color.Transparent
        viewbooks.Location = New Point(25, 38)
        viewbooks.Name = "viewbooks"
        viewbooks.Size = New Size(255, 61)
        viewbooks.TabIndex = 31
        viewbooks.Text = "Request Books"
        viewbooks.UseVisualStyleBackColor = False
        ' 
        ' logoutadmin
        ' 
        logoutadmin.Anchor = AnchorStyles.Bottom
        logoutadmin.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        logoutadmin.BackgroundImageLayout = ImageLayout.None
        logoutadmin.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        logoutadmin.ForeColor = Color.Transparent
        logoutadmin.Location = New Point(25, 636)
        logoutadmin.Name = "logoutadmin"
        logoutadmin.Size = New Size(255, 61)
        logoutadmin.TabIndex = 30
        logoutadmin.Text = "Log out "
        logoutadmin.UseVisualStyleBackColor = False
        ' 
        ' saved
        ' 
        saved.Anchor = AnchorStyles.None
        saved.Location = New Point(16, 1680)
        saved.Name = "saved"
        saved.Size = New Size(187, 44)
        saved.TabIndex = 6
        saved.Text = "Save"
        saved.UseVisualStyleBackColor = True
        ' 
        ' clear
        ' 
        clear.Anchor = AnchorStyles.None
        clear.BackColor = Color.Snow
        clear.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        clear.ForeColor = Color.Black
        clear.Location = New Point(16, 1735)
        clear.Name = "clear"
        clear.Size = New Size(187, 41)
        clear.TabIndex = 7
        clear.Text = "Clear"
        clear.UseVisualStyleBackColor = False
        ' 
        ' logout
        ' 
        logout.Anchor = AnchorStyles.None
        logout.Location = New Point(16, 1848)
        logout.Name = "logout"
        logout.Size = New Size(187, 44)
        logout.TabIndex = 4
        logout.Text = "Log Out"
        logout.UseVisualStyleBackColor = True
        ' 
        ' list
        ' 
        list.Anchor = AnchorStyles.None
        list.Location = New Point(16, 1788)
        list.Name = "list"
        list.Size = New Size(187, 44)
        list.TabIndex = 3
        list.Text = "List of Student"
        list.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(329, 54)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 31)
        Label2.TabIndex = 10
        Label2.Text = "Title:"
        ' 
        ' titleadmin
        ' 
        titleadmin.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        titleadmin.Location = New Point(411, 56)
        titleadmin.Multiline = True
        titleadmin.Name = "titleadmin"
        titleadmin.Size = New Size(416, 31)
        titleadmin.TabIndex = 9
        ' 
        ' publisheradmin
        ' 
        publisheradmin.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        publisheradmin.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        publisheradmin.Location = New Point(473, 165)
        publisheradmin.Multiline = True
        publisheradmin.Name = "publisheradmin"
        publisheradmin.Size = New Size(740, 31)
        publisheradmin.TabIndex = 14
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(329, 165)
        Label3.Name = "Label3"
        Label3.Size = New Size(138, 31)
        Label3.TabIndex = 13
        Label3.Text = "Publisher:"
        ' 
        ' authoradmin
        ' 
        authoradmin.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        authoradmin.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        authoradmin.Location = New Point(979, 56)
        authoradmin.Multiline = True
        authoradmin.Name = "authoradmin"
        authoradmin.Size = New Size(234, 31)
        authoradmin.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(859, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 31)
        Label1.TabIndex = 15
        Label1.Text = "Author:"
        ' 
        ' rackadmin
        ' 
        rackadmin.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        rackadmin.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rackadmin.Location = New Point(539, 114)
        rackadmin.Multiline = True
        rackadmin.Name = "rackadmin"
        rackadmin.Size = New Size(674, 31)
        rackadmin.TabIndex = 18
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(329, 114)
        Label4.Name = "Label4"
        Label4.Size = New Size(191, 31)
        Label4.TabIndex = 17
        Label4.Text = "Rack Location:"
        ' 
        ' contentadmin
        ' 
        contentadmin.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        contentadmin.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        contentadmin.Location = New Point(473, 235)
        contentadmin.Multiline = True
        contentadmin.Name = "contentadmin"
        contentadmin.Size = New Size(740, 375)
        contentadmin.TabIndex = 19
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(329, 235)
        Label5.Name = "Label5"
        Label5.Size = New Size(119, 31)
        Label5.TabIndex = 20
        Label5.Text = "Content:"
        ' 
        ' donebook
        ' 
        donebook.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        donebook.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        donebook.BackgroundImageLayout = ImageLayout.None
        donebook.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        donebook.ForeColor = Color.Transparent
        donebook.Location = New Point(473, 632)
        donebook.Name = "donebook"
        donebook.Size = New Size(740, 61)
        donebook.TabIndex = 33
        donebook.Text = "Publish"
        donebook.UseVisualStyleBackColor = False
        ' 
        ' AdminPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1249, 722)
        Controls.Add(donebook)
        Controls.Add(Label5)
        Controls.Add(contentadmin)
        Controls.Add(rackadmin)
        Controls.Add(Label4)
        Controls.Add(authoradmin)
        Controls.Add(Label1)
        Controls.Add(publisheradmin)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(titleadmin)
        Controls.Add(Panel1)
        Name = "AdminPage"
        Text = "AdminPage"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents saved As Button
    Friend WithEvents clear As Button
    Friend WithEvents logout As Button
    Friend WithEvents list As Button
    Friend WithEvents viewbooks As Button
    Friend WithEvents logoutadmin As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents titleadmin As TextBox
    Friend WithEvents publisheradmin As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents authoradmin As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rackadmin As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents contentadmin As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents donebook As Button
    Friend WithEvents users As Button
    Friend WithEvents returnbooksbtn2 As Button
End Class
