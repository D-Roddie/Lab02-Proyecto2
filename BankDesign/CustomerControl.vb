Imports BankAccount
Imports Entities

Public Class CustomerControl
    Private customerList As New List(Of Customer)
    Private ReadOnly CtmManagement As CustomerManagement = New CustomerManagement()
    Private selectedCustomer as New Customer

    Public Sub New()

        ' This call is required by the designer.

        InitializeComponent()
        InitializeListView()
        LockText()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles Customer_ListView.SelectedIndexChanged
        For Each item As ListViewItem In Customer_ListView.SelectedItems
            If item.Selected Then
                selectedCustomer = customerList.Find(Function(x) x.Id.Contains(item.SubItems(0).Text))
                CustomerID_txt.Text = selectedCustomer.Id
                CustomerName_txt.Text = selectedCustomer.Name
                CustomerLastName_txt.Text = selectedCustomer.LastName
                CustomerBirthday_txt.Text = selectedCustomer.Birthday
                CustomerAge_txt.Text = selectedCustomer.Age
                CustomerSocialStatus_txt.Text = selectedCustomer.SocialStatus
                CustomerGender_txt.Text = selectedCustomer.Gender
                
            End If
        Next
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) _
        Handles CustomerDelete_Lock.Click
        If CustomerID_txt.Text IsNot "" Then
            Dim delCustomer As New Customer
            delCustomer.Id = CustomerID_txt.Text
            CtmManagement.Delete(delCustomer)
            RefreshCustomersList()

        End If
    End Sub

    Private Sub CustomerRegister_btn_Click(sender As Object, e As EventArgs) Handles CustomerRegister_btn.Click
        
        Dim newCustomer As New Customer
        newCustomer.Id = CustomerID_txt.Text
        newCustomer.Name = CustomerName_txt.Text
        newCustomer.LastName = CustomerLastName_txt.Text
        newCustomer.Birthday = CustomerBirthday_txt.Text
        newCustomer.Age = CustomerAge_txt.Text
        newCustomer.SocialStatus = CustomerSocialStatus_txt.Text
        newCustomer.Gender = CustomerGender_txt.Text

        ctmManagement.Create(newCustomer)
        RefreshCustomersList()
        LockText()
    End Sub

    Private Sub RefreshCustomersList()

        customerList = ctmManagement.RetrieveAll()


        Customer_ListView.Clear()
        InitializeListView()
    End Sub


    Private Sub InitializeListView()
        With Customer_ListView
            .View = View.Details
            .HeaderStyle = ColumnHeaderStyle.Clickable
            .Columns.Clear()
            .Columns.AddRange(
                New ColumnHeader() _
                                 {New ColumnHeader(), New ColumnHeader(), New ColumnHeader(), New ColumnHeader(),
                                  New ColumnHeader(),
                                  New ColumnHeader(), New ColumnHeader()})
            .Columns.Item(0).Text = "ID"
            .Columns.Item(1).Text = "Name"
            .Columns.Item(2).Text = "LastName"
            .Columns.Item(3).Text = "Birthday"
            .Columns.Item(4).Text = "Age"
            .Columns.Item(5).Text = "Social Status"
            .Columns.Item(6).Text = "Gender"
        End With
        customerList = CtmManagement.RetrieveAll()
        For Each cust In customerList
            Customer_ListView.Items.Add(
                New ListViewItem(
                    {cust.Id, cust.Name, cust.LastName, cust.Birthday, cust.Age, cust.SocialStatus, cust.Gender}))
        Next
    End Sub

    Private Sub CustomerControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub CustomerUpdateLock_Click(sender As Object, e As EventArgs) Handles CustomerUpdateLock.Click
        If CustomerID_txt.Text IsNot "" Then
            Dim customer As New Customer
            customer.Id = CustomerID_txt.Text
            customer.Name = CustomerName_txt.Text
            customer.LastName = CustomerLastName_txt.Text
            customer.Birthday = CustomerBirthday_txt.Text
            customer.Age = CustomerAge_txt.Text
            customer.SocialStatus = CustomerSocialStatus_txt.Text
            customer.Gender = CustomerGender_txt.Text
            CtmManagement.Update(customer)

            RefreshCustomersList()
        End If
    End Sub

    Private Sub LockText()
        CustomerID_txt.ReadOnly = True
        CustomerID_txt.BackColor = Color.DimGray
        CustomerID_txt.ForeColor = color.White

        CustomerName_txt.ReadOnly = True
        CustomerName_txt.BackColor = Color.DimGray
        CustomerName_txt.ForeColor = color.White

        CustomerLastName_txt.ReadOnly = True
        CustomerLastName_txt.BackColor = Color.DimGray
        CustomerLastName_txt.ForeColor = color.White

        CustomerBirthday_txt.ReadOnly = True
        CustomerBirthday_txt.BackColor = Color.DimGray
        CustomerBirthday_txt.ForeColor = color.White

        CustomerAge_txt.ReadOnly = True
        CustomerAge_txt.BackColor = Color.DimGray
        CustomerAge_txt.ForeColor = color.White

        CustomerSocialStatus_txt.ReadOnly = True
        CustomerSocialStatus_txt.BackColor = Color.DimGray
        CustomerSocialStatus_txt.ForeColor = color.White

        CustomerGender_txt.ReadOnly = True
        CustomerGender_txt.BackColor = Color.DimGray
        CustomerGender_txt.ForeColor = color.White
    End Sub

    Private Sub LockTextV2()
        CustomerID_txt.ReadOnly = True
        CustomerID_txt.BackColor = Color.DimGray
        CustomerID_txt.ForeColor = color.White

        CustomerName_txt.ReadOnly = True
        CustomerName_txt.BackColor = Color.DimGray
        CustomerName_txt.ForeColor = color.White

        CustomerLastName_txt.ReadOnly = True
        CustomerLastName_txt.BackColor = Color.DimGray
        CustomerLastName_txt.ForeColor = color.White

        CustomerBirthday_txt.ReadOnly = True
        CustomerBirthday_txt.BackColor = Color.DimGray
        CustomerBirthday_txt.ForeColor = color.White

        CustomerAge_txt.ReadOnly = True
        CustomerAge_txt.BackColor = Color.DimGray
        CustomerAge_txt.ForeColor = color.White

        CustomerSocialStatus_txt.ReadOnly = True
        CustomerSocialStatus_txt.BackColor = Color.DimGray
        CustomerSocialStatus_txt.ForeColor = color.White

        CustomerGender_txt.ReadOnly = True
        CustomerGender_txt.BackColor = Color.DimGray
        CustomerGender_txt.ForeColor = color.White
    End Sub

    Private Sub UnlockText()
        CustomerID_txt.ReadOnly = False
        CustomerID_txt.BackColor = Color.White
        CustomerID_txt.ForeColor = Color.Black
        CustomerID_txt.Clear()
        CustomerName_txt.ReadOnly = False
        CustomerName_txt.BackColor = Color.White
        CustomerName_txt.ForeColor = Color.Black
        CustomerName_txt.Clear()
        CustomerLastName_txt.ReadOnly = False
        CustomerLastName_txt.BackColor = Color.White
        CustomerLastName_txt.ForeColor = Color.Black
        CustomerLastName_txt.Clear()
        CustomerBirthday_txt.ReadOnly = False
        CustomerBirthday_txt.BackColor = Color.White
        CustomerBirthday_txt.ForeColor = Color.Black
        CustomerBirthday_txt.Clear()
        CustomerAge_txt.ReadOnly = False
        CustomerAge_txt.BackColor = Color.White
        CustomerAge_txt.ForeColor = Color.Black
        CustomerAge_txt.Clear()
        CustomerSocialStatus_txt.ReadOnly = False
        CustomerSocialStatus_txt.BackColor = Color.White
        CustomerSocialStatus_txt.ForeColor = Color.Black
        CustomerSocialStatus_txt.Clear()
        CustomerGender_txt.ReadOnly = False
        CustomerGender_txt.BackColor = Color.White
        CustomerGender_txt.ForeColor = Color.Black
        CustomerGender_txt.Clear()
    End Sub

    Private Sub UnlockTextUpdate()
        CustomerID_txt.ReadOnly = False
        CustomerID_txt.BackColor = Color.White
        CustomerID_txt.ForeColor = Color.Black

        CustomerName_txt.ReadOnly = False
        CustomerName_txt.BackColor = Color.White
        CustomerName_txt.ForeColor = Color.Black
     
        CustomerLastName_txt.ReadOnly = False
        CustomerLastName_txt.BackColor = Color.White
        CustomerLastName_txt.ForeColor = Color.Black
        
        CustomerBirthday_txt.ReadOnly = False
        CustomerBirthday_txt.BackColor = Color.White
        CustomerBirthday_txt.ForeColor = Color.Black
      
        CustomerAge_txt.ReadOnly = False
        CustomerAge_txt.BackColor = Color.White
        CustomerAge_txt.ForeColor = Color.Black
       
        CustomerSocialStatus_txt.ReadOnly = False
        CustomerSocialStatus_txt.BackColor = Color.White
        CustomerSocialStatus_txt.ForeColor = Color.Black
     
        CustomerGender_txt.ReadOnly = False
        CustomerGender_txt.BackColor = Color.White
        CustomerGender_txt.ForeColor = Color.Black
    End Sub



    Private Sub CustomerUpdateSecond_Click(sender As Object, e As EventArgs) Handles CustomerUpdateSecond.Click
        UnlockTextUpdate()
        CustomerID_txt.ReadOnly = True
        CustomerID_txt.BackColor = Color.DimGray
        CustomerID_txt.ForeColor = color.White
    End Sub

    Private Sub CustomerLock_btn_Click(sender As Object, e As EventArgs) Handles CustomerLock_btn.Click
        UnlockText()
        CustomerRegister_btn.BringToFront()
       
        
    End Sub
End Class