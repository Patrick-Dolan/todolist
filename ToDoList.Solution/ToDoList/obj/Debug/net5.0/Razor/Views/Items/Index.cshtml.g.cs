#pragma checksum "C:\Users\dolan\OneDrive\Documents\Epicodus\C# and .NET\Week 1-2 TDD with C#\todolist\ToDoList.Solution\ToDoList\Views\Items\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "990b2ce6687a65276dbdd5f51fcb34f5be08460e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Index), @"mvc.1.0.view", @"/Views/Items/Index.cshtml")]
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
#line 1 "C:\Users\dolan\OneDrive\Documents\Epicodus\C# and .NET\Week 1-2 TDD with C#\todolist\ToDoList.Solution\ToDoList\Views\Items\Index.cshtml"
using ToDoList.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"990b2ce6687a65276dbdd5f51fcb34f5be08460e", @"/Views/Items/Index.cshtml")]
    public class Views_Items_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>To Do List</h1>\r\n");
#nullable restore
#line 4 "C:\Users\dolan\OneDrive\Documents\Epicodus\C# and .NET\Week 1-2 TDD with C#\todolist\ToDoList.Solution\ToDoList\Views\Items\Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>There are no items in the list.</p>\r\n");
#nullable restore
#line 7 "C:\Users\dolan\OneDrive\Documents\Epicodus\C# and .NET\Week 1-2 TDD with C#\todolist\ToDoList.Solution\ToDoList\Views\Items\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<ul>\r\n");
#nullable restore
#line 9 "C:\Users\dolan\OneDrive\Documents\Epicodus\C# and .NET\Week 1-2 TDD with C#\todolist\ToDoList.Solution\ToDoList\Views\Items\Index.cshtml"
   foreach (Item item in Model)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>");
#nullable restore
#line 11 "C:\Users\dolan\OneDrive\Documents\Epicodus\C# and .NET\Week 1-2 TDD with C#\todolist\ToDoList.Solution\ToDoList\Views\Items\Index.cshtml"
   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 12 "C:\Users\dolan\OneDrive\Documents\Epicodus\C# and .NET\Week 1-2 TDD with C#\todolist\ToDoList.Solution\ToDoList\Views\Items\Index.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n<a href=\"/items/new\">Add a new item.</a>");
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
