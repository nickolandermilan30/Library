
Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports Newtonsoft.Json
Public Class Form1
    Private fcon As New FirebaseConfig() With {
        .AuthSecret = "B5iNSPj0nG0fhbIdCeMIeILkK6NYh8MnJjpsCUtW",
        .BasePath = "https://elibrary-6e689-default-rtdb.firebaseio.com/"
    }

    Private client As IFirebaseClient

    Private Sub register_Click(sender As Object, e As EventArgs) Handles register.Click
        Dim regForm As New Register
        regForm.Show()
        Me.Hide()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)
            If client Is Nothing Then
                MessageBox.Show("Connection to Firebase failed.")
            End If
        Catch ex As Exception
            MessageBox.Show("Firebase Init Error: " & ex.Message)
        End Try
    End Sub

    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        If client Is Nothing Then
            MessageBox.Show("Firebase client not initialized.")
            Return
        End If

        If String.IsNullOrWhiteSpace(email.Text) OrElse String.IsNullOrWhiteSpace(password.Text) Then
            MessageBox.Show("Please enter both email and password.")
            Return
        End If

        Try
            ' Get all users from Firebase
            Dim response As FirebaseResponse = client.Get("users")
            Dim data As Dictionary(Of String, UserData) = JsonConvert.DeserializeObject(Of Dictionary(Of String, UserData))(response.Body)

            ' Search for matching credentials
            For Each pair In data
                Dim user = pair.Value
                If user.email = email.Text AndAlso user.password = password.Text Then
                    ' Redirect based on role
                    Select Case user.role.ToLower()
                        Case "admin"
                            Dim adminForm As New AdminPage
                            adminForm.Show()
                        Case "staff"
                            Dim staffForm As New StaffPage
                            staffForm.Show()
                        Case "student"
                            Dim studentForm As New StudentPage
                            studentForm.Show()
                        Case Else
                            MessageBox.Show("Unrecognized role.")
                            Return
                    End Select

                    Me.Hide()
                    Return
                End If
            Next

            ' If no match found
            MessageBox.Show("Invalid email or password.")

        Catch ex As Exception
            MessageBox.Show("Login error: " & ex.Message)
        End Try
    End Sub

    Public Class UserData
        Public Property firstname As String
        Public Property lastname As String
        Public Property suffix As String
        Public Property email As String
        Public Property password As String
        Public Property age As String
        Public Property gender As String
        Public Property role As String
    End Class


End Class
