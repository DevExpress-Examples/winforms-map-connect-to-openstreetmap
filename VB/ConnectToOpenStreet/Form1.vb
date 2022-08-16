Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace ConnectToOpenStreet

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' Create a Map Control object.
            Dim map As MapControl = New MapControl()
            ' Specify the map position on the form.           
            map.Dock = DockStyle.Fill
            ' Add the Map Control to the form.
            Me.Controls.Add(map)
            ' Create an image tiles layer and add it to the map.
            Dim tilesLayer As ImageLayer = New ImageLayer()
            map.Layers.Add(tilesLayer)
            ' Create an Open Street Map data provider.
            Dim provider As OpenStreetMapDataProvider = New OpenStreetMapDataProvider()
            tilesLayer.DataProvider = provider
            ' Specify the TileUriTemplate property to connect the Map Control to an OSM server. 
            provider.TileUriTemplate = "http://{0}.tile.MyCustomOSMProvider.org/{1}/{2}/{3}.png"
        End Sub
    End Class
End Namespace
