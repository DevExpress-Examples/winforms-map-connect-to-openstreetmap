Imports System
Imports System.Net
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace ConnectToOpenStreet
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			' Create a map control.
			Dim map As New MapControl()

			' Specify the map position on the form.           
			map.Dock = DockStyle.Fill

			' Add the map control to the window.
			Me.Controls.Add(map)

			' Create an image tiles layer and add it to the map.
			Dim tileLayer As New ImageLayer()
			map.Layers.Add(tileLayer)

			' Create an Open Street data provider.
			Dim provider As New OpenStreetMapDataProvider()
			tileLayer.DataProvider = provider

			' Specify a template that is used to obtain image tiles. 
			provider.TileUriTemplate = "http://{0}.tile.MyCustomOSMProvider.org/{1}/{2}/{3}.png"

			AddHandler provider.WebRequest, AddressOf OnWebRequest
		End Sub

		Private Sub OnWebRequest(ByVal sender As Object, ByVal e As MapWebRequestEventArgs)
			e.UserAgent = "XtraMap Getting Started - Connect to OpenStreetMap"
		End Sub
	End Class
End Namespace
