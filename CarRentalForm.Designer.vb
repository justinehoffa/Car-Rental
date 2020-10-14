<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarRentalForm
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
        Me.CustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.ZipCodeTextBox = New System.Windows.Forms.TextBox()
        Me.BeginningOdometerReadingTextBox = New System.Windows.Forms.TextBox()
        Me.EndingOdometerReadingTextBox = New System.Windows.Forms.TextBox()
        Me.NumberOfDaysTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerNameLabel = New System.Windows.Forms.Label()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.ZipCodeLabel = New System.Windows.Forms.Label()
        Me.BeginningOdometerReadingLabel = New System.Windows.Forms.Label()
        Me.EndingOdometerReadingLabel = New System.Windows.Forms.Label()
        Me.NumberOfDaysLabel = New System.Windows.Forms.Label()
        Me.OdometerGroupBox = New System.Windows.Forms.GroupBox()
        Me.DiscountsGroupBox = New System.Windows.Forms.GroupBox()
        Me.MilesRadioButton = New System.Windows.Forms.RadioButton()
        Me.KilometersRadioButton = New System.Windows.Forms.RadioButton()
        Me.AAAMemberDiscountCheckBox = New System.Windows.Forms.CheckBox()
        Me.SeniorCitizenDiscountCheckBox = New System.Windows.Forms.CheckBox()
        Me.DistanceTraveledinMilesTextBox = New System.Windows.Forms.TextBox()
        Me.MileageChargeTextBox = New System.Windows.Forms.TextBox()
        Me.DayChargeTextBox = New System.Windows.Forms.TextBox()
        Me.MinusDiscount = New System.Windows.Forms.TextBox()
        Me.AmountOwedTextBox = New System.Windows.Forms.TextBox()
        Me.DistanceTraveledinMilesLabel = New System.Windows.Forms.Label()
        Me.MileageChargeLabel = New System.Windows.Forms.Label()
        Me.DayChargeLabel = New System.Windows.Forms.Label()
        Me.MinusDiscountLabel = New System.Windows.Forms.Label()
        Me.AmountOwedLabel = New System.Windows.Forms.Label()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.OdometerGroupBox.SuspendLayout()
        Me.DiscountsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'CustomerNameTextBox
        '
        Me.CustomerNameTextBox.Location = New System.Drawing.Point(349, 26)
        Me.CustomerNameTextBox.Name = "CustomerNameTextBox"
        Me.CustomerNameTextBox.Size = New System.Drawing.Size(310, 31)
        Me.CustomerNameTextBox.TabIndex = 0
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(349, 81)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(310, 31)
        Me.AddressTextBox.TabIndex = 1
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(349, 140)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(310, 31)
        Me.CityTextBox.TabIndex = 2
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(349, 193)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(310, 31)
        Me.StateTextBox.TabIndex = 3
        '
        'ZipCodeTextBox
        '
        Me.ZipCodeTextBox.Location = New System.Drawing.Point(349, 251)
        Me.ZipCodeTextBox.Name = "ZipCodeTextBox"
        Me.ZipCodeTextBox.Size = New System.Drawing.Size(310, 31)
        Me.ZipCodeTextBox.TabIndex = 4
        '
        'BeginningOdometerReadingTextBox
        '
        Me.BeginningOdometerReadingTextBox.Location = New System.Drawing.Point(349, 309)
        Me.BeginningOdometerReadingTextBox.Name = "BeginningOdometerReadingTextBox"
        Me.BeginningOdometerReadingTextBox.Size = New System.Drawing.Size(310, 31)
        Me.BeginningOdometerReadingTextBox.TabIndex = 5
        '
        'EndingOdometerReadingTextBox
        '
        Me.EndingOdometerReadingTextBox.Location = New System.Drawing.Point(349, 365)
        Me.EndingOdometerReadingTextBox.Name = "EndingOdometerReadingTextBox"
        Me.EndingOdometerReadingTextBox.Size = New System.Drawing.Size(310, 31)
        Me.EndingOdometerReadingTextBox.TabIndex = 6
        '
        'NumberOfDaysTextBox
        '
        Me.NumberOfDaysTextBox.Location = New System.Drawing.Point(349, 420)
        Me.NumberOfDaysTextBox.Name = "NumberOfDaysTextBox"
        Me.NumberOfDaysTextBox.Size = New System.Drawing.Size(310, 31)
        Me.NumberOfDaysTextBox.TabIndex = 7
        '
        'CustomerNameLabel
        '
        Me.CustomerNameLabel.AutoSize = True
        Me.CustomerNameLabel.Location = New System.Drawing.Point(31, 29)
        Me.CustomerNameLabel.Name = "CustomerNameLabel"
        Me.CustomerNameLabel.Size = New System.Drawing.Size(166, 25)
        Me.CustomerNameLabel.TabIndex = 8
        Me.CustomerNameLabel.Text = "Customer Name"
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Location = New System.Drawing.Point(22, 84)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(91, 25)
        Me.AddressLabel.TabIndex = 9
        Me.AddressLabel.Text = "Address"
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Location = New System.Drawing.Point(22, 143)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(49, 25)
        Me.CityLabel.TabIndex = 10
        Me.CityLabel.Text = "City"
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Location = New System.Drawing.Point(22, 196)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(62, 25)
        Me.StateLabel.TabIndex = 11
        Me.StateLabel.Text = "State"
        '
        'ZipCodeLabel
        '
        Me.ZipCodeLabel.AutoSize = True
        Me.ZipCodeLabel.Location = New System.Drawing.Point(22, 254)
        Me.ZipCodeLabel.Name = "ZipCodeLabel"
        Me.ZipCodeLabel.Size = New System.Drawing.Size(99, 25)
        Me.ZipCodeLabel.TabIndex = 12
        Me.ZipCodeLabel.Text = "Zip Code"
        '
        'BeginningOdometerReadingLabel
        '
        Me.BeginningOdometerReadingLabel.AutoSize = True
        Me.BeginningOdometerReadingLabel.Location = New System.Drawing.Point(22, 312)
        Me.BeginningOdometerReadingLabel.Name = "BeginningOdometerReadingLabel"
        Me.BeginningOdometerReadingLabel.Size = New System.Drawing.Size(294, 25)
        Me.BeginningOdometerReadingLabel.TabIndex = 13
        Me.BeginningOdometerReadingLabel.Text = "Beginning Odometer Reading"
        '
        'EndingOdometerReadingLabel
        '
        Me.EndingOdometerReadingLabel.AutoSize = True
        Me.EndingOdometerReadingLabel.Location = New System.Drawing.Point(22, 368)
        Me.EndingOdometerReadingLabel.Name = "EndingOdometerReadingLabel"
        Me.EndingOdometerReadingLabel.Size = New System.Drawing.Size(265, 25)
        Me.EndingOdometerReadingLabel.TabIndex = 14
        Me.EndingOdometerReadingLabel.Text = "Ending Odometer Reading"
        '
        'NumberOfDaysLabel
        '
        Me.NumberOfDaysLabel.AutoSize = True
        Me.NumberOfDaysLabel.Location = New System.Drawing.Point(22, 423)
        Me.NumberOfDaysLabel.Name = "NumberOfDaysLabel"
        Me.NumberOfDaysLabel.Size = New System.Drawing.Size(166, 25)
        Me.NumberOfDaysLabel.TabIndex = 15
        Me.NumberOfDaysLabel.Text = "Number of Days"
        '
        'OdometerGroupBox
        '
        Me.OdometerGroupBox.Controls.Add(Me.KilometersRadioButton)
        Me.OdometerGroupBox.Controls.Add(Me.MilesRadioButton)
        Me.OdometerGroupBox.Location = New System.Drawing.Point(132, 530)
        Me.OdometerGroupBox.Name = "OdometerGroupBox"
        Me.OdometerGroupBox.Size = New System.Drawing.Size(435, 245)
        Me.OdometerGroupBox.TabIndex = 16
        Me.OdometerGroupBox.TabStop = False
        Me.OdometerGroupBox.Text = "Is Odometer in Miles or Kilometers?"
        '
        'DiscountsGroupBox
        '
        Me.DiscountsGroupBox.Controls.Add(Me.SeniorCitizenDiscountCheckBox)
        Me.DiscountsGroupBox.Controls.Add(Me.AAAMemberDiscountCheckBox)
        Me.DiscountsGroupBox.Location = New System.Drawing.Point(632, 530)
        Me.DiscountsGroupBox.Name = "DiscountsGroupBox"
        Me.DiscountsGroupBox.Size = New System.Drawing.Size(435, 246)
        Me.DiscountsGroupBox.TabIndex = 17
        Me.DiscountsGroupBox.TabStop = False
        Me.DiscountsGroupBox.Text = "Enter any Discounts"
        '
        'MilesRadioButton
        '
        Me.MilesRadioButton.AutoSize = True
        Me.MilesRadioButton.Location = New System.Drawing.Point(100, 62)
        Me.MilesRadioButton.Name = "MilesRadioButton"
        Me.MilesRadioButton.Size = New System.Drawing.Size(94, 29)
        Me.MilesRadioButton.TabIndex = 0
        Me.MilesRadioButton.TabStop = True
        Me.MilesRadioButton.Text = "Miles"
        Me.MilesRadioButton.UseVisualStyleBackColor = True
        '
        'KilometersRadioButton
        '
        Me.KilometersRadioButton.AutoSize = True
        Me.KilometersRadioButton.Location = New System.Drawing.Point(100, 144)
        Me.KilometersRadioButton.Name = "KilometersRadioButton"
        Me.KilometersRadioButton.Size = New System.Drawing.Size(144, 29)
        Me.KilometersRadioButton.TabIndex = 1
        Me.KilometersRadioButton.TabStop = True
        Me.KilometersRadioButton.Text = "Kilometers"
        Me.KilometersRadioButton.UseVisualStyleBackColor = True
        '
        'AAAMemberDiscountCheckBox
        '
        Me.AAAMemberDiscountCheckBox.AutoSize = True
        Me.AAAMemberDiscountCheckBox.Location = New System.Drawing.Point(117, 63)
        Me.AAAMemberDiscountCheckBox.Name = "AAAMemberDiscountCheckBox"
        Me.AAAMemberDiscountCheckBox.Size = New System.Drawing.Size(260, 29)
        Me.AAAMemberDiscountCheckBox.TabIndex = 2
        Me.AAAMemberDiscountCheckBox.Text = "AAA Member Discount"
        Me.AAAMemberDiscountCheckBox.UseVisualStyleBackColor = True
        '
        'SeniorCitizenDiscountCheckBox
        '
        Me.SeniorCitizenDiscountCheckBox.AutoSize = True
        Me.SeniorCitizenDiscountCheckBox.Location = New System.Drawing.Point(117, 144)
        Me.SeniorCitizenDiscountCheckBox.Name = "SeniorCitizenDiscountCheckBox"
        Me.SeniorCitizenDiscountCheckBox.Size = New System.Drawing.Size(268, 29)
        Me.SeniorCitizenDiscountCheckBox.TabIndex = 3
        Me.SeniorCitizenDiscountCheckBox.Text = "Senior Citizen Discount"
        Me.SeniorCitizenDiscountCheckBox.UseVisualStyleBackColor = True
        '
        'DistanceTraveledinMilesTextBox
        '
        Me.DistanceTraveledinMilesTextBox.Location = New System.Drawing.Point(1109, 26)
        Me.DistanceTraveledinMilesTextBox.Name = "DistanceTraveledinMilesTextBox"
        Me.DistanceTraveledinMilesTextBox.Size = New System.Drawing.Size(310, 31)
        Me.DistanceTraveledinMilesTextBox.TabIndex = 18
        '
        'MileageChargeTextBox
        '
        Me.MileageChargeTextBox.Location = New System.Drawing.Point(1109, 81)
        Me.MileageChargeTextBox.Name = "MileageChargeTextBox"
        Me.MileageChargeTextBox.Size = New System.Drawing.Size(310, 31)
        Me.MileageChargeTextBox.TabIndex = 19
        '
        'DayChargeTextBox
        '
        Me.DayChargeTextBox.Location = New System.Drawing.Point(1109, 140)
        Me.DayChargeTextBox.Name = "DayChargeTextBox"
        Me.DayChargeTextBox.Size = New System.Drawing.Size(310, 31)
        Me.DayChargeTextBox.TabIndex = 20
        '
        'MinusDiscount
        '
        Me.MinusDiscount.Location = New System.Drawing.Point(1109, 193)
        Me.MinusDiscount.Name = "MinusDiscount"
        Me.MinusDiscount.Size = New System.Drawing.Size(310, 31)
        Me.MinusDiscount.TabIndex = 21
        '
        'AmountOwedTextBox
        '
        Me.AmountOwedTextBox.Location = New System.Drawing.Point(1109, 251)
        Me.AmountOwedTextBox.Name = "AmountOwedTextBox"
        Me.AmountOwedTextBox.Size = New System.Drawing.Size(310, 31)
        Me.AmountOwedTextBox.TabIndex = 22
        '
        'DistanceTraveledinMilesLabel
        '
        Me.DistanceTraveledinMilesLabel.AutoSize = True
        Me.DistanceTraveledinMilesLabel.Location = New System.Drawing.Point(785, 32)
        Me.DistanceTraveledinMilesLabel.Name = "DistanceTraveledinMilesLabel"
        Me.DistanceTraveledinMilesLabel.Size = New System.Drawing.Size(266, 25)
        Me.DistanceTraveledinMilesLabel.TabIndex = 23
        Me.DistanceTraveledinMilesLabel.Text = "Distance Traveled in Miles"
        '
        'MileageChargeLabel
        '
        Me.MileageChargeLabel.AutoSize = True
        Me.MileageChargeLabel.Location = New System.Drawing.Point(870, 84)
        Me.MileageChargeLabel.Name = "MileageChargeLabel"
        Me.MileageChargeLabel.Size = New System.Drawing.Size(164, 25)
        Me.MileageChargeLabel.TabIndex = 24
        Me.MileageChargeLabel.Text = "Mileage Charge"
        '
        'DayChargeLabel
        '
        Me.DayChargeLabel.AutoSize = True
        Me.DayChargeLabel.Location = New System.Drawing.Point(870, 146)
        Me.DayChargeLabel.Name = "DayChargeLabel"
        Me.DayChargeLabel.Size = New System.Drawing.Size(126, 25)
        Me.DayChargeLabel.TabIndex = 25
        Me.DayChargeLabel.Text = "Day Charge"
        '
        'MinusDiscountLabel
        '
        Me.MinusDiscountLabel.AutoSize = True
        Me.MinusDiscountLabel.Location = New System.Drawing.Point(870, 199)
        Me.MinusDiscountLabel.Name = "MinusDiscountLabel"
        Me.MinusDiscountLabel.Size = New System.Drawing.Size(160, 25)
        Me.MinusDiscountLabel.TabIndex = 26
        Me.MinusDiscountLabel.Text = "Minus Discount"
        '
        'AmountOwedLabel
        '
        Me.AmountOwedLabel.AutoSize = True
        Me.AmountOwedLabel.Location = New System.Drawing.Point(870, 257)
        Me.AmountOwedLabel.Name = "AmountOwedLabel"
        Me.AmountOwedLabel.Size = New System.Drawing.Size(146, 25)
        Me.AmountOwedLabel.TabIndex = 27
        Me.AmountOwedLabel.Text = "Amount Owed"
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(132, 801)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(199, 94)
        Me.CalculateButton.TabIndex = 28
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(384, 801)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(199, 94)
        Me.ClearButton.TabIndex = 29
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SummaryButton
        '
        Me.SummaryButton.Location = New System.Drawing.Point(641, 801)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(199, 94)
        Me.SummaryButton.TabIndex = 30
        Me.SummaryButton.Text = "Summary"
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(899, 801)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(199, 94)
        Me.ExitButton.TabIndex = 31
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'CarRentalForm
        '
        Me.AcceptButton = Me.CalculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(1450, 922)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SummaryButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.AmountOwedLabel)
        Me.Controls.Add(Me.MinusDiscountLabel)
        Me.Controls.Add(Me.DayChargeLabel)
        Me.Controls.Add(Me.MileageChargeLabel)
        Me.Controls.Add(Me.DistanceTraveledinMilesLabel)
        Me.Controls.Add(Me.AmountOwedTextBox)
        Me.Controls.Add(Me.MinusDiscount)
        Me.Controls.Add(Me.DayChargeTextBox)
        Me.Controls.Add(Me.MileageChargeTextBox)
        Me.Controls.Add(Me.DistanceTraveledinMilesTextBox)
        Me.Controls.Add(Me.DiscountsGroupBox)
        Me.Controls.Add(Me.OdometerGroupBox)
        Me.Controls.Add(Me.NumberOfDaysLabel)
        Me.Controls.Add(Me.EndingOdometerReadingLabel)
        Me.Controls.Add(Me.BeginningOdometerReadingLabel)
        Me.Controls.Add(Me.ZipCodeLabel)
        Me.Controls.Add(Me.StateLabel)
        Me.Controls.Add(Me.CityLabel)
        Me.Controls.Add(Me.AddressLabel)
        Me.Controls.Add(Me.CustomerNameLabel)
        Me.Controls.Add(Me.NumberOfDaysTextBox)
        Me.Controls.Add(Me.EndingOdometerReadingTextBox)
        Me.Controls.Add(Me.BeginningOdometerReadingTextBox)
        Me.Controls.Add(Me.ZipCodeTextBox)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.CustomerNameTextBox)
        Me.Name = "CarRentalForm"
        Me.Text = "Acme Car Rental Service"
        Me.OdometerGroupBox.ResumeLayout(False)
        Me.OdometerGroupBox.PerformLayout()
        Me.DiscountsGroupBox.ResumeLayout(False)
        Me.DiscountsGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CustomerNameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents ZipCodeTextBox As TextBox
    Friend WithEvents BeginningOdometerReadingTextBox As TextBox
    Friend WithEvents EndingOdometerReadingTextBox As TextBox
    Friend WithEvents NumberOfDaysTextBox As TextBox
    Friend WithEvents CustomerNameLabel As Label
    Friend WithEvents AddressLabel As Label
    Friend WithEvents CityLabel As Label
    Friend WithEvents StateLabel As Label
    Friend WithEvents ZipCodeLabel As Label
    Friend WithEvents BeginningOdometerReadingLabel As Label
    Friend WithEvents EndingOdometerReadingLabel As Label
    Friend WithEvents NumberOfDaysLabel As Label
    Friend WithEvents OdometerGroupBox As GroupBox
    Friend WithEvents KilometersRadioButton As RadioButton
    Friend WithEvents MilesRadioButton As RadioButton
    Friend WithEvents DiscountsGroupBox As GroupBox
    Friend WithEvents SeniorCitizenDiscountCheckBox As CheckBox
    Friend WithEvents AAAMemberDiscountCheckBox As CheckBox
    Friend WithEvents DistanceTraveledinMilesTextBox As TextBox
    Friend WithEvents MileageChargeTextBox As TextBox
    Friend WithEvents DayChargeTextBox As TextBox
    Friend WithEvents MinusDiscount As TextBox
    Friend WithEvents AmountOwedTextBox As TextBox
    Friend WithEvents DistanceTraveledinMilesLabel As Label
    Friend WithEvents MileageChargeLabel As Label
    Friend WithEvents DayChargeLabel As Label
    Friend WithEvents MinusDiscountLabel As Label
    Friend WithEvents AmountOwedLabel As Label
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SummaryButton As Button
    Friend WithEvents ExitButton As Button
End Class
