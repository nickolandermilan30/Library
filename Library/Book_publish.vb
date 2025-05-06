Public Class Book_publish
    Public Property BookTitle As String
    Public Property BookAuthor As String
    Public Property BookPublisher As String
    Public Property BookRack As String
    Public Property BookContent As String

    Private pages As List(Of String) ' List of text chunks
    Private currentPageIndex As Integer = 0

    Private Sub Book_publish_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        titlebook.Text = BookTitle
        authorbook.Text = BookAuthor
        publisherbook.Text = BookPublisher
        rackbook.Text = BookRack

        ' Split the content into pages
        pages = SplitContentIntoPages(BookContent, 500) ' 500 = characters per page
        ShowCurrentPage()
    End Sub

    Private Sub ShowCurrentPage()
        If pages IsNot Nothing AndAlso pages.Count > 0 Then
            content.Text = pages(currentPageIndex)
        Else
            content.Text = "No content available."
        End If
    End Sub

    Private Function SplitContentIntoPages(text As String, charsPerPage As Integer) As List(Of String)
        Dim result As New List(Of String)
        Dim i As Integer = 0
        While i < text.Length
            Dim length As Integer = Math.Min(charsPerPage, text.Length - i)
            result.Add(text.Substring(i, length))
            i += charsPerPage
        End While
        Return result
    End Function

    Private Sub nextpage_Click(sender As Object, e As EventArgs) Handles nextpage.Click
        If pages Is Nothing OrElse pages.Count = 0 Then Return

        If currentPageIndex < pages.Count - 1 Then
            currentPageIndex += 1
            ShowCurrentPage()
        Else
            MessageBox.Show("You're on the last page.")
        End If
    End Sub

    Private Sub prev_Click(sender As Object, e As EventArgs) Handles prev.Click
        If pages Is Nothing OrElse pages.Count = 0 Then Return

        If currentPageIndex > 0 Then
            currentPageIndex -= 1
            ShowCurrentPage()
        Else
            MessageBox.Show("You're on the first page.")
        End If
    End Sub

    Private Sub closebook_Click(sender As Object, e As EventArgs) Handles closebook.Click
        Me.Close()
    End Sub
End Class
