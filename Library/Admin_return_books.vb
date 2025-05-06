Imports FireSharp.Config
Imports FireSharp.Interfaces
Imports FireSharp.Response
Imports Newtonsoft.Json

Public Class Admin_return_books

    Private client As IFirebaseClient

    Private Sub Admin_return_books_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Firebase Config
        Dim fcon As New FirebaseConfig With {
            .AuthSecret = "B5iNSPj0nG0fhbIdCeMIeILkK6NYh8MnJjpsCUtW",
            .BasePath = "https://elibrary-6e689-default-rtdb.firebaseio.com/"
        }

        Try
            client = New FireSharp.FirebaseClient(fcon)
            If client Is Nothing Then
                MessageBox.Show("Connection to Firebase failed.")
                Return
            End If

            ' Load student complaint names
            LoadStudentComplaints()

        Catch ex As Exception
            MessageBox.Show("Firebase init error: " & ex.Message)
        End Try
    End Sub

    ' Create a global dictionary to map student names to Firebase keys
    Private studentKeyMap As New Dictionary(Of String, String)()

    Private Sub LoadStudentComplaints()
        Try
            Dim response As FirebaseResponse = client.Get("book_complaints")
            If response.Body = "null" Then
                MessageBox.Show("No complaints found.")
                Return
            End If

            Dim complaintsDict As Dictionary(Of String, ComplaintData) =
            JsonConvert.DeserializeObject(Of Dictionary(Of String, ComplaintData))(response.Body)

            studemycomplainlist.Items.Clear()
            studentKeyMap.Clear()

            For Each entry In complaintsDict
                Dim key As String = entry.Key
                Dim studentName As String = entry.Value.student_name

                ' Add to mapping and checklist
                studentKeyMap(studentName) = key
                studemycomplainlist.Items.Add(studentName)
            Next
        Catch ex As Exception
            MessageBox.Show("Error loading complaints: " & ex.Message)
        End Try
    End Sub

    Private Sub studemycomplainlist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles studemycomplainlist.SelectedIndexChanged
        Try
            If studemycomplainlist.SelectedItem Is Nothing Then Exit Sub

            Dim selectedStudentName As String = studemycomplainlist.SelectedItem.ToString()

            ' Use the dictionary to get the Firebase key
            If Not studentKeyMap.ContainsKey(selectedStudentName) Then
                MessageBox.Show("Student key not found.")
                Return
            End If

            Dim firebaseKey As String = studentKeyMap(selectedStudentName)
            Dim response As FirebaseResponse = client.Get("book_complaints/" & firebaseKey)

            If response.Body = "null" Then
                MessageBox.Show("Complaint not found.")
                Return
            End If

            Dim complaint As ComplaintData = JsonConvert.DeserializeObject(Of ComplaintData)(response.Body)

            ' Set values to labels/textbox
            titlename.Text = complaint.book_title
            studentname.Text = complaint.student_name
            rolestudent.Text = complaint.student_role
            studentcomplain.Text = complaint.complaint_text

        Catch ex As Exception
            MessageBox.Show("Error displaying complaint: " & ex.Message)
        End Try
    End Sub


    Private Class ComplaintData
        Public Property student_name As String
        Public Property student_role As String
        Public Property book_title As String
        Public Property complaint_text As String
    End Class

    Private Sub donebook_Click(sender As Object, e As EventArgs) Handles donebook.Click
        Me.Close()
    End Sub
End Class
