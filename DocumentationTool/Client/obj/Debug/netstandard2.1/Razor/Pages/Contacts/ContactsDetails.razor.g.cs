#pragma checksum "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactsDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad8136f55c08204917849822072262eddda911bb"
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
using DocumentationTool.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Shared.Tags;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Excel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Hardware;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Contacts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Infrastucture;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Hardware;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Contacts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactsDetails.razor"
using DocumentationTool.Client.Shared.GeneralSH;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactsDetails.razor"
using DocumentationTool.Client.Shared.Tabs;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/contact/detail/{PersonId:int}")]
    public partial class ContactsDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Monitor details</h3>\r\n\r\n");
#nullable restore
#line 10 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactsDetails.razor"
 if (Person != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenComponent<DocumentationTool.Client.Shared.Tabs.TabControl>(2);
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n        ");
                __builder2.OpenComponent<DocumentationTool.Client.Shared.Tabs.TabPage>(5);
                __builder2.AddAttribute(6, "Text", "General");
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(8, "\r\n            ");
                    __builder3.OpenComponent<DocumentationTool.Client.Shared.GeneralSH.GeneralDetails>(9);
                    __builder3.AddAttribute(10, "General", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DocumentationTool.Shared.Entities.Hardware.General>(
#nullable restore
#line 14 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactsDetails.razor"
                                     Person.General

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(11, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.OpenComponent<DocumentationTool.Client.Shared.Tabs.TabPage>(13);
                __builder2.AddAttribute(14, "Text", "Person");
                __builder2.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(16, "\r\n            ");
                    __builder3.OpenComponent<DocumentationTool.Client.Pages.Contacts.ContactsDisplayDetails>(17);
                    __builder3.AddAttribute(18, "Person", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DocumentationTool.Shared.Entities.Contacts.Person>(
#nullable restore
#line 17 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactsDetails.razor"
                                            Person

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(19, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "\r\n");
#nullable restore
#line 20 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactsDetails.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Contacts\ContactsDetails.razor"
       
    [Parameter]
    public int PersonId { get; set; }

    public Person Person;

    protected async override Task OnInitializedAsync()
    {
        Person = await PersonRepository.GetPerson(PersonId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPersonRepostiroy PersonRepository { get; set; }
    }
}
#pragma warning restore 1591
