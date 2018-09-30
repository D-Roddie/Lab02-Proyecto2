Imports BankAccount
Imports Entities

Public Class CustomerView
    Private customerList As New List(Of Customer)
    Private ReadOnly CtmManagement As CustomerManagement = New CustomerManagement()
    Private SLTCustomer As New Customer

    Public Sub New()
        InitializeComponent()
        InitializeListView()
        LockText()
    End Sub

    Private Sub InitializeListView()
        With Customer_ListView
            .View = View.Details
            .HeaderStyle = ColumnHeaderStyle.Clickable
            .Columns.Clear()
            .Columns.AddRange(New ColumnHeader() _
                                 {New ColumnHeader(), New ColumnHeader(), New ColumnHeader(), New ColumnHeader()})
            .Columns.Item(0).Text = "ID"
            .Columns.Item(1).Text = "Name"
            .Columns.Item(2).Text = "LastName"
            .Columns.Item(3).Text = "Age"
        End With
        customerList = CtmManagement.RetrieveAll()
        For Each customer In customerList
            Customer_ListView.Items.Add(New ListViewItem({customer.Id, customer.Name, customer.LastName, customer.Age}))
        Next
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles CustomerID_txt.TextChanged
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CustomerUpdate_btn.Click
    End Sub

    Private Sub Customer_ListView_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles Customer_ListView.SelectedIndexChanged
    End Sub

    Private Sub CustomerRegister_btn_Click(sender As Object, e As EventArgs) Handles CustomerRegister_btn.Click

        UnLockText()

        Dim newCustomer As New Customer
        newCustomer.Id = CustomerID_txt.Text
        newCustomer.Name = CustomerName_txt.Text
        newCustomer.LastName = CustomerLastName_txt.Text
        newCustomer.Age = CustomerAge_txt.Text

        CtmManagement.Create(newCustomer)

        CustomerID_txt.Clear()
        CustomerName_txt.Clear()
        CustomerLastName_txt.Clear()
        CustomerAge_txt.Clear()
        RefreshCustomersList()
    End Sub

    Private Sub RefreshCustomersList()
        customerList = CtmManagement.RetrieveAll()
        Customer_ListView.Clear()
        InitializeListView()
    End Sub

    Private Sub LockText()
        CustomerID_txt.Enabled = False
        CustomerAge_txt.Enabled = False
        CustomerName_txt.Enabled = False
        CustomerLastName_txt.Enabled = False
    End Sub

    Private Sub UnLockText()
        CustomerID_txt.Enabled = True
        CustomerAge_txt.Enabled = True
        CustomerName_txt.Enabled = True
        CustomerLastName_txt.Enabled = True
    End Sub

    Private Sub CustomerDelete_btn_Click(sender As Object, e As EventArgs) Handles CustomerDelete_btn.Click
        CustomerAge_txt.Enabled = False
        CustomerName_txt.Enabled = False
        CustomerLastName_txt.Enabled = False

        If CustomerDelete_btn.Text IsNot "" Then
            Dim oldCustomer As New Customer
            oldCustomer.Id = CustomerDelete_btn.Text
            CtmManagement.Delete(oldCustomer)
            CustomerDelete_btn.Text = ""
            RefreshCustomersList()


            RefreshCustomersList()
        End If
    End Sub

    Private Sub CustomerView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
