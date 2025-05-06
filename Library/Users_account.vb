Imports FireSharp.Config
Imports FireSharp.Interfaces
Imports FireSharp.Response
Imports Newtonsoft.Json

Public Class Users_account

    ' Firebase configuration
    Private fcon As New FirebaseConfig() With {
        .AuthSecret = "B5iNSPj0nG0fhbIdCeMIeILkK6NYh8MnJjpsCUtW",
        .BasePath = "https://elibrary-6e689-default-rtdb.firebaseio.com/"
    }

    Private client As IFirebaseClient

    Private Sub Users_account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)
            If client Is Nothing Then
                MessageBox.Show("Failed to connect to Firebase.")
                Return
            End If

            LoadUserList()

        Catch ex As Exception
            MessageBox.Show("Error initializing Firebase: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadUserList()
        Try
            Dim response As FirebaseResponse = client.Get("users")
            If response.Body = "null" Then
                MessageBox.Show("No user data found.")
                Return
            End If

            ' Deserialize into a dictionary of users
            Dim users As Dictionary(Of String, User) = JsonConvert.DeserializeObject(Of Dictionary(Of String, User))(response.Body)

            If users IsNot Nothing Then
                Dim userDataList As New List(Of User)

                For Each entry In users.Values
                    userDataList.Add(entry)
                Next

                ' ✅ Bind the list to the DataGridView
                userlist.DataSource = userDataList
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading users: " & ex.Message)
        End Try
    End Sub

    ' Define user structure
    Public Class User
        Public Property firstname As String
        Public Property lastname As String
        Public Property suffix As String
        Public Property gender As String
        Public Property age As String
        Public Property email As String
        Public Property password As String
        Public Property role As String
    End Class

    Private Sub userlist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles userlist.CellContentClick
        ' Optional: Handle cell clicks here
    End Sub

    Private Sub closelist_Click(sender As Object, e As EventArgs) Handles closelist.Click
        Me.Close()
    End Sub
End Class
