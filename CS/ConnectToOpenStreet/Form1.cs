using System;
using System.Windows.Forms;
using DevExpress.XtraMap;

namespace ConnectToOpenStreet {
    public partial class Form1 : Form {
        public Form1() {
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
            ImageLayer tilesLayer = new ImageLayer();
            map.Layers.Add(tilesLayer);            

            // Create an Open Street data provider.
            OpenStreetMapDataProvider provider = new OpenStreetMapDataProvider();
            tilesLayer.DataProvider = provider;

        }
    }
}
