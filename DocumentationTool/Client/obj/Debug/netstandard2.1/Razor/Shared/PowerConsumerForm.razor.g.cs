#pragma checksum "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5bff5707cd197caaede1ef980d73fd5a7e7e2b5"
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
    public partial class PowerConsumerForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>PowerConsumer Form</h3>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 2 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerForm.razor"
                 PowerConsumer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group");
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.AddMarkupContent(10, "<label>Title</label>\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "class", "form-control");
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerForm.razor"
                                                          PowerConsumer.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => PowerConsumer.Title = __value, PowerConsumer.Title))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => PowerConsumer.Title));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n            ");
                __Blazor.DocumentationTool.Client.Shared.PowerConsumerForm.TypeInference.CreateValidationMessage_0(__builder2, 19, 20, 
#nullable restore
#line 9 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerForm.razor"
                                      () => PowerConsumer.Title

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n\r\n    ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "form-group");
                __builder2.AddMarkupContent(26, "\r\n        ");
                __builder2.AddMarkupContent(27, "<label>Active</label>\r\n        ");
                __builder2.OpenElement(28, "div");
                __builder2.AddMarkupContent(29, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(30);
                __builder2.AddAttribute(31, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerForm.razor"
                                         PowerConsumer.Active

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => PowerConsumer.Active = __value, PowerConsumer.Active))));
                __builder2.AddAttribute(33, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => PowerConsumer.Active));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n            ");
                __Blazor.DocumentationTool.Client.Shared.PowerConsumerForm.TypeInference.CreateValidationMessage_1(__builder2, 35, 36, 
#nullable restore
#line 17 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerForm.razor"
                                      () => PowerConsumer.Active

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n\r\n    ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group");
                __builder2.AddMarkupContent(42, "\r\n        ");
                __builder2.AddMarkupContent(43, "<label>Manufactutrer</label>\r\n        ");
                __builder2.OpenElement(44, "div");
                __builder2.AddMarkupContent(45, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(46);
                __builder2.AddAttribute(47, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerForm.razor"
                                     PowerConsumer.Manufacturer

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => PowerConsumer.Manufacturer = __value, PowerConsumer.Manufacturer))));
                __builder2.AddAttribute(49, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => PowerConsumer.Manufacturer));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n            ");
                __Blazor.DocumentationTool.Client.Shared.PowerConsumerForm.TypeInference.CreateValidationMessage_2(__builder2, 51, 52, 
#nullable restore
#line 25 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerForm.razor"
                                      () => PowerConsumer.Manufacturer

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(53, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n\r\n    ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "form-group");
                __builder2.AddMarkupContent(58, "\r\n        ");
                __builder2.AddMarkupContent(59, "<label>PowerModel</label>\r\n        ");
                __builder2.OpenElement(60, "div");
                __builder2.AddMarkupContent(61, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(62);
                __builder2.AddAttribute(63, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerForm.razor"
                                     PowerConsumer.PowerModel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(64, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => PowerConsumer.PowerModel = __value, PowerConsumer.PowerModel))));
                __builder2.AddAttribute(65, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => PowerConsumer.PowerModel));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(66, "\r\n            ");
                __Blazor.DocumentationTool.Client.Shared.PowerConsumerForm.TypeInference.CreateValidationMessage_3(__builder2, 67, 68, 
#nullable restore
#line 33 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerForm.razor"
                                      () => PowerConsumer.PowerModel

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(69, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n\r\n    ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "form-group");
                __builder2.AddMarkupContent(74, "\r\n        ");
                __builder2.AddMarkupContent(75, "<label>Volt</label>\r\n        ");
                __builder2.OpenElement(76, "div");
                __builder2.AddMarkupContent(77, "\r\n            ");
                __Blazor.DocumentationTool.Client.Shared.PowerConsumerForm.TypeInference.CreateInputNumber_4(__builder2, 78, 79, 
#nullable restore
#line 40 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerForm.razor"
                                       PowerConsumer.Volt

#line default
#line hidden
#nullable disable
                , 80, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => PowerConsumer.Volt = __value, PowerConsumer.Volt)), 81, () => PowerConsumer.Volt);
                __builder2.AddMarkupContent(82, "\r\n            ");
                __Blazor.DocumentationTool.Client.Shared.PowerConsumerForm.TypeInference.CreateValidationMessage_5(__builder2, 83, 84, 
#nullable restore
#line 41 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerForm.razor"
                                      () => PowerConsumer.Volt

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(85, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n\r\n    ");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "form-group");
                __builder2.AddMarkupContent(90, "\r\n        ");
                __builder2.AddMarkupContent(91, "<label>Watt</label>\r\n        ");
                __builder2.OpenElement(92, "div");
                __builder2.AddMarkupContent(93, "\r\n            ");
                __Blazor.DocumentationTool.Client.Shared.PowerConsumerForm.TypeInference.CreateInputNumber_6(__builder2, 94, 95, 
#nullable restore
#line 48 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerForm.razor"
                                       PowerConsumer.Watt

#line default
#line hidden
#nullable disable
                , 96, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => PowerConsumer.Watt = __value, PowerConsumer.Watt)), 97, () => PowerConsumer.Watt);
                __builder2.AddMarkupContent(98, "\r\n            ");
                __Blazor.DocumentationTool.Client.Shared.PowerConsumerForm.TypeInference.CreateValidationMessage_7(__builder2, 99, 100, 
#nullable restore
#line 49 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerForm.razor"
                                      () => PowerConsumer.Watt

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(101, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n\r\n    ");
                __builder2.OpenElement(104, "div");
                __builder2.AddAttribute(105, "class", "form-group");
                __builder2.AddMarkupContent(106, "\r\n        ");
                __builder2.AddMarkupContent(107, "<label>Ampere</label>\r\n        ");
                __builder2.OpenElement(108, "div");
                __builder2.AddMarkupContent(109, "\r\n            ");
                __Blazor.DocumentationTool.Client.Shared.PowerConsumerForm.TypeInference.CreateInputNumber_8(__builder2, 110, 111, 
#nullable restore
#line 56 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerForm.razor"
                                       PowerConsumer.Ampere

#line default
#line hidden
#nullable disable
                , 112, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => PowerConsumer.Ampere = __value, PowerConsumer.Ampere)), 113, () => PowerConsumer.Ampere);
                __builder2.AddMarkupContent(114, "\r\n            ");
                __Blazor.DocumentationTool.Client.Shared.PowerConsumerForm.TypeInference.CreateValidationMessage_9(__builder2, 115, 116, 
#nullable restore
#line 57 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerForm.razor"
                                      () => PowerConsumer.Ampere

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(117, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(118, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(119, "\r\n\r\n    ");
                __builder2.OpenElement(120, "div");
                __builder2.AddAttribute(121, "class", "form-group");
                __builder2.AddMarkupContent(122, "\r\n        ");
                __builder2.AddMarkupContent(123, "<label>BTU</label>\r\n        ");
                __builder2.OpenElement(124, "div");
                __builder2.AddMarkupContent(125, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(126);
                __builder2.AddAttribute(127, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 64 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerForm.razor"
                                     PowerConsumer.BTU

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(128, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => PowerConsumer.BTU = __value, PowerConsumer.BTU))));
                __builder2.AddAttribute(129, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => PowerConsumer.BTU));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(130, "\r\n            ");
                __Blazor.DocumentationTool.Client.Shared.PowerConsumerForm.TypeInference.CreateValidationMessage_10(__builder2, 131, 132, 
#nullable restore
#line 65 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerForm.razor"
                                      () => PowerConsumer.BTU

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(133, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(134, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(135, "\r\n\r\n    ");
                __builder2.OpenElement(136, "div");
                __builder2.AddAttribute(137, "class", "form-group");
                __builder2.AddMarkupContent(138, "\r\n        ");
                __builder2.AddMarkupContent(139, "<label>Description</label>\r\n        ");
                __builder2.OpenElement(140, "div");
                __builder2.AddMarkupContent(141, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(142);
                __builder2.AddAttribute(143, "class", "form-control");
                __builder2.AddAttribute(144, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 72 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerForm.razor"
                                                              PowerConsumer.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(145, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => PowerConsumer.Description = __value, PowerConsumer.Description))));
                __builder2.AddAttribute(146, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => PowerConsumer.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(147, "\r\n            ");
                __Blazor.DocumentationTool.Client.Shared.PowerConsumerForm.TypeInference.CreateValidationMessage_11(__builder2, 148, 149, 
#nullable restore
#line 73 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerForm.razor"
                                      () => PowerConsumer.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(150, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(151, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(152, "\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerForm.razor"
       
    [Parameter] public PowerConsumer PowerConsumer { get; set; }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.DocumentationTool.Client.Shared.PowerConsumerForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_9<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_10<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_11<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591