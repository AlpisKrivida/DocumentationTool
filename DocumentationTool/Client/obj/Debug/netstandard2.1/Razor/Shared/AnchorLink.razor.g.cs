#pragma checksum "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\AnchorLink.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2534ae9b3b019258a3e125daf98c6dc544463d42"
// <auto-generated/>
#pragma warning disable 1591
namespace DocumentationTool.Client.Shared
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
    public partial class AnchorLink : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "a");
            __builder.AddMultipleAttributes(1, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 65 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\AnchorLink.razor"
                this.Attributes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\AnchorLink.razor"
                                           this.AnchorOnClickAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventPreventDefaultAttribute(3, "onclick", 
#nullable restore
#line 65 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\AnchorLink.razor"
                                                                                              this.preventDefault

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, 
#nullable restore
#line 65 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\AnchorLink.razor"
                                                                                                                    this.ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 1 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\AnchorLink.razor"
       

    public AnchorLink()
    {
        this.Attributes = new Dictionary<string, object>();
    }

    private string targetId = null;
    private bool preventDefault = false;

    /// <summary>
    /// This parameter supports arbitrary attributes.
    /// </summary>
    /// <remarks>
    /// Any attribute specified on the component, which is not defined as a parameter, whill be added to this dictionary.
    /// It is then uses as the source for attributes rendered onto the resulting HTML element below in the markup section
    /// of this component.
    /// For details, refer to <see cref="https://docs.microsoft.com/en-us/aspnet/core/blazor/components#attribute-splatting-and-arbitrary-parameters"/>.
    /// </remarks>
    [Parameter(CaptureUnmatchedValues = true)]
    public IDictionary<string, object> Attributes { get; set; }

    /// <summary>
    /// Supports child content for the component.
    /// </summary>
    /// <see cref="https://docs.microsoft.com/en-us/aspnet/core/blazor/components#child-content"/>
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Inject]
    protected IJSRuntime JsInterop { get; set; }


    protected override void OnParametersSet()
    {
        string href = null;
        if (this.Attributes.ContainsKey("href"))
        {
            // If the href attribute has been specified, we examine the value of it. If if starts with '#'
            // we assume the rest of the value contains the ID of the element the link points to.
            href = $"{this.Attributes["href"]}";
            if (href.StartsWith("#"))
            {
                // If the href contains an anchor link we don't want the default click action to occur, but
                // rather take care of the click in our own method.
                this.targetId = href.Substring(1);
                this.preventDefault = true;
            }
        }
        base.OnParametersSet();
    }

    private async Task AnchorOnClickAsync()
    {
        if (!string.IsNullOrEmpty(this.targetId))
        {
            // If the target ID has been specified, we know this is an anchor link that we need to scroll
            // to, so we call the JavaScript method to take care of this for us.
            await this.JsInterop.InvokeVoidAsync("anchorLink.scrollIntoView", this.targetId);
        }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
