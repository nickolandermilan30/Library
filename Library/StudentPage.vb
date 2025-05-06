Imports FireSharp.Config
Imports FireSharp.Interfaces
Imports FireSharp.Response
Imports Newtonsoft.Json

Public Class StudentPage
    ' Firebase configuration
    Private fcon As New FirebaseConfig() With {
        .AuthSecret = "B5iNSPj0nG0fhbIdCeMIeILkK6NYh8MnJjpsCUtW",
        .BasePath = "https://elibrary-6e689-default-rtdb.firebaseio.com/"
    }
    Private client As IFirebaseClient

    ' Properties to carry over from login
    Public Property StudentName As String
    Public Property StudentEmail As String

    Private Sub StudentPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)
            If client Is Nothing Then
                MessageBox.Show("Firebase connection failed.")
                Return
            End If
        Catch ex As Exception
            MessageBox.Show("Firebase init error: " & ex.Message)
            Return
        End Try

        namefetch.Text = StudentName
        emailfetch.Text = StudentEmail

        content.Multiline = True
        content.ScrollBars = ScrollBars.Vertical
        content.WordWrap = True


    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        ' Validate fields
        If String.IsNullOrWhiteSpace(title.Text) OrElse
       String.IsNullOrWhiteSpace(author.Text) OrElse
       String.IsNullOrWhiteSpace(publisher.Text) OrElse
       String.IsNullOrWhiteSpace(rack.Text) OrElse
       String.IsNullOrWhiteSpace(content.Text) Then
            MessageBox.Show("Please complete all book fields.")
            Return
        End If

        ' Create the book object with student info
        Dim bookData As New With {
        .title = title.Text,
        .author = author.Text,
        .publisher = publisher.Text,
        .rack = rack.Text,
        .content = content.Text,
        .submitted_by = StudentName,
        .email = StudentEmail,
        .submitted_at = Date.Now.ToString("yyyy-MM-dd HH:mm:ss")
    }

        Try
            ' Use Push to generate a unique ID for each book
            Dim path = $"student_book/{StudentName.Replace(" ", "_")}"
            Dim response = client.Push(path, bookData)

            If response.StatusCode = Net.HttpStatusCode.OK Then
                MessageBox.Show("Book submitted and saved!")
            Else
                MessageBox.Show("Book submission failed.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error submitting book: " & ex.Message)
        End Try
    End Sub


    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Me.Hide()
        Dim loginForm As New Form1
        loginForm.Show()
    End Sub

    ' Optional: TextChanged handlers (not required unless doing live validation)
    Private Sub title_TextChanged(sender As Object, e As EventArgs) Handles title.TextChanged
    End Sub

    Private Sub publisher_TextChanged(sender As Object, e As EventArgs) Handles publisher.TextChanged
    End Sub

    Private Sub rack_TextChanged(sender As Object, e As EventArgs) Handles rack.TextChanged
    End Sub

    Private Sub author_TextChanged(sender As Object, e As EventArgs) Handles author.TextChanged
    End Sub

    Private Sub content_TextChanged(sender As Object, e As EventArgs) Handles content.TextChanged
    End Sub

    Private Sub accbtn_Click(sender As Object, e As EventArgs) Handles accbtn.Click
        Dim accountForm As New Student_Account()
        accountForm.StudentEmail = StudentEmail
        accountForm.StudentFullName = StudentName ' <-- Pass name
        accountForm.Show()
    End Sub

    Private Sub viewbook_Click(sender As Object, e As EventArgs) Handles viewbook.Click
        Dim publishBookForm As New Publish_book()
        publishBookForm.Show()
    End Sub

    Private Sub returnbook_Click(sender As Object, e As EventArgs) Handles returnbook.Click
        Dim returnForm As New Return_books()
        returnForm.StudentName = StudentName
        returnForm.StudentRole = "Student" ' or another role string if available
        returnForm.Show()
    End Sub

End Class
