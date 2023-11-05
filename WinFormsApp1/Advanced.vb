Public Class Advanced
    Private Sub Advanced_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbdepartment.Enabled = False
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
    End Sub

    Private Sub CHKDepartment_CheckedChanged(sender As Object, e As EventArgs) Handles CHKDepartment.CheckedChanged
        If (CHKDepartment.Checked) Then
            cmbdepartment.Enabled = True
        Else
            cmbdepartment.Enabled = False
            cmbdepartment.ResetText()
            cmbdepartment.SelectedItem = Nothing

            ' If (ListBox1.Items.Equals(cmbdepartment.SelectedItem)) Then
            'ListBox1.Items.Clear()
            'End If
        End If

    End Sub

    Private Sub CHKGender_CheckedChanged(sender As Object, e As EventArgs) Handles CHKGender.CheckedChanged
        If (CHKGender.Checked) Then
            GroupBox1.Enabled = True
        Else
            GroupBox1.Enabled = False
        End If
    End Sub

    Private Sub CHKDivision_CheckedChanged(sender As Object, e As EventArgs) Handles CHKDivision.CheckedChanged
        If (CHKDivision.Checked) Then
            GroupBox2.Enabled = True
        Else
            GroupBox2.Enabled = False
        End If
    End Sub

    Private Sub cmbdepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdepartment.SelectedIndexChanged
        FilterStudents()
    End Sub

    Private Sub rdMale_CheckedChanged(sender As Object, e As EventArgs) Handles rdMale.CheckedChanged
        FilterStudents()
    End Sub

    Private Sub rdFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rdFemale.CheckedChanged
        FilterStudents()
    End Sub

    Private Sub rdRegular_CheckedChanged(sender As Object, e As EventArgs) Handles rdRegular.CheckedChanged
        FilterStudents()
    End Sub

    Private Sub rdExtension_CheckedChanged(sender As Object, e As EventArgs) Handles rdExtension.CheckedChanged
        FilterStudents()
    End Sub

    Private Sub FilterStudents()

        ListBox1.Items.Clear()

        For Each st As student In Module1.studentList

            If ((Not CHKDepartment.Checked OrElse (st.department IsNot Nothing AndAlso st.department = cmbdepartment.SelectedItem)) AndAlso
                (Not CHKGender.Checked OrElse (st.gender IsNot Nothing AndAlso st.gender = If(rdMale.Checked, "Male", "Female"))) AndAlso
                (Not CHKDivision.Checked OrElse (st.division IsNot Nothing AndAlso st.division = If(rdRegular.Checked, "Regular", "Extension")))) Then


                If st.name IsNot Nothing AndAlso st.department IsNot Nothing Then
                    ListBox1.Items.Add("Name: " & st.name & ".     | " & "Gender: " & st.gender & ".     | " & "Department: " & st.department & ".     | " & "Division: " & st.division)
                End If
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