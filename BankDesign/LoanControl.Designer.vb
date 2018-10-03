<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoanControl
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LoanID_txt = New System.Windows.Forms.TextBox()
        Me.LoanAmount_txt = New System.Windows.Forms.TextBox()
        Me.LoanRate_txt = New System.Windows.Forms.TextBox()
        Me.LoanName_txt = New System.Windows.Forms.TextBox()
        Me.LoanShare_txt = New System.Windows.Forms.TextBox()
        Me.LoanStatus_txt = New System.Windows.Forms.TextBox()
        Me.LoanStartDate_txt = New System.Windows.Forms.TextBox()
        Me.LoanBalanceOperation_txt = New System.Windows.Forms.TextBox()
        Me.LoanRegister_btn = New System.Windows.Forms.Button()
        Me.LoanUpdate_btn = New System.Windows.Forms.Button()
        Me.LoanDelete_btn = New System.Windows.Forms.Button()
        Me.Loan_ListView = New System.Windows.Forms.ListView()
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178,Byte),Integer), CType(CType(8,Byte),Integer), CType(CType(55,Byte),Integer))
        Me.Label1.Location = New System.Drawing.Point(48, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Loans"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
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
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(49, 156)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Amount:"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(49, 204)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Rate:"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(49, 252)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 23)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(49, 300)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 23)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Share:"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(49, 348)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 23)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Start Date:"
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(49, 396)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 23)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Status:"
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(49, 444)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(201, 23)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Balance Operation:"
        '
        'LoanID_txt
        '
        Me.LoanID_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LoanID_txt.Location = New System.Drawing.Point(321, 102)
        Me.LoanID_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.LoanID_txt.Name = "LoanID_txt"
        Me.LoanID_txt.Size = New System.Drawing.Size(177, 29)
        Me.LoanID_txt.TabIndex = 1
        '
        'LoanAmount_txt
        '
        Me.LoanAmount_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LoanAmount_txt.Location = New System.Drawing.Point(321, 150)
        Me.LoanAmount_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.LoanAmount_txt.Name = "LoanAmount_txt"
        Me.LoanAmount_txt.Size = New System.Drawing.Size(177, 29)
        Me.LoanAmount_txt.TabIndex = 1
        '
        'LoanRate_txt
        '
        Me.LoanRate_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LoanRate_txt.Location = New System.Drawing.Point(321, 198)
        Me.LoanRate_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.LoanRate_txt.Name = "LoanRate_txt"
        Me.LoanRate_txt.Size = New System.Drawing.Size(177, 29)
        Me.LoanRate_txt.TabIndex = 1
        '
        'LoanName_txt
        '
        Me.LoanName_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LoanName_txt.Location = New System.Drawing.Point(321, 246)
        Me.LoanName_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.LoanName_txt.Name = "LoanName_txt"
        Me.LoanName_txt.Size = New System.Drawing.Size(177, 29)
        Me.LoanName_txt.TabIndex = 1
        '
        'LoanShare_txt
        '
        Me.LoanShare_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LoanShare_txt.Location = New System.Drawing.Point(321, 294)
        Me.LoanShare_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.LoanShare_txt.Name = "LoanShare_txt"
        Me.LoanShare_txt.Size = New System.Drawing.Size(177, 29)
        Me.LoanShare_txt.TabIndex = 1
        '
        'LoanStatus_txt
        '
        Me.LoanStatus_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LoanStatus_txt.Location = New System.Drawing.Point(321, 390)
        Me.LoanStatus_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.LoanStatus_txt.Name = "LoanStatus_txt"
        Me.LoanStatus_txt.Size = New System.Drawing.Size(177, 29)
        Me.LoanStatus_txt.TabIndex = 1
        '
        'LoanStartDate_txt
        '
        Me.LoanStartDate_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LoanStartDate_txt.Location = New System.Drawing.Point(321, 342)
        Me.LoanStartDate_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.LoanStartDate_txt.Name = "LoanStartDate_txt"
        Me.LoanStartDate_txt.Size = New System.Drawing.Size(177, 29)
        Me.LoanStartDate_txt.TabIndex = 1
        '
        'LoanBalanceOperation_txt
        '
        Me.LoanBalanceOperation_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LoanBalanceOperation_txt.Location = New System.Drawing.Point(321, 438)
        Me.LoanBalanceOperation_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.LoanBalanceOperation_txt.Name = "LoanBalanceOperation_txt"
        Me.LoanBalanceOperation_txt.Size = New System.Drawing.Size(177, 29)
        Me.LoanBalanceOperation_txt.TabIndex = 1
        '
        'LoanRegister_btn
        '
        Me.LoanRegister_btn.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.LoanRegister_btn.FlatAppearance.BorderSize = 3
        Me.LoanRegister_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoanRegister_btn.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LoanRegister_btn.ForeColor = System.Drawing.Color.White
        Me.LoanRegister_btn.Location = New System.Drawing.Point(211, 530)
        Me.LoanRegister_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.LoanRegister_btn.Name = "LoanRegister_btn"
        Me.LoanRegister_btn.Size = New System.Drawing.Size(145, 50)
        Me.LoanRegister_btn.TabIndex = 3
        Me.LoanRegister_btn.Text = "Register"
        Me.LoanRegister_btn.UseVisualStyleBackColor = true
        '
        'LoanUpdate_btn
        '
        Me.LoanUpdate_btn.FlatAppearance.BorderColor = System.Drawing.Color.Olive
        Me.LoanUpdate_btn.FlatAppearance.BorderSize = 3
        Me.LoanUpdate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoanUpdate_btn.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LoanUpdate_btn.ForeColor = System.Drawing.Color.White
        Me.LoanUpdate_btn.Location = New System.Drawing.Point(860, 530)
        Me.LoanUpdate_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.LoanUpdate_btn.Name = "LoanUpdate_btn"
        Me.LoanUpdate_btn.Size = New System.Drawing.Size(145, 50)
        Me.LoanUpdate_btn.TabIndex = 3
        Me.LoanUpdate_btn.Text = "Update"
        Me.LoanUpdate_btn.UseVisualStyleBackColor = true
        '
        'LoanDelete_btn
        '
        Me.LoanDelete_btn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.LoanDelete_btn.FlatAppearance.BorderSize = 3
        Me.LoanDelete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoanDelete_btn.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LoanDelete_btn.ForeColor = System.Drawing.Color.White
        Me.LoanDelete_btn.Location = New System.Drawing.Point(1063, 530)
        Me.LoanDelete_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.LoanDelete_btn.Name = "LoanDelete_btn"
        Me.LoanDelete_btn.Size = New System.Drawing.Size(145, 50)
        Me.LoanDelete_btn.TabIndex = 3
        Me.LoanDelete_btn.Text = "Delete"
        Me.LoanDelete_btn.UseVisualStyleBackColor = true
        '
        'Loan_ListView
        '
        Me.Loan_ListView.Location = New System.Drawing.Point(616, 102)
        Me.Loan_ListView.Name = "Loan_ListView"
        Me.Loan_ListView.Size = New System.Drawing.Size(592, 365)
        Me.Loan_ListView.TabIndex = 4
        Me.Loan_ListView.UseCompatibleStateImageBehavior = false
        '
        'LoanControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41,Byte),Integer), CType(CType(39,Byte),Integer), CType(CType(40,Byte),Integer))
        Me.Controls.Add(Me.Loan_ListView)
        Me.Controls.Add(Me.LoanDelete_btn)
        Me.Controls.Add(Me.LoanUpdate_btn)
        Me.Controls.Add(Me.LoanRegister_btn)
        Me.Controls.Add(Me.LoanStartDate_txt)
        Me.Controls.Add(Me.LoanBalanceOperation_txt)
        Me.Controls.Add(Me.LoanStatus_txt)
        Me.Controls.Add(Me.LoanShare_txt)
        Me.Controls.Add(Me.LoanName_txt)
        Me.Controls.Add(Me.LoanRate_txt)
        Me.Controls.Add(Me.LoanAmount_txt)
        Me.Controls.Add(Me.LoanID_txt)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "LoanControl"
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
    Friend WithEvents Label9 As Label
    Friend WithEvents LoanID_txt As TextBox
    Friend WithEvents LoanAmount_txt As TextBox
    Friend WithEvents LoanRate_txt As TextBox
    Friend WithEvents LoanName_txt As TextBox
    Friend WithEvents LoanShare_txt As TextBox
    Friend WithEvents LoanStatus_txt As TextBox
    Friend WithEvents LoanStartDate_txt As TextBox
    Friend WithEvents LoanBalanceOperation_txt As TextBox
    Friend WithEvents LoanRegister_btn As Button
    Friend WithEvents LoanUpdate_btn As Button
    Friend WithEvents LoanDelete_btn As Button
    Friend WithEvents Loan_ListView As ListView
End Class
