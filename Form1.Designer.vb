<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        grplat = New GroupBox()
        rdpates = New RadioButton()
        rdburger = New RadioButton()
        rdpizza = New RadioButton()
        grsupplement = New GroupBox()
        chdessert = New CheckBox()
        chfrites = New CheckBox()
        chfromage = New CheckBox()
        Label1 = New Label()
        Listboisson = New ListBox()
        label = New Label()
        btncommande = New Button()
        btnannuler = New Button()
        lblafficher = New Label()
        grplat.SuspendLayout()
        grsupplement.SuspendLayout()
        SuspendLayout()
        ' 
        ' grplat
        ' 
        grplat.Controls.Add(rdpates)
        grplat.Controls.Add(rdburger)
        grplat.Controls.Add(rdpizza)
        grplat.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grplat.Location = New Point(12, 12)
        grplat.Name = "grplat"
        grplat.Size = New Size(168, 165)
        grplat.TabIndex = 0
        grplat.TabStop = False
        grplat.Text = "choix du plat"
        ' 
        ' rdpates
        ' 
        rdpates.AutoSize = True
        rdpates.Location = New Point(6, 121)
        rdpates.Name = "rdpates"
        rdpates.Size = New Size(84, 32)
        rdpates.TabIndex = 2
        rdpates.TabStop = True
        rdpates.Text = "Pates"
        rdpates.UseVisualStyleBackColor = True
        ' 
        ' rdburger
        ' 
        rdburger.AutoSize = True
        rdburger.Location = New Point(6, 83)
        rdburger.Name = "rdburger"
        rdburger.Size = New Size(97, 32)
        rdburger.TabIndex = 1
        rdburger.TabStop = True
        rdburger.Text = "Burger"
        rdburger.UseVisualStyleBackColor = True
        ' 
        ' rdpizza
        ' 
        rdpizza.AutoSize = True
        rdpizza.Location = New Point(6, 45)
        rdpizza.Name = "rdpizza"
        rdpizza.Size = New Size(82, 32)
        rdpizza.TabIndex = 0
        rdpizza.TabStop = True
        rdpizza.Text = "Pizza"
        rdpizza.UseVisualStyleBackColor = True
        ' 
        ' grsupplement
        ' 
        grsupplement.Controls.Add(chdessert)
        grsupplement.Controls.Add(chfrites)
        grsupplement.Controls.Add(chfromage)
        grsupplement.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grsupplement.Location = New Point(12, 198)
        grsupplement.Name = "grsupplement"
        grsupplement.Size = New Size(168, 176)
        grsupplement.TabIndex = 1
        grsupplement.TabStop = False
        grsupplement.Text = "Supplément"
        ' 
        ' chdessert
        ' 
        chdessert.AutoSize = True
        chdessert.Location = New Point(15, 123)
        chdessert.Name = "chdessert"
        chdessert.Size = New Size(106, 32)
        chdessert.TabIndex = 2
        chdessert.Text = "Dessert"
        chdessert.UseVisualStyleBackColor = True
        ' 
        ' chfrites
        ' 
        chfrites.AutoSize = True
        chfrites.Location = New Point(15, 85)
        chfrites.Name = "chfrites"
        chfrites.Size = New Size(86, 32)
        chfrites.TabIndex = 1
        chfrites.Text = "Frites"
        chfrites.UseVisualStyleBackColor = True
        ' 
        ' chfromage
        ' 
        chfromage.AutoSize = True
        chfromage.Location = New Point(15, 47)
        chfromage.Name = "chfromage"
        chfromage.Size = New Size(116, 32)
        chfromage.TabIndex = 0
        chfromage.Text = "Fromage"
        chfromage.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(306, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 28)
        Label1.TabIndex = 2
        Label1.Text = "Boisson"
        ' 
        ' Listboisson
        ' 
        Listboisson.FormattingEnabled = True
        Listboisson.Location = New Point(395, 38)
        Listboisson.Name = "Listboisson"
        Listboisson.Size = New Size(290, 64)
        Listboisson.TabIndex = 3
        ' 
        ' label
        ' 
        label.AutoSize = True
        label.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label.Location = New Point(320, 143)
        label.Name = "label"
        label.Size = New Size(81, 28)
        label.TabIndex = 4
        label.Text = "Facture"
        ' 
        ' btncommande
        ' 
        btncommande.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btncommande.Location = New Point(353, 279)
        btncommande.Name = "btncommande"
        btncommande.Size = New Size(109, 29)
        btncommande.TabIndex = 5
        btncommande.Text = "commande"
        btncommande.UseVisualStyleBackColor = True
        ' 
        ' btnannuler
        ' 
        btnannuler.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnannuler.Location = New Point(489, 279)
        btnannuler.Name = "btnannuler"
        btnannuler.Size = New Size(94, 29)
        btnannuler.TabIndex = 6
        btnannuler.Text = "annuler"
        btnannuler.UseVisualStyleBackColor = True
        ' 
        ' lblafficher
        ' 
        lblafficher.AutoSize = True
        lblafficher.Location = New Point(442, 231)
        lblafficher.Name = "lblafficher"
        lblafficher.Size = New Size(0, 20)
        lblafficher.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 522)
        Controls.Add(lblafficher)
        Controls.Add(btnannuler)
        Controls.Add(btncommande)
        Controls.Add(label)
        Controls.Add(Listboisson)
        Controls.Add(Label1)
        Controls.Add(grsupplement)
        Controls.Add(grplat)
        Name = "Form1"
        Text = "Form1"
        grplat.ResumeLayout(False)
        grplat.PerformLayout()
        grsupplement.ResumeLayout(False)
        grsupplement.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents grplat As GroupBox
    Friend WithEvents rdpates As RadioButton
    Friend WithEvents rdburger As RadioButton
    Friend WithEvents rdpizza As RadioButton
    Friend WithEvents grsupplement As GroupBox
    Friend WithEvents chdessert As CheckBox
    Friend WithEvents chfrites As CheckBox
    Friend WithEvents chfromage As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Listboisson As ListBox
    Friend WithEvents label As Label
    Friend WithEvents btncommande As Button
    Friend WithEvents btnannuler As Button
    Friend WithEvents lblafficher As Label

End Class
