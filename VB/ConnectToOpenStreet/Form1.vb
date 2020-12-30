Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace ConnectToOpenStreet
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' Create a map control.
            Dim map As New MapControl()

            ' Specify the map position on the form.           
            map.Dock = DockStyle.Fill

            ' Add the map control to the window.
            Me.Controls.Add(map)

            ' Create an image tiles layer and add it to the map.
            Dim tilesLayer As New ImageLayer()
            map.Layers.Add(tilesLayer)

            ' Create an Open Street data provider.
            Dim provider As New OpenStreetMapDataProvider()
            tilesLayer.DataProvider = provider
        
            ' Specify the TileUriTemplate property to connect the Map Control to an OSM server. 
            provider.TileUriTemplate = "http://{0}.tile.MyCustomOSMProvider.org/{1}/{2}/{3}.png"

        End Sub
    End Class
End Namespace
