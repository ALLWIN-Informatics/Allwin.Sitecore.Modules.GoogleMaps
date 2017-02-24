using Newtonsoft.Json;
using Sitecore.Data.Items;
using Allwin.Sitecore.Modules.GoogleMaps.Constant;
using Allwin.Sitecore.Modules.GoogleMaps.Utilities;
using System.Globalization;

namespace Allwin.Sitecore.Modules.GoogleMaps.Models.Map.GoogleMaps
{
    [JsonObject]
    public class MarkerOptions : Base
    {
        /// <summary>
        /// The constructor.
        /// </summary>
        /// <param name="item">The item.</param>
        public MarkerOptions(Item item) : base(item) { }

        /// <summary>
        /// The position.
        /// </summary>
        public double PositionLongitude
        {
            get
            {
                double result = 0;

                double.TryParse(this.Item.GetString(Templates.MarkerOptions.FieldNames.Longitude), NumberStyles.Number, CultureInfo.InvariantCulture, out result);

                return result;
            }
        }

        public double PositionLatitude
        {
            get
            {
                double result = 0;

                double.TryParse(this.Item.GetString(Templates.MarkerOptions.FieldNames.Latitude), NumberStyles.Number, CultureInfo.InvariantCulture, out result);

                return result;
            }
        }
        /// <summary>
        /// The name.
        /// </summary>
        public string Name => StringUtils.GetSimpleJson("title", this.Item.GetString(Templates.MarkerOptions.FieldNames.Name), useApostrophe: true, excludePropertyName: true);

        /// <summary>
        /// The icon.
        /// </summary>
        public string Icon => string.IsNullOrEmpty(this.Item.GetString(Templates.MarkerOptions.FieldNames.Icon)) ? string.Empty : this.Item.GetImage(Templates.MarkerOptions.FieldNames.Icon);

        /// <summary>
        /// The content.
        /// </summary>
        public string Content
        {
            get
            {
                if (this.Item.TemplateID == Templates.IDs.TemplatedMapMarker)
                {
                    var ff = this.Item.GetString(Templates.MarkerOptions.FieldNames.InfoWindowTemplate);
                    return (this.Item.GetString(Templates.MarkerOptions.FieldNames.InfoWindowTemplate)).Replace("\"", "\\\"").Replace("\r\n", string.Empty).Replace("\n", string.Empty);
                }                

                // Fallback just for case
                return string.Empty;
            }
        }

        /// <summary>
        /// The use info window.
        /// </summary>
        public bool UseInfoWindow => this.Item.GetCheckBoxValue(Templates.MarkerOptions.FieldNames.UseInfoWindow);
    }
}
