Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports BankAccounts
<TestClass()> Public Class UnitTest2

    <TestMethod()> Public Sub TestCreatAccount()

        'Arrange 
        Dim AccounHolder As String = "MR S. N. David"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim intrestRate As String = "4.3"
        Dim Balance As String = "20000.8"
        Dim CountryOfOrigin As String = "whoo Vill"

        Dim BF As New BankAccountsForm()
        BF.SetTestForTesting(AccounHolder, AccountNumber, intrestRate, Balance, CountryOfOrigin)

        'ACT 
        BF.CreatAccount()
        Dim TempAccount() As BankAccount = BF.GetAccounts


        Assert.AreEqual(AccounHolder, TempAccount(0).GetAccountHolder())
        Assert.AreEqual(AccounHolder, BF.GetAccounts(0).GetAccountNumber())
        Assert.AreEqual(4.3, BF.GetAccounts(0).GetInterestRate())
        Assert.AreEqual(20000.8, BF.GetAccounts(0).GetBankBalance())
        Assert.AreEqual(CountryOfOrigin, BF.GetAccounts(0).GetCountry())

    End Sub
    <TestMethod()> Public Sub TestEmptyAccountholder()
        'arrage 
        Dim AccountHolder As String = ""
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim intrestrate As String = "4.3"
        Dim Balance As String = "20000.8"
        Dim CountryOfOrigin As String = "whoo Vill"

        Dim BF As New BankAccountsForm()
        BF.SetTextForTesting(AccountHolder, AccountNumber, Balance, intrestrate, CountryOfOrigin)

        'Act 
        Try
            BF.CreatAccount()
            Assert.Fail()
        Catch EX As Exception

            'Assert 
            Assert.AreEqual("AccountHolderRequiredExpectation", EX.Message)

        End Try
    End Sub

    <TestMethod()> Public Sub TestEmptyCountry()
        'arrage 
        Dim AccountHolder As String = "MR S. N. David"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim intrestrate As String = "4.3"
        Dim Balance As String = "20000.8"
        Dim CountryOfOrigin As String = ""

        Dim BF As New BankAccountsForm()
        BF.SetTextForTesting(AccountHolder, AccountNumber, Balance, intrestrate, CountryOfOrigin)

        'Act 
        Try
            BF.CreatAccount()
            Assert.Fail()
        Catch EX As Exception

            'Assert 
            Assert.AreEqual("CountryOfOriginRequiredExpectation", EX.Message)

        End Try
    End Sub

End Class