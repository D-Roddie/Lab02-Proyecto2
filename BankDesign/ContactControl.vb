Imports BankAccount
Imports Entities

Public Class ContactControl
    Private contactList As New List(Of Contact)
    Private ReadOnly cntManagemnet As ContactManagement = New ContactManagement()
    Private selectedContact as New Contact

    Private addressList As New List(Of Address)
    Private ReadOnly addManagement As AddressManagement = New AddressManagement()
    Private selectedAddress as New Address

    Public Sub New()

        ' This call is required by the designer.

        InitializeComponent()
        Address_InitializeListView()
        InitializeListView()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) _
        Handles Label8.Click, Label3.Click, Label2.Click, Label9.Click, Label7.Click, Label6.Click, Label10.Click
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) _
        Handles ContactID_txt.TextChanged, ContactValue_txt.TextChanged, ContactType_txt.TextChanged,
                AddressDistrict_txt.TextChanged, AddressStreet_txt.TextChanged, AddressProvince_txt.TextChanged,
                AddressID_txt.TextChanged
    End Sub

    Private Sub ListView2_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles Address_ListView.SelectedIndexChanged
        For Each item As ListViewItem In Address_ListView.SelectedItems
            If item.Selected Then
                selectedAddress = addressList.Find(Function(x) x.IDCustomer.Contains(item.SubItems(0).Text))
                AddressID_txt.Text = selectedAddress.IDCustomer
                AddressProvince_txt.Text = selectedAddress.Province
                AddressStreet_txt.Text = selectedAddress.Street
                AddressDistrict_txt.Text = selectedAddress.District


            End If
        Next
    End Sub

    Private Sub RefreshAccountList()

        contactList = cntManagemnet.RetrieveAll()


        Contact_ListView.Clear()
        InitializeListView()
    End Sub

    Private Sub RefreshAddressList()

        addressList = addManagement.RetrieveAll()


        Address_ListView.Clear()
        Address_InitializeListView()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles ContactRegister_btn.Click
        Dim newContact As New Contact
        newContact.ID = ContactID_txt.Text
        newContact.TypeCommunication = ContactType_txt.Text
        newContact.Value = ContactValue_txt.Text


        cntManagemnet.Create(newContact)
        RefreshAccountList()
    End Sub

    Private Sub Address_InitializeListView()
        With _Address_ListView
            .View = View.Details
            .HeaderStyle = ColumnHeaderStyle.Clickable
            .Columns.Clear()
            .Columns.AddRange(
                New ColumnHeader() _
                                 {New ColumnHeader(), New ColumnHeader(), New ColumnHeader(), New ColumnHeader()})
            .Columns.Item(0).Text = "ID"
            .Columns.Item(1).Text = "Province"
            .Columns.Item(2).Text = "Street"
            .Columns.Item(3).Text = "District"
        End With
        addressList = addManagement.RetrieveAll()
        For Each add In addressList
            Address_ListView.Items.Add(
                New ListViewItem(
                    {add.IDCustomer, add.Province, add.Street, add.District}))
        Next
    End Sub

    Private Sub InitializeListView()
        With Contact_ListView
            .View = View.Details
            .HeaderStyle = ColumnHeaderStyle.Clickable
            .Columns.Clear()
            .Columns.AddRange(
                New ColumnHeader() _
                                 {New ColumnHeader(), New ColumnHeader(), New ColumnHeader()})
            .Columns.Item(0).Text = "ID"
            .Columns.Item(1).Text = "Type"
            .Columns.Item(2).Text = "Value"
        End With
        contactList = cntManagemnet.RetrieveAll()
        For Each cnt In contactList
            Contact_ListView.Items.Add(
                New ListViewItem(
                    {cnt.ID, cnt.TypeCommunication, cnt.Value}))
        Next
    End Sub

    Private Sub ContactDelete_btn_Click(sender As Object, e As EventArgs) Handles ContactDelete_btn.Click
        If ContactID_txt.Text IsNot "" Then
            Dim delContact As New Contact
            delContact.ID = ContactID_txt.Text
            cntManagemnet.Delete(delContact)
            RefreshAccountList()

        End If
    End Sub

    Private Sub Contact_ListView_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles Contact_ListView.SelectedIndexChanged
        For Each item As ListViewItem In Contact_ListView.SelectedItems
            If item.Selected Then
                selectedContact = contactList.Find(Function(x) x.ID.Contains(item.SubItems(0).Text))
                ContactID_txt.Text = selectedContact.ID
                ContactType_txt.Text = selectedContact.TypeCommunication
                ContactValue_txt.Text = selectedContact.Value


            End If
        Next
    End Sub

    Private Sub ContactUpdate_btn_Click(sender As Object, e As EventArgs) Handles ContactUpdate_btn.Click
        If ContactID_txt.Text IsNot "" Then
            Dim newContact As New Contact
            newContact.ID = ContactID_txt.Text
            newContact.TypeCommunication = ContactType_txt.Text
            newContact.Value = ContactValue_txt.Text


            cntManagemnet.Update(newContact)
            RefreshAccountList()
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        RefreshAccountList()
    End Sub

    Private Sub AddressRegister_btn_Click(sender As Object, e As EventArgs) Handles AddressRegister_btn.Click
        Dim newAddress As New Address
        newAddress.IDCustomer = AddressID_txt.Text
        newAddress.Province = AddressProvince_txt.Text
        newAddress.Street = AddressStreet_txt.Text
        newAddress.District = AddressDistrict_txt.Text

        addManagement.Create(newAddress)
        RefreshAddressList()
    End Sub

    Private Sub AddressDelete_btn_Click(sender As Object, e As EventArgs) Handles AddressDelete_btn.Click
        If AddressID_txt.Text IsNot "" Then
            Dim delAddress As New Address
            delAddress.IDCustomer = AddressID_txt.Text
            addManagement.Delete(delAddress)
            RefreshAddressList()

        End If
    End Sub

    Private Sub AddressRefresh_btn_Click(sender As Object, e As EventArgs)
        RefreshAddressList()
    End Sub

    Private Sub AddressUpdate_btn_Click(sender As Object, e As EventArgs) Handles AddressUpdate_btn.Click
        If AddressID_txt.Text IsNot "" Then
            Dim newAddress As New Address
            newAddress.IDCustomer = AddressID_txt.Text
            newAddress.Province = AddressProvince_txt.Text
            newAddress.Street = AddressStreet_txt.Text
            newAddress.District = AddressDistrict_txt.Text

            addManagement.Update(newAddress)
            RefreshAddressList()
        End If
    End Sub
End Class
