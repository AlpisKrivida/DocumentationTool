#pragma checksum "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "075fa31b8a8b878128e319108685c6b61665e601"
// <auto-generated/>
#pragma warning disable 1591
namespace DocumentationTool.Client.Pages.Contacts
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
    public partial class ContactModal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal" + " " + (
#nullable restore
#line 3 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactModal.razor"
                   ModalClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "tabindex", "-1");
            __builder.AddAttribute(3, "role", "dialog");
            __builder.AddAttribute(4, "style", "display:" + (
#nullable restore
#line 3 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactModal.razor"
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
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.AddMarkupContent(16, "<h5 class=\"modal-title\">People</h5>\r\n                ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "type", "button");
            __builder.AddAttribute(19, "class", "close");
            __builder.AddAttribute(20, "data-dismiss", "modal");
            __builder.AddAttribute(21, "aria-label", "Close");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactModal.razor"
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
            __builder.AddMarkupContent(48, "<label>Display </label>\r\n                                        ");
            __builder.OpenElement(49, "select");
            __builder.AddAttribute(50, "class", "custom-select-sm");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactModal.razor"
                                                                                                           LoadPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactModal.razor"
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
            __builder.AddMarkupContent(68, "\r\n                                            ");
            __builder.AddMarkupContent(69, "<label> people</label>\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                                    ");
            __Blazor.DocumentationTool.Client.Pages.Contacts.ContactModal.TypeInference.CreateGenericList_0(__builder, 72, 73, 
#nullable restore
#line 29 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactModal.razor"
                                                       Checklist

#line default
#line hidden
#nullable disable
            , 74, (__builder2) => {
                __builder2.AddMarkupContent(75, "\r\n                                            ");
                __builder2.OpenElement(76, "table");
                __builder2.AddAttribute(77, "class", "table");
                __builder2.AddMarkupContent(78, "\r\n                                                ");
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
#line 43 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactModal.razor"
                                                     foreach (var item in Checklist)
                                                    {
                                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactModal.razor"
                                                         if (item.Person != null)
                                                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(82, "                                                            ");
                __builder2.OpenElement(83, "tr");
                __builder2.AddMarkupContent(84, "\r\n                                                                ");
                __builder2.OpenElement(85, "th");
                __builder2.AddMarkupContent(86, "\r\n                                                                    ");
                __builder2.OpenElement(87, "input");
                __builder2.AddAttribute(88, "type", "checkbox");
                __builder2.AddAttribute(89, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 49 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactModal.razor"
                                                                                                      (e) => { CheckBox(item.Person, e.Value); }

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n                                                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n                                                                ");
                __builder2.OpenElement(92, "td");
                __builder2.AddContent(93, 
#nullable restore
#line 51 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactModal.razor"
                                                                     item.Person.General.Title

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n                                                                ");
                __builder2.AddMarkupContent(95, "<td> </td>\r\n                                                                ");
                __builder2.AddMarkupContent(96, "<td> </td>\r\n                                                                ");
                __builder2.OpenElement(97, "td");
                __builder2.AddMarkupContent(98, "\r\n                                                                    ");
                __builder2.OpenElement(99, "a");
                __builder2.AddAttribute(100, "href", "/router/detail/" + (
#nullable restore
#line 55 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactModal.razor"
                                                                                             item.Person.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(101, "<span class=\"oi oi-eye\"></span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n                                                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n                                                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n");
#nullable restore
#line 58 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactModal.razor"
                                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactModal.razor"
                                                         
                                                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(105, "                                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(106, "\r\n                                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\r\n                                        ");
            }
            );
            __builder.AddMarkupContent(108, "\r\n                                ");
            __builder.OpenElement(109, "div");
            __builder.AddAttribute(110, "class", "row");
            __builder.AddMarkupContent(111, "\r\n                                    ");
            __builder.OpenElement(112, "div");
            __builder.AddAttribute(113, "class", "col-12");
            __builder.AddMarkupContent(114, "\r\n                                        ");
            __builder.OpenElement(115, "div");
            __builder.AddAttribute(116, "class", "d-flex");
            __builder.AddMarkupContent(117, "\r\n                                            ");
            __builder.OpenElement(118, "div");
            __builder.AddAttribute(119, "class", "ml-auto");
            __builder.AddMarkupContent(120, "\r\n                                                ");
            __builder.OpenComponent<DocumentationTool.Client.Shared.Pagination>(121);
            __builder.AddAttribute(122, "CurrentPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 68 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactModal.razor"
                                                                          paginationDTO.Page

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(123, "TotalAmountPages", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 68 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactModal.razor"
                                                                                                                totalAmountPages

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(124, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 69 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactModal.razor"
                                                                          SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(125, "\r\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n            ");
            __builder.OpenElement(135, "div");
            __builder.AddAttribute(136, "class", "modal-footer");
            __builder.AddMarkupContent(137, "\r\n                ");
            __builder.OpenElement(138, "button");
            __builder.AddAttribute(139, "type", "button");
            __builder.AddAttribute(140, "class", "btn btn-primary");
            __builder.AddAttribute(141, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 80 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactModal.razor"
                                                                        () => Save()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(142, "Save changes");
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n                ");
            __builder.OpenElement(144, "button");
            __builder.AddAttribute(145, "type", "button");
            __builder.AddAttribute(146, "class", "btn btn-secondary");
            __builder.AddAttribute(147, "data-dismiss", "modal");
            __builder.AddAttribute(148, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 81 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactModal.razor"
                                                                                               () => Close()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(149, "Close");
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n\r\n\r\n");
#nullable restore
#line 88 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactModal.razor"
 if (ShowBackdrop)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(155, "    <div class=\"modal-backdrop fade show\"></div>\r\n");
#nullable restore
#line 91 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactModal.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 94 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactModal.razor"
       
    //Modal
    public Guid Guid = Guid.NewGuid();
    public string ModalDisplay = "none;";
    public string ModalClass = "";
    public bool ShowBackdrop = false;

    private List<PersonModal> Checklist = new List<PersonModal>();
    PaginationDTO paginationDTO = new PaginationDTO();
    private int totalAmountPages;
    private int recordsPerPage = 5;


    public List<Person> People;

    [Parameter] public ServerDevice serverDevice { get; set; }
    [Parameter] public EventCallback<List<Person>> saved { get; set; }

    public async Task Open()
    {

        ModalDisplay = "block;";
        ModalClass = "Show";
        ShowBackdrop = true;
        StateHasChanged();
        await LoadData();
        await LoadPage();
    }

    public void Close()
    {
        ModalDisplay = "none";
        ModalClass = "";
        ShowBackdrop = false;
        StateHasChanged();
    }

    public void Save()
    {
        ModalDisplay = "none";
        ModalClass = "";
        ShowBackdrop = false;
        saved.InvokeAsync(People);
        StateHasChanged();
    }

    private void CheckBox(Person item, object checkedValue)
    {
        if ((bool)checkedValue)
        {
            if (!People.Contains(item))
            {
                People.Add(item);
            }
        }
        else
        {
            if (People.Contains(item))
            {
                People.Remove(item);
            }
        }
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
        Checklist = new List<PersonModal>();


        paginationDTO.RecordsPerPage = recordsPerPage;
        var paginatedResponse = await personRepository.GetPeople(paginationDTO);
        People = paginatedResponse.Response.Where(x => x.ServerId != serverDevice.Id).ToList();
        totalAmountPages = paginatedResponse.TotalAmountPages;

        foreach (var item in People)
        {
            Checklist.Add(new PersonModal { IsActive = false, Person = item });
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPersonRepostiroy personRepository { get; set; }
    }
}
namespace __Blazor.DocumentationTool.Client.Pages.Contacts.ContactModal
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
