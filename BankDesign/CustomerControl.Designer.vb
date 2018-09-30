<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerControl
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CustomerID_txt = New System.Windows.Forms.TextBox()
        Me.CustomerName_txt = New System.Windows.Forms.TextBox()
        Me.CustomerLastName_txt = New System.Windows.Forms.TextBox()
        Me.CustomerGender_txt = New System.Windows.Forms.TextBox()
        Me.CustomerAge_txt = New System.Windows.Forms.TextBox()
        Me.CustomerBirthday_txt = New System.Windows.Forms.TextBox()
        Me.CustomerSocialStatus_txt = New System.Windows.Forms.TextBox()
        Me.Customer_ListView = New System.Windows.Forms.ListView()
        Me.CustomerRegister_btn = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CustomerUpdateLock = New System.Windows.Forms.Button()
        Me.CustomerDelete_Lock = New System.Windows.Forms.Button()
        Me.CustomerUpdateSecond = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.CustomerLock_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(325, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Management"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 108)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(49, 156)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(49, 204)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Last Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(49, 252)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 23)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Birthday:"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(49, 300)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 23)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Age:"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(49, 348)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 23)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Social Status:"
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(49, 396)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 23)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Gender:"
        '
        'CustomerID_txt
        '
        Me.CustomerID_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomerID_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CustomerID_txt.ForeColor = System.Drawing.SystemColors.Desktop
        Me.CustomerID_txt.Location = New System.Drawing.Point(232, 102)
        Me.CustomerID_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomerID_txt.Name = "CustomerID_txt"
        Me.CustomerID_txt.Size = New System.Drawing.Size(178, 29)
        Me.CustomerID_txt.TabIndex = 2
        '
        'CustomerName_txt
        '
        Me.CustomerName_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomerName_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CustomerName_txt.ForeColor = System.Drawing.SystemColors.Desktop
        Me.CustomerName_txt.Location = New System.Drawing.Point(232, 150)
        Me.CustomerName_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomerName_txt.Name = "CustomerName_txt"
        Me.CustomerName_txt.Size = New System.Drawing.Size(178, 29)
        Me.CustomerName_txt.TabIndex = 2
        '
        'CustomerLastName_txt
        '
        Me.CustomerLastName_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomerLastName_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CustomerLastName_txt.ForeColor = System.Drawing.SystemColors.Desktop
        Me.CustomerLastName_txt.Location = New System.Drawing.Point(232, 198)
        Me.CustomerLastName_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomerLastName_txt.Name = "CustomerLastName_txt"
        Me.CustomerLastName_txt.Size = New System.Drawing.Size(178, 29)
        Me.CustomerLastName_txt.TabIndex = 2
        '
        'CustomerGender_txt
        '
        Me.CustomerGender_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomerGender_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CustomerGender_txt.ForeColor = System.Drawing.SystemColors.Desktop
        Me.CustomerGender_txt.Location = New System.Drawing.Point(232, 390)
        Me.CustomerGender_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomerGender_txt.Name = "CustomerGender_txt"
        Me.CustomerGender_txt.Size = New System.Drawing.Size(178, 29)
        Me.CustomerGender_txt.TabIndex = 2
        '
        'CustomerAge_txt
        '
        Me.CustomerAge_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomerAge_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CustomerAge_txt.ForeColor = System.Drawing.SystemColors.Desktop
        Me.CustomerAge_txt.Location = New System.Drawing.Point(232, 294)
        Me.CustomerAge_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomerAge_txt.Name = "CustomerAge_txt"
        Me.CustomerAge_txt.Size = New System.Drawing.Size(178, 29)
        Me.CustomerAge_txt.TabIndex = 2
        '
        'CustomerBirthday_txt
        '
        Me.CustomerBirthday_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomerBirthday_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CustomerBirthday_txt.ForeColor = System.Drawing.SystemColors.Desktop
        Me.CustomerBirthday_txt.Location = New System.Drawing.Point(232, 246)
        Me.CustomerBirthday_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomerBirthday_txt.Name = "CustomerBirthday_txt"
        Me.CustomerBirthday_txt.Size = New System.Drawing.Size(178, 29)
        Me.CustomerBirthday_txt.TabIndex = 2
        '
        'CustomerSocialStatus_txt
        '
        Me.CustomerSocialStatus_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomerSocialStatus_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CustomerSocialStatus_txt.ForeColor = System.Drawing.SystemColors.Desktop
        Me.CustomerSocialStatus_txt.Location = New System.Drawing.Point(232, 342)
        Me.CustomerSocialStatus_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomerSocialStatus_txt.Name = "CustomerSocialStatus_txt"
        Me.CustomerSocialStatus_txt.Size = New System.Drawing.Size(178, 29)
        Me.CustomerSocialStatus_txt.TabIndex = 2
        '
        'Customer_ListView
        '
        Me.Customer_ListView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Customer_ListView.Location = New System.Drawing.Point(612, 102)
        Me.Customer_ListView.Margin = New System.Windows.Forms.Padding(4)
        Me.Customer_ListView.Name = "Customer_ListView"
        Me.Customer_ListView.Size = New System.Drawing.Size(555, 318)
        Me.Customer_ListView.TabIndex = 3
        Me.Customer_ListView.UseCompatibleStateImageBehavior = false
        '
        'CustomerRegister_btn
        '
        Me.CustomerRegister_btn.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.CustomerRegister_btn.FlatAppearance.BorderSize = 3
        Me.CustomerRegister_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CustomerRegister_btn.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CustomerRegister_btn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.CustomerRegister_btn.Location = New System.Drawing.Point(153, 462)
        Me.CustomerRegister_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomerRegister_btn.Name = "CustomerRegister_btn"
        Me.CustomerRegister_btn.Size = New System.Drawing.Size(145, 50)
        Me.CustomerRegister_btn.TabIndex = 4
        Me.CustomerRegister_btn.Text = "Register"
        Me.CustomerRegister_btn.UseVisualStyleBackColor = true
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178,Byte),Integer), CType(CType(8,Byte),Integer), CType(CType(55,Byte),Integer))
        Me.Label9.Location = New System.Drawing.Point(48, 41)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(325, 32)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Customer Management"
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(49, 108)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 23)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "ID:"
        '
        'CustomerUpdateLock
        '
        Me.CustomerUpdateLock.FlatAppearance.BorderColor = System.Drawing.Color.Olive
        Me.CustomerUpdateLock.FlatAppearance.BorderSize = 3
        Me.CustomerUpdateLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CustomerUpdateLock.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CustomerUpdateLock.ForeColor = System.Drawing.Color.White
        Me.CustomerUpdateLock.Location = New System.Drawing.Point(612, 462)
        Me.CustomerUpdateLock.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomerUpdateLock.Name = "CustomerUpdateLock"
        Me.CustomerUpdateLock.Size = New System.Drawing.Size(145, 50)
        Me.CustomerUpdateLock.TabIndex = 4
        Me.CustomerUpdateLock.Text = "Update"
        Me.CustomerUpdateLock.UseVisualStyleBackColor = true
        '
        'CustomerDelete_Lock
        '
        Me.CustomerDelete_Lock.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.CustomerDelete_Lock.FlatAppearance.BorderSize = 3
        Me.CustomerDelete_Lock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CustomerDelete_Lock.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CustomerDelete_Lock.ForeColor = System.Drawing.Color.White
        Me.CustomerDelete_Lock.Location = New System.Drawing.Point(1022, 462)
        Me.CustomerDelete_Lock.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomerDelete_Lock.Name = "CustomerDelete_Lock"
        Me.CustomerDelete_Lock.Size = New System.Drawing.Size(145, 50)
        Me.CustomerDelete_Lock.TabIndex = 4
        Me.CustomerDelete_Lock.Text = "Delete"
        Me.CustomerDelete_Lock.UseVisualStyleBackColor = true
        '
        'CustomerUpdateSecond
        '
        Me.CustomerUpdateSecond.FlatAppearance.BorderColor = System.Drawing.Color.Olive
        Me.CustomerUpdateSecond.FlatAppearance.BorderSize = 3
        Me.CustomerUpdateSecond.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CustomerUpdateSecond.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CustomerUpdateSecond.ForeColor = System.Drawing.Color.White
        Me.CustomerUpdateSecond.Location = New System.Drawing.Point(765, 462)
        Me.CustomerUpdateSecond.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomerUpdateSecond.Name = "CustomerUpdateSecond"
        Me.CustomerUpdateSecond.Size = New System.Drawing.Size(145, 50)
        Me.CustomerUpdateSecond.TabIndex = 4
        Me.CustomerUpdateSecond.Text = "Update"
        Me.CustomerUpdateSecond.UseVisualStyleBackColor = true
        '
        'CustomerLock_btn
        '
        Me.CustomerLock_btn.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.CustomerLock_btn.FlatAppearance.BorderSize = 3
        Me.CustomerLock_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CustomerLock_btn.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CustomerLock_btn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.CustomerLock_btn.Location = New System.Drawing.Point(153, 462)
        Me.CustomerLock_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomerLock_btn.Name = "CustomerLock_btn"
        Me.CustomerLock_btn.Size = New System.Drawing.Size(145, 50)
        Me.CustomerLock_btn.TabIndex = 4
        Me.CustomerLock_btn.Text = "Register"
        Me.CustomerLock_btn.UseVisualStyleBackColor = true
        '
        'CustomerControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41,Byte),Integer), CType(CType(39,Byte),Integer), CType(CType(40,Byte),Integer))
        Me.Controls.Add(Me.CustomerUpdateLock)
        Me.Controls.Add(Me.CustomerDelete_Lock)
        Me.Controls.Add(Me.CustomerUpdateSecond)
        Me.Controls.Add(Me.CustomerLock_btn)
        Me.Controls.Add(Me.CustomerRegister_btn)
        Me.Controls.Add(Me.Customer_ListView)
        Me.Controls.Add(Me.CustomerGender_txt)
        Me.Controls.Add(Me.CustomerBirthday_txt)
        Me.Controls.Add(Me.CustomerSocialStatus_txt)
        Me.Controls.Add(Me.CustomerAge_txt)
        Me.Controls.Add(Me.CustomerLastName_txt)
        Me.Controls.Add(Me.CustomerName_txt)
        Me.Controls.Add(Me.CustomerID_txt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CustomerControl"
        Me.Size = New System.Drawing.Size(1269, 620)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CustomerID_txt As TextBox
    Friend WithEvents CustomerName_txt As TextBox
    Friend WithEvents CustomerLastName_txt As TextBox
    Friend WithEvents CustomerGender_txt As TextBox
    Friend WithEvents CustomerAge_txt As TextBox
    Friend WithEvents CustomerBirthday_txt As TextBox
    Friend WithEvents CustomerSocialStatus_txt As TextBox
    Friend WithEvents Customer_ListView As ListView
    Friend WithEvents CustomerRegister_btn As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents CustomerUpdateLock As Button
    Friend WithEvents CustomerDelete_Lock As Button
    Friend WithEvents CustomerUpdateSecond As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents CustomerLock_btn As Button
End Class
