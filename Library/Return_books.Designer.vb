<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Return_books
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
        namestudent = New Label()
        Label6 = New Label()
        Label1 = New Label()
        rolestudent = New Label()
        Label3 = New Label()
        Books = New ComboBox()
        Label4 = New Label()
        complain = New TextBox()
        closebtn = New Button()
        sendadmin = New Button()
        SuspendLayout()
        ' 
        ' namestudent
        ' 
        namestudent.AutoSize = True
        namestudent.Font = New Font("Rockwell", 18F)
        namestudent.Location = New Point(139, 36)
        namestudent.Name = "namestudent"
        namestudent.Size = New Size(57, 27)
        namestudent.TabIndex = 20
        namestudent.Text = "N/A"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Rockwell", 18F)
        Label6.Location = New Point(21, 36)
        Label6.Name = "Label6"
        Label6.Size = New Size(84, 27)
        Label6.TabIndex = 19
        Label6.Text = "Name:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell", 18F)
        Label1.Location = New Point(475, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 27)
        Label1.TabIndex = 21
        Label1.Text = "Role:"
        ' 
        ' rolestudent
        ' 
        rolestudent.AutoSize = True
        rolestudent.Font = New Font("Rockwell", 18F)
        rolestudent.Location = New Point(572, 36)
        rolestudent.Name = "rolestudent"
        rolestudent.Size = New Size(57, 27)
        rolestudent.TabIndex = 22
        rolestudent.Text = "N/A"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Rockwell", 18F)
        Label3.Location = New Point(21, 104)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 27)
        Label3.TabIndex = 23
        Label3.Text = "Books:"
        ' 
        ' Books
        ' 
        Books.FormattingEnabled = True
        Books.Location = New Point(146, 104)
        Books.Name = "Books"
        Books.Size = New Size(330, 23)
        Books.TabIndex = 24
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Rockwell", 18F)
        Label4.Location = New Point(12, 168)
        Label4.Name = "Label4"
        Label4.Size = New Size(128, 27)
        Label4.TabIndex = 25
        Label4.Text = "Complain:"
        ' 
        ' complain
        ' 
        complain.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        complain.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        complain.Location = New Point(146, 168)
        complain.Multiline = True
        complain.Name = "complain"
        complain.Size = New Size(596, 305)
        complain.TabIndex = 26
        ' 
        ' closebtn
        ' 
        closebtn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        closebtn.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        closebtn.BackgroundImageLayout = ImageLayout.None
        closebtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        closebtn.ForeColor = Color.Transparent
        closebtn.Location = New Point(146, 491)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(291, 61)
        closebtn.TabIndex = 27
        closebtn.Text = "Close"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' sendadmin
        ' 
        sendadmin.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        sendadmin.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        sendadmin.BackgroundImageLayout = ImageLayout.None
        sendadmin.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        sendadmin.ForeColor = Color.Transparent
        sendadmin.Location = New Point(451, 491)
        sendadmin.Name = "sendadmin"
        sendadmin.Size = New Size(291, 61)
        sendadmin.TabIndex = 28
        sendadmin.Text = "Send to Admin"
        sendadmin.UseVisualStyleBackColor = False
        ' 
        ' Return_books
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 570)
        Controls.Add(sendadmin)
        Controls.Add(closebtn)
        Controls.Add(complain)
        Controls.Add(Label4)
        Controls.Add(Books)
        Controls.Add(Label3)
        Controls.Add(rolestudent)
        Controls.Add(Label1)
        Controls.Add(namestudent)
        Controls.Add(Label6)
        Name = "Return_books"
        Text = "Return_books"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents namestudent As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rolestudent As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Books As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents complain As TextBox
    Friend WithEvents closebtn As Button
    Friend WithEvents sendadmin As Button
End Class
