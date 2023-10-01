Imports System.Data.SqlClient
Public Class SQL_Server_Connexion
    Private Shared _ConStr As String = Nothing
    Private _Serveur As String = "localhost"
    Private _IdUtilisateur As String = "root"
    Private _MotDePasse As String = Nothing
    Private _Bd As String = Nothing
    Shared ReadOnly Property chaine() As String
        Get
            Return _ConStr
        End Get
    End Property
    Sub New(ByVal Serveur As String, ByVal Utilisateur As String, ByVal MotDePasse As String, ByVal BaseDonnees As String)
        Me._Serveur = Serveur
        Me._IdUtilisateur = Utilisateur
        If BaseDonnees Is Nothing Then
            MsgBox("Aucune Base de donnee trouve")
        Else
            Me._Bd = BaseDonnees
            If MotDePasse Is Nothing Then
                _ConStr = "data Source=" & Me._Serveur & " ; User id=" & Me._IdUtilisateur & " ; initial catalog=" & Me._Bd
                MsgBox("Authentification sans mot de passe reussi")
            Else
                Me._MotDePasse = MotDePasse
                _ConStr = "data Source= " & Me._Serveur & "; User id=" & Me._IdUtilisateur & "; PASSWORD=" & Me._MotDePasse & ";initial catalog=" & Me._Bd
                MsgBox("AYTHENDIFICATION REUSSI AVEC SUCCES")
            End If
        End If
    End Sub
    Public Function GetConnexion() As SqlConnection
        MsgBox(chaine)
        Dim connec As New SqlConnection(chaine)
        Try
            connec.Open()
            Return connec
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

    Public Sub SetCommand(ByVal Query As String)
        Dim Cmd As SqlCommand = Nothing
        Dim con As SqlConnection = GetConnexion()
        Try

            Cmd = New SqlCommand(Query, con)
            Cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            Con.close()
        End Try
    End Sub

    Public Function ADDSLASHE(ByVal chainne As String) As String
        If chainne IsNot Nothing Then
            chainne = chainne.Replace("'", " '' ").Replace("\", "\\")
        End If
        Return chainne
    End Function

    Public Function GetReader(ByVal Query As String) As SqlDataReader
        Dim Reader As SqlDataReader = Nothing
        Try
            Dim con As SqlConnection = GetConnexion()
            Dim Cmd As New SqlCommand(Query, con)
            Reader = Cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return Reader

    End Function

End Class


