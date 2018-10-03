<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContactControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ContactID_txt = New System.Windows.Forms.TextBox()
        Me.Contact_ListView = New System.Windows.Forms.ListView()
        Me.Address_ListView = New System.Windows.Forms.ListView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ContactType_txt = New System.Windows.Forms.TextBox()
        Me.ContactValue_txt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.AddressID_txt = New System.Windows.Forms.TextBox()
        Me.AddressProvince_txt = New System.Windows.Forms.TextBox()
        Me.AddressStreet_txt = New System.Windows.Forms.TextBox()
        Me.AddressDistrict_txt = New System.Windows.Forms.TextBox()
        Me.AddressUpdate_btn = New System.Windows.Forms.Button()
        Me.AddressDelete_btn = New System.Windows.Forms.Button()
        Me.ContactUpdate_btn = New System.Windows.Forms.Button()
        Me.ContactDelete_btn = New System.Windows.Forms.Button()
        Me.ContactRegister_btn = New System.Windows.Forms.Button()
        Me.AddressRegister_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178,Byte),Integer), CType(CType(8,Byte),Integer), CType(CType(55,Byte),Integer))
        Me.Label1.Location = New System.Drawing.Point(36, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contact"
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(37, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 19)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Contact ID"
        '
        'ContactID_txt
        '
        Me.ContactID_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ContactID_txt.Location = New System.Drawing.Point(174, 83)
        Me.ContactID_txt.Name = "ContactID_txt"
        Me.ContactID_txt.Size = New System.Drawing.Size(134, 24)
        Me.ContactID_txt.TabIndex = 1
        '
        'Contact_ListView
        '
        Me.Contact_ListView.Location = New System.Drawing.Point(40, 320)
        Me.Contact_ListView.Name = "Contact_ListView"
        Me.Contact_ListView.Size = New System.Drawing.Size(333, 127)
        Me.Contact_ListView.TabIndex = 3
        Me.Contact_ListView.UseCompatibleStateImageBehavior = false
        '
        'Address_ListView
        '
        Me.Address_ListView.Location = New System.Drawing.Point(531, 320)
        Me.Address_ListView.Name = "Address_ListView"
        Me.Address_ListView.Size = New System.Drawing.Size(332, 127)
        Me.Address_ListView.TabIndex = 3
        Me.Address_ListView.UseCompatibleStateImageBehavior = false
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(37, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Type "
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(37, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Value"
        '
        'ContactType_txt
        '
        Me.ContactType_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ContactType_txt.Location = New System.Drawing.Point(174, 122)
        Me.ContactType_txt.Name = "ContactType_txt"
        Me.ContactType_txt.Size = New System.Drawing.Size(134, 24)
        Me.ContactType_txt.TabIndex = 1
        '
        'ContactValue_txt
        '
        Me.ContactValue_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ContactValue_txt.Location = New System.Drawing.Point(174, 161)
        Me.ContactValue_txt.Name = "ContactValue_txt"
        Me.ContactValue_txt.Size = New System.Drawing.Size(134, 24)
        Me.ContactValue_txt.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178,Byte),Integer), CType(CType(8,Byte),Integer), CType(CType(55,Byte),Integer))
        Me.Label5.Location = New System.Drawing.Point(526, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(527, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Address ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(527, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Province"
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(527, 167)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 19)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Street"
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(527, 206)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 19)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "District"
        '
        'AddressID_txt
        '
        Me.AddressID_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.AddressID_txt.Location = New System.Drawing.Point(664, 83)
        Me.AddressID_txt.Name = "AddressID_txt"
        Me.AddressID_txt.Size = New System.Drawing.Size(134, 24)
        Me.AddressID_txt.TabIndex = 1
        '
        'AddressProvince_txt
        '
        Me.AddressProvince_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.AddressProvince_txt.Location = New System.Drawing.Point(664, 122)
        Me.AddressProvince_txt.Name = "AddressProvince_txt"
        Me.AddressProvince_txt.Size = New System.Drawing.Size(134, 24)
        Me.AddressProvince_txt.TabIndex = 1
        '
        'AddressStreet_txt
        '
        Me.AddressStreet_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.AddressStreet_txt.Location = New System.Drawing.Point(664, 161)
        Me.AddressStreet_txt.Name = "AddressStreet_txt"
        Me.AddressStreet_txt.Size = New System.Drawing.Size(134, 24)
        Me.AddressStreet_txt.TabIndex = 1
        '
        'AddressDistrict_txt
        '
        Me.AddressDistrict_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.AddressDistrict_txt.Location = New System.Drawing.Point(664, 200)
        Me.AddressDistrict_txt.Name = "AddressDistrict_txt"
        Me.AddressDistrict_txt.Size = New System.Drawing.Size(134, 24)
        Me.AddressDistrict_txt.TabIndex = 1
        '
        'AddressUpdate_btn
        '
        Me.AddressUpdate_btn.FlatAppearance.BorderColor = System.Drawing.Color.Olive
        Me.AddressUpdate_btn.FlatAppearance.BorderSize = 3
        Me.AddressUpdate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddressUpdate_btn.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.AddressUpdate_btn.ForeColor = System.Drawing.Color.White
        Me.AddressUpdate_btn.Location = New System.Drawing.Point(531, 453)
        Me.AddressUpdate_btn.Name = "AddressUpdate_btn"
        Me.AddressUpdate_btn.Size = New System.Drawing.Size(109, 41)
        Me.AddressUpdate_btn.TabIndex = 4
        Me.AddressUpdate_btn.Text = "Update"
        Me.AddressUpdate_btn.UseVisualStyleBackColor = true
        '
        'AddressDelete_btn
        '
        Me.AddressDelete_btn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.AddressDelete_btn.FlatAppearance.BorderSize = 3
        Me.AddressDelete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddressDelete_btn.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.AddressDelete_btn.ForeColor = System.Drawing.Color.White
        Me.AddressDelete_btn.Location = New System.Drawing.Point(754, 453)
        Me.AddressDelete_btn.Name = "AddressDelete_btn"
        Me.AddressDelete_btn.Size = New System.Drawing.Size(109, 41)
        Me.AddressDelete_btn.TabIndex = 4
        Me.AddressDelete_btn.Text = "Delete"
        Me.AddressDelete_btn.UseVisualStyleBackColor = true
        '
        'ContactUpdate_btn
        '
        Me.ContactUpdate_btn.FlatAppearance.BorderColor = System.Drawing.Color.Olive
        Me.ContactUpdate_btn.FlatAppearance.BorderSize = 3
        Me.ContactUpdate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ContactUpdate_btn.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ContactUpdate_btn.ForeColor = System.Drawing.Color.White
        Me.ContactUpdate_btn.Location = New System.Drawing.Point(40, 453)
        Me.ContactUpdate_btn.Name = "ContactUpdate_btn"
        Me.ContactUpdate_btn.Size = New System.Drawing.Size(109, 41)
        Me.ContactUpdate_btn.TabIndex = 4
        Me.ContactUpdate_btn.Text = "Update"
        Me.ContactUpdate_btn.UseVisualStyleBackColor = true
        '
        'ContactDelete_btn
        '
        Me.ContactDelete_btn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.ContactDelete_btn.FlatAppearance.BorderSize = 3
        Me.ContactDelete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ContactDelete_btn.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ContactDelete_btn.ForeColor = System.Drawing.Color.White
        Me.ContactDelete_btn.Location = New System.Drawing.Point(264, 453)
        Me.ContactDelete_btn.Name = "ContactDelete_btn"
        Me.ContactDelete_btn.Size = New System.Drawing.Size(109, 41)
        Me.ContactDelete_btn.TabIndex = 4
        Me.ContactDelete_btn.Text = "Delete"
        Me.ContactDelete_btn.UseVisualStyleBackColor = true
        '
        'ContactRegister_btn
        '
        Me.ContactRegister_btn.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.ContactRegister_btn.FlatAppearance.BorderSize = 3
        Me.ContactRegister_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ContactRegister_btn.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ContactRegister_btn.ForeColor = System.Drawing.Color.White
        Me.ContactRegister_btn.Location = New System.Drawing.Point(145, 250)
        Me.ContactRegister_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.ContactRegister_btn.Name = "ContactRegister_btn"
        Me.ContactRegister_btn.Size = New System.Drawing.Size(109, 41)
        Me.ContactRegister_btn.TabIndex = 6
        Me.ContactRegister_btn.Text = "Register"
        Me.ContactRegister_btn.UseVisualStyleBackColor = true
        '
        'AddressRegister_btn
        '
        Me.AddressRegister_btn.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.AddressRegister_btn.FlatAppearance.BorderSize = 3
        Me.AddressRegister_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddressRegister_btn.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.AddressRegister_btn.ForeColor = System.Drawing.Color.White
        Me.AddressRegister_btn.Location = New System.Drawing.Point(634, 250)
        Me.AddressRegister_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.AddressRegister_btn.Name = "AddressRegister_btn"
        Me.AddressRegister_btn.Size = New System.Drawing.Size(109, 41)
        Me.AddressRegister_btn.TabIndex = 6
        Me.AddressRegister_btn.Text = "Register"
        Me.AddressRegister_btn.UseVisualStyleBackColor = true
        '
        'ContactControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41,Byte),Integer), CType(CType(39,Byte),Integer), CType(CType(40,Byte),Integer))
        Me.Controls.Add(Me.AddressRegister_btn)
        Me.Controls.Add(Me.ContactRegister_btn)
        Me.Controls.Add(Me.ContactDelete_btn)
        Me.Controls.Add(Me.AddressDelete_btn)
        Me.Controls.Add(Me.ContactUpdate_btn)
        Me.Controls.Add(Me.AddressUpdate_btn)
        Me.Controls.Add(Me.Address_ListView)
        Me.Controls.Add(Me.Contact_ListView)
        Me.Controls.Add(Me.AddressDistrict_txt)
        Me.Controls.Add(Me.AddressStreet_txt)
        Me.Controls.Add(Me.ContactValue_txt)
        Me.Controls.Add(Me.AddressProvince_txt)
        Me.Controls.Add(Me.ContactType_txt)
        Me.Controls.Add(Me.AddressID_txt)
        Me.Controls.Add(Me.ContactID_txt)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ContactControl"
        Me.Size = New System.Drawing.Size(952, 504)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ContactID_txt As TextBox
    Friend WithEvents Contact_ListView As ListView
    Friend WithEvents Address_ListView As ListView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ContactType_txt As TextBox
    Friend WithEvents ContactValue_txt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents AddressID_txt As TextBox
    Friend WithEvents AddressProvince_txt As TextBox
    Friend WithEvents AddressStreet_txt As TextBox
    Friend WithEvents AddressDistrict_txt As TextBox
    Friend WithEvents AddressUpdate_btn As Button
    Friend WithEvents AddressDelete_btn As Button
    Friend WithEvents ContactUpdate_btn As Button
    Friend WithEvents ContactDelete_btn As Button
    Friend WithEvents ContactRegister_btn As Button
    Friend WithEvents AddressRegister_btn As Button
End Class
