Structure student
    Dim name As String
    Dim department As String
    Dim gender As String
    Dim DOB As Date
    Dim division As String
End Structure
Public Class Form1

    Dim counter As Integer = 0
    Dim studentList(5) As student
    Dim st As student

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbdepartment.SelectedIndex = 0
    End Sub

    Private Sub cmdInsert_Click(sender As Object, e As EventArgs) Handles cmdInsert.Click
        Dim currentYear As Integer = Date.Now.Year
        Dim birthYear As Integer = stDOB.Value.Year

        If birthYear > 2005 Then
            MsgBox("Invalid Date of Birth. The year of birth cannot be greater than 2005.")
            Return
        End If

        st.name = txtName.Text
        st.DOB = stDOB.Value
        st.department = cmbdepartment.SelectedValue

        If (rdMale.Checked) Then
            st.gender = "Male"
        Else
            st.gender = "Female"
        End If

        If (rdRegular.Checked) Then
            st.division = "Regular"
        Else
            st.division = "Extension"
        End If

        If (counter <= 5) Then
            studentList(counter) = st
            counter = counter + 1
        Else
            MsgBox("Array is full !")
        End If

        txtName.Text = ""
        cmbdepartment.SelectedIndex = 0
        rdMale.Checked = True
        rdRegular.Checked = True
    End Sub

    Private Sub cmdShow_Click(sender As Object, e As EventArgs) Handles cmdShow.Click

        If counter > 0 Then
            Dim studentInfo As String = ""


            For i As Integer = 0 To counter - 1
                Dim st As student = studentList(i)


                studentInfo &= "Student " & (i + 1).ToString() & " Information:" & vbCrLf &
                               "Name: " & st.name & vbCrLf &
                               "DOB: " & st.DOB.ToString() & vbCrLf &
                               "Department: " & st.department & vbCrLf &
                               "Gender: " & st.gender & vbCrLf &
                               "Division: " & st.division & vbCrLf & vbCrLf
            Next


            MsgBox(studentInfo)
        Else
            MsgBox("No students in the list.")
        End If
    End Sub

End Class


'assignment to show students inserted 

'date can't be invalid

'restricting date of intaking'


''show coding'

'""