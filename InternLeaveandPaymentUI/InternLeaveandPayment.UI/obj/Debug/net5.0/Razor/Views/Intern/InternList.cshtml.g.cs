#pragma checksum "C:\Users\Akif\Desktop\InternLeaveandPayment\InternLeaveandPaymentUI\InternLeaveandPaymentUI\InternLeaveandPayment.UI\Views\Intern\InternList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3918ffd0ac75f233f54444a2157d4b9e2bbe6bf1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Intern_InternList), @"mvc.1.0.view", @"/Views/Intern/InternList.cshtml")]
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
#line 1 "C:\Users\Akif\Desktop\InternLeaveandPayment\InternLeaveandPaymentUI\InternLeaveandPaymentUI\InternLeaveandPayment.UI\Views\_ViewImports.cshtml"
using InternLeaveandPayment.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Akif\Desktop\InternLeaveandPayment\InternLeaveandPaymentUI\InternLeaveandPaymentUI\InternLeaveandPayment.UI\Views\_ViewImports.cshtml"
using InternLeaveandPayment.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3918ffd0ac75f233f54444a2157d4b9e2bbe6bf1", @"/Views/Intern/InternList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1448c6446469fc0393e0ecf12262533ac16024c7", @"/Views/_ViewImports.cshtml")]
    public class Views_Intern_InternList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<InternLeaveandPaymentUI.Domain.DTOs.Intern.InternListDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Intern", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddIntern", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Akif\Desktop\InternLeaveandPayment\InternLeaveandPaymentUI\InternLeaveandPaymentUI\InternLeaveandPayment.UI\Views\Intern\InternList.cshtml"
  
    ViewData["Title"] = "InternList";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Stajyer Listesi</h1>\r\n<div>\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3918ffd0ac75f233f54444a2157d4b9e2bbe6bf14658", async() => {
                WriteLiteral("Yeni Kayıt");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <div>
        <table class=""table"">
            <thead>
                <tr>
                    <th scope=""col"">Adı-Soyadı</th>
                    <th scope=""col"">Şirketi</th>
                    <th scope=""col"">Okulu</th>
                    <th scope=""col"">Okul Bölümü</th>
                    <th scope=""col"">Sorumlu Kişi</th>
                    <th scope=""col"">Departman/İşletme</th>
                    <th scope=""col"">Staj Günleri</th>
                    <th scope=""col"">Detay</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 26 "C:\Users\Akif\Desktop\InternLeaveandPayment\InternLeaveandPaymentUI\InternLeaveandPaymentUI\InternLeaveandPayment.UI\Views\Intern\InternList.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 29 "C:\Users\Akif\Desktop\InternLeaveandPayment\InternLeaveandPaymentUI\InternLeaveandPaymentUI\InternLeaveandPayment.UI\Views\Intern\InternList.cshtml"
                       Write(item.InternName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 29 "C:\Users\Akif\Desktop\InternLeaveandPayment\InternLeaveandPaymentUI\InternLeaveandPaymentUI\InternLeaveandPayment.UI\Views\Intern\InternList.cshtml"
                                         Write(item.InternSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 30 "C:\Users\Akif\Desktop\InternLeaveandPayment\InternLeaveandPaymentUI\InternLeaveandPaymentUI\InternLeaveandPayment.UI\Views\Intern\InternList.cshtml"
                       Write(item.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 31 "C:\Users\Akif\Desktop\InternLeaveandPayment\InternLeaveandPaymentUI\InternLeaveandPaymentUI\InternLeaveandPayment.UI\Views\Intern\InternList.cshtml"
                       Write(item.InternSchool);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 32 "C:\Users\Akif\Desktop\InternLeaveandPayment\InternLeaveandPaymentUI\InternLeaveandPaymentUI\InternLeaveandPayment.UI\Views\Intern\InternList.cshtml"
                       Write(item.InternSchoolDepartment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 33 "C:\Users\Akif\Desktop\InternLeaveandPayment\InternLeaveandPaymentUI\InternLeaveandPaymentUI\InternLeaveandPayment.UI\Views\Intern\InternList.cshtml"
                       Write(item.EmployeeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 33 "C:\Users\Akif\Desktop\InternLeaveandPayment\InternLeaveandPaymentUI\InternLeaveandPaymentUI\InternLeaveandPayment.UI\Views\Intern\InternList.cshtml"
                                           Write(item.EmployeeSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 34 "C:\Users\Akif\Desktop\InternLeaveandPayment\InternLeaveandPaymentUI\InternLeaveandPaymentUI\InternLeaveandPayment.UI\Views\Intern\InternList.cshtml"
                       Write(item.DepartmentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td></td>\r\n                        <td><a  class=\"btn btn-primary\">Detay</a></td>\r\n                    </tr>\r\n");
#nullable restore
#line 38 "C:\Users\Akif\Desktop\InternLeaveandPayment\InternLeaveandPaymentUI\InternLeaveandPaymentUI\InternLeaveandPayment.UI\Views\Intern\InternList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<InternLeaveandPaymentUI.Domain.DTOs.Intern.InternListDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
