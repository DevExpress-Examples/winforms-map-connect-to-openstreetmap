Imports System
Imports System.Net
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace ConnectToOpenStreet

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' Create a map control.
            Dim map As MapControl = New MapControl()
            ' Specify the map position on the form.           
            map.Dock = DockStyle.Fill
            ' Add the map control to the window.
            Me.Controls.Add(map)
            ' Create an image tiles layer and add it to the map.
            Dim tileLayer As ImageLayer = New ImageLayer()
            map.Layers.Add(tileLayer)
            ' Create an Open Street data provider.
            Dim provider As OpenStreetMapDataProvider = New OpenStreetMapDataProvider()
            tileLayer.DataProvider = provider
            ' Specify a template that is used to obtain image tiles. 
            provider.TileUriTemplate = "https://{0}.tile.MyCustomOSMProvider.org/{1}/{2}/{3}.png"
            AddHandler provider.WebRequest, AddressOf OnWebRequest
        End Sub

        Private Sub OnWebRequest(ByVal sender As Object, ByVal e As MapWebRequestEventArgs)
            e.UserAgent = "Sample app with OSM tiles"
            e.Referer = "https://www.mycompanysite.com/"
        End Sub
    End Class
End Namespace
