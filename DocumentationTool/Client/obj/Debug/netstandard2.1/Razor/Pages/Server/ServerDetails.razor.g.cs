#pragma checksum "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Server\ServerDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b9304e1c233130dbaa6cd0088873b02a0e4d53a"
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
#line 1 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using Syncfusion.Blazor.Diagrams;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Helpers.Modals;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Shared.Tags;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Excel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Hardware;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Contacts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Infrastucture;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Software;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Sowftware;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Network;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Hardware;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Contacts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Information;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Network;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Server\ServerDetails.razor"
using DocumentationTool.Client.Shared.Tabs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Server\ServerDetails.razor"
using DocumentationTool.Client.Shared.GeneralSH;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Server\ServerDetails.razor"
using DocumentationTool.Client.Shared.FormFactorSH;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Server\ServerDetails.razor"
using DocumentationTool.Client.Shared.PowerConsumerSH;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Server\ServerDetails.razor"
using DocumentationTool.Client.Shared.ModelSH;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Server\ServerDetails.razor"
using DocumentationTool.Client.Shared.CPUSH;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Server\ServerDetails.razor"
using DocumentationTool.Client.Shared.MemorySH;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Server\ServerDetails.razor"
using DocumentationTool.Client.Shared.DevicePortSH;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Server\ServerDetails.razor"
using DocumentationTool.Client.Shared.HostAddressSH;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Server\ServerDetails.razor"
using DocumentationTool.Client.Pages.Contacts;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/server/detail/{ServerId:int}")]
    public partial class ServerDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Server details</h3>\r\n\r\n");
#nullable restore
#line 19 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Server\ServerDetails.razor"
 if (Server != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<DocumentationTool.Client.Shared.Tabs.TabControl>(1);
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenComponent<DocumentationTool.Client.Shared.Tabs.TabPage>(4);
                __builder2.AddAttribute(5, "Text", "General");
                __builder2.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(7, "\r\n        ");
                    __builder3.OpenComponent<DocumentationTool.Client.Shared.GeneralSH.GeneralDetails>(8);
                    __builder3.AddAttribute(9, "General", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DocumentationTool.Shared.Entities.Hardware.General>(
#nullable restore
#line 23 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Server\ServerDetails.razor"
                                 Server.General

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(10, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n    ");
                __builder2.OpenComponent<DocumentationTool.Client.Shared.Tabs.TabPage>(12);
                __builder2.AddAttribute(13, "Text", "Form factor");
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(15, "\r\n        ");
                    __builder3.OpenComponent<DocumentationTool.Client.Shared.FormFactorSH.FormFactorDetail>(16);
                    __builder3.AddAttribute(17, "FormFactor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DocumentationTool.Shared.Entities.Shared.FormFactor>(
#nullable restore
#line 26 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Server\ServerDetails.razor"
                                      Server.FormFactor

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(18, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n    ");
                __builder2.OpenComponent<DocumentationTool.Client.Shared.Tabs.TabPage>(20);
                __builder2.AddAttribute(21, "Text", "Power consumer");
                __builder2.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(23, "\r\n        ");
                    __builder3.OpenComponent<DocumentationTool.Client.Shared.PowerConsumerSH.PowerConsumerDetail>(24);
                    __builder3.AddAttribute(25, "PowerConsumer", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DocumentationTool.Shared.Entities.Shared.PowerConsumer>(
#nullable restore
#line 29 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Server\ServerDetails.razor"
                                            Server.PowerConsumer

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(26, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n    ");
                __builder2.OpenComponent<DocumentationTool.Client.Shared.Tabs.TabPage>(28);
                __builder2.AddAttribute(29, "Text", "Model");
                __builder2.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(31, "\r\n        ");
                    __builder3.OpenComponent<DocumentationTool.Client.Shared.ModelSH.ModelDetail>(32);
                    __builder3.AddAttribute(33, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DocumentationTool.Shared.Entities.Hardware.Model>(
#nullable restore
#line 32 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Server\ServerDetails.razor"
                            Server.Model

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(34, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n    ");
                __builder2.OpenComponent<DocumentationTool.Client.Shared.Tabs.TabPage>(36);
                __builder2.AddAttribute(37, "Text", "CPU");
                __builder2.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(39, "\r\n        ");
                    __builder3.OpenComponent<DocumentationTool.Client.Shared.CPUSH.CPUDetail>(40);
                    __builder3.AddAttribute(41, "CPU", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DocumentationTool.Shared.Entities.Hardware.CPU>(
#nullable restore
#line 35 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Server\ServerDetails.razor"
                        Server.CPU

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(42, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(43, "\r\n    ");
                __builder2.OpenComponent<DocumentationTool.Client.Shared.Tabs.TabPage>(44);
                __builder2.AddAttribute(45, "Text", "Memory");
                __builder2.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(47, "\r\n        ");
                    __builder3.OpenComponent<DocumentationTool.Client.Shared.MemorySH.MemoryDetail>(48);
                    __builder3.AddAttribute(49, "Memory", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DocumentationTool.Shared.Entities.Hardware.Memory>(
#nullable restore
#line 38 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Server\ServerDetails.razor"
                              Server.Memory

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(50, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n    ");
                __builder2.OpenComponent<DocumentationTool.Client.Shared.Tabs.TabPage>(52);
                __builder2.AddAttribute(53, "Text", "Port");
                __builder2.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(55, "\r\n        ");
                    __builder3.OpenComponent<DocumentationTool.Client.Shared.DevicePortSH.DeviceIndex>(56);
                    __builder3.AddAttribute(57, "Device", "server");
                    __builder3.AddAttribute(58, "DeviceId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 42 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Server\ServerDetails.razor"
                               ServerId

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(59, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(60, "\r\n    ");
                __builder2.OpenComponent<DocumentationTool.Client.Shared.Tabs.TabPage>(61);
                __builder2.AddAttribute(62, "Text", "Host address");
                __builder2.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(64, "\r\n        ");
                    __builder3.OpenComponent<DocumentationTool.Client.Shared.HostAddressSH.HostAddressIndex>(65);
                    __builder3.AddAttribute(66, "DeviceHostAddress", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DocumentationTool.Shared.Entities.Shared.HostAddress>(
#nullable restore
#line 45 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Server\ServerDetails.razor"
                                             Server.HostAddress

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(67, "Device", "server");
                    __builder3.AddAttribute(68, "DeviceId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 47 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Server\ServerDetails.razor"
                                    Server.Id

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(69, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(70, "\r\n    ");
                __builder2.OpenComponent<DocumentationTool.Client.Shared.Tabs.TabPage>(71);
                __builder2.AddAttribute(72, "Text", "Contacts");
                __builder2.AddAttribute(73, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(74, "\r\n        ");
                    __builder3.OpenComponent<DocumentationTool.Client.Pages.Contacts.ContactForDevices>(75);
                    __builder3.AddAttribute(76, "ServerDevice", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DocumentationTool.Shared.Entities.Hardware.ServerDevice>(
#nullable restore
#line 52 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Server\ServerDetails.razor"
                                         Server

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(77, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(78, "\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(79, "\r\n");
#nullable restore
#line 56 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Server\ServerDetails.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Server\ServerDetails.razor"
       
    [Parameter]
    public int ServerId { get; set; }

    public ServerDevice Server;

    public string ServerName = "server";

    protected async override Task OnInitializedAsync()
    {
        Server = await serverRepository.GetServerDevice(ServerId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServerRepository serverRepository { get; set; }
    }
}
#pragma warning restore 1591
