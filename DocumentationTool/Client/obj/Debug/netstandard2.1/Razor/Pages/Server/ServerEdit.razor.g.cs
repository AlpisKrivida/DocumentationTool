#pragma checksum "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Server\ServerEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b2735ee654271ad6f078bf0a25e7399240d3b42"
// <auto-generated/>
#pragma warning disable 1591
namespace DocumentationTool.Client.Pages.Server
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
using DocumentationTool.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Shared.Tags;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Excel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Hardware;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Contacts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Infrastucture;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Software;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Sowftware;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Hardware;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Contacts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Information;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/server/edit/{ServerId:int}")]
    public partial class ServerEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Server edit</h3>\r\n\r\n");
#nullable restore
#line 7 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Server\ServerEdit.razor"
 if (Server != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenComponent<DocumentationTool.Client.Pages.Server.ServerForm>(2);
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 9 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Server\ServerEdit.razor"
                               Edit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "General", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DocumentationTool.Shared.Entities.Hardware.General>(
#nullable restore
#line 10 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Server\ServerEdit.razor"
                          Server.General

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DocumentationTool.Shared.Entities.Hardware.Model>(
#nullable restore
#line 11 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Server\ServerEdit.razor"
                        Server.Model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "Server", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DocumentationTool.Shared.Entities.Hardware.ServerDevice>(
#nullable restore
#line 12 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Server\ServerEdit.razor"
                         Server

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "PowerConsumer", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DocumentationTool.Shared.Entities.Shared.PowerConsumer>(
#nullable restore
#line 13 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Server\ServerEdit.razor"
                                Server.PowerConsumer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "FormFactor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DocumentationTool.Shared.Entities.Shared.FormFactor>(
#nullable restore
#line 14 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Server\ServerEdit.razor"
                             Server.FormFactor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "CPU", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DocumentationTool.Shared.Entities.Hardware.CPU>(
#nullable restore
#line 15 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Server\ServerEdit.razor"
                      Server.CPU

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "Memory", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DocumentationTool.Shared.Entities.Hardware.Memory>(
#nullable restore
#line 16 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Server\ServerEdit.razor"
                         Server.Memory

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 19 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Server\ServerEdit.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Server\ServerEdit.razor"
       
    [Parameter]
    public int ServerId { get; set; }

    public ServerDevice Server;

    protected async override Task OnInitializedAsync()
    {
        Server = await serverRepository.GetServerDevice(ServerId);
    }

    private async Task Edit()
    {
        Server.General.DateOfChange = DateTime.Now;

        await serverRepository.UpdateServerDevice(Server);
        navigationManager.NavigateTo("server");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServerRepository serverRepository { get; set; }
    }
}
#pragma warning restore 1591
