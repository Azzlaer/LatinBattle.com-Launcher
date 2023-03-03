Imports System.Security.Principal

Public Class Form2
    Dim objShell = CreateObject("Wscript.Shell")

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim currentIdentity As WindowsIdentity = WindowsIdentity.GetCurrent()
        Dim currentPrincipal As New WindowsPrincipal(currentIdentity)
        Dim isAdmin As Boolean = currentPrincipal.IsInRole(WindowsBuiltInRole.Administrator)
        If isAdmin Then
            Label33.Text = "MODO ADMINISTRADOR: ACTIVADO"
        Else
            Label33.Text = "MODO ADMINISTRADOR: DESACTIVADO"
            MsgBox("ABRE LA APLICACION EN MODO ADMINISTRADOR PARA PODER USAR ESTA SECCION", vbInformation)
            TabControl1.Enabled = False
        End If


        TextBox1.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Blizzard Entertainment\Warcraft III\", "GamePath", " ")
        TextBox2.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Blizzard Entertainment\Warcraft III\", "InstallPath", " ")
        TextBox3.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Blizzard Entertainment\Warcraft III\", "UninstallPath", " ")

        TextBox6.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\", "GamePath", " ")
        TextBox7.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\", "InstallPath", " ")
        TextBox8.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\", "Program", " ")
        TextBox9.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\", "ProgramX", " ")
        TextBox10.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\", "User Game Save Folder", " ")
        TextBox11.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\", "War3CD", " ")
        TextBox12.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\", "War3XCD", " ")

        TextBox4.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\DelOpt3", "Path0", " ")
        TextBox13.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\DelOpt3", "File0", " ")


        TextBox5.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\DelOpt2", "Path0", " ")
        TextBox14.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\DelOpt2", "File0", " ")

        TextBox18.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\DelOpt2", "Path1", " ")
        TextBox16.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\DelOpt2", "File1", " ")

        TextBox17.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\DelOpt2", "Path2", " ")
        TextBox15.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\DelOpt2", "File2", " ")

        TextBox20.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\DelOpt2", "Path3", " ")
        TextBox19.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\DelOpt2", "File3", " ")

        TextBox21.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\String", "userbnet", " ")
        TextBox22.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\String", "userlocal", " ")

        TextBox23.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\Video", "resheight", " ")
        TextBox24.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\Video", "reswidth", " ")

        TextBox25.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\Video", "windowheight", " ")
        TextBox26.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\Video", "windowwidth", " ")


        TextBox29.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\Video", "refreshrate", " ")
        TextBox30.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\Video", "cinematicheight", " ")
        TextBox31.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\Video", "cinematicwidth", " ")
        TextBox32.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\Video", "cinematicrefresh", " ")
        TextBox27.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\Video", "maxfps", " ")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        GroupBox4.Enabled = True
        GroupBox5.Enabled = True
        GroupBox6.Enabled = True
        Button3.Enabled = True
        Button6.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        GroupBox1.Enabled = True
        GroupBox2.Enabled = True
        GroupBox3.Enabled = True
        Button5.Enabled = True
        Button2.Enabled = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            objShell.RegWrite("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\Video\vsync", "1", "REG_DWORD")
        Else
            objShell.RegWrite("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\Video\vsync", "0", "REG_DWORD")
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            objShell.RegWrite("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\Video\unitshadows", "1", "REG_DWORD")
        Else
            objShell.RegWrite("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\Video\unitshadows", "0", "REG_DWORD")
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            objShell.RegWrite("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\Video\occlusion", "1", "REG_DWORD")
        Else
            objShell.RegWrite("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\Video\occlusion", "0", "REG_DWORD")
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            objShell.RegWrite("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\Video\fixedaspect", "1", "REG_DWORD")
        Else
            objShell.RegWrite("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\Video\fixedaspect", "0", "REG_DWORD")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\String", "userbnet", TextBox21.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\String\", "userlocal", TextBox22.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\DelOpt3", "Path0", TextBox4.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\DelOpt3", "File0", TextBox13.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\DelOpt2", "Path0", TextBox5.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\DelOpt2", "File0", TextBox14.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\DelOpt2", "Path1", TextBox18.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\DelOpt2", "File1", TextBox16.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\DelOpt2", "Path2", TextBox17.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\DelOpt2", "File2", TextBox15.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\DelOpt2", "Path3", TextBox20.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\DelOpt2", "File3", TextBox19.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\String", "userbnet", TextBox21.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\String", "userlocal", TextBox22.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\Video", "resheight", TextBox23.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\Video", "reswidth", TextBox24.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\Video", "windowheight", TextBox25.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\Video", "windowwidth", TextBox26.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\Video", "refreshrate", TextBox29.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\Video", "cinematicheight", TextBox30.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\Video", "cinematicwidth", TextBox31.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\Video", "cinematicrefresh", TextBox32.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\Video", "maxfps", TextBox27.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        GroupBox4.Enabled = False
        GroupBox5.Enabled = False
        GroupBox6.Enabled = False
        Button4.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\", "GamePath", TextBox6.Text, Microsoft.Win32.RegistryValueKind.Unknown)

        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Blizzard Entertainment\Warcraft III", "GamePath", TextBox1.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Blizzard Entertainment\Warcraft III", "InstallPath", TextBox2.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Blizzard Entertainment\Warcraft III\", "UninstallPath", TextBox3.Text, Microsoft.Win32.RegistryValueKind.Unknown)



        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\", "InstallPath", TextBox7.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\", "Program", TextBox8.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\", "ProgramX", TextBox9.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\", "User Game Save Folder", TextBox10.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\", "War3CD", TextBox11.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\", "War3XCD", TextBox12.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\DelOpt3", "Path0", TextBox4.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\DelOpt3", "File0", TextBox13.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\DelOpt3", "File0", TextBox13.Text, Microsoft.Win32.RegistryValueKind.Unknown)

        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\DelOpt2", "Path0", TextBox5.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\DelOpt2", "File0", TextBox14.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\DelOpt2", "Path1", TextBox18.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\DelOpt2", "Path2", TextBox17.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\DelOpt2", "File1", TextBox16.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\DelOpt2", "File2", TextBox15.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\DelOpt2", "Path3", TextBox20.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\DelOpt2", "File3", TextBox19.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\String", "userbnet", TextBox21.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\String", "userlocal", TextBox22.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\Video", "resheight", TextBox23.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\Video", "reswidth", TextBox24.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\Video", "windowheight", TextBox25.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment\Warcraft III\Video", "windowwidth", TextBox26.Text, Microsoft.Win32.RegistryValueKind.Unknown)
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        GroupBox3.Enabled = False
        Button5.Enabled = False
        Button1.Enabled = False


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        GroupBox3.Enabled = False
        Button5.Enabled = False
        Button2.Enabled = False
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        GroupBox4.Enabled = False
        GroupBox5.Enabled = False
        GroupBox6.Enabled = False
        Button3.Enabled = False
        Button6.Enabled = False
    End Sub
End Class