using System.Web.Mvc;
using Allwin.Sitecore.Modules.GoogleMaps.Repositories.GoogleMaps;
using Sitecore.Mvc.Presentation;

namespace Allwin.Sitecore.Modules.GoogleMaps.Controllers
{
    /// <summary>
    /// The integration controller.
    /// </summary>
    public class MapController : Controller
    {
        /// <summary>
        /// The google repository.
        /// </summary>
        private readonly IGoogleMapsRepository _googleMapsRepository;

        /// <summary>
        /// The constructor.
        /// </summary>
        public MapController()
        {
            this._googleMapsRepository = new GoogleMapsRepository(RenderingContext.Current.Rendering.Item);
        }

        /// <summary>
        /// The constructor.
        /// </summary>
        /// <param name="googleMapsRepository">The google maps repository.</param>
        public MapController(IGoogleMapsRepository googleMapsRepository)
        {
            this._googleMapsRepository = googleMapsRepository;
        }

        /// <summary>
        /// The google maps action
        /// </summary>
        /// <returns>
        /// The google maps view.
        /// </returns>
        public ActionResult GoogleMaps()
        {
            return this.View("GoogleMaps", this._googleMapsRepository.GetMapModel());
        }
    }
}