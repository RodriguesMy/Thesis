#pragma checksum "C:\Users\rodri\OneDrive\YEAR 4\Assignments 4th year\DoubleProject\Project\SPOS\Pages\ReceiptToPrint.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a17d690249bc186f9d51b75b589fcdcc2bcbf94f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SPOS.Pages.Pages_ReceiptToPrint), @"mvc.1.0.razor-page", @"/Pages/ReceiptToPrint.cshtml")]
namespace SPOS.Pages
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
#line 1 "C:\Users\rodri\OneDrive\YEAR 4\Assignments 4th year\DoubleProject\Project\SPOS\Pages\_ViewImports.cshtml"
using SPOS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\rodri\OneDrive\YEAR 4\Assignments 4th year\DoubleProject\Project\SPOS\Pages\ReceiptToPrint.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a17d690249bc186f9d51b75b589fcdcc2bcbf94f", @"/Pages/ReceiptToPrint.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9665e241a70feba0eded80435369eb6121fabe1f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ReceiptToPrint : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ReceiptContents.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/receiptToPrint.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 99, "\"", 146, 1);
#nullable restore
#line 7 "C:\Users\rodri\OneDrive\YEAR 4\Assignments 4th year\DoubleProject\Project\SPOS\Pages\ReceiptToPrint.cshtml"
WriteAttributeValue("", 106, Url.Content("~/css/receiptToPrint.css"), 106, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n");
            }
            );
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a17d690249bc186f9d51b75b589fcdcc2bcbf94f4521", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a17d690249bc186f9d51b75b589fcdcc2bcbf94f5560", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n<div class=\"receipt\" style=\"height:100%; width:100%\">\r\n    <div class=\"center\">*Company Name*</div>\r\n    <br />\r\n    Location: COFFEE PLACE\r\n    <br />\r\n    Cashier: ");
#nullable restore
#line 19 "C:\Users\rodri\OneDrive\YEAR 4\Assignments 4th year\DoubleProject\Project\SPOS\Pages\ReceiptToPrint.cshtml"
        Write(HttpContext.Session.GetString("userName"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    Order#: ");
#nullable restore
#line 21 "C:\Users\rodri\OneDrive\YEAR 4\Assignments 4th year\DoubleProject\Project\SPOS\Pages\ReceiptToPrint.cshtml"
       Write(HttpContext.Session.GetString("orderId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    <div class=\"date\">Date & Time: ");
#nullable restore
#line 23 "C:\Users\rodri\OneDrive\YEAR 4\Assignments 4th year\DoubleProject\Project\SPOS\Pages\ReceiptToPrint.cshtml"
                              Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
    <br /><br />
    <table id=""receipt_table"">
        <tr style=""border-bottom: 2px solid black;"">
            <td style=""width:10%;"" class=""id"">ID</td>
            <td style=""width:60%;"" class=""description"">Description</td>
            <td style=""width:15%;"" class=""cost"">Cost</td>
            <td style=""width:15%;"" class=""qty"">Qty</td>
        </tr>
    </table>
    <br />
    <hr />
    <br />
    <b>TOTAL EUR:</b>
    <b style=""float:right;"" id=""total_price"">€");
#nullable restore
#line 37 "C:\Users\rodri\OneDrive\YEAR 4\Assignments 4th year\DoubleProject\Project\SPOS\Pages\ReceiptToPrint.cshtml"
                                         Write(HttpContext.Session.GetString("total"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n    <br /><br />\r\n");
#nullable restore
#line 39 "C:\Users\rodri\OneDrive\YEAR 4\Assignments 4th year\DoubleProject\Project\SPOS\Pages\ReceiptToPrint.cshtml"
     if (HttpContext.Session.GetString("discount") != "0")
    {
        var current = double.Parse(HttpContext.Session.GetString("total"));
        var discount = int.Parse(HttpContext.Session.GetString("discount"));
        var originalPrice = current / (1 - discount * 0.01);
        var total = Math.Round(originalPrice - (originalPrice * discount / 100), 2, MidpointRounding.AwayFromZero).ToString("N2");
        var savings = (originalPrice - double.Parse(total)).ToString("N2");


#line default
#line hidden
#nullable disable
            WriteLiteral("        <b>DISCOUNT:</b>\r\n        <b style=\"float:right;\" id=\"discount\">");
#nullable restore
#line 48 "C:\Users\rodri\OneDrive\YEAR 4\Assignments 4th year\DoubleProject\Project\SPOS\Pages\ReceiptToPrint.cshtml"
                                         Write(HttpContext.Session.GetString("discount"));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</b>\r\n        <br /><br />\r\n        <b>AFTER DISCOUNT:</b>\r\n        <b style=\"float:right;\" id=\"discount\">€");
#nullable restore
#line 51 "C:\Users\rodri\OneDrive\YEAR 4\Assignments 4th year\DoubleProject\Project\SPOS\Pages\ReceiptToPrint.cshtml"
                                          Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n        <br /><br />\r\n        <b>SAVINGS:</b>\r\n        <b style=\"float:right;\" id=\"savings\">€");
#nullable restore
#line 54 "C:\Users\rodri\OneDrive\YEAR 4\Assignments 4th year\DoubleProject\Project\SPOS\Pages\ReceiptToPrint.cshtml"
                                         Write(savings);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n        <br /><br />\r\n");
#nullable restore
#line 56 "C:\Users\rodri\OneDrive\YEAR 4\Assignments 4th year\DoubleProject\Project\SPOS\Pages\ReceiptToPrint.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\rodri\OneDrive\YEAR 4\Assignments 4th year\DoubleProject\Project\SPOS\Pages\ReceiptToPrint.cshtml"
     if (HttpContext.Session.GetString("paymentMethod") == "CASH")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <b>AMOUNT RECEIVED:</b>\r\n        <b style=\"float:right;\" id=\"amount_received\">€");
#nullable restore
#line 60 "C:\Users\rodri\OneDrive\YEAR 4\Assignments 4th year\DoubleProject\Project\SPOS\Pages\ReceiptToPrint.cshtml"
                                                 Write(HttpContext.Session.GetString("amountReceived"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n        <br /><br />\r\n        <b>CHANGE:</b>\r\n        <b style=\"float:right;\" id=\"change_to_give\">€");
#nullable restore
#line 63 "C:\Users\rodri\OneDrive\YEAR 4\Assignments 4th year\DoubleProject\Project\SPOS\Pages\ReceiptToPrint.cshtml"
                                                Write(HttpContext.Session.GetString("change"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n        <br /><br />\r\n");
#nullable restore
#line 65 "C:\Users\rodri\OneDrive\YEAR 4\Assignments 4th year\DoubleProject\Project\SPOS\Pages\ReceiptToPrint.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <b>PAYMENT METHOD:</b><b style=\"float:right;\" id=\"total_price\">");
#nullable restore
#line 66 "C:\Users\rodri\OneDrive\YEAR 4\Assignments 4th year\DoubleProject\Project\SPOS\Pages\ReceiptToPrint.cshtml"
                                                              Write(HttpContext.Session.GetString("paymentMethod"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n    <hr />\r\n    <br />\r\n    <div class=\"center\">\r\n");
#nullable restore
#line 70 "C:\Users\rodri\OneDrive\YEAR 4\Assignments 4th year\DoubleProject\Project\SPOS\Pages\ReceiptToPrint.cshtml"
         if (HttpContext.Session.GetString("modified") == "true")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>*RECEIPT MODIFIED*</div><br /><br />\r\n");
#nullable restore
#line 73 "C:\Users\rodri\OneDrive\YEAR 4\Assignments 4th year\DoubleProject\Project\SPOS\Pages\ReceiptToPrint.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        ALL CHARGES ARE INCLUDED IN PRICE<br /><br />\r\n        Wifi Key: 12345<br /><br />\r\n\r\n        THANK YOU FOR YOUR PURCHASE!<br />\r\n        COME AGAIN SOON!<br /><br />\r\n\r\n        ***Purchase Closed***\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SPOS.Pages.ReceiptToPrintModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SPOS.Pages.ReceiptToPrintModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SPOS.Pages.ReceiptToPrintModel>)PageContext?.ViewData;
        public SPOS.Pages.ReceiptToPrintModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
