Imports System.Data.SqlClient
Imports System.Globalization

Public Class Producto
    Private _Id As String
    Private _Nombre As String
    Private _Cantidad As String
    Private _Precio As String
    Private _Reabastecimiento As DateTime

    Public Property Id As String
        Get
            Return _Id
        End Get
        Set
            _Id = Value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set
            _Nombre = Value
        End Set
    End Property

    Public Property Cantidad As String
        Get
            Return _Cantidad
        End Get
        Set
            _Cantidad = Value
        End Set
    End Property

    Public Property Precio As String
        Get
            Return _Precio
        End Get
        Set
            _Precio = Value
        End Set
    End Property

    Public Property Reabastecimiento As String
        Get
            Return _Reabastecimiento
        End Get
        Set
            _Reabastecimiento = Value
        End Set
    End Property

#Region "Definicion de Metodos"
    Public Function Alta() As Boolean
        Dim cnx As New SqlConnection("Server=DESKTOP-SLN622U; database=Fruteria; Integrated Security=true")
        Dim cmd As New SqlCommand("dbo.Alta", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@id", _Id))
        cmd.Parameters.Add(New SqlParameter("@nombre", _Nombre))
        cmd.Parameters.Add(New SqlParameter("@cantidad", _Cantidad))
        cmd.Parameters.Add(New SqlParameter("@precio", _Precio))
        cmd.Parameters.Add(New SqlParameter("@reabastecimiento", _Reabastecimiento.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture)))
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
        Return True
    End Function

    Public Function Baja() As Boolean
        Dim cnx As New SqlConnection("Server=DESKTOP-SLN622U; database=Fruteria; Integrated Security=true")
        Dim cmd As New SqlCommand("dbo.Baja", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@id", _Id))
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
        Return True
    End Function

    Public Function Modificacion() As Boolean
        Dim cnx As New SqlConnection("Server=DESKTOP-SLN622U; database=Fruteria; Integrated Security=true")
        Dim cmd As New SqlCommand("dbo.Modificacion", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@id", _Id))
        cmd.Parameters.Add(New SqlParameter("@nombre", _Nombre))
        cmd.Parameters.Add(New SqlParameter("@cantidad", _Cantidad))
        cmd.Parameters.Add(New SqlParameter("@precio", _Precio))
        cmd.Parameters.Add(New SqlParameter("@reabastecimiento", _Reabastecimiento.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture)))
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
        Return True
    End Function

    Public Function Consulta() As String()
        Dim cnx As New SqlConnection("Server=DESKTOP-SLN622U; database=Fruteria; Integrated Security=true")
        Dim cmd As New SqlCommand("dbo.Consulta", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        Dim nombre, Cantidad, Precio, Reabastecimiento As String
        cmd.Parameters.Add(New SqlParameter("@id", _Id))
        cnx.Open()
        Dim leer As SqlDataReader
        leer = cmd.ExecuteReader
        If leer.Read() Then
            Console.WriteLine(leer(1))
            nombre = leer(1).ToString()
            Cantidad = leer(2).ToString()
            Precio = leer(3).ToString()
            Reabastecimiento = DateTime.ParseExact(leer(4).ToString(), "MM/dd/yyyy", CultureInfo.InvariantCulture)
            cnx.Close()
            Return New String() {nombre, Cantidad, Precio, Reabastecimiento}
        End If
        Return New String() {"empty"}
    End Function
#End Region
End Class