using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework.Components;

namespace Nop.Plugin.TestPlugin.Components
{
    public class TestPluginViewComponent:NopViewComponent
    {
        public IViewComponentResult Invoke(string widgetZone, object additionalData)
        {
            return View("~/Plugins/TestPlugin/Views/PublicInfo.cshtml");
        }
    }
}
