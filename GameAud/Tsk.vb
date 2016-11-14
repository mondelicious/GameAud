Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Module Tsk
    <DllImport("winmm.dll")> _
    Public Function waveOutGetVolume(ByVal hwo As IntPtr, ByRef dwVolume As UInteger) As Integer
    End Function

    <DllImport("winmm.dll")> _
    Public Function waveOutSetVolume(ByVal hwo As IntPtr, ByVal dwVolume As UInteger) As Integer
    End Function
End Module
