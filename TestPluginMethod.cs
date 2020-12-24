using Nop.Core;
using Nop.Services.Plugins;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nop.Plugin.TestPlugin
{
    public class TestPluginMethod : BasePlugin
    {
        private readonly IWebHelper _webHelper;

        public TestPluginMethod(IWebHelper webHelper)
        {
            _webHelper = webHelper;
        }
        public override string GetConfigurationPageUrl()
        {
            return $"{_webHelper.GetStoreLocation()}Admin/TestPlugin/Configure";
        }

        public override void Install()
        {
            base.Install();
        }
    }
}
