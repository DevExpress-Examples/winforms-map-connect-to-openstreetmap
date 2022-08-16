using System;
using System.Net;
using System.Windows.Forms;
using DevExpress.XtraMap;

namespace ConnectToOpenStreet {
    public partial class Form1 : Form {
        public Form1() {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create a map control.
            MapControl map = new MapControl();

            // Specify the map position on the form.           
            map.Dock = DockStyle.Fill;

            // Add the map control to the window.
            this.Controls.Add(map);

            // Create an image tiles layer and add it to the map.
            ImageLayer tileLayer = new ImageLayer();
            map.Layers.Add(tileLayer);            

            // Create an Open Street data provider.
            OpenStreetMapDataProvider provider = new OpenStreetMapDataProvider();
            tileLayer.DataProvider = provider;

            // Specify a template that is used to obtain image tiles. 
            provider.TileUriTemplate = "http://{0}.tile.MyCustomOSMProvider.org/{1}/{2}/{3}.png";

            provider.WebRequest += OnWebRequest;
        }

        private void OnWebRequest(object sender, MapWebRequestEventArgs e) {
            e.UserAgent = "Sample app with OSM tiles";
            e.Referer = "https://www.mycompanysite.com/";
        }
    }
}
