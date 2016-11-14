Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.TrackBarRenderer

Public Class Options
   
    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        On Error Resume Next


        Timer1.Enabled = True


        My.Computer.Audio.Play(My.Resources.BGM_BubbleWorld, AudioPlayMode.BackgroundLoop)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        On Error Resume Next

        Dim CurrVol As UInteger = 0
        waveOutGetVolume(IntPtr.Zero, CurrVol)
        Dim CalcVol As UShort = CUShort((CurrVol And &HFFFF))
        TrackBar1.Value = CalcVol / (UShort.MaxValue / 10)
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        On Error Resume Next
        Dim NewVolume As Integer = ((UShort.MaxValue / 10) * TrackBar1.Value)
        Dim NewVolumeAllChannels As UInteger = ((CUInt(NewVolume) And &HFFFF) Or (CUInt(NewVolume) << 16))
        waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels)
    End Sub
End Class