﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class List_Book
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
        liststudentnbook = New ListBox()
        Label6 = New Label()
        closelist = New Button()
        SuspendLayout()
        ' 
        ' liststudentnbook
        ' 
        liststudentnbook.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        liststudentnbook.FormattingEnabled = True
        liststudentnbook.ItemHeight = 30
        liststudentnbook.Location = New Point(41, 102)
        liststudentnbook.Name = "liststudentnbook"
        liststudentnbook.Size = New Size(446, 574)
        liststudentnbook.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.Font = New Font("Rockwell", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Fuchsia
        Label6.Location = New Point(108, 33)
        Label6.Name = "Label6"
        Label6.Size = New Size(309, 39)
        Label6.TabIndex = 18
        Label6.Text = "Book List Request "
        ' 
        ' closelist
        ' 
        closelist.Anchor = AnchorStyles.Top
        closelist.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        closelist.BackgroundImageLayout = ImageLayout.None
        closelist.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        closelist.ForeColor = Color.Transparent
        closelist.Location = New Point(41, 704)
        closelist.Name = "closelist"
        closelist.Size = New Size(446, 61)
        closelist.TabIndex = 31
        closelist.Text = "Close"
        closelist.UseVisualStyleBackColor = False
        ' 
        ' List_Book
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(538, 799)
        Controls.Add(closelist)
        Controls.Add(Label6)
        Controls.Add(liststudentnbook)
        Name = "List_Book"
        Text = "List_Book"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents liststudentnbook As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents closelist As Button
End Class
