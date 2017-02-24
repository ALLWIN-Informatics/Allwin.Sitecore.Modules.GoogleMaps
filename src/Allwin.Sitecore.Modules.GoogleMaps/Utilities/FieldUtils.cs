using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Resources.Media;
using System.Collections.Generic;

namespace Allwin.Sitecore.Modules.GoogleMaps.Utilities
{
    /// <summary>
    /// The field utils.
    /// </summary>
    public static class FieldUtils
    {
        /// <summary>
        /// Gets a checkbox value.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="fieldName">The field name.</param>
        /// <returns></returns>
        public static bool GetCheckBoxValue(this Item item, string fieldName)
        {
            if (item == null || item.Fields == null || item.Fields[fieldName] == null)
            {
                return false;
            }

            return new CheckboxField(item.Fields[fieldName]).Checked;
        }

        /// <summary>
        /// Gets a droplink selected item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="fieldName">The field name.</param>
        /// <returns></returns>
        public static Item GetDropLinkSelectedItem(this Item item, string fieldName)
        {
            if (item == null || item.Fields == null || item.Fields[fieldName] == null)
            {
                return null;
            }

            return new InternalLinkField(item.Fields[fieldName])?.TargetItem;
        }

        /// <summary>
        /// Gets a multli list values.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="fieldName">The field name.</param>
        /// <returns></returns>
        public static IEnumerable<Item> GetMultiListValues(this Item item, string fieldName)
        {
            if (item == null || item.Fields == null || item.Fields[fieldName] == null)
            {
                return null;
            }

            return new MultilistField(item.Fields[fieldName])?.GetItems();
        }

        /// <summary>
        /// Gets the path of an image.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="fieldName">The field name.</param>
        /// <returns></returns>
        public static string GetImage(this Item item, string fieldName)
        {
            if (item == null || item.Fields == null || item.Fields[fieldName] == null)
            {
                return null;
            }

            var imgField = new ImageField(item.Fields[fieldName]);

            if (imgField.MediaItem == null)
                return string.Empty;

            return MediaManager.GetMediaUrl(imgField.MediaItem, new MediaUrlOptions()
            {
                AlwaysIncludeServerUrl = true,
                IncludeExtension = true
            });
        }

        /// <summary>
        /// Gets the 
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="fieldName">The field name.</param>
        /// <returns></returns>
        public static string GetString(this Item item, string fieldName)
        {
            if (item == null || item.Fields == null || item.Fields[fieldName] == null)
            {
                return null;
            }

            return item[fieldName];
        }
    }
}