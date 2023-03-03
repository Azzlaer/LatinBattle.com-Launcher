Imports System.Security.Principal
Imports Microsoft.Win32
Imports System.Diagnostics
Imports System.IO

Public Class Form6
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://www.hiveworkshop.com/threads/reset-editor-registry.336183/")
    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim currentIdentity As WindowsIdentity = WindowsIdentity.GetCurrent()
        Dim currentPrincipal As New WindowsPrincipal(currentIdentity)
        Dim isAdmin As Boolean = currentPrincipal.IsInRole(WindowsBuiltInRole.Administrator)
        If isAdmin Then
            Label5.Text = "MODO ADMINISTRADOR: ACTIVADO"
        Else
            Label5.Text = "MODO ADMINISTRADOR: DESACTIVADO"
            MsgBox("ABRE LA APLICACION EN MODO ADMINISTRADOR PARA PODER USAR ESTA SECCION", vbInformation)
            GroupBox1.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Computer.Registry.CurrentUser.DeleteSubKey("Software\Blizzard Entertainment\WorldEdit")
        MsgBox("Usted ha eliminado toda configuracion de WorldEdit, se recomienda utilizar el siguiente boton INSTALACION MINIMA.", vbInformation)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
    Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Blizzard Entertainment\WorldEdit", True)
        If key IsNot Nothing Then
            Try
                Dim filePath As String = Application.StartupPath & "\WorldEdit.reg"
                Using sw As New StreamWriter(filePath)
                    sw.WriteLine("Windows Registry Editor Version 5.00")
                    sw.WriteLine()
                    sw.WriteLine("[HKEY_CURRENT_USER\Software\Blizzard Entertainment\WorldEdit]")
                    For Each valueName As String In key.GetValueNames()
                        sw.WriteLine("""" & valueName & """=""" & key.GetValue(valueName).ToString() & """")
                    Next
                End Using
                MessageBox.Show("La copia de seguridad se ha creado con éxito.")
            Catch ex As Exception
                MessageBox.Show("Error al crear la copia de seguridad: " & ex.Message)
            End Try
        Else
            MessageBox.Show("La clave de registro no existe.")
        End If
    End Sub

End Class