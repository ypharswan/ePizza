#pragma checksum "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0fbcbdc0a45596532083c5f4bb57b072330ca248477b2d8b113492d309d5a27a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_Order_Index), @"mvc.1.0.view", @"/Areas/User/Views/Order/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\User\Views\_ViewImports.cshtml"
using ePizzaHub.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\User\Views\_ViewImports.cshtml"
using ePizzaHub.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"0fbcbdc0a45596532083c5f4bb57b072330ca248477b2d8b113492d309d5a27a", @"/Areas/User/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"e2a85a5b1785b59c4023b0e61413d28562a4ae2b9d606ba0e0732f0c519b5475", @"/Areas/User/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_User_Views_Order_Index : ePizzaHub.WebUI.Helpers.BaseViewPage<IEnumerable<ePizzaHub.Entities.Order>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>My Orders</h1>\r\n\r\n");
#nullable restore
#line 9 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
 if (Model != null && Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 15 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n\r\n                <th>\r\n                    ");
#nullable restore
#line 19 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.PaymentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 22 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 25 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ZipCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 28 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Locality));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 31 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 34 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 40 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 44 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 47 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PaymentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 50 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 53 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ZipCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 56 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Locality));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 59 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 62 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 65 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
                   Write(Html.ActionLink("Details", "Details", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 68 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 71 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-sm-12 mt-4"">
            <p style=""min-height:300px"">
                You haven't placed any order yet. Please search your pizza from the menu! <br><br>
                <a href=""/"" class=""btn btn-primary"">Browse Menu</a>
            </p>
        </div>
    </div>
");
#nullable restore
#line 82 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ePizzaHub.Entities.Order>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
