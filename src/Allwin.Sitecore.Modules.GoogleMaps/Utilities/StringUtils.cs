using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Allwin.Sitecore.Modules.GoogleMaps.Utilities
{
    /// <summary>
    /// The string utils.
    /// This class for the Google Maps view to render the options directly into the view.
    /// </summary>
    public static class StringUtils
    {
        /// <summary>
        /// Gets the simple JSON property, value  pair.
        /// </summary>
        /// <param name="propertyName">The JSON property name.</param>
        /// <param name="value">The value.</param>
        /// <param name="useSeparator">The use separator at the end of the string.</param>
        /// <returns>
        /// Returned format: "name: string1"
        /// </returns>
        public static string GetSimpleJson(string propertyName, string value, bool useSeparator = true, bool useApostrophe = false, bool excludePropertyName = false)
        {
            if (string.IsNullOrWhiteSpace(propertyName) || string.IsNullOrWhiteSpace(value))
            {
                return string.Empty;
            }

            if (excludePropertyName)
            {
                return string.Format("{0}", value);
            }

            if (useApostrophe)
            {
                return string.Format("{0}: '{1}'{2}", propertyName, value, useSeparator ? "," : string.Empty);
            }

            return string.Format("{0}: {1}{2}", propertyName, value, useSeparator ? "," : string.Empty);
        }

        /// <summary>
        /// Gets the JSON list.
        /// </summary>
        /// <param name="propertyName">The JSON property name.</param>
        /// <param name="values">The values.</param>
        /// <returns>
        /// Returned format: "name: [{string1,string2}]"
        /// </returns>
        public static string GetListJson(string propertyName, List<string> values)
        {
            if (string.IsNullOrWhiteSpace(propertyName) || values == null || !values.Any())
            {
                return string.Empty;
            }

            return string.Format("{0}: [{1}]", propertyName, string.Join(",", values.Where(x => !string.IsNullOrWhiteSpace(x)).Select(x => string.Format("{{{0}}}", x))));
        }

        /// <summary>
        /// Gets the JSON object list.
        /// </summary>
        /// <param name="objectsList">The object value pairs.</param>
        /// <returns>
        /// Returned format: "[{string1,string2}]"
        /// </returns>
        public static string GetObjectListJson(List<List<string>> objectsList)
        {
            if (objectsList == null || !objectsList.Any() || objectsList.Any(x => x == null))
            {
                return string.Empty;
            }

            var listOfObjects = objectsList.Select(objectValuePair => GetObjectJson(objectValuePair)).ToList();

            return string.Format("[{0}]", string.Join(",", listOfObjects.Where(x => !string.IsNullOrWhiteSpace(x))));
        }

        /// <summary>
        /// The object JSON.
        /// </summary>
        /// <param name="propertyName">The property name.</param>
        /// <param name="objects">The objects</param>
        /// <returns>
        /// Returned format: "{string1,string2}"
        /// </returns>
        public static string GetObjectJson(List<string> objects)
        {
            if (objects == null || !objects.Any())
            {
                return string.Empty;
            }

            return "{" + string.Join(",", objects.Where(x => !string.IsNullOrWhiteSpace(x))) + "}";
        }

        /// <summary>
        /// Generates the HTML for the Info Box Window above the marker.
        /// </summary>
        /// <param name="objects">The objects</param>
        /// <returns></returns>
        public static string GetInfoWindowContent(string title1, string title2, string text, string telLabel, string telNum, string emailLabel, string email)
        {
            string baseHtml =   "<div id='content'>" +
                                    "<div id='siteNotice'>" +
                                    "</div>" +
                                    "<h2 id='firstHeading' class='firstHeading'>{0}</h1>" +
                                    "<h3 id='firstHeading' class='firstHeading'>{1}</h2>" +
                                    "<div id='bodyContent'>" +
                                        "<p>{2}</p>" +
                                        "<p>{3} <a href=tel:{4}>{4}</a><p>" +
                                        "<p>{5} <a href=mailto:{6}>{6}</a><p>" +
                                    "</div>" +
                                "</div>";

            return string.Format("{0}",string.Format(baseHtml, HttpUtility.HtmlEncode(title1), HttpUtility.HtmlEncode(title2), HttpUtility.HtmlEncode(text), HttpUtility.HtmlEncode(telLabel), HttpUtility.HtmlEncode(telNum), HttpUtility.HtmlEncode(emailLabel), HttpUtility.HtmlEncode(email)));
        }
    }
}