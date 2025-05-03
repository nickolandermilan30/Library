<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        firstname = New TextBox()
        Label1 = New Label()
        emailreg = New TextBox()
        Label2 = New Label()
        passwordreg = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        lastname = New TextBox()
        Label5 = New Label()
        role = New ComboBox()
        Label6 = New Label()
        Label7 = New Label()
        age = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        gender = New ComboBox()
        regbutton = New Button()
        back = New Button()
        suffix = New ComboBox()
        SuspendLayout()
        ' 
        ' firstname
        ' 
        firstname.Anchor = AnchorStyles.Top
        firstname.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        firstname.Location = New Point(242, 324)
        firstname.Multiline = True
        firstname.Name = "firstname"
        firstname.Size = New Size(170, 31)
        firstname.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(133, 392)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 31)
        Label1.TabIndex = 3
        Label1.Text = "Email:"
        ' 
        ' emailreg
        ' 
        emailreg.Anchor = AnchorStyles.Top
        emailreg.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        emailreg.Location = New Point(242, 392)
        emailreg.Multiline = True
        emailreg.Name = "emailreg"
        emailreg.Size = New Size(682, 31)
        emailreg.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(82, 324)
        Label2.Name = "Label2"
        Label2.Size = New Size(143, 31)
        Label2.TabIndex = 5
        Label2.Text = "Firstname:"
        ' 
        ' passwordreg
        ' 
        passwordreg.Anchor = AnchorStyles.Top
        passwordreg.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        passwordreg.Location = New Point(278, 452)
        passwordreg.Multiline = True
        passwordreg.Name = "passwordreg"
        passwordreg.Size = New Size(646, 31)
        passwordreg.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(133, 450)
        Label3.Name = "Label3"
        Label3.Size = New Size(139, 31)
        Label3.TabIndex = 7
        Label3.Text = "Password:"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(439, 324)
        Label4.Name = "Label4"
        Label4.Size = New Size(137, 31)
        Label4.TabIndex = 10
        Label4.Text = "Lastname:"
        ' 
        ' lastname
        ' 
        lastname.Anchor = AnchorStyles.Top
        lastname.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lastname.Location = New Point(582, 324)
        lastname.Multiline = True
        lastname.Name = "lastname"
        lastname.Size = New Size(170, 31)
        lastname.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(769, 324)
        Label5.Name = "Label5"
        Label5.Size = New Size(90, 31)
        Label5.TabIndex = 12
        Label5.Text = "Suffix:"
        ' 
        ' role
        ' 
        role.Anchor = AnchorStyles.Top
        role.FormattingEnabled = True
        role.Location = New Point(242, 263)
        role.Name = "role"
        role.Size = New Size(682, 23)
        role.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(94, 258)
        Label6.Name = "Label6"
        Label6.Size = New Size(131, 31)
        Label6.TabIndex = 14
        Label6.Text = "Log in as:"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.AutoSize = True
        Label7.Font = New Font("Rockwell", 72F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        Label7.Location = New Point(344, 98)
        Label7.Name = "Label7"
        Label7.Size = New Size(414, 106)
        Label7.TabIndex = 15
        Label7.Text = "Register"
        ' 
        ' age
        ' 
        age.Anchor = AnchorStyles.Top
        age.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        age.Location = New Point(242, 511)
        age.Multiline = True
        age.Name = "age"
        age.Size = New Size(245, 31)
        age.TabIndex = 17
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top
        Label8.AutoSize = True
        Label8.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(133, 511)
        Label8.Name = "Label8"
        Label8.Size = New Size(73, 31)
        Label8.TabIndex = 16
        Label8.Text = "Age:"
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top
        Label9.AutoSize = True
        Label9.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(532, 511)
        Label9.Name = "Label9"
        Label9.Size = New Size(117, 31)
        Label9.TabIndex = 18
        Label9.Text = "Gender:"
        ' 
        ' gender
        ' 
        gender.Anchor = AnchorStyles.Top
        gender.FormattingEnabled = True
        gender.Location = New Point(655, 519)
        gender.Name = "gender"
        gender.Size = New Size(269, 23)
        gender.TabIndex = 19
        ' 
        ' regbutton
        ' 
        regbutton.Anchor = AnchorStyles.Top
        regbutton.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        regbutton.BackgroundImageLayout = ImageLayout.None
        regbutton.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        regbutton.ForeColor = Color.Transparent
        regbutton.Location = New Point(582, 633)
        regbutton.Name = "regbutton"
        regbutton.Size = New Size(347, 61)
        regbutton.TabIndex = 20
        regbutton.Text = "Register"
        regbutton.UseVisualStyleBackColor = False
        ' 
        ' back
        ' 
        back.Anchor = AnchorStyles.Top
        back.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        back.BackgroundImageLayout = ImageLayout.None
        back.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        back.ForeColor = Color.Transparent
        back.Location = New Point(212, 633)
        back.Name = "back"
        back.Size = New Size(347, 61)
        back.TabIndex = 21
        back.Text = "Back"
        back.UseVisualStyleBackColor = False
        ' 
        ' suffix
        ' 
        suffix.Anchor = AnchorStyles.Top
        suffix.FormattingEnabled = True
        suffix.Location = New Point(865, 327)
        suffix.Name = "suffix"
        suffix.Size = New Size(59, 23)
        suffix.TabIndex = 22
        ' 
        ' Register
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1071, 762)
        Controls.Add(suffix)
        Controls.Add(back)
        Controls.Add(regbutton)
        Controls.Add(gender)
        Controls.Add(Label9)
        Controls.Add(age)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(role)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(lastname)
        Controls.Add(passwordreg)
        Controls.Add(Label3)
        Controls.Add(emailreg)
        Controls.Add(Label2)
        Controls.Add(firstname)
        Controls.Add(Label1)
        Name = "Register"
        Text = "Register"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents firstname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents emailreg As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents passwordreg As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lastname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents role As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents age As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents gender As ComboBox
    Friend WithEvents regbutton As Button
    Friend WithEvents back As Button
    Friend WithEvents suffix As ComboBox
End Class
