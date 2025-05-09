Imports System.Net
Imports FireSharp.Config
Imports FireSharp.Interfaces
Imports FireSharp.Response
Imports Newtonsoft.Json

Public Class Student_Account
    ' Firebase config
    Private fcon As New FirebaseConfig() With {
        .AuthSecret = "B5iNSPj0nG0fhbIdCeMIeILkK6NYh8MnJjpsCUtW",
        .BasePath = "https://elibrary-6e689-default-rtdb.firebaseio.com/"
    }

    Private client As IFirebaseClient
    Public Property StudentFullName As String

    ' Set during login or navigation
    Public Property StudentEmail As String

    Private hiddenKey As String = ""

    Private Sub Student_Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)
            If client Is Nothing Then
                MessageBox.Show("Connection to Firebase failed.")
                Return
            End If

            firstname.Text = StudentFullName


            ' Load user data using email (search by email)
            Dim response As FirebaseResponse = client.Get("users")
            If response.StatusCode = HttpStatusCode.OK Then
                Dim data = JsonConvert.DeserializeObject(Of Dictionary(Of String, User))(response.Body)
                For Each item In data
                    If item.Value.email = StudentEmail Then
                        ' Populate fields
                        firstnametext.Text = item.Value.firstname
                        lastnametext.Text = item.Value.lastname

                        agetext.Text = item.Value.age
                        emailtext.Text = item.Value.email
                        passtext.Text = item.Value.password

                        hiddenKey = item.Key ' store for updating
                        Exit For
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading user: " & ex.Message)
        End Try
    End Sub

    Private Sub changeinfo_Click(sender As Object, e As EventArgs) Handles changeinfo.Click
        If client Is Nothing OrElse String.IsNullOrWhiteSpace(hiddenKey) Then
            MessageBox.Show("Cannot update: Firebase not ready.")
            Return
        End If

        Dim updatedUser As New User With {
            .firstname = firstnametext.Text,
            .lastname = lastnametext.Text,
            .email = emailtext.Text,
            .password = passtext.Text,
            .age = agetext.Text
        }

        Try
            Dim setter = client.Update("users/" & hiddenKey, updatedUser)
            If setter.StatusCode = HttpStatusCode.OK Then
                MessageBox.Show("Information updated successfully!")
            Else
                MessageBox.Show("Update failed.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating info: " & ex.Message)
        End Try
    End Sub

    ' Define user class without gender and role
    Public Class User
        Public Property firstname As String
        Public Property lastname As String
        Public Property suffix As String
        Public Property email As String
        Public Property password As String
        Public Property age As String
    End Class

    Private Sub firstname_Click(sender As Object, e As EventArgs) Handles firstname.Click

    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Me.Close()
    End Sub
End Class
