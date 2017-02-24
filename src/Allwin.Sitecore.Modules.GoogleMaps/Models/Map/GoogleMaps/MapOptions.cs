using Newtonsoft.Json;
using Sitecore.Data.Items;
using Allwin.Sitecore.Modules.GoogleMaps.Constant;
using Allwin.Sitecore.Modules.GoogleMaps.Utilities;
using System.Collections.Generic;

namespace Allwin.Sitecore.Modules.GoogleMaps.Models.Map.GoogleMaps
{
    /// <summary>
    /// The Main Map model.
    /// </summary>
    [JsonObject]
    public class MapOptions : Base
    {
        /// <summary>
        /// The constructor.
        /// </summary>
        /// <param name="item">The item.</param>
        public MapOptions(Item item) : base (item) { }

        #region Style Settings

        /// <summary>
        /// The map type.
        /// </summary>
        public string MapType => StringUtils.GetSimpleJson("mapTypeId", FieldUtils.GetDropLinkSelectedItem(this.Item, Templates.MapOptions.FieldNames.MapType)?.GetString("Type"));

        /// <summary>
        /// The background color.
        /// </summary>
        public string BackgroundColor => StringUtils.GetSimpleJson("backgroundColor", this.Item.GetString(Templates.MapOptions.FieldNames.BackgroundColor), useApostrophe: true);

        #endregion

        #region Min-Max Settings

        /// <summary>
        /// The minimum zoom.
        /// </summary>
        public string MinZoom => StringUtils.GetSimpleJson("minZoom", this.Item.GetString(Templates.MapOptions.FieldNames.MinZoom));

        /// <summary>
        /// The maximum zoom.
        /// </summary>
        public string MaxZoom => StringUtils.GetSimpleJson("maxZoom", this.Item.GetString(Templates.MapOptions.FieldNames.MaxZoom));

        /// <summary>
        /// Gets the height.
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        public string Height => this.Item.GetString(Templates.MapOptions.FieldNames.Height);

        #endregion

        #region Initial Settings

        /// <summary>
        /// The initial zoom.
        /// </summary>
        public string InitialZoom => StringUtils.GetSimpleJson("zoom", this.Item?.GetString(Templates.MapOptions.FieldNames.InitialZoom));

        /// <summary>
        /// The initial center.
        /// </summary>
        public string InitialCenter => StringUtils.GetSimpleJson("center", StringUtils.GetObjectJson(new List<string> { StringUtils.GetSimpleJson("lng", this.Item?.GetString(Templates.MapOptions.FieldNames.InitialCenterLongitude), false, excludePropertyName: false), StringUtils.GetSimpleJson("lat", this.Item?.GetString(Templates.MapOptions.FieldNames.InitialCenterLatitude), false, excludePropertyName: false) })); // LAT_LON_JSON

        /// <summary>
        /// The heading.
        /// </summary>
        public string Heading => StringUtils.GetSimpleJson("heading", this.Item.GetString(Templates.MapOptions.FieldNames.Heading));

        /// <summary>
        /// The tilt.
        /// </summary>
        public string Tilt => StringUtils.GetSimpleJson("tilt", this.Item.GetString(Templates.MapOptions.FieldNames.Tilt));

        /// <summary>
        /// Gets a value indicating whether [ask for geolocation].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [ask for geolocation]; otherwise, <c>false</c>.
        /// </value>
        public bool AskForGeolocation => this.Item.GetCheckBoxValue(Templates.MapOptions.FieldNames.AskForGeolocation);

        /// <summary>
        /// Gets a value indicating whether [include google map script].
        /// </summary>
        /// <value>
        /// <c>true</c> if [include google map script]; otherwise, <c>false</c>.
        /// </value>
        public bool IncludeGoogleMapScript => this.Item.GetCheckBoxValue(Templates.MapOptions.FieldNames.IncludeGoogleMapScript);

        #endregion

        #region Controls

        /// <summary>
        /// The disable default UI.
        /// </summary>
        public string DisableDefaultUI => StringUtils.GetSimpleJson("disableDefaultUI", this.Item.GetCheckBoxValue(Templates.MapOptions.FieldNames.DisableDefaultUI).ToString().ToLower());

        /// <summary>
        /// The disable double click zoom.
        /// </summary>
        public string DisableDoubleClickZoom => StringUtils.GetSimpleJson("disableDoubleClickZoom", this.Item.GetCheckBoxValue(Templates.MapOptions.FieldNames.DisableDoubleClickZoom).ToString().ToLower());

        /// <summary>
        /// The draggable.
        /// </summary>
        public string Draggable => StringUtils.GetSimpleJson("draggable", this.Item.GetCheckBoxValue(Templates.MapOptions.FieldNames.Draggable).ToString().ToLower());

        /// <summary>
        /// The keyboard shortcuts.
        /// </summary>
        public string KeyboardShortcuts => StringUtils.GetSimpleJson("keyboardShortcuts", this.Item.GetCheckBoxValue(Templates.MapOptions.FieldNames.KeyboardShortcuts).ToString().ToLower());

        /// <summary>
        /// The map maker.
        /// </summary>
        public string MapMaker => StringUtils.GetSimpleJson("mapMaker", this.Item.GetCheckBoxValue(Templates.MapOptions.FieldNames.MapMaker).ToString().ToLower());

        /// <summary>
        /// The scroll wheel.
        /// </summary>
        public string ScrollWheel => StringUtils.GetSimpleJson("scrollwheel", this.Item.GetCheckBoxValue(Templates.MapOptions.FieldNames.ScrollWheel).ToString().ToLower());

        #endregion

        #region Imaging

        /// <summary>
        /// The dragging curzor.
        /// </summary>
        public string DraggingCursor => StringUtils.GetSimpleJson("draggingCursor", this.Item.GetImage(Templates.MapOptions.FieldNames.DraggingCursor), useApostrophe: true);

        #endregion
    }
}