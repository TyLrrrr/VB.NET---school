Public Class IndividualForm
    'Variables set up to be used in my functions
    Private decPhoneCost As Decimal
    Private decTax As Decimal
    Private decPhoneTotal As Decimal
    Private decOptionsCost As Decimal
    Private decPackage As Decimal
    Private decMonthly As Decimal
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'When the calculate button is pressed all functions will run
        GetPhonePrice(g_decPH100, g_decPH110, g_decPH200)
        GetPackagePrice(g_decPK800, g_decPK1500, g_decPKUnlimited)
        GetOptionsPrice(g_decOptionEmail, g_decOptionTextM)
        CalculateTax(decPhoneCost, g_decPhoneTax)
        CalculateTotal(decPhoneCost, decTax)
        CalculateMonthly(decPackage, decOptionsCost)
        'After the functions are ran output will be passed out to the correct labels
        lblSub.Text = decPhoneCost.ToString("c")
        lblTax.Text = decTax.ToString("c")
        lblTotal.Text = decPhoneTotal.ToString("c")
        lblOptions.Text = decOptionsCost.ToString("c")
        lblPackage.Text = decPackage.ToString("c")
        lblMonthly.Text = decMonthly.ToString("c")

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Closes the instance of this form
        Me.Close()
    End Sub

    Function GetPhonePrice(ByVal g_decPH100 As Decimal,
                           ByVal g_decPH110 As Decimal,
                           ByVal g_decPH200 As Decimal) As Decimal
        'this function will get the price of the phone
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
        'this function will get the price of the package
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
        'This function will get the price of the selected options
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
        'this function will calculate the tax off the phone cost
        decTax = decPhoneCost * g_decTax
        Return decTax
    End Function

    Function CalculateTotal(ByVal decPhoneCost As Decimal,
                            ByVal decTax As Decimal) As Decimal
        'This function will add the phone cost and tax together for a total cost
        decPhoneTotal = decPhoneCost + decTax
        Return decPhoneTotal
    End Function

    Function CalculateMonthly(ByVal decPackage As Decimal,
                              ByVal decOptionCost As Decimal) As Decimal
        'This function will add the options cost and package cost to get a monthly charge
        decMonthly = decPackage + decOptionCost
        Return decMonthly
    End Function

End Class