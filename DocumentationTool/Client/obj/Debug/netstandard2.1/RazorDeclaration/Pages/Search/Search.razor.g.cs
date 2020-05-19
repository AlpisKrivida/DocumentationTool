#pragma checksum "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "789932bdebf3f6462fd3de140b820935affa7939"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DocumentationTool.Client.Pages.Search
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
#line 20 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Hardware;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Contacts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Infrastructure;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/search/{searchTag}")]
    public partial class Search : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 84 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
       
    [Parameter] public string searchTag { get; set; }

    List<string> Tags { get; set; }

    List<Monitor> Monitors;
    List<Cable> Cables;
    List<Person> People;
    List<ClientPC> ClientPCs;
    List<Printer> Printers;
    List<RouterDevice> RouterDevices;
    List<ServerDevice> ServerDevices;
    List<Switch> Switches;

    protected override async Task OnInitializedAsync()
    {
        Tags = searchTag.Split(null).ToList();

        try
        {
            await LoadData();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }

    protected override async Task OnParametersSetAsync()
    {
        Tags = searchTag.Split(null).ToList();
    }

    private async Task LoadData()
    {
        Monitors = await monitorRepository.GetAllMonitors();
        Cables = await cableRepository.GetAllCables();
        People = await personRepository.GetAllPeople();
        ClientPCs = await clientRepository.GetAllClientPC();
        Printers = await printerRepository.GetAllPrintersPC();
        RouterDevices = await routerRepository.GetAllRouters();
        ServerDevices = await serverReposiotry.GetAllServers();
        Switches = await switchRepository.GetAllSwitches();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISwitchRepository switchRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServerRepository serverReposiotry { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRouterRepository routerRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPrinterRepository printerRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClientRepository clientRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPersonRepostiroy personRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICableRepository cableRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMonitorRepository monitorRepository { get; set; }
    }
}
#pragma warning restore 1591
