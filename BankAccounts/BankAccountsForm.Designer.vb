<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BankAccountsForm
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
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.TextAccountHolder = New System.Windows.Forms.TextBox()
        Me.AccountHolderLabel = New System.Windows.Forms.Label()
        Me.TextAccountNumber = New System.Windows.Forms.TextBox()
        Me.AccountNumberLabel = New System.Windows.Forms.Label()
        Me.TextIntrestRate = New System.Windows.Forms.TextBox()
        Me.LabelIntrestRate = New System.Windows.Forms.Label()
        Me.TextBalance = New System.Windows.Forms.TextBox()
        Me.LabelBalance = New System.Windows.Forms.Label()
        Me.TextBoxCountryOfOrigin = New System.Windows.Forms.TextBox()
        Me.LabelCountryOfOrigin = New System.Windows.Forms.Label()
        Me.TextBoxAccountList = New System.Windows.Forms.TextBox()
        Me.LabelAccountHolder = New System.Windows.Forms.Label()
        Me.ButtonPrintAccount = New System.Windows.Forms.Button()
        Me.ButtonAddIntrest = New System.Windows.Forms.Button()
        Me.ButtonAddAccount = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(461, 397)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(123, 69)
        Me.BtnExit.TabIndex = 0
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseMnemonic = False
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'TextAccountHolder
        '
        Me.TextAccountHolder.Location = New System.Drawing.Point(30, 74)
        Me.TextAccountHolder.Name = "TextAccountHolder"
        Me.TextAccountHolder.Size = New System.Drawing.Size(225, 22)
        Me.TextAccountHolder.TabIndex = 1
        '
        'AccountHolderLabel
        '
        Me.AccountHolderLabel.AutoSize = True
        Me.AccountHolderLabel.Location = New System.Drawing.Point(30, 51)
        Me.AccountHolderLabel.Name = "AccountHolderLabel"
        Me.AccountHolderLabel.Size = New System.Drawing.Size(150, 17)
        Me.AccountHolderLabel.TabIndex = 2
        Me.AccountHolderLabel.Text = "Account Holder Name "
        '
        'TextAccountNumber
        '
        Me.TextAccountNumber.Location = New System.Drawing.Point(30, 138)
        Me.TextAccountNumber.Name = "TextAccountNumber"
        Me.TextAccountNumber.Size = New System.Drawing.Size(225, 22)
        Me.TextAccountNumber.TabIndex = 3
        '
        'AccountNumberLabel
        '
        Me.AccountNumberLabel.AutoSize = True
        Me.AccountNumberLabel.Location = New System.Drawing.Point(30, 115)
        Me.AccountNumberLabel.Name = "AccountNumberLabel"
        Me.AccountNumberLabel.Size = New System.Drawing.Size(117, 17)
        Me.AccountNumberLabel.TabIndex = 4
        Me.AccountNumberLabel.Text = "Account Number "
        '
        'TextIntrestRate
        '
        Me.TextIntrestRate.Location = New System.Drawing.Point(30, 200)
        Me.TextIntrestRate.Name = "TextIntrestRate"
        Me.TextIntrestRate.Size = New System.Drawing.Size(114, 22)
        Me.TextIntrestRate.TabIndex = 5
        '
        'LabelIntrestRate
        '
        Me.LabelIntrestRate.AutoSize = True
        Me.LabelIntrestRate.Location = New System.Drawing.Point(30, 177)
        Me.LabelIntrestRate.Name = "LabelIntrestRate"
        Me.LabelIntrestRate.Size = New System.Drawing.Size(85, 17)
        Me.LabelIntrestRate.TabIndex = 6
        Me.LabelIntrestRate.Text = "Intrest Rate "
        '
        'TextBalance
        '
        Me.TextBalance.Location = New System.Drawing.Point(30, 265)
        Me.TextBalance.Name = "TextBalance"
        Me.TextBalance.Size = New System.Drawing.Size(114, 22)
        Me.TextBalance.TabIndex = 7
        '
        'LabelBalance
        '
        Me.LabelBalance.AutoSize = True
        Me.LabelBalance.Location = New System.Drawing.Point(30, 242)
        Me.LabelBalance.Name = "LabelBalance"
        Me.LabelBalance.Size = New System.Drawing.Size(59, 17)
        Me.LabelBalance.TabIndex = 8
        Me.LabelBalance.Text = "Balance"
        '
        'TextBoxCountryOfOrigin
        '
        Me.TextBoxCountryOfOrigin.Location = New System.Drawing.Point(33, 329)
        Me.TextBoxCountryOfOrigin.Name = "TextBoxCountryOfOrigin"
        Me.TextBoxCountryOfOrigin.Size = New System.Drawing.Size(222, 22)
        Me.TextBoxCountryOfOrigin.TabIndex = 9
        '
        'LabelCountryOfOrigin
        '
        Me.LabelCountryOfOrigin.AutoSize = True
        Me.LabelCountryOfOrigin.Location = New System.Drawing.Point(33, 306)
        Me.LabelCountryOfOrigin.Name = "LabelCountryOfOrigin"
        Me.LabelCountryOfOrigin.Size = New System.Drawing.Size(122, 17)
        Me.LabelCountryOfOrigin.TabIndex = 10
        Me.LabelCountryOfOrigin.Text = "Country Of Origin "
        '
        'TextBoxAccountList
        '
        Me.TextBoxAccountList.Location = New System.Drawing.Point(339, 74)
        Me.TextBoxAccountList.Multiline = True
        Me.TextBoxAccountList.Name = "TextBoxAccountList"
        Me.TextBoxAccountList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxAccountList.Size = New System.Drawing.Size(245, 277)
        Me.TextBoxAccountList.TabIndex = 11
        '
        'LabelAccountHolder
        '
        Me.LabelAccountHolder.AutoSize = True
        Me.LabelAccountHolder.Location = New System.Drawing.Point(339, 51)
        Me.LabelAccountHolder.Name = "LabelAccountHolder"
        Me.LabelAccountHolder.Size = New System.Drawing.Size(70, 17)
        Me.LabelAccountHolder.TabIndex = 12
        Me.LabelAccountHolder.Text = "Accounts "
        '
        'ButtonPrintAccount
        '
        Me.ButtonPrintAccount.Location = New System.Drawing.Point(88, 397)
        Me.ButtonPrintAccount.Name = "ButtonPrintAccount"
        Me.ButtonPrintAccount.Size = New System.Drawing.Size(92, 69)
        Me.ButtonPrintAccount.TabIndex = 13
        Me.ButtonPrintAccount.Text = "Print Accounts "
        Me.ButtonPrintAccount.UseVisualStyleBackColor = True
        '
        'ButtonAddIntrest
        '
        Me.ButtonAddIntrest.Location = New System.Drawing.Point(200, 397)
        Me.ButtonAddIntrest.Name = "ButtonAddIntrest"
        Me.ButtonAddIntrest.Size = New System.Drawing.Size(98, 69)
        Me.ButtonAddIntrest.TabIndex = 14
        Me.ButtonAddIntrest.Text = "Add Intrest Rate "
        Me.ButtonAddIntrest.UseVisualStyleBackColor = True
        '
        'ButtonAddAccount
        '
        Me.ButtonAddAccount.Location = New System.Drawing.Point(313, 397)
        Me.ButtonAddAccount.Name = "ButtonAddAccount"
        Me.ButtonAddAccount.Size = New System.Drawing.Size(87, 69)
        Me.ButtonAddAccount.TabIndex = 15
        Me.ButtonAddAccount.Text = "Add Account "
        Me.ButtonAddAccount.UseVisualStyleBackColor = True
        '
        'BankAccountsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 478)
        Me.Controls.Add(Me.ButtonAddAccount)
        Me.Controls.Add(Me.ButtonAddIntrest)
        Me.Controls.Add(Me.ButtonPrintAccount)
        Me.Controls.Add(Me.LabelAccountHolder)
        Me.Controls.Add(Me.TextBoxAccountList)
        Me.Controls.Add(Me.LabelCountryOfOrigin)
        Me.Controls.Add(Me.TextBoxCountryOfOrigin)
        Me.Controls.Add(Me.LabelBalance)
        Me.Controls.Add(Me.TextBalance)
        Me.Controls.Add(Me.LabelIntrestRate)
        Me.Controls.Add(Me.TextIntrestRate)
        Me.Controls.Add(Me.AccountNumberLabel)
        Me.Controls.Add(Me.TextAccountNumber)
        Me.Controls.Add(Me.AccountHolderLabel)
        Me.Controls.Add(Me.TextAccountHolder)
        Me.Controls.Add(Me.BtnExit)
        Me.Name = "BankAccountsForm"
        Me.Text = "Bank Accounts Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnExit As Windows.Forms.Button
    Friend WithEvents TextAccountHolder As Windows.Forms.TextBox
    Friend WithEvents AccountHolderLabel As Windows.Forms.Label
    Friend WithEvents TextAccountNumber As Windows.Forms.TextBox
    Friend WithEvents AccountNumberLabel As Windows.Forms.Label
    Friend WithEvents TextIntrestRate As Windows.Forms.TextBox
    Friend WithEvents LabelIntrestRate As Windows.Forms.Label
    Friend WithEvents TextBalance As Windows.Forms.TextBox
    Friend WithEvents LabelBalance As Windows.Forms.Label
    Friend WithEvents TextBoxCountryOfOrigin As Windows.Forms.TextBox
    Friend WithEvents LabelCountryOfOrigin As Windows.Forms.Label
    Friend WithEvents TextBoxAccountList As Windows.Forms.TextBox
    Friend WithEvents LabelAccountHolder As Windows.Forms.Label
    Friend WithEvents ButtonPrintAccount As Windows.Forms.Button
    Friend WithEvents ButtonAddIntrest As Windows.Forms.Button
    Friend WithEvents ButtonAddAccount As Windows.Forms.Button
End Class
