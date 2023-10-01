<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEtudiant_Matiere
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
        Me.Label5 = New System.Windows.Forms.Label
        Me.Txtnote = New System.Windows.Forms.TextBox
        Me.BtnSEM = New System.Windows.Forms.Button
        Me.btnREM = New System.Windows.Forms.Button
        Me.BtnCEM = New System.Windows.Forms.Button
        Me.BtnEEM = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtcodemat = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtmatricule = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Note"
        '
        'Txtnote
        '
        Me.Txtnote.Location = New System.Drawing.Point(80, 104)
        Me.Txtnote.Name = "Txtnote"
        Me.Txtnote.Size = New System.Drawing.Size(179, 20)
        Me.Txtnote.TabIndex = 58
        '
        'BtnSEM
        '
        Me.BtnSEM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSEM.Location = New System.Drawing.Point(249, 138)
        Me.BtnSEM.Name = "BtnSEM"
        Me.BtnSEM.Size = New System.Drawing.Size(75, 23)
        Me.BtnSEM.TabIndex = 57
        Me.BtnSEM.Text = "Supprimer"
        Me.BtnSEM.UseVisualStyleBackColor = True
        '
        'btnREM
        '
        Me.btnREM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnREM.Location = New System.Drawing.Point(12, 138)
        Me.btnREM.Name = "btnREM"
        Me.btnREM.Size = New System.Drawing.Size(64, 23)
        Me.btnREM.TabIndex = 56
        Me.btnREM.Text = "Rechercher"
        Me.btnREM.UseVisualStyleBackColor = True
        '
        'BtnCEM
        '
        Me.BtnCEM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCEM.Location = New System.Drawing.Point(167, 138)
        Me.BtnCEM.Name = "BtnCEM"
        Me.BtnCEM.Size = New System.Drawing.Size(75, 23)
        Me.BtnCEM.TabIndex = 55
        Me.BtnCEM.Text = "Cancel"
        Me.BtnCEM.UseVisualStyleBackColor = True
        '
        'BtnEEM
        '
        Me.BtnEEM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEEM.Location = New System.Drawing.Point(84, 138)
        Me.BtnEEM.Name = "BtnEEM"
        Me.BtnEEM.Size = New System.Drawing.Size(75, 23)
        Me.BtnEEM.TabIndex = 53
        Me.BtnEEM.Text = "Enregistrer"
        Me.BtnEEM.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "CodeMat"
        '
        'txtcodemat
        '
        Me.txtcodemat.Location = New System.Drawing.Point(80, 73)
        Me.txtcodemat.Name = "txtcodemat"
        Me.txtcodemat.Size = New System.Drawing.Size(179, 20)
        Me.txtcodemat.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Matricule"
        '
        'txtmatricule
        '
        Me.txtmatricule.Location = New System.Drawing.Point(80, 37)
        Me.txtmatricule.Name = "txtmatricule"
        Me.txtmatricule.Size = New System.Drawing.Size(179, 20)
        Me.txtmatricule.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 18)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "TABLE_ETUDIANT_MATIERE"
        '
        'FrmEtudiant_Matiere
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 169)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Txtnote)
        Me.Controls.Add(Me.BtnSEM)
        Me.Controls.Add(Me.btnREM)
        Me.Controls.Add(Me.BtnCEM)
        Me.Controls.Add(Me.BtnEEM)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtcodemat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtmatricule)
        Me.Name = "FrmEtudiant_Matiere"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmEtudiant_Matiere"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Txtnote As System.Windows.Forms.TextBox
    Friend WithEvents BtnSEM As System.Windows.Forms.Button
    Friend WithEvents btnREM As System.Windows.Forms.Button
    Friend WithEvents BtnCEM As System.Windows.Forms.Button
    Friend WithEvents BtnEEM As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcodemat As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtmatricule As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
