using Microsoft.AspNetCore.Mvc;
using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.Orders;
using Nop.Services.Catalog;
using Nop.Services.Customers;
using Nop.Services.Orders;
using Nop.Web.Framework;
using Nop.Web.Framework.Controllers;
using Nop.Web.Framework.Mvc.Filters;
using System;
using System.Xml;

namespace Nop.Plugin.TestPlugin.Controllers
{
    public class TestPluginController:BasePluginController
    {

        private readonly IProductService _productService;
        private readonly IProductAttributeService _attributeService;
        private readonly IShoppingCartService _cartService;
        private readonly ICustomerService _customerService;
        private readonly IProductAttributeParser _productAttributeParser;

        public TestPluginController(IProductService productService,IProductAttributeService attributeService
            ,IShoppingCartService cartService,ICustomerService customerService,
            IProductAttributeParser productAttributeParser
            )
        {
            _productService = productService;
            _attributeService = attributeService;
            _cartService = cartService;
            _customerService = customerService;
            _productAttributeParser = productAttributeParser;
        }

        [AuthorizeAdmin] //confirms access to the admin panel
        [Area(AreaNames.Admin)] //specifies the area containing a controller or action
        public IActionResult Configure()
        {
            return View("~/Plugins/Nop.Plugins.TestPlugin/Views/Configure.cshtml");
        }

        public IActionResult Test()
        {
            Console.WriteLine("///////////////////////////////////////");
            //var result = from pa in ProductAttribute where pa.Name == "Year" select pa.Name;

            // adding new attribute
            //ProductAttribute newAtt = new ProductAttribute();
            //newAtt.Name = "test123";
            //_attributeService.InsertProductAttribute(newAtt);

            //var result = _productService.SearchProducts(
            //    categoryIds: null,
            //    pageSize: 1,
            //    showHidden: true
            //);

            //var c1 = _customerService.GetCustomerByEmail("admin@admin.com");
            //var r2 = _cartService.GetShoppingCart(c1);

            return Ok("okay");
            return View("~/Plugins/Nop.Plugins.TestPlugin/Views/Configure.cshtml");
        }
    }
}
