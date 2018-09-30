<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.CustomerID_txt = New System.Windows.Forms.TextBox()
        Me.CustomerName_txt = New System.Windows.Forms.TextBox()
        Me.CustomerLastName_txt = New System.Windows.Forms.TextBox()
        Me.CustomerAge_txt = New System.Windows.Forms.TextBox()
        Me.CustomerRegister_btn = New System.Windows.Forms.Button()
        Me.Customer_ListView = New System.Windows.Forms.ListView()
        Me.CustomerUpdate_btn = New System.Windows.Forms.Button()
        Me.CustomerDelete_btn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 100)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 159)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 219)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Last Name: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 278)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Age: "
        '
        'CustomerID_txt
        '
        Me.CustomerID_txt.Location = New System.Drawing.Point(183, 91)
        Me.CustomerID_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomerID_txt.Name = "CustomerID_txt"
        Me.CustomerID_txt.Size = New System.Drawing.Size(132, 22)
        Me.CustomerID_txt.TabIndex = 4
        '
        'CustomerName_txt
        '
        Me.CustomerName_txt.Location = New System.Drawing.Point(183, 150)
        Me.CustomerName_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomerName_txt.Name = "CustomerName_txt"
        Me.CustomerName_txt.Size = New System.Drawing.Size(132, 22)
        Me.CustomerName_txt.TabIndex = 5
        '
        'CustomerLastName_txt
        '
        Me.CustomerLastName_txt.Location = New System.Drawing.Point(183, 210)
        Me.CustomerLastName_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomerLastName_txt.Name = "CustomerLastName_txt"
        Me.CustomerLastName_txt.Size = New System.Drawing.Size(132, 22)
        Me.CustomerLastName_txt.TabIndex = 6
        '
        'CustomerAge_txt
        '
        Me.CustomerAge_txt.Location = New System.Drawing.Point(183, 270)
        Me.CustomerAge_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomerAge_txt.Name = "CustomerAge_txt"
        Me.CustomerAge_txt.Size = New System.Drawing.Size(132, 22)
        Me.CustomerAge_txt.TabIndex = 7
        '
        'CustomerRegister_btn
        '
        Me.CustomerRegister_btn.Location = New System.Drawing.Point(17, 27)
        Me.CustomerRegister_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomerRegister_btn.Name = "CustomerRegister_btn"
        Me.CustomerRegister_btn.Size = New System.Drawing.Size(200, 44)
        Me.CustomerRegister_btn.TabIndex = 8
        Me.CustomerRegister_btn.Text = "Register"
        Me.CustomerRegister_btn.UseVisualStyleBackColor = True
        '
        'Customer_ListView
        '
        Me.Customer_ListView.Location = New System.Drawing.Point(464, 90)
        Me.Customer_ListView.Margin = New System.Windows.Forms.Padding(4)
        Me.Customer_ListView.Name = "Customer_ListView"
        Me.Customer_ListView.Size = New System.Drawing.Size(519, 202)
        Me.Customer_ListView.TabIndex = 9
        Me.Customer_ListView.UseCompatibleStateImageBehavior = False
        '
        'CustomerUpdate_btn
        '
        Me.CustomerUpdate_btn.Location = New System.Drawing.Point(17, 116)
        Me.CustomerUpdate_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomerUpdate_btn.Name = "CustomerUpdate_btn"
        Me.CustomerUpdate_btn.Size = New System.Drawing.Size(200, 44)
        Me.CustomerUpdate_btn.TabIndex = 10
        Me.CustomerUpdate_btn.Text = "Update"
        Me.CustomerUpdate_btn.UseVisualStyleBackColor = True
        '
        'CustomerDelete_btn
        '
        Me.CustomerDelete_btn.Location = New System.Drawing.Point(304, 27)
        Me.CustomerDelete_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomerDelete_btn.Name = "CustomerDelete_btn"
        Me.CustomerDelete_btn.Size = New System.Drawing.Size(200, 44)
        Me.CustomerDelete_btn.TabIndex = 11
        Me.CustomerDelete_btn.Text = "Delete"
        Me.CustomerDelete_btn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.CustomerDelete_btn)
        Me.Panel1.Controls.Add(Me.CustomerUpdate_btn)
        Me.Panel1.Controls.Add(Me.CustomerRegister_btn)
        Me.Panel1.Location = New System.Drawing.Point(464, 309)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(520, 182)
        Me.Panel1.TabIndex = 12
        '
        'CustomerView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Customer_ListView)
        Me.Controls.Add(Me.CustomerAge_txt)
        Me.Controls.Add(Me.CustomerLastName_txt)
        Me.Controls.Add(Me.CustomerName_txt)
        Me.Controls.Add(Me.CustomerID_txt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CustomerView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cenfo Bank"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CustomerID_txt As TextBox
    Friend WithEvents CustomerName_txt As TextBox
    Friend WithEvents CustomerLastName_txt As TextBox
    Friend WithEvents CustomerAge_txt As TextBox
    Friend WithEvents CustomerRegister_btn As Button
    Friend WithEvents Customer_ListView As ListView
    Friend WithEvents CustomerUpdate_btn As Button
    Friend WithEvents CustomerDelete_btn As Button
    Friend WithEvents Panel1 As Panel
End Class
