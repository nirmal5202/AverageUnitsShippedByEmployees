<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AverageWeeklyShippedByEmployees
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
        Me.components = New System.ComponentModel.Container()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.ttAverageWeeklyShippedByEmployees = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtUnitsInput = New System.Windows.Forms.TextBox()
        Me.lblEmployee1 = New System.Windows.Forms.Label()
        Me.txtEmployee1Output = New System.Windows.Forms.TextBox()
        Me.lblAvgAnsForEmp1 = New System.Windows.Forms.Label()
        Me.lblAvgAnsForEmp2 = New System.Windows.Forms.Label()
        Me.txtEmployee2Output = New System.Windows.Forms.TextBox()
        Me.lblEmployee2 = New System.Windows.Forms.Label()
        Me.lblAvgAnsForEmp3 = New System.Windows.Forms.Label()
        Me.txtEmployee3Output = New System.Windows.Forms.TextBox()
        Me.lblEmployee3 = New System.Windows.Forms.Label()
        Me.lblAvgPerEmp = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblDay
        '
        Me.lblDay.Location = New System.Drawing.Point(26, 20)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(98, 37)
        Me.lblDay.TabIndex = 0
        Me.lblDay.Text = "&Day 1"
        Me.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttAverageWeeklyShippedByEmployees.SetToolTip(Me.lblDay, "Day is displayed here")
        '
        'txtUnitsInput
        '
        Me.txtUnitsInput.Location = New System.Drawing.Point(159, 78)
        Me.txtUnitsInput.Name = "txtUnitsInput"
        Me.txtUnitsInput.Size = New System.Drawing.Size(140, 29)
        Me.txtUnitsInput.TabIndex = 2
        Me.txtUnitsInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ttAverageWeeklyShippedByEmployees.SetToolTip(Me.txtUnitsInput, "Enter Units Shipped here")
        '
        'lblEmployee1
        '
        Me.lblEmployee1.Location = New System.Drawing.Point(68, 131)
        Me.lblEmployee1.Name = "lblEmployee1"
        Me.lblEmployee1.Size = New System.Drawing.Size(192, 37)
        Me.lblEmployee1.TabIndex = 3
        Me.lblEmployee1.Text = "Employee &1"
        Me.lblEmployee1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttAverageWeeklyShippedByEmployees.SetToolTip(Me.lblEmployee1, "Field of Employee 1")
        '
        'txtEmployee1Output
        '
        Me.txtEmployee1Output.Location = New System.Drawing.Point(73, 180)
        Me.txtEmployee1Output.Multiline = True
        Me.txtEmployee1Output.Name = "txtEmployee1Output"
        Me.txtEmployee1Output.ReadOnly = True
        Me.txtEmployee1Output.Size = New System.Drawing.Size(187, 259)
        Me.txtEmployee1Output.TabIndex = 4
        Me.txtEmployee1Output.TabStop = False
        Me.txtEmployee1Output.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ttAverageWeeklyShippedByEmployees.SetToolTip(Me.txtEmployee1Output, "Output for Employee 1 will be displayed here.")
        '
        'lblAvgAnsForEmp1
        '
        Me.lblAvgAnsForEmp1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAvgAnsForEmp1.Location = New System.Drawing.Point(71, 446)
        Me.lblAvgAnsForEmp1.Name = "lblAvgAnsForEmp1"
        Me.lblAvgAnsForEmp1.Size = New System.Drawing.Size(192, 37)
        Me.lblAvgAnsForEmp1.TabIndex = 3
        Me.lblAvgAnsForEmp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttAverageWeeklyShippedByEmployees.SetToolTip(Me.lblAvgAnsForEmp1, "Displays average weekly items shipped by employee 1")
        '
        'lblAvgAnsForEmp2
        '
        Me.lblAvgAnsForEmp2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAvgAnsForEmp2.Location = New System.Drawing.Point(324, 446)
        Me.lblAvgAnsForEmp2.Name = "lblAvgAnsForEmp2"
        Me.lblAvgAnsForEmp2.Size = New System.Drawing.Size(192, 37)
        Me.lblAvgAnsForEmp2.TabIndex = 8
        Me.lblAvgAnsForEmp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttAverageWeeklyShippedByEmployees.SetToolTip(Me.lblAvgAnsForEmp2, "Displays average weekly items shipped by employee 2")
        '
        'txtEmployee2Output
        '
        Me.txtEmployee2Output.Location = New System.Drawing.Point(326, 180)
        Me.txtEmployee2Output.Multiline = True
        Me.txtEmployee2Output.Name = "txtEmployee2Output"
        Me.txtEmployee2Output.ReadOnly = True
        Me.txtEmployee2Output.Size = New System.Drawing.Size(187, 259)
        Me.txtEmployee2Output.TabIndex = 7
        Me.txtEmployee2Output.TabStop = False
        Me.txtEmployee2Output.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ttAverageWeeklyShippedByEmployees.SetToolTip(Me.txtEmployee2Output, "Output for Employee 2 will be displayed here.")
        '
        'lblEmployee2
        '
        Me.lblEmployee2.Location = New System.Drawing.Point(321, 131)
        Me.lblEmployee2.Name = "lblEmployee2"
        Me.lblEmployee2.Size = New System.Drawing.Size(192, 37)
        Me.lblEmployee2.TabIndex = 6
        Me.lblEmployee2.Text = "Employee &2"
        Me.lblEmployee2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttAverageWeeklyShippedByEmployees.SetToolTip(Me.lblEmployee2, "Field of Employee 2")
        '
        'lblAvgAnsForEmp3
        '
        Me.lblAvgAnsForEmp3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAvgAnsForEmp3.Location = New System.Drawing.Point(577, 446)
        Me.lblAvgAnsForEmp3.Name = "lblAvgAnsForEmp3"
        Me.lblAvgAnsForEmp3.Size = New System.Drawing.Size(192, 37)
        Me.lblAvgAnsForEmp3.TabIndex = 11
        Me.lblAvgAnsForEmp3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttAverageWeeklyShippedByEmployees.SetToolTip(Me.lblAvgAnsForEmp3, "Displays average weekly items shipped by employee 3")
        '
        'txtEmployee3Output
        '
        Me.txtEmployee3Output.Location = New System.Drawing.Point(579, 180)
        Me.txtEmployee3Output.Multiline = True
        Me.txtEmployee3Output.Name = "txtEmployee3Output"
        Me.txtEmployee3Output.ReadOnly = True
        Me.txtEmployee3Output.Size = New System.Drawing.Size(187, 259)
        Me.txtEmployee3Output.TabIndex = 10
        Me.txtEmployee3Output.TabStop = False
        Me.txtEmployee3Output.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ttAverageWeeklyShippedByEmployees.SetToolTip(Me.txtEmployee3Output, "Output for Employee 3 will be displayed here.")
        '
        'lblEmployee3
        '
        Me.lblEmployee3.Location = New System.Drawing.Point(574, 131)
        Me.lblEmployee3.Name = "lblEmployee3"
        Me.lblEmployee3.Size = New System.Drawing.Size(192, 37)
        Me.lblEmployee3.TabIndex = 9
        Me.lblEmployee3.Text = "Employee &3"
        Me.lblEmployee3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttAverageWeeklyShippedByEmployees.SetToolTip(Me.lblEmployee3, "Field of Employee 3")
        '
        'lblAvgPerEmp
        '
        Me.lblAvgPerEmp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAvgPerEmp.Location = New System.Drawing.Point(68, 503)
        Me.lblAvgPerEmp.Name = "lblAvgPerEmp"
        Me.lblAvgPerEmp.Size = New System.Drawing.Size(701, 49)
        Me.lblAvgPerEmp.TabIndex = 12
        Me.lblAvgPerEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttAverageWeeklyShippedByEmployees.SetToolTip(Me.lblAvgPerEmp, "Displays average weekly items shipped by ALL employees")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(68, 592)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(213, 55)
        Me.btnEnter.TabIndex = 13
        Me.btnEnter.Text = "&Enter"
        Me.ttAverageWeeklyShippedByEmployees.SetToolTip(Me.btnEnter, "Enter to Return")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(312, 592)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(213, 55)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "&Reset"
        Me.ttAverageWeeklyShippedByEmployees.SetToolTip(Me.btnReset, "Clear all data")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(558, 592)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(213, 55)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.ttAverageWeeklyShippedByEmployees.SetToolTip(Me.btnExit, "End the program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblUnits
        '
        Me.lblUnits.Location = New System.Drawing.Point(26, 73)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(98, 34)
        Me.lblUnits.TabIndex = 1
        Me.lblUnits.Text = "&Units:"
        Me.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AverageWeeklyShippedByEmployees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(850, 676)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblAvgPerEmp)
        Me.Controls.Add(Me.lblAvgAnsForEmp3)
        Me.Controls.Add(Me.txtEmployee3Output)
        Me.Controls.Add(Me.lblEmployee3)
        Me.Controls.Add(Me.lblAvgAnsForEmp2)
        Me.Controls.Add(Me.txtEmployee2Output)
        Me.Controls.Add(Me.lblEmployee2)
        Me.Controls.Add(Me.lblAvgAnsForEmp1)
        Me.Controls.Add(Me.txtEmployee1Output)
        Me.Controls.Add(Me.lblEmployee1)
        Me.Controls.Add(Me.txtUnitsInput)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.lblDay)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AverageWeeklyShippedByEmployees"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Weekly Shipped by Employees"
        Me.ttAverageWeeklyShippedByEmployees.SetToolTip(Me, "This form calculates the average weekly items shipped by 3 employees")
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDay As Label
    Friend WithEvents ttAverageWeeklyShippedByEmployees As ToolTip
    Friend WithEvents lblUnits As Label
    Friend WithEvents txtUnitsInput As TextBox
    Friend WithEvents lblEmployee1 As Label
    Friend WithEvents txtEmployee1Output As TextBox
    Friend WithEvents lblAvgAnsForEmp1 As Label
    Friend WithEvents lblAvgAnsForEmp2 As Label
    Friend WithEvents txtEmployee2Output As TextBox
    Friend WithEvents lblEmployee2 As Label
    Friend WithEvents lblAvgAnsForEmp3 As Label
    Friend WithEvents txtEmployee3Output As TextBox
    Friend WithEvents lblEmployee3 As Label
    Friend WithEvents lblAvgPerEmp As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
End Class
