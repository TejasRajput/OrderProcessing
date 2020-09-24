#pragma checksum "D:\Tejas Projects\Tests\OrderProcessing\OrderProcessingApp\OrderProcessingAppUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffdb6eb1b194cc1052cc5860ca71d3eba4b5a6bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Tejas Projects\Tests\OrderProcessing\OrderProcessingApp\OrderProcessingAppUI\Views\_ViewImports.cshtml"
using OrderProcessingAppUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Tejas Projects\Tests\OrderProcessing\OrderProcessingApp\OrderProcessingAppUI\Views\_ViewImports.cshtml"
using OrderProcessingAppUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffdb6eb1b194cc1052cc5860ca71d3eba4b5a6bf", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2099555cf172343c6a6d7844101273a562f36495", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Tejas Projects\Tests\OrderProcessing\OrderProcessingApp\OrderProcessingAppUI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    ViewBag.PaymentTypes = new List<string>{
        "Physical product",
        "Book",
        "Membership",
        "Videos",
        "Upgrade Membership"
    };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Order Processing App</h1>\r\n    <br />\r\n");
#nullable restore
#line 15 "D:\Tejas Projects\Tests\OrderProcessing\OrderProcessingApp\OrderProcessingAppUI\Views\Home\Index.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <fieldset>\r\n            Payment Type:\r\n            ");
#nullable restore
#line 19 "D:\Tejas Projects\Tests\OrderProcessing\OrderProcessingApp\OrderProcessingAppUI\Views\Home\Index.cshtml"
       Write(Html.DropDownList("PaymentType", new SelectList(ViewBag.PaymentTypes), "- Select Payment Type -"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <p>\r\n                <br />\r\n                <input type=\"submit\" value=\"Submit\" onclick=\"return PaymentSelection()\" />\r\n            </p>\r\n        </fieldset>\r\n");
#nullable restore
#line 25 "D:\Tejas Projects\Tests\OrderProcessing\OrderProcessingApp\OrderProcessingAppUI\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div>\r\n        <h6>Result:</h6>\r\n        <p style=\"color:red\"> ");
#nullable restore
#line 29 "D:\Tejas Projects\Tests\OrderProcessing\OrderProcessingApp\OrderProcessingAppUI\Views\Home\Index.cshtml"
                         Write(ViewBag.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
    </div>
</div>


<script type=""text/javascript"">

    function PaymentSelection() {
        var selection = document.getElementById('PaymentType').value;
        if (selection == '') {
            alert('Please select a payment type');
            return false;
        }

        return true;
    }

</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
