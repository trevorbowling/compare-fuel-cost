<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompareFuelCost
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCompareLifeVehicleCost = New System.Windows.Forms.Button()
        Me.lblCostDifferenceNum = New System.Windows.Forms.Label()
        Me.lblCompactCostNum = New System.Windows.Forms.Label()
        Me.lblSUVCostNum = New System.Windows.Forms.Label()
        Me.cboYearsOwned = New System.Windows.Forms.ComboBox()
        Me.txtCompactMPG = New System.Windows.Forms.TextBox()
        Me.txtSUVMPG = New System.Windows.Forms.TextBox()
        Me.txtMilesTraveled = New System.Windows.Forms.TextBox()
        Me.txtCostPerGal = New System.Windows.Forms.TextBox()
        Me.lblCostDifference = New System.Windows.Forms.Label()
        Me.lblCompactCost = New System.Windows.Forms.Label()
        Me.lblSUVCost = New System.Windows.Forms.Label()
        Me.lblCompactMPG = New System.Windows.Forms.Label()
        Me.lblMilesTraveled = New System.Windows.Forms.Label()
        Me.lblYearsOwned = New System.Windows.Forms.Label()
        Me.lblSUVMPG = New System.Windows.Forms.Label()
        Me.lblCostPerGal = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnCompareLifeVehicleCost)
        Me.Panel1.Controls.Add(Me.lblCostDifferenceNum)
        Me.Panel1.Controls.Add(Me.lblCompactCostNum)
        Me.Panel1.Controls.Add(Me.lblSUVCostNum)
        Me.Panel1.Controls.Add(Me.cboYearsOwned)
        Me.Panel1.Controls.Add(Me.txtCompactMPG)
        Me.Panel1.Controls.Add(Me.txtSUVMPG)
        Me.Panel1.Controls.Add(Me.txtMilesTraveled)
        Me.Panel1.Controls.Add(Me.txtCostPerGal)
        Me.Panel1.Controls.Add(Me.lblCostDifference)
        Me.Panel1.Controls.Add(Me.lblCompactCost)
        Me.Panel1.Controls.Add(Me.lblSUVCost)
        Me.Panel1.Controls.Add(Me.lblCompactMPG)
        Me.Panel1.Controls.Add(Me.lblMilesTraveled)
        Me.Panel1.Controls.Add(Me.lblYearsOwned)
        Me.Panel1.Controls.Add(Me.lblSUVMPG)
        Me.Panel1.Controls.Add(Me.lblCostPerGal)
        Me.Panel1.Location = New System.Drawing.Point(242, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(317, 340)
        Me.Panel1.TabIndex = 0
        '
        'btnCompareLifeVehicleCost
        '
        Me.btnCompareLifeVehicleCost.BackColor = System.Drawing.Color.OrangeRed
        Me.btnCompareLifeVehicleCost.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompareLifeVehicleCost.ForeColor = System.Drawing.Color.White
        Me.btnCompareLifeVehicleCost.Location = New System.Drawing.Point(59, 174)
        Me.btnCompareLifeVehicleCost.Name = "btnCompareLifeVehicleCost"
        Me.btnCompareLifeVehicleCost.Size = New System.Drawing.Size(198, 33)
        Me.btnCompareLifeVehicleCost.TabIndex = 17
        Me.btnCompareLifeVehicleCost.Text = "Compare Life of Vehicle Cost"
        Me.btnCompareLifeVehicleCost.UseVisualStyleBackColor = False
        '
        'lblCostDifferenceNum
        '
        Me.lblCostDifferenceNum.AutoSize = True
        Me.lblCostDifferenceNum.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostDifferenceNum.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblCostDifferenceNum.Location = New System.Drawing.Point(166, 293)
        Me.lblCostDifferenceNum.Name = "lblCostDifferenceNum"
        Me.lblCostDifferenceNum.Size = New System.Drawing.Size(98, 16)
        Me.lblCostDifferenceNum.TabIndex = 16
        Me.lblCostDifferenceNum.Text = "XXXXXXXXXX"
        '
        'lblCompactCostNum
        '
        Me.lblCompactCostNum.AutoSize = True
        Me.lblCompactCostNum.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompactCostNum.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblCompactCostNum.Location = New System.Drawing.Point(166, 257)
        Me.lblCompactCostNum.Name = "lblCompactCostNum"
        Me.lblCompactCostNum.Size = New System.Drawing.Size(98, 16)
        Me.lblCompactCostNum.TabIndex = 15
        Me.lblCompactCostNum.Text = "XXXXXXXXXX"
        '
        'lblSUVCostNum
        '
        Me.lblSUVCostNum.AutoSize = True
        Me.lblSUVCostNum.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSUVCostNum.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblSUVCostNum.Location = New System.Drawing.Point(166, 221)
        Me.lblSUVCostNum.Name = "lblSUVCostNum"
        Me.lblSUVCostNum.Size = New System.Drawing.Size(98, 16)
        Me.lblSUVCostNum.TabIndex = 14
        Me.lblSUVCostNum.Text = "XXXXXXXXXX"
        '
        'cboYearsOwned
        '
        Me.cboYearsOwned.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYearsOwned.ForeColor = System.Drawing.Color.OrangeRed
        Me.cboYearsOwned.FormattingEnabled = True
        Me.cboYearsOwned.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cboYearsOwned.Location = New System.Drawing.Point(220, 78)
        Me.cboYearsOwned.Name = "cboYearsOwned"
        Me.cboYearsOwned.Size = New System.Drawing.Size(66, 24)
        Me.cboYearsOwned.TabIndex = 13
        '
        'txtCompactMPG
        '
        Me.txtCompactMPG.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompactMPG.ForeColor = System.Drawing.Color.OrangeRed
        Me.txtCompactMPG.Location = New System.Drawing.Point(220, 137)
        Me.txtCompactMPG.Name = "txtCompactMPG"
        Me.txtCompactMPG.Size = New System.Drawing.Size(66, 22)
        Me.txtCompactMPG.TabIndex = 12
        '
        'txtSUVMPG
        '
        Me.txtSUVMPG.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSUVMPG.ForeColor = System.Drawing.Color.OrangeRed
        Me.txtSUVMPG.Location = New System.Drawing.Point(220, 107)
        Me.txtSUVMPG.Name = "txtSUVMPG"
        Me.txtSUVMPG.Size = New System.Drawing.Size(66, 22)
        Me.txtSUVMPG.TabIndex = 11
        '
        'txtMilesTraveled
        '
        Me.txtMilesTraveled.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMilesTraveled.ForeColor = System.Drawing.Color.OrangeRed
        Me.txtMilesTraveled.Location = New System.Drawing.Point(220, 49)
        Me.txtMilesTraveled.Name = "txtMilesTraveled"
        Me.txtMilesTraveled.Size = New System.Drawing.Size(66, 22)
        Me.txtMilesTraveled.TabIndex = 9
        '
        'txtCostPerGal
        '
        Me.txtCostPerGal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostPerGal.ForeColor = System.Drawing.Color.OrangeRed
        Me.txtCostPerGal.Location = New System.Drawing.Point(220, 17)
        Me.txtCostPerGal.Name = "txtCostPerGal"
        Me.txtCostPerGal.Size = New System.Drawing.Size(66, 22)
        Me.txtCostPerGal.TabIndex = 8
        '
        'lblCostDifference
        '
        Me.lblCostDifference.AutoSize = True
        Me.lblCostDifference.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostDifference.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblCostDifference.Location = New System.Drawing.Point(31, 293)
        Me.lblCostDifference.Name = "lblCostDifference"
        Me.lblCostDifference.Size = New System.Drawing.Size(120, 16)
        Me.lblCostDifference.TabIndex = 7
        Me.lblCostDifference.Text = "Difference in Cost"
        '
        'lblCompactCost
        '
        Me.lblCompactCost.AutoSize = True
        Me.lblCompactCost.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompactCost.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblCompactCost.Location = New System.Drawing.Point(31, 257)
        Me.lblCompactCost.Name = "lblCompactCost"
        Me.lblCompactCost.Size = New System.Drawing.Size(123, 16)
        Me.lblCompactCost.TabIndex = 6
        Me.lblCompactCost.Text = "Compact Gas Cost"
        '
        'lblSUVCost
        '
        Me.lblSUVCost.AutoSize = True
        Me.lblSUVCost.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSUVCost.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblSUVCost.Location = New System.Drawing.Point(31, 221)
        Me.lblSUVCost.Name = "lblSUVCost"
        Me.lblSUVCost.Size = New System.Drawing.Size(94, 16)
        Me.lblSUVCost.TabIndex = 5
        Me.lblSUVCost.Text = "SUV Gas Cost"
        '
        'lblCompactMPG
        '
        Me.lblCompactMPG.AutoSize = True
        Me.lblCompactMPG.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompactMPG.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblCompactMPG.Location = New System.Drawing.Point(12, 143)
        Me.lblCompactMPG.Name = "lblCompactMPG"
        Me.lblCompactMPG.Size = New System.Drawing.Size(124, 16)
        Me.lblCompactMPG.TabIndex = 4
        Me.lblCompactMPG.Text = "Compact Car MPG"
        '
        'lblMilesTraveled
        '
        Me.lblMilesTraveled.AutoSize = True
        Me.lblMilesTraveled.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMilesTraveled.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblMilesTraveled.Location = New System.Drawing.Point(12, 53)
        Me.lblMilesTraveled.Name = "lblMilesTraveled"
        Me.lblMilesTraveled.Size = New System.Drawing.Size(158, 16)
        Me.lblMilesTraveled.TabIndex = 3
        Me.lblMilesTraveled.Text = "Miles Traveled Per Year"
        '
        'lblYearsOwned
        '
        Me.lblYearsOwned.AutoSize = True
        Me.lblYearsOwned.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearsOwned.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblYearsOwned.Location = New System.Drawing.Point(12, 83)
        Me.lblYearsOwned.Name = "lblYearsOwned"
        Me.lblYearsOwned.Size = New System.Drawing.Size(181, 16)
        Me.lblYearsOwned.TabIndex = 2
        Me.lblYearsOwned.Text = "Years of Vehicle Ownership"
        '
        'lblSUVMPG
        '
        Me.lblSUVMPG.AutoSize = True
        Me.lblSUVMPG.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSUVMPG.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblSUVMPG.Location = New System.Drawing.Point(12, 113)
        Me.lblSUVMPG.Name = "lblSUVMPG"
        Me.lblSUVMPG.Size = New System.Drawing.Size(69, 16)
        Me.lblSUVMPG.TabIndex = 1
        Me.lblSUVMPG.Text = "SUV MPG"
        '
        'lblCostPerGal
        '
        Me.lblCostPerGal.AutoSize = True
        Me.lblCostPerGal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostPerGal.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblCostPerGal.Location = New System.Drawing.Point(12, 23)
        Me.lblCostPerGal.Name = "lblCostPerGal"
        Me.lblCostPerGal.Size = New System.Drawing.Size(139, 16)
        Me.lblCostPerGal.TabIndex = 0
        Me.lblCostPerGal.Text = "Fuel Cost Per Gallon"
        '
        'frmCompareFuelCost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CompareFuelCost.My.Resources.Resources.gas_pump1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(558, 338)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCompareFuelCost"
        Me.Text = "Compare Gas Mileage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblCostDifferenceNum As System.Windows.Forms.Label
    Friend WithEvents lblCompactCostNum As System.Windows.Forms.Label
    Friend WithEvents lblSUVCostNum As System.Windows.Forms.Label
    Friend WithEvents cboYearsOwned As System.Windows.Forms.ComboBox
    Friend WithEvents txtCompactMPG As System.Windows.Forms.TextBox
    Friend WithEvents txtSUVMPG As System.Windows.Forms.TextBox
    Friend WithEvents txtMilesTraveled As System.Windows.Forms.TextBox
    Friend WithEvents txtCostPerGal As System.Windows.Forms.TextBox
    Friend WithEvents lblCostDifference As System.Windows.Forms.Label
    Friend WithEvents lblCompactCost As System.Windows.Forms.Label
    Friend WithEvents lblSUVCost As System.Windows.Forms.Label
    Friend WithEvents lblCompactMPG As System.Windows.Forms.Label
    Friend WithEvents lblMilesTraveled As System.Windows.Forms.Label
    Friend WithEvents lblYearsOwned As System.Windows.Forms.Label
    Friend WithEvents lblSUVMPG As System.Windows.Forms.Label
    Friend WithEvents lblCostPerGal As System.Windows.Forms.Label
    Friend WithEvents btnCompareLifeVehicleCost As System.Windows.Forms.Button

End Class
