#pragma checksum "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\PortDevices\PortModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcd4cfc9e0d2d07030535f269657d8b0e7fe51a7"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class PortModal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal" + " " + (
#nullable restore
#line 3 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\PortDevices\PortModal.razor"
                   ModalClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "tabindex", "-1");
            __builder.AddAttribute(3, "role", "dialog");
            __builder.AddAttribute(4, "style", "display:" + (
#nullable restore
#line 3 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\PortDevices\PortModal.razor"
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
            __builder.AddMarkupContent(13, @"<div class=""modal-header"">
                <h5 class=""modal-title"">Cables</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "modal-body");
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "container-fluid");
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "row");
            __builder.AddMarkupContent(22, "\r\n                        ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "col-12");
            __builder.AddMarkupContent(25, "\r\n                            ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "card");
            __builder.AddMarkupContent(28, "\r\n\r\n\r\n                                ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "form-row p-1");
            __builder.AddMarkupContent(31, "\r\n                                    ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "form-group m-1");
            __builder.AddMarkupContent(34, "\r\n                                        ");
            __builder.AddMarkupContent(35, "<label>Display </label>\r\n                                        ");
            __builder.OpenElement(36, "select");
            __builder.AddAttribute(37, "class", "custom-select-sm");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\PortDevices\PortModal.razor"
                                                                                                           LoadPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\PortDevices\PortModal.razor"
                                                                                 recordsPerPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => recordsPerPage = __value, recordsPerPage));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(41, "\r\n                                            ");
            __builder.OpenElement(42, "option");
            __builder.AddAttribute(43, "value", true);
            __builder.AddContent(44, "5");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                                            ");
            __builder.OpenElement(46, "option");
            __builder.AddContent(47, "10");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                                            ");
            __builder.OpenElement(49, "option");
            __builder.AddContent(50, "15");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                                            ");
            __builder.OpenElement(52, "option");
            __builder.AddContent(53, "20");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                                        ");
            __builder.AddMarkupContent(56, "<label> cables</label>\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n\r\n\r\n                                ");
            __Blazor.DocumentationTool.Client.Pages.PortDevices.PortModal.TypeInference.CreateGenericList_0(__builder, 59, 60, 
#nullable restore
#line 36 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\PortDevices\PortModal.razor"
                                                   Cables

#line default
#line hidden
#nullable disable
            , 61, (__builder2) => {
                __builder2.AddMarkupContent(62, "\r\n                                        ");
                __builder2.OpenElement(63, "table");
                __builder2.AddAttribute(64, "class", "table");
                __builder2.AddMarkupContent(65, "\r\n                                            ");
                __builder2.AddMarkupContent(66, @"<thead class=""thead-light"">
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
                __builder2.OpenElement(67, "tbody");
                __builder2.AddMarkupContent(68, "\r\n");
#nullable restore
#line 50 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\PortDevices\PortModal.razor"
                                                 foreach (var item in Cables)
                                                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(69, "                                                    ");
                __builder2.OpenElement(70, "tr");
                __builder2.AddMarkupContent(71, "\r\n                                                        ");
                __builder2.OpenElement(72, "th");
                __builder2.AddMarkupContent(73, "\r\n                                                            ");
                __builder2.OpenElement(74, "input");
                __builder2.AddAttribute(75, "type", "checkbox");
                __builder2.AddAttribute(76, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 54 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\PortDevices\PortModal.razor"
                                                                                              (e) => CheckboxClicked(e.Value, item)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n                                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n                                                        ");
                __builder2.OpenElement(79, "td");
                __builder2.AddContent(80, 
#nullable restore
#line 56 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\PortDevices\PortModal.razor"
                                                             item.General.Title

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n                                                        ");
                __builder2.OpenElement(82, "td");
                __builder2.AddContent(83, 
#nullable restore
#line 57 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\PortDevices\PortModal.razor"
                                                             item.CableType

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n                                                        ");
                __builder2.OpenElement(85, "td");
                __builder2.AddContent(86, 
#nullable restore
#line 58 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\PortDevices\PortModal.razor"
                                                             item.CableLenght

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n                                                        ");
                __builder2.OpenElement(88, "td");
                __builder2.AddMarkupContent(89, "\r\n                                                            ");
                __builder2.OpenElement(90, "a");
                __builder2.AddAttribute(91, "href", "/cable/detail/" + (
#nullable restore
#line 60 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\PortDevices\PortModal.razor"
                                                                                    item.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(92, "<span class=\"oi oi-eye\"></span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n                                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n                                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n");
#nullable restore
#line 65 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\PortDevices\PortModal.razor"
                                                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(96, "                                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\r\n                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n                                    ");
            }
            );
            __builder.AddMarkupContent(99, "\r\n                                ");
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "class", "row");
            __builder.AddMarkupContent(102, "\r\n                                    ");
            __builder.OpenElement(103, "div");
            __builder.AddAttribute(104, "class", "col-12");
            __builder.AddMarkupContent(105, "\r\n                                        ");
            __builder.OpenElement(106, "div");
            __builder.AddAttribute(107, "class", "d-flex");
            __builder.AddMarkupContent(108, "\r\n                                            ");
            __builder.OpenElement(109, "div");
            __builder.AddAttribute(110, "class", "ml-auto");
            __builder.AddMarkupContent(111, "\r\n                                                ");
            __builder.OpenComponent<DocumentationTool.Client.Shared.Pagination>(112);
            __builder.AddAttribute(113, "CurrentPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 74 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\PortDevices\PortModal.razor"
                                                                          paginationDTO.Page

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(114, "TotalAmountPages", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 74 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\PortDevices\PortModal.razor"
                                                                                                                totalAmountPages

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(115, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 75 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\PortDevices\PortModal.razor"
                                                                          SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(116, "\r\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n            ");
            __builder.OpenElement(126, "div");
            __builder.AddAttribute(127, "class", "modal-footer");
            __builder.AddMarkupContent(128, "\r\n                ");
            __builder.AddMarkupContent(129, "<button type=\"button\" class=\"btn btn-primary\">Save changes</button>\r\n                ");
            __builder.OpenElement(130, "button");
            __builder.AddAttribute(131, "type", "button");
            __builder.AddAttribute(132, "class", "btn btn-secondary");
            __builder.AddAttribute(133, "data-dismiss", "modal");
            __builder.AddAttribute(134, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 87 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\PortDevices\PortModal.razor"
                                                                                               () => Close()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(135, "Close");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n\r\n\r\n");
#nullable restore
#line 94 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\PortDevices\PortModal.razor"
 if (ShowBackdrop)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(141, "    <div class=\"modal-backdrop fade show\"></div>\r\n");
#nullable restore
#line 97 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\PortDevices\PortModal.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 100 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\PortDevices\PortModal.razor"
       

    public Guid Guid = Guid.NewGuid();
    public string ModalDisplay = "none;";
    public string ModalClass = "";
    public bool ShowBackdrop = false;
    List<Cable> Cables;
    List<bool> CheckBox;
    PaginationDTO paginationDTO = new PaginationDTO();
    private int totalAmountPages;
    private int recordsPerPage = 5;
    private int currentCheckbox = 0;

    [Parameter] public List<Cable> SelectedCables { get; set; }

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
        StateHasChanged();
    }

    private void CheckboxClicked(object e, Cable cable)
    {
        if((bool)e)
        {
            SelectedCables.Add(cable);
        }
        else
        {
            SelectedCables.Remove(cable);
        }
        Console.WriteLine(SelectedCables.Count());
    }

    private bool GetCheckBoxValue()
    {
        CheckBox.Add(false);

        return CheckBox.ElementAt(currentCheckbox);
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
        var paginatedResponse = await cableRepository.GetCables(paginationDTO);
        Cables = paginatedResponse.Response;
        totalAmountPages = paginatedResponse.TotalAmountPages;
    }

    private async Task SelectedPage(int page)
    {
        paginationDTO.Page = page;
        await LoadCables();
    }

    private async Task DeleteCable(int id)
    {
        await cableRepository.DeleteCable(id);
        await LoadCables();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICableRepository cableRepository { get; set; }
    }
}
namespace __Blazor.DocumentationTool.Client.Pages.PortDevices.PortModal
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
