Public Class Categoria

Private _idCategoria As Integer
Private _nombre As String



Public Property IdCategoria() As Integer
    Get
        Return _idCategoria
    End Get
    Set(ByVal value As Integer)
        _idCategoria = value
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



Public Sub New

End Sub

    Public Sub New(idCategoria As Integer, nombre As String)
        _idCategoria = idCategoria
        _nombre = nombre
    End Sub
End Class