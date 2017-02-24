using Newtonsoft.Json;
using Sitecore.Data.Items;

namespace Allwin.Sitecore.Modules.GoogleMaps.Models.Map.GoogleMaps
{
    /// <summary>
    /// The marker.
    /// </summary>
    [JsonObject]
    public class Marker : Base
    {
        /// <summary>
        /// The constructor.
        /// </summary>
        /// <param name="item">The item.</param>
        public Marker(Item item) : base(item)
        {
        }

        /// <summary>
        /// The max Z index.
        /// </summary>
        [JsonProperty]
        public string MaxZindex { get; set; }

        /// <summary>
        /// The marker options.
        /// </summary>
        [JsonProperty]
        public MarkerOptions MarkerOptions => new MarkerOptions(this.Item);
    }
}
