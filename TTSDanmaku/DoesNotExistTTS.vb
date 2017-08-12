﻿'Google TTS Library
'Source: https://github.com/rcarubbi/Google.TTS/blob/master/Google.TTS/TTSHelper.cs
'Copyright (C) reserved by original author who was known as "rcarubbi".
'Modified by Elepover.

Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Net
Imports System.IO
Imports System.Web
Imports System.Runtime.InteropServices
Imports System.Threading
Namespace Google.TTS
    Public Enum Idioma
        Chinese
        English
    End Enum

    Public Enum ProxyMethod
        ItauProxy
    End Enum

    Public Class TTSHelper
        Private Shared Sub CopyStream(input As Stream, output As Stream)
            Dim buffer As Byte() = New Byte(8 * 1024 - 1) {}
            Dim len As Integer
            While (InlineAssignHelper(len, input.Read(buffer, 0, buffer.Length))) > 0
                output.Write(buffer, 0, len)
            End While
        End Sub

        Private Shared _request As HttpWebRequest
        Public Shared Function URL_TTS_GOOGLE(useGoogleGlobal As Boolean) As String
            If Settings.Settings.HTTPSPreference Then
                If useGoogleGlobal Then
                    Return "https://translate.google.com/translate_tts?ie=UTF-8&tl={1}&q={0}&client=tw-ob"
                Else
                    Return "https://translate.google.cn/translate_tts?ie=UTF-8&tl={1}&q={0}&client=tw-ob"
                End If
            Else
                If useGoogleGlobal Then
                    Return "http://translate.google.com/translate_tts?ie=UTF-8&tl={1}&q={0}&client=tw-ob"
                Else
                    Return "http://translate.google.cn/translate_tts?ie=UTF-8&tl={1}&q={0}&client=tw-ob"
                End If
            End If

        End Function


        Public Shared Property ProxyPath() As String
            Get
                Return m_ProxyPath
            End Get
            Set
                m_ProxyPath = Value
            End Set
        End Property
        Private Shared m_ProxyPath As String

        Public Shared Property ProxyUserName() As String
            Get
                Return m_ProxyUserName
            End Get
            Set
                m_ProxyUserName = Value
            End Set
        End Property
        Private Shared m_ProxyUserName As String

        Public Shared Property ProxyPassword() As String
            Get
                Return m_ProxyPassword
            End Get
            Set
                m_ProxyPassword = Value
            End Set
        End Property
        Private Shared m_ProxyPassword As String

        Public Shared Property ProxyMethod() As System.Nullable(Of ProxyMethod)
            Get
                Return m_ProxyMethod
            End Get
            Set
                m_ProxyMethod = Value
            End Set
        End Property
        Private Shared m_ProxyMethod As System.Nullable(Of ProxyMethod)

        Public Shared Function GerarArquivo(texto As String, idioma__1 As Idioma, googleGlobal As Boolean, Optional useProxy As Boolean = False, Optional proxy As Net.WebProxy = Nothing) As String
            Dim strIdioma As String = If(idioma__1 = Idioma.Chinese, "zh-CN", "en")
            Dim processedStr As String = HttpUtility.UrlEncode(texto, System.Text.Encoding.UTF8)
            Dim url As New Uri(String.Format(URL_TTS_GOOGLE(googleGlobal), processedStr, strIdioma))
            If useProxy Then
                PrepareRequest(url, True, proxy)
            Else
                PrepareRequest(url)
            End If

            Dim response As WebResponse = Nothing
            Try
                response = _request.GetResponse()
            Catch
                If ProxyMethod.HasValue AndAlso ProxyMethod.Value = Google.TTS.ProxyMethod.ItauProxy Then
                    ProxyMethod = Nothing
                    PrepareRequest(url)
                    response = _request.GetResponse()
                End If
            End Try
            Dim fileContent As Stream = response.GetResponseStream()
            Dim caminhoTemp As String = GetRandomFilename()

            Using file__2 As Stream = File.OpenWrite(caminhoTemp)
                CopyStream(fileContent, file__2)
                file__2.Flush()
                file__2.Close()
            End Using

            fileContent.Close()
            fileContent.Dispose()

            Return caminhoTemp
        End Function

        Private Shared Sub PrepareRequest(url As Uri, Optional useProxy As Boolean = False, Optional proxy As Net.WebProxy = Nothing)
            If ProxyMethod.HasValue AndAlso ProxyMethod.Value = Google.TTS.ProxyMethod.ItauProxy Then
                Dim urlBytes As Byte() = Encoding.UTF8.GetBytes(url.AbsolutePath.ToCharArray())
                _request = DirectCast(HttpWebRequest.Create(String.Format(ProxyPath, Convert.ToBase64String(urlBytes))), HttpWebRequest)
                _request.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 2.0.50727)"
                If useProxy Then
                    _request.Proxy = proxy
                End If

                Dim authBytes As Byte() = Encoding.UTF8.GetBytes(String.Format("{0}:{1}", ProxyUserName, ProxyPassword).ToCharArray())
                _request.Headers("Authorization") = "Basic " + Convert.ToBase64String(authBytes)
                _request.KeepAlive = True
                _request.Accept = "*/*"
                _request.Headers("Accept-Encoding") = "identity;q=1, *;q=0, gzip, deflate, sdch, br"

                _request.Headers("Cookie") = "BCSI-CS-578f1ddf35ea416c=2"
            Else
                _request = DirectCast(HttpWebRequest.Create(url), HttpWebRequest)
                _request.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 2.0.50727)"
                _request.UseDefaultCredentials = True
            End If
        End Sub
        'Private Shared _wplayer As WMPLib.WindowsMediaPlayer

        'Public Shared Sub ReproduzirArquivo(parameter As Object)
        '    idle = False

        '    Dim arquivos As List(Of [String]) = DirectCast(parameter, List(Of [String]))

        '    _wplayer = New WMPLib.WindowsMediaPlayer()
        '    Dim _playlist = _wplayer.playlistCollection.newPlaylist("playlist")
        '    For Each arquivo As var In arquivos
        '        Dim media As WMPLib.IWMPMedia = _wplayer.newMedia(Path.Combine(Path.GetTempPath(), arquivo))
        '        _playlist.appendItem(media)
        '    Next
        '    _wplayer.currentPlaylist = _playlist
        '    _wplayer.PlayStateChange += New WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(AddressOf _wplayer_PlayStateChange)
        '    _wplayer.MediaError += New WMPLib._WMPOCXEvents_MediaErrorEventHandler(AddressOf _wplayer_MediaError)
        '    _wplayer.controls.play()


        'End Sub

        Private Shared Sub _wplayer_MediaError(pMediaObject As Object)
            Throw New Exception("Erro ao tentar reproduzir arquivo")
        End Sub

        Shared locker As New Object()
        Shared idle As Boolean = True
        'Private Shared Sub _wplayer_PlayStateChange(NewState As Integer)
        '    Console.WriteLine(DirectCast(NewState, WMPLib.WMPPlayState).ToString())
        '    If DirectCast(NewState, WMPLib.WMPPlayState) = WMPLib.WMPPlayState.wmppsMediaEnded Then
        '        File.Delete(arquivos.First())
        '        arquivos.RemoveAt(0)
        '    ElseIf DirectCast(NewState, WMPLib.WMPPlayState) = WMPLib.WMPPlayState.wmppsStopped OrElse DirectCast(NewState, WMPLib.WMPPlayState) = WMPLib.WMPPlayState.wmppsReady Then
        '        idle = True
        '    End If
        'End Sub

        'Public Shared Sub ReproduzirSincrono(texto As String, idioma As Idioma)
        '    Reproduzir(texto, idioma, True)
        'End Sub

        'Public Shared Sub ReproduzirAsincrono(texto As String, idioma As Idioma)
        '    Reproduzir(texto, idioma, False)
        'End Sub

        Private Shared arquivos As List(Of [String]) = New List(Of String)()
        'Private Shared Sub Reproduzir(texto As String, idioma As Idioma, esperar As Boolean)
        '    Dim trechos As List(Of [String]) = SepararTrechos(texto, 12).ToList()
        '    arquivos.Clear()
        '    For Each trecho As var In trechos
        '        arquivos.Add(GerarArquivo(trecho, idioma))
        '    Next
        '    Dim playerProcess As New Thread(New ParameterizedThreadStart(AddressOf ReproduzirArquivo))

        '    playerProcess.Start(arquivos)
        '    Thread.Sleep(1000)
        '    While esperar AndAlso Not idle
        '        Thread.Sleep(1000)
        '    End While
        'End Sub

        '    Private Shared Function SepararTrechos(texto As String, maxWords As Integer) As IEnumerable(Of String)

        '        Dim palavras = texto.Split(" "c)
        '        Dim countMaxWords As Integer = 0
        '        Dim stbTrecho As New StringBuilder()
        '        For Each palavra As Int32 In palavras
        '            If countMaxWords = 0 Then
        '                stbTrecho.Append(palavra)
        '            Else
        '                stbTrecho.Append(" " + palavra)
        '            End If

        '            If countMaxWords = maxWords OrElse palavra = palavras(palavras.Count() - 1) Then
        '                countMaxWords = 0
        '                Dim retorno = stbTrecho.ToString()
        '                stbTrecho = New StringBuilder()
        '                yield Return retorno
        'End If
        '            countMaxWords += 1
        '        Next
        '    End Function
        Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
            target = value
            Return value
        End Function
    End Class
End Namespace