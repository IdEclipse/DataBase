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

    Public Function InsertarCliente(ByVal Objeto As Cliente) As Boolean
        Conectar()
        cmd = New SqlCommand("Cliente_Insertar")
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conexion

        cmd.Parameters.AddWithValue("@Nombre", Objeto.Nombre)
        cmd.Parameters.AddWithValue("@Apellido", Objeto.Apellido)
        cmd.Parameters.AddWithValue("@Direccion", Objeto.Direccion)
        cmd.Parameters.AddWithValue("@Telefono", Objeto.Telefono)
        cmd.Parameters.AddWithValue("@DNI", Objeto.Dni)

        cmd.ExecuteNonQuery()
        Return True
        Desconectar()
    End Function


    Public Function EditarCliente(ByVal Objeto As Cliente) As Boolean
        Conectar()
        cmd = New SqlCommand("Cliente_Actualizar")
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conexion

        cmd.Parameters.AddWithValue("@IdCliente", Objeto.IdCliente)
        cmd.Parameters.AddWithValue("@Nombre", Objeto.Nombre)
        cmd.Parameters.AddWithValue("@Apellido", Objeto.Apellido)
        cmd.Parameters.AddWithValue("@Direccion", Objeto.Direccion)
        cmd.Parameters.AddWithValue("@Telefono", Objeto.Telefono)
        cmd.Parameters.AddWithValue("@DNI", Objeto.Dni)

        cmd.ExecuteNonQuery()
        Return True
        Desconectar()

    End Function




    Public Function EliminarCliente(ByVal Id As Integer) As Boolean
        Conectar()
        cmd = New SqlCommand("Cliente_Eliminar")
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conexion

        cmd.Parameters.AddWithValue("@IdCliente", Id)

        cmd.ExecuteNonQuery()
        Return True
        Desconectar()


    End Function







End Class
