using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace TMap
{
    public partial class Form1 : Form
    {
        private List<PointLatLng> _points;

        public Form1()
        {
            InitializeComponent();
            _points = new List<PointLatLng>();
        }

        private void LoadMap(PointLatLng point)
        {
            map.Position = point;
        }

        private void AddMarker(PointLatLng pointToAdd, GMarkerGoogleType markerType = GMarkerGoogleType.arrow)
        {
            var markers = new GMapOverlay("markers");
            var marker = new GMarkerGoogle(pointToAdd, markerType);
            markers.Markers.Add(marker);
            map.Overlays.Add(markers);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GMapProviders.GoogleMap.ApiKey = AppConfig.Key;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            map.CacheLocation = @"cache"; // Enter the folder with the downloaded maps 
            map.DragButton = MouseButtons.Left;

            map.MapProvider = GMapProviders.GoogleMap;
            map.ShowCenter = false;
            map.MinZoom = 3;  // Minimum Zoom Level
            map.MaxZoom = 21;  // Maximum Zoom Level
            map.Zoom = 10;  // Current Zoom Level

            map.SetPositionByKeywords("Kyiv, Ukraine");
        }

        GMapOverlay markers = new GMapOverlay("markers");
        private void btnLoadIntoMap_Click(object sender, EventArgs e)
        {
            if(!(txtLat.Text.Trim().Equals("") && txtLng.Text.Trim().Equals("")))
            {
                // Reverse Geocoding
                MessageBox.Show("Reverse Geogoding");
                var point = new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLng.Text));
                LoadMap(point);
                AddMarker(point);
            }
            else
            {
                // Geocoding
                if (!txtAddress.Text.Trim().Equals(""))
                {
                    GeoCoderStatusCode statusCode;
                    var pointLatLng = GoogleMapProvider.Instance.GetPoint(txtAddress.Text.Trim(), out statusCode);
                    if (statusCode == GeoCoderStatusCode.OK)
                    {
                        txtLat.Text = pointLatLng?.Lat.ToString();
                        txtLng.Text = pointLatLng?.Lng.ToString();
                        btnLoadIntoMap.PerformClick();

                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong. Returned Status Code" + statusCode);
                    }
                }
                else
                {
                    MessageBox.Show("Недійсні дані для завантаження");
                }    
            }
        }

        private void btnAddPoint_Click(object sender, EventArgs e)
        {   
            _points.Add(new PointLatLng(Convert.ToDouble(txtLat.Text),
                Convert.ToDouble(txtLng.Text)));
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            _points.Clear();
        }

        private void btnGetRouteInfo_Click(object sender, EventArgs e)
        {
            if (!(txtLat.Text.Trim().Equals("") && txtLng.Text.Trim().Equals("")))
            {
                var route = GoogleMapProvider.Instance.GetRoute(_points[0], _points[1], false, false, 14);
                var r = new GMapRoute(route.Points, "My Route");
                var routes = new GMapOverlay("routes");
                routes.Routes.Add(r);
                map.Overlays.Add(routes);
                lblDistance.Text = route.Distance + " KM";
            }
            else
            {
                MessageBox.Show("Недійсні дані для завантаження");
            }
        }

        private void btnAddPoly_Click(object sender, EventArgs e)
        {
            var polygon = new GMapPolygon(_points, "My Area") 
            { 
                Stroke = new Pen(Color.DarkGreen, 2),
                // Fill = new SolidBrush(Color.BurlyWood)
            };
            var polygons = new GMapOverlay("polygons");
            polygons.Polygons.Add(polygon);
            map.Overlays.Add(polygons);
        }

        private void btnRemoveOverlay_Click(object sender, EventArgs e)
        {
            if (map.Overlays.Count > 0)
            {
                map.Overlays.RemoveAt(0);
                map.Refresh();
            }
        }

        private void map_MouseClick(object sender, MouseEventArgs e)
        {
            if(chkMouseClick.Checked == true && e.Button == MouseButtons.Right)
            {
                var point = map.FromLocalToLatLng(e.X, e.Y);
                double lat = point.Lat;
                double lng = point.Lng;

                txtLat.Text = lat + "";
                txtLng.Text = lng + "";

                // Load Location
                LoadMap(point);

                // Adding Marker 
                AddMarker(point);

                // Get Address
                var addresses = GetAddress(point);

                // Display Address
                if (addresses != null)
                    txtAddress.Text = "Address: \n" + String.Join(", ", addresses.ToArray());
                else
                    txtAddress.Text = "Unable To Load Address";
            }
        }

        private List<String> GetAddress(PointLatLng point)
        {
            List<Placemark> placemarks = null;
            var statusCode = GMapProviders.GoogleMap.GetPlacemarks(point, out placemarks);
            // if(statusCode == GeoCoderStatusCode.G_GEO_SUCCESS && placemarks != null)
            if (statusCode == GeoCoderStatusCode.OK && placemarks != null)
            {
                List<String> addresses = new List<string>();
                foreach(var placemark in placemarks)
                {
                    addresses.Add(placemark.Address);
                }
                return addresses;
            } 
            return null;
        }
    }
}
