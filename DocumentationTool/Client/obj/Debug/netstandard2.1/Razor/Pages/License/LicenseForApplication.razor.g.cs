#pragma checksum "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\License\LicenseForApplication.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be2e0af30a14ddef30491085bfe07dc10acef947"
// <auto-generated/>
#pragma warning disable 1591
namespace DocumentationTool.Client.Pages.License
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
    public partial class LicenseForApplication : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid pt-4");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<div class=\"row\">\r\n        <div class=\"col-12\">\r\n            <h3>Licenses</h3>\r\n        </div>\r\n    </div>\r\n\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-12");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "form-group");
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "a");
            __builder.AddAttribute(17, "class", "btn btn-info");
            __builder.AddAttribute(18, "href", "license/create/" + (
#nullable restore
#line 14 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\License\LicenseForApplication.razor"
                                                                  ApplicationId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(19, "<span class=\"ri oi oi-plus\"></span> New License");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n                ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "form-row p-1");
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "form-group m-1");
            __builder.AddMarkupContent(27, "\r\n                        ");
            __builder.AddMarkupContent(28, "<label>Display </label>\r\n                        ");
            __builder.OpenElement(29, "select");
            __builder.AddAttribute(30, "class", "custom-select-sm");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\License\LicenseForApplication.razor"
                                                                                           LoadPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\License\LicenseForApplication.razor"
                                                                 recordsPerPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => recordsPerPage = __value, recordsPerPage));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(34, "\r\n                            ");
            __builder.OpenElement(35, "option");
            __builder.AddAttribute(36, "value", true);
            __builder.AddContent(37, "5");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                            ");
            __builder.OpenElement(39, "option");
            __builder.AddContent(40, "10");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                            ");
            __builder.OpenElement(42, "option");
            __builder.AddContent(43, "15");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                            ");
            __builder.OpenElement(45, "option");
            __builder.AddContent(46, "20");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                        ");
            __builder.AddMarkupContent(49, "<label> licenses</label>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n\r\n\r\n                ");
            __Blazor.DocumentationTool.Client.Pages.License.LicenseForApplication.TypeInference.CreateGenericList_0(__builder, 52, 53, 
#nullable restore
#line 31 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\License\LicenseForApplication.razor"
                                   License

#line default
#line hidden
#nullable disable
            , 54, (__builder2) => {
                __builder2.AddMarkupContent(55, "\r\n                        ");
                __builder2.OpenElement(56, "table");
                __builder2.AddAttribute(57, "class", "table");
                __builder2.AddMarkupContent(58, "\r\n                            ");
                __builder2.AddMarkupContent(59, @"<thead class=""thead-light"">
                                <tr>
                                    <th>Key</th>
                                    <th>Expire date</th>
                                    <th>Total price</th>
                                    <th>Action</th>
                                </tr>
                            </thead>
                            ");
                __builder2.OpenElement(60, "tbody");
                __builder2.AddMarkupContent(61, "\r\n");
#nullable restore
#line 43 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\License\LicenseForApplication.razor"
                                 foreach (var item in License)
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(62, "                                    ");
                __builder2.OpenElement(63, "tr");
                __builder2.AddMarkupContent(64, "\r\n                                        ");
                __builder2.OpenElement(65, "td");
                __builder2.AddContent(66, 
#nullable restore
#line 46 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\License\LicenseForApplication.razor"
                                             item.Key

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n                                        ");
                __builder2.OpenElement(68, "td");
                __builder2.AddContent(69, 
#nullable restore
#line 47 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\License\LicenseForApplication.razor"
                                             item.ExpireDate

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n                                        ");
                __builder2.OpenElement(71, "td");
                __builder2.AddContent(72, 
#nullable restore
#line 48 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\License\LicenseForApplication.razor"
                                             CountPrice(@item.Amount, @item.PricePerUnit)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n                                        ");
                __builder2.OpenElement(74, "td");
                __builder2.AddMarkupContent(75, "\r\n                                            ");
                __builder2.OpenElement(76, "a");
                __builder2.AddAttribute(77, "href", "/license/detail/" + (
#nullable restore
#line 50 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\License\LicenseForApplication.razor"
                                                                      item.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(78, "<span class=\"oi oi-eye\"></span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n                                            ");
                __builder2.OpenElement(80, "a");
                __builder2.AddAttribute(81, "href", "/license/edit/" + (
#nullable restore
#line 51 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\License\LicenseForApplication.razor"
                                                                    item.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(82, "<span class=\"oi oi-pencil\"></span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n                                            ");
                __builder2.OpenElement(84, "a");
                __builder2.AddAttribute(85, "href", "/license/delete/" + (
#nullable restore
#line 52 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\License\LicenseForApplication.razor"
                                                                      item.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(86, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\License\LicenseForApplication.razor"
                                                                                           () => DeleteLicense(item.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(87, "<span class=\"oi oi-trash\"></span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n");
#nullable restore
#line 55 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\License\LicenseForApplication.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(91, "                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n                    ");
            }
            );
            __builder.AddMarkupContent(94, "\r\n                ");
            __builder.OpenElement(95, "div");
            __builder.AddAttribute(96, "class", "row");
            __builder.AddMarkupContent(97, "\r\n                    ");
            __builder.OpenElement(98, "div");
            __builder.AddAttribute(99, "class", "col-12");
            __builder.AddMarkupContent(100, "\r\n                        ");
            __builder.OpenElement(101, "div");
            __builder.AddAttribute(102, "class", "d-flex");
            __builder.AddMarkupContent(103, "\r\n                            ");
            __builder.OpenElement(104, "div");
            __builder.AddAttribute(105, "class", "ml-auto");
            __builder.AddMarkupContent(106, "\r\n                                ");
            __builder.OpenComponent<DocumentationTool.Client.Shared.Pagination>(107);
            __builder.AddAttribute(108, "CurrentPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 64 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\License\LicenseForApplication.razor"
                                                          paginationDTO.Page

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(109, "TotalAmountPages", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 64 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\License\LicenseForApplication.razor"
                                                                                                totalAmountPages

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(110, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 65 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\License\LicenseForApplication.razor"
                                                          SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(111, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\License\LicenseForApplication.razor"
       
    [Parameter]
    public int ApplicationId { get; set; }

    List<LicenseKey> License;
    PaginationDTO paginationDTO = new PaginationDTO();
    private int totalAmountPages;
    private int recordsPerPage = 5;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            await LoadLicense();
        }
        catch (Exception ex)
        {

        }
    }

    private double CountPrice(int amount, double price) => price * amount;

    private async Task LoadPage()
    {
        paginationDTO = new PaginationDTO();
        await LoadLicense();
    }

    private async Task LoadLicense()
    {
        paginationDTO.RecordsPerPage = recordsPerPage;
        var paginatedResponse = await licenseRepository.GetLicenseKey(paginationDTO);
        License = paginatedResponse.Response
            .Where(x => x.ApplicationId == ApplicationId).ToList();
        totalAmountPages = paginatedResponse.TotalAmountPages;
    }

    private async Task SelectedPage(int page)
    {
        paginationDTO.Page = page;
        await LoadLicense();
    }

    private async Task DeleteLicense(int id)
    {
        await licenseRepository.DeleteLicenseKey(id);
        await LoadLicense();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILicenseRepository licenseRepository { get; set; }
    }
}
namespace __Blazor.DocumentationTool.Client.Pages.License.LicenseForApplication
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
