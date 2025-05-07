Imports FireSharp.Config
Imports FireSharp.Interfaces
Imports FireSharp.Response
Imports Newtonsoft.Json

Public Class StaffPage

    ' Firebase config
    Private fcon As New FirebaseConfig() With {
        .AuthSecret = "B5iNSPj0nG0fhbIdCeMIeILkK6NYh8MnJjpsCUtW",
        .BasePath = "https://elibrary-6e689-default-rtdb.firebaseio.com/"
    }

    Private client As IFirebaseClient

    Private Sub StaffPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        client = New FireSharp.FirebaseClient(fcon)

        ' Optional: make content field scrollable
        contentadmin.Multiline = True
        contentadmin.ScrollBars = ScrollBars.Vertical
    End Sub

    Private Sub viewbooks_Click(sender As Object, e As EventArgs) Handles viewbooks.Click
        Dim publishForm As New Publish_book()
        publishForm.StaffRef = Me ' Pass StaffPage reference
        publishForm.Show()
    End Sub

    Private Sub logoutadmin1_Click(sender As Object, e As EventArgs) Handles logoutadmin1.Click
        Me.Hide()
        Dim loginForm As New Form1
        loginForm.Show()
    End Sub

    ' BookRequest structure for Firebase
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

    ' ✅ Save to Firebase when "Done" is clicked
    Private Async Sub donebook_Click(sender As Object, e As EventArgs) Handles donebook.Click
        If client Is Nothing Then
            MessageBox.Show("Not connected to Firebase.")
            Return
        End If

        Dim bookReq As New BookRequest With {
            .title = titleadmin.Text,
            .author = authoradmin.Text,
            .publisher = publisheradmin.Text,
            .rack = rackadmin.Text,
            .content = contentadmin.Text,
            .submitted_by = "Staff", ' <-- Staff instead of Admin
            .email = "staff@example.com", ' Optional email field
            .submitted_at = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        }

        Try
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

    Private Sub returnbooksbtn1_Click(sender As Object, e As EventArgs) Handles returnbooksbtn1.Click
        Dim returnForm As New Admin_return_books()
        returnForm.Show() ' Use ShowDialog() if you want it modal
    End Sub

End Class
