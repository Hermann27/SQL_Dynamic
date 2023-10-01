
Public Class Form1
    Dim oldEmail As String = Nothing
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim SQL As New SQL_Server_Connexion("localhost", "sa", "@IUC-PA2", "GestionNote")
            Dim requete As String = Nothing
            Try
                If oldEmail = Nothing Then
                    requete = "INSERT INTO " & _
                               " Utilisateur (Email,MotDePasse,Nom,Prenom) " & _
                               "values('" & SQL.ADDSLASHE(txtemail.Text) & "','" & SQL.ADDSLASHE(txtpass.Text) & "','" & SQL.ADDSLASHE(txtnom.Text) & "','" & SQL.ADDSLASHE(txtprenom.Text) & "')"
                Else
                    requete = "Update Utilisateur set " & _
                    "Email='" & SQL.ADDSLASHE(txtemail.Text) & "'," & _
                    "Nom='" & SQL.ADDSLASHE(txtemail.Text) & "'," & _
                    "Prenom='" & SQL.ADDSLASHE(txtemail.Text) & "'," & _
                    "MotDePasse=' " & SQL.ADDSLASHE(txtemail.Text) & "' " & _
                    "WHERE Email='" & SQL.ADDSLASHE(txtemail.Text) & "' "


                End If


                SQL.SetCommand(requete)
                MsgBox("Enregistrement effectuer")
            Catch ex As Exception
                MsgBox("C'EST UTILISATEUR EXISTE DEJA MERCI")
            End Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub txtemail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtemail.TextChanged

    End Sub
    Public Sub cancel()
        txtemail.Text = Nothing
        txtnom.Text = Nothing
        txtprenom.Text = Nothing
        txtpass.Text = Nothing

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cancel()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim QUERY As String = Nothing
        If txtemail.Text IsNot Nothing Then
            Try
                Dim SQL As New SQL_Server_Connexion("localhost", "sa", "@IUC-PA2", "GestionNote")
                QUERY = "DELETE  from Utilisateur where Email='" & SQL.ADDSLASHE(txtemail.Text) & "'"
                SQL.SetCommand(QUERY)
                MsgBox("Suppresion terminer avec sucess", MsgBoxStyle.Critical)
                cancel()
            Catch ex As Exception

                Throw New Exception("Incorrect")
            End Try
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim SQL As New SQL_Server_Connexion("localhost", "sa", "@IUC-PA2", "GestionNote")
            Dim Query As String = "select * from Utilisateur where Email='" & SQL.ADDSLASHE(txtemail.Text) & "'"
            Dim reader = SQL.GetReader(Query)
            While reader.Read
                txtemail.Text = reader("Email").ToString
                txtnom.Text = reader("Nom").ToString
                txtprenom.Text = reader("Prenom").ToString
                txtpass.Text = reader("MotDePasse").ToString
            End While
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub
End Class
