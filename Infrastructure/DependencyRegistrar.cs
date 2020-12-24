using Autofac;
using Nop.Core.Configuration;
using Nop.Core.Infrastructure;
using Nop.Core.Infrastructure.DependencyManagement;
using Nop.Plugin.TestPlugin.Services;
using Nop.Services.Catalog;
using Nop.Services.Orders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nop.Plugin.TestPlugin.Infrastructure
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public int Order => 2;

        public void Register(ContainerBuilder builder, ITypeFinder typeFinder, NopConfig config)
        {
            //builder.RegisterType<TestPriceCalculation>().As<IPriceCalculationService>().InstancePerLifetimeScope();
           // builder.RegisterType<ShoppingCartService>().As<IShoppingCartService>().InstancePerLifetimeScope();
        }
    }
}
