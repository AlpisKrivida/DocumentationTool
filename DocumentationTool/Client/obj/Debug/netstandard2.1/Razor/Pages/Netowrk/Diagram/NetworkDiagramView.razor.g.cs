#pragma checksum "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Netowrk\Diagram\NetworkDiagramView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4201122182b3547cf26af278d482f119d64c5394"
// <auto-generated/>
#pragma warning disable 1591
namespace DocumentationTool.Client.Pages.Netowrk.Diagram
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
#line 19 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Software;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Sowftware;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Hardware;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Contacts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Information;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Netowrk\Diagram\NetworkDiagramView.razor"
using Syncfusion.Blazor.Diagrams;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Netowrk\Diagram\NetworkDiagramView.razor"
using System.Collections.ObjectModel;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/networkDiagram")]
    public partial class NetworkDiagramView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Syncfusion.Blazor.Diagrams.SfDiagram>(0);
            __builder.AddAttribute(1, "id", "diagram");
            __builder.AddAttribute(2, "Width", "100%");
            __builder.AddAttribute(3, "Height", "580px");
            __builder.AddAttribute(4, "tool", 
#nullable restore
#line 5 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Netowrk\Diagram\NetworkDiagramView.razor"
                                                                           DiagramTools.ZoomPan

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "NodeDefaults", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Diagrams.DiagramNode>(
#nullable restore
#line 5 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Netowrk\Diagram\NetworkDiagramView.razor"
                                                                                                                NodeDefaults

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ConnectorDefaults", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Diagrams.DiagramConnector>(
#nullable restore
#line 5 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Netowrk\Diagram\NetworkDiagramView.razor"
                                                                                                                                                  ConnectorDefault

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Diagrams.DiagramLayout>(
#nullable restore
#line 5 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Netowrk\Diagram\NetworkDiagramView.razor"
                                                                                                                                                                             LayoutValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Diagrams.DiagramDataSource>(10);
                __builder2.AddAttribute(11, "Id", "Name");
                __builder2.AddAttribute(12, "ParentId", "ReportingPerson");
                __builder2.AddAttribute(13, "DataMapSettings", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Syncfusion.Blazor.Diagrams.DiagramDataMapSetting>>(
#nullable restore
#line 6 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Netowrk\Diagram\NetworkDiagramView.razor"
                                                                              datamap

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Netowrk\Diagram\NetworkDiagramView.razor"
                                                                                                    dataSource

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Diagrams.DiagramSnapSettings>(16);
                __builder2.AddAttribute(17, "Constraints", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Diagrams.SnapConstraints>(
#nullable restore
#line 7 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Netowrk\Diagram\NetworkDiagramView.razor"
                                       SnapConstraints.None

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n");
            }
            ));
            __builder.AddComponentReferenceCapture(19, (__value) => {
#nullable restore
#line 5 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Netowrk\Diagram\NetworkDiagramView.razor"
                  diagram = (Syncfusion.Blazor.Diagrams.SfDiagram)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Netowrk\Diagram\NetworkDiagramView.razor"
       
    SfDiagram diagram;
    List<DiagramDataMapSetting> datamap = new List<DiagramDataMapSetting>() {
        new DiagramDataMapSetting() { Property = "Shape.Source", Field = "image" },
        //new DiagramDataMapSetting() { Property = "Style.fill", Field = "fillColor" },
        //new DiagramDataMapSetting() { Property = "Style.strokeColor", Field = "border" }

    };

    DiagramLayout LayoutValue = new DiagramLayout()
    {
        Type = LayoutType.ComplexHierarchicalTree,
        HorizontalSpacing = 40,
        VerticalSpacing = 40,
        Orientation = LayoutOrientation.TopToBottom,
        Margin = new LayoutMargin() { Left = 20, Top = 20 },
    };

    DiagramNode NodeDefaults = new DiagramNode
    {
        Height = 40,
        Width = 40,
        Shape = new DiagramShape() {
            Type = Shapes.Image,
            //Source = "/Icons/printer.png"
        },
    };

    DiagramConnector ConnectorDefault = new DiagramConnector
    {
        Type = Syncfusion.Blazor.Diagrams.Segments.Orthogonal,
        CornerRadius = 7,
        TargetDecorator = new ConnectorTargetDecorator() { Width = 7, Height = 7 },
        Style = new ConnectorShapeStyle() { StrokeColor = "#6d6d6d" }

    };
    public class DataModel
    {
        public string Name;
        public string fillColor;
        public string border;
        public string image;
        public string[] ReportingPerson;
    }
    public object dataSource = new List<object>()
{
        new DataModel { Name = "node11", fillColor = "#e7704c", border = "#c15433", image = "/Icons/internet.jpg" },
        new DataModel {  Name = "node12", ReportingPerson = new string[]{ "node10" }, fillColor = "#efd46e", border = "#d6b123", image = "/Icons/switch.png" },
        new DataModel {  Name = "node13", ReportingPerson = new string[]{ "node10" }, fillColor = "#efd46e", border = "#d6b123", image = "/Icons/switch.png" },
        new DataModel {  Name = "node10", ReportingPerson = new string[] { "node11" }, fillColor = "#58b087", border = "#16955e", image = "/Icons/router.png" },
    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
