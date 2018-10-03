<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountControlv2
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
        Me.AccountID_txt = New System.Windows.Forms.TextBox()
        Me.AccountName_txt = New System.Windows.Forms.TextBox()
        Me.AccountCurrency_txt = New System.Windows.Forms.TextBox()
        Me.AccountBalance_txt = New System.Windows.Forms.TextBox()
        Me.AccountRegister_btn = New System.Windows.Forms.Button()
        Me.Account_ListView = New System.Windows.Forms.ListView()
        Me.AccountDelete_btn = New System.Windows.Forms.Button()
        Me.AccountUpdate_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178,Byte),Integer), CType(CType(8,Byte),Integer), CType(CType(55,Byte),Integer))
        Me.Label1.Location = New System.Drawing.Point(36, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Account Management"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(37, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(37, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(37, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Currency"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(37, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Balance"
        '
        'AccountID_txt
        '
        Me.AccountID_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AccountID_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.AccountID_txt.Location = New System.Drawing.Point(174, 144)
        Me.AccountID_txt.Name = "AccountID_txt"
        Me.AccountID_txt.Size = New System.Drawing.Size(134, 24)
        Me.AccountID_txt.TabIndex = 1
        '
        'AccountName_txt
        '
        Me.AccountName_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AccountName_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.AccountName_txt.Location = New System.Drawing.Point(174, 183)
        Me.AccountName_txt.Name = "AccountName_txt"
        Me.AccountName_txt.Size = New System.Drawing.Size(134, 24)
        Me.AccountName_txt.TabIndex = 1
        '
        'AccountCurrency_txt
        '
        Me.AccountCurrency_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AccountCurrency_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.AccountCurrency_txt.Location = New System.Drawing.Point(174, 222)
        Me.AccountCurrency_txt.Name = "AccountCurrency_txt"
        Me.AccountCurrency_txt.Size = New System.Drawing.Size(134, 24)
        Me.AccountCurrency_txt.TabIndex = 1
        '
        'AccountBalance_txt
        '
        Me.AccountBalance_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AccountBalance_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.AccountBalance_txt.Location = New System.Drawing.Point(174, 261)
        Me.AccountBalance_txt.Name = "AccountBalance_txt"
        Me.AccountBalance_txt.Size = New System.Drawing.Size(134, 24)
        Me.AccountBalance_txt.TabIndex = 1
        '
        'AccountRegister_btn
        '
        Me.AccountRegister_btn.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.AccountRegister_btn.FlatAppearance.BorderSize = 3
        Me.AccountRegister_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AccountRegister_btn.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.AccountRegister_btn.ForeColor = System.Drawing.Color.White
        Me.AccountRegister_btn.Location = New System.Drawing.Point(95, 392)
        Me.AccountRegister_btn.Name = "AccountRegister_btn"
        Me.AccountRegister_btn.Size = New System.Drawing.Size(109, 41)
        Me.AccountRegister_btn.TabIndex = 2
        Me.AccountRegister_btn.Text = "Register"
        Me.AccountRegister_btn.UseVisualStyleBackColor = true
        '
        'Account_ListView
        '
        Me.Account_ListView.Location = New System.Drawing.Point(459, 83)
        Me.Account_ListView.Name = "Account_ListView"
        Me.Account_ListView.Size = New System.Drawing.Size(416, 258)
        Me.Account_ListView.TabIndex = 3
        Me.Account_ListView.UseCompatibleStateImageBehavior = false
        '
        'AccountDelete_btn
        '
        Me.AccountDelete_btn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.AccountDelete_btn.FlatAppearance.BorderSize = 3
        Me.AccountDelete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AccountDelete_btn.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.AccountDelete_btn.ForeColor = System.Drawing.Color.White
        Me.AccountDelete_btn.Location = New System.Drawing.Point(765, 392)
        Me.AccountDelete_btn.Name = "AccountDelete_btn"
        Me.AccountDelete_btn.Size = New System.Drawing.Size(109, 41)
        Me.AccountDelete_btn.TabIndex = 2
        Me.AccountDelete_btn.Text = "Delete"
        Me.AccountDelete_btn.UseVisualStyleBackColor = true
        '
        'AccountUpdate_btn
        '
        Me.AccountUpdate_btn.FlatAppearance.BorderColor = System.Drawing.Color.Olive
        Me.AccountUpdate_btn.FlatAppearance.BorderSize = 3
        Me.AccountUpdate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AccountUpdate_btn.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.AccountUpdate_btn.ForeColor = System.Drawing.Color.White
        Me.AccountUpdate_btn.Location = New System.Drawing.Point(459, 392)
        Me.AccountUpdate_btn.Name = "AccountUpdate_btn"
        Me.AccountUpdate_btn.Size = New System.Drawing.Size(109, 41)
        Me.AccountUpdate_btn.TabIndex = 2
        Me.AccountUpdate_btn.Text = "Update"
        Me.AccountUpdate_btn.UseVisualStyleBackColor = true
        '
        'AccountControlv2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41,Byte),Integer), CType(CType(39,Byte),Integer), CType(CType(40,Byte),Integer))
        Me.Controls.Add(Me.Account_ListView)
        Me.Controls.Add(Me.AccountDelete_btn)
        Me.Controls.Add(Me.AccountUpdate_btn)
        Me.Controls.Add(Me.AccountRegister_btn)
        Me.Controls.Add(Me.AccountBalance_txt)
        Me.Controls.Add(Me.AccountCurrency_txt)
        Me.Controls.Add(Me.AccountName_txt)
        Me.Controls.Add(Me.AccountID_txt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AccountControlv2"
        Me.Size = New System.Drawing.Size(952, 504)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents AccountID_txt As TextBox
    Friend WithEvents AccountName_txt As TextBox
    Friend WithEvents AccountCurrency_txt As TextBox
    Friend WithEvents AccountBalance_txt As TextBox
    Friend WithEvents AccountRegister_btn As Button
    Friend WithEvents Account_ListView As ListView
    Friend WithEvents AccountDelete_btn As Button
    Friend WithEvents AccountUpdate_btn As Button
End Class
