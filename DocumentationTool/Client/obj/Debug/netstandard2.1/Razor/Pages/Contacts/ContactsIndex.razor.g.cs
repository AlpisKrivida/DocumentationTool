#pragma checksum "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactsIndex.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae5164be2a387f3e4ca42cbdcd6b6b38b29a7274"
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
#line 4 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactsIndex.razor"
using Blazor.FileReader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactsIndex.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/contact")]
    public partial class ContactsIndex : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<div class=\"row\">\r\n        <div class=\"col-12\">\r\n            <h3>Contacts</h3>\r\n        </div>\r\n    </div>\r\n\r\n    ");
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
            __builder.AddAttribute(14, "class", "form-group row");
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.AddMarkupContent(16, "<div class=\"col\">\r\n                        <a class=\"btn btn-info\" href=\"contact/create\"><span class=\"ri oi oi-plus\"></span> New contact</a>\r\n                    </div>\r\n                    ");
            __builder.AddMarkupContent(17, "<div class=\"col-8\">\r\n\r\n                    </div>\r\n                    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "col align-self-lg-end");
            __builder.AddMarkupContent(20, "\r\n                        ");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "class", "btn btn-primary");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactsIndex.razor"
                                                                  GenerateExcel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(24, "Export");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                        ");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "class", "btn btn-primary");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactsIndex.razor"
                                                                  Show

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(29, "Import");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n");
#nullable restore
#line 31 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactsIndex.razor"
                 if (showImport)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(33, "                    ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "btn btn-success text-left");
            __builder.AddMarkupContent(36, "\r\n                        ");
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "type", "file");
            __builder.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 34 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactsIndex.razor"
                                                                            async () => await OpenFileAsync()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddElementReferenceCapture(40, (__value) => {
#nullable restore
#line 34 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactsIndex.razor"
                                                 inputReference = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
#nullable restore
#line 36 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactsIndex.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "form-row p-1");
            __builder.AddMarkupContent(46, "\r\n                    ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "form-group m-1");
            __builder.AddMarkupContent(49, "\r\n                        ");
            __builder.AddMarkupContent(50, "<label>Display </label>\r\n                        ");
            __builder.OpenElement(51, "select");
            __builder.AddAttribute(52, "class", "custom-select-sm");
            __builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactsIndex.razor"
                                                                                           LoadPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactsIndex.razor"
                                                                 recordsPerPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => recordsPerPage = __value, recordsPerPage));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(56, "\r\n                            ");
            __builder.OpenElement(57, "option");
            __builder.AddAttribute(58, "value", true);
            __builder.AddContent(59, "5");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                            ");
            __builder.OpenElement(61, "option");
            __builder.AddContent(62, "10");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                            ");
            __builder.OpenElement(64, "option");
            __builder.AddContent(65, "15");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                            ");
            __builder.OpenElement(67, "option");
            __builder.AddContent(68, "20");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                        ");
            __builder.AddMarkupContent(71, "<label> contacts</label>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n\r\n\r\n                ");
            __Blazor.DocumentationTool.Client.Pages.Contacts.ContactsIndex.TypeInference.CreateGenericList_0(__builder, 74, 75, 
#nullable restore
#line 52 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactsIndex.razor"
                                   People

#line default
#line hidden
#nullable disable
            , 76, (__builder2) => {
                __builder2.AddMarkupContent(77, "\r\n                        ");
                __builder2.OpenElement(78, "table");
                __builder2.AddAttribute(79, "class", "table");
                __builder2.AddMarkupContent(80, "\r\n                            ");
                __builder2.AddMarkupContent(81, @"<thead class=""thead-light"">
                                <tr>
                                    <th>First name</th>
                                    <th>Last name</th>
                                    <th>Telephone number</th>
                                    <th>E-mail address</th>
                                    <th>City</th>
                                    <th>Function</th>
                                    <th>Action</th>
                                </tr>
                            </thead>
                            ");
                __builder2.OpenElement(82, "tbody");
                __builder2.AddMarkupContent(83, "\r\n");
#nullable restore
#line 67 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactsIndex.razor"
                                 foreach (var item in People)
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(84, "                                    ");
                __builder2.OpenElement(85, "tr");
                __builder2.AddMarkupContent(86, "\r\n                                        ");
                __builder2.OpenElement(87, "td");
                __builder2.AddContent(88, 
#nullable restore
#line 70 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactsIndex.razor"
                                             item.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n                                        ");
                __builder2.OpenElement(90, "td");
                __builder2.AddContent(91, 
#nullable restore
#line 71 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactsIndex.razor"
                                             item.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n                                        ");
                __builder2.OpenElement(93, "td");
                __builder2.AddContent(94, 
#nullable restore
#line 72 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactsIndex.razor"
                                             item.TelephoneCompany

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n                                        ");
                __builder2.OpenElement(96, "td");
                __builder2.AddContent(97, 
#nullable restore
#line 73 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactsIndex.razor"
                                             item.EMailAdress

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n                                        ");
                __builder2.OpenElement(99, "td");
                __builder2.AddContent(100, 
#nullable restore
#line 74 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactsIndex.razor"
                                             item.City

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n                                        ");
                __builder2.OpenElement(102, "td");
                __builder2.AddContent(103, 
#nullable restore
#line 75 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactsIndex.razor"
                                             item.Function

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n                                        ");
                __builder2.OpenElement(105, "td");
                __builder2.AddMarkupContent(106, "\r\n                                            ");
                __builder2.OpenElement(107, "a");
                __builder2.AddAttribute(108, "href", "/contact/detail/" + (
#nullable restore
#line 77 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactsIndex.razor"
                                                                      item.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(109, "<span class=\"oi oi-eye\"></span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\r\n                                            ");
                __builder2.OpenElement(111, "a");
                __builder2.AddAttribute(112, "href", "/contact/edit/" + (
#nullable restore
#line 78 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactsIndex.razor"
                                                                    item.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(113, "<span class=\"oi oi-pencil\"></span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\r\n                                            ");
                __builder2.OpenElement(115, "a");
                __builder2.AddAttribute(116, "href", "/contact");
                __builder2.AddAttribute(117, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 79 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactsIndex.razor"
                                                                           () => DeletePerson(item.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(118, "<span class=\"oi oi-trash\"></span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(119, "\r\n                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(120, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(121, "\r\n");
#nullable restore
#line 82 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactsIndex.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(122, "                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(123, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(124, "\r\n                    ");
            }
            );
            __builder.AddMarkupContent(125, "\r\n                ");
            __builder.OpenElement(126, "div");
            __builder.AddAttribute(127, "class", "row");
            __builder.AddMarkupContent(128, "\r\n                    ");
            __builder.OpenElement(129, "div");
            __builder.AddAttribute(130, "class", "col-12");
            __builder.AddMarkupContent(131, "\r\n                        ");
            __builder.OpenElement(132, "div");
            __builder.AddAttribute(133, "class", "d-flex");
            __builder.AddMarkupContent(134, "\r\n                            ");
            __builder.OpenElement(135, "div");
            __builder.AddAttribute(136, "class", "ml-auto");
            __builder.AddMarkupContent(137, "\r\n                                ");
            __builder.OpenComponent<DocumentationTool.Client.Shared.Pagination>(138);
            __builder.AddAttribute(139, "CurrentPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 91 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactsIndex.razor"
                                                          paginationDTO.Page

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(140, "TotalAmountPages", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 91 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactsIndex.razor"
                                                                                                totalAmountPages

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(141, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 92 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactsIndex.razor"
                                                          SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(142, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(144, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(147, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 103 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactsIndex.razor"
       
    List<Person> People;
    PaginationDTO paginationDTO = new PaginationDTO();
    private int totalAmountPages;
    private int recordsPerPage = 5;

    //IFileListEntry file;
    int numLines;
    bool showImport = false;
    ElementReference inputReference;
    MemoryStream fileStream = null;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            await LoadPeople();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }

    private void Show()
    {
        showImport = !showImport;
    }

    public async Task OpenFileAsync()
    {
        var file = (await fileReaderService.CreateReference(inputReference).EnumerateFilesAsync()).FirstOrDefault();

        if (file != null)
        {
            var fileinfo = await file.ReadFileInfoAsync();

            //using(var ms = await file.CreateMemoryStreamAsync((int)fileinfo.Size))
            //{
            //    fileStream = ms;
            //}

            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (var ms = await file.CreateMemoryStreamAsync((int)fileinfo.Size))
            using (OfficeOpenXml.ExcelPackage package = new OfficeOpenXml.ExcelPackage(ms))
            {
                OfficeOpenXml.ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault();
                int colCount = worksheet.Dimension.End.Column;
                int rowCount = worksheet.Dimension.End.Row;
                Console.WriteLine(colCount);
                Console.WriteLine(rowCount);

                for (int row = 1; row <= rowCount; row++)
                {
                    for (int col = 1; col <= colCount; col++)
                    {
                        if (col == 1) Console.WriteLine(worksheet.Cells[row, col].Value.ToString());
                    }
                }
            }
            showImport = false;
        }
    }

    private async Task LoadPage()
    {
        paginationDTO = new PaginationDTO();
        await LoadPeople();
    }

    private async Task LoadPeople()
    {
        paginationDTO.RecordsPerPage = recordsPerPage;
        var paginatedResponse = await personRepository.GetPeople(paginationDTO);
        People = paginatedResponse.Response;
        totalAmountPages = paginatedResponse.TotalAmountPages;
    }

    private async Task SelectedPage(int page)
    {
        paginationDTO.Page = page;
        await LoadPeople();
    }

    private async Task DeletePerson(int id)
    {
        await personRepository.DeletePerson(id);
        await LoadPeople();
    }

    private async Task<List<Person>> GetAllPeople()
    {
        return await personRepository.GetAllPeople();
    }

    private async Task GenerateExcel()
    {
        ContactExcel ce = new ContactExcel();
        var people = await GetAllPeople();
        ce.GenerateExcel(iJSRuntime, people, false);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileReaderService fileReaderService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime iJSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPersonRepostiroy personRepository { get; set; }
    }
}
namespace __Blazor.DocumentationTool.Client.Pages.Contacts.ContactsIndex
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
