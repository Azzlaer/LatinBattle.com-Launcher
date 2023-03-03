Option Explicit On  
Option Strict On

Public Class Form4

    Private Sub Button1_Click( _
        ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        WebBrowser1.Navigate(TextBox1.Text.Trim)

    End Sub

    Private Sub WebBrowser1_DocumentCompleted( _
        ByVal sender As System.Object, _
        ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) _
        Handles WebBrowser1.DocumentCompleted

        If e.Url.ToString = String.Empty Or e.Url.ToString = "http:///" Then
            Exit Sub
        End If
        Try
            Me.Cursor = Cursors.WaitCursor

            Call links()

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Debug.Print(ex.Message.ToString)
        End Try

    End Sub

    'Extrae los links  
    ' ''''''''''''''''''''''''''''''''  
    Private Sub links()

        ListBox1.Items.Clear()
        For i As Integer = 0 To WebBrowser1.Document.Links.Count - 1
            ListBox1.Items.Add(WebBrowser1.Document.Links.Item(i).GetAttribute("href"))
        Next

    End Sub

    Private Sub Form1_Load( _
        ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles MyBase.Load
        Button1.Text = " Cargar página y obtener links "
        WebBrowser1.Visible = False
        TextBox1.Text = "www.google.com"

    End Sub
End Class