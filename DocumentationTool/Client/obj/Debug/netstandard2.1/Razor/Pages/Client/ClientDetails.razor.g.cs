#pragma checksum "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Client\ClientDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48a970a39e38a507d7e8f6af8fad8a02df41e34c"
// <auto-generated/>
#pragma warning disable 1591
namespace DocumentationTool.Client.Pages.Client
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
#nullable restore
#line 1 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Client\ClientDetails.razor"
using DocumentationTool.Client.Shared.Tabs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Client\ClientDetails.razor"
using DocumentationTool.Client.Shared.GeneralSH;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Client\ClientDetails.razor"
using DocumentationTool.Client.Shared.ModelSH;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Client\ClientDetails.razor"
using DocumentationTool.Client.Shared.DesktopSH;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Client\ClientDetails.razor"
using DocumentationTool.Client.Shared.MemorySH;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Client\ClientDetails.razor"
using DocumentationTool.Client.Shared.CPUSH;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/client/detail/{ClientId:int}")]
    public partial class ClientDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Client details</h3>\r\n\r\n");
#nullable restore
#line 15 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Client\ClientDetails.razor"
 if (Client != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenComponent<DocumentationTool.Client.Shared.Tabs.TabControl>(2);
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n        ");
                __builder2.OpenComponent<DocumentationTool.Client.Shared.Tabs.TabPage>(5);
                __builder2.AddAttribute(6, "Text", "General");
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(8, "\r\n            ");
                    __builder3.OpenComponent<DocumentationTool.Client.Shared.GeneralSH.GeneralDetails>(9);
                    __builder3.AddAttribute(10, "General", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DocumentationTool.Shared.Entities.Hardware.General>(
#nullable restore
#line 19 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Client\ClientDetails.razor"
                                     Client.General

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(11, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.OpenComponent<DocumentationTool.Client.Shared.Tabs.TabPage>(13);
                __builder2.AddAttribute(14, "Text", "CPU");
                __builder2.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(16, "\r\n            ");
                    __builder3.OpenComponent<DocumentationTool.Client.Shared.CPUSH.CPUDetail>(17);
                    __builder3.AddAttribute(18, "CPU", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DocumentationTool.Shared.Entities.Hardware.CPU>(
#nullable restore
#line 22 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Client\ClientDetails.razor"
                            Client.CPU

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(19, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.OpenComponent<DocumentationTool.Client.Shared.Tabs.TabPage>(21);
                __builder2.AddAttribute(22, "Text", "Memory");
                __builder2.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(24, "\r\n            ");
                    __builder3.OpenComponent<DocumentationTool.Client.Shared.MemorySH.MemoryDetail>(25);
                    __builder3.AddAttribute(26, "Memory", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DocumentationTool.Shared.Entities.Hardware.Memory>(
#nullable restore
#line 25 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Client\ClientDetails.razor"
                                  Client.Memory

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.OpenComponent<DocumentationTool.Client.Shared.Tabs.TabPage>(29);
                __builder2.AddAttribute(30, "Text", "Desktop");
                __builder2.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(32, "\r\n            ");
                    __builder3.OpenComponent<DocumentationTool.Client.Shared.DesktopSH.DesktopDetail>(33);
                    __builder3.AddAttribute(34, "Desktop", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DocumentationTool.Shared.Entities.Hardware.Desktop>(
#nullable restore
#line 28 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Client\ClientDetails.razor"
                                    Client.Desktop

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(35, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n        ");
                __builder2.OpenComponent<DocumentationTool.Client.Shared.Tabs.TabPage>(37);
                __builder2.AddAttribute(38, "Text", "Model");
                __builder2.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(40, "\r\n            ");
                    __builder3.OpenComponent<DocumentationTool.Client.Shared.ModelSH.ModelDetail>(41);
                    __builder3.AddAttribute(42, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DocumentationTool.Shared.Entities.Hardware.Model>(
#nullable restore
#line 31 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Client\ClientDetails.razor"
                                Client.Model

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(43, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(45, "\r\n");
#nullable restore
#line 34 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Client\ClientDetails.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Client\ClientDetails.razor"
       
    [Parameter]
    public int ClientId { get; set; }

    public ClientPC Client;

    protected async override Task OnInitializedAsync()
    {
        Client = await clientsRepository.GetClientPC(ClientId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClientRepository clientsRepository { get; set; }
    }
}
#pragma warning restore 1591