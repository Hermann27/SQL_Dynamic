Public Class FrmAnneeAcademic

    Private Sub btnRa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRa.Click
        Try
            Dim SQL As New SQL_Server_Connexion("localhost", "sa", "@IUC-PA2", "GestionNote")
            Dim Query As String = "select * from AnneeAcademic where Code='" & SQL.ADDSLASHE(txtcodeA.Text) & "' "
            Dim reader = SQL.GetReader(Query)
            While reader.Read
                txtcodeA.Text = reader("Code").ToString
                txtAdebut.Text = reader("AnneeDebut").ToString
                TxtAfin.Text = reader("AnneFin").ToString
            End While
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class