
Public Class Advanced



    Private Sub rdMale_CheckedChanged(sender As Object, e As EventArgs)
        filterStudents()
    End Sub

    Private Sub rdFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rdMale.CheckedChanged, rdFemale.CheckedChanged
        filterStudents()
    End Sub
    Private Sub rdRegular_CheckedChanged(sender As Object, e As EventArgs)
        filterStudents()
    End Sub
    Private Sub rdExtension_CheckedChanged(sender As Object, e As EventArgs) Handles rdRegular.CheckedChanged, rdExtension.CheckedChanged
        filterStudents()
    End Sub

    Private Sub cmbdepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdepartment.SelectedIndexChanged
        filterStudents()
    End Sub

    Private Sub Advanced_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbdepartment.Enabled = False
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        filterStudents()
    End Sub


    Private Sub CHKDepartment_CheckedChanged(sender As Object, e As EventArgs) Handles CHKDepartment.CheckedChanged
        If (CHKDepartment.Checked) Then
            cmbdepartment.Enabled = True
        Else
            cmbdepartment.Enabled = False
            cmbdepartment.SelectedItem = Nothing
        End If

        filterStudents()
    End Sub



    Private Sub CHKGender_CheckedChanged(sender As Object, e As EventArgs) Handles CHKGender.CheckedChanged
        If (CHKGender.Checked) Then
            GroupBox1.Enabled = True
        Else
            GroupBox1.Enabled = False
            rdFemale.Checked = False
            rdMale.Checked = False
        End If
        filterStudents()
    End Sub


    Private Sub CHKDivision_CheckedChanged(sender As Object, e As EventArgs) Handles CHKDivision.CheckedChanged
        If (CHKDivision.Checked) Then
            GroupBox2.Enabled = True
        Else
            GroupBox2.Enabled = False
            rdExtension.Checked = False
            rdRegular.Checked = False
        End If

        filterStudents()
    End Sub


    Private Sub filterStudents()
        Dim DEP As String = If(cmbdepartment.SelectedItem IsNot Nothing, cmbdepartment.SelectedItem.ToString(), "")
        Dim GEN As String = If(rdMale.Checked, "Male", If(rdFemale.Checked, "Female", ""))
        Dim DIVN As String = If(rdRegular.Checked, "Regular", If(rdExtension.Checked, "Extension", ""))


        If (String.IsNullOrWhiteSpace(DEP) And String.IsNullOrWhiteSpace(GEN) And String.IsNullOrWhiteSpace(DIVN)) Then
            ListBox1.Items.Clear()
            Return
        End If
        ListBox1.Items.Clear()


        For x = 0 To Module1.counter - 1


            If (String.IsNullOrEmpty(GEN) OrElse studentList(x).gender = GEN) AndAlso
               (String.IsNullOrEmpty(DIVN) OrElse studentList(x).division = DIVN) AndAlso
               (String.IsNullOrEmpty(DEP) OrElse studentList(x).department = DEP) Then
                ListBox1.Items.Add("Name: " & studentList(x).name & ".     | " & "Gender: " & studentList(x).gender & ".     | " & "Department: " & studentList(x).department & ".     | " & "Division: " & studentList(x).division)
            End If

        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class

'EVERYTHING MUST COME ONTO THE LISTBOX WHENEVER A FILTER METHOD IS CLICKED(the checkboxes)'
'MULTIPLE FILTERING AT THE SAME TIME'
'IF AGAIN AT SOME POINT THE CHECKBOXES ARE UNCHECKED IT MUST RESTORE THE FIRST VERSION OF THE LISTBOX LISTS'