Imports FireSharp.Config
Imports FireSharp.Interfaces
Imports FireSharp.Response
Imports Newtonsoft.Json

Public Class Return_books

    Public Property StudentName As String
    Public Property StudentRole As String

    Private client As IFirebaseClient

    Private Sub Return_books_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display student info
        namestudent.Text = StudentName
        rolestudent.Text = StudentRole

        ' Initialize Firebase and load book titles
        InitializeFirebase()
        LoadStudentBooks()
    End Sub

    ' Firebase configuration
    Private Sub InitializeFirebase()
        Dim fcon As New FirebaseConfig With {
            .AuthSecret = "B5iNSPj0nG0fhbIdCeMIeILkK6NYh8MnJjpsCUtW",
            .BasePath = "https://elibrary-6e689-default-rtdb.firebaseio.com/"
        }

        Try
            client = New FireSharp.FirebaseClient(fcon)
            If client Is Nothing Then
                MessageBox.Show("Firebase connection failed.")
            End If
        Catch ex As Exception
            MessageBox.Show("Firebase init error: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadStudentBooks()
        Try
            ' Format the path based on the student's name
            Dim studentKey As String = StudentName.Replace(" ", "_")
            Dim response As FirebaseResponse = client.Get("student_book/" & studentKey)

            If response.Body = "null" Then
                MessageBox.Show("No books found for this student.")
                Return
            End If

            ' Deserialize the books into a dictionary
            Dim booksDict As Dictionary(Of String, BookData) =
                JsonConvert.DeserializeObject(Of Dictionary(Of String, BookData))(response.Body)

            ' Populate the ComboBox with book titles
            Books.Items.Clear()
            For Each book In booksDict.Values
                Books.Items.Add(book.title)
            Next

        Catch ex As Exception
            MessageBox.Show("Error loading books: " & ex.Message)
        End Try
    End Sub

    Private Sub Books_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Books.SelectedIndexChanged
        ' Optional: Display more book details here if needed
        Dim selectedTitle As String = Books.SelectedItem?.ToString()
        If Not String.IsNullOrEmpty(selectedTitle) Then
            MessageBox.Show("Selected book: " & selectedTitle)
        End If
    End Sub

    ' Define BookData class for deserialization
    Private Class BookData
        Public Property title As String
        Public Property author As String
        Public Property publisher As String
        Public Property rack As String
        Public Property content As String
        Public Property submitted_by As String
        Public Property email As String
        Public Property submitted_at As String
    End Class

    Private Sub complain_TextChanged(sender As Object, e As EventArgs) Handles complain.TextChanged

    End Sub

    Private Sub sendadmin_Click(sender As Object, e As EventArgs) Handles sendadmin.Click
        ' Validate input
        If Books.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a book.")
            Return
        End If

        If String.IsNullOrWhiteSpace(complain.Text) Then
            MessageBox.Show("Please enter your complaint.")
            Return
        End If

        ' Create a complaint object
        Dim complaintData As New With {
        .student_name = StudentName,
        .student_role = StudentRole,
        .book_title = Books.SelectedItem.ToString(),
        .complaint_text = complain.Text,
        .submitted_at = Date.Now.ToString("yyyy-MM-dd HH:mm:ss")
    }

        Try
            ' Push to Firebase under "book_complaints/"
            Dim response As FirebaseResponse = client.Push("book_complaints", complaintData)

            If response.StatusCode = Net.HttpStatusCode.OK Then
                MessageBox.Show("Complaint submitted successfully!")
                complain.Clear()
            Else
                MessageBox.Show("Failed to submit complaint.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error submitting complaint: " & ex.Message)
        End Try
    End Sub


    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Me.Close()
    End Sub
End Class
