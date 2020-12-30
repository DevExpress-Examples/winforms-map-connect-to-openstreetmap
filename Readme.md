<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/ConnectToOpenStreet/Form1.cs) (VB: [Form1.vb](./VB/ConnectToOpenStreet/Form1.vb))
<!-- default file list end -->
# XtraMap Getting Started - Lesson 2 - Connect to OpenStreetMap

This example uses [OpenStreetMapDataProvider](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.OpenStreetMapDataProvider) to connect [Map Control](xref:15074) to the [OpenStreetMap](http://www.openstreetmap.org/) service.

>**IMPORTANT: Specify a valid OSM server name in the [OpenStreetMapDataProvider.TileUriTemplate](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.OpenStreetMapDataProvider.TileUriTemplate) property. For instance, you can set your own tile server, use a public OSM server or choose alternative OSM servers. For more information, refer to the following article: [Tile Usage Policy](https://operations.osmfoundation.org/policies/tiles).** 

Follow the steps below to display the OpenStreetMap geodata in the Map Control:

* Use the [ServicePointManager.SecurityProtocol](https://docs.microsoft.com/en-us/dotnet/api/system.net.servicepointmanager.securityprotocol?view=net-5.0) property to specify the network security protocol before the [InitializeComponent](https://docs.microsoft.com/en-us/dotnet/api/system.windows.markup.icomponentconnector.initializecomponent?view=net-5.0.) method call.

* Create a [MapControl](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.MapControl) object. Set the [MapControl.Dock](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control.dock?view=net-5.0#System_Windows_Forms_Control_Dock) property to the **DockStyle.Fill** value to fit the Map Control to the form. Call the [Add](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control.controlcollection.add?view=net-5.0#System_Windows_Forms_Control_ControlCollection_Add_System_Windows_Forms_Control_) method to add the Map Control to the form's control collection.       

* Create [ImageLayer](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.ImageLayer) and use the [MapControl.Layers.Add](http://docs.devexpress.devx/CoreLibraries/DevExpress.Utils.DXCollectionBase-1.Add(-0)) method to add this layer to the map.  

* Create an [OpenStreetMapDataProvider](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.OpenStreetMapDataProvider) object and assign it to the [ImageLayer.DataProvider](https://docs.devexpress.com/CoreLibraries/DevExpress.Utils.DXCollectionBase-1.Add(-0)) property. Specify the [OpenStreetMapDataProvider.TileUriTemplate](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.OpenStreetMapDataProvider.TileUriTemplate) property to load data from an OSM server. Our example contains a sample template string that does not connect to an existing OSM server.   

* Handle the [OpenStreetMapDataProvider.WebRequest](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.MapImageDataProviderBase.WebRequest) event and use the [e.UserAgent](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.MapWebRequestEventArgs.UserAgent) property to pass the user-agent HTTP header to the server.

<br/>
