<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Book_publish
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
        Label6 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        content = New TextBox()
        prev = New Button()
        titlebook = New Label()
        authorbook = New Label()
        rackbook = New Label()
        publisherbook = New Label()
        nextpage = New Button()
        closebook = New Button()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(42, 40)
        Label6.Name = "Label6"
        Label6.Size = New Size(76, 31)
        Label6.TabIndex = 18
        Label6.Text = "Title:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(42, 88)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 31)
        Label1.TabIndex = 19
        Label1.Text = "Author:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(42, 186)
        Label2.Name = "Label2"
        Label2.Size = New Size(138, 31)
        Label2.TabIndex = 20
        Label2.Text = "Publisher:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(42, 136)
        Label4.Name = "Label4"
        Label4.Size = New Size(191, 31)
        Label4.TabIndex = 21
        Label4.Text = "Rack Location:"
        ' 
        ' content
        ' 
        content.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        content.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        content.Location = New Point(42, 256)
        content.Multiline = True
        content.Name = "content"
        content.Size = New Size(1008, 447)
        content.TabIndex = 22
        ' 
        ' prev
        ' 
        prev.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        prev.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        prev.BackgroundImageLayout = ImageLayout.None
        prev.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        prev.ForeColor = Color.Transparent
        prev.Location = New Point(42, 722)
        prev.Name = "prev"
        prev.Size = New Size(474, 61)
        prev.TabIndex = 23
        prev.Text = "Preview"
        prev.UseVisualStyleBackColor = False
        ' 
        ' titlebook
        ' 
        titlebook.AutoSize = True
        titlebook.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        titlebook.Location = New Point(251, 40)
        titlebook.Name = "titlebook"
        titlebook.Size = New Size(64, 31)
        titlebook.TabIndex = 24
        titlebook.Text = "N/A"
        ' 
        ' authorbook
        ' 
        authorbook.AutoSize = True
        authorbook.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        authorbook.Location = New Point(251, 88)
        authorbook.Name = "authorbook"
        authorbook.Size = New Size(64, 31)
        authorbook.TabIndex = 25
        authorbook.Text = "N/A"
        ' 
        ' rackbook
        ' 
        rackbook.AutoSize = True
        rackbook.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rackbook.Location = New Point(251, 136)
        rackbook.Name = "rackbook"
        rackbook.Size = New Size(64, 31)
        rackbook.TabIndex = 26
        rackbook.Text = "N/A"
        ' 
        ' publisherbook
        ' 
        publisherbook.AutoSize = True
        publisherbook.Font = New Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        publisherbook.Location = New Point(251, 186)
        publisherbook.Name = "publisherbook"
        publisherbook.Size = New Size(64, 31)
        publisherbook.TabIndex = 27
        publisherbook.Text = "N/A"
        ' 
        ' nextpage
        ' 
        nextpage.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        nextpage.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        nextpage.BackgroundImageLayout = ImageLayout.None
        nextpage.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        nextpage.ForeColor = Color.Transparent
        nextpage.Location = New Point(576, 722)
        nextpage.Name = "nextpage"
        nextpage.Size = New Size(474, 61)
        nextpage.TabIndex = 28
        nextpage.Text = "Next"
        nextpage.UseVisualStyleBackColor = False
        ' 
        ' closebook
        ' 
        closebook.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        closebook.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        closebook.BackgroundImageLayout = ImageLayout.None
        closebook.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        closebook.ForeColor = Color.Transparent
        closebook.Location = New Point(760, 40)
        closebook.Name = "closebook"
        closebook.Size = New Size(290, 61)
        closebook.TabIndex = 29
        closebook.Text = "Close"
        closebook.UseVisualStyleBackColor = False
        ' 
        ' Book_publish
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1086, 805)
        Controls.Add(closebook)
        Controls.Add(nextpage)
        Controls.Add(publisherbook)
        Controls.Add(rackbook)
        Controls.Add(authorbook)
        Controls.Add(titlebook)
        Controls.Add(prev)
        Controls.Add(content)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Label6)
        Name = "Book_publish"
        Text = "Book_publish"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents content As TextBox
    Friend WithEvents prev As Button
    Friend WithEvents titlebook As Label
    Friend WithEvents authorbook As Label
    Friend WithEvents rackbook As Label
    Friend WithEvents publisherbook As Label
    Friend WithEvents nextpage As Button
    Friend WithEvents closebook As Button
End Class
