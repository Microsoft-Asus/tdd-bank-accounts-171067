Public Class BankAccount
    Private AccountHolder As String
    Private AccountNumber As String
    Private InterestRate As Double
    Private BankBalance As Double
    Private CountryOfOrigin As String

    Public Sub New(AccountHolder As String, AccountNumber As String, InterestRate As Double, BankBalance As Double, CountryOfOrigin As String)
        Me.AccountHolder = AccountHolder
        Me.AccountHolder = AccountNumber
        Me.InterestRate = InterestRate
        Me.BankBalance = BankBalance
        Me.CountryOfOrigin = CountryOfOrigin
    End Sub

    Public Sub New(AccountHolder As String, AccountNumber As String, InterestRate As Double, BankBalance As Double)
        Me.AccountHolder = AccountHolder
        Me.AccountHolder = AccountNumber
        Me.InterestRate = InterestRate
        Me.BankBalance = BankBalance

    End Sub

    Public Sub New(AccountHolder As String, AccountNumber As String, InterestRate As Double)
        Me.AccountHolder = AccountHolder
        Me.AccountHolder = AccountNumber
        Me.InterestRate = InterestRate


    End Sub


    Public Function GetAccountHolder() As String
        Return Me.AccountHolder
    End Function

    Public Function GetAccountNumber() As String
        Return Me.AccountNumber
    End Function

    Public Function GetInterestRate() As Double
        Return Me.BankBalance
    End Function

    Public Function GetBankBalance() As Double
        Return Me.BankBalance
    End Function

    Public Function GetOriginCountry() As String
        Return Me.CountryOfOrigin
    End Function

    Public Function SetInterestRate(Rate As Double)
        Me.InterestRate = Rate
        Return Nothing
    End Function

    Public Function ApplyInterestRate()
        Dim Newbalance As Double = Me.BankBalance * 0.043 * (1 / 12)

        Me.BankBalance = Math.Round(Newbalance, 2)

        Return Nothing
    End Function

    Public Function Deposit(ammount As Double) As Double
        Me.BankBalance += ammount
        Return Me.BankBalance
    End Function

    Public Function WihtDrawll(Ammount As Double) As Double
        Me.BankBalance -= Ammount
        Return Me.BankBalance
    End Function

    Public Overrides Function Tostring() As String
        Dim accountString As New Stringbuilder()
        accountString.Append("MR S. N. David" & vbCrLf)
        accountString.Append("ABCD 890111 11167890" & vbCrLf)
        accountString.Append("Intrest: 4.3%" & vbCrLf)
        accountString.Append("20000.8" & vbCrLf)
        accountString.Append("whoo Vill" & vbCrLf)

        Return accountString.ToString()
    End Function
End Class
