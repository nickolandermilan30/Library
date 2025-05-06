<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Users_account
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
        userlist = New DataGridView()
        Label6 = New Label()
        closelist = New Button()
        CType(userlist, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' userlist
        ' 
        userlist.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        userlist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        userlist.Location = New Point(21, 84)
        userlist.Name = "userlist"
        userlist.Size = New Size(1012, 448)
        userlist.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.Font = New Font("Rockwell", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Fuchsia
        Label6.Location = New Point(375, 26)
        Label6.Name = "Label6"
        Label6.Size = New Size(309, 39)
        Label6.TabIndex = 19
        Label6.Text = "Book List Request "
        ' 
        ' closelist
        ' 
        closelist.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        closelist.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        closelist.BackgroundImageLayout = ImageLayout.None
        closelist.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        closelist.ForeColor = Color.Transparent
        closelist.Location = New Point(21, 548)
        closelist.Name = "closelist"
        closelist.Size = New Size(1012, 61)
        closelist.TabIndex = 34
        closelist.Text = "Close"
        closelist.UseVisualStyleBackColor = False
        ' 
        ' Users_account
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1054, 631)
        Controls.Add(closelist)
        Controls.Add(Label6)
        Controls.Add(userlist)
        Name = "Users_account"
        Text = "Users_account"
        CType(userlist, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents userlist As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents closelist As Button
End Class
