﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCredit
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LblMensualite = New System.Windows.Forms.Label()
        Me.LblDuree = New System.Windows.Forms.Label()
        Me.LblMontant = New System.Windows.Forms.Label()
        Me.LblTaux = New System.Windows.Forms.Label()
        Me.TxtDuree = New System.Windows.Forms.TextBox()
        Me.TxtMontant = New System.Windows.Forms.TextBox()
        Me.TxtTaux = New System.Windows.Forms.TextBox()
        Me.TxtMensualite = New System.Windows.Forms.TextBox()
        Me.BtnCalculer = New System.Windows.Forms.Button()
        Me.LblMsg = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnEnregistrer = New System.Windows.Forms.Button()
        Me.btnAccueil = New System.Windows.Forms.Button()
        Me.cmdVendreVoit = New System.Windows.Forms.Button()
        Me.cmdAcheterVoiture = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblMensualite
        '
        Me.LblMensualite.AutoSize = True
        Me.LblMensualite.Location = New System.Drawing.Point(244, 73)
        Me.LblMensualite.Name = "LblMensualite"
        Me.LblMensualite.Size = New System.Drawing.Size(63, 13)
        Me.LblMensualite.TabIndex = 0
        Me.LblMensualite.Text = "Mensualités"
        '
        'LblDuree
        '
        Me.LblDuree.AutoSize = True
        Me.LblDuree.Location = New System.Drawing.Point(37, 172)
        Me.LblDuree.Name = "LblDuree"
        Me.LblDuree.Size = New System.Drawing.Size(36, 13)
        Me.LblDuree.TabIndex = 1
        Me.LblDuree.Text = "Durée"
        '
        'LblMontant
        '
        Me.LblMontant.AutoSize = True
        Me.LblMontant.Location = New System.Drawing.Point(37, 69)
        Me.LblMontant.Name = "LblMontant"
        Me.LblMontant.Size = New System.Drawing.Size(46, 13)
        Me.LblMontant.TabIndex = 2
        Me.LblMontant.Text = "Montant"
        '
        'LblTaux
        '
        Me.LblTaux.AutoSize = True
        Me.LblTaux.Location = New System.Drawing.Point(244, 172)
        Me.LblTaux.Name = "LblTaux"
        Me.LblTaux.Size = New System.Drawing.Size(31, 13)
        Me.LblTaux.TabIndex = 3
        Me.LblTaux.Text = "Taux"
        '
        'TxtDuree
        '
        Me.TxtDuree.Location = New System.Drawing.Point(107, 165)
        Me.TxtDuree.Name = "TxtDuree"
        Me.TxtDuree.Size = New System.Drawing.Size(100, 20)
        Me.TxtDuree.TabIndex = 4
        '
        'TxtMontant
        '
        Me.TxtMontant.Location = New System.Drawing.Point(107, 66)
        Me.TxtMontant.Name = "TxtMontant"
        Me.TxtMontant.Size = New System.Drawing.Size(100, 20)
        Me.TxtMontant.TabIndex = 5
        '
        'TxtTaux
        '
        Me.TxtTaux.Location = New System.Drawing.Point(319, 165)
        Me.TxtTaux.Name = "TxtTaux"
        Me.TxtTaux.Size = New System.Drawing.Size(100, 20)
        Me.TxtTaux.TabIndex = 6
        '
        'TxtMensualite
        '
        Me.TxtMensualite.Location = New System.Drawing.Point(319, 66)
        Me.TxtMensualite.Name = "TxtMensualite"
        Me.TxtMensualite.Size = New System.Drawing.Size(100, 20)
        Me.TxtMensualite.TabIndex = 7
        '
        'BtnCalculer
        '
        Me.BtnCalculer.Location = New System.Drawing.Point(40, 263)
        Me.BtnCalculer.Name = "BtnCalculer"
        Me.BtnCalculer.Size = New System.Drawing.Size(75, 23)
        Me.BtnCalculer.TabIndex = 8
        Me.BtnCalculer.Text = "Calculer"
        Me.BtnCalculer.UseVisualStyleBackColor = True
        '
        'LblMsg
        '
        Me.LblMsg.AutoSize = True
        Me.LblMsg.Location = New System.Drawing.Point(316, 263)
        Me.LblMsg.Name = "LblMsg"
        Me.LblMsg.Size = New System.Drawing.Size(0, 13)
        Me.LblMsg.TabIndex = 9
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(132, 263)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 10
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnEnregistrer
        '
        Me.btnEnregistrer.Location = New System.Drawing.Point(235, 263)
        Me.btnEnregistrer.Name = "btnEnregistrer"
        Me.btnEnregistrer.Size = New System.Drawing.Size(75, 23)
        Me.btnEnregistrer.TabIndex = 11
        Me.btnEnregistrer.Text = "Enregister"
        Me.btnEnregistrer.UseVisualStyleBackColor = True
        '
        'btnAccueil
        '
        Me.btnAccueil.Location = New System.Drawing.Point(455, 27)
        Me.btnAccueil.Name = "btnAccueil"
        Me.btnAccueil.Size = New System.Drawing.Size(75, 23)
        Me.btnAccueil.TabIndex = 12
        Me.btnAccueil.Text = "Accueil"
        Me.btnAccueil.UseVisualStyleBackColor = True
        '
        'cmdVendreVoit
        '
        Me.cmdVendreVoit.Location = New System.Drawing.Point(431, 287)
        Me.cmdVendreVoit.Name = "cmdVendreVoit"
        Me.cmdVendreVoit.Size = New System.Drawing.Size(114, 23)
        Me.cmdVendreVoit.TabIndex = 22
        Me.cmdVendreVoit.Text = "Vendre une voiture"
        Me.cmdVendreVoit.UseVisualStyleBackColor = True
        '
        'cmdAcheterVoiture
        '
        Me.cmdAcheterVoiture.Location = New System.Drawing.Point(431, 222)
        Me.cmdAcheterVoiture.Name = "cmdAcheterVoiture"
        Me.cmdAcheterVoiture.Size = New System.Drawing.Size(118, 23)
        Me.cmdAcheterVoiture.TabIndex = 21
        Me.cmdAcheterVoiture.Text = "Acheter une voiture"
        Me.cmdAcheterVoiture.UseVisualStyleBackColor = True
        '
        'FrmCredit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 322)
        Me.Controls.Add(Me.cmdVendreVoit)
        Me.Controls.Add(Me.cmdAcheterVoiture)
        Me.Controls.Add(Me.btnAccueil)
        Me.Controls.Add(Me.btnEnregistrer)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.LblMsg)
        Me.Controls.Add(Me.BtnCalculer)
        Me.Controls.Add(Me.TxtMensualite)
        Me.Controls.Add(Me.TxtTaux)
        Me.Controls.Add(Me.TxtMontant)
        Me.Controls.Add(Me.TxtDuree)
        Me.Controls.Add(Me.LblTaux)
        Me.Controls.Add(Me.LblMontant)
        Me.Controls.Add(Me.LblDuree)
        Me.Controls.Add(Me.LblMensualite)
        Me.Name = "FrmCredit"
        Me.Text = "FrmCredit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblMensualite As System.Windows.Forms.Label
    Friend WithEvents LblDuree As System.Windows.Forms.Label
    Friend WithEvents LblMontant As System.Windows.Forms.Label
    Friend WithEvents LblTaux As System.Windows.Forms.Label
    Friend WithEvents TxtDuree As System.Windows.Forms.TextBox
    Friend WithEvents TxtMontant As System.Windows.Forms.TextBox
    Friend WithEvents TxtTaux As System.Windows.Forms.TextBox
    Friend WithEvents TxtMensualite As System.Windows.Forms.TextBox
    Friend WithEvents BtnCalculer As System.Windows.Forms.Button
    Friend WithEvents LblMsg As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnEnregistrer As System.Windows.Forms.Button
    Friend WithEvents btnAccueil As System.Windows.Forms.Button
    Friend WithEvents cmdVendreVoit As System.Windows.Forms.Button
    Friend WithEvents cmdAcheterVoiture As System.Windows.Forms.Button
End Class
