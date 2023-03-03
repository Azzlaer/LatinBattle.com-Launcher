Imports System.Windows.Forms
Imports System.IO, System.Net, System.Web

Public Class Dialog1
    Public Sub checkforupdates()
        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://latinbattle.com/launcher/Version.txt")
        Dim response As System.Net.HttpWebResponse = request.GetResponse()
        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream)
        Dim newestversion As String = sr.ReadToEnd()
        Dim currenversion As String = Application.ProductVersion
        Label4.Text = currenversion.ToString
        Label5.Text = newestversion.ToString
        If Label4.Text < Label5.Text Then
            Label7.Visible = True
            Label7.Text = "ESTADO: Existe una nueva version del programa, usa el boton verde que dice DESCARGA para acceder"
            Button1.Enabled = True
            Button1.BackColor = Color.Green
        Else
            Label7.Text = Label7.Text = "ESTADO: NO EXISTE UNA VERSION NUEVA POR EL MOMENTO"
        End If

    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Dialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        checkforupdates()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Process.Start("https://latinbattle.com/?p=882")
        Process.Start("https://latinbattle.com/Launcher/W3Launcher.rar")
    End Sub
End Class
