#pragma checksum "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\FormFactorForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c038ffb98d53fb87bd65467af4010a4266ae85ee"
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
    public partial class FormFactorForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Model Form</h3>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 2 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\FormFactorForm.razor"
                 FormFactor

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
                __builder2.AddMarkupContent(10, "<label>Form factor</label>\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "class", "form-control");
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\FormFactorForm.razor"
                                                          FormFactor.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => FormFactor.Name = __value, FormFactor.Name))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => FormFactor.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n            ");
                __Blazor.DocumentationTool.Client.Shared.FormFactorForm.TypeInference.CreateValidationMessage_0(__builder2, 19, 20, 
#nullable restore
#line 9 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\FormFactorForm.razor"
                                      () => FormFactor.Name

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
                __builder2.AddMarkupContent(27, "<label>Rack units</label>\r\n        ");
                __builder2.OpenElement(28, "div");
                __builder2.AddMarkupContent(29, "\r\n            ");
                __Blazor.DocumentationTool.Client.Shared.FormFactorForm.TypeInference.CreateInputNumber_1(__builder2, 30, 31, "form-control", 32, 
#nullable restore
#line 16 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\FormFactorForm.razor"
                                                            FormFactor.RackUnit

#line default
#line hidden
#nullable disable
                , 33, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => FormFactor.RackUnit = __value, FormFactor.RackUnit)), 34, () => FormFactor.RackUnit);
                __builder2.AddMarkupContent(35, "\r\n            ");
                __Blazor.DocumentationTool.Client.Shared.FormFactorForm.TypeInference.CreateValidationMessage_2(__builder2, 36, 37, 
#nullable restore
#line 17 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\FormFactorForm.razor"
                                      () => FormFactor.RackUnit

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n\r\n    ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group col-md-4");
                __builder2.AddMarkupContent(43, "\r\n        ");
                __builder2.AddMarkupContent(44, "<label>Dimension unit</label>\r\n        ");
                __Blazor.DocumentationTool.Client.Shared.FormFactorForm.TypeInference.CreateInputSelect_3(__builder2, 45, 46, "form-control", 47, 
#nullable restore
#line 23 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\FormFactorForm.razor"
                                                        FormFactor.DimesnsionUnit

#line default
#line hidden
#nullable disable
                , 48, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => FormFactor.DimesnsionUnit = __value, FormFactor.DimesnsionUnit)), 49, () => FormFactor.DimesnsionUnit, 50, (__builder3) => {
                    __builder3.AddMarkupContent(51, "\r\n            ");
                    __builder3.AddMarkupContent(52, "<option value>Select measure...</option>\r\n            ");
                    __builder3.AddMarkupContent(53, "<option>cm</option>\r\n            ");
                    __builder3.AddMarkupContent(54, "<option>foot</option>\r\n            ");
                    __builder3.AddMarkupContent(55, "<option>inch</option>\r\n            ");
                    __builder3.AddMarkupContent(56, "<option>m</option>\r\n            ");
                    __builder3.AddMarkupContent(57, "<option>mm</option>\r\n        ");
                }
                );
                __builder2.AddMarkupContent(58, "\r\n        ");
                __Blazor.DocumentationTool.Client.Shared.FormFactorForm.TypeInference.CreateValidationMessage_4(__builder2, 59, 60, 
#nullable restore
#line 31 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\FormFactorForm.razor"
                                  () => FormFactor.DimesnsionUnit

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(61, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n\r\n    ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "form-group");
                __builder2.AddMarkupContent(65, "\r\n        ");
                __builder2.AddMarkupContent(66, "<label>Width</label>\r\n        ");
                __builder2.OpenElement(67, "div");
                __builder2.AddMarkupContent(68, "\r\n            ");
                __Blazor.DocumentationTool.Client.Shared.FormFactorForm.TypeInference.CreateInputNumber_5(__builder2, 69, 70, "form-control", 71, 
#nullable restore
#line 37 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\FormFactorForm.razor"
                                                            FormFactor.Width

#line default
#line hidden
#nullable disable
                , 72, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => FormFactor.Width = __value, FormFactor.Width)), 73, () => FormFactor.Width);
                __builder2.AddMarkupContent(74, "\r\n            ");
                __Blazor.DocumentationTool.Client.Shared.FormFactorForm.TypeInference.CreateValidationMessage_6(__builder2, 75, 76, 
#nullable restore
#line 38 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\FormFactorForm.razor"
                                      () => FormFactor.Width

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(77, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n\r\n    ");
                __builder2.OpenElement(80, "div");
                __builder2.AddAttribute(81, "class", "form-group");
                __builder2.AddMarkupContent(82, "\r\n        ");
                __builder2.AddMarkupContent(83, "<label>Height</label>\r\n        ");
                __builder2.OpenElement(84, "div");
                __builder2.AddMarkupContent(85, "\r\n            ");
                __Blazor.DocumentationTool.Client.Shared.FormFactorForm.TypeInference.CreateInputNumber_7(__builder2, 86, 87, "form-control", 88, 
#nullable restore
#line 45 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\FormFactorForm.razor"
                                                            FormFactor.Height

#line default
#line hidden
#nullable disable
                , 89, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => FormFactor.Height = __value, FormFactor.Height)), 90, () => FormFactor.Height);
                __builder2.AddMarkupContent(91, "\r\n            ");
                __Blazor.DocumentationTool.Client.Shared.FormFactorForm.TypeInference.CreateValidationMessage_8(__builder2, 92, 93, 
#nullable restore
#line 46 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\FormFactorForm.razor"
                                      () => FormFactor.Height

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(94, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n\r\n    ");
                __builder2.OpenElement(97, "div");
                __builder2.AddAttribute(98, "class", "form-group");
                __builder2.AddMarkupContent(99, "\r\n        ");
                __builder2.AddMarkupContent(100, "<label>Depth</label>\r\n        ");
                __builder2.OpenElement(101, "div");
                __builder2.AddMarkupContent(102, "\r\n            ");
                __Blazor.DocumentationTool.Client.Shared.FormFactorForm.TypeInference.CreateInputNumber_9(__builder2, 103, 104, "form-control", 105, 
#nullable restore
#line 53 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\FormFactorForm.razor"
                                                            FormFactor.Depth

#line default
#line hidden
#nullable disable
                , 106, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => FormFactor.Depth = __value, FormFactor.Depth)), 107, () => FormFactor.Depth);
                __builder2.AddMarkupContent(108, "\r\n            ");
                __Blazor.DocumentationTool.Client.Shared.FormFactorForm.TypeInference.CreateValidationMessage_10(__builder2, 109, 110, 
#nullable restore
#line 54 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\FormFactorForm.razor"
                                      () => FormFactor.Depth

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(111, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(113, "\r\n\r\n    ");
                __builder2.OpenElement(114, "div");
                __builder2.AddAttribute(115, "class", "form-row");
                __builder2.AddMarkupContent(116, "\r\n        ");
                __builder2.OpenElement(117, "div");
                __builder2.AddAttribute(118, "class", "form-group");
                __builder2.AddMarkupContent(119, "\r\n            ");
                __builder2.AddMarkupContent(120, "<label>Weight</label>\r\n            ");
                __builder2.OpenElement(121, "div");
                __builder2.AddMarkupContent(122, "\r\n                ");
                __Blazor.DocumentationTool.Client.Shared.FormFactorForm.TypeInference.CreateInputNumber_11(__builder2, 123, 124, "form-control", 125, 
#nullable restore
#line 62 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\FormFactorForm.razor"
                                                                FormFactor.Weight

#line default
#line hidden
#nullable disable
                , 126, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => FormFactor.Weight = __value, FormFactor.Weight)), 127, () => FormFactor.Weight);
                __builder2.AddMarkupContent(128, "\r\n                ");
                __Blazor.DocumentationTool.Client.Shared.FormFactorForm.TypeInference.CreateValidationMessage_12(__builder2, 129, 130, 
#nullable restore
#line 63 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\FormFactorForm.razor"
                                          () => FormFactor.Weight

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(131, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(132, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(133, "\r\n        ");
                __builder2.OpenElement(134, "div");
                __builder2.AddAttribute(135, "class", "form-group col-md-4");
                __builder2.AddMarkupContent(136, "\r\n            ");
                __builder2.AddMarkupContent(137, "<label>Display measure</label>\r\n            ");
                __Blazor.DocumentationTool.Client.Shared.FormFactorForm.TypeInference.CreateInputSelect_13(__builder2, 138, 139, "form-control", 140, 
#nullable restore
#line 68 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\FormFactorForm.razor"
                                                            FormFactor.WeightMeasure

#line default
#line hidden
#nullable disable
                , 141, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => FormFactor.WeightMeasure = __value, FormFactor.WeightMeasure)), 142, () => FormFactor.WeightMeasure, 143, (__builder3) => {
                    __builder3.AddMarkupContent(144, "\r\n                ");
                    __builder3.AddMarkupContent(145, "<option value>Select measure...</option>\r\n                ");
                    __builder3.AddMarkupContent(146, "<option>g</option>\r\n                ");
                    __builder3.AddMarkupContent(147, "<option>kg</option>\r\n                ");
                    __builder3.AddMarkupContent(148, "<option>t</option>\r\n            ");
                }
                );
                __builder2.AddMarkupContent(149, "\r\n            ");
                __Blazor.DocumentationTool.Client.Shared.FormFactorForm.TypeInference.CreateValidationMessage_14(__builder2, 150, 151, 
#nullable restore
#line 74 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\FormFactorForm.razor"
                                      () => FormFactor.WeightMeasure

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(152, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(153, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(154, "\r\n\r\n    ");
                __builder2.OpenElement(155, "div");
                __builder2.AddAttribute(156, "class", "form-group");
                __builder2.AddMarkupContent(157, "\r\n        ");
                __builder2.AddMarkupContent(158, "<label>Description</label>\r\n        ");
                __builder2.OpenElement(159, "div");
                __builder2.AddMarkupContent(160, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(161);
                __builder2.AddAttribute(162, "class", "form-control");
                __builder2.AddAttribute(163, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 81 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\FormFactorForm.razor"
                                                              FormFactor.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(164, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => FormFactor.Description = __value, FormFactor.Description))));
                __builder2.AddAttribute(165, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => FormFactor.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(166, "\r\n            ");
                __Blazor.DocumentationTool.Client.Shared.FormFactorForm.TypeInference.CreateValidationMessage_15(__builder2, 167, 168, 
#nullable restore
#line 82 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\FormFactorForm.razor"
                                      () => FormFactor.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(169, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(170, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(171, "\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 88 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\FormFactorForm.razor"
       
    [Parameter] public FormFactor FormFactor { get; set; }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.DocumentationTool.Client.Shared.FormFactorForm
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
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_9<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_10<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_11<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_12<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_13<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_14<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_15<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
