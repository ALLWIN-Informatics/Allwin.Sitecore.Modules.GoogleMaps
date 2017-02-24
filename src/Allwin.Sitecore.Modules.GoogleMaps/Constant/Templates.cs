using Sitecore.Data;

namespace Allwin.Sitecore.Modules.GoogleMaps.Constant
{
    /// <summary>
    /// The templates.
    /// </summary>
    public static class Templates
    {
        public static class IDs
        {
            public static readonly ID SimpleMapMarker = new ID("{444616CA-BE26-46F3-819C-2E0CED85BAF6}");
            public static readonly ID TemplatedMapMarker = new ID("{807FB6FD-A1C6-4F3E-8AAC-42BF6E272853}");
        }

        public static class Styler
        {
            public static class FieldNames
            {
                public static readonly string Visibility = "Visibility";
                public static readonly string InvertLightness = "Invert Lightness";
                public static readonly string Color = "Color";
                public static readonly string Weight = "Weight";
                public static readonly string Hue = "Hue";
                public static readonly string Saturation = "Saturation";
                public static readonly string Lightness = "Lightness";
                public static readonly string Gamma = "Gamma";
            }
        }

        public static class MapOptions
        {
            public static class FieldNames
            {
                public static readonly string MapType = "Map Type";
                public static readonly string BackgroundColor = "Background Color";
                public static readonly string MinZoom = "Min Zoom";
                public static readonly string MaxZoom = "Max Zoom";
                public static readonly string Height = "Height";
                public static readonly string InitialZoom = "Zoom";
                public static readonly string InitialCenterLongitude = "Center Longitude";
                public static readonly string InitialCenterLatitude = "Center Latitude";
                public static readonly string DisableDefaultUI = "Disable Default UI";
                public static readonly string DisableDoubleClickZoom = "Disable Double Click Zoom";
                public static readonly string KeyboardShortcuts = "Keyboard Shortcuts";
                public static readonly string MapMaker = "Map Maker";
                public static readonly string ScrollWheel = "Scroll Wheel";
                public static readonly string Draggable = "Draggable";
                public static readonly string DraggingCursor = "DraggingCursor";
                public static readonly string Heading = "Heading";
                public static readonly string Tilt = "Tilt";
                public static readonly string AskForGeolocation = "Ask For Geolocation";
                public static readonly string IncludeGoogleMapScript = "Include Google Maps Script";
            }
        }

        public static class Style
        {
            public static class FieldNames
            {
                public static readonly string FeatureType = "Feature Type";
                public static readonly string ElementType = "Element Type";
            }
        }

        public static class MarkerOptions
        {
            public static class FieldNames
            {
                public static readonly string Longitude = "Longitude";
                public static readonly string Latitude = "Latitude";
                public static readonly string Name = "Name";
                public static readonly string Icon = "Icon";
                public static readonly string UseInfoWindow = "Use Info Window";
                public static readonly string InfoWindowTemplate = "Info Window Template";
                public static readonly string Title1 = "Title 1";
                public static readonly string Title2 = "Title 2";
                public static readonly string Text = "Text";
                public static readonly string TelephoneLabel = "Telephone label";
                public static readonly string TelephoneNumber = "Telephone number";
                public static readonly string EmailLabel = "Email label";
                public static readonly string Email = "Email";
            }
        }

        public static class Map
        {
            public static class FieldNames
            {
                public static readonly string Styles = "Styles";
                public static readonly string Markers = "Markers";
            }
        }

        public static class DropdownValue
        {
            public static class FieldNames
            {
                public static readonly string Type = "Type";
            }
        }
    }
}
