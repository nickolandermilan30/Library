Imports FireSharp.Config
Imports FireSharp.Interfaces
Imports FireSharp.Response
Imports Newtonsoft.Json

Public Class AdminPage
    Private fcon As New FirebaseConfig() With {
        .AuthSecret = "B5iNSPj0nG0fhbIdCeMIeILkK6NYh8MnJjpsCUtW",
        .BasePath = "https://elibrary-6e689-default-rtdb.firebaseio.com/"
    }

    Private client As IFirebaseClient

    Private Sub AdminPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        client = New FireSharp.FirebaseClient(fcon)

        ' Make contentadmin TextBox scrollable
        contentadmin.Multiline = True
        contentadmin.ScrollBars = ScrollBars.Vertical ' Or use ScrollBars.Both
    End Sub

    Private Sub viewbooks_Click(sender As Object, e As EventArgs) Handles viewbooks.Click
        Dim listForm As New List_Book()
        listForm.AdminPageRef = Me ' pass self reference
        listForm.Show()
    End Sub

    Public Sub LoadStudentBookData(studentName As String)
        Try
            Dim path = "student_book/" & studentName.Replace(" ", "_")
            Dim response As FirebaseResponse = client.Get(path)
            If response.Body = "null" Then
                MessageBox.Show("No books found for this student.")
                Return
            End If

            ' Since multiple books might exist, load the first one only
            Dim books = JsonConvert.DeserializeObject(Of Dictionary(Of String, BookData))(response.Body)

            If books IsNot Nothing AndAlso books.Count > 0 Then
                Dim firstBook = books.Values.First()
                titleadmin.Text = firstBook.title
                authoradmin.Text = firstBook.author
                publisheradmin.Text = firstBook.publisher
                rackadmin.Text = firstBook.rack
                contentadmin.Text = firstBook.content
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading book data: " & ex.Message)
        End Try
    End Sub

    Public Class BookData
        Public Property title As String
        Public Property author As String
        Public Property publisher As String
        Public Property rack As String
        Public Property content As String
        Public Property submitted_by As String
        Public Property email As String
        Public Property submitted_at As String
    End Class

    Private Sub users_Click(sender As Object, e As EventArgs) Handles users.Click
        Dim userForm As New Users_account
        userForm.Show
    End Sub

    Private Sub logoutadmin_Click(sender As Object, e As EventArgs) Handles logoutadmin.Click
        Me.Hide()
        Dim loginForm As New Form1
        loginForm.Show()
    End Sub

    Private Async Sub donebook_Click(sender As Object, e As EventArgs) Handles donebook.Click
        If client Is Nothing Then
            MessageBox.Show("Not connected to Firebase.")
            Return
        End If

        ' Create new book entry
        Dim bookReq As New BookRequest With {
            .title = titleadmin.Text,
            .author = authoradmin.Text,
            .publisher = publisheradmin.Text,
            .rack = rackadmin.Text,
            .content = contentadmin.Text,
            .submitted_by = "Admin", ' Or pull actual logged-in admin
            .email = "admin@example.com", ' Optional
            .submitted_at = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        }

        Try
            ' Push to Firebase under publish_book/book_requested
            Dim setter = Await client.PushAsync("publish_book/book_requested", bookReq)
            If setter.Result.name IsNot Nothing Then
                MessageBox.Show("Book submitted successfully.")
            Else
                MessageBox.Show("Failed to submit book.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error saving book: " & ex.Message)
        End Try
    End Sub

    Private Sub returnbooksbtn2_Click(sender As Object, e As EventArgs) Handles returnbooksbtn2.Click
        Dim returnForm As New Admin_return_books()
        returnForm.Show() ' Or use ShowDialog() if you want it to block until closed
    End Sub

End Class

Public Class BookRequest
    Public Property title As String
    Public Property author As String
    Public Property publisher As String
    Public Property rack As String
    Public Property content As String
    Public Property submitted_by As String
    Public Property email As String
    Public Property submitted_at As String
End Class

