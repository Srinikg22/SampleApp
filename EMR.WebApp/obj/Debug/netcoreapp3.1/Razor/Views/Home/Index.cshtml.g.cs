#pragma checksum "C:\Users\user\source\repos\EMR.WebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "218779346bb99ceceab67a5fd8bb26c846251ef3"
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
#line 1 "C:\Users\user\source\repos\EMR.WebApp\Views\_ViewImports.cshtml"
using EMR.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\EMR.WebApp\Views\_ViewImports.cshtml"
using EMR.WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"218779346bb99ceceab67a5fd8bb26c846251ef3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c72e4db74ae08b094858961bfaa34369b03b0fda", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("runat", new global::Microsoft.AspNetCore.Html.HtmlString("server"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background:url(images/export/beige_back.gif);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\user\source\repos\EMR.WebApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">EMR WebApp</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n\r\n\r\n\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "218779346bb99ceceab67a5fd8bb26c846251ef34967", async() => {
                WriteLiteral("\r\n    <title>Longerity Medical Clinic::Login</title>\r\n\r\n    <%--\r\n    <link href=\"css/jqueryui/southstreet/jquery-ui-min.css\" rel=\"stylesheet\" />--%>\r\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"css/Common.css\" />\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "218779346bb99ceceab67a5fd8bb26c846251ef36258", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "218779346bb99ceceab67a5fd8bb26c846251ef36520", async() => {
                    WriteLiteral(@"
        <div id=""Layer166"" style=""position: absolute; left: 10px; top: 10px; width: 22px; height: 22px; z-index: 1"">
            <asp:Image ID=""imgLogo"" runat=""server"" ImageUrl=""~/images/export/layout1_r1_c1.gif""
                       Width=""100"" Height=""97"" border=""0""");
                    BeginWriteAttribute("alt", " alt=\"", 914, "\"", 920, 0);
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n        </div>\r\n        <div id=\"Layer21\" style=\"position: absolute; left: 121px; top: 13px; z-index: 2\">\r\n            <img src=\"images/lmc_logo.gif\" width=\"180\" height=\"88\"");
                    BeginWriteAttribute("alt", " alt=\"", 1099, "\"", 1105, 0);
                    EndWriteAttribute();
                    WriteLiteral(@" />
        </div>
        <div id=""main"">

            <div id=""tray"" class=""box"">
                <p class=""f-left box"">


                    <%-- &nbsp;&nbsp;&nbsp;&nbsp;
                    <img src=""Images/lmc_logo.gif"" alt=""Longerity Medical Clinic"" title=""Longerity Medical Clinic"" />--%>
                </p>
                <p class=""f-right"">
                </p>
            </div>
            <h1 style=""border: 1px solid #AFAFAF;""></h1>
            <div id=""cols"" class=""box"">
                <div id=""Logincontent"" class=""box"" style=""margin-left: 400px ! important; width: 450px; height: 200px!important;"">
                    <div style=""margin-left: 120px; padding-top: 10px;"">
                        <asp:Label ID=""lblMessage"" runat=""server"" CssClass=""errorMessage"" Visible=""false""></asp:Label>
                    </div>
                    <table style=""text-align: center; margin-left: 50px;"">
                        <tr>
                            <td>
                       ");
                    WriteLiteral(@"         <h2>Login</h2>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <span class=""requiredStarMark"">*</span>User Name :
                            </td>
                            <td>
                                &nbsp;<asp:TextBox ID=""txtUserName"" runat=""server"" MaxLength=""100"" CssClass=""textbox""></asp:TextBox>

                            </td>
                        </tr>
                        <tr>

                            <td colspan=""2"" style=""padding-right: 48px;"">
                                <asp:RequiredFieldValidator ID=""rfvUserName"" runat=""server""
                                                            CssClass=""aspDotNetValidation"" ErrorMessage=""Please enter your user name."" SetFocusOnError=""true"" ControlToValidate=""txtUserName"" ValidationGroup=""Login""></asp:RequiredFieldValidator>
                        ");
                    WriteLiteral(@"    </td>
                        </tr>
                        <tr>
                            <td>
                                <span class=""requiredStarMark"">*</span>Password :
                            </td>
                            <td>
                                <asp:TextBox ID=""txtPassword"" runat=""server"" MaxLength=""50"" TextMode=""Password""></asp:TextBox>

                            </td>
                        </tr>
                        <tr>
                            <td colspan=""2"" style=""padding-right: 48px;"">
                                <asp:RequiredFieldValidator ID=""rfvPassword"" runat=""server""
                                                            CssClass=""aspDotNetValidation"" ErrorMessage=""Please enter your password."" SetFocusOnError=""true"" ControlToValidate=""txtUserName"" ValidationGroup=""Login""></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td ");
                    WriteLiteral(@"colspan=""2"" style=""text-align: center; padding-left: 260px;"">
                                <asp:Button ID=""btnLogin"" runat=""server"" Text=""Login"" ValidationGroup=""Login"" CssClass=""btnLogin"" OnClick=""btnLogin_Click"" />
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
