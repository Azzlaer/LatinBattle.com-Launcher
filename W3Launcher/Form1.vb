Imports System.Net.Sockets
Imports System.Threading
Imports System.Net
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Security.Principal



Public Class Form1
    Dim objShell = CreateObject("Wscript.Shell")
    Private Sub GeneralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralToolStripMenuItem.Click
        Process.Start("https://latinbattle.com/?page_id=63")
    End Sub

    Private Sub TikTokToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TikTokToolStripMenuItem.Click
        Process.Start("https://www.tiktok.com/@azzlaer")
    End Sub

    Private Sub DiscordToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiscordToolStripMenuItem1.Click
        Process.Start("https://discord.io/LatinBattle")
    End Sub

    Private Sub YoutubeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YoutubeToolStripMenuItem.Click
        Process.Start("https://www.youtube.com/c/Azzlaer")
    End Sub

    Private Sub FacebookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacebookToolStripMenuItem.Click
        Process.Start("https://www.facebook.com/latinbattle")
    End Sub

    Private Sub InstagramToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InstagramToolStripMenuItem.Click
        Process.Start("https://www.instagram.com/latinbattle/")
    End Sub

    Private Sub PaypalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaypalToolStripMenuItem.Click
        Process.Start("https://bit.ly/3PS4uGo")
    End Sub

    Private Sub WebPayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebPayToolStripMenuItem.Click
        Process.Start("https://bit.ly/3zDwbO1")
    End Sub


    Private Sub DescargasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DescargasToolStripMenuItem.Click
        Process.Start("https://latinbattle.com/?page_id=691")
    End Sub


    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        ToolStripProgressBar1.Visible = False
    End Sub
    Private Sub WebBrowser1_Navigating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserNavigatingEventArgs) Handles WebBrowser1.Navigating
        ToolStripProgressBar1.Visible = True
        With ToolStripProgressBar1
            .Minimum = 0
            .Maximum = 50
            .Step = 5
        End With
        For index As Integer = 0 To 50 Step 5
            ToolStripProgressBar1.Value = index
            System.Threading.Thread.Sleep(35)
        Next
    End Sub

    Private Sub LatinBattleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LatinBattleToolStripMenuItem.Click
        Process.Start("http://latinbattle.com")
    End Sub

    Private Sub D2wbot1vs1RankToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D2wbot1vs1RankToolStripMenuItem.Click
        WebBrowser1.Navigate("https://latinbattle.com/url/e1076")
    End Sub

    Private Sub SoloToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SoloToolStripMenuItem.Click
        WebBrowser1.Navigate("https://latinbattle.com/url/a9ca1")
    End Sub

    Private Sub TeamToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeamToolStripMenuItem.Click
        WebBrowser1.Navigate("https://latinbattle.com/url/63fec")
    End Sub

    Private Sub FFAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FFAToolStripMenuItem.Click
        WebBrowser1.Navigate("https://latinbattle.com/url/41dca")
    End Sub

    Private Sub VerDotAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerDotAToolStripMenuItem.Click
        WebBrowser1.Navigate("https://latinbattle.com/url/97819")
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MsgBox("Gracias por jugar con nosotros", vbInformation)
    End Sub

    Private Sub GuiasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuiasToolStripMenuItem1.Click
        Process.Start("https://latinbattle.com/category/w3/")
    End Sub

    Private Sub PartidasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PartidasToolStripMenuItem.Click
        'WebBrowser1.Navigate("https://latinbattle.com/w3/verpartidas2.php?column=datetime&order=desc")
        'WebBrowser1.Navigate("https://latinbattle.com/w3/verpartidas.php")
        WebBrowser1.Navigate("https://latinbattle.com/url/dd3aa")
    End Sub

    Private Sub VerificarPuertosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerificarPuertosToolStripMenuItem.Click
        Process.Start("https://latinbattle.com/url/f8117")
    End Sub

    Private Sub ClanesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClanesToolStripMenuItem.Click
        WebBrowser1.Navigate("https://latinbattle.com/url/44ca5")
    End Sub

    Private Sub D2ghostToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D2ghostToolStripMenuItem.Click
        WebBrowser1.Navigate("https://latinbattle.com/url/8523d")
    End Sub

    Private Sub D2fbotToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D2fbotToolStripMenuItem.Click
        WebBrowser1.Navigate("https://latinbattle.com/url/eb6a0")
    End Sub

    Private Sub CuentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuentasToolStripMenuItem.Click
        WebBrowser1.Navigate("https://latinbattle.com/url/924ed")
    End Sub

    Private Sub ActividadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActividadToolStripMenuItem.Click
        WebBrowser1.Navigate("https://latinbattle.com/url/6edf4")
    End Sub

    Private Sub D2cbotToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D2cbotToolStripMenuItem.Click
        WebBrowser1.Navigate("https://latinbattle.com/url/da158")
    End Sub

    Private Sub D2dbotToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D2dbotToolStripMenuItem.Click
        WebBrowser1.Navigate("https://latinbattle.com/url/cae4a")
    End Sub

    Private Sub D2gbotToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D2gbotToolStripMenuItem.Click
        WebBrowser1.Navigate("https://latinbattle.com/url/10ea8")
    End Sub

    Private Sub D2hbotToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D2hbotToolStripMenuItem.Click
        WebBrowser1.Navigate("https://latinbattle.com/url/c3501")
    End Sub

    Private Sub D2qbotToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D2qbotToolStripMenuItem.Click
        WebBrowser1.Navigate("https://latinbattle.com/url/c4cb1")
    End Sub

    Private Sub D2rbotToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D2rbotToolStripMenuItem.Click
        WebBrowser1.Navigate("https://latinbattle.com/url/59aac")
    End Sub

    Private Sub SsjuegosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SsjuegosToolStripMenuItem.Click
        WebBrowser1.Navigate("https://latinbattle.com/url/3a8e2")
    End Sub

    Private Sub D2abotToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D2abotToolStripMenuItem.Click
        WebBrowser1.Navigate("https://latinbattle.com/url/5b8e3")
    End Sub

    Private Sub D2bbotToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D2bbotToolStripMenuItem.Click
        WebBrowser1.Navigate("https://latinbattle.com/url/ab4fd")
    End Sub

    Private Sub D2ibotToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D2ibotToolStripMenuItem.Click
        WebBrowser1.Navigate("https://latinbattle.com/url/f2028")
    End Sub

    Private Sub D2mbotToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D2mbotToolStripMenuItem.Click
        WebBrowser1.Navigate("http://144.22.50.4/bots/d2mbot.php")
    End Sub

    Private Sub D2npbotToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D2npbotToolStripMenuItem.Click
        WebBrowser1.Navigate("http://144.22.50.4/bots/d2npbot.php")
    End Sub

    Private Sub D2nbotToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D2nbotToolStripMenuItem.Click
        WebBrowser1.Navigate("http://144.22.50.4/bots/d2nbot.php")
    End Sub

    Private Sub D2obotToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D2obotToolStripMenuItem.Click
        WebBrowser1.Navigate("http://144.22.50.4/bots/d2obot.php")
    End Sub

    Private Sub ReplaysToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReplaysToolStripMenuItem.Click
        WebBrowser1.Navigate("https://latinbattle.com/url/01ffe")
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dialog1.ShowDialog()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''ToolStripStatusLabel8.Text = "Version: " & Application.ProductVersion & " / 1.0.0.17"
        ''Me.Text = "LatinBattle.com - Comunidad Latina de Juegos - Version: " & Application.ProductVersion & " / 1.0.0.17"



        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://latinbattle.com/launcher/Version.txt")
        Dim response As System.Net.HttpWebResponse = request.GetResponse()
        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream)
        Dim newestversion As String = sr.ReadToEnd()
        Dim currenversion As String = Application.ProductVersion
        ToolStripStatusLabel10.Text = currenversion.ToString
        ToolStripStatusLabel11.Text = newestversion.ToString



        Dim currentIdentity As WindowsIdentity = WindowsIdentity.GetCurrent()
        Dim currentPrincipal As New WindowsPrincipal(currentIdentity)
        Dim isAdmin As Boolean = currentPrincipal.IsInRole(WindowsBuiltInRole.Administrator)

        WebBrowser1.Navigate("https://latinbattle.com/url/fa18d")
        If My.Computer.Network.IsAvailable Then
            ToolStripStatusLabel1.Text = "Estado: Online"
        Else
            ToolStripStatusLabel1.Text = "Estado: Offline"
        End If
        'PlayBackgroundSoundFile()

        ToolStripStatusLabel2.Text = "IP Publica: " & GetExternalIp()
        ToolStripStatusLabel3.Text = "IP Privada: " & GetIPAddress()

        If isAdmin Then
            ToolStripStatusLabel6.Text = "Modo Administrador: SI"
        Else
            ToolStripStatusLabel6.Text = "Modo Administrador: NO"
        End If
        If ToolStripStatusLabel10.Text < ToolStripStatusLabel11.Text Then
            MsgBox("Version desactualizada . . . Descargando ultima version")
            MsgBox("Cerrando aplicacion . .", vbInformation)
            Process.Start("https://latinbattle.com/Launcher/W3Launcher.rar")
            Me.Close()
        End If
    End Sub


    'Sub PlayBackgroundSoundFile()
    '  My.Computer.Audio.Play("https://latinbattle.com/Launcher/1.wav",
    '       AudioPlayMode.WaitToComplete)
    ' End Sub

    Private Sub BaneadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BaneadosToolStripMenuItem.Click
        WebBrowser1.Navigate("https://latinbattle.com/url/45882")
    End Sub


    Private Sub VotanosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VotanosToolStripMenuItem.Click
        Process.Start("https://www.trackyserver.com/es/server/2068139")
    End Sub

    Private Sub AcortadorDeEnlacesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcortadorDeEnlacesToolStripMenuItem.Click
        Process.Start("https://latinbattle.com/url/")
    End Sub

    Private Sub Warcraft3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Warcraft3ToolStripMenuItem.Click
        Process.Start("https://chat.whatsapp.com/CeN0Kg49YLVAA6SjCko546")
    End Sub

    Private Sub ValheimToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("https://chat.whatsapp.com/DDvSyR1KLPB1wkG47PxB8w")
    End Sub

    Private Sub MinecraftToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("https://chat.whatsapp.com/Je7be1pAz692oLQCXSCe8g")
    End Sub

    Private Sub ArmorStandsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArmorStandsToolStripMenuItem.Click
        Process.Start("https://latinbattle.com/mc/")
    End Sub

    Private Sub GametrackerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GametrackerToolStripMenuItem.Click
        Process.Start("https://www.gametracker.com/server_info/152.230.104.34:25565/")
    End Sub

    Private Sub PatreonToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatreonToolStripMenuItem.Click
        Process.Start("http://bit.ly/3Eqyc1c")
    End Sub

    Private Sub ComoUsarBotsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComoUsarBotsToolStripMenuItem.Click
        Process.Start("https://latinbattle.com/?page_id=372")
    End Sub

    Private Sub AddmefastToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddmefastToolStripMenuItem.Click
        Process.Start("https://latinbattle.com/url/fe158")
    End Sub

    Private Sub ContadorDeVisitasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContadorDeVisitasToolStripMenuItem.Click
        Process.Start("https://livetrafficfeed.com/live/latinbattle.com")
    End Sub

    Private Sub ContadorDeVisitasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContadorDeVisitasToolStripMenuItem1.Click
        Process.Start("https://www.revolvermaps.com/livestats/0fkug5q5vsh/")
    End Sub

    Private Sub AccesoAlBotD2ghostToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccesoAlBotD2ghostToolStripMenuItem.Click
        WebBrowser1.Navigate("https://latinbattle.com/w3/veradmins.php")
    End Sub

    Private Sub HistorialDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistorialDeToolStripMenuItem.Click
        WebBrowser1.Navigate("https://latinbattle.com/w3/verhistorial.php")
    End Sub

    Private Sub VerDonadoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerDonadoresToolStripMenuItem.Click
        WebBrowser1.Navigate("https://latinbattle.com/w3/verdonaciones.php")
    End Sub

    Private Sub W3MapsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles W3MapsToolStripMenuItem.Click
        Process.Start("https://wc3maps.com/")
    End Sub

    Private Sub EpicWarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EpicWarToolStripMenuItem.Click
        Process.Start("https://www.epicwar.com/maps/")
    End Sub

    Private Sub HiveworkshopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HiveworkshopToolStripMenuItem.Click
        Process.Start("https://www.hiveworkshop.com/repositories/maps.564/")
    End Sub

    Private Sub Warcraft3ReforgedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Warcraft3ReforgedToolStripMenuItem.Click
        Process.Start("https://maps.w3reforged.com/maps/top-250")
    End Sub

    Private Sub ReplayYStatsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReplayYStatsToolStripMenuItem.Click
        Process.Start("https://wc3stats.com/upload")
    End Sub

    Private Sub PlayerHeadsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayerHeadsToolStripMenuItem.Click
        Process.Start("https://minecraft-heads.com/player-heads")
    End Sub

    Private Sub MinecraftToolsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinecraftToolsToolStripMenuItem.Click
        Process.Start("https://minecraft.tools/es/")
    End Sub

    Private Sub RegistroREGEDITToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroREGEDITToolStripMenuItem.Click
        Form2.Show()
    End Sub



    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("http://w3latinbattle.sytes.net:8080/w3/index.html")
        'WebBrowser1.Navigate("http://www.LatinBattle.com/w3/index.html")
    End Sub

    Private Sub D2ghostToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D2ghostToolStripMenuItem2.Click
        WebBrowser1.Navigate("https://www.latinbattle.com/w3/verlistado.php")
    End Sub

    Private Sub LatinbattleToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LatinbattleToolStripMenuItem2.Click
        WebBrowser1.Navigate("http://w3latinbattle.sytes.net:8080/w3/verlistado.php")
    End Sub

    Private Sub D2ghostToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D2ghostToolStripMenuItem1.Click
        'WebBrowser1.Navigate("https://www.latinbattle.com/w3/uploadform.html")
        Process.Start("http://www.LatinBattle.com/w3/index.html")
    End Sub

    Private Sub LatinbattleToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LatinbattleToolStripMenuItem1.Click
        'WebBrowser1.Navigate("http://w3latinbattle.sytes.net:8080/w3/uploadform.html")
        Process.Start("http://w3latinbattle.sytes.net:8080/w3/index.html")

    End Sub

    Private Sub BuscadorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscadorToolStripMenuItem.Click
        WebBrowser1.Navigate("http://www.shinysearch.com/myhome.php?theme=lion&ltext=LatinBattle.com")
    End Sub

    Private Sub ArchivosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArchivosToolStripMenuItem.Click
        WebBrowser1.Navigate("http://w3latinbattle.sytes.net:8080/Descargas/")
    End Sub

    Private Sub DescargaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DescargaToolStripMenuItem.Click
        WebBrowser1.Navigate("http://w3latinbattle.sytes.net:8081/")
    End Sub

    Private Sub OpenStatsGhostToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenStatsGhostToolStripMenuItem.Click
        Process.Start("http://w3latinbattle.sytes.net:8080/openstats/")
    End Sub

    Private Sub TestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form4.Show()
    End Sub

    Private Sub VerProcesosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerProcesosToolStripMenuItem.Click
        Process.Start("taskmgr.exe")
    End Sub

    Private Sub VPSLatinBattleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VPSLatinBattleToolStripMenuItem.Click
        WebBrowser1.Navigate("http://latinbattle.com/w3/adm/")
    End Sub

    Private Sub VPSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VPSToolStripMenuItem.Click
        WebBrowser1.Navigate("http://w3latinbattle.sytes.net:8080/adm/")
    End Sub

    Private Sub AdministracionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdministracionToolStripMenuItem.Click
        WebBrowser1.Navigate("https://latinbattle.com/w3/server/")
    End Sub

    Private Function GetExternalIp() As String
        Try
            Dim ExternalIP As String
            ExternalIP = (New System.Net.WebClient()).DownloadString("http://checkip.dyndns.org/")
            ExternalIP = (New System.Text.RegularExpressions.Regex("\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}")) _
                     .Matches(ExternalIP)(0).ToString()
            Return ExternalIP
        Catch
            Return Nothing
        End Try
    End Function

    Shared Function GetIPAddress() As String
        Dim oAddr As System.Net.IPAddress
        Dim sAddr As String
        With System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName())
            oAddr = New System.Net.IPAddress(.AddressList(0).Address)
            sAddr = oAddr.ToString
        End With
        GetIPAddress = sAddr
    End Function

    Private Sub PuertosModoAdministradorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PuertosModoAdministradorToolStripMenuItem.Click
        Form5.Show()
    End Sub

    Private Sub WorldEditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WorldEditToolStripMenuItem.Click
        Form6.Show()
    End Sub


    Private Sub GuiasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuiasToolStripMenuItem.Click
        Process.Start("https://latinbattle.com/category/d2/")
    End Sub

    Private Sub GuiasToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuiasToolStripMenuItem2.Click
        Process.Start("https://latinbattle.com/category/diablo/")
    End Sub

    Private Sub GuiasToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuiasToolStripMenuItem3.Click
        Process.Start("https://latinbattle.com/category/valheim/")
    End Sub

    Private Sub InfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InfoToolStripMenuItem.Click
        Process.Start("https://latinbattle.com/valheim/")
    End Sub

    Private Sub ClasificacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClasificacionToolStripMenuItem.Click
        WebBrowser1.Navigate("http://w3latinbattle.sytes.net:8080/ladder/stats.php?game=DRTL&type=0")
    End Sub

    Private Sub TorneosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TorneosToolStripMenuItem.Click
        WebBrowser1.Navigate("https://latinbattle.com/w3/torneos/")
    End Sub



    Private directorioWarcraft As String 'variable global para almacenar la ruta del directorio del juego Warcraft
    Private archivoRuta As String = "rutaWarcraft.txt" 'nombre del archivo donde se guarda la ruta

    Private Sub EliminarCacheButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles EliminarCacheButton.Click
        'Si la variable directorioWarcraft está vacía, preguntar al usuario por el directorio del juego Warcraft
        If String.IsNullOrEmpty(directorioWarcraft) Then
            'Verificar si existe un archivo de texto con la ruta guardada
            If System.IO.File.Exists(archivoRuta) Then
                'Leer la ruta del archivo y asignarla a la variable global
                directorioWarcraft = System.IO.File.ReadAllText(archivoRuta)
            Else
                'Pedir al usuario que ingrese la ruta del directorio del juego Warcraft
                directorioWarcraft = InputBox("INGRESE DIRECTORIO DEL JUEGO WARCRAFT")
                'Guardar la ruta en un archivo de texto
                System.IO.File.WriteAllText(archivoRuta, directorioWarcraft)
            End If
        End If

        'Eliminar el archivo bncache.dat si existe en el directorio del juego
        Dim archivoCache As String = directorioWarcraft & "\bncache.dat"
        If System.IO.File.Exists(archivoCache) Then
            System.IO.File.Delete(archivoCache)
            MsgBox("Memoria cache borrada con exito.", vbInformation)
        Else
            MsgBox("El archivo bncache.dat no existe en el directorio especificado.", vbExclamation)
        End If
    End Sub

    Private Sub FirewallDeWindowsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FirewallDeWindowsToolStripMenuItem.Click
        Process.Start("wf.msc")
    End Sub

    Private Sub ControlDeCuentasDeUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControlDeCuentasDeUsuarioToolStripMenuItem.Click
        Process.Start("UserAccountControlSettings.exe")
    End Sub

    Private Sub MundosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MundosToolStripMenuItem.Click
        Dim UserName As String = Environment.UserName
        Process.Start("C:\Users\" & UserName & "\AppData\LocalLow\IronGate\Valheim\worlds")
    End Sub

    Private Sub LocalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalToolStripMenuItem.Click
        Dim UserName As String = Environment.UserName
        Process.Start("C:\Users\" & UserName & "\AppData\LocalLow\IronGate\Valheim\characters_local")
    End Sub

    Private Sub NubeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NubeToolStripMenuItem.Click
        Dim UserName As String = Environment.UserName
        Process.Start("C:\Users\" & UserName & "\AppData\LocalLow\IronGate\Valheim\characters")
    End Sub


    Private Sub DescargaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DescargaToolStripMenuItem1.Click
        Form7.ShowDialog()
    End Sub

    Private Sub ExploradorDeWindowsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExploradorDeWindowsToolStripMenuItem.Click
        Process.Start("explorer.exe")
    End Sub

    Private Sub NotepadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotepadToolStripMenuItem.Click
        Process.Start("Notepad.exe")
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Process.Start("calc.exe")
    End Sub
End Class
