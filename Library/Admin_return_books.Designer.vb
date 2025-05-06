<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_return_books
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
        studemycomplainlist = New CheckedListBox()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        studentcomplain = New TextBox()
        donebook = New Button()
        titlename = New Label()
        studentname = New Label()
        rolestudent = New Label()
        SuspendLayout()
        ' 
        ' studemycomplainlist
        ' 
        studemycomplainlist.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        studemycomplainlist.FormattingEnabled = True
        studemycomplainlist.Location = New Point(22, 51)
        studemycomplainlist.Name = "studemycomplainlist"
        studemycomplainlist.Size = New Size(381, 700)
        studemycomplainlist.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(422, 51)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 31)
        Label2.TabIndex = 11
        Label2.Text = "Title:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(422, 94)
        Label1.Name = "Label1"
        Label1.Size = New Size(192, 31)
        Label1.TabIndex = 12
        Label1.Text = "Student Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(422, 142)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 31)
        Label3.TabIndex = 13
        Label3.Text = "Role:"
        ' 
        ' studentcomplain
        ' 
        studentcomplain.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        studentcomplain.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        studentcomplain.Location = New Point(422, 198)
        studentcomplain.Multiline = True
        studentcomplain.Name = "studentcomplain"
        studentcomplain.Size = New Size(574, 492)
        studentcomplain.TabIndex = 20
        ' 
        ' donebook
        ' 
        donebook.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        donebook.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        donebook.BackgroundImageLayout = ImageLayout.None
        donebook.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        donebook.ForeColor = Color.Transparent
        donebook.Location = New Point(422, 709)
        donebook.Name = "donebook"
        donebook.Size = New Size(574, 61)
        donebook.TabIndex = 34
        donebook.Text = "Close"
        donebook.UseVisualStyleBackColor = False
        ' 
        ' titlename
        ' 
        titlename.AutoSize = True
        titlename.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        titlename.Location = New Point(520, 51)
        titlename.Name = "titlename"
        titlename.Size = New Size(64, 31)
        titlename.TabIndex = 36
        titlename.Text = "N/A"
        ' 
        ' studentname
        ' 
        studentname.AutoSize = True
        studentname.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        studentname.Location = New Point(641, 94)
        studentname.Name = "studentname"
        studentname.Size = New Size(64, 31)
        studentname.TabIndex = 37
        studentname.Text = "N/A"
        ' 
        ' rolestudent
        ' 
        rolestudent.AutoSize = True
        rolestudent.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rolestudent.Location = New Point(520, 142)
        rolestudent.Name = "rolestudent"
        rolestudent.Size = New Size(64, 31)
        rolestudent.TabIndex = 38
        rolestudent.Text = "N/A"
        ' 
        ' Admin_return_books
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1031, 809)
        Controls.Add(rolestudent)
        Controls.Add(studentname)
        Controls.Add(titlename)
        Controls.Add(donebook)
        Controls.Add(studentcomplain)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(studemycomplainlist)
        Name = "Admin_return_books"
        Text = "Admin_return_books"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents studemycomplainlist As CheckedListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents studentcomplain As TextBox
    Friend WithEvents donebook As Button
    Friend WithEvents titlename As Label
    Friend WithEvents studentname As Label
    Friend WithEvents rolestudent As Label
End Class
