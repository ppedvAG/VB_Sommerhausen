
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Text
Imports Microsoft.Win32

<ProgId("Form1_Mit_CheckBox")>
<Guid("7821178F-0D28-4D69-B669-38A66B314C13")>
<ComVisible(True)>
Public Class Form1


    <ComRegisterFunction()>
    Public Shared Sub RegisterClass(key As String)
        Dim sb As StringBuilder = New StringBuilder(key)
        sb.Replace("HKEY_CLASSES_ROOT\", "")
        Dim k As RegistryKey = Registry.ClassesRoot.OpenSubKey(sb.ToString(), True)
        Dim ctrl As RegistryKey = k.CreateSubKey("Control")
        ctrl.Close()
        Dim inprocServer32 As RegistryKey = k.OpenSubKey("InprocServer32", True)
        inprocServer32.SetValue("CodeBase", Assembly.GetExecutingAssembly().CodeBase)
        inprocServer32.Close()
        k.Close()
        MessageBox.Show("Registered")
    End Sub



    <ComUnregisterFunction()>
    Public Shared Sub UnregisterClass(key As String)
        Dim sb As StringBuilder = New StringBuilder(key)
        sb.Replace("HKEY_CLASSES_ROOT\", "")
        Dim k As RegistryKey = Registry.ClassesRoot.OpenSubKey(sb.ToString(), True)
        k.DeleteSubKey("Control", False)
        k.OpenSubKey("InprocServer32", True)
        k.DeleteSubKey("CodeBase", False)
        k.Close()
        MessageBox.Show("UnRegistered")
    End Sub


End Class
