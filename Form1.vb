Public Class Form1
    Dim prix As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listboisson.Items.Add("café")
        Listboisson.Items.Add("jus d'orange")
        Listboisson.Items.Add("Eau minérale")
        Listboisson.Items.Add("citronade")
    End Sub

    Private Sub btncommande_Click(sender As Object, e As EventArgs) Handles btncommande.Click
        Dim commande As String
        If rdpizza.Checked Then
            commande = "pizza"
            prix = 10
        ElseIf rdburger.Checked Then
            commande = "Burger"
            prix = 8
        Else
            commande = "Pates"
            prix = 15
        End If
        For Each ctrl In grsupplement.Controls
            If ctrl.Checked Then
                commande = commande + " " + ctrl.text
                If ctrl.Text = "Fromage" Then
                    prix = prix + 2
                ElseIf ctrl.Text = "Fries" Then
                    prix = prix + 2
                ElseIf ctrl.Text = "Dessert" Then
                    prix = prix + 4
                End If
            End If
        Next
        commande = commande & " " & Listboisson.SelectedItem
        prix = prix + 2
        lblafficher.Text = commande & " total: " & prix
    End Sub

End Class
