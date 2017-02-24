using Newtonsoft.Json;
using Sitecore.Data.Items;
using Allwin.Sitecore.Modules.GoogleMaps.Constant;
using Allwin.Sitecore.Modules.GoogleMaps.Utilities;
using System.Collections.Generic;

namespace Allwin.Sitecore.Modules.GoogleMaps.Models.Map.GoogleMaps
{
    /// <summary>
    /// The styler.
    /// </summary>
    [JsonObject]
    public class Styler : Base
    {
        /// <summary>
        /// The constructor.
        /// </summary>
        /// <param name="item">The item.</param>
        public Styler(Item item) : base(item)
        {
        }

        /// <summary>
        /// The visibility.
        /// </summary>
        public string Visibility => StringUtils.GetSimpleJson("visibility",  Item?.GetDropLinkSelectedItem(Templates.Styler.FieldNames.Visibility)?.GetString(Templates.DropdownValue.FieldNames.Type), false, true);

        /// <summary>
        /// The invert lightness.
        /// </summary>
        public string InvertLightness => StringUtils.GetSimpleJson("invert_lightness",  Item?.GetCheckBoxValue(Templates.Styler.FieldNames.InvertLightness).ToString().ToLower(), useSeparator: false);

        /// <summary>
        /// The color.
        /// </summary>
        public string Color => StringUtils.GetSimpleJson("color", Item?.GetString(Templates.Styler.FieldNames.Color), false, true);

        /// <summary>
        /// The weight.
        /// </summary>
        public string Weight => StringUtils.GetSimpleJson("weight", Item?.GetString(Templates.Styler.FieldNames.Weight), false, true);

        /// <summary>
        /// The hue.
        /// </summary>
        public string Hue => StringUtils.GetSimpleJson("hue", Item?.GetString(Templates.Styler.FieldNames.Hue), false, true);

        /// <summary>
        /// The saturation.
        /// </summary>
        public string Saturation => StringUtils.GetSimpleJson("saturation", Item?.GetString(Templates.Styler.FieldNames.Saturation), false, true);

        /// <summary>
        /// The lightness.
        /// </summary>
        public string Lightness => StringUtils.GetSimpleJson("lightness", Item?.GetString(Templates.Styler.FieldNames.Lightness), false, true);

        /// <summary>
        /// The gamma.
        /// </summary>
        public string Gamma => StringUtils.GetSimpleJson("gamma", Item?.GetString(Templates.Styler.FieldNames.Gamma), false, true);

        /// <summary>
        /// The properties.
        /// </summary>
        public List<string> Properties => new List<string> {
                                            this.Visibility,
                                            this.InvertLightness,
                                            this.Color,
                                            this.Weight,
                                            this.Hue,
                                            this.Saturation,
                                            this.Lightness,
                                            this.Gamma };
    }
}
