using System.Collections.Generic;
using Sitecore.Data.Items;
using Allwin.Sitecore.Modules.GoogleMaps.Utilities;
using Allwin.Sitecore.Modules.GoogleMaps.Constant;
using System.Linq;
using Newtonsoft.Json;

namespace Allwin.Sitecore.Modules.GoogleMaps.Models.Map.GoogleMaps
{
    /// <summary>
    /// The Main Map model.
    /// </summary>
    [JsonObject]
    public class Map : Base
    {
        /// <summary>
        /// The constructor.
        /// </summary>
        /// <param name="item">The item.</param>
        public Map(Item item) : base(item)
        {
            var styles = item.GetMultiListValues("Styles");
            this.Styles = new List<Style>();
            foreach (var style in styles)
            {
                this.Styles.Add(new Style(style));
            }
        }

        /// <summary>
        /// The markers.
        /// </summary>
        public List<Marker> Markers => this.Item?.GetMultiListValues(Templates.Map.FieldNames.Markers)?.Select(x => new Marker(x)).ToList();

        /// <summary>
        /// The styles.
        /// </summary>
        public List<Style> Styles { get; set; }

        /// <summary>
        /// The style as JSON.
        /// </summary>
        [JsonProperty]
        public string StylesAsJson => StringUtils.GetObjectListJson(this.Styles.Select(x => x.Properties).ToList());

        /// <summary>
        /// The map options.
        /// </summary>
        public MapOptions MapOptions => new MapOptions(Item);

        /// <summary>
        /// The app id.
        /// </summary>
        public string AppId => global::Sitecore.Configuration.Settings.GetSetting("Allwin.Sitecore.Modules.GoogleMaps.GoogleMaps.AppId", string.Empty);
    }
}