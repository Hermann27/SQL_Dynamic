<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAnneeAcademic
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
        Me.TxtAfin = New System.Windows.Forms.TextBox
        Me.BtnSa = New System.Windows.Forms.Button
        Me.btnRa = New System.Windows.Forms.Button
        Me.BtnCa = New System.Windows.Forms.Button
        Me.BtnEa = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtAdebut = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtcodeA = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "AnneeFin"
        '
        'TxtAfin
        '
        Me.TxtAfin.Location = New System.Drawing.Point(138, 107)
        Me.TxtAfin.Name = "TxtAfin"
        Me.TxtAfin.Size = New System.Drawing.Size(179, 20)
        Me.TxtAfin.TabIndex = 48
        '
        'BtnSa
        '
        Me.BtnSa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSa.Location = New System.Drawing.Point(249, 141)
        Me.BtnSa.Name = "BtnSa"
        Me.BtnSa.Size = New System.Drawing.Size(75, 23)
        Me.BtnSa.TabIndex = 47
        Me.BtnSa.Text = "Supprimer"
        Me.BtnSa.UseVisualStyleBackColor = True
        '
        'btnRa
        '
        Me.btnRa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRa.Location = New System.Drawing.Point(12, 141)
        Me.btnRa.Name = "btnRa"
        Me.btnRa.Size = New System.Drawing.Size(64, 23)
        Me.btnRa.TabIndex = 46
        Me.btnRa.Text = "Rechercher"
        Me.btnRa.UseVisualStyleBackColor = True
        '
        'BtnCa
        '
        Me.BtnCa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCa.Location = New System.Drawing.Point(167, 141)
        Me.BtnCa.Name = "BtnCa"
        Me.BtnCa.Size = New System.Drawing.Size(75, 23)
        Me.BtnCa.TabIndex = 45
        Me.BtnCa.Text = "Cancel"
        Me.BtnCa.UseVisualStyleBackColor = True
        '
        'BtnEa
        '
        Me.BtnEa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEa.Location = New System.Drawing.Point(84, 141)
        Me.BtnEa.Name = "BtnEa"
        Me.BtnEa.Size = New System.Drawing.Size(75, 23)
        Me.BtnEa.TabIndex = 43
        Me.BtnEa.Text = "Enregistrer"
        Me.BtnEa.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "AnneeDbut"
        '
        'txtAdebut
        '
        Me.txtAdebut.Location = New System.Drawing.Point(138, 76)
        Me.txtAdebut.Name = "txtAdebut"
        Me.txtAdebut.Size = New System.Drawing.Size(179, 20)
        Me.txtAdebut.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Code"
        '
        'txtcodeA
        '
        Me.txtcodeA.Location = New System.Drawing.Point(138, 40)
        Me.txtcodeA.Name = "txtcodeA"
        Me.txtcodeA.Size = New System.Drawing.Size(179, 20)
        Me.txtcodeA.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 18)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "TABLE_ANNEE_ACADEMIC"
        '
        'FrmAnneeAcademic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 174)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtAfin)
        Me.Controls.Add(Me.BtnSa)
        Me.Controls.Add(Me.btnRa)
        Me.Controls.Add(Me.BtnCa)
        Me.Controls.Add(Me.BtnEa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAdebut)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtcodeA)
        Me.Name = "FrmAnneeAcademic"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAnneeAcademic"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtAfin As System.Windows.Forms.TextBox
    Friend WithEvents BtnSa As System.Windows.Forms.Button
    Friend WithEvents btnRa As System.Windows.Forms.Button
    Friend WithEvents BtnCa As System.Windows.Forms.Button
    Friend WithEvents BtnEa As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAdebut As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcodeA As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
