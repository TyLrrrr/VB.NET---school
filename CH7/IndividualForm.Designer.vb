<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IndividualForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rad200 = New System.Windows.Forms.RadioButton()
        Me.rad110 = New System.Windows.Forms.RadioButton()
        Me.rad100 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radUnlimited = New System.Windows.Forms.RadioButton()
        Me.rad1500 = New System.Windows.Forms.RadioButton()
        Me.rad800 = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkTextMessage = New System.Windows.Forms.CheckBox()
        Me.chkEmail = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMonthly = New System.Windows.Forms.Label()
        Me.lblPackage = New System.Windows.Forms.Label()
        Me.lblOptions = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSub = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tyler Sather"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rad200)
        Me.GroupBox1.Controls.Add(Me.rad110)
        Me.GroupBox1.Controls.Add(Me.rad100)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(164, 155)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Phone"
        '
        'rad200
        '
        Me.rad200.AutoSize = True
        Me.rad200.Location = New System.Drawing.Point(6, 97)
        Me.rad200.Name = "rad200"
        Me.rad200.Size = New System.Drawing.Size(75, 17)
        Me.rad200.TabIndex = 2
        Me.rad200.TabStop = True
        Me.rad200.Text = "Model 200"
        Me.rad200.UseVisualStyleBackColor = True
        '
        'rad110
        '
        Me.rad110.AutoSize = True
        Me.rad110.Location = New System.Drawing.Point(6, 64)
        Me.rad110.Name = "rad110"
        Me.rad110.Size = New System.Drawing.Size(75, 17)
        Me.rad110.TabIndex = 1
        Me.rad110.TabStop = True
        Me.rad110.Text = "Model 110"
        Me.rad110.UseVisualStyleBackColor = True
        '
        'rad100
        '
        Me.rad100.AutoSize = True
        Me.rad100.Location = New System.Drawing.Point(6, 29)
        Me.rad100.Name = "rad100"
        Me.rad100.Size = New System.Drawing.Size(72, 17)
        Me.rad100.TabIndex = 0
        Me.rad100.TabStop = True
        Me.rad100.Text = "Model100"
        Me.rad100.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radUnlimited)
        Me.GroupBox2.Controls.Add(Me.rad1500)
        Me.GroupBox2.Controls.Add(Me.rad800)
        Me.GroupBox2.Location = New System.Drawing.Point(182, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(247, 155)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select a Package"
        '
        'radUnlimited
        '
        Me.radUnlimited.AutoSize = True
        Me.radUnlimited.Location = New System.Drawing.Point(6, 97)
        Me.radUnlimited.Name = "radUnlimited"
        Me.radUnlimited.Size = New System.Drawing.Size(159, 17)
        Me.radUnlimited.TabIndex = 2
        Me.radUnlimited.TabStop = True
        Me.radUnlimited.Text = "Unlimited Minutes per Month"
        Me.radUnlimited.UseVisualStyleBackColor = True
        '
        'rad1500
        '
        Me.rad1500.AutoSize = True
        Me.rad1500.Location = New System.Drawing.Point(6, 64)
        Me.rad1500.Name = "rad1500"
        Me.rad1500.Size = New System.Drawing.Size(140, 17)
        Me.rad1500.TabIndex = 1
        Me.rad1500.TabStop = True
        Me.rad1500.Text = "1500 Minutes per Month"
        Me.rad1500.UseVisualStyleBackColor = True
        '
        'rad800
        '
        Me.rad800.AutoSize = True
        Me.rad800.Location = New System.Drawing.Point(6, 29)
        Me.rad800.Name = "rad800"
        Me.rad800.Size = New System.Drawing.Size(134, 17)
        Me.rad800.TabIndex = 0
        Me.rad800.TabStop = True
        Me.rad800.Text = "800 Minutes per Month"
        Me.rad800.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkTextMessage)
        Me.GroupBox3.Controls.Add(Me.chkEmail)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 197)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(164, 103)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Select Options"
        '
        'chkTextMessage
        '
        Me.chkTextMessage.AutoSize = True
        Me.chkTextMessage.Location = New System.Drawing.Point(6, 62)
        Me.chkTextMessage.Name = "chkTextMessage"
        Me.chkTextMessage.Size = New System.Drawing.Size(101, 17)
        Me.chkTextMessage.TabIndex = 1
        Me.chkTextMessage.Text = "Text Messaging"
        Me.chkTextMessage.UseVisualStyleBackColor = True
        '
        'chkEmail
        '
        Me.chkEmail.AutoSize = True
        Me.chkEmail.Location = New System.Drawing.Point(6, 29)
        Me.chkEmail.Name = "chkEmail"
        Me.chkEmail.Size = New System.Drawing.Size(51, 17)
        Me.chkEmail.TabIndex = 0
        Me.chkEmail.Text = "Email"
        Me.chkEmail.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.lblMonthly)
        Me.GroupBox4.Controls.Add(Me.lblPackage)
        Me.GroupBox4.Controls.Add(Me.lblOptions)
        Me.GroupBox4.Controls.Add(Me.lblTotal)
        Me.GroupBox4.Controls.Add(Me.lblTax)
        Me.GroupBox4.Controls.Add(Me.lblSub)
        Me.GroupBox4.Location = New System.Drawing.Point(182, 197)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(247, 229)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Totals"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Total Monthly Charge"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Package Charge"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(82, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Options"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "PhoneTotal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(100, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Tax"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Phone Subtotal"
        '
        'lblMonthly
        '
        Me.lblMonthly.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMonthly.Location = New System.Drawing.Point(141, 186)
        Me.lblMonthly.Name = "lblMonthly"
        Me.lblMonthly.Size = New System.Drawing.Size(100, 28)
        Me.lblMonthly.TabIndex = 5
        Me.lblMonthly.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPackage
        '
        Me.lblPackage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPackage.Location = New System.Drawing.Point(141, 154)
        Me.lblPackage.Name = "lblPackage"
        Me.lblPackage.Size = New System.Drawing.Size(100, 28)
        Me.lblPackage.TabIndex = 4
        Me.lblPackage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOptions
        '
        Me.lblOptions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOptions.Location = New System.Drawing.Point(141, 121)
        Me.lblOptions.Name = "lblOptions"
        Me.lblOptions.Size = New System.Drawing.Size(100, 28)
        Me.lblOptions.TabIndex = 3
        Me.lblOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(141, 89)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 28)
        Me.lblTotal.TabIndex = 2
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(141, 57)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(100, 28)
        Me.lblTax.TabIndex = 1
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSub
        '
        Me.lblSub.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSub.Location = New System.Drawing.Point(141, 24)
        Me.lblSub.Name = "lblSub"
        Me.lblSub.Size = New System.Drawing.Size(100, 28)
        Me.lblSub.TabIndex = 0
        Me.lblSub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(12, 376)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(164, 50)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "C&lose"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(12, 311)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(164, 50)
        Me.btnCalc.TabIndex = 0
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'IndividualForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 443)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "IndividualForm"
        Me.Text = "Individual Plan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rad200 As RadioButton
    Friend WithEvents rad110 As RadioButton
    Friend WithEvents rad100 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radUnlimited As RadioButton
    Friend WithEvents rad1500 As RadioButton
    Friend WithEvents rad800 As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents chkTextMessage As CheckBox
    Friend WithEvents chkEmail As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblMonthly As Label
    Friend WithEvents lblPackage As Label
    Friend WithEvents lblOptions As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblSub As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnCalc As Button
End Class
