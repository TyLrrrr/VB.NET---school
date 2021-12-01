Public Class FamilyForm
    'Set up the variables to be used in the functions
    Private intNumPhones As Integer
    Private decPhoneCost As Decimal
    Private decTax As Decimal
    Private decPhoneTotal As Decimal
    Private decOptionsCost As Decimal
    Private decPackage As Decimal
    Private decMonthly As Decimal
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'This will test the input entered to see if it is an int and above 1 phone, if true it will run all of the functions
        'if false it will display an error message
        Dim intNumPhones As Integer = 0
        If Integer.TryParse(txtNumPhones.Text, intNumPhones) And intNumPhones > 1 Then

            GetPhonePrice(g_decPH100, g_decPH110, g_decPH200)
            'Phone multiplier cost of phone times the amout of phones ordered
            decPhoneCost = decPhoneCost * intNumPhones
            GetPackagePrice(g_decPK800, g_decPK1500, g_decPKUnlimited)
            GetOptionsPrice(g_decOptionEmail, g_decOptionTextM)
            'Phone multiplier cost of options time the amount of phones ordered
            decOptionsCost = decOptionsCost * intNumPhones
            CalculateTax(decPhoneCost, g_decPhoneTax)
            CalculateTotal(decPhoneCost, decTax)
            CalculateMonthly(decPackage, decOptionsCost)

            lblSub.Text = decPhoneCost.ToString("c")
            lblTax.Text = decTax.ToString("c")
            lblTotal.Text = decPhoneTotal.ToString("c")
            lblOptions.Text = decOptionsCost.ToString("c")
            lblPackage.Text = decPackage.ToString("c")
            lblMonthly.Text = decMonthly.ToString("c")

        Else
            MessageBox.Show("Please enter a valid number of phones!")
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'This will close the form instance
        Me.Close()
    End Sub
    Function GetPhonePrice(ByVal g_decPH100 As Decimal,
                          ByVal g_decPH110 As Decimal,
                          ByVal g_decPH200 As Decimal) As Decimal
        'This functoin will get the cost of the phones
        If rad100.Checked = True Then
            decPhoneCost = g_decPH100
        End If
        If rad110.Checked = True Then
            decPhoneCost = g_decPH110
        End If
        If rad200.Checked = True Then
            decPhoneCost = g_decPH200
        End If

        Return decPhoneCost
    End Function

    Function GetPackagePrice(ByVal g_decPK800 As Decimal,
                             ByVal g_decPK1500 As Decimal,
                             ByVal g_decPKUnlimited As Decimal) As Decimal
        'This function will get the cost of the packages
        If rad800.Checked = True Then
            decPackage = g_decPK800
        End If
        If rad1500.Checked = True Then
            decPackage = g_decPK1500
        End If
        If radUnlimited.Checked = True Then
            decPackage = g_decPKUnlimited
        End If
        Return decPackage
    End Function

    Function GetOptionsPrice(ByVal g_decOptionEmail As Decimal,
                             ByVal g_decOptionTextM As Decimal) As Decimal
        'This function will get the total of the options wanted
        If chkEmail.Checked = True Then
            decOptionsCost += g_decOptionEmail
        End If
        If chkTextMessage.Checked = True Then
            decOptionsCost += g_decOptionTextM
        End If
        Return decOptionsCost
    End Function

    Function CalculateTax(ByVal decPhoneCost As Decimal,
                          ByVal g_decTax As Decimal) As Decimal
        'This function will get the cost of the taxes
        decTax = decPhoneCost * g_decTax
        Return decTax
    End Function

    Function CalculateTotal(ByVal decPhoneCost As Decimal,
                            ByVal decTax As Decimal) As Decimal
        'This function will get the total of the phones and taxes
        decPhoneTotal = decPhoneCost + decTax
        Return decPhoneTotal
    End Function

    Function CalculateMonthly(ByVal decPackage As Decimal,
                              ByVal decOptionCost As Decimal) As Decimal
        'This function will add the options and the package for a monthly charge
        decMonthly = decPackage + decOptionCost
        Return decMonthly
    End Function
End Class