#pragma checksum "C:\Users\rodri\OneDrive\YEAR 4\Assignments 4th year\DoubleProject\Project\SPOS\Pages\Payment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea0759a8c473e5390a10118a79daab5995c638b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SPOS.Pages.Pages_Payment), @"mvc.1.0.razor-page", @"/Pages/Payment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea0759a8c473e5390a10118a79daab5995c638b7", @"/Pages/Payment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9665e241a70feba0eded80435369eb6121fabe1f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Payment : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/mainPage.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "button", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 92, "\"", 133, 1);
#nullable restore
#line 7 "C:\Users\rodri\OneDrive\YEAR 4\Assignments 4th year\DoubleProject\Project\SPOS\Pages\Payment.cshtml"
WriteAttributeValue("", 99, Url.Content("~/css/mainPage.css"), 99, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n");
            }
            );
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea0759a8c473e5390a10118a79daab5995c638b74801", async() => {
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
            WriteLiteral(@"

<section class=""receipt_area"">
    <div class=""inside_receipt_area"">
        
        <div class=""receipt"" style=""height:100%;padding:5%;"">
            <div class=""center"">*Company Name*</div>
            <br />
            Location: COFFEE PLACE
            <br />
            Cashier:
            <br />
            Order#:
            <br />
            <div class=""date"">Date & Time: ");
#nullable restore
#line 24 "C:\Users\rodri\OneDrive\YEAR 4\Assignments 4th year\DoubleProject\Project\SPOS\Pages\Payment.cshtml"
                                      Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
            <br /><br />
            <table id=""receipt_table"">
                <tr style=""background-color:lightblue"" hidden>
                    <td style=""width:10%;""></td>
                    <td style=""width:60%;""></td>
                    <td style=""width:15%;""></td>
                    <td style=""width:15%;"">Staff ID</td>
                </tr>
                <tr style=""border-bottom: 2px solid black;"">
                    <td class=""id"">ID</td>
                    <td class=""description"">Description</td>
                    <td class=""cost"">Cost</td>
                    <td class=""qty"">Qty</td>
                </tr>
            </table>
            <br /><br />
            <b>TOTAL EUR:</b>
            <b style=""float:right;"" id=""total_price""></b>
            <br /><br />
            <b>AMOUNT RECEIVED:</b>
            <b style=""float:right;"" id=""amount_received""></b>
            <br /><br />
            <b>CHANGE:</b>
            <b style=""float:right;"" id=""change_to_gi");
            WriteLiteral(@"ve""></b>
            <br /><br />
            <b>PAYMENT METHOD:</b><b style=""float:right;"" id=""total_price"">CASH</b>
            <hr />
            <br />
            <div class=""center"">
                ALL CHARGES ARE INCLUDED IN PRICE<br /><br />
                Wifi Key: 12345<br /><br />

                THANK YOU FOR YOUR PURCHASE!<br />
                COME AGAIN SOON!<br /><br />

                ***Purchase Closed***
            </div>
        </div>
    </div>
</section>

<section class=""selection"">
    <div class=""selectionArea"">
        //DISCOUNTS
        <hr />
        Payment Method:
        <br />
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea0759a8c473e5390a10118a79daab5995c638b78280", async() => {
                WriteLiteral("\r\n            <button onclick=\"openModalForCash(\'CASH\')\">CASH</button>\r\n            <button type=\"submit\">VISA</button>\r\n            <button type=\"submit\">MASTER</button>\r\n            <button type=\"submit\">AMEX</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n    <button class=\"backBtn\" onclick=\"location.replace(\'/MainPage\');\">Back</button>\r\n\r\n    <div id=\"myModal\" class=\"modal\">\r\n        <!--Modal content-->\r\n        <div class=\"modal-content\">\r\n            <span class=\"close\">&times;</span>\r\n");
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SPOS.Pages.PaymentModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SPOS.Pages.PaymentModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SPOS.Pages.PaymentModel>)PageContext?.ViewData;
        public SPOS.Pages.PaymentModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
