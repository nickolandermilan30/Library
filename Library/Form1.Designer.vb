<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        Label2 = New Label()
        email = New TextBox()
        password = New TextBox()
        Label3 = New Label()
        register = New Button()
        login = New Button()
        showpassword = New CheckBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(248, 353)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 31)
        Label1.TabIndex = 0
        Label1.Text = "Email:"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(201, 417)
        Label2.Name = "Label2"
        Label2.Size = New Size(139, 31)
        Label2.TabIndex = 1
        Label2.Text = "Password:"
        ' 
        ' email
        ' 
        email.Anchor = AnchorStyles.Top
        email.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        email.Location = New Point(346, 353)
        email.Multiline = True
        email.Name = "email"
        email.Size = New Size(445, 31)
        email.TabIndex = 2
        ' 
        ' password
        ' 
        password.Anchor = AnchorStyles.Top
        password.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        password.Location = New Point(346, 417)
        password.Multiline = True
        password.Name = "password"
        password.PasswordChar = "*"c
        password.Size = New Size(445, 31)
        password.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Rockwell", 72F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        Label3.Location = New Point(346, 176)
        Label3.Name = "Label3"
        Label3.Size = New Size(430, 106)
        Label3.TabIndex = 4
        Label3.Text = "ELibrary"
        ' 
        ' register
        ' 
        register.Anchor = AnchorStyles.Top
        register.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        register.BackgroundImageLayout = ImageLayout.None
        register.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        register.ForeColor = Color.Transparent
        register.Location = New Point(346, 532)
        register.Name = "register"
        register.Size = New Size(208, 61)
        register.TabIndex = 5
        register.Text = "Register"
        register.UseVisualStyleBackColor = False
        ' 
        ' login
        ' 
        login.Anchor = AnchorStyles.Top
        login.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        login.BackgroundImageLayout = ImageLayout.None
        login.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        login.ForeColor = Color.Transparent
        login.Location = New Point(582, 532)
        login.Name = "login"
        login.Size = New Size(209, 61)
        login.TabIndex = 6
        login.Text = "Log In"
        login.UseVisualStyleBackColor = False
        ' 
        ' showpassword
        ' 
        showpassword.Anchor = AnchorStyles.Top
        showpassword.AutoSize = True
        showpassword.Location = New Point(683, 467)
        showpassword.Name = "showpassword"
        showpassword.Size = New Size(108, 19)
        showpassword.TabIndex = 7
        showpassword.Text = "Show password"
        showpassword.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1071, 762)
        Controls.Add(showpassword)
        Controls.Add(login)
        Controls.Add(register)
        Controls.Add(Label3)
        Controls.Add(password)
        Controls.Add(email)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Log in"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents email As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents register As Button
    Friend WithEvents login As Button
    Friend WithEvents showpassword As CheckBox

End Class
