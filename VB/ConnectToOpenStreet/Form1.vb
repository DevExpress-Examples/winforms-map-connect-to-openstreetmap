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
            ' Create a map control.
            Dim map As MapControl = New MapControl()
            ' Specify the map position on the form.           
            map.Dock = DockStyle.Fill
            ' Add the map control to the window.
            Me.Controls.Add(map)
            ' Create an image tiles layer and add it to the map.
            Dim tilesLayer As ImageTilesLayer = New ImageTilesLayer()
            map.Layers.Add(tilesLayer)
            ' Create an Open Street data provider.
            Dim provider As OpenStreetMapDataProvider = New OpenStreetMapDataProvider()
            tilesLayer.DataProvider = provider
        End Sub
    End Class
End Namespace
