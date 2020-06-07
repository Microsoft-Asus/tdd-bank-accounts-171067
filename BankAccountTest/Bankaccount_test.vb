Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class Bankaccount_test

    <TestMethod()> Public Sub TestConstructors()

        'Arrange 
        Dim Accountholder As String = "MR S. N. David"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim Interestrate As Double = 4.3
        Dim BankBalance As Double = 200000.8
        Dim CountryOfOrigin As String = "whoo Vill"

        'ACT
        Dim Account1 As New BankAccounts.BankAccount(Accountholder, AccountNumber, Interestrate, BankBalance, CountryOfOrigin)
        Dim Account2 As New BankAccounts.BankAccount(Accountholder, AccountNumber, Interestrate, BankBalance)
        Dim Account3 As New BankAccounts.BankAccount(Accountholder, AccountNumber, Interestrate)
        'Assert
        Assert.IsNotNull(Account1)
        Assert.IsNotNull(Account2)
        Assert.IsNotNull(Account3)

    End Sub


    ''' <summary>
    ''' Testing Getters and seters 
    ''' </summary>



    <TestMethod()> Public Sub TestGetAccountHolder()
        'Arrange 
        Dim Accountholder As String = "MR S. N. David"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim Interestrate As Double = 4.3
        Dim BankBalance As Double = 20000.8
        Dim CountryOfOrigin As String = "whoo Vill"
        Dim Account1 As New BankAccounts.BankAccount(Accountholder, AccountNumber, Interestrate, BankBalance, CountryOfOrigin)

        'ACT
        Dim Name As String = Account1.GetAccountHolder

        'Assert 
        Assert.AreEqual(Name, "MR S. N. David")

    End Sub

    <TestMethod()> Public Sub TestGetAccountNumber()
        Dim Accountholder As String = "MR S. N. David"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim Interestrate As Double = 4.3
        Dim BankBalance As Double = 20000.8
        Dim CountryOfOrigin As String = "whoo Vill"
        Dim Account1 As New BankAccounts.BankAccount(Accountholder, AccountNumber, Interestrate, BankBalance, CountryOfOrigin)

        'ACT
        Dim Number As String = Account1.GetAccountNumber

        'Assert 
        Assert.AreEqual(Number, "ABCD 890111 11167890")
    End Sub

    <TestMethod()> Public Sub TestGetInterestRate()
        'Arrange 
        Dim Accountholder As String = "MR S. N. David"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim Interestrate As Double = 4.3
        Dim BankBalance As Double = 20000.8
        Dim CountryOfOrigin As String = "whoo Vill"
        Dim Account1 As New BankAccounts.BankAccount(Accountholder, AccountNumber, Interestrate, BankBalance, CountryOfOrigin)

        'ACT
        Dim Interest As Double = Account1.GetInterestRate

        'Assert
        Assert.AreEqual(Interestrate, 4.3)
    End Sub

    <TestMethod()> Public Sub TestGetBankBalance()
        'Assert 
        Dim Accountholder As String = "MR S. N. David"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim Interestrate As Double = 4.3
        Dim BankBalance As Double = 20000.8
        Dim CountryOfOrigin As String = "whoo Vill"
        Dim Account1 As New BankAccounts.BankAccount(Accountholder, AccountNumber, Interestrate, BankBalance, CountryOfOrigin)

        'ACT 
        Dim Balance As Double = Account1.GetBankBalance

        'Assert
        Assert.AreEqual(BankBalance, 20000.8)
    End Sub

    <TestMethod()> Public Sub TestGetOriginCountry()
        'Assert
        Dim Accountholder As String = "MR S. N. David"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim Interestrate As Double = 4.3
        Dim BankBalance As Double = 20000.8
        Dim CountryOfOrigin As String = "whoo Vill"
        Dim Account1 As New BankAccounts.BankAccount(Accountholder, AccountNumber, Interestrate, BankBalance, CountryOfOrigin)

        'ACT 
        Dim OriginCountry As String = Account1.GetOriginCountry

        'Assert
        Assert.AreEqual(CountryOfOrigin, "whoo Vill")
    End Sub

    <TestMethod()> Public Sub TestSetInterestRate()
        'Arrange 
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount()

        'ACT 
        Account1.SetInterestRate(4.3)

        'Assert
        Assert.AreEqual(200000.8, Account1.GetInterestRate())
    End Sub

    <TestMethod()> Public Sub TestApplyInterestRate()
        ' p x r x t = i => X + 200000 = A

        'Arrange 
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount()

        'ACT 
        Account1.ApplyInterestRate()

        'Assert 
        Assert.AreEqual(Account1.GetBankBalance(), 716.67)
    End Sub

    <TestMethod()> Public Sub TestDeposit()
        'Arrange
        Dim account1 As BankAccounts.BankAccount = Me.NewAccount()
        Dim ExpectedValues As Double = 200000.8 + 800
        'ACT
        Dim actualvalue As Double = account1.Deposit(800)
        'assert 
        Assert.AreEqual(ExpectedValues, actualvalue)
    End Sub

    <TestMethod()> Public Sub TestToStringMethod()
        Dim ExpectedValueString As New StringBuilder()
        ExpectedValueString.Append("MR S. N. David" & vbCrLf)
        ExpectedValueString.Append("ABCD 890111 11167890" & vbCrLf)
        ExpectedValueString.Append("Intrest: 4.3" & vbCrLf)
        ExpectedValueString.Append("20000.8" & vbCrLf)
        ExpectedValueString.Append("whoo Vill" & vbCrLf)

        Dim Account1 As BankAccounts.BankAccount = NewAccount()
        'ACT 
        Dim actualstring = Account1.Tostring()
        'Assert 
        Assert.AreEqual(ExpectedValueString.ToString(), actualstring)
    End Sub

    <TestMethod()> Public Sub TestWithdrallSmall()
        'Arrange 
        Dim account1 As BankAccounts.BankAccount = Me.NewAccount()
        Dim expectedval As Double = 200000.8 - 5000
        'ACT
        Dim NewBalance = account1.Withdrawll(5000)
        'Assert 
        Assert.AreEqual(expectedval, NewBalance)
    End Sub

    Private Function NewAccount() As BankAccounts.BankAccount
        Dim Accountholder As String = "MR S. N. David"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim Interestrate As Double = 4.3
        Dim BankBalance As Double = 200000.8
        Dim CountryOfOrigin As String = "whoo Ville"
        Dim Account1 As New BankAccounts.BankAccount(Accountholder, AccountNumber, Interestrate, BankBalance, CountryOfOrigin)
        Return Account1
    End Function

End Class