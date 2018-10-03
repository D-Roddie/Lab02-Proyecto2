Imports BankAccount
Imports Entities

Public Class LoanControl
    Private loanList As New List(Of Loans)
    Private ReadOnly loanManagement As LoanManagement = New LoanManagement()
    Private selectedLoan as New Loans

    Public Sub New()

        ' This call is required by the designer.

        InitializeComponent()
        InitializeListView()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub InitializeListView()
        With Loan_ListView
            .View = View.Details
            .HeaderStyle = ColumnHeaderStyle.Clickable
            .Columns.Clear()
            .Columns.AddRange(
                New ColumnHeader() _
                                 {New ColumnHeader(), New ColumnHeader(), New ColumnHeader(), New ColumnHeader(),
                                  New ColumnHeader(),
                                  New ColumnHeader(), New ColumnHeader(), New ColumnHeader()})
            .Columns.Item(0).Text = "ID"
            .Columns.Item(1).Text = "Amount"
            .Columns.Item(2).Text = "Rate"
            .Columns.Item(3).Text = "Name"
            .Columns.Item(4).Text = "Share"
            .Columns.Item(5).Text = "Start Date"
            .Columns.Item(6).Text = "Status"
            .Columns.Item(7).Text = "Balance Operation"
        End With
        loanList = loanManagement.RetrieveAll()
        For Each loan In loanList
            Loan_ListView.Items.Add(
                New ListViewItem(
                    {loan.LoansID, loan.Amount, loan.Rate, loan.LoanName, loan.Share, loan.StartDate, loan.Status,
                     loan.BalanceOperation}))
        Next
    End Sub

    Private Sub RefreshLoanList()

        loanList = loanManagement.RetrieveAll()


        Loan_ListView.Clear()
        InitializeListView()
    End Sub

    Private Sub LoanControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click, Label9.Click
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) _
        Handles LoanStatus_txt.TextChanged, LoanBalanceOperation_txt.TextChanged, LoanStartDate_txt.TextChanged
    End Sub

    Private Sub LoanRegister_btn_Click(sender As Object, e As EventArgs) Handles LoanRegister_btn.Click
        Dim newLoan As New Loans
        newLoan.LoansID = LoanID_txt.Text
        newLoan.Amount = LoanAmount_txt.Text
        newLoan.Rate = LoanRate_txt.Text
        newLoan.LoanName = LoanName_txt.Text
        newLoan.Share = LoanShare_txt.Text
        newLoan.StartDate = LoanStartDate_txt.Text
        newLoan.Status = _LoanStatus_txt.Text
        newLoan.BalanceOperation = LoanBalanceOperation_txt.Text

        loanManagement.Create(newLoan)
        RefreshLoanList()
    End Sub


    Private Sub Loan_ListView_SelectedIndexChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub LoanUpdate_btn_Click(sender As Object, e As EventArgs) Handles LoanUpdate_btn.Click
        If LoanID_txt.Text IsNot "" Then
            Dim newLoan As New Loans
            newLoan.LoansID = LoanID_txt.Text
            newLoan.Amount = LoanAmount_txt.Text
            newLoan.Rate = LoanRate_txt.Text
            newLoan.LoanName = LoanName_txt.Text
            newLoan.Share = LoanShare_txt.Text
            newLoan.StartDate = LoanStartDate_txt.Text
            newLoan.Status = _LoanStatus_txt.Text
            newLoan.BalanceOperation = LoanBalanceOperation_txt.Text

            loanManagement.Update(newLoan)
            RefreshLoanList()
        End If
    End Sub

    Private Sub LoanDelete_btn_Click(sender As Object, e As EventArgs) Handles LoanDelete_btn.Click
        If LoanID_txt.Text IsNot "" Then
            Dim delLoan As New Loans
            delLoan.LoansID = LoanID_txt.Text
            loanManagement.Delete(delLoan)
            RefreshLoanList()

        End If
    End Sub

    Private Sub Loan_ListView_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles Loan_ListView.SelectedIndexChanged
        
        For Each item As ListViewItem In Loan_ListView.SelectedItems
            If item.Selected Then
                selectedLoan = loanList.Find(Function(x) x.LoansID.Contains(item.SubItems(0).Text))
                LoanID_txt.Text = selectedLoan.LoansID
                LoanAmount_txt.Text = selectedLoan.Amount
                LoanRate_txt.Text = selectedLoan.Rate
                LoanName_txt.Text = selectedLoan.LoanName
                LoanShare_txt.Text = selectedLoan.Share
                LoanStartDate_txt.Text = selectedLoan.StartDate
                LoanStatus_txt.Text = selectedLoan.Status
                LoanBalanceOperation_txt.Text = selectedLoan.BalanceOperation
                
            End If
        Next
    End Sub
End Class
