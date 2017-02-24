using Allwin.Sitecore.Modules.GoogleMaps.Models.Map.GoogleMaps;
using Sitecore.Data.Items;

namespace Allwin.Sitecore.Modules.GoogleMaps.Repositories.GoogleMaps
{
    /// <summary>
    /// The default class for google repository.
    /// </summary>
    public class GoogleMapsRepository : IGoogleMapsRepository
    {
        /// <summary>
        /// The datasource item.
        /// </summary>
        public Item DatasourceItem { get; set; }

        /// <summary>
        /// The constructor.
        /// </summary>
        /// <param name="datasource">The datasource item.</param>
        public GoogleMapsRepository(Item datasource)
        {
            this.DatasourceItem = datasource;
        }

        /// <summary>
        /// Gets the datasource model.
        /// </summary>
        /// <returns>
        /// The Map object.
        /// </returns>
        public Map GetMapModel()
        {
            return new Map(this.DatasourceItem);
        }
    }
}
