<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMatiere
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
        Me.BtnSup = New System.Windows.Forms.Button
        Me.btnRech = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.BtnEnregistre = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtcode = New System.Windows.Forms.TextBox
        Me.txtgroup = New System.Windows.Forms.TextBox
        Me.txtIntitule = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'BtnSup
        '
        Me.BtnSup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSup.Location = New System.Drawing.Point(253, 150)
        Me.BtnSup.Name = "BtnSup"
        Me.BtnSup.Size = New System.Drawing.Size(75, 23)
        Me.BtnSup.TabIndex = 27
        Me.BtnSup.Text = "Supprimer"
        Me.BtnSup.UseVisualStyleBackColor = True
        '
        'btnRech
        '
        Me.btnRech.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRech.Location = New System.Drawing.Point(8, 150)
        Me.btnRech.Name = "btnRech"
        Me.btnRech.Size = New System.Drawing.Size(64, 23)
        Me.btnRech.TabIndex = 26
        Me.btnRech.Text = "Rechercher"
        Me.btnRech.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(168, 150)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 25
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnEnregistre
        '
        Me.BtnEnregistre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnregistre.Location = New System.Drawing.Point(83, 150)
        Me.BtnEnregistre.Name = "BtnEnregistre"
        Me.BtnEnregistre.Size = New System.Drawing.Size(75, 23)
        Me.BtnEnregistre.TabIndex = 21
        Me.BtnEnregistre.Text = "Enregistrer"
        Me.BtnEnregistre.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Prenom"
        '
        'txtcode
        '
        Me.txtcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcode.Location = New System.Drawing.Point(74, 34)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(254, 20)
        Me.txtcode.TabIndex = 16
        '
        'txtgroup
        '
        Me.txtgroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgroup.Location = New System.Drawing.Point(74, 104)
        Me.txtgroup.Name = "txtgroup"
        Me.txtgroup.Size = New System.Drawing.Size(254, 20)
        Me.txtgroup.TabIndex = 18
        '
        'txtIntitule
        '
        Me.txtIntitule.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntitule.Location = New System.Drawing.Point(74, 71)
        Me.txtIntitule.Name = "txtIntitule"
        Me.txtIntitule.Size = New System.Drawing.Size(254, 20)
        Me.txtIntitule.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Nom"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(98, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 18)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "TABLE_MATIERE"
        '
        'FrmMatiere
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 181)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnSup)
        Me.Controls.Add(Me.btnRech)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnEnregistre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtcode)
        Me.Controls.Add(Me.txtgroup)
        Me.Controls.Add(Me.txtIntitule)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmMatiere"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMatiere"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSup As System.Windows.Forms.Button
    Friend WithEvents btnRech As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnEnregistre As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcode As System.Windows.Forms.TextBox
    Friend WithEvents txtgroup As System.Windows.Forms.TextBox
    Friend WithEvents txtIntitule As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
