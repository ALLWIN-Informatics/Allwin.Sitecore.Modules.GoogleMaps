using Allwin.Sitecore.Modules.GoogleMaps.Models.Map.GoogleMaps;
using Sitecore.Data.Items;

namespace Allwin.Sitecore.Modules.GoogleMaps.Repositories.GoogleMaps
{
    /// <summary>
    /// The interface for google repository.
    /// </summary>
    public interface IGoogleMapsRepository
    {
        /// <summary>
        /// The datasource item.
        /// </summary>
        Item DatasourceItem { get; set; }

        /// <summary>
        /// Gets the datasource model.
        /// </summary>
        /// <returns>
        /// The Map object.
        /// </returns>
        Map GetMapModel();
    }
}
