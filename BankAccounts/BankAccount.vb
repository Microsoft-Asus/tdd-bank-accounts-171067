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

    Public Overrides Function Tostring() As String
        Imports System.Text
        Dim Accountstring As New StringBuilder()
        Accountstring.Append("MR S. N. David" & vbCrLf)
        Accountstring.Append("ABCD 890111 11167890" & vbCrLf)
        Accountstring.Append(2.5 & vbCrLf)
        Accountstring.Append(200000.8 & vbCrLf)
        Accountstring.Append("whoo Vill" & vbCrLf)
        Return Accountstring
    End Function

End Class
