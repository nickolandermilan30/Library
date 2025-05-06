Imports FireSharp.Config
Imports FireSharp.Interfaces
Imports FireSharp.Response
Imports Newtonsoft.Json

Public Class List_Book
    Private fcon As New FirebaseConfig() With {
        .AuthSecret = "B5iNSPj0nG0fhbIdCeMIeILkK6NYh8MnJjpsCUtW",
        .BasePath = "https://elibrary-6e689-default-rtdb.firebaseio.com/"
    }

    Private client As IFirebaseClient

    Public Property AdminPageRef As AdminPage ' Reference to AdminPage

    Private Sub List_Book_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        client = New FireSharp.FirebaseClient(fcon)
        If client Is Nothing Then
            MessageBox.Show("Connection failed.")
            Return
        End If

        Try
            Dim res As FirebaseResponse = client.Get("student_book")
            Dim dict = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(res.Body)

            If dict IsNot Nothing Then
                For Each studentKey In dict.Keys
                    liststudentnbook.Items.Add(studentKey.Replace("_", " ")) ' display nicely
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading student list: " & ex.Message)
        End Try
    End Sub

    Private Sub liststudentnbook_SelectedIndexChanged(sender As Object, e As EventArgs) Handles liststudentnbook.SelectedIndexChanged
        If liststudentnbook.SelectedItem Is Nothing OrElse AdminPageRef Is Nothing Then Return

        Dim selectedName As String = liststudentnbook.SelectedItem.ToString()
        AdminPageRef.LoadStudentBookData(selectedName)
        Me.Close()
    End Sub
End Class
