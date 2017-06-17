Public Class basicinfo_form

    Private Sub fillView(i As Integer)
        Dim target_item As MSXML2.IXMLDOMNode = itemList.item(i)

        LB_Address.Text = target_item.selectSingleNode("platPlc").text
        TB_bldNm.Text = target_item.selectSingleNode("bldNm").text
        TB_archGbCdNm.Text = target_item.selectSingleNode("archGbCdNm").text
        TB_platArea.Text = target_item.selectSingleNode("platArea").text
        TB_archArea.Text = target_item.selectSingleNode("archArea").text
        TB_bcRat.Text = target_item.selectSingleNode("bcRat").text
        TB_vlRat.Text = target_item.selectSingleNode("vlRat").text
        TB_mainPurpsCdNm.Text = target_item.selectSingleNode("mainPurpsCdNm").text
    End Sub

    Private Sub basicinfo_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objXMLDoc As New MSXML2.DOMDocument60   'XML DOM OBJ for USE XML DOM PARSE WINAPI(Ver 6.0)
        Dim xml_source As String    'temp val for save xml String

        Dim query_address As String     'Encoded(URL) Address String
        Dim url_mapview As String   'URL For Show DAUM MAP(Custom Server)
        Dim url_permission As String   'URL For Architecture Permission
        Dim url_ad2point As String 'DAUM API For Convert Address to Coordinate

        url_permission = "http://apis.data.go.kr/1611000/ArchPmsService/getApBasisOulnInfo?sigunguCd=" & Target_Building.sigunguCd & "&bjdongCd=" & Target_Building.bjdongCd & "&bun=" & Target_Building.bun & "&ji=" & Target_Building.ji & "&ServiceKey=" & SERVICE_KEY

        xml_source = getHttpResponse(url_permission)    'HTTP GET To url_permission

        With objXMLDoc      'LOAD XMLSTRING TO OBJXMLDOC
            .async = False
            .validateOnParse = False
            .resolveExternals = False
            .loadXML(xml_source)
        End With

        itemList = objXMLDoc.getElementsByTagName("item")   'split nodes as 'item' tag

        If itemList.length > 0 Then     'Fill ComboBox As Date
            For i As Integer = 0 To itemList.length - 1
                CB_Date.Items.Add(itemList.item(i).selectSingleNode("archPmsDay").text)
            Next
            CB_Date.SelectedIndex = 0
        Else
            ResultMsg.Text = "조회 가능한 건축인허가 정보가 존재하지 않습니다."
        End If

        fillView(0)     'CALL SUBROUTINE

        'get information for load daum map
        query_address = Net.WebUtility.UrlEncode(LB_Address.Text)   'Encode Korean String to Unicode For Format URL to API Form
        url_ad2point = "http://apis.daum.net/local/geo/addr2coord?apikey=202dc80b6974454f91f89bff0c98f163&q=" & query_address & "&output=xml"

        xml_source = getHttpResponse(url_ad2point)

        With objXMLDoc  'LOAD XMLSTRING TO OBJXMLDOC
            .async = False
            .validateOnParse = False
            .resolveExternals = False
            .loadXML(xml_source)
        End With

        Dim itemList_mapapi As MSXML2.IXMLDOMNodeList = objXMLDoc.getElementsByTagName("item")   'split nodes as 'item' tag

        Dim lat As String = itemList_mapapi.item(0).selectSingleNode("lat").text
        Dim lng As String = itemList_mapapi.item(0).selectSingleNode("lng").text

        'Set URL For WebBrowser Navigate
        query_address = Net.WebUtility.UrlEncode(LB_Address.Text)   'Encode Korean String to Unicode For Format URL to API Form
        url_mapview = "http://api.cerastium.link/index.php?lat=" & lat & "&lng=" & lng & "&address=" & query_address

        WB_RoadView.Navigate(url_mapview)
    End Sub

    Private Sub CB_Date_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Date.SelectedIndexChanged
        Dim i As Integer
        i = CB_Date.SelectedIndex

        fillView(i)     'Context Switching
    End Sub

    Private Sub ShowAllButton_Click(sender As Object, e As EventArgs) Handles ShowAllButton.Click
        all_info.Show()
    End Sub
End Class