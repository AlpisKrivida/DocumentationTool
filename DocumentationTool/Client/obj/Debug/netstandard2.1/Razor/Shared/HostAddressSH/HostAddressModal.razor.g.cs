#pragma checksum "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f2026c1f80a9779692e79d2794920267797288a"
// <auto-generated/>
#pragma warning disable 1591
namespace DocumentationTool.Client.Shared.HostAddressSH
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
    public partial class HostAddressModal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal" + " " + (
#nullable restore
#line 3 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressModal.razor"
                   ModalClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "tabindex", "-1");
            __builder.AddAttribute(3, "role", "dialog");
            __builder.AddAttribute(4, "style", "display:" + (
#nullable restore
#line 3 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressModal.razor"
                                                                           ModalDisplay

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "modal-dialog");
            __builder.AddAttribute(8, "role", "document");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-content");
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "modal-header");
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.AddMarkupContent(16, "<h5 class=\"modal-title\">Network</h5>\r\n                ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "type", "button");
            __builder.AddAttribute(19, "class", "close");
            __builder.AddAttribute(20, "data-dismiss", "modal");
            __builder.AddAttribute(21, "aria-label", "Close");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressModal.razor"
                                                                                                      () => Close()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.AddMarkupContent(24, "<span aria-hidden=\"true\">&times;</span>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "modal-body");
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "container-fluid");
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "row");
            __builder.AddMarkupContent(35, "\r\n                        ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "col-12");
            __builder.AddMarkupContent(38, "\r\n                            ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "card");
            __builder.AddMarkupContent(41, "\r\n                                ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "form-row p-1");
            __builder.AddMarkupContent(44, "\r\n                                    ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "form-group m-1");
            __builder.AddMarkupContent(47, "\r\n                                        ");
            __builder.AddMarkupContent(48, "<label>Network </label>\r\n                                        ");
            __builder.OpenElement(49, "select");
            __builder.AddAttribute(50, "class", "custom-select-sm");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressModal.razor"
                                                                                                           LoadPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressModal.razor"
                                                                                 recordsPerPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => recordsPerPage = __value, recordsPerPage));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(54, "\r\n                                            ");
            __builder.OpenElement(55, "option");
            __builder.AddAttribute(56, "value", true);
            __builder.AddContent(57, "5");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                                            ");
            __builder.OpenElement(59, "option");
            __builder.AddContent(60, "10");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                                            ");
            __builder.OpenElement(62, "option");
            __builder.AddContent(63, "15");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                                            ");
            __builder.OpenElement(65, "option");
            __builder.AddContent(66, "20");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                                        ");
            __builder.AddMarkupContent(69, "<label> cables</label>\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n\r\n\r\n                                ");
            __Blazor.DocumentationTool.Client.Shared.HostAddressSH.HostAddressModal.TypeInference.CreateGenericList_0(__builder, 72, 73, 
#nullable restore
#line 31 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressModal.razor"
                                                   CableChecklist

#line default
#line hidden
#nullable disable
            , 74, (__builder2) => {
                __builder2.AddMarkupContent(75, "\r\n                                        ");
                __builder2.OpenElement(76, "table");
                __builder2.AddAttribute(77, "class", "table");
                __builder2.AddMarkupContent(78, "\r\n                                            ");
                __builder2.AddMarkupContent(79, @"<thead class=""thead-light"">
                                                <tr>
                                                    <th>
                                                    </th>
                                                    <th>Title</th>
                                                    <th>Type</th>
                                                    <th>Cable lenght</th>
                                                    <th>Action</th>
                                                </tr>
                                            </thead>
                                            ");
                __builder2.OpenElement(80, "tbody");
                __builder2.AddMarkupContent(81, "\r\n");
#nullable restore
#line 45 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressModal.razor"
                                                 foreach (var item in CableChecklist)
                                                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(82, "                                                    ");
                __builder2.OpenElement(83, "tr");
                __builder2.AddMarkupContent(84, "\r\n                                                        ");
                __builder2.OpenElement(85, "th");
                __builder2.AddMarkupContent(86, "\r\n                                                            ");
                __builder2.OpenElement(87, "input");
                __builder2.AddAttribute(88, "disabled", 
#nullable restore
#line 49 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressModal.razor"
                                                                              isDisabled

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(89, "type", "checkbox");
                __builder2.AddAttribute(90, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressModal.razor"
                                                                                                                                          () => CheckBox(item)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(91, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 49 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressModal.razor"
                                                                                                                 item.IsActive

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(92, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => item.IsActive = __value, item.IsActive));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n                                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n                                                        ");
                __builder2.OpenElement(95, "td");
                __builder2.AddContent(96, 
#nullable restore
#line 52 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressModal.razor"
                                                             item.LayerThreeNet.General.Title

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\r\n                                                        ");
                __builder2.OpenElement(98, "td");
                __builder2.AddContent(99, 
#nullable restore
#line 53 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressModal.razor"
                                                             item.LayerThreeNet.NetMask

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\r\n                                                        ");
                __builder2.OpenElement(101, "td");
                __builder2.AddContent(102, 
#nullable restore
#line 54 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressModal.razor"
                                                             item.LayerThreeNet.Prefix

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n                                                        ");
                __builder2.OpenElement(104, "td");
                __builder2.AddMarkupContent(105, "\r\n                                                            ");
                __builder2.OpenElement(106, "a");
                __builder2.AddAttribute(107, "href", "/cable/detail/" + (
#nullable restore
#line 56 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressModal.razor"
                                                                                    item.LayerThreeNet.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(108, "<span class=\"oi oi-eye\"></span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\r\n                                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\r\n                                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(111, "\r\n");
#nullable restore
#line 59 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressModal.razor"
                                                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(112, "                                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(113, "\r\n                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\r\n                                    ");
            }
            );
            __builder.AddMarkupContent(115, "\r\n                                ");
            __builder.OpenElement(116, "div");
            __builder.AddAttribute(117, "class", "row");
            __builder.AddMarkupContent(118, "\r\n                                    ");
            __builder.OpenElement(119, "div");
            __builder.AddAttribute(120, "class", "col-12");
            __builder.AddMarkupContent(121, "\r\n                                        ");
            __builder.OpenElement(122, "div");
            __builder.AddAttribute(123, "class", "d-flex");
            __builder.AddMarkupContent(124, "\r\n                                            ");
            __builder.OpenElement(125, "div");
            __builder.AddAttribute(126, "class", "ml-auto");
            __builder.AddMarkupContent(127, "\r\n                                                ");
            __builder.OpenComponent<DocumentationTool.Client.Shared.Pagination>(128);
            __builder.AddAttribute(129, "CurrentPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 68 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressModal.razor"
                                                                          paginationDTO.Page

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(130, "TotalAmountPages", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 68 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressModal.razor"
                                                                                                                totalAmountPages

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(131, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 69 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressModal.razor"
                                                                          SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(132, "\r\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n            ");
            __builder.OpenElement(142, "div");
            __builder.AddAttribute(143, "class", "modal-footer");
            __builder.AddMarkupContent(144, "\r\n                ");
            __builder.OpenElement(145, "button");
            __builder.AddAttribute(146, "type", "button");
            __builder.AddAttribute(147, "class", "btn btn-primary");
            __builder.AddAttribute(148, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 80 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressModal.razor"
                                                                        () => Close()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(149, "Save changes");
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n                ");
            __builder.OpenElement(151, "button");
            __builder.AddAttribute(152, "type", "button");
            __builder.AddAttribute(153, "class", "btn btn-secondary");
            __builder.AddAttribute(154, "data-dismiss", "modal");
            __builder.AddAttribute(155, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 81 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressModal.razor"
                                                                                               () => ChangeDisabled()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(156, "Remove checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(157, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(158, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(160, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(161, "\r\n\r\n\r\n");
#nullable restore
#line 88 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressModal.razor"
 if (ShowBackdrop)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(162, "    <div class=\"modal-backdrop fade show\"></div>\r\n");
#nullable restore
#line 91 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressModal.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 94 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressModal.razor"
       

    public Guid Guid = Guid.NewGuid();
    public string ModalDisplay = "none;";
    public string ModalClass = "";
    public bool ShowBackdrop = false;

    List<LayerThreeNet> LayerThreeNets;
    PaginationDTO paginationDTO = new PaginationDTO();
    private int totalAmountPages;
    private int recordsPerPage = 5;
    private int currentCheckbox = 0;

    private bool isDisabled { get; set; } = false;

    private List<NetworkModal> CableChecklist = new List<NetworkModal>();

    [Parameter] public LayerThreeNet SelectedCable { get; set; }
    [Parameter] public EventCallback<LayerThreeNet> saved { get; set; }

    public void Open()
    {
        ModalDisplay = "block;";
        ModalClass = "Show";
        ShowBackdrop = true;
        StateHasChanged();
    }

    public void Close()
    {
        ModalDisplay = "none";
        ModalClass = "";
        ShowBackdrop = false;
        saved.InvokeAsync(SelectedCable);
        StateHasChanged();
    }

    private void CheckBox(NetworkModal item)
    {
        item.IsActive = !item.IsActive;
        isDisabled = true;
        SelectedCable = item.LayerThreeNet;
        Console.WriteLine(SelectedCable.General.Title);
    }

    private void ChangeDisabled()
    {
        foreach (var item in CableChecklist)
            item.IsActive = false;

        //SelectedCable = new Cable();
        isDisabled = false;
    }

    protected override async Task OnInitializedAsync()
    {
        try
        {
            await LoadCables();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }

    private async Task LoadPage()
    {
        paginationDTO = new PaginationDTO();
        await LoadCables();
    }

    private async Task LoadCables()
    {
        paginationDTO.RecordsPerPage = recordsPerPage;
        var paginatedResponse = await networkRepository.GetLayerThreeNet(paginationDTO);
        LayerThreeNets = paginatedResponse.Response;
        totalAmountPages = paginatedResponse.TotalAmountPages;

        CableChecklist = new List<NetworkModal>();
        foreach (var item in LayerThreeNets)
        {
            CableChecklist.Add(new NetworkModal { IsActive = false, LayerThreeNet = item });
        }
    }

    private async Task SelectedPage(int page)
    {
        paginationDTO.Page = page;
        await LoadCables();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INetworkRepository networkRepository { get; set; }
    }
}
namespace __Blazor.DocumentationTool.Client.Shared.HostAddressSH.HostAddressModal
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