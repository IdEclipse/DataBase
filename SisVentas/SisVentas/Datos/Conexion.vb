Imports System.Data
Imports System.Data.SqlClient
Public Class Conexion
    Public conexion As New SqlConnection(My.Settings.cnx)


    Sub Conectar()
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If
    End Sub

    Sub Desconectar()
        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If

    End Sub

End Class
