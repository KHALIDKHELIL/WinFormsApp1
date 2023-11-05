<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Advanced
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        CHKDepartment = New CheckBox()
        CHKGender = New CheckBox()
        CHKDivision = New CheckBox()
        cmbdepartment = New ComboBox()
        GroupBox1 = New GroupBox()
        rdMale = New RadioButton()
        rdFemale = New RadioButton()
        GroupBox2 = New GroupBox()
        rdRegular = New RadioButton()
        rdExtension = New RadioButton()
        Label1 = New Label()
        ListBox1 = New ListBox()
        Button1 = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' CHKDepartment
        ' 
        CHKDepartment.AutoSize = True
        CHKDepartment.Location = New Point(327, 63)
        CHKDepartment.Name = "CHKDepartment"
        CHKDepartment.Size = New Size(131, 24)
        CHKDepartment.TabIndex = 0
        CHKDepartment.Text = "By Department"
        CHKDepartment.UseVisualStyleBackColor = True
        ' 
        ' CHKGender
        ' 
        CHKGender.AutoSize = True
        CHKGender.Location = New Point(327, 151)
        CHKGender.Name = "CHKGender"
        CHKGender.Size = New Size(99, 24)
        CHKGender.TabIndex = 1
        CHKGender.Text = "By Gender"
        CHKGender.UseVisualStyleBackColor = True
        ' 
        ' CHKDivision
        ' 
        CHKDivision.AutoSize = True
        CHKDivision.Location = New Point(327, 251)
        CHKDivision.Name = "CHKDivision"
        CHKDivision.Size = New Size(104, 24)
        CHKDivision.TabIndex = 2
        CHKDivision.Text = "By Division"
        CHKDivision.UseVisualStyleBackColor = True
        ' 
        ' cmbdepartment
        ' 
        cmbdepartment.FormattingEnabled = True
        cmbdepartment.Items.AddRange(New Object() {"ACCOUNTING", "BUSINESS MANAGEMENT", "COMPUTER SCIENCE", "COTM", "MARKETING MANAGEMENT", "PHARMACY"})
        cmbdepartment.Location = New Point(538, 63)
        cmbdepartment.Name = "cmbdepartment"
        cmbdepartment.Size = New Size(249, 28)
        cmbdepartment.TabIndex = 3
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rdMale)
        GroupBox1.Controls.Add(rdFemale)
        GroupBox1.Location = New Point(557, 131)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(181, 86)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Gender"
        ' 
        ' rdMale
        ' 
        rdMale.AutoSize = True
        rdMale.Location = New Point(17, 26)
        rdMale.Name = "rdMale"
        rdMale.Size = New Size(63, 24)
        rdMale.TabIndex = 1
        rdMale.TabStop = True
        rdMale.Text = "Male"
        rdMale.UseVisualStyleBackColor = True
        ' 
        ' rdFemale
        ' 
        rdFemale.AutoSize = True
        rdFemale.Location = New Point(17, 56)
        rdFemale.Name = "rdFemale"
        rdFemale.Size = New Size(78, 24)
        rdFemale.TabIndex = 0
        rdFemale.TabStop = True
        rdFemale.Text = "Female"
        rdFemale.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(rdRegular)
        GroupBox2.Controls.Add(rdExtension)
        GroupBox2.Location = New Point(557, 240)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(168, 78)
        GroupBox2.TabIndex = 5
        GroupBox2.TabStop = False
        GroupBox2.Text = "Division"
        ' 
        ' rdRegular
        ' 
        rdRegular.AutoSize = True
        rdRegular.Location = New Point(17, 26)
        rdRegular.Name = "rdRegular"
        rdRegular.Size = New Size(81, 24)
        rdRegular.TabIndex = 1
        rdRegular.TabStop = True
        rdRegular.Text = "Regular"
        rdRegular.UseVisualStyleBackColor = True
        ' 
        ' rdExtension
        ' 
        rdExtension.AutoSize = True
        rdExtension.Location = New Point(17, 56)
        rdExtension.Name = "rdExtension"
        rdExtension.Size = New Size(93, 24)
        rdExtension.TabIndex = 0
        rdExtension.TabStop = True
        rdExtension.Text = "Extension"
        rdExtension.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(538, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 20)
        Label1.TabIndex = 6
        Label1.Text = "Department"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 20
        ListBox1.Location = New Point(147, 349)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(872, 144)
        ListBox1.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(533, 520)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 8
        Button1.Text = "Exit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Advanced
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1179, 561)
        Controls.Add(Button1)
        Controls.Add(ListBox1)
        Controls.Add(Label1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(cmbdepartment)
        Controls.Add(CHKDivision)
        Controls.Add(CHKGender)
        Controls.Add(CHKDepartment)
        Name = "Advanced"
        Text = "Advanced"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CHKDepartment As CheckBox
    Friend WithEvents CHKGender As CheckBox
    Friend WithEvents CHKDivision As CheckBox
    Friend WithEvents cmbdepartment As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdMale As RadioButton
    Friend WithEvents rdFemale As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdRegular As RadioButton
    Friend WithEvents rdExtension As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
End Class
