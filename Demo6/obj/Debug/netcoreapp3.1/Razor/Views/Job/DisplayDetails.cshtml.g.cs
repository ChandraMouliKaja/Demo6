#pragma checksum "C:\Users\Chandra Mouli\source\repos\MVC by VS\Demo6\Demo6\Views\Job\DisplayDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe0244af1ad769a9113c19fbe556769e1f1460a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Job_DisplayDetails), @"mvc.1.0.view", @"/Views/Job/DisplayDetails.cshtml")]
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
#line 1 "C:\Users\Chandra Mouli\source\repos\MVC by VS\Demo6\Demo6\Views\_ViewImports.cshtml"
using Demo6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Chandra Mouli\source\repos\MVC by VS\Demo6\Demo6\Views\Job\DisplayDetails.cshtml"
using Demo6.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe0244af1ad769a9113c19fbe556769e1f1460a9", @"/Views/Job/DisplayDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0aab0efa45ba2d4cb68b1230e20f6ec013272657", @"/Views/_ViewImports.cshtml")]
    public class Views_Job_DisplayDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Registeration>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe0244af1ad769a9113c19fbe556769e1f1460a93269", async() => {
                WriteLiteral("\n");
#nullable restore
#line 6 "C:\Users\Chandra Mouli\source\repos\MVC by VS\Demo6\Demo6\Views\Job\DisplayDetails.cshtml"
      
        ViewData["Title"] = "Details Page";
    

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe0244af1ad769a9113c19fbe556769e1f1460a94458", async() => {
                WriteLiteral("\n\n    <h1>Submitted Details</h1>\n    <table border=\"1\" align=\"center\">\n        <tr>\n            <td> Full Name </td>\n            <td>");
#nullable restore
#line 16 "C:\Users\Chandra Mouli\source\repos\MVC by VS\Demo6\Demo6\Views\Job\DisplayDetails.cshtml"
           Write(Model.fName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" &nbsp; ");
#nullable restore
#line 16 "C:\Users\Chandra Mouli\source\repos\MVC by VS\Demo6\Demo6\Views\Job\DisplayDetails.cshtml"
                               Write(Model.mName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" &nbsp;");
#nullable restore
#line 16 "C:\Users\Chandra Mouli\source\repos\MVC by VS\Demo6\Demo6\Views\Job\DisplayDetails.cshtml"
                                                  Write(Model.lName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>Date of Birth </td>\n            <td>");
#nullable restore
#line 20 "C:\Users\Chandra Mouli\source\repos\MVC by VS\Demo6\Demo6\Views\Job\DisplayDetails.cshtml"
           Write(Model.Date);

#line default
#line hidden
#nullable disable
                WriteLiteral(" &nbsp; ");
#nullable restore
#line 20 "C:\Users\Chandra Mouli\source\repos\MVC by VS\Demo6\Demo6\Views\Job\DisplayDetails.cshtml"
                              Write(Model.Month);

#line default
#line hidden
#nullable disable
                WriteLiteral(" &nbsp; ");
#nullable restore
#line 20 "C:\Users\Chandra Mouli\source\repos\MVC by VS\Demo6\Demo6\Views\Job\DisplayDetails.cshtml"
                                                  Write(Model.Year);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n        </tr>        \n        <tr>\n            <td>Street Address</td>\n            <td>");
#nullable restore
#line 24 "C:\Users\Chandra Mouli\source\repos\MVC by VS\Demo6\Demo6\Views\Job\DisplayDetails.cshtml"
           Write(Model.StreetAddress);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>Street Address1</td>\n            <td>");
#nullable restore
#line 28 "C:\Users\Chandra Mouli\source\repos\MVC by VS\Demo6\Demo6\Views\Job\DisplayDetails.cshtml"
           Write(Model.StreetAddress1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>City</td>\n            <td>");
#nullable restore
#line 32 "C:\Users\Chandra Mouli\source\repos\MVC by VS\Demo6\Demo6\Views\Job\DisplayDetails.cshtml"
           Write(Model.StreetAddress1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>State / Province</td>\n            <td>");
#nullable restore
#line 36 "C:\Users\Chandra Mouli\source\repos\MVC by VS\Demo6\Demo6\Views\Job\DisplayDetails.cshtml"
           Write(Model.State);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>Postal/Zip Code</td>\n            <td>");
#nullable restore
#line 40 "C:\Users\Chandra Mouli\source\repos\MVC by VS\Demo6\Demo6\Views\Job\DisplayDetails.cshtml"
           Write(Model.PinCode);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>EMail Address</td>\n            <td>");
#nullable restore
#line 44 "C:\Users\Chandra Mouli\source\repos\MVC by VS\Demo6\Demo6\Views\Job\DisplayDetails.cshtml"
           Write(Model.EMail);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>Phone Number</td>\n            <td>");
#nullable restore
#line 48 "C:\Users\Chandra Mouli\source\repos\MVC by VS\Demo6\Demo6\Views\Job\DisplayDetails.cshtml"
           Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>LinkedIn</td>\n            <td>");
#nullable restore
#line 52 "C:\Users\Chandra Mouli\source\repos\MVC by VS\Demo6\Demo6\Views\Job\DisplayDetails.cshtml"
           Write(Model.LinkedIn);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>Position Applied</td>\n            <td>");
#nullable restore
#line 56 "C:\Users\Chandra Mouli\source\repos\MVC by VS\Demo6\Demo6\Views\Job\DisplayDetails.cshtml"
           Write(Model.PositionApplied);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>About Us</td>\n            <td>");
#nullable restore
#line 60 "C:\Users\Chandra Mouli\source\repos\MVC by VS\Demo6\Demo6\Views\Job\DisplayDetails.cshtml"
           Write(Model.Aboutus);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>Available Start Date</td>\n            <td>");
#nullable restore
#line 64 "C:\Users\Chandra Mouli\source\repos\MVC by VS\Demo6\Demo6\Views\Job\DisplayDetails.cshtml"
           Write(Model.AppStartDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>Cover Letter</td>\n            <td>");
#nullable restore
#line 68 "C:\Users\Chandra Mouli\source\repos\MVC by VS\Demo6\Demo6\Views\Job\DisplayDetails.cshtml"
           Write(Model.CoverLetter);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n        </tr>\n\n    </table>\n\n  \n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Registeration> Html { get; private set; }
    }
}
#pragma warning restore 1591