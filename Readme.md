<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128576889/18.2.9%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5070)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Map for WinForms - Connect to the OpenStreetMap Service

This example uses [`OpenStreetMapDataProvider`](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.OpenStreetMapDataProvider) to connect [Map Control](https://docs.devexpress.com/WindowsForms/15074/controls-and-libraries/map-control?p=netframework) to the [OpenStreetMap](http://www.openstreetmap.org/) service.

> **IMPORTANT:** Specify a valid OSM server name in the [`OpenStreetMapDataProvider.TileUriTemplate`](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.OpenStreetMapDataProvider.TileUriTemplate) property. For instance, you can set your own tile server, use a public OSM server or choose alternative OSM servers. For more information, refer to the following article: [Tile Usage Policy](https://operations.osmfoundation.org/policies/tiles). 

Follow the steps below to display the OpenStreetMap geodata in the Map Control:

* Use the [`ServicePointManager.SecurityProtocol`](https://docs.microsoft.com/en-us/dotnet/api/system.net.servicepointmanager.securityprotocol?view=net-5.0) property to specify the network security protocol before the [`InitializeComponent`](https://docs.microsoft.com/en-us/dotnet/api/system.windows.markup.icomponentconnector.initializecomponent?view=net-5.0.) method call.

* Create a [`MapControl`](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.MapControl) object. Set the [`MapControl.Dock`](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control.dock?view=net-5.0#System_Windows_Forms_Control_Dock) property to the **DockStyle.Fill** value to fit the Map Control to the form. Call the [Add](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control.controlcollection.add?view=net-5.0#System_Windows_Forms_Control_ControlCollection_Add_System_Windows_Forms_Control_) method to add the Map Control to the form's control collection.       

* Create [`ImageLayer`](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.ImageLayer) and use the [`MapControl.Layers.Add`](https://docs.devexpress.com/CoreLibraries/DevExpress.Utils.DXCollectionBase-1.Add(-0)) method to add this layer to the map.

* Create an [`OpenStreetMapDataProvider`](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.OpenStreetMapDataProvider) object and assign it to the [`ImageLayer.DataProvider`](https://docs.devexpress.com/CoreLibraries/DevExpress.Utils.DXCollectionBase-1.Add(-0)) property. Specify the [`OpenStreetMapDataProvider.TileUriTemplate`](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.OpenStreetMapDataProvider.TileUriTemplate) property to load data from an OSM server. Our example contains a sample template string that does not connect to an existing OSM server.   

* Handle the [`OpenStreetMapDataProvider.WebRequest`](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.MapImageDataProviderBase.WebRequest) event and specify the [`e.UserAgent`](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.MapWebRequestEventArgs.UserAgent) and [`e.Referer`](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.MapWebRequestEventArgs.Referer?p=netframework) properties in the event handler.

## Files to Look At

* [Form1.cs](./CS/ConnectToOpenStreet/Form1.cs) (VB: [Form1.vb](./VB/ConnectToOpenStreet/Form1.vb))

## Documentation

* [Image Tile Providers](https://docs.devexpress.com/WindowsForms/115774/controls-and-libraries/map-control/map-image-data/image-tile-providers)
* [GIS Data](https://docs.devexpress.com/WindowsForms/17858/controls-and-libraries/map-control/gis-data)

## More Examples

* [How to: Use the OpenStreetMap Search Service Via the Map Control](https://github.com/DevExpress-Examples/how-to-use-the-openstreetmap-search-service-via-the-map-control-t629598)
* [How to: Use the OpenStreetMap Geocode Service Via the Map Control](https://github.com/DevExpress-Examples/how-to-use-the-openstreetmap-geocode-service-via-the-map-control-t629683)
