<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_Account
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
        Label2 = New Label()
        firstnametext = New TextBox()
        Label1 = New Label()
        lastnametext = New TextBox()
        Label4 = New Label()
        emailtext = New TextBox()
        passtext = New TextBox()
        Label5 = New Label()
        changeinfo = New Button()
        logout = New Button()
        Label6 = New Label()
        Label7 = New Label()
        agetext = New TextBox()
        firstname = New Label()
        adjusttext = New Label()
        Label10 = New Label()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(216, 223)
        Label2.Name = "Label2"
        Label2.Size = New Size(143, 31)
        Label2.TabIndex = 10
        Label2.Text = "Firstname:"
        ' 
        ' firstnametext
        ' 
        firstnametext.Anchor = AnchorStyles.Top
        firstnametext.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        firstnametext.Location = New Point(365, 225)
        firstnametext.Multiline = True
        firstnametext.Name = "firstnametext"
        firstnametext.Size = New Size(330, 29)
        firstnametext.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(216, 273)
        Label1.Name = "Label1"
        Label1.Size = New Size(137, 31)
        Label1.TabIndex = 12
        Label1.Text = "Lastname:"
        ' 
        ' lastnametext
        ' 
        lastnametext.Anchor = AnchorStyles.Top
        lastnametext.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lastnametext.Location = New Point(365, 275)
        lastnametext.Multiline = True
        lastnametext.Name = "lastnametext"
        lastnametext.Size = New Size(143, 29)
        lastnametext.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(216, 334)
        Label4.Name = "Label4"
        Label4.Size = New Size(92, 31)
        Label4.TabIndex = 24
        Label4.Text = "Email:"
        ' 
        ' emailtext
        ' 
        emailtext.Anchor = AnchorStyles.Top
        emailtext.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        emailtext.Location = New Point(314, 334)
        emailtext.Multiline = True
        emailtext.Name = "emailtext"
        emailtext.Size = New Size(381, 29)
        emailtext.TabIndex = 25
        ' 
        ' passtext
        ' 
        passtext.Anchor = AnchorStyles.Top
        passtext.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        passtext.Location = New Point(361, 395)
        passtext.Multiline = True
        passtext.Name = "passtext"
        passtext.Size = New Size(334, 29)
        passtext.TabIndex = 27
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(216, 395)
        Label5.Name = "Label5"
        Label5.Size = New Size(139, 31)
        Label5.TabIndex = 26
        Label5.Text = "Password:"
        ' 
        ' changeinfo
        ' 
        changeinfo.Anchor = AnchorStyles.Top
        changeinfo.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        changeinfo.BackgroundImageLayout = ImageLayout.None
        changeinfo.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        changeinfo.ForeColor = Color.Transparent
        changeinfo.Location = New Point(203, 481)
        changeinfo.Name = "changeinfo"
        changeinfo.Size = New Size(209, 61)
        changeinfo.TabIndex = 28
        changeinfo.Text = "Change"
        changeinfo.UseVisualStyleBackColor = False
        ' 
        ' logout
        ' 
        logout.Anchor = AnchorStyles.Top
        logout.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        logout.BackgroundImageLayout = ImageLayout.None
        logout.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        logout.ForeColor = Color.Transparent
        logout.Location = New Point(542, 481)
        logout.Name = "logout"
        logout.Size = New Size(209, 61)
        logout.TabIndex = 29
        logout.Text = "Close"
        logout.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.Font = New Font("Rockwell", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        Label6.Location = New Point(110, 71)
        Label6.Name = "Label6"
        Label6.Size = New Size(108, 42)
        Label6.TabIndex = 30
        Label6.Text = "Hello"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.AutoSize = True
        Label7.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(531, 275)
        Label7.Name = "Label7"
        Label7.Size = New Size(73, 31)
        Label7.TabIndex = 31
        Label7.Text = "Age:"
        ' 
        ' agetext
        ' 
        agetext.Anchor = AnchorStyles.Top
        agetext.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        agetext.Location = New Point(636, 281)
        agetext.Multiline = True
        agetext.Name = "agetext"
        agetext.Size = New Size(59, 29)
        agetext.TabIndex = 32
        ' 
        ' firstname
        ' 
        firstname.Anchor = AnchorStyles.Top
        firstname.AutoSize = True
        firstname.Font = New Font("Rockwell", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        firstname.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        firstname.Location = New Point(211, 71)
        firstname.Name = "firstname"
        firstname.Size = New Size(87, 42)
        firstname.TabIndex = 33
        firstname.Text = "N/A"
        ' 
        ' adjusttext
        ' 
        adjusttext.Anchor = AnchorStyles.Top
        adjusttext.AutoSize = True
        adjusttext.Font = New Font("Rockwell", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        adjusttext.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        adjusttext.Location = New Point(216, 126)
        adjusttext.Name = "adjusttext"
        adjusttext.Size = New Size(573, 42)
        adjusttext.TabIndex = 34
        adjusttext.Text = "Let's change your account info :>"
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top
        Label10.AutoSize = True
        Label10.Font = New Font("Rockwell", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        Label10.Location = New Point(445, 500)
        Label10.Name = "Label10"
        Label10.Size = New Size(63, 42)
        Label10.TabIndex = 35
        Label10.Text = "Or"
        ' 
        ' Student_Account
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(924, 615)
        Controls.Add(Label10)
        Controls.Add(adjusttext)
        Controls.Add(firstname)
        Controls.Add(agetext)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(logout)
        Controls.Add(changeinfo)
        Controls.Add(passtext)
        Controls.Add(Label5)
        Controls.Add(emailtext)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(lastnametext)
        Controls.Add(Label2)
        Controls.Add(firstnametext)
        Name = "Student_Account"
        Text = "Student_Account"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents firstnametext As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lastnametext As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents emailtext As TextBox
    Friend WithEvents passtext As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents changeinfo As Button
    Friend WithEvents logout As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents agetext As TextBox
    Friend WithEvents firstname As Label
    Friend WithEvents adjusttext As Label
    Friend WithEvents Label10 As Label
End Class
