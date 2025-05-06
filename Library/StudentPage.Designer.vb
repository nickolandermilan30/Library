<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentPage
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
        title = New TextBox()
        Label1 = New Label()
        logout = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        author = New TextBox()
        publisher = New TextBox()
        rack = New TextBox()
        Label5 = New Label()
        content = New TextBox()
        submit = New Button()
        Label6 = New Label()
        namefetch = New Label()
        emailfetch = New Label()
        Label9 = New Label()
        accbtn = New Button()
        viewbook = New Button()
        returnbook = New Button()
        SuspendLayout()
        ' 
        ' title
        ' 
        title.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        title.Location = New Point(171, 105)
        title.Multiline = True
        title.Name = "title"
        title.Size = New Size(445, 31)
        title.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(642, 103)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 31)
        Label1.TabIndex = 3
        Label1.Text = "Author:"
        ' 
        ' logout
        ' 
        logout.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        logout.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        logout.BackgroundImageLayout = ImageLayout.None
        logout.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        logout.ForeColor = Color.Transparent
        logout.Location = New Point(12, 693)
        logout.Name = "logout"
        logout.Size = New Size(177, 61)
        logout.TabIndex = 7
        logout.Text = "Log out "
        logout.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(51, 103)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 31)
        Label2.TabIndex = 8
        Label2.Text = "Title:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(51, 182)
        Label3.Name = "Label3"
        Label3.Size = New Size(138, 31)
        Label3.TabIndex = 9
        Label3.Text = "Publisher:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(642, 182)
        Label4.Name = "Label4"
        Label4.Size = New Size(191, 31)
        Label4.TabIndex = 10
        Label4.Text = "Rack Location:"
        ' 
        ' author
        ' 
        author.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        author.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        author.Location = New Point(762, 105)
        author.Multiline = True
        author.Name = "author"
        author.Size = New Size(445, 31)
        author.TabIndex = 11
        ' 
        ' publisher
        ' 
        publisher.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        publisher.Location = New Point(213, 182)
        publisher.Multiline = True
        publisher.Name = "publisher"
        publisher.Size = New Size(403, 31)
        publisher.TabIndex = 12
        ' 
        ' rack
        ' 
        rack.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        rack.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rack.Location = New Point(852, 182)
        rack.Multiline = True
        rack.Name = "rack"
        rack.Size = New Size(355, 31)
        rack.TabIndex = 13
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(51, 259)
        Label5.Name = "Label5"
        Label5.Size = New Size(119, 31)
        Label5.TabIndex = 14
        Label5.Text = "Content:"
        ' 
        ' content
        ' 
        content.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        content.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        content.Location = New Point(204, 259)
        content.Multiline = True
        content.Name = "content"
        content.Size = New Size(1008, 495)
        content.TabIndex = 15
        ' 
        ' submit
        ' 
        submit.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        submit.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        submit.BackgroundImageLayout = ImageLayout.None
        submit.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        submit.ForeColor = Color.Transparent
        submit.Location = New Point(12, 535)
        submit.Name = "submit"
        submit.Size = New Size(177, 61)
        submit.TabIndex = 16
        submit.Text = "Submit"
        submit.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(51, 30)
        Label6.Name = "Label6"
        Label6.Size = New Size(93, 31)
        Label6.TabIndex = 17
        Label6.Text = "Name:"
        ' 
        ' namefetch
        ' 
        namefetch.AutoSize = True
        namefetch.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        namefetch.Location = New Point(150, 30)
        namefetch.Name = "namefetch"
        namefetch.Size = New Size(64, 31)
        namefetch.TabIndex = 18
        namefetch.Text = "N/A"
        ' 
        ' emailfetch
        ' 
        emailfetch.AutoSize = True
        emailfetch.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        emailfetch.Location = New Point(740, 30)
        emailfetch.Name = "emailfetch"
        emailfetch.Size = New Size(64, 31)
        emailfetch.TabIndex = 20
        emailfetch.Text = "N/A"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(642, 30)
        Label9.Name = "Label9"
        Label9.Size = New Size(92, 31)
        Label9.TabIndex = 19
        Label9.Text = "Email:"
        ' 
        ' accbtn
        ' 
        accbtn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        accbtn.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        accbtn.BackgroundImageLayout = ImageLayout.None
        accbtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        accbtn.ForeColor = Color.Transparent
        accbtn.Location = New Point(12, 612)
        accbtn.Name = "accbtn"
        accbtn.Size = New Size(177, 63)
        accbtn.TabIndex = 21
        accbtn.Text = "Account"
        accbtn.UseVisualStyleBackColor = False
        ' 
        ' viewbook
        ' 
        viewbook.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        viewbook.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        viewbook.BackgroundImageLayout = ImageLayout.None
        viewbook.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        viewbook.ForeColor = Color.Transparent
        viewbook.Location = New Point(12, 452)
        viewbook.Name = "viewbook"
        viewbook.Size = New Size(177, 61)
        viewbook.TabIndex = 22
        viewbook.Text = "View Book "
        viewbook.UseVisualStyleBackColor = False
        ' 
        ' returnbook
        ' 
        returnbook.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        returnbook.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        returnbook.BackgroundImageLayout = ImageLayout.None
        returnbook.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        returnbook.ForeColor = Color.Transparent
        returnbook.Location = New Point(12, 370)
        returnbook.Name = "returnbook"
        returnbook.Size = New Size(177, 61)
        returnbook.TabIndex = 23
        returnbook.Text = "Return Book"
        returnbook.UseVisualStyleBackColor = False
        ' 
        ' StudentPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1255, 792)
        Controls.Add(returnbook)
        Controls.Add(viewbook)
        Controls.Add(accbtn)
        Controls.Add(emailfetch)
        Controls.Add(Label9)
        Controls.Add(namefetch)
        Controls.Add(Label6)
        Controls.Add(submit)
        Controls.Add(content)
        Controls.Add(Label5)
        Controls.Add(rack)
        Controls.Add(publisher)
        Controls.Add(author)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(logout)
        Controls.Add(title)
        Controls.Add(Label1)
        Name = "StudentPage"
        Text = "StudentPage"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents title As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents logout As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents author As TextBox
    Friend WithEvents publisher As TextBox
    Friend WithEvents rack As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents content As TextBox
    Friend WithEvents submit As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents namefetch As Label
    Friend WithEvents emailfetch As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents accbtn As Button
    Friend WithEvents viewbook As Button
    Friend WithEvents returnbook As Button
End Class
