#pragma checksum "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "789932bdebf3f6462fd3de140b820935affa7939"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/search/{searchTag}")]
    public partial class Search : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.DocumentationTool.Client.Pages.Search.Search.TypeInference.CreateGenericList_0(__builder, 0, 1, 
#nullable restore
#line 11 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                       Monitors

#line default
#line hidden
#nullable disable
            , 2, (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n            ");
                __builder2.OpenElement(4, "table");
                __builder2.AddAttribute(5, "class", "table");
                __builder2.AddMarkupContent(6, "\r\n                ");
                __builder2.AddMarkupContent(7, "<thead class=\"thead-light\">\r\n                    <tr>\r\n                        <th>Title</th>\r\n                        <th>Status</th>\r\n                        <th>Action</th>\r\n                    </tr>\r\n                </thead>\r\n                ");
                __builder2.OpenElement(8, "tbody");
                __builder2.AddMarkupContent(9, "\r\n");
#nullable restore
#line 22 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                     foreach (var item in Monitors)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                         if (item.General.Tag != null)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(10, "                            ");
                __builder2.OpenComponent<DocumentationTool.Client.Pages.Search.ShowItems>(11);
                __builder2.AddAttribute(12, "General", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DocumentationTool.Shared.Entities.Hardware.General>(
#nullable restore
#line 26 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                                                item.General

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "Id", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 26 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                                                                  item.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "name", "monitor");
                __builder2.AddAttribute(15, "Tags", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<System.String>>(
#nullable restore
#line 26 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                                                                                                Tags

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n");
#nullable restore
#line 27 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                         
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                     if (Cables != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                         foreach (var item in Cables)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(17, "                            ");
                __builder2.OpenComponent<DocumentationTool.Client.Pages.Search.ShowItems>(18);
                __builder2.AddAttribute(19, "General", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DocumentationTool.Shared.Entities.Hardware.General>(
#nullable restore
#line 33 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                                                item.General

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "Id", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 33 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                                                                  item.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "name", "cable");
                __builder2.AddAttribute(22, "Tags", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<System.String>>(
#nullable restore
#line 33 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                                                                                              Tags

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n");
#nullable restore
#line 34 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                         
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                     if (People != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                         foreach (var item in People)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(24, "                            ");
                __builder2.OpenComponent<DocumentationTool.Client.Pages.Search.ShowItems>(25);
                __builder2.AddAttribute(26, "General", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DocumentationTool.Shared.Entities.Hardware.General>(
#nullable restore
#line 40 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                                                item.General

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "Id", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 40 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                                                                  item.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "name", "person");
                __builder2.AddAttribute(29, "Tags", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<System.String>>(
#nullable restore
#line 40 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                                                                                               Tags

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n");
#nullable restore
#line 41 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                         
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                     if (ClientPCs != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                         foreach (var item in ClientPCs)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(31, "                            ");
                __builder2.OpenComponent<DocumentationTool.Client.Pages.Search.ShowItems>(32);
                __builder2.AddAttribute(33, "General", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DocumentationTool.Shared.Entities.Hardware.General>(
#nullable restore
#line 47 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                                                item.General

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "Id", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 47 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                                                                  item.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "name", "client");
                __builder2.AddAttribute(36, "Tags", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<System.String>>(
#nullable restore
#line 47 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                                                                                               Tags

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n");
#nullable restore
#line 48 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                         
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                     if (Printers != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                         foreach (var item in Printers)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(38, "                            ");
                __builder2.OpenComponent<DocumentationTool.Client.Pages.Search.ShowItems>(39);
                __builder2.AddAttribute(40, "General", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DocumentationTool.Shared.Entities.Hardware.General>(
#nullable restore
#line 54 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                                                item.General

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "Id", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 54 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                                                                  item.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "name", "printer");
                __builder2.AddAttribute(43, "Tags", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<System.String>>(
#nullable restore
#line 54 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                                                                                                Tags

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n");
#nullable restore
#line 55 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                         
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                     if (RouterDevices != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                         foreach (var item in RouterDevices)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(45, "                            ");
                __builder2.OpenComponent<DocumentationTool.Client.Pages.Search.ShowItems>(46);
                __builder2.AddAttribute(47, "General", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DocumentationTool.Shared.Entities.Hardware.General>(
#nullable restore
#line 61 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                                                item.General

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "Id", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 61 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                                                                  item.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "name", "router");
                __builder2.AddAttribute(50, "Tags", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<System.String>>(
#nullable restore
#line 61 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                                                                                               Tags

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n");
#nullable restore
#line 62 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                         
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                     if (ServerDevices != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                         foreach (var item in ServerDevices)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(52, "                            ");
                __builder2.OpenComponent<DocumentationTool.Client.Pages.Search.ShowItems>(53);
                __builder2.AddAttribute(54, "General", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DocumentationTool.Shared.Entities.Hardware.General>(
#nullable restore
#line 68 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                                                item.General

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "Id", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 68 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                                                                  item.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "name", "server");
                __builder2.AddAttribute(57, "Tags", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<System.String>>(
#nullable restore
#line 68 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                                                                                               Tags

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(58, "\r\n");
#nullable restore
#line 69 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                         
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                     if (Switches != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                         foreach (var item in Switches)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(59, "                            ");
                __builder2.OpenComponent<DocumentationTool.Client.Pages.Search.ShowItems>(60);
                __builder2.AddAttribute(61, "General", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DocumentationTool.Shared.Entities.Hardware.General>(
#nullable restore
#line 75 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                                                item.General

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "Id", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 75 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                                                                  item.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "name", "switch");
                __builder2.AddAttribute(64, "Tags", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<System.String>>(
#nullable restore
#line 75 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                                                                                               Tags

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\r\n");
#nullable restore
#line 76 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Search\Search.razor"
                         
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(66, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n        ");
            }
            );
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
namespace __Blazor.DocumentationTool.Client.Pages.Search.Search
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateGenericList_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::DocumentationTool.Client.Shared.GenericList<TItem>>(seq);
        __builder.AddAttribute(__seq0, "List", __arg0);
        __builder.AddAttribute(__seq1, "WholeListTemplate", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
