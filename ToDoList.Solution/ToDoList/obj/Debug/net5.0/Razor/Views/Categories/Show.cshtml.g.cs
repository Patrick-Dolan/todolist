#pragma checksum "C:\Users\dolan\OneDrive\Documents\Epicodus\C# and .NET\Week1-2\todolist\ToDoList.Solution\ToDoList\Views\Categories\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a55cb6b80822cab81ece68989b6965503117538"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Show), @"mvc.1.0.view", @"/Views/Categories/Show.cshtml")]
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
#line 9 "C:\Users\dolan\OneDrive\Documents\Epicodus\C# and .NET\Week1-2\todolist\ToDoList.Solution\ToDoList\Views\Categories\Show.cshtml"
using ToDoList.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a55cb6b80822cab81ece68989b6965503117538", @"/Views/Categories/Show.cshtml")]
    public class Views_Categories_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a55cb6b80822cab81ece68989b69655031175383009", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <title>My To-Do List!</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"" integrity=""sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk"" crossorigin=""anonymous"">
  ");
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
            WriteLiteral("\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a55cb6b80822cab81ece68989b69655031175384268", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("\r\n    <h3>Here are all the items in this category:</h3>\r\n\r\n    <ol>\r\n");
#nullable restore
#line 14 "C:\Users\dolan\OneDrive\Documents\Epicodus\C# and .NET\Week1-2\todolist\ToDoList.Solution\ToDoList\Views\Categories\Show.cshtml"
     foreach (Item item in @Model["items"])
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("      <li><a");
                BeginWriteAttribute("href", " href=\'", 498, "\'", 553, 4);
                WriteAttributeValue("", 505, "/categories/", 505, 12, true);
#nullable restore
#line 16 "C:\Users\dolan\OneDrive\Documents\Epicodus\C# and .NET\Week1-2\todolist\ToDoList.Solution\ToDoList\Views\Categories\Show.cshtml"
WriteAttributeValue("", 517, Model["category"].Id, 517, 21, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 538, "/items/", 538, 7, true);
#nullable restore
#line 16 "C:\Users\dolan\OneDrive\Documents\Epicodus\C# and .NET\Week1-2\todolist\ToDoList.Solution\ToDoList\Views\Categories\Show.cshtml"
WriteAttributeValue("", 545, item.Id, 545, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 16 "C:\Users\dolan\OneDrive\Documents\Epicodus\C# and .NET\Week1-2\todolist\ToDoList.Solution\ToDoList\Views\Categories\Show.cshtml"
                                                                Write(item.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></li>\r\n");
#nullable restore
#line 17 "C:\Users\dolan\OneDrive\Documents\Epicodus\C# and .NET\Week1-2\todolist\ToDoList.Solution\ToDoList\Views\Categories\Show.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ol>\r\n\r\n    <p><a");
                BeginWriteAttribute("href", " href=\'", 612, "\'", 662, 3);
                WriteAttributeValue("", 619, "/categories/", 619, 12, true);
#nullable restore
#line 20 "C:\Users\dolan\OneDrive\Documents\Epicodus\C# and .NET\Week1-2\todolist\ToDoList.Solution\ToDoList\Views\Categories\Show.cshtml"
WriteAttributeValue("", 631, Model["category"].Id, 631, 21, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 652, "/items/new", 652, 10, true);
                EndWriteAttribute();
                WriteLiteral(">Add a new item</a></p>\r\n    <p><a href=\'/categories\'>Return to category list</a></p>\r\n    <p><a href=\'/\'>Return to Main Page</a></p>\r\n  ");
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
            WriteLiteral("\r\n</html>");
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
