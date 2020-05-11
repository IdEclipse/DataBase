Imports System.Reflection
Public Class FrmFiltroLabor
    Private _idLabor As Integer

    Public Property IdLabor As Integer
        Get
            Return _idLabor
        End Get
        Set(value As Integer)
            _idLabor = value
        End Set
    End Property

    Private Sub FrmFiltroLabor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Ds.Nivel' Puede moverla o quitarla según sea necesario.
        Me.NivelTableAdapter.Fill(Me.Ds.Nivel)
        'TODO: esta línea de código carga datos en la tabla 'Ds.Orientacion' Puede moverla o quitarla según sea necesario.
        Me.OrientacionTableAdapter.Fill(Me.Ds.Orientacion)
        'TODO: esta línea de código carga datos en la tabla 'Ds.TipoLabor' Puede moverla o quitarla según sea necesario.
        Me.TipoLaborTableAdapter.Fill(Me.Ds.TipoLabor)
        'TODO: esta línea de código carga datos en la tabla 'Ds.Veta' Puede moverla o quitarla según sea necesario.
        Me.VetaTableAdapter.Fill(Me.Ds.Veta)
        'TODO: esta línea de código carga datos en la tabla 'Ds.Nivel' Puede moverla o quitarla según sea necesario.
        Me.NivelTableAdapter.Fill(Me.Ds.Nivel)
        'TODO: esta línea de código carga datos en la tabla 'Ds.Labor' Puede moverla o quitarla según sea necesario.
        Me.LaborTableAdapter.Fill(Me.Ds.Labor)






    End Sub



    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        IdLabor = LaborDataGridView.CurrentRow.Cells(0).Value
        Me.Close()

    End Sub


    Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' para acelerar el grid control desde el constructor
        LaborDataGridView.GetType().GetMethod("SetStyle", BindingFlags.Instance Or BindingFlags.NonPublic).Invoke(LaborDataGridView, New Object() {ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.DoubleBuffer, True})

    End Sub




End Class