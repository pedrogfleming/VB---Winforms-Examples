Imports MySql.Data.MySqlClient

Public Class Form1
#Region "Variables"
    Private cmb As MySqlCommandBuilder()
    Dim conexion1 As New MySqlConnection
    Dim datos As New DataSet
    Dim adaptador As New MySqlDataAdapter
    Dim lista As Byte
#End Region
#Region "Base de datos"
    Public Sub Conectar()
        Try
            conexion1.ConnectionString = "server=localhost;user=root;database=youtube;"
            conexion1.Open()
            Dim consulta As String
            consulta = "SELECT * FROM personas"
            adaptador = New MySqlDataAdapter(consulta, conexion1)
            datos = New DataSet
            adaptador.Fill(datos, "persona")
            DgvPersonas.DataSource = datos
            DgvPersonas.DataMember = "persona"
            MsgBox("Conectado Correctamente")
        Catch ex As Exception
            MsgBox("No conectado" + ex.ToString)
            Me.Close()
        End Try
    End Sub
#End Region
#Region "Load"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar()
    End Sub
#End Region



End Class
