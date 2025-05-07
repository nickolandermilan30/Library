<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffPage
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
        donebook = New Button()
        Label5 = New Label()
        contentadmin = New TextBox()
        rackadmin = New TextBox()
        Label4 = New Label()
        authoradmin = New TextBox()
        Label1 = New Label()
        publisheradmin = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        titleadmin = New TextBox()
        returnbooksbtn2 = New Button()
        users = New Button()
        viewbooks = New Button()
        logoutadmin = New Button()
        saved = New Button()
        clear = New Button()
        logout = New Button()
        list = New Button()
        Panel1 = New Panel()
        returnbooksbtn1 = New Button()
        logoutadmin1 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' donebook
        ' 
        donebook.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        donebook.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        donebook.BackgroundImageLayout = ImageLayout.None
        donebook.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        donebook.ForeColor = Color.Transparent
        donebook.Location = New Point(493, 634)
        donebook.Name = "donebook"
        donebook.Size = New Size(740, 61)
        donebook.TabIndex = 45
        donebook.Text = "Publish"
        donebook.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(349, 237)
        Label5.Name = "Label5"
        Label5.Size = New Size(119, 31)
        Label5.TabIndex = 44
        Label5.Text = "Content:"
        ' 
        ' contentadmin
        ' 
        contentadmin.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        contentadmin.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        contentadmin.Location = New Point(493, 237)
        contentadmin.Multiline = True
        contentadmin.Name = "contentadmin"
        contentadmin.Size = New Size(740, 375)
        contentadmin.TabIndex = 43
        ' 
        ' rackadmin
        ' 
        rackadmin.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        rackadmin.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rackadmin.Location = New Point(559, 116)
        rackadmin.Multiline = True
        rackadmin.Name = "rackadmin"
        rackadmin.Size = New Size(674, 31)
        rackadmin.TabIndex = 42
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(349, 116)
        Label4.Name = "Label4"
        Label4.Size = New Size(191, 31)
        Label4.TabIndex = 41
        Label4.Text = "Rack Location:"
        ' 
        ' authoradmin
        ' 
        authoradmin.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        authoradmin.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        authoradmin.Location = New Point(999, 58)
        authoradmin.Multiline = True
        authoradmin.Name = "authoradmin"
        authoradmin.Size = New Size(234, 31)
        authoradmin.TabIndex = 40
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(879, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 31)
        Label1.TabIndex = 39
        Label1.Text = "Author:"
        ' 
        ' publisheradmin
        ' 
        publisheradmin.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        publisheradmin.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        publisheradmin.Location = New Point(493, 167)
        publisheradmin.Multiline = True
        publisheradmin.Name = "publisheradmin"
        publisheradmin.Size = New Size(740, 31)
        publisheradmin.TabIndex = 38
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(349, 167)
        Label3.Name = "Label3"
        Label3.Size = New Size(138, 31)
        Label3.TabIndex = 37
        Label3.Text = "Publisher:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(349, 56)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 31)
        Label2.TabIndex = 36
        Label2.Text = "Title:"
        ' 
        ' titleadmin
        ' 
        titleadmin.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        titleadmin.Location = New Point(431, 58)
        titleadmin.Multiline = True
        titleadmin.Name = "titleadmin"
        titleadmin.Size = New Size(416, 31)
        titleadmin.TabIndex = 35
        ' 
        ' returnbooksbtn2
        ' 
        returnbooksbtn2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        returnbooksbtn2.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        returnbooksbtn2.BackgroundImageLayout = ImageLayout.None
        returnbooksbtn2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        returnbooksbtn2.ForeColor = Color.Transparent
        returnbooksbtn2.Location = New Point(25, 1179)
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
        logoutadmin.Location = New Point(82, 1262)
        logoutadmin.Name = "logoutadmin"
        logoutadmin.Size = New Size(255, 61)
        logoutadmin.TabIndex = 30
        logoutadmin.Text = "Log out "
        logoutadmin.UseVisualStyleBackColor = False
        ' 
        ' saved
        ' 
        saved.Anchor = AnchorStyles.None
        saved.Location = New Point(73, 1993)
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
        clear.Location = New Point(73, 2048)
        clear.Name = "clear"
        clear.Size = New Size(187, 41)
        clear.TabIndex = 7
        clear.Text = "Clear"
        clear.UseVisualStyleBackColor = False
        ' 
        ' logout
        ' 
        logout.Anchor = AnchorStyles.None
        logout.Location = New Point(73, 2161)
        logout.Name = "logout"
        logout.Size = New Size(187, 44)
        logout.TabIndex = 4
        logout.Text = "Log Out"
        logout.UseVisualStyleBackColor = True
        ' 
        ' list
        ' 
        list.Anchor = AnchorStyles.None
        list.Location = New Point(73, 2101)
        list.Name = "list"
        list.Size = New Size(187, 44)
        list.TabIndex = 3
        list.Text = "List of Student"
        list.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        Panel1.Controls.Add(returnbooksbtn1)
        Panel1.Controls.Add(logoutadmin1)
        Panel1.Controls.Add(returnbooksbtn2)
        Panel1.Controls.Add(users)
        Panel1.Controls.Add(viewbooks)
        Panel1.Controls.Add(logoutadmin)
        Panel1.Controls.Add(saved)
        Panel1.Controls.Add(clear)
        Panel1.Controls.Add(logout)
        Panel1.Controls.Add(list)
        Panel1.Location = New Point(3, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(315, 726)
        Panel1.TabIndex = 34
        ' 
        ' returnbooksbtn1
        ' 
        returnbooksbtn1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        returnbooksbtn1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        returnbooksbtn1.BackgroundImageLayout = ImageLayout.None
        returnbooksbtn1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        returnbooksbtn1.ForeColor = Color.Transparent
        returnbooksbtn1.Location = New Point(25, 551)
        returnbooksbtn1.Name = "returnbooksbtn1"
        returnbooksbtn1.Size = New Size(255, 61)
        returnbooksbtn1.TabIndex = 47
        returnbooksbtn1.Text = "Return books"
        returnbooksbtn1.UseVisualStyleBackColor = False
        ' 
        ' logoutadmin1
        ' 
        logoutadmin1.Anchor = AnchorStyles.Bottom
        logoutadmin1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        logoutadmin1.BackgroundImageLayout = ImageLayout.None
        logoutadmin1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        logoutadmin1.ForeColor = Color.Transparent
        logoutadmin1.Location = New Point(25, 634)
        logoutadmin1.Name = "logoutadmin1"
        logoutadmin1.Size = New Size(255, 61)
        logoutadmin1.TabIndex = 46
        logoutadmin1.Text = "Log out "
        logoutadmin1.UseVisualStyleBackColor = False
        ' 
        ' StaffPage
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
        Name = "StaffPage"
        Text = "StaffPage"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents donebook As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents contentadmin As TextBox
    Friend WithEvents rackadmin As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents authoradmin As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents publisheradmin As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents titleadmin As TextBox
    Friend WithEvents returnbooksbtn2 As Button
    Friend WithEvents users As Button
    Friend WithEvents viewbooks As Button
    Friend WithEvents logoutadmin As Button
    Friend WithEvents saved As Button
    Friend WithEvents clear As Button
    Friend WithEvents logout As Button
    Friend WithEvents list As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents returnbooksbtn1 As Button
    Friend WithEvents logoutadmin1 As Button
End Class
