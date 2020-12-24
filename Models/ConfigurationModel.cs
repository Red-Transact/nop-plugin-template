using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;

namespace Nop.Plugin.TestPlugin.Models
{
    public class ConfigurationModel : BaseNopModel
    {
        /// <summary>
        /// test plugin test model
        /// </summary>
        [NopResourceDisplayName("Plugins.TestPlugin.TestAttribute")]
        public string TestAttribute { get; set; }
    }
}
