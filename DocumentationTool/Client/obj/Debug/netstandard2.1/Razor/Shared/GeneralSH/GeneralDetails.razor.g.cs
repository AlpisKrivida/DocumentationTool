#pragma checksum "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\GeneralSH\GeneralDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bf9175d09b868c1ecaf19d1415795bc692c67b2"
// <auto-generated/>
#pragma warning disable 1591
namespace DocumentationTool.Client.Shared.GeneralSH
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using Syncfusion.Blazor.Diagrams;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Shared.Tags;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Excel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Hardware;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Contacts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Infrastucture;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Software;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Sowftware;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Network;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Hardware;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Contacts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Information;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Network;

#line default
#line hidden
#nullable disable
    public partial class GeneralDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid pt-4");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<div class=\"row\">\r\n        <div class=\"col-8\">\r\n            <h3>General Details</h3>\r\n        </div>\r\n    </div>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-8");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "row");
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.AddMarkupContent(16, "<label class=\"font-weight-bold text-left\">Title: </label>\r\n                    ");
            __builder.OpenElement(17, "label");
            __builder.AddAttribute(18, "class", "text-right pl-3");
            __builder.AddContent(19, 
#nullable restore
#line 12 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\GeneralSH\GeneralDetails.razor"
                                                    General.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "row");
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.AddMarkupContent(25, "<label class=\"font-weight-bold text-left\">Purpose: </label>\r\n                    ");
            __builder.OpenElement(26, "label");
            __builder.AddAttribute(27, "class", "text-right pl-3");
            __builder.AddContent(28, 
#nullable restore
#line 20 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\GeneralSH\GeneralDetails.razor"
                                                    General.Purpose

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "row");
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.AddMarkupContent(34, "<label class=\"font-weight-bold text-left\">Creation date: </label>\r\n                    ");
            __builder.OpenElement(35, "label");
            __builder.AddAttribute(36, "class", "text-right pl-3");
            __builder.AddContent(37, 
#nullable restore
#line 24 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\GeneralSH\GeneralDetails.razor"
                                                    General.CreatioDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "row");
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.AddMarkupContent(43, "<label class=\"font-weight-bold text-left\">Date of change: </label>\r\n                    ");
            __builder.OpenElement(44, "label");
            __builder.AddAttribute(45, "class", "text-right pl-3");
            __builder.AddContent(46, 
#nullable restore
#line 28 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\GeneralSH\GeneralDetails.razor"
                                                    General.DateOfChange

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "row");
            __builder.AddMarkupContent(51, "\r\n                    ");
            __builder.AddMarkupContent(52, "<label class=\"font-weight-bold text-left\">Status: </label>\r\n                    ");
            __builder.OpenElement(53, "label");
            __builder.AddAttribute(54, "class", "text-right pl-3");
            __builder.AddContent(55, 
#nullable restore
#line 36 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\GeneralSH\GeneralDetails.razor"
                                                    General.Status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "row");
            __builder.AddMarkupContent(60, "\r\n                    ");
            __builder.AddMarkupContent(61, "<label class=\"font-weight-bold text-left\">Description: </label>\r\n                    ");
            __builder.OpenElement(62, "label");
            __builder.AddAttribute(63, "class", "text-right pl-3");
            __builder.AddContent(64, 
#nullable restore
#line 52 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\GeneralSH\GeneralDetails.razor"
                                                    General.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\GeneralSH\GeneralDetails.razor"
       
    [Parameter] public General General { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
