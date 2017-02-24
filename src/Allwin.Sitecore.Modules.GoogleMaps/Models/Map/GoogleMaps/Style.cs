using System.Collections.Generic;
using Sitecore.Data.Items;
using Allwin.Sitecore.Modules.GoogleMaps.Constant;
using Allwin.Sitecore.Modules.GoogleMaps.Utilities;
using Newtonsoft.Json;

namespace Allwin.Sitecore.Modules.GoogleMaps.Models.Map.GoogleMaps
{
    /// <summary>
    /// The style.
    /// </summary>
    [JsonObject]
    public class Style : Base
    {
        /// <summary>
        /// The constructor.
        /// </summary>
        /// <param name="item">The item.</param>
        public Style(Item item) : base(item)
        {
            this.Stylers = new Styler(item);
        }

        /// <summary>
        /// The feature type.
        /// </summary>
        public string FeatureType => StringUtils.GetSimpleJson("featureType", Item?.GetDropLinkSelectedItem(Templates.Style.FieldNames.FeatureType)?.GetString(Templates.DropdownValue.FieldNames.Type), false, true);

        /// <summary>
        /// The element type.
        /// </summary>
        public string ElementType => StringUtils.GetSimpleJson("elementType", Item?.GetDropLinkSelectedItem(Templates.Style.FieldNames.ElementType)?.GetString(Templates.DropdownValue.FieldNames.Type), false, true);

        /// <summary>
        /// The properties.
        /// </summary>
        public List<string> Properties => new List<string> { FeatureType, ElementType, StringUtils.GetListJson("stylers", this.Stylers.Properties) };

        /// <summary>
        /// The stylers.
        /// </summary>
        Styler Stylers { get; set; }
    }
}
