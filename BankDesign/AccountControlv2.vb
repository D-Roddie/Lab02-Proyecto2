Imports BankAccount
Imports Entities

Public Class AccountControlv2
    Private accountList As New List(Of Account)
    Private ReadOnly accManagement As AccountManagement = New AccountManagement()
    Private selectAccount as New Account

    Public Sub New()

        ' This call is required by the designer.

        InitializeComponent()
        InitializeListView()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles AccountID_txt.TextChanged, AccountCurrency_txt.TextChanged, AccountName_txt.TextChanged, AccountBalance_txt.TextChanged

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Account_ListView.SelectedIndexChanged
        For Each item As ListViewItem In Account_ListView.SelectedItems
            If item.Selected Then
                selectAccount = accountList.Find(Function(x) x.Identification.Contains(item.SubItems(0).Text))
                AccountID_txt.Text = selectAccount.Identification
                AccountName_txt.Text = selectAccount.AccountName
                AccountCurrency_txt.Text = selectAccount.Currency
                AccountBalance_txt.Text = selectAccount.Balance
                
                
            End If
        Next
    End Sub

    Private Sub AccountRegister_btn_Click(sender As Object, e As EventArgs) Handles AccountRegister_btn.Click
        Dim newAccount As New Account
        newAccount.Identification = AccountID_txt.Text
        newAccount.AccountName = AccountName_txt.Text
        newAccount.Currency = AccountCurrency_txt.Text
        newAccount.Balance = AccountBalance_txt.Text


        accManagement.Create(newAccount)
        RefreshAccountList()
    End Sub

    Private Sub RefreshAccountList()

        accountList = accManagement.RetrieveAll()


        Account_ListView.Clear()
        InitializeListView()
    End Sub

    Private Sub InitializeListView()
        With Account_ListView
            .View = View.Details
            .HeaderStyle = ColumnHeaderStyle.Clickable
            .Columns.Clear()
            .Columns.AddRange(
                New ColumnHeader() _
                                 {New ColumnHeader(), New ColumnHeader(), New ColumnHeader(), New ColumnHeader()})
            .Columns.Item(0).Text = "ID"
            .Columns.Item(1).Text = "Name"
            .Columns.Item(2).Text = "Currency"
            .Columns.Item(3).Text = "Balance"

        End With
        accountList = accManagement.RetrieveAll()
        For Each acc In accountList
            Account_ListView.Items.Add(
                New ListViewItem(
                    {acc.Identification, acc.AccountName, acc.Currency, acc.Balance}))
        Next
    End Sub

    Private Sub AccountDelete_btn_Click(sender As Object, e As EventArgs) Handles AccountDelete_btn.Click
        If AccountID_txt.Text IsNot "" Then
            Dim delAccount As New Account
            delAccount.Identification = AccountID_txt.Text
            accManagement.Delete(delAccount)
            RefreshAccountList()

        End If
    End Sub

    Private Sub AccountUpdate_btn_Click(sender As Object, e As EventArgs) Handles AccountUpdate_btn.Click
        If AccountID_txt.Text IsNot "" Then
        Dim newAccount As New Account
        newAccount.Identification = AccountID_txt.Text
        newAccount.AccountName = AccountName_txt.Text
        newAccount.Currency = AccountCurrency_txt.Text
        newAccount.Balance = AccountBalance_txt.Text


        accManagement.Update(newAccount)
        RefreshAccountList()
        End If
    End Sub
End Class
