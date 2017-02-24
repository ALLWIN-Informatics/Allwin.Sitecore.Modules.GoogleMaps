using Sitecore;
using Sitecore.Diagnostics;
using Sitecore.Shell.Applications.WebEdit.Commands;
using Sitecore.Shell.Framework.Commands;
using Sitecore.Text;
using Sitecore.Web.UI.Sheer;

namespace Allwin.Sitecore.Modules.GoogleMaps.Commands.Common
{
    /// <summary>
    /// The edit dataasource.
    /// </summary>
    public class EditDatasource : WebEditCommand
    {
        /// <summary>
        /// Entry point to open the content editor
        /// </summary>
        /// <param name="context">The command context containing parameters.</param>
        public override void Execute(CommandContext context)
        {
            Assert.ArgumentNotNull(context, "context");
            if (context.Items.Length == 1)
            {
                UrlString path = new UrlString("/sitecore/shell/Applications/Content Manager/default.aspx");
                path["fo"] = context.Items[0].ID.ToString();
                path["ro"] = context.Items[0].ID.ToString();
                path["la"] = Context.Request.GetQueryString("lang");
                path["vs"] = context.Items[0].Version.Number.ToString();
                SheerResponse.ShowModalDialog(path.ToString(), "1024", "800", "SitecoreWebEditEditor", false);
            }
        }
    }
}