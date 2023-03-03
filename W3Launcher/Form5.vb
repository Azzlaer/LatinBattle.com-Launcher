Imports System.Net.NetworkInformation
Imports System.Net
Imports NetFwTypeLib
Imports System.Net.Sockets
Imports System.Security.Principal

Public Class Form5
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Process.Start("wf.msc")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim portNumber As Integer = 6125 ' Aquí especifica el número de puerto que deseas abrir
        Dim command As String = String.Format("netsh advfirewall firewall add rule name=""LatinBattle.com - 6125 TCP"" dir=in action=allow protocol=TCP localport={0}", portNumber)
        Dim startInfo As New ProcessStartInfo("cmd.exe", "/C " & command)
        startInfo.WindowStyle = ProcessWindowStyle.Hidden
        startInfo.CreateNoWindow = True
        Process.Start(startInfo)
        MsgBox("Listo", vbInformation)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim portNumber As Integer = 6112 ' Aquí especifica el número de puerto que deseas abrir
        Dim command As String = String.Format("netsh advfirewall firewall add rule name=""LatinBattle.com - 6112 TCP"" dir=in action=allow protocol=TCP localport={0}", portNumber)
        Dim startInfo As New ProcessStartInfo("cmd.exe", "/C " & command)
        startInfo.WindowStyle = ProcessWindowStyle.Hidden
        startInfo.CreateNoWindow = True
        Process.Start(startInfo)
        MsgBox("Listo", vbInformation)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim portNumber As Integer = 6200 ' Aquí especifica el número de puerto que deseas abrir
        Dim command As String = String.Format("netsh advfirewall firewall add rule name=""LatinBattle.com - 6200 TCP"" dir=in action=allow protocol=TCP localport={0}", portNumber)
        Dim startInfo As New ProcessStartInfo("cmd.exe", "/C " & command)
        startInfo.WindowStyle = ProcessWindowStyle.Hidden
        startInfo.CreateNoWindow = True
        Process.Start(startInfo)
        MsgBox("Listo", vbInformation)
    End Sub


    Private Sub btnAddPort_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddPort.Click
        Dim port As Integer = CInt(txtPort.Text)
        Dim name As String = txtName.Text
        Dim protocol As Sockets.ProtocolType
        If cmbProtocol.Text = "TCP" Then
            protocol = Sockets.ProtocolType.Tcp
        Else
            If cmbProtocol.Text = "UDP" Then
                protocol = Sockets.ProtocolType.Udp
            End If
        End If

        Dim portNumber As Integer = txtPort.Text ' Aquí especifica el número de puerto que deseas abrir
        'Dim command As String = String.Format("netsh advfirewall firewall add rule name=LatinBattle.com - ", txtPort.Text, "dir=in action=allow protocol=" & cmbProtocol.Text, "localport={0}", portNumber)
        Dim command As String = String.Format("netsh advfirewall firewall add rule name=""{0}"" dir=in action=allow protocol=""{1}"" localport=""{2}""", name, protocol, portNumber)
        Dim startInfo As New ProcessStartInfo("cmd.exe", "/C " & command)
        startInfo.WindowStyle = ProcessWindowStyle.Hidden
        startInfo.CreateNoWindow = True
        Process.Start(startInfo)
        MsgBox("Listo", vbInformation)
    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim currentIdentity As WindowsIdentity = WindowsIdentity.GetCurrent()
        Dim currentPrincipal As New WindowsPrincipal(currentIdentity)
        Dim isAdmin As Boolean = currentPrincipal.IsInRole(WindowsBuiltInRole.Administrator)
        If isAdmin Then
            Label5.Text = "MODO ADMINISTRADOR: ACTIVADO"
        Else
            Label5.Text = "MODO ADMINISTRADOR: DESACTIVADO"
            MsgBox("La aplicación NO está ejecutandose en modo Administrador", vbInformation)
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False
        End If
    End Sub
End Class