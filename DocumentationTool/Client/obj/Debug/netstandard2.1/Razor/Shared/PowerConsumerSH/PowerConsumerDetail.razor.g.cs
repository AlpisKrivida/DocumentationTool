#pragma checksum "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerSH\PowerConsumerDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "222f920baf6b033a4e102d12a89f0a9351ea302c"
// <auto-generated/>
#pragma warning disable 1591
namespace DocumentationTool.Client.Shared.PowerConsumerSH
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
#line 6 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Hardware;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Contacts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Excel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Hardware;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Contacts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Infrastucture;

#line default
#line hidden
#nullable disable
    public partial class PowerConsumerDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid pt-4");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<div class=\"row\">\r\n        <div class=\"col-8\">\r\n            <h3>Power Consumer Details</h3>\r\n        </div>\r\n    </div>\r\n    ");
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
#line 12 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerSH\PowerConsumerDetail.razor"
                                                    PowerConsumer.Title

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
            __builder.AddMarkupContent(25, "<label class=\"font-weight-bold text-left\">Active: </label>\r\n                    ");
            __builder.OpenElement(26, "label");
            __builder.AddAttribute(27, "class", "text-right pl-3");
            __builder.AddContent(28, 
#nullable restore
#line 16 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerSH\PowerConsumerDetail.razor"
                                                    PowerConsumer.Active

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
            __builder.AddMarkupContent(34, "<label class=\"font-weight-bold text-left\">Manufactureer: </label>\r\n                    ");
            __builder.OpenElement(35, "label");
            __builder.AddAttribute(36, "class", "text-right pl-3");
            __builder.AddContent(37, 
#nullable restore
#line 20 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerSH\PowerConsumerDetail.razor"
                                                    PowerConsumer.Manufacturer

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
            __builder.AddMarkupContent(43, "<label class=\"font-weight-bold text-left\">Power model: </label>\r\n                    ");
            __builder.OpenElement(44, "label");
            __builder.AddAttribute(45, "class", "text-right pl-3");
            __builder.AddContent(46, 
#nullable restore
#line 24 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerSH\PowerConsumerDetail.razor"
                                                    PowerConsumer.PowerModel

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
            __builder.AddMarkupContent(52, "<label class=\"font-weight-bold text-left\">Volt: </label>\r\n                    ");
            __builder.OpenElement(53, "label");
            __builder.AddAttribute(54, "class", "text-right pl-3");
            __builder.AddContent(55, 
#nullable restore
#line 28 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerSH\PowerConsumerDetail.razor"
                                                    PowerConsumer.Volt

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
            __builder.AddMarkupContent(61, "<label class=\"font-weight-bold text-left\">Watt: </label>\r\n                    ");
            __builder.OpenElement(62, "label");
            __builder.AddAttribute(63, "class", "text-right pl-3");
            __builder.AddContent(64, 
#nullable restore
#line 32 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerSH\PowerConsumerDetail.razor"
                                                    PowerConsumer.Watt

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "row");
            __builder.AddMarkupContent(69, "\r\n                    ");
            __builder.AddMarkupContent(70, "<label class=\"font-weight-bold text-left\">Ampere: </label>\r\n                    ");
            __builder.OpenElement(71, "label");
            __builder.AddAttribute(72, "class", "text-right pl-3");
            __builder.AddContent(73, 
#nullable restore
#line 36 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerSH\PowerConsumerDetail.razor"
                                                    PowerConsumer.Ampere

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "row");
            __builder.AddMarkupContent(78, "\r\n                    ");
            __builder.AddMarkupContent(79, "<label class=\"font-weight-bold text-left\">BTU: </label>\r\n                    ");
            __builder.OpenElement(80, "label");
            __builder.AddAttribute(81, "class", "text-right pl-3");
            __builder.AddContent(82, 
#nullable restore
#line 40 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerSH\PowerConsumerDetail.razor"
                                                    PowerConsumer.BTU

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                ");
            __builder.OpenElement(85, "div");
            __builder.AddAttribute(86, "class", "row");
            __builder.AddMarkupContent(87, "\r\n                    ");
            __builder.AddMarkupContent(88, "<label class=\"font-weight-bold text-left\">Description: </label>\r\n                    ");
            __builder.OpenElement(89, "label");
            __builder.AddAttribute(90, "class", "text-right pl-3");
            __builder.AddContent(91, 
#nullable restore
#line 44 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerSH\PowerConsumerDetail.razor"
                                                    PowerConsumer.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerSH\PowerConsumerDetail.razor"
       
    [Parameter] public PowerConsumer PowerConsumer { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
