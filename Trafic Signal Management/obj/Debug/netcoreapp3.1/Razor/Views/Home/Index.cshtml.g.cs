#pragma checksum "C:\Users\91701\source\repos\Trafic Signal Management\Trafic Signal Management\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9de4a51a13d7de9babefcd9f028114e2df0c510f"
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
#line 1 "C:\Users\91701\source\repos\Trafic Signal Management\Trafic Signal Management\Views\_ViewImports.cshtml"
using Trafic_Signal_Management;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\91701\source\repos\Trafic Signal Management\Trafic Signal Management\Views\_ViewImports.cshtml"
using Trafic_Signal_Management.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9de4a51a13d7de9babefcd9f028114e2df0c510f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d253fbeb56fb051b965ef8a701481beaf203144f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GlobalConfig>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 53, "\"", 95, 1);
#nullable restore
#line 4 "C:\Users\91701\source\repos\Trafic Signal Management\Trafic Signal Management\Views\Home\Index.cshtml"
WriteAttributeValue("", 59, Url.Content("~/js/ConfigScript.js"), 59, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n");
            }
            );
#nullable restore
#line 6 "C:\Users\91701\source\repos\Trafic Signal Management\Trafic Signal Management\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
    <div>
        <label>Time :</label>
        <div id=""time"">0</div>
    </div>
    <div>
        <label>Current Open :</label>
        <div id=""cur"">A</div>
    </div>
    <div>
        <label>Next Open :</label>
        <div id=""nxt""></div>
    </div>
    <div>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9de4a51a13d7de9babefcd9f028114e2df0c510f4243", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 24 "C:\Users\91701\source\repos\Trafic Signal Management\Trafic Signal Management\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Direction);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <div id=""dir"">Clockwise</div>
    </div>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-4 d-flex justify-content-center"">
                <Button>AA</Button>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-4 d-flex justify-content-center"">
                <button>A</button>
            </div>
        </div>

        <div class=""row"">
            <div class=""col-4 "">
                <Button>AD</Button>
                <button>D</button>
            </div>
            <div class=""col-4 "">
                <Button>AB</Button>
                <button>B</button>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-4 d-flex justify-content-center"">
                <Button>AC</Button>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-4 d-flex justify-content-center"">
                <button>C</button>
            </div>
        <");
            WriteLiteral("/div>\r\n    </div>\r\n    <div>\r\n        <label>Remaining Time :</label>\r\n        <div id=\"rtime\"></div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GlobalConfig> Html { get; private set; }
    }
}
#pragma warning restore 1591
