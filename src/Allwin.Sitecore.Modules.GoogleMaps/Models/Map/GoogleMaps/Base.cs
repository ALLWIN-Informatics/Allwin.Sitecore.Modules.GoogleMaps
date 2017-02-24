using Newtonsoft.Json;
using Sitecore.Data.Items;
using System.Web.Script.Serialization;

namespace Allwin.Sitecore.Modules.GoogleMaps.Models.Map.GoogleMaps
{
    /// <summary>
    /// The base class for all models.
    /// </summary>
    [JsonObject]
    public abstract class Base
    {
        /// <summary>
        /// The constructor.
        /// </summary>
        /// <param name="item">The item.</param>
        protected Base(Item item)
        {
            this.Item = item;
        }

        /// <summary>
        /// The item.
        /// </summary>
        [JsonIgnore]
        [ScriptIgnore]
        public Item Item { get; set; }
    }
}