Structure student
    Dim name As String
    Dim department As String
    Dim gender As String
    Dim DOB As Date
    Dim division As String
End Structure

Public Class Form1


    Dim st As student


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbdepartment.SelectedIndex = 0
        stDOB.MinDate = Now.AddYears(-30)
        stDOB.MaxDate = Now.AddYears(-20)
    End Sub

    Private Sub cmdInsert_Click(sender As Object, e As EventArgs) Handles cmdInsert.Click
        Dim currentYear As Integer = Now.Year
        Dim birthYear As Integer = stDOB.Value.Year

        If birthYear > 2005 Then
            MsgBox("Invalid Date of Birth. The year of birth cannot be greater than 2005.")
            Return
        End If

        st.name = txtName.Text
        st.department = cmbdepartment.SelectedItem
        st.DOB = stDOB.Value


        If (rdMale.Checked) Then
            st.gender = "Male"
        Else
            st.gender = "Female"
        End If

        If (st.name = "") Then
            MsgBox("please insert a name for the student")
            Return
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
        Listbox1.Items.Clear()

        Dim studentArray() As student = studentList
        For i As Integer = 0 To studentArray.Length - 1
            Dim st As student = studentArray(i)
            If Not String.IsNullOrEmpty(st.name) Then
                Listbox1.Items.Add("Name: " & st.name & ".      " & "Gender: " & st.gender & ".      " & "Department: " & st.department)
            End If
        Next




    End Sub






    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub







    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Application.Exit()
    End Sub




    Private Sub ByDepartmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ByDepartmentToolStripMenuItem.Click

        Dim form2 As New Form2("department")
        form2.Show()
    End Sub

    Private Sub ByGenderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ByGenderToolStripMenuItem.Click

        Dim form2 As New Form2("gender")
        form2.Show()
    End Sub

    Private Sub ByDivisionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ByDivisionToolStripMenuItem.Click
        Dim form2 As New Form2("division")
        form2.Show()
    End Sub

    Private Sub AdvancedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdvancedToolStripMenuItem.Click
        Advanced.Show()

    End Sub

End Class


'assignment to show students inserted 

'date can't be invalid

'restricting date of intaking'


''show coding'




'a-z only assignment'
'date to the future



'LIST SHOW TO CLEAR THE VALUES AND UPDATE THE VALUES'
'""