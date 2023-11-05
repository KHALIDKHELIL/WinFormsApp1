Public Class Form2
    Private filterMethod As String

    Public Sub New(filter)

        InitializeComponent()
        filterMethod = filter


        Select Case filterMethod
            Case "department"
                ComboBox1.Items.AddRange(New String() {
                    "ACCOUNTING",
                    "BUSINESS MANAGEMENT",
                    "COMPUTER SCIENCE",
                    "COTM",
                    "MARKETING MANAGEMENT",
                    "PHARMACY"})
            Case "gender"
                ComboBox1.Items.AddRange(New String() {"Male", "Female"})
            Case "division"
                ComboBox1.Items.AddRange(New String() {"Regular", "Extension"})
        End Select
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ListBox1.Items.Clear()
        For Each st As student In Module1.studentList
            If Not String.IsNullOrEmpty(st.name) Then
                Select Case filterMethod
                    Case "department"
                        If st.department = ComboBox1.SelectedItem.ToString() Then
                            ListBox1.Items.Add("Name: " & st.name & ".      " & "Gender: " & st.gender & ".      " & "Department: " & st.department & "Division: " & st.division)
                        End If
                    Case "gender"
                        If st.gender = ComboBox1.SelectedItem.ToString() Then
                            ListBox1.Items.Add("Name: " & st.name & ".      " & "Gender: " & st.gender & ".      " & "Department: " & st.department & "Division: " & st.division)
                        End If
                    Case "division"
                        If st.division = ComboBox1.SelectedItem.ToString() Then
                            ListBox1.Items.Add("Name: " & st.name & ".      " & "Gender: " & st.gender & ".      " & "Department: " & st.department & "Division: " & st.division)
                        End If
                End Select
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
