Public Class FrmEtudiant_Matiere
    Dim OldMatricule As String = Nothing
    Private Sub btnREM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnREM.Click
        Try
            Dim SQL As New SQL_Server_Connexion("localhost", "sa", "@IUC-PA2", "GestionNote")
            Dim Query As String = "select * from Etudiant_Matiere where Matricule='" & SQL.ADDSLASHE(txtmatricule.Text) & "' "
            Dim reader = SQL.GetReader(Query)
            While reader.Read
                txtmatricule.Text = reader("Matricule").ToString
                txtcodemat.Text = reader("CodeMat").ToString
                Txtnote.Text = reader("Note").ToString
            End While
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub BtnEEM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEEM.Click
        Try
            Dim SQL As New SQL_Server_Connexion("localhost", "sa", "@IUC-PA2", "GestionNote")
            Dim requete As String = Nothing
            Try
                If OldMatricule = Nothing Then
                    requete = "INSERT INTO " & _
                               " Etudiant_Matiere (Matricule,CodeMat,Note) " & _
                               "values('" & SQL.ADDSLASHE(txtmatricule.Text) & "','" & SQL.ADDSLASHE(txtcodemat.Text) & "','" & SQL.ADDSLASHE(Txtnote.Text) & "')"
                Else
                    requete = "Update Etudiant_Matiere set " & _
                    "Matricule='" & SQL.ADDSLASHE(txtmatricule.Text) & "'," & _
                    "CodeMat='" & SQL.ADDSLASHE(txtcodemat.Text) & "'," & _
                    "Note='" & SQL.ADDSLASHE(Txtnote.Text) & "'" 

                End If


                SQL.SetCommand(requete)
                MsgBox("Enregistrement effectuer")
            Catch ex As Exception
                MsgBox("C'EST Enregistrement EXISTE DEJA dans notre base de donnees")
            End Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Sub cancel()
        txtmatricule.Text = Nothing
        txtcodemat.Text = Nothing
        Txtnote.Text = Nothing


    End Sub

    Private Sub BtnCEM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCEM.Click
        cancel()
    End Sub

    Private Sub BtnSEM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSEM.Click
        Dim QUERY As String = Nothing
        If txtmatricule.Text IsNot Nothing Then
            Try
                Dim SQL As New SQL_Server_Connexion("localhost", "sa", "@IUC-PA2", "GestionNote")
                QUERY = "DELETE  from Etudiant_Matiere where CodeMat='" & SQL.ADDSLASHE(txtcodemat.Text) & "'"
                SQL.SetCommand(QUERY)
                MsgBox("Suppresion terminer avec sucess", MsgBoxStyle.Critical)
                cancel()
            Catch ex As Exception

                Throw New Exception("Incorrect")
            End Try
        End If
    End Sub
End Class