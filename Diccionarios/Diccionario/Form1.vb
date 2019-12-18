
Imports System.IO
Public Class Form1
    Public list_diccionario As New List(Of String)

    Private Sub agregar(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Escribir As New StreamWriter("C:\Users\ITQ\Documents\archivo.txt")
        Dim palabra, definicion, dic As String

        palabra = txtPalabra.Text
        definicion = txtDefinicion.Text
        dic = palabra + ":" + definicion
        Dim item1 As ListViewItem
        item1 = New ListViewItem(palabra, 0)
        item1.SubItems.Add(palabra)
        item1.SubItems.Add(definicion)




        Escribir.WriteLine(dic)
        Escribir.Close()

        Form2.lvDiccionario.Items.Add(item1)
        Form2.Show()
        Me.Hide()





    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Enabled = False

        'Form2.lvDiccionario =


    End Sub

    Private Sub txtPalabra_TextChanged(sender As Object, e As EventArgs) Handles txtPalabra.TextChanged
        Button1.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        OpenFileDialog1.InitialDirectory = "C:\Users\ITQ\Pictures"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)

        End If



    End Sub

    Private Sub txtDefinicion_TextChanged(sender As Object, e As EventArgs) Handles txtDefinicion.TextChanged
        Button1.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtPalabra.Text = "" And txtDefinicion.Text = "" And PictureBox1.Equals("") Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If
    End Sub
End Class
