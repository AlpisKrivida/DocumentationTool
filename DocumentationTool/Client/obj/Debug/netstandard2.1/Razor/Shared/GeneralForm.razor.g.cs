#pragma checksum "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\GeneralForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c5feedec5ddd9055a0080bf88cb76ff9ecd31a5"
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
    public partial class GeneralForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>General Form</h3>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 2 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\GeneralForm.razor"
                 General

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
#line 8 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\GeneralForm.razor"
                                                          General.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => General.Title = __value, General.Title))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => General.Title));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n            ");
                __Blazor.DocumentationTool.Client.Shared.GeneralForm.TypeInference.CreateValidationMessage_0(__builder2, 19, 20, 
#nullable restore
#line 9 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\GeneralForm.razor"
                                      () => General.Title

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
                __builder2.AddMarkupContent(27, "<label>Category</label>\r\n        ");
                __builder2.OpenElement(28, "div");
                __builder2.AddMarkupContent(29, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "class", "form-control");
                __builder2.AddAttribute(32, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\GeneralForm.razor"
                                                          General.Category

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => General.Category = __value, General.Category))));
                __builder2.AddAttribute(34, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => General.Category));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n            ");
                __Blazor.DocumentationTool.Client.Shared.GeneralForm.TypeInference.CreateValidationMessage_1(__builder2, 36, 37, 
#nullable restore
#line 17 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\GeneralForm.razor"
                                      () => General.Category

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
                __builder2.AddAttribute(42, "class", "form-group");
                __builder2.AddMarkupContent(43, "\r\n        ");
                __builder2.AddMarkupContent(44, "<label>Purpose</label>\r\n        ");
                __builder2.OpenElement(45, "div");
                __builder2.AddMarkupContent(46, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(47);
                __builder2.AddAttribute(48, "class", "form-control");
                __builder2.AddAttribute(49, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\GeneralForm.razor"
                                                          General.Purpose

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => General.Purpose = __value, General.Purpose))));
                __builder2.AddAttribute(51, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => General.Purpose));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n            ");
                __Blazor.DocumentationTool.Client.Shared.GeneralForm.TypeInference.CreateValidationMessage_2(__builder2, 53, 54, 
#nullable restore
#line 25 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\GeneralForm.razor"
                                      () => General.Purpose

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(55, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n\r\n    ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "form-group");
                __builder2.AddMarkupContent(60, "\r\n        ");
                __builder2.AddMarkupContent(61, "<label>Condition</label>\r\n        ");
                __builder2.OpenElement(62, "div");
                __builder2.AddMarkupContent(63, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(64);
                __builder2.AddAttribute(65, "class", "form-control");
                __builder2.AddAttribute(66, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\GeneralForm.razor"
                                                          General.Condition

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(67, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => General.Condition = __value, General.Condition))));
                __builder2.AddAttribute(68, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => General.Condition));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(69, "\r\n            ");
                __Blazor.DocumentationTool.Client.Shared.GeneralForm.TypeInference.CreateValidationMessage_3(__builder2, 70, 71, 
#nullable restore
#line 33 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\GeneralForm.razor"
                                      () => General.Condition

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(72, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n    ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "form-group");
                __builder2.AddMarkupContent(77, "\r\n        ");
                __builder2.AddMarkupContent(78, "<label>CMDB status</label>\r\n        ");
                __Blazor.DocumentationTool.Client.Shared.GeneralForm.TypeInference.CreateInputSelect_4(__builder2, 79, 80, "form-control", 81, 
#nullable restore
#line 38 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\GeneralForm.razor"
                                                        General.CMDBStatus

#line default
#line hidden
#nullable disable
                , 82, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => General.CMDBStatus = __value, General.CMDBStatus)), 83, () => General.CMDBStatus, 84, (__builder3) => {
                    __builder3.AddMarkupContent(85, "\r\n            ");
                    __builder3.AddMarkupContent(86, "<option value>Select measure...</option>\r\n            ");
                    __builder3.AddMarkupContent(87, "<option>defect</option>\r\n            ");
                    __builder3.AddMarkupContent(88, "<option>delivered</option>\r\n            ");
                    __builder3.AddMarkupContent(89, "<option>in operation</option>\r\n            ");
                    __builder3.AddMarkupContent(90, "<option>ordered</option>\r\n            ");
                    __builder3.AddMarkupContent(91, "<option>planned</option>\r\n        ");
                }
                );
                __builder2.AddMarkupContent(92, "\r\n        ");
                __Blazor.DocumentationTool.Client.Shared.GeneralForm.TypeInference.CreateValidationMessage_5(__builder2, 93, 94, 
#nullable restore
#line 46 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\GeneralForm.razor"
                                  () => General.CMDBStatus

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(95, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n\r\n    ");
                __builder2.OpenElement(97, "div");
                __builder2.AddAttribute(98, "class", "form-group");
                __builder2.AddMarkupContent(99, "\r\n        ");
                __builder2.AddMarkupContent(100, "<label>Object ID</label>\r\n        ");
                __builder2.OpenElement(101, "div");
                __builder2.AddMarkupContent(102, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(103);
                __builder2.AddAttribute(104, "class", "form-control");
                __builder2.AddAttribute(105, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 52 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\GeneralForm.razor"
                                                          General.ObjectID

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(106, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => General.ObjectID = __value, General.ObjectID))));
                __builder2.AddAttribute(107, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => General.ObjectID));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(108, "\r\n            ");
                __Blazor.DocumentationTool.Client.Shared.GeneralForm.TypeInference.CreateValidationMessage_6(__builder2, 109, 110, 
#nullable restore
#line 53 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\GeneralForm.razor"
                                      () => General.ObjectID

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
                __builder2.AddAttribute(115, "class", "form-group");
                __builder2.AddMarkupContent(116, "\r\n        ");
                __builder2.AddMarkupContent(117, "<label>Onject type</label>\r\n        ");
                __builder2.OpenElement(118, "div");
                __builder2.AddMarkupContent(119, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(120);
                __builder2.AddAttribute(121, "class", "form-control");
                __builder2.AddAttribute(122, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 60 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\GeneralForm.razor"
                                                          General.ObjectType

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(123, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => General.ObjectType = __value, General.ObjectType))));
                __builder2.AddAttribute(124, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => General.ObjectType));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(125, "\r\n            ");
                __Blazor.DocumentationTool.Client.Shared.GeneralForm.TypeInference.CreateValidationMessage_7(__builder2, 126, 127, 
#nullable restore
#line 61 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\GeneralForm.razor"
                                      () => General.ObjectType

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(128, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(129, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(130, "\r\n\r\n    ");
                __builder2.OpenElement(131, "div");
                __builder2.AddAttribute(132, "class", "form-group");
                __builder2.AddMarkupContent(133, "\r\n        ");
                __builder2.AddMarkupContent(134, "<label>SYSID</label>\r\n        ");
                __builder2.OpenElement(135, "div");
                __builder2.AddMarkupContent(136, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(137);
                __builder2.AddAttribute(138, "class", "form-control");
                __builder2.AddAttribute(139, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 68 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\GeneralForm.razor"
                                                          General.SYSID

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(140, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => General.SYSID = __value, General.SYSID))));
                __builder2.AddAttribute(141, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => General.SYSID));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(142, "\r\n            ");
                __Blazor.DocumentationTool.Client.Shared.GeneralForm.TypeInference.CreateValidationMessage_8(__builder2, 143, 144, 
#nullable restore
#line 69 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\GeneralForm.razor"
                                      () => General.SYSID

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(145, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(146, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(147, "\r\n\r\n    ");
                __builder2.OpenElement(148, "div");
                __builder2.AddAttribute(149, "class", "form-group");
                __builder2.AddMarkupContent(150, "\r\n        ");
                __builder2.AddMarkupContent(151, "<label>Description</label>\r\n        ");
                __builder2.OpenElement(152, "div");
                __builder2.AddMarkupContent(153, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(154);
                __builder2.AddAttribute(155, "class", "form-control");
                __builder2.AddAttribute(156, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 76 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\GeneralForm.razor"
                                                              General.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(157, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => General.Description = __value, General.Description))));
                __builder2.AddAttribute(158, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => General.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(159, "\r\n            ");
                __Blazor.DocumentationTool.Client.Shared.GeneralForm.TypeInference.CreateValidationMessage_9(__builder2, 160, 161, 
#nullable restore
#line 77 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\GeneralForm.razor"
                                      () => General.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(162, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(163, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(164, "\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "C:\Users\Alpis\source\repos\DocumentationTool\DocumentationTool\Client\Shared\GeneralForm.razor"
       
    [Parameter] public General General { get; set; }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.DocumentationTool.Client.Shared.GeneralForm
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
        public static void CreateInputSelect_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
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
        public static void CreateValidationMessage_9<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591