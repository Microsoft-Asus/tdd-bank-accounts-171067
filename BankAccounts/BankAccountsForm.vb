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

    Public Function CreatAccount()


        'Guard Clauses
        If TextAccountHolder.Text = "" Then Throw New Exception("AccountHolderRequiredExpectation")
        If TextBoxCountryOfOrigin.Text = "" Then Throw New Exception("CountryOfOriginRequiredExpectation")

        Dim Accountholder As String = TextAccountHolder.Text
        Dim AccountNumber As String = TextAccountNumber.Text
        Dim Interestrate As Double = CDbl(TextIntrestRate.Text)
        Dim BankBalance As Double = CDbl(TextBalance.Text)
        Dim CountryOfOrigin As String = TextBoxCountryOfOrigin.Text

        Dim NewAccount As New BankAccount(Accountholder, AccountNumber, Interestrate, BankBalance, CountryOfOrigin)
        Me.Accounts(Me.NumAccounts) = NewAccount

        Return Nothing
    End Function


    Public Function SetTestForTesting(AccountHolder As String, AccountNumber As String, IntrestRate As String, Balance As String, countryOfOrigin As String)
        TextAccountHolder.Text = AccountHolder
        TextAccountNumber.Text = AccountNumber
        TextIntrestRate.Text = IntrestRate
        TextBalance.Text = Balance
        TextBoxCountryOfOrigin.Text = countryOfOrigin

        Return Nothing
    End Function

    Public Function GetAccounts() As BankAccount()
        Return Me.Accounts
    End Function

    Public Function SetTextForTesting(AccountHolder As String, AccountNumber As String, IntrestRate As String, Balance As String, countryOfOrigin As String)
        TextAccountHolder.Text = AccountHolder
        TextAccountNumber.Text = AccountNumber
        TextIntrestRate.Text = IntrestRate
        TextBalance.Text = Balance
        TextBoxCountryOfOrigin.Text = countryOfOrigin

        Return Nothing
    End Function

End Class