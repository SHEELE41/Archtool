Module Public_Module
    Public Const SERVICE_KEY As String = "OLptxSAXRKiwE0ALQB0kv1DsY0wjN59FraQai%2BRd0ulpI46nfPBlKGVAlUPUjL%2BYmuaWX1U9BnsM1793jhxmMg%3D%3D"
    'API Service Key define

    Public Structure Building   'Building Structure define
        Dim sigunguCd As String
        Dim bjdongCd As String
        Dim bun As String
        Dim ji As String
    End Structure

    Public Target_Building As Building

    Public Function getHttpResponse(url As String) As String
        Dim WinHttp As New WinHttp.WinHttpRequest
        WinHttp.Open("GET", url)
        WinHttp.Send()
        WinHttp.WaitForResponse()
        Return WinHttp.ResponseText
    End Function

    Public itemList As MSXML2.IXMLDOMNodeList  'List(array) for allocate each nodes
End Module
