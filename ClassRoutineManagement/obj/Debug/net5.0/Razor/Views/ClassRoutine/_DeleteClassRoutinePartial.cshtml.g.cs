#pragma checksum "E:\ASPCore\FinalProject\ClassRoutineManagement\ClassRoutineManagement\Views\ClassRoutine\_DeleteClassRoutinePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d8c3fcce8fabc622c59064d4cac93a52869ac1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ClassRoutine__DeleteClassRoutinePartial), @"mvc.1.0.view", @"/Views/ClassRoutine/_DeleteClassRoutinePartial.cshtml")]
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
#line 1 "E:\ASPCore\FinalProject\ClassRoutineManagement\ClassRoutineManagement\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ASPCore\FinalProject\ClassRoutineManagement\ClassRoutineManagement\Views\_ViewImports.cshtml"
using ClassRoutineManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\ASPCore\FinalProject\ClassRoutineManagement\ClassRoutineManagement\Views\_ViewImports.cshtml"
using ClassRoutineManagement.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\ASPCore\FinalProject\ClassRoutineManagement\ClassRoutineManagement\Views\_ViewImports.cshtml"
using ClassRoutineManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\ASPCore\FinalProject\ClassRoutineManagement\ClassRoutineManagement\Views\_ViewImports.cshtml"
using ClassRoutineManagement.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d8c3fcce8fabc622c59064d4cac93a52869ac1b", @"/Views/ClassRoutine/_DeleteClassRoutinePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbaaf2dcad6d03ff0e5953f212d12ea6605e8ffb", @"/Views/_ViewImports.cshtml")]
    public class Views_ClassRoutine__DeleteClassRoutinePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClassRoutineManagement.ViewModels.ClassRoutineCreateViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h4>Class Routine</h4>

<div class=""modal fade"" id=""deleteRoutine"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"" id=""addRoutineLabel"">Are you sure you want to delete this record?</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"">
                    <span>x</span>
                </button>
            </div>

            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d8c3fcce8fabc622c59064d4cac93a52869ac1b6518", async() => {
                WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7d8c3fcce8fabc622c59064d4cac93a52869ac1b6850", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 18 "E:\ASPCore\FinalProject\ClassRoutineManagement\ClassRoutineManagement\Views\ClassRoutine\_DeleteClassRoutinePartial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                WriteLiteral("                        ");
#nullable restore
#line 20 "E:\ASPCore\FinalProject\ClassRoutineManagement\ClassRoutineManagement\Views\ClassRoutine\_DeleteClassRoutinePartial.cshtml"
                   Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 23 "E:\ASPCore\FinalProject\ClassRoutineManagement\ClassRoutineManagement\Views\ClassRoutine\_DeleteClassRoutinePartial.cshtml"
                   Write(Html.DisplayFor(model => model.DayOfWeek));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d8c3fcce8fabc622c59064d4cac93a52869ac1b9474", async() => {
#nullable restore
#line 26 "E:\ASPCore\FinalProject\ClassRoutineManagement\ClassRoutineManagement\Views\ClassRoutine\_DeleteClassRoutinePartial.cshtml"
                                                                    Write(Model.StartTime);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 26 "E:\ASPCore\FinalProject\ClassRoutineManagement\ClassRoutineManagement\Views\ClassRoutine\_DeleteClassRoutinePartial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StartTime);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d8c3fcce8fabc622c59064d4cac93a52869ac1b11499", async() => {
#nullable restore
#line 29 "E:\ASPCore\FinalProject\ClassRoutineManagement\ClassRoutineManagement\Views\ClassRoutine\_DeleteClassRoutinePartial.cshtml"
                                                                  Write(Model.EndTime);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 29 "E:\ASPCore\FinalProject\ClassRoutineManagement\ClassRoutineManagement\Views\ClassRoutine\_DeleteClassRoutinePartial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.EndTime);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 33 "E:\ASPCore\FinalProject\ClassRoutineManagement\ClassRoutineManagement\Views\ClassRoutine\_DeleteClassRoutinePartial.cshtml"
                   Write(Html.DisplayNameFor(model => model.ClassesId));

#line default
#line hidden
#nullable disable
                WriteLiteral(":\r\n                        ");
#nullable restore
#line 34 "E:\ASPCore\FinalProject\ClassRoutineManagement\ClassRoutineManagement\Views\ClassRoutine\_DeleteClassRoutinePartial.cshtml"
                   Write(Html.DisplayFor(model => model.ClassesId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n");
                WriteLiteral("                        ");
#nullable restore
#line 38 "E:\ASPCore\FinalProject\ClassRoutineManagement\ClassRoutineManagement\Views\ClassRoutine\_DeleteClassRoutinePartial.cshtml"
                   Write(Html.DisplayNameFor(model => model.SubjectId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 39 "E:\ASPCore\FinalProject\ClassRoutineManagement\ClassRoutineManagement\Views\ClassRoutine\_DeleteClassRoutinePartial.cshtml"
                   Write(Html.DisplayFor(model => model.SubjectId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 42 "E:\ASPCore\FinalProject\ClassRoutineManagement\ClassRoutineManagement\Views\ClassRoutine\_DeleteClassRoutinePartial.cshtml"
                   Write(Html.DisplayNameFor(model => model.ClassRoomId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 43 "E:\ASPCore\FinalProject\ClassRoutineManagement\ClassRoutineManagement\Views\ClassRoutine\_DeleteClassRoutinePartial.cshtml"
                   Write(Html.DisplayFor(model => model.ClassRoomId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"form-group\">\r\n                        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"modal-footer\">\r\n                <button type=\"button\" class=\"btn btn-outline-danger\" data-dismiss=\"modal\">Close</button>\r\n");
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClassRoutineManagement.ViewModels.ClassRoutineCreateViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591