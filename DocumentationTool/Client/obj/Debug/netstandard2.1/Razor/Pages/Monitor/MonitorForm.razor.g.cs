#pragma checksum "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Pages\Monitor\MonitorForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f9278ab2343fc3b5c91777a969865ea0a85b29a"
// <auto-generated/>
#pragma warning disable 1591
namespace DocumentationTool.Client.Pages.Monitor
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
    public partial class MonitorForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 1 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Pages\Monitor\MonitorForm.razor"
                     Monitor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 1 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Pages\Monitor\MonitorForm.razor"
                                             OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n\r\n    ");
                __builder2.OpenElement(7, "form");
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-row");
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group col-md-8");
                __builder2.AddMarkupContent(14, "\r\n                ");
                __builder2.AddMarkupContent(15, "<label>Display </label>\r\n                ");
                __Blazor.DocumentationTool.Client.Pages.Monitor.MonitorForm.TypeInference.CreateInputNumber_0(__builder2, 16, 17, "form-control", 18, 
#nullable restore
#line 8 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Pages\Monitor\MonitorForm.razor"
                                                                Monitor.Display

#line default
#line hidden
#nullable disable
                , 19, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Monitor.Display = __value, Monitor.Display)), 20, () => Monitor.Display);
                __builder2.AddMarkupContent(21, "\r\n                ");
                __Blazor.DocumentationTool.Client.Pages.Monitor.MonitorForm.TypeInference.CreateValidationMessage_1(__builder2, 22, 23, 
#nullable restore
#line 9 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Pages\Monitor\MonitorForm.razor"
                                          () => Monitor.Display

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(24, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n            ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "form-group col-md-4");
                __builder2.AddMarkupContent(28, "\r\n                ");
                __builder2.AddMarkupContent(29, "<label>Display measure</label>\r\n                ");
                __Blazor.DocumentationTool.Client.Pages.Monitor.MonitorForm.TypeInference.CreateInputSelect_2(__builder2, 30, 31, "form-control", 32, 
#nullable restore
#line 13 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Pages\Monitor\MonitorForm.razor"
                                                                Monitor.DisplayMeasure

#line default
#line hidden
#nullable disable
                , 33, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Monitor.DisplayMeasure = __value, Monitor.DisplayMeasure)), 34, () => Monitor.DisplayMeasure, 35, (__builder3) => {
                    __builder3.AddMarkupContent(36, "\r\n                    ");
                    __builder3.AddMarkupContent(37, "<option value>Select measure...</option>\r\n                    ");
                    __builder3.AddMarkupContent(38, "<option>cm</option>\r\n                    ");
                    __builder3.AddMarkupContent(39, "<option>foot</option>\r\n                    ");
                    __builder3.AddMarkupContent(40, "<option>inch</option>\r\n                    ");
                    __builder3.AddMarkupContent(41, "<option>m</option>\r\n                    ");
                    __builder3.AddMarkupContent(42, "<option>mm</option>\r\n                ");
                }
                );
                __builder2.AddMarkupContent(43, "\r\n                ");
                __Blazor.DocumentationTool.Client.Pages.Monitor.MonitorForm.TypeInference.CreateValidationMessage_3(__builder2, 44, 45, 
#nullable restore
#line 21 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Pages\Monitor\MonitorForm.razor"
                                          () => Monitor.DisplayMeasure

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(46, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n\r\n        ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "form-group");
                __builder2.AddMarkupContent(51, "\r\n            ");
                __builder2.AddMarkupContent(52, "<label>Type</label>\r\n            ");
                __builder2.OpenElement(53, "div");
                __builder2.AddMarkupContent(54, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(55);
                __builder2.AddAttribute(56, "class", "form-control");
                __builder2.AddAttribute(57, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Pages\Monitor\MonitorForm.razor"
                                                              Monitor.Type

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Monitor.Type = __value, Monitor.Type))));
                __builder2.AddAttribute(59, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Monitor.Type));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(60, "\r\n                ");
                __Blazor.DocumentationTool.Client.Pages.Monitor.MonitorForm.TypeInference.CreateValidationMessage_4(__builder2, 61, 62, 
#nullable restore
#line 29 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Pages\Monitor\MonitorForm.razor"
                                          () => Monitor.Type

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(63, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n\r\n        ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "form-group");
                __builder2.AddMarkupContent(68, "\r\n            ");
                __builder2.AddMarkupContent(69, "<label>Resolution</label>\r\n            ");
                __builder2.OpenElement(70, "div");
                __builder2.AddMarkupContent(71, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(72);
                __builder2.AddAttribute(73, "class", "form-control");
                __builder2.AddAttribute(74, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Pages\Monitor\MonitorForm.razor"
                                                              Monitor.Resolution

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(75, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Monitor.Resolution = __value, Monitor.Resolution))));
                __builder2.AddAttribute(76, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Monitor.Resolution));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(77, "\r\n                ");
                __Blazor.DocumentationTool.Client.Pages.Monitor.MonitorForm.TypeInference.CreateValidationMessage_5(__builder2, 78, 79, 
#nullable restore
#line 37 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Pages\Monitor\MonitorForm.razor"
                                          () => Monitor.Resolution

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(80, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n\r\n        ");
                __builder2.OpenElement(83, "div");
                __builder2.AddAttribute(84, "class", "form-group");
                __builder2.AddMarkupContent(85, "\r\n            ");
                __builder2.AddMarkupContent(86, "<label>Pivot</label>\r\n            ");
                __builder2.OpenElement(87, "div");
                __builder2.AddMarkupContent(88, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(89);
                __builder2.AddAttribute(90, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 44 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Pages\Monitor\MonitorForm.razor"
                                             Monitor.Pivot

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(91, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Monitor.Pivot = __value, Monitor.Pivot))));
                __builder2.AddAttribute(92, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => Monitor.Pivot));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(93, "\r\n                ");
                __Blazor.DocumentationTool.Client.Pages.Monitor.MonitorForm.TypeInference.CreateValidationMessage_6(__builder2, 94, 95, 
#nullable restore
#line 45 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Pages\Monitor\MonitorForm.razor"
                                          () => Monitor.Pivot

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(96, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n\r\n        ");
                __builder2.OpenElement(99, "div");
                __builder2.AddAttribute(100, "class", "form-group");
                __builder2.AddMarkupContent(101, "\r\n            ");
                __builder2.AddMarkupContent(102, "<label>Speaker</label>\r\n            ");
                __builder2.OpenElement(103, "div");
                __builder2.AddMarkupContent(104, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(105);
                __builder2.AddAttribute(106, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 52 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Pages\Monitor\MonitorForm.razor"
                                             Monitor.Speaker

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(107, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Monitor.Speaker = __value, Monitor.Speaker))));
                __builder2.AddAttribute(108, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => Monitor.Speaker));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(109, "\r\n                ");
                __Blazor.DocumentationTool.Client.Pages.Monitor.MonitorForm.TypeInference.CreateValidationMessage_7(__builder2, 110, 111, 
#nullable restore
#line 53 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Pages\Monitor\MonitorForm.razor"
                                          () => Monitor.Speaker

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(112, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(113, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\r\n\r\n        ");
                __builder2.OpenElement(115, "div");
                __builder2.AddAttribute(116, "class", "form-group");
                __builder2.AddMarkupContent(117, "\r\n            ");
                __builder2.AddMarkupContent(118, "<label>Description</label>\r\n            ");
                __builder2.OpenElement(119, "div");
                __builder2.AddMarkupContent(120, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(121);
                __builder2.AddAttribute(122, "class", "form-control");
                __builder2.AddAttribute(123, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 60 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Pages\Monitor\MonitorForm.razor"
                                                                  Monitor.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(124, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Monitor.Description = __value, Monitor.Description))));
                __builder2.AddAttribute(125, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Monitor.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(126, "\r\n                ");
                __Blazor.DocumentationTool.Client.Pages.Monitor.MonitorForm.TypeInference.CreateValidationMessage_8(__builder2, 127, 128, 
#nullable restore
#line 61 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Pages\Monitor\MonitorForm.razor"
                                          () => Monitor.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(129, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(130, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(131, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(132, "\r\n\r\n    ");
                __builder2.OpenComponent<DocumentationTool.Client.Shared.ModelForm>(133);
                __builder2.AddAttribute(134, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DocumentationTool.Shared.Entities.Hardware.Model>(
#nullable restore
#line 66 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Pages\Monitor\MonitorForm.razor"
                      Model

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(135, "\r\n    ");
                __builder2.OpenComponent<DocumentationTool.Client.Shared.FormFactorForm>(136);
                __builder2.AddAttribute(137, "FormFactor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DocumentationTool.Shared.Entities.Shared.FormFactor>(
#nullable restore
#line 68 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Pages\Monitor\MonitorForm.razor"
                                FormFactor

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(138, "\r\n    ");
                __builder2.OpenComponent<DocumentationTool.Client.Shared.PowerConsumerForm>(139);
                __builder2.AddAttribute(140, "PowerConsumer", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DocumentationTool.Shared.Entities.Shared.PowerConsumer>(
#nullable restore
#line 69 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Pages\Monitor\MonitorForm.razor"
                                      PowerConsumer

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(141, "\r\n\r\n    ");
                __builder2.AddMarkupContent(142, "<button class=\"btn btn-primary\" type=\"submit\">Save Changes</button>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Pages\Monitor\MonitorForm.razor"
       
    [Parameter] public Monitor Monitor { get; set; }
    [Parameter] public Model Model { get; set; }
    //[Parameter] public General General { get; set; }
    [Parameter] public FormFactor FormFactor { get; set; }
    [Parameter] public PowerConsumer PowerConsumer { get; set; }
    [Parameter] public EventCallback OnValidSubmit { get; set; }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.DocumentationTool.Client.Pages.Monitor.MonitorForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591