<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.CtmConfig_btn = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Account_btn = New System.Windows.Forms.Button()
        Me.Customer_btn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ContactControl1 = New BankDesign.ContactControl()
        Me.AccountControlv21 = New BankDesign.AccountControlv2()
        Me.CustomerControl1 = New BankDesign.CustomerControl()
        Me.Panel1.SuspendLayout
        Me.Panel3.SuspendLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel5.SuspendLayout
        Me.SuspendLayout
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41,Byte),Integer), CType(CType(39,Byte),Integer), CType(CType(40,Byte),Integer))
        Me.Panel1.Controls.Add(Me.SidePanel)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.CtmConfig_btn)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Account_btn)
        Me.Panel1.Controls.Add(Me.Customer_btn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(275, 832)
        Me.Panel1.TabIndex = 0
        '
        'SidePanel
        '
        Me.SidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(178,Byte),Integer), CType(CType(8,Byte),Integer), CType(CType(55,Byte),Integer))
        Me.SidePanel.Location = New System.Drawing.Point(0, 64)
        Me.SidePanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(13, 66)
        Me.SidePanel.TabIndex = 4
        '
        'Button6
        '
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"),System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(16, 433)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(259, 66)
        Me.Button6.TabIndex = 4
        Me.Button6.Text = "      Customer"
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button6.UseVisualStyleBackColor = true
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"),System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(16, 359)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(259, 66)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "      Customer"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = true
        '
        'CtmConfig_btn
        '
        Me.CtmConfig_btn.FlatAppearance.BorderSize = 0
        Me.CtmConfig_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CtmConfig_btn.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CtmConfig_btn.ForeColor = System.Drawing.Color.White
        Me.CtmConfig_btn.Image = CType(resources.GetObject("CtmConfig_btn.Image"),System.Drawing.Image)
        Me.CtmConfig_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CtmConfig_btn.Location = New System.Drawing.Point(16, 286)
        Me.CtmConfig_btn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CtmConfig_btn.Name = "CtmConfig_btn"
        Me.CtmConfig_btn.Size = New System.Drawing.Size(259, 66)
        Me.CtmConfig_btn.TabIndex = 4
        Me.CtmConfig_btn.Text = "      Customer         Configuration"
        Me.CtmConfig_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CtmConfig_btn.UseVisualStyleBackColor = true
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"),System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(16, 212)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(259, 66)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "      Balance"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = true
        '
        'Account_btn
        '
        Me.Account_btn.FlatAppearance.BorderSize = 0
        Me.Account_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Account_btn.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Account_btn.ForeColor = System.Drawing.Color.White
        Me.Account_btn.Image = CType(resources.GetObject("Account_btn.Image"),System.Drawing.Image)
        Me.Account_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Account_btn.Location = New System.Drawing.Point(16, 138)
        Me.Account_btn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Account_btn.Name = "Account_btn"
        Me.Account_btn.Size = New System.Drawing.Size(259, 66)
        Me.Account_btn.TabIndex = 4
        Me.Account_btn.Text = "      Account"
        Me.Account_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Account_btn.UseVisualStyleBackColor = true
        '
        'Customer_btn
        '
        Me.Customer_btn.FlatAppearance.BorderSize = 0
        Me.Customer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Customer_btn.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Customer_btn.ForeColor = System.Drawing.Color.White
        Me.Customer_btn.Image = CType(resources.GetObject("Customer_btn.Image"),System.Drawing.Image)
        Me.Customer_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Customer_btn.Location = New System.Drawing.Point(16, 64)
        Me.Customer_btn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Customer_btn.Name = "Customer_btn"
        Me.Customer_btn.Size = New System.Drawing.Size(259, 66)
        Me.Customer_btn.TabIndex = 4
        Me.Customer_btn.Text = "      Customer"
        Me.Customer_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Customer_btn.UseVisualStyleBackColor = true
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(178,Byte),Integer), CType(CType(8,Byte),Integer), CType(CType(55,Byte),Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(275, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1269, 21)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(703, 106)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(178,Byte),Integer), CType(CType(8,Byte),Integer), CType(CType(55,Byte),Integer))
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(317, 1)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(165, 185)
        Me.Panel3.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(20, 134)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Laboratorio"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(17, 106)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cenfo Bank"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"),System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(43, 28)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(79, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = false
        '
        'Button7
        '
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"),System.Drawing.Image)
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(1481, 30)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(47, 38)
        Me.Button7.TabIndex = 4
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button7.UseVisualStyleBackColor = true
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.ContactControl1)
        Me.Panel5.Controls.Add(Me.AccountControlv21)
        Me.Panel5.Controls.Add(Me.CustomerControl1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(275, 212)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1269, 620)
        Me.Panel5.TabIndex = 5
        '
        'ContactControl1
        '
        Me.ContactControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41,Byte),Integer), CType(CType(39,Byte),Integer), CType(CType(40,Byte),Integer))
        Me.ContactControl1.Location = New System.Drawing.Point(0, 0)
        Me.ContactControl1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ContactControl1.Name = "ContactControl1"
        Me.ContactControl1.Size = New System.Drawing.Size(1269, 620)
        Me.ContactControl1.TabIndex = 2
        '
        'AccountControlv21
        '
        Me.AccountControlv21.BackColor = System.Drawing.Color.FromArgb(CType(CType(41,Byte),Integer), CType(CType(39,Byte),Integer), CType(CType(40,Byte),Integer))
        Me.AccountControlv21.Location = New System.Drawing.Point(0, 0)
        Me.AccountControlv21.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.AccountControlv21.Name = "AccountControlv21"
        Me.AccountControlv21.Size = New System.Drawing.Size(1269, 620)
        Me.AccountControlv21.TabIndex = 1
        '
        'CustomerControl1
        '
        Me.CustomerControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41,Byte),Integer), CType(CType(39,Byte),Integer), CType(CType(40,Byte),Integer))
        Me.CustomerControl1.Location = New System.Drawing.Point(0, 0)
        Me.CustomerControl1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.CustomerControl1.Name = "CustomerControl1"
        Me.CustomerControl1.Size = New System.Drawing.Size(1269, 620)
        Me.CustomerControl1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1544, 832)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(false)
        Me.Panel3.ResumeLayout(false)
        Me.Panel3.PerformLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel5.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Customer_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SidePanel As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents CtmConfig_btn As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Account_btn As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents CustomerControl1 As CustomerControl
    Friend WithEvents AccountControlv21 As AccountControlv2
    Friend WithEvents ContactControl1 As ContactControl
End Class
