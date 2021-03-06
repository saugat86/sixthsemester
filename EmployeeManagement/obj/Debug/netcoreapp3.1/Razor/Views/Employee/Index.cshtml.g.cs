#pragma checksum "C:\Users\SAUGAT\source\repos\EmployeeManagement\EmployeeManagement\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b82e2aaf16a205810d917fd8e7e32c0bcbff7676"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
#line 1 "C:\Users\SAUGAT\source\repos\EmployeeManagement\EmployeeManagement\Views\_ViewImports.cshtml"
using EmployeeManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SAUGAT\source\repos\EmployeeManagement\EmployeeManagement\Views\_ViewImports.cshtml"
using EmployeeManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b82e2aaf16a205810d917fd8e7e32c0bcbff7676", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3af35a328bfe0c906f75d04efeba14f80e1f583b", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Person>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\SAUGAT\source\repos\EmployeeManagement\EmployeeManagement\Views\Employee\Index.cshtml"
  
  ViewData["Title"] = "Employee Home";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>All Employees [");
#nullable restore
#line 7 "C:\Users\SAUGAT\source\repos\EmployeeManagement\EmployeeManagement\Views\Employee\Index.cshtml"
              Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"]</h1>

<table class=""table"">
  <thead class=""thead-dark"">
    <tr>
      <th scope=""col"">#</th>
      <th scope=""col"">First</th>
      <th scope=""col"">Last</th>
      <th scope=""col"">Address</th>
      <th scope=""col"">Gender</th>
      <th scope=""col"">Salary</th>
      <th scope=""col""></th>
      <th scope=""col""></th>
    </tr>
  </thead>
  <tbody>
");
#nullable restore
#line 23 "C:\Users\SAUGAT\source\repos\EmployeeManagement\EmployeeManagement\Views\Employee\Index.cshtml"
     for (int i = 0; i < Model.Count; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <tr>\r\n        <td>");
#nullable restore
#line 26 "C:\Users\SAUGAT\source\repos\EmployeeManagement\EmployeeManagement\Views\Employee\Index.cshtml"
        Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>\r\n");
#nullable restore
#line 28 "C:\Users\SAUGAT\source\repos\EmployeeManagement\EmployeeManagement\Views\Employee\Index.cshtml"
            
            string fn = Model[i].Firstname;
          

#line default
#line hidden
#nullable disable
            WriteLiteral("          <a");
            BeginWriteAttribute("href", " href=\"", 657, "\"", 696, 2);
            WriteAttributeValue("", 664, "/employee/detail?id=", 664, 20, true);
#nullable restore
#line 31 "C:\Users\SAUGAT\source\repos\EmployeeManagement\EmployeeManagement\Views\Employee\Index.cshtml"
WriteAttributeValue("", 684, Model[i].id, 684, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 31 "C:\Users\SAUGAT\source\repos\EmployeeManagement\EmployeeManagement\Views\Employee\Index.cshtml"
                                                Write(fn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </td>\r\n        <td>");
#nullable restore
#line 33 "C:\Users\SAUGAT\source\repos\EmployeeManagement\EmployeeManagement\Views\Employee\Index.cshtml"
       Write(Model[i].Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 34 "C:\Users\SAUGAT\source\repos\EmployeeManagement\EmployeeManagement\Views\Employee\Index.cshtml"
       Write(Model[i].Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 35 "C:\Users\SAUGAT\source\repos\EmployeeManagement\EmployeeManagement\Views\Employee\Index.cshtml"
       Write(Model[i].Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 36 "C:\Users\SAUGAT\source\repos\EmployeeManagement\EmployeeManagement\Views\Employee\Index.cshtml"
       Write(Model[i].Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>\r\n          <a class=\"btn btn-warning\"");
            BeginWriteAttribute("href", " href=\"", 915, "\"", 952, 2);
            WriteAttributeValue("", 922, "/Employee/Edit?id=", 922, 18, true);
#nullable restore
#line 38 "C:\Users\SAUGAT\source\repos\EmployeeManagement\EmployeeManagement\Views\Employee\Index.cshtml"
WriteAttributeValue("", 940, Model[i].id, 940, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n          <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 999, "\"", 1038, 2);
            WriteAttributeValue("", 1006, "/Employee/Delete?id=", 1006, 20, true);
#nullable restore
#line 39 "C:\Users\SAUGAT\source\repos\EmployeeManagement\EmployeeManagement\Views\Employee\Index.cshtml"
WriteAttributeValue("", 1026, Model[i].id, 1026, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n        </td>\r\n\r\n      </tr>\r\n");
#nullable restore
#line 43 "C:\Users\SAUGAT\source\repos\EmployeeManagement\EmployeeManagement\Views\Employee\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Person>> Html { get; private set; }
    }
}
#pragma warning restore 1591
