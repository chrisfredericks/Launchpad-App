#pragma checksum "C:\Users\Asus\Desktop\Web-App-Project-III\launchPad\Views\Admin\Start.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4878171d6051c85f7b4fdce15a745a3ba4cd7296"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Start), @"mvc.1.0.view", @"/Views/Admin/Start.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Start.cshtml", typeof(AspNetCore.Views_Admin_Start))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Asus\Desktop\Web-App-Project-III\launchPad\Views\_ViewImports.cshtml"
using launchPad;

#line default
#line hidden
#line 1 "C:\Users\Asus\Desktop\Web-App-Project-III\launchPad\Views\Admin\Start.cshtml"
using System.Linq;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4878171d6051c85f7b4fdce15a745a3ba4cd7296", @"/Views/Admin/Start.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79584d5e01a5cab46b1fc077803bc6e6b1627f42", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Start : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<launchPad.Models.LinkManager>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btnAdd"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("selectedCategory"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btnDelete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("deleteFile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btnUpdate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateLink", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 209, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"pr-3\">\r\n        <h1>_launchPad.</h1>\r\n    </div>\r\n    <div class=\"pt-3 pr-3 pl-3\">\r\n        <h5>Administration</h5>\r\n    </div>\r\n    <div class=\"pt-3 pl-3\">\r\n        <h5><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 268, "\"", 303, 1);
#line 12 "C:\Users\Asus\Desktop\Web-App-Project-III\launchPad\Views\Admin\Start.cshtml"
WriteAttributeValue("", 275, Url.Action("Index", "Home"), 275, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(304, 86, true);
            WriteLiteral(">Logout</a></h5>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"container\">\r\n  <div class=\"row\">\r\n");
            EndContext();
#line 18 "C:\Users\Asus\Desktop\Web-App-Project-III\launchPad\Views\Admin\Start.cshtml"
     foreach (var item in Model.categories) {

#line default
#line hidden
            BeginContext(437, 48, true);
            WriteLiteral("      <div class=\"col-sm\">\r\n        \r\n          ");
            EndContext();
            BeginContext(485, 834, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4878171d6051c85f7b4fdce15a745a3ba4cd72968465", async() => {
                BeginContext(491, 74, true);
                WriteLiteral("\r\n            <div class=\"row\">\r\n              <div>\r\n                <h3>");
                EndContext();
                BeginContext(566, 13, false);
#line 24 "C:\Users\Asus\Desktop\Web-App-Project-III\launchPad\Views\Admin\Start.cshtml"
               Write(item.category);

#line default
#line hidden
                EndContext();
                BeginContext(579, 94, true);
                WriteLiteral("</h3>\r\n              </div>          \r\n              <div class=\"pl-2 pb-3\">\r\n                ");
                EndContext();
                BeginContext(673, 212, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4878171d6051c85f7b4fdce15a745a3ba4cd72969376", async() => {
                    BeginContext(810, 66, true);
                    WriteLiteral("\r\n                    <i class=\"fa fa-plus\"></i>\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "value", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 27 "C:\Users\Asus\Desktop\Web-App-Project-III\launchPad\Views\Admin\Start.cshtml"
AddHtmlAttributeValue("", 800, item.Id, 800, 8, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(885, 73, true);
                WriteLiteral("\r\n              </div>\r\n              <input type=\"hidden\" name=\"catName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 958, "\"", 980, 1);
#line 31 "C:\Users\Asus\Desktop\Web-App-Project-III\launchPad\Views\Admin\Start.cshtml"
WriteAttributeValue("", 966, item.category, 966, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(981, 60, true);
                WriteLiteral(" />\r\n              <div class=\"pl-2 pb-3\">\r\n                ");
                EndContext();
                BeginContext(1041, 217, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4878171d6051c85f7b4fdce15a745a3ba4cd729612465", async() => {
                    BeginContext(1183, 66, true);
                    WriteLiteral("\r\n                    <i class=\"fa fa-edit\"></i>\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "value", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 33 "C:\Users\Asus\Desktop\Web-App-Project-III\launchPad\Views\Admin\Start.cshtml"
AddHtmlAttributeValue("", 1176, item, 1176, 5, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1258, 54, true);
                WriteLiteral("\r\n              </div>\r\n            </div>\r\n          ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1319, 12, true);
            WriteLiteral("\r\n        \r\n");
            EndContext();
#line 40 "C:\Users\Asus\Desktop\Web-App-Project-III\launchPad\Views\Admin\Start.cshtml"
          int count = Model.links.Where(n => n.categoryId == item.Id).Count(a => a.pinned == "1");
          int i = 0;
        

#line default
#line hidden
            BeginContext(1464, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 43 "C:\Users\Asus\Desktop\Web-App-Project-III\launchPad\Views\Admin\Start.cshtml"
         foreach (var link in Model.sortedLinks().Where(n => n.categoryId == item.Id)) {
          i++;


#line default
#line hidden
            BeginContext(1572, 10, true);
            WriteLiteral("          ");
            EndContext();
            BeginContext(1582, 920, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4878171d6051c85f7b4fdce15a745a3ba4cd729616835", async() => {
                BeginContext(1588, 106, true);
                WriteLiteral("\r\n            <div id=\"adminButtons\" class=\"row\">\r\n              <div class=\"pr-2 pb-1\">\r\n                ");
                EndContext();
                BeginContext(1694, 219, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4878171d6051c85f7b4fdce15a745a3ba4cd729617336", async() => {
                    BeginContext(1832, 72, true);
                    WriteLiteral("\r\n                    <i class=\"fa fa-edit fa-sm\"></i>\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "value", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 49 "C:\Users\Asus\Desktop\Web-App-Project-III\launchPad\Views\Admin\Start.cshtml"
AddHtmlAttributeValue("", 1825, item, 1825, 5, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1913, 80, true);
                WriteLiteral("\r\n              </div> \r\n              <div class=\"pr-2 pb-1\">\r\n                ");
                EndContext();
                BeginContext(1993, 216, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4878171d6051c85f7b4fdce15a745a3ba4cd729619965", async() => {
                    BeginContext(2127, 73, true);
                    WriteLiteral("\r\n                    <i class=\"fa fa-trash fa-sm\"></i>\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "value", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 54 "C:\Users\Asus\Desktop\Web-App-Project-III\launchPad\Views\Admin\Start.cshtml"
AddHtmlAttributeValue("", 2120, item, 2120, 5, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2209, 65, true);
                WriteLiteral("\r\n              </div>\r\n              <div>\r\n                <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2274, "\"", 2336, 2);
                WriteAttributeValue("", 2280, "https://www.google.com/s2/favicons?domain_url=", 2280, 46, true);
#line 59 "C:\Users\Asus\Desktop\Web-App-Project-III\launchPad\Views\Admin\Start.cshtml"
WriteAttributeValue("", 2326, link.href, 2326, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 2337, "\"", 2354, 1);
#line 59 "C:\Users\Asus\Desktop\Web-App-Project-III\launchPad\Views\Admin\Start.cshtml"
WriteAttributeValue("", 2343, link.label, 2343, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2355, 35, true);
                WriteLiteral(" class=\"pr-1\"> \r\n                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2390, "\"", 2407, 1);
#line 60 "C:\Users\Asus\Desktop\Web-App-Project-III\launchPad\Views\Admin\Start.cshtml"
WriteAttributeValue("", 2397, link.href, 2397, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2408, 17, true);
                WriteLiteral(" target=\"_blank\">");
                EndContext();
                BeginContext(2426, 10, false);
#line 60 "C:\Users\Asus\Desktop\Web-App-Project-III\launchPad\Views\Admin\Start.cshtml"
                                                Write(link.label);

#line default
#line hidden
                EndContext();
                BeginContext(2436, 59, true);
                WriteLiteral("</a> \r\n              </div>\r\n            </div>\r\n          ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2502, 3, true);
            WriteLiteral(" \r\n");
            EndContext();
#line 64 "C:\Users\Asus\Desktop\Web-App-Project-III\launchPad\Views\Admin\Start.cshtml"
          if ((count == i)  && (count > 0)) {

#line default
#line hidden
            BeginContext(2552, 50, true);
            WriteLiteral("            <p>-----------------------------</p>\r\n");
            EndContext();
#line 66 "C:\Users\Asus\Desktop\Web-App-Project-III\launchPad\Views\Admin\Start.cshtml"
          }     
        }

#line default
#line hidden
            BeginContext(2631, 14, true);
            WriteLiteral("      </div>\r\n");
            EndContext();
#line 69 "C:\Users\Asus\Desktop\Web-App-Project-III\launchPad\Views\Admin\Start.cshtml"
    }

#line default
#line hidden
            BeginContext(2652, 20, true);
            WriteLiteral("  </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2690, 43, true);
                WriteLiteral("\r\n    <script>startAutoLogout();</script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<launchPad.Models.LinkManager> Html { get; private set; }
    }
}
#pragma warning restore 1591
