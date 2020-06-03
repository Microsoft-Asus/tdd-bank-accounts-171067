Imports System.Windows.Forms

Public Class BankAccountsForm

    'Class veriables decralation goes
    Private Accounts() As BankAccount
    Private NumAccounts As Integer

    'Class method deffinition go here (Constructors / Getters / setters)
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.NumAccounts = 0

    End Sub

    Private Sub BtnExit_Click(Sender As Object, BF As EventArgs) Handles BtnExit.Click

        Application.Exit()

    End Sub

    'Methods to help testing 

    Public Function SetTestForTesting(AccountHolder As String, AccountNumber As String, IntrestRate As String, Balance As String, Intrest_Rate As String, countryOfOrigin As String)
        TextAccountHolder.Text = AccountHolder
        TextAccountNumber.Text = AccountNumber
        TextIntrestRate.Text = IntrestRate
        TextBalance.Text = Balance
        TextBoxCountryOfOrigin.Text = countryOfOrigin

        Return Nothing
    End Function

    Public Function GetAccounts() As BankAccounts()
        Return Me.Accounts
    End Function

End Class