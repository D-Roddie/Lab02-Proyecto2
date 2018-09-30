Public Class Form1
    Public Sub New()
        InitializeComponent()
        SidePanel.Height = Customer_btn.Height
        CustomerControl1.BringToFront()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Customer_btn.Click
        SidePanel.Height = Customer_btn.Height
        SidePanel.Top = Customer_btn.Top
        CustomerControl1.BringToFront()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Account_btn.Click
        SidePanel.Height = Account_btn.Height
        SidePanel.Top = Account_btn.Top
        AccountControlv21.BringToFront()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles CtmConfig_btn.Click
        SidePanel.Height = CtmConfig_btn.Height
        SidePanel.Top = CtmConfig_btn.Top
        ContactControl1.BringToFront()
    End Sub
End Class
