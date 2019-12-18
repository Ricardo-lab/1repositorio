Public Class Form2
    Dim listDiccionario As ListView
    Dim palabra, definicion As String

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listDiccionario = lvDiccionario


    End Sub

    Private Sub lvDiccionario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvDiccionario.SelectedIndexChanged
        If listDiccionario.SelectedItems.Count > 0 Then

            Dim item As ListViewItem = listDiccionario.SelectedItems(0)

            Dim palabra As String = item.SubItems(1).Text
            Dim definicion As String = item.SubItems(2).Text

            Form3.lblPalabra.Text = palabra
            Form3.txtDefinicion.Text = definicion

            Form3.Show()
            Me.Hide()

        End If

    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs)





    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class