#pragma checksum "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Client\ClientIndex.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4818d80e78185bfdcb1cfdf2bdee6ab048bc15e0"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/client")]
    public partial class ClientIndex : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<div class=\"row\">\r\n        <div class=\"col-12\">\r\n            <h3>Clients</h3>\r\n        </div>\r\n    </div>\r\n\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-12");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card");
            __builder.AddMarkupContent(12, "\r\n\r\n                ");
            __builder.AddMarkupContent(13, "<div class=\"form-group\">\r\n                    <a class=\"btn btn-info\" href=\"client/create\"><span class=\"ri oi oi-plus\"></span> New client</a>\r\n                </div>\r\n\r\n                ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "form-row p-1");
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "form-group m-1");
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.AddMarkupContent(20, "<label>Display </label>\r\n                        ");
            __builder.OpenElement(21, "select");
            __builder.AddAttribute(22, "class", "custom-select-sm");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Client\ClientIndex.razor"
                                                                                           LoadPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Client\ClientIndex.razor"
                                                                 recordsPerPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => recordsPerPage = __value, recordsPerPage));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(26, "\r\n                            ");
            __builder.OpenElement(27, "option");
            __builder.AddAttribute(28, "value", true);
            __builder.AddContent(29, "5");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                            ");
            __builder.OpenElement(31, "option");
            __builder.AddContent(32, "10");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                            ");
            __builder.OpenElement(34, "option");
            __builder.AddContent(35, "15");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                            ");
            __builder.OpenElement(37, "option");
            __builder.AddContent(38, "20");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                        ");
            __builder.AddMarkupContent(41, "<label> clients</label>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n\r\n\r\n                ");
            __Blazor.DocumentationTool.Client.Pages.Client.ClientIndex.TypeInference.CreateGenericList_0(__builder, 44, 45, 
#nullable restore
#line 33 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Client\ClientIndex.razor"
                                   Clients

#line default
#line hidden
#nullable disable
            , 46, (__builder2) => {
                __builder2.AddMarkupContent(47, "\r\n                        ");
                __builder2.OpenElement(48, "table");
                __builder2.AddAttribute(49, "class", "table");
                __builder2.AddMarkupContent(50, "\r\n                            ");
                __builder2.AddMarkupContent(51, @"<thead class=""thead-light"">
                                <tr>
                                    <th>Title</th>
                                    <th>Dekstop type</th>
                                    <th>Purpose</th>
                                    <th>Action</th>
                                </tr>
                            </thead>
                            ");
                __builder2.OpenElement(52, "tbody");
                __builder2.AddMarkupContent(53, "\r\n");
#nullable restore
#line 45 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Client\ClientIndex.razor"
                                 foreach (var item in Clients)
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(54, "                                    ");
                __builder2.OpenElement(55, "tr");
                __builder2.AddMarkupContent(56, "\r\n                                        ");
                __builder2.OpenElement(57, "td");
                __builder2.AddContent(58, 
#nullable restore
#line 48 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Client\ClientIndex.razor"
                                             item.General.Title

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                                        ");
                __builder2.OpenElement(60, "td");
                __builder2.AddContent(61, 
#nullable restore
#line 49 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Client\ClientIndex.razor"
                                             item.Desktop.Type

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n                                        ");
                __builder2.OpenElement(63, "td");
                __builder2.AddContent(64, 
#nullable restore
#line 50 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Client\ClientIndex.razor"
                                             item.General.Purpose

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n                                        ");
                __builder2.OpenElement(66, "td");
                __builder2.AddMarkupContent(67, "\r\n                                            ");
                __builder2.OpenElement(68, "a");
                __builder2.AddAttribute(69, "href", "/client/detail/" + (
#nullable restore
#line 52 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Client\ClientIndex.razor"
                                                                     item.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(70, "<span class=\"oi oi-eye\"></span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n                                            ");
                __builder2.OpenElement(72, "a");
                __builder2.AddAttribute(73, "href", "/client/edit/" + (
#nullable restore
#line 53 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Client\ClientIndex.razor"
                                                                   item.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(74, "<span class=\"oi oi-pencil\"></span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n                                            ");
                __builder2.OpenElement(76, "a");
                __builder2.AddAttribute(77, "href", "/client");
                __builder2.AddAttribute(78, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Client\ClientIndex.razor"
                                                                          () => DeleteDevice(item.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(79, "<span class=\"oi oi-trash\"></span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n");
#nullable restore
#line 57 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Client\ClientIndex.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(83, "                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n                    ");
            }
            );
            __builder.AddMarkupContent(86, "\r\n                ");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "class", "row");
            __builder.AddMarkupContent(89, "\r\n                    ");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "col-12");
            __builder.AddMarkupContent(92, "\r\n                        ");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "d-flex");
            __builder.AddMarkupContent(95, "\r\n                            ");
            __builder.OpenElement(96, "div");
            __builder.AddAttribute(97, "class", "ml-auto");
            __builder.AddMarkupContent(98, "\r\n                                ");
            __builder.OpenComponent<DocumentationTool.Client.Shared.Pagination>(99);
            __builder.AddAttribute(100, "CurrentPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 66 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Client\ClientIndex.razor"
                                                          paginationDTO.Page

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(101, "TotalAmountPages", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 66 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Client\ClientIndex.razor"
                                                                                                totalAmountPages

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(102, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 67 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Client\ClientIndex.razor"
                                                          SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(103, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Client\ClientIndex.razor"
       
    List<ClientPC> Clients;
    PaginationDTO paginationDTO = new PaginationDTO();
    private int totalAmountPages;
    private int recordsPerPage = 5;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            await LoadClients();
        }
        catch (Exception ex)
        {

        }
    }

    private async Task LoadPage()
    {
        paginationDTO = new PaginationDTO();
        await LoadClients();
    }

    private async Task LoadClients()
    {
        paginationDTO.RecordsPerPage = recordsPerPage;
        var paginatedResponse = await clientRepository.GetClientPCs(paginationDTO);
        Clients = paginatedResponse.Response;
        totalAmountPages = paginatedResponse.TotalAmountPages;
    }

    private async Task SelectedPage(int page)
    {
        paginationDTO.Page = page;
        await LoadClients();
    }

    private async Task DeleteDevice(int id)
    {
        await clientRepository.DeleteClientPC(id);
        await LoadClients();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClientRepository clientRepository { get; set; }
    }
}
namespace __Blazor.DocumentationTool.Client.Pages.Client.ClientIndex
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
