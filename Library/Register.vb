
Imports System.Net
Imports System.IO
Imports Newtonsoft.Json


Imports FireSharp.Config
Imports FireSharp.Interfaces
Imports FireSharp.Response

Public Class Register
    Private fcon As New FirebaseConfig() With {
        .AuthSecret = "B5iNSPj0nG0fhbIdCeMIeILkK6NYh8MnJjpsCUtW",
        .BasePath = "https://elibrary-6e689-default-rtdb.firebaseio.com/"
    }

    Private client As IFirebaseClient

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)
            If client Is Nothing Then
                MessageBox.Show("Connection to Firebase failed.")
            End If
        Catch ex As Exception
            MessageBox.Show("Firebase Init Error: " & ex.Message)
        End Try

        ' Populate dropdowns
        role.Items.AddRange({"Admin", "Staff", "Student"})
        gender.Items.AddRange({"Male", "Female"})
    End Sub


    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Dim loginback As New Form1
        loginback.Show()
        Me.Hide()
    End Sub

    Private Sub firstname_TextChanged(sender As Object, e As EventArgs) Handles firstname.TextChanged

    End Sub

    Private Sub lastname_TextChanged(sender As Object, e As EventArgs) Handles lastname.TextChanged

    End Sub

    Private Sub emailreg_TextChanged(sender As Object, e As EventArgs) Handles emailreg.TextChanged

    End Sub

    Private Sub passwordreg_TextChanged(sender As Object, e As EventArgs) Handles passwordreg.TextChanged

    End Sub

    Private Sub age_TextChanged(sender As Object, e As EventArgs) Handles age.TextChanged

    End Sub

    Private Sub regbutton_Click(sender As Object, e As EventArgs) Handles regbutton.Click
        If client Is Nothing Then
            MessageBox.Show("Firebase client not initialized.")
            Return
        End If


        If String.IsNullOrWhiteSpace(firstname.Text) OrElse
       String.IsNullOrWhiteSpace(lastname.Text) OrElse
       String.IsNullOrWhiteSpace(emailreg.Text) OrElse
       String.IsNullOrWhiteSpace(passwordreg.Text) OrElse
       String.IsNullOrWhiteSpace(age.Text) OrElse
       String.IsNullOrWhiteSpace(gender.Text) OrElse
       String.IsNullOrWhiteSpace(role.Text) Then

            MessageBox.Show("Registration failed. Try again. Please fill out all fields.")
            Return
        End If

        Dim user As New With {
        .firstname = firstname.Text,
        .lastname = lastname.Text,
        .email = emailreg.Text,
        .password = passwordreg.Text,
        .age = age.Text,
        .gender = gender.Text,
        .role = role.Text
    }

        Try
            Dim response = client.Push("users", user)

            If response.StatusCode = Net.HttpStatusCode.OK Then
                MessageBox.Show("Register complete!")

                ' Redirect to login
                Dim loginForm As New Form1
                loginForm.Show()
                Me.Hide()
            Else
                MessageBox.Show("Registration failed. Try again.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


End Class