Imports System.Data
Imports System.Data.SqlClient
Public Class fCategoria
    Inherits Conexion

    Dim cmd As SqlCommand



    Public Function Mostrar() As DataTable
        Dim dt As New DataTable
        Dim leer As SqlDataReader
        Conectar()
        cmd = New SqlCommand("Categoria_Mostrar")
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conexion
        leer = cmd.ExecuteReader
        dt.Load(leer)
        Return dt
        Desconectar()
    End Function

    Public Function InsertarCliente(ByVal Objeto As Categoria) As Boolean
        Conectar()
        cmd = New SqlCommand("Categoria_Insertar")
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conexion

        cmd.Parameters.AddWithValue("@Nombre", Objeto.Nombre)

        cmd.ExecuteNonQuery()
        Return True
        Desconectar()
    End Function


    Public Function EditarCliente(ByVal Objeto As Categoria) As Boolean
        Conectar()
        cmd = New SqlCommand("Categoria_Actualizar")
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conexion

        cmd.Parameters.AddWithValue("@IdCategoria", Objeto.IdCategoria)
        cmd.Parameters.AddWithValue("@Nombre", Objeto.Nombre)


        cmd.ExecuteNonQuery()
        Return True
        Desconectar()

    End Function




    Public Function EliminarCliente(ByVal Id As Integer) As Boolean
        Conectar()
        cmd = New SqlCommand("Categoria_Eliminar")
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conexion

        cmd.Parameters.AddWithValue("@IdCategoria", Id)

        cmd.ExecuteNonQuery()
        Return True
        Desconectar()


    End Function

End Class
