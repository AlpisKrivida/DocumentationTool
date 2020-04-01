#pragma checksum "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Pages\Mouse\MouseIndex.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3354cbe957a5d9c6696b4fbcc572ac0433fce2c5"
// <auto-generated/>
#pragma warning disable 1591
namespace DocumentationTool.Client.Pages.Mouse
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Hardware;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Hardware;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.DTOs;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/mouse")]
    public partial class MouseIndex : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Mouse Index</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"form-group\">\r\n    <a class=\"btn btn-info\" href=\"mouse/create\">New Mouse</a>\r\n</div>\r\n\r\n");
            __builder.OpenComponent<DocumentationTool.Client.Shared.Pagination>(2);
            __builder.AddAttribute(3, "CurrentPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 10 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Pages\Mouse\MouseIndex.razor"
                          paginationDTO.Page

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "TotalAmountPages", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 10 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Pages\Mouse\MouseIndex.razor"
                                                                totalAmountPages

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 11 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Pages\Mouse\MouseIndex.razor"
                          SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __Blazor.DocumentationTool.Client.Pages.Mouse.MouseIndex.TypeInference.CreateGenericList_0(__builder, 7, 8, 
#nullable restore
#line 13 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Pages\Mouse\MouseIndex.razor"
                   Mouses

#line default
#line hidden
#nullable disable
            , 9, (__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenElement(11, "table");
                __builder2.AddAttribute(12, "class", "table table-striped");
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.AddMarkupContent(14, "<thead>\r\n                <tr>\r\n                    <th></th>\r\n                    <th>Name</th>\r\n                </tr>\r\n            </thead>\r\n            ");
                __builder2.OpenElement(15, "tbody");
                __builder2.AddMarkupContent(16, "\r\n");
#nullable restore
#line 23 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Pages\Mouse\MouseIndex.razor"
                 foreach (var item in Mouses)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(17, "                    ");
                __builder2.OpenElement(18, "tr");
                __builder2.AddMarkupContent(19, "\r\n                        ");
                __builder2.OpenElement(20, "td");
                __builder2.AddMarkupContent(21, "\r\n                            ");
                __builder2.OpenElement(22, "a");
                __builder2.AddAttribute(23, "class", "btn btn-success");
                __builder2.AddAttribute(24, "href", "/mouse/edit/" + (
#nullable restore
#line 27 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Pages\Mouse\MouseIndex.razor"
                                                                          item.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(25, "Edit");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                            ");
                __builder2.OpenElement(27, "button");
                __builder2.AddAttribute(28, "class", "btn btn-danger");
                __builder2.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Pages\Mouse\MouseIndex.razor"
                                                                       () => DeleteMouse(item.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(30, "Delete");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                        ");
                __builder2.OpenElement(33, "td");
                __builder2.AddContent(34, 
#nullable restore
#line 30 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Pages\Mouse\MouseIndex.razor"
                             item.Type

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n");
#nullable restore
#line 32 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Pages\Mouse\MouseIndex.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(37, "            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n    ");
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Pages\Mouse\MouseIndex.razor"
       
    List<Mouse> Mouses;
    PaginationDTO paginationDTO = new PaginationDTO() { RecordsPerPage = 1 };
    private int totalAmountPages;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            await LoadMouses();
        }
        catch (Exception ex)
        {

        }
    }

    private async Task LoadMouses()
    {
        var paginatedResponse = await mouseRepository.GetMouses(paginationDTO);
        Mouses = paginatedResponse.Response;
        totalAmountPages = paginatedResponse.TotalAmountPages;
    }

    private async Task SelectedPage(int page)
    {
        paginationDTO.Page = page;
        await LoadMouses();
    }

    private async Task DeleteMouse(int id)
    {
        await mouseRepository.DeleteMouse(id);
        await LoadMouses();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMouseRepository mouseRepository { get; set; }
    }
}
namespace __Blazor.DocumentationTool.Client.Pages.Mouse.MouseIndex
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
