#pragma checksum "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Switch\SwitchIndex.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea0739bc308e68e0686ec6768fb16589d385f6e4"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DocumentationTool.Client.Pages.Switch
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
using DocumentationTool.Client.Helpers.Modals;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Shared.Tags;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Excel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Hardware;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Contacts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Infrastucture;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Software;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Sowftware;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Network;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Hardware;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Contacts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Information;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Network;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/switch")]
    public partial class SwitchIndex : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Switch\SwitchIndex.razor"
       
    List<Switch> Switches;
    PaginationDTO paginationDTO = new PaginationDTO();
    private int totalAmountPages;
    private int recordsPerPage = 5;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            await LoadSwitches();
        }
        catch (Exception ex)
        {

        }
    }

    private async Task LoadPage()
    {
        paginationDTO = new PaginationDTO();
        await LoadSwitches();
    }

    private async Task LoadSwitches()
    {
        paginationDTO.RecordsPerPage = recordsPerPage;
        var paginatedResponse = await switchRepository.GetSwitches(paginationDTO);
        Switches = paginatedResponse.Response;
        totalAmountPages = paginatedResponse.TotalAmountPages;
    }

    private async Task SelectedPage(int page)
    {
        paginationDTO.Page = page;
        await LoadSwitches();
    }

    private async Task DeleteSwitch(int id)
    {
        await switchRepository.DeleteSwitch(id);
        await LoadSwitches();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISwitchRepository switchRepository { get; set; }
    }
}
#pragma warning restore 1591
