Public Class Form1

    Dim hargaMakanan As Integer
    Dim hargaMinuman As Integer
    Dim minuman As Boolean

    Private Sub HideMinuman()
        pnlMinuman.Visible = False
        Me.lblPorsiMinuman.Visible = False
        Me.txtMinuman.Visible = False
    End Sub

    Private Sub ShowMinuman()
        pnlMinuman.Visible = True
        Me.lblPorsiMinuman.Visible = True
        Me.txtMinuman.Visible = True
    End Sub

    Private Sub total()
        Dim subMakanan As Integer = Me.hargaMakanan * Integer.Parse(Me.txtMakanan.Text)
        Dim total As Integer

        If Me.minuman = True Then
            Dim subMinuman As Integer = Me.hargaMinuman * Integer.Parse(Me.txtMinuman.Text)
            total = subMakanan + subMinuman
        Else
            total = subMakanan
        End If

        lblTotal.Text = "Rp. " & total.ToString()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.HideMinuman()
        Me.minuman = False
    End Sub

    Private Sub ckMinuman_CheckedChanged(sender As Object, e As EventArgs) Handles ckMinuman.CheckedChanged
        Select Case Me.minuman
            Case True
                Me.minuman = False
                Me.HideMinuman()
            Case False
                Me.minuman = True
                Me.ShowMinuman()
        End Select
    End Sub

    Private Sub cmbMinuman_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMinuman.SelectedIndexChanged
        Select Case Me.cmbMinuman.Text
            Case "Es Jeruk"
                Me.lblHargaMinuman.Text = "Rp. 3000"
                Me.hargaMinuman = 3000
            Case "Jus Alpukat"
                Me.lblHargaMinuman.Text = "Rp. 7000"
                Me.hargaMinuman = 7000
            Case "Teh Manis"
                Me.lblHargaMinuman.Text = "Rp. 4000"
                Me.hargaMinuman = 4000
        End Select
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Me.total()
    End Sub

    Private Sub cmbMakanan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMakanan.SelectedIndexChanged
        Select Case Me.cmbMakanan.Text
            Case "Nasi Uduk"
                Me.lblHargaMakanan.Text = "Rp. 3500"
                Me.hargaMakanan = 3500
            Case "Bakso"
                Me.lblHargaMakanan.Text = "Rp. 6000"
                Me.hargaMakanan = 6000
            Case "Mie Ayam"
                Me.lblHargaMakanan.Text = "Rp. 7000"
                Me.hargaMakanan = 7000
        End Select
    End Sub
End Class
