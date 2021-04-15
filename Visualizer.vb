Imports System.Globalization
Imports Producto

Public Class Visualizer
    Private Sub limpiar()
        txt_id.Text = ""
        txt_nombre.Text = ""
        txt_cantidad.Text = ""
        txt_precio.Text = ""
        dt_reabastecimiento.Value = DateTime.ParseExact("01/01/2000", "MM/dd/yyyy", CultureInfo.InvariantCulture)
    End Sub
    Private Sub tst_nuevo_Click(sender As Object, e As EventArgs) Handles tst_nuevo.Click
        limpiar()
    End Sub

    Private Sub tst_consulta_Click(sender As Object, e As EventArgs) Handles tst_consulta.Click
        Dim consulta As New Producto
        With consulta
            .Id = txt_id.Text
            Dim data = consulta.Consulta
            If Not data(0).Equals("empty") Then
                txt_nombre.Text = data(0)
                txt_cantidad.Text = data(1)
                txt_precio.Text = data(2)
                dt_reabastecimiento.Value = data(3)
            Else
                txt_nombre.Text = "Dato no existente"
            End If

        End With
    End Sub

    Private Sub tst_modifica_Click(sender As Object, e As EventArgs) Handles tst_modifica.Click
        Dim modificar As New Producto
        With modificar
            .Id = txt_id.Text
            .Nombre = txt_nombre.Text
            .Cantidad = txt_cantidad.Text
            .Precio = txt_precio.Text
            .Reabastecimiento = dt_reabastecimiento.Value
            modificar.Modificacion()
        End With
    End Sub

    Private Sub tst_agrega_Click(sender As Object, e As EventArgs) Handles tst_agrega.Click
        Dim agregar As New Producto
        With agregar
            .Id = txt_id.Text
            .Nombre = txt_nombre.Text
            .Cantidad = txt_cantidad.Text
            .Precio = txt_precio.Text
            .Reabastecimiento = dt_reabastecimiento.Value
            agregar.Alta()
        End With
    End Sub

    Private Sub tst_eliminar_Click(sender As Object, e As EventArgs) Handles tst_eliminar.Click
        Dim eliminar As New Producto
        With eliminar
            .Id = txt_id.Text
            eliminar.Baja()
        End With
    End Sub

    Private Sub tst_salir_Click(sender As Object, e As EventArgs) Handles tst_salir.Click
        End
    End Sub
End Class
