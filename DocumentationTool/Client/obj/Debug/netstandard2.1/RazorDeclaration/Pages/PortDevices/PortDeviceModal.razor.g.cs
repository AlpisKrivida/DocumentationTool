#pragma checksum "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\PortDevices\PortDeviceModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01ace7448e66effd9cee9271ae3655b7d1433e47"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DocumentationTool.Client.Pages.PortDevices
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
    public partial class PortDeviceModal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 155 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\PortDevices\PortDeviceModal.razor"
       
    //Modal
    public Guid Guid = Guid.NewGuid();
    public string ModalDisplay = "none;";
    public string ModalClass = "";
    public bool ShowBackdrop = false;
    private bool isDisabled { get; set; } = false;

    private List<DeviceModal> Checklist = new List<DeviceModal>();


    PaginationDTO paginationDTO = new PaginationDTO();
    private int totalAmountPages;
    private int recordsPerPage = 5;


    public List<RouterDevice> RouterDevices;
    public List<Switch> SwitchDevices;

    [Parameter] public DevicePort DevicePort { get; set; }
    [Parameter] public string DeviceName { get; set; }
    [Parameter] public EventCallback<DevicePort> saved { get; set; }

    public async Task Open(string deviceName)
    {

        ModalDisplay = "block;";
        ModalClass = "Show";
        ShowBackdrop = true;
        StateHasChanged();
        DeviceName = deviceName;
        await LoadData();
        await LoadPage();
    }

    public void Close()
    {
        ModalDisplay = "none";
        ModalClass = "";
        ShowBackdrop = false;
        saved.InvokeAsync(DevicePort);
        StateHasChanged();
    }

    private void CheckBox(DeviceModal item)
    {
        item.IsActive = !item.IsActive;
        isDisabled = true;
        DevicePort.RouterDevice = item.Router;
    }

    private void ChangeDisabled()
    {
        foreach (var item in Checklist)
            item.IsActive = false;

        isDisabled = false;
    }

    protected override async Task OnInitializedAsync()
    {
        try
        {
            await LoadData();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }

    private async Task LoadPage()
    {
        paginationDTO = new PaginationDTO();
        await LoadData();
    }

    private async Task LoadData()
    {
        Checklist = new List<DeviceModal>();

        //Console.WriteLine(DeviceName);
        if (DeviceName == "Router")
        {
            paginationDTO.RecordsPerPage = recordsPerPage;
            var paginatedResponse = await routerRepository.GetRouters(paginationDTO);
            RouterDevices = paginatedResponse.Response;
            totalAmountPages = paginatedResponse.TotalAmountPages;

            foreach (var item in RouterDevices)
            {
                Checklist.Add(new DeviceModal { IsActive = false, Router = item });
            }
        }
        else if (DeviceName == "Switch")
        {
            paginationDTO.RecordsPerPage = recordsPerPage;
            var paginatedResponse = await switchRepository.GetSwitches(paginationDTO);
            SwitchDevices = paginatedResponse.Response;
            totalAmountPages = paginatedResponse.TotalAmountPages;

            foreach (var item in SwitchDevices)
            {
                Checklist.Add(new DeviceModal { IsActive = false, Switch = item });
            }

        }
        Console.WriteLine("yes " + Checklist.Count);
    }

    private async Task SelectedPage(int page)
    {
        paginationDTO.Page = page;
        await LoadData();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISwitchRepository switchRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRouterRepository routerRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICableRepository cableRepository { get; set; }
    }
}
#pragma warning restore 1591
