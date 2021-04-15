<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Visualizer
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tst_nuevo = New System.Windows.Forms.ToolStripTextBox()
        Me.tst_consulta = New System.Windows.Forms.ToolStripTextBox()
        Me.tst_modifica = New System.Windows.Forms.ToolStripTextBox()
        Me.tst_agrega = New System.Windows.Forms.ToolStripTextBox()
        Me.tst_eliminar = New System.Windows.Forms.ToolStripTextBox()
        Me.tst_salir = New System.Windows.Forms.ToolStripTextBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_cantidad = New System.Windows.Forms.Label()
        Me.lbl_precio = New System.Windows.Forms.Label()
        Me.lbl_reabastecimiento = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.dt_reabastecimiento = New System.Windows.Forms.DateTimePicker()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tst_nuevo, Me.tst_consulta, Me.tst_modifica, Me.tst_agrega, Me.tst_eliminar, Me.tst_salir})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(933, 29)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tst_nuevo
        '
        Me.tst_nuevo.Name = "tst_nuevo"
        Me.tst_nuevo.Size = New System.Drawing.Size(148, 23)
        Me.tst_nuevo.Text = "Nuevo"
        '
        'tst_consulta
        '
        Me.tst_consulta.Name = "tst_consulta"
        Me.tst_consulta.Size = New System.Drawing.Size(148, 23)
        Me.tst_consulta.Text = "Consultar"
        '
        'tst_modifica
        '
        Me.tst_modifica.Name = "tst_modifica"
        Me.tst_modifica.Size = New System.Drawing.Size(148, 23)
        Me.tst_modifica.Text = "Modificar"
        '
        'tst_agrega
        '
        Me.tst_agrega.Name = "tst_agrega"
        Me.tst_agrega.Size = New System.Drawing.Size(148, 23)
        Me.tst_agrega.Text = "Agregar"
        '
        'tst_eliminar
        '
        Me.tst_eliminar.Name = "tst_eliminar"
        Me.tst_eliminar.Size = New System.Drawing.Size(148, 23)
        Me.tst_eliminar.Text = "Eliminar"
        '
        'tst_salir
        '
        Me.tst_salir.Name = "tst_salir"
        Me.tst_salir.Size = New System.Drawing.Size(148, 23)
        Me.tst_salir.Text = "Salir"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(53, 183)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(23, 20)
        Me.lbl_id.TabIndex = 1
        Me.lbl_id.Text = "Id"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(53, 212)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(143, 20)
        Me.lbl_nombre.TabIndex = 2
        Me.lbl_nombre.Text = "Producto (Nombre)"
        '
        'lbl_cantidad
        '
        Me.lbl_cantidad.AutoSize = True
        Me.lbl_cantidad.Location = New System.Drawing.Point(53, 242)
        Me.lbl_cantidad.Name = "lbl_cantidad"
        Me.lbl_cantidad.Size = New System.Drawing.Size(73, 20)
        Me.lbl_cantidad.TabIndex = 3
        Me.lbl_cantidad.Text = "Cantidad"
        '
        'lbl_precio
        '
        Me.lbl_precio.AutoSize = True
        Me.lbl_precio.Location = New System.Drawing.Point(53, 271)
        Me.lbl_precio.Name = "lbl_precio"
        Me.lbl_precio.Size = New System.Drawing.Size(53, 20)
        Me.lbl_precio.TabIndex = 4
        Me.lbl_precio.Text = "Precio"
        '
        'lbl_reabastecimiento
        '
        Me.lbl_reabastecimiento.AutoSize = True
        Me.lbl_reabastecimiento.Location = New System.Drawing.Point(53, 300)
        Me.lbl_reabastecimiento.Name = "lbl_reabastecimiento"
        Me.lbl_reabastecimiento.Size = New System.Drawing.Size(138, 20)
        Me.lbl_reabastecimiento.TabIndex = 5
        Me.lbl_reabastecimiento.Text = "Reabastecimiento"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(215, 180)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(439, 26)
        Me.txt_id.TabIndex = 6
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(215, 209)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(439, 26)
        Me.txt_nombre.TabIndex = 7
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(215, 239)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(439, 26)
        Me.txt_cantidad.TabIndex = 8
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(215, 268)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(439, 26)
        Me.txt_precio.TabIndex = 9
        '
        'dt_reabastecimiento
        '
        Me.dt_reabastecimiento.Location = New System.Drawing.Point(215, 300)
        Me.dt_reabastecimiento.Name = "dt_reabastecimiento"
        Me.dt_reabastecimiento.Size = New System.Drawing.Size(439, 26)
        Me.dt_reabastecimiento.TabIndex = 10
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("MV Boli", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(162, 72)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(535, 41)
        Me.lbl_title.TabIndex = 11
        Me.lbl_title.Text = "Fruteria ""Los Tres Tristes Tigres"""
        '
        'Visualizer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 499)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.dt_reabastecimiento)
        Me.Controls.Add(Me.txt_precio)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_reabastecimiento)
        Me.Controls.Add(Me.lbl_precio)
        Me.Controls.Add(Me.lbl_cantidad)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Visualizer"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents tst_nuevo As ToolStripTextBox
    Friend WithEvents tst_consulta As ToolStripTextBox
    Friend WithEvents tst_modifica As ToolStripTextBox
    Friend WithEvents tst_agrega As ToolStripTextBox
    Friend WithEvents tst_eliminar As ToolStripTextBox
    Friend WithEvents tst_salir As ToolStripTextBox
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_cantidad As Label
    Friend WithEvents lbl_precio As Label
    Friend WithEvents lbl_reabastecimiento As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_cantidad As TextBox
    Friend WithEvents txt_precio As TextBox
    Friend WithEvents dt_reabastecimiento As DateTimePicker
    Friend WithEvents lbl_title As Label
End Class
