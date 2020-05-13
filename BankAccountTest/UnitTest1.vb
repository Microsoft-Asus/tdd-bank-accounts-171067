Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestConstructors()

        'Arrange 
        Dim Accountholder As String = "MR S. N. David"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim Interestrate As Double = 2.5
        Dim BankBalance As Double = 200000.8
        Dim CountryOfOrigin As String = "whoo Vill"

        'ACT
        Dim Account1 As New BankAccounts.BankAccount(Accountholder, AccountNumber, Interestrate, BankBalance, CountryOfOrigin)
        Dim Account2 As New BankAccounts.BankAccount(Accountholder, AccountNumber, Interestrate, BankBalance)
        Dim Account3 As New BankAccounts.BankAccount(Accountholder, AccountNumber, Interestrate,)
        'Assert
        Assert.IsNotNull(Account1)
        Assert.IsNotNull(Account2)
        Assert.IsNotNull(Account3)

    End Sub

End Class