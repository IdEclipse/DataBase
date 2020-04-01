Public Class Cliente
    Private _idCliente As Integer
    Private _nombre As String
    Private _apellido As String
    Private _direccion As String
    Private _telefono As String
    Private _dni As String



    Public Property IdCliente() As Integer
        Get
            Return _idCliente
        End Get
        Set(ByVal value As Integer)
            _idCliente = value
        End Set
    End Property


    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property


    Public Property Apellido() As String
        Get
            Return _apellido
        End Get
        Set(ByVal value As String)
            _apellido = value
        End Set
    End Property


    Public Property Direccion() As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
        End Set
    End Property


    Public Property Telefono() As String
        Get
            Return _telefono
        End Get
        Set(ByVal value As String)
            _telefono = value
        End Set
    End Property


    Public Property Dni() As String
        Get
            Return _dni
        End Get
        Set(ByVal value As String)
            _dni = value
        End Set
    End Property



    Public Sub New()

    End Sub

    Public Sub New(idCliente As Integer, nombre As String, apellido As String, direccion As String, telefono As String, dni As String)
        _idCliente = idCliente
        _nombre = nombre
        _apellido = apellido
        _direccion = direccion
        _telefono = telefono
        _dni = dni
    End Sub
End Class
