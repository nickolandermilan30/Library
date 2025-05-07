Imports FireSharp.Config
Imports FireSharp.Interfaces
Imports FireSharp.Response
Imports Newtonsoft.Json

Public Class Publish_book

    ' Firebase config
    Private fcon As New FirebaseConfig() With {
        .AuthSecret = "B5iNSPj0nG0fhbIdCeMIeILkK6NYh8MnJjpsCUtW",
        .BasePath = "https://elibrary-6e689-default-rtdb.firebaseio.com/"
    }

    Private client As IFirebaseClient
    Public Property StaffRef As StaffPage ' Reference to the StaffPage form

    ' Book data class (should match your Firebase structure)
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

    Private Sub Publish_book_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)
            If client Is Nothing Then
                MessageBox.Show("Firebase connection failed.")
                Return
            End If

            LoadPublishedBooks()

        Catch ex As Exception
            MessageBox.Show("Error initializing Firebase: " & ex.Message)
        End Try
    End Sub

    Private selectedBooks As Dictionary(Of String, BookData)

    Private Sub LoadPublishedBooks()
        Try
            Dim response As FirebaseResponse = client.Get("publish_book/book_requested")
            If response.Body = "null" Then
                MessageBox.Show("No published books found.")
                Return
            End If

            selectedBooks = JsonConvert.DeserializeObject(Of Dictionary(Of String, BookData))(response.Body)

            listpublishbooks.Items.Clear()

            ' Add titles to ListView (and keep mapping to full data)
            For Each entry In selectedBooks
                listpublishbooks.Items.Add(entry.Value.title)
            Next

        Catch ex As Exception
            MessageBox.Show("Error loading books: " & ex.Message)
        End Try
    End Sub

    Private Sub listpublishbooks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listpublishbooks.SelectedIndexChanged
        If listpublishbooks.SelectedIndex = -1 Then Exit Sub

        Dim selectedTitle = listpublishbooks.SelectedItem.ToString()
        Dim selectedBook = selectedBooks.Values.FirstOrDefault(Function(b) b.title = selectedTitle)

        If selectedBook IsNot Nothing Then
            ' If opened from StaffPage, update its fields directly
            If StaffRef IsNot Nothing Then
                StaffRef.titleadmin.Text = selectedBook.title
                StaffRef.authoradmin.Text = selectedBook.author
                StaffRef.rackadmin.Text = selectedBook.rack
                StaffRef.publisheradmin.Text = selectedBook.publisher
                StaffRef.contentadmin.Text = selectedBook.content
                Me.Close() ' Optionally close the popup after selection
            Else
                ' Fallback to opening Book_publish form if used elsewhere
                Dim bookForm As New Book_publish()
                bookForm.BookTitle = selectedBook.title
                bookForm.BookAuthor = selectedBook.author
                bookForm.BookPublisher = selectedBook.publisher
                bookForm.BookRack = selectedBook.rack
                bookForm.BookContent = selectedBook.content
                bookForm.Show()
            End If
        End If
    End Sub
End Class
