<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lvDiccionario = New System.Windows.Forms.ListView()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(121, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DICCIONARIO"
        '
        'lvDiccionario
        '
        Me.lvDiccionario.HideSelection = False
        Me.lvDiccionario.Location = New System.Drawing.Point(11, 69)
        Me.lvDiccionario.Margin = New System.Windows.Forms.Padding(2)
        Me.lvDiccionario.Name = "lvDiccionario"
        Me.lvDiccionario.Size = New System.Drawing.Size(284, 326)
        Me.lvDiccionario.TabIndex = 1
        Me.lvDiccionario.UseCompatibleStateImageBehavior = False
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(465, 405)
        Me.btnRegresar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(109, 40)
        Me.btnRegresar.TabIndex = 2
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Diccionario.My.Resources.Resources.er
        Me.PictureBox1.Location = New System.Drawing.Point(315, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(382, 336)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Diccionario.My.Resources.Resources.fondo_ilustracion_3d_publicidad_fondos_pantalla_gatsby_escena_art_deco_83608_4
        Me.ClientSize = New System.Drawing.Size(709, 456)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.lvDiccionario)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lvDiccionario As ListView
    Friend WithEvents btnRegresar As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
