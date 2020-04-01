Imports System.Data
Imports System.Data.SqlClient

Public Class fCliente
    Inherits Conexion

    Dim cmd As SqlCommand



    Public Function Mostrar() As DataTable
        Dim dt As New DataTable
        Dim leer As SqlDataReader
        Conectar()
        cmd = New SqlCommand("Cliente_Mostrar")
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conexion
        leer = cmd.ExecuteReader
        dt.Load(leer)
        Return dt
        Desconectar()
    End Function



End Class
