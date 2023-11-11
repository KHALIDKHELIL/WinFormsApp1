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
        components = New ComponentModel.Container()
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
        Listbox1 = New ListBox()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        MenuStrip1 = New MenuStrip()
        FilterToolStripMenuItem = New ToolStripMenuItem()
        ByDepartmentToolStripMenuItem = New ToolStripMenuItem()
        ByDivisionToolStripMenuItem = New ToolStripMenuItem()
        ByGenderToolStripMenuItem = New ToolStripMenuItem()
        AdvancedToolStripMenuItem = New ToolStripMenuItem()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        MenuStrip1.SuspendLayout()
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
        txtName.Text = "fdvdf"
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
        stDOB.MinDate = New Date(1930, 6, 10, 0, 0, 0, 0)
        stDOB.Name = "stDOB"
        stDOB.Size = New Size(250, 27)
        stDOB.TabIndex = 6
        stDOB.Value = New Date(2023, 12, 25, 23, 59, 59, 0)
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
        GroupBox1.Location = New Point(43, 265)
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
        GroupBox2.Location = New Point(275, 265)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(214, 96)
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
        ' Listbox1
        ' 
        Listbox1.FormattingEnabled = True
        Listbox1.ItemHeight = 20
        Listbox1.Location = New Point(670, 163)
        Listbox1.Name = "Listbox1"
        Listbox1.Size = New Size(608, 204)
        Listbox1.TabIndex = 15
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FilterToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1447, 28)
        MenuStrip1.TabIndex = 17
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FilterToolStripMenuItem
        ' 
        FilterToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ByDepartmentToolStripMenuItem, ByDivisionToolStripMenuItem, ByGenderToolStripMenuItem, AdvancedToolStripMenuItem})
        FilterToolStripMenuItem.Name = "FilterToolStripMenuItem"
        FilterToolStripMenuItem.Size = New Size(56, 24)
        FilterToolStripMenuItem.Text = "Filter"
        ' 
        ' ByDepartmentToolStripMenuItem
        ' 
        ByDepartmentToolStripMenuItem.Name = "ByDepartmentToolStripMenuItem"
        ByDepartmentToolStripMenuItem.Size = New Size(192, 26)
        ByDepartmentToolStripMenuItem.Text = "By Department"
        ' 
        ' ByDivisionToolStripMenuItem
        ' 
        ByDivisionToolStripMenuItem.Name = "ByDivisionToolStripMenuItem"
        ByDivisionToolStripMenuItem.Size = New Size(192, 26)
        ByDivisionToolStripMenuItem.Text = "By Division"
        ' 
        ' ByGenderToolStripMenuItem
        ' 
        ByGenderToolStripMenuItem.Name = "ByGenderToolStripMenuItem"
        ByGenderToolStripMenuItem.Size = New Size(192, 26)
        ByGenderToolStripMenuItem.Text = "By Gender"
        ' 
        ' AdvancedToolStripMenuItem
        ' 
        AdvancedToolStripMenuItem.Name = "AdvancedToolStripMenuItem"
        AdvancedToolStripMenuItem.Size = New Size(192, 26)
        AdvancedToolStripMenuItem.Text = "Advanced"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1447, 550)
        Controls.Add(MenuStrip1)
        Controls.Add(Listbox1)
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
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
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
    Friend WithEvents Listbox1 As ListBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FilterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ByDepartmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ByDivisionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ByGenderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdvancedToolStripMenuItem As ToolStripMenuItem
End Class
