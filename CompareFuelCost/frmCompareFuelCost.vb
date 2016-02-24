' Program Name: Compare Fuel Cost
' Author:       Trevor Anthony Bowling
' Date:         March 13, 2014
' Purpose:      This Windows Application compares the cost of fuel
'               for an SUV with the cost of fuel for a Compact Car
'               over the life of the vehicles.

Option Strict On

Public Class frmCompareFuelCost

    Private Sub btnCompareLifeVehicleCost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompareLifeVehicleCost.Click
        ' This event handler allows the user to enter the fuel cost, miles traveled,
        ' years owned, SUV MPG and Compact Car MPG. It then calculates the SUV gas cost
        ' Compact Car gas cost, and the difference between the two.

        'Class variables

        Dim decCostPerGal As Decimal
        Dim decMilesTraveled As Decimal
        Dim intYearsOwned As Integer
        Dim decSUVMPG As Decimal
        Dim decCompactMPG As Decimal
        Dim decSUVCost As Decimal
        Dim decCompactCost As Decimal
        Dim decCostDifference As Decimal
        Dim intYears As Integer
        Dim blnCostPerGalValid As Boolean = False
        Dim blnMilesTraveledValid As Boolean = False
        Dim blnYearValid As Boolean = False
        Dim blnSUVMPGValid As Boolean = False
        Dim blnCompactMPGValid As Boolean = False
        Dim strSelectedYear As String = ""

        ' A function procedure is called to validate the cost per gallon
        blnCostPerGalValid = ValidateCostPerGal()
        ' A function procedure is called to validate the miles traveled
        blnMilesTraveledValid = ValidateMilesTraveled()
        ' A function procedure is called to validate the year selected
        intYears = ValidateYear(blnYearValid, strSelectedYear)
        ' A function procedure is called to validate the SUV mpg
        blnSUVMPGValid = ValidateSUVMPG()
        ' A function procedure is called to validate the Compact Car mpg
        blnCompactMPGValid = ValidateCompactMPG()

        decCostPerGal = Convert.ToDecimal(txtCostPerGal.Text)
        decMilesTraveled = Convert.ToDecimal(txtMilesTraveled.Text)
        intYearsOwned = Convert.ToInt32(cboYearsOwned.SelectedItem)
        decSUVMPG = Convert.ToDecimal(txtSUVMPG.Text)
        decCompactMPG = Convert.ToDecimal(txtCompactMPG.Text)

        ' Calculate the cost if valid
        If (blnCostPerGalValid And blnMilesTraveledValid And blnSUVMPGValid And blnCompactMPGValid) Then
            decSUVCost = ((decMilesTraveled / decSUVMPG) * decCostPerGal * intYears)
            decCompactCost = ((decMilesTraveled / decCompactMPG) * decCostPerGal * intYears)
            decCostDifference = decSUVCost - decCompactCost
        End If

        ' Display the Calculations

        lblSUVCost.Visible = True
        lblSUVCostNum.Visible = True
        lblSUVCostNum.Text = decSUVCost.ToString("C")
        lblCompactCost.Visible = True
        lblCompactCostNum.Visible = True
        lblCompactCostNum.Text = decCompactCost.ToString("C")
        lblCostDifference.Visible = True
        lblCostDifferenceNum.Visible = True
        lblCostDifferenceNum.Text = decCostDifference.ToString("C")

    End Sub


    Private Function ValidateCostPerGal() As Boolean

        ' This procedure validates the values entered for Fuel Cost Per Gallon

        Dim decCostPerGal As Decimal
        Dim blnValid As Boolean = False

        Try
            decCostPerGal = Convert.ToDecimal(txtCostPerGal.Text)
            If decCostPerGal > 0 Then
                blnValid = True
            Else
                MsgBox("Please enter a valid number for the Fuel Cost Per Gallon", , "Error")
                txtCostPerGal.Focus()
                txtCostPerGal.Clear()
            End If
        Catch exception As FormatException
            MsgBox("Please enter a valid number for the Fuel Cost Per Gallon", , "Error")
            txtCostPerGal.Focus()
            txtCostPerGal.Clear()
        Catch exception As OverflowException
            MsgBox("Please enter a valid number for the Fuel Cost Per Gallon", , "Error")
            txtCostPerGal.Focus()
            txtCostPerGal.Clear()
        Catch exception As SystemException
            MsgBox("Please enter a valid number for the Fuel Cost Per Gallon", , "Error")
            txtCostPerGal.Focus()
            txtCostPerGal.Clear()
        End Try

        Return blnValid

    End Function

    Private Function ValidateMilesTraveled() As Boolean

        ' This procedure validates the values entered for Miles Traveled

        Dim decMilesTraveled As Decimal
        Dim blnValid As Boolean = False

        Try
            decMilesTraveled = Convert.ToDecimal(txtMilesTraveled.Text)
            If decMilesTraveled > 0 Then
                blnValid = True
            Else
                MsgBox("Please enter a valid number for the Miles Traveled Per Year", , "Error")
                txtMilesTraveled.Clear()
                txtMilesTraveled.Focus()
            End If
        Catch Exception As FormatException
            MsgBox("Please enter a valid number for the Miles Traveled Per Year", , "Error")
            txtMilesTraveled.Clear()
            txtMilesTraveled.Focus()
        Catch exception As OverflowException
            MsgBox("Please enter a valid number for the Miles Traveled Per Year", , "Error")
            txtMilesTraveled.Clear()
            txtMilesTraveled.Focus()
        Catch exception As SystemException
            MsgBox("Please enter a valid number for the Miles Traveled Per Year", , "Error")
            txtMilesTraveled.Clear()
            txtMilesTraveled.Focus()
        End Try

        Return blnValid
    End Function

    Private Function ValidateYear(ByRef blnYear As Boolean, ByRef strYear As String) As Integer

        ' This procedure validates the value selected for Years of Vehicle Ownership

        Dim intYear As Integer

        Try
            intYear = Convert.ToInt32(cboYearsOwned.SelectedIndex)
            strYear = cboYearsOwned.SelectedItem.ToString()
            blnYear = True
        Catch exception As SystemException
            ' Checks if year is not selected
            MsgBox(" Please select Years of Ownership", , "Error")
            blnYear = False
        End Try

        Return intYear
    End Function

    Private Function ValidateSUVMPG() As Boolean

        ' This procedure validates the value entered in SUV MPG

        Dim decSUVMPG As Decimal
        Dim blnValid As Boolean = False

        Try
            decSUVMPG = Convert.ToDecimal(txtSUVMpg.Text)
            If decSUVMPG > 0 Then
                blnValid = True
            Else
                MsgBox("Please enter a valid number for the SUV MPG.", , "Error")
                txtSUVMpg.Clear()
                txtSUVMpg.Focus()
            End If
        Catch Exception As FormatException
            MsgBox("Please enter a valid number for the SUV MPG.", , "Error")
            txtSUVMpg.Clear()
            txtSUVMpg.Focus()
        Catch Exception As OverflowException
            MsgBox("Please enter a valid number for the SUV MPG.", , "Error")
            txtSUVMpg.Clear()
            txtSUVMpg.Focus()
        Catch Exception As SystemException
            MsgBox("Please enter a valid number for the SUV MPG.", , "Error")
            txtSUVMpg.Clear()
            txtSUVMpg.Focus()

        End Try

        Return blnValid

    End Function

    Private Function ValidateCompactMPG() As Boolean

        ' This procedure validates the values entered for Compact Car MPG

        Dim decCompactMPG As Decimal
        Dim blnValid As Boolean = False

        Try
            decCompactMPG = Convert.ToDecimal(txtCompactMPG.Text)
            If decCompactMPG > 0 Then
                blnValid = True
            Else
                MsgBox("Please enter a valid number for the Compact Car MPG.", , "Error")
                txtCompactMPG.Clear()
                txtCompactMPG.Focus()
            End If
        Catch Exception As FormatException
            MsgBox("Please enter a valid number for the Compact Car MPG.", , "Error")
            txtCompactMPG.Clear()
            txtCompactMPG.Focus()
        Catch exception As OverflowException
            MsgBox("Please enter a valid number for the Compact Car MPG.", , "Error")
            txtCompactMPG.Clear()
            txtCompactMPG.Focus()
        Catch exception As SystemException
            MsgBox("Please enter a valid number for the Compact Car MPG.", , "Error")
            txtCompactMPG.Clear()
            txtCompactMPG.Focus()
        End Try
        Return blnValid

    End Function

    Private Sub frmGasCost_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' This event handler hides the ten X's before the results are calculated

        lblSUVCostNum.Text = ""
        lblCompactCostNum.Text = ""
        lblCostDifferenceNum.Text = ""

    End Sub
    Private Sub frmCompareFuelCost_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' This event handler displays the splash screen fo five seconds before going to the form

        Threading.Thread.Sleep(5000)

    End Sub
End Class

