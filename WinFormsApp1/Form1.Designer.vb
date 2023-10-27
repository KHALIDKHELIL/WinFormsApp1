<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtName = New TextBox()
        Label2 = New Label()
        stDOB = New DateTimePicker()
        Label3 = New Label()
        GroupBox1 = New GroupBox()
        rdFemale = New RadioButton()
        rdMale = New RadioButton()
        GroupBox2 = New GroupBox()
        rdExtension = New RadioButton()
        rdRegular = New RadioButton()
        cmdInsert = New Button()
        cmdShow = New Button()
        cmdExit = New Button()
        cmbdepartment = New ComboBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(43, 81)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 20)
        Label1.TabIndex = 2
        Label1.Text = "Name :"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(116, 78)
        txtName.Name = "txtName"
        txtName.Size = New Size(302, 27)
        txtName.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(558, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 20)
        Label2.TabIndex = 4
        Label2.Text = "Department :"
        ' 
        ' stDOB
        ' 
        stDOB.Location = New Point(135, 158)
        stDOB.Name = "stDOB"
        stDOB.Size = New Size(250, 27)
        stDOB.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(43, 163)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 20)
        Label3.TabIndex = 7
        Label3.Text = "Birth Date :"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rdFemale)
        GroupBox1.Controls.Add(rdMale)
        GroupBox1.Location = New Point(116, 256)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(190, 96)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "Gender"
        ' 
        ' rdFemale
        ' 
        rdFemale.AutoSize = True
        rdFemale.Location = New Point(3, 53)
        rdFemale.Name = "rdFemale"
        rdFemale.Size = New Size(78, 24)
        rdFemale.TabIndex = 1
        rdFemale.Text = "Female"
        rdFemale.UseVisualStyleBackColor = True
        ' 
        ' rdMale
        ' 
        rdMale.AutoSize = True
        rdMale.Checked = True
        rdMale.Location = New Point(3, 23)
        rdMale.Name = "rdMale"
        rdMale.Size = New Size(63, 24)
        rdMale.TabIndex = 0
        rdMale.TabStop = True
        rdMale.Text = "Male"
        rdMale.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.ButtonFace
        GroupBox2.Controls.Add(rdExtension)
        GroupBox2.Controls.Add(rdRegular)
        GroupBox2.ForeColor = SystemColors.ActiveCaptionText
        GroupBox2.Location = New Point(524, 265)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(212, 87)
        GroupBox2.TabIndex = 10
        GroupBox2.TabStop = False
        GroupBox2.Text = "Division"
        ' 
        ' rdExtension
        ' 
        rdExtension.AutoSize = True
        rdExtension.Location = New Point(6, 56)
        rdExtension.Name = "rdExtension"
        rdExtension.Size = New Size(93, 24)
        rdExtension.TabIndex = 1
        rdExtension.Text = "Extension"
        rdExtension.UseVisualStyleBackColor = True
        ' 
        ' rdRegular
        ' 
        rdRegular.AutoSize = True
        rdRegular.Checked = True
        rdRegular.Location = New Point(6, 26)
        rdRegular.Name = "rdRegular"
        rdRegular.Size = New Size(81, 24)
        rdRegular.TabIndex = 0
        rdRegular.TabStop = True
        rdRegular.Text = "Regular"
        rdRegular.UseVisualStyleBackColor = True
        ' 
        ' cmdInsert
        ' 
        cmdInsert.BackgroundImageLayout = ImageLayout.Center
        cmdInsert.Location = New Point(300, 456)
        cmdInsert.Name = "cmdInsert"
        cmdInsert.Size = New Size(94, 29)
        cmdInsert.TabIndex = 11
        cmdInsert.Text = "Insert"
        cmdInsert.UseVisualStyleBackColor = True
        ' 
        ' cmdShow
        ' 
        cmdShow.Location = New Point(560, 456)
        cmdShow.Name = "cmdShow"
        cmdShow.Size = New Size(94, 29)
        cmdShow.TabIndex = 12
        cmdShow.Text = "Show"
        cmdShow.UseVisualStyleBackColor = True
        ' 
        ' cmdExit
        ' 
        cmdExit.Location = New Point(810, 453)
        cmdExit.Name = "cmdExit"
        cmdExit.Size = New Size(94, 32)
        cmdExit.TabIndex = 13
        cmdExit.Text = "Exit"
        cmdExit.UseVisualStyleBackColor = True
        ' 
        ' cmbdepartment
        ' 
        cmbdepartment.FormattingEnabled = True
        cmbdepartment.Items.AddRange(New Object() {"ACCOUNTING", "BUSINESS MANAGEMENT", "COMPUTER SCIENCE", "COTM", "MARKETING MANAGEMENT", "PHARMACY"})
        cmbdepartment.Location = New Point(670, 84)
        cmbdepartment.Name = "cmbdepartment"
        cmbdepartment.Size = New Size(304, 28)
        cmbdepartment.Sorted = True
        cmbdepartment.TabIndex = 14
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1205, 550)
        Controls.Add(cmbdepartment)
        Controls.Add(cmdExit)
        Controls.Add(cmdShow)
        Controls.Add(cmdInsert)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label3)
        Controls.Add(stDOB)
        Controls.Add(Label2)
        Controls.Add(txtName)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Application"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents stDOB As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdFemale As RadioButton
    Friend WithEvents rdMale As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdRegular As RadioButton
    Friend WithEvents rdExtension As RadioButton
    Friend WithEvents cmdInsert As Button
    Friend WithEvents cmdShow As Button
    Friend WithEvents cmdExit As Button
    Friend WithEvents cmbdepartment As ComboBox
End Class
