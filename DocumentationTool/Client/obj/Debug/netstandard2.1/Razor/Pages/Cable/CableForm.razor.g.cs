#pragma checksum "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Cable\CableForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8b543d37f9bea1c2916f9d3217cb0bff5aaa242"
// <auto-generated/>
#pragma warning disable 1591
namespace DocumentationTool.Client.Pages.Cable
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
#line 1 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Cable\CableForm.razor"
using DocumentationTool.Client.Shared.GeneralSH;

#line default
#line hidden
#nullable disable
    public partial class CableForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 4 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Cable\CableForm.razor"
                 Cable

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 4 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Cable\CableForm.razor"
                                       OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n   \r\n    ");
                __builder2.OpenComponent<DocumentationTool.Client.Shared.GeneralSH.GeneralForm>(5);
                __builder2.AddAttribute(6, "General", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DocumentationTool.Shared.Entities.Hardware.General>(
#nullable restore
#line 6 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Cable\CableForm.razor"
                          General

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n\r\n    ");
                __builder2.AddMarkupContent(8, "<h3>Cable</h3>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n    ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-group row");
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col-md-8");
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "formInputModel");
                __builder2.AddMarkupContent(19, "\r\n\r\n                ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group row");
                __builder2.AddMarkupContent(22, "\r\n                    ");
                __builder2.AddMarkupContent(23, "<label class=\"col-md-2 col-form-label\">Type</label>\r\n                    ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "col-md-4 ");
                __builder2.AddMarkupContent(26, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(27);
                __builder2.AddAttribute(28, "class", "form-control form-control-sm");
                __builder2.AddAttribute(29, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Cable\CableForm.razor"
                                                                                      Cable.CableType

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Cable.CableType = __value, Cable.CableType))));
                __builder2.AddAttribute(31, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Cable.CableType));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\r\n                        ");
                __Blazor.DocumentationTool.Client.Pages.Cable.CableForm.TypeInference.CreateValidationMessage_0(__builder2, 33, 34, 
#nullable restore
#line 18 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Cable\CableForm.razor"
                                                  () => Cable.CableType

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(35, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n\r\n                ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "form-group row");
                __builder2.AddMarkupContent(40, "\r\n                    ");
                __builder2.AddMarkupContent(41, "<label class=\"col-md-2 col-form-label\">Lenght </label>\r\n                    ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "col-md-4");
                __builder2.AddMarkupContent(44, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(45);
                __builder2.AddAttribute(46, "class", "form-control form-control-sm");
                __builder2.AddAttribute(47, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Cable\CableForm.razor"
                                                                                      Cable.CableLenght

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Cable.CableLenght = __value, Cable.CableLenght))));
                __builder2.AddAttribute(49, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Cable.CableLenght));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n                        ");
                __Blazor.DocumentationTool.Client.Pages.Cable.CableForm.TypeInference.CreateValidationMessage_1(__builder2, 51, 52, 
#nullable restore
#line 26 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Cable\CableForm.razor"
                                                  () => Cable.CableLenght

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(53, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n\r\n                    ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "col-md-3");
                __builder2.AddMarkupContent(57, "\r\n                        ");
                __Blazor.DocumentationTool.Client.Pages.Cable.CableForm.TypeInference.CreateInputSelect_2(__builder2, 58, 59, "form-control form-control-sm", 60, 
#nullable restore
#line 30 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Cable\CableForm.razor"
                                                                                        Cable.CableLenghtDimensions

#line default
#line hidden
#nullable disable
                , 61, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Cable.CableLenghtDimensions = __value, Cable.CableLenghtDimensions)), 62, () => Cable.CableLenghtDimensions, 63, (__builder3) => {
                    __builder3.AddMarkupContent(64, "\r\n                            ");
                    __builder3.AddMarkupContent(65, "<option value>Select measure...</option>\r\n                            ");
                    __builder3.AddMarkupContent(66, "<option>cm</option>\r\n                            ");
                    __builder3.AddMarkupContent(67, "<option>foot</option>\r\n                            ");
                    __builder3.AddMarkupContent(68, "<option>inch</option>\r\n                            ");
                    __builder3.AddMarkupContent(69, "<option>m</option>\r\n                            ");
                    __builder3.AddMarkupContent(70, "<option>mm</option>\r\n                        ");
                }
                );
                __builder2.AddMarkupContent(71, "\r\n                        ");
                __Blazor.DocumentationTool.Client.Pages.Cable.CableForm.TypeInference.CreateValidationMessage_3(__builder2, 72, 73, 
#nullable restore
#line 38 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Cable\CableForm.razor"
                                                  () => Cable.CableLenghtDimensions

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(74, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n\r\n                ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "form-group row");
                __builder2.AddMarkupContent(79, "\r\n                    ");
                __builder2.AddMarkupContent(80, "<label class=\"col-md-2 col-form-label\">Color</label>\r\n                    ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "col-md-4 ");
                __builder2.AddMarkupContent(83, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(84);
                __builder2.AddAttribute(85, "class", "form-control form-control-sm");
                __builder2.AddAttribute(86, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Cable\CableForm.razor"
                                                                                      Cable.Color

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(87, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Cable.Color = __value, Cable.Color))));
                __builder2.AddAttribute(88, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Cable.Color));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(89, "\r\n                        ");
                __Blazor.DocumentationTool.Client.Pages.Cable.CableForm.TypeInference.CreateValidationMessage_4(__builder2, 90, 91, 
#nullable restore
#line 46 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Cable\CableForm.razor"
                                                  () => Cable.Color

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(92, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n\r\n                ");
                __builder2.OpenElement(95, "div");
                __builder2.AddAttribute(96, "class", "form-group row");
                __builder2.AddMarkupContent(97, "\r\n                    ");
                __builder2.AddMarkupContent(98, "<label class=\"col-md-2 col-form-label\">Occupancy</label>\r\n                    ");
                __builder2.OpenElement(99, "div");
                __builder2.AddAttribute(100, "class", "col-md-4 ");
                __builder2.AddMarkupContent(101, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(102);
                __builder2.AddAttribute(103, "class", "form-control form-control-sm");
                __builder2.AddAttribute(104, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Cable\CableForm.razor"
                                                                                      Cable.Occupancy

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(105, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Cable.Occupancy = __value, Cable.Occupancy))));
                __builder2.AddAttribute(106, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Cable.Occupancy));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(107, "\r\n                        ");
                __Blazor.DocumentationTool.Client.Pages.Cable.CableForm.TypeInference.CreateValidationMessage_5(__builder2, 108, 109, 
#nullable restore
#line 54 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Cable\CableForm.razor"
                                                  () => Cable.Occupancy

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(110, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(111, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\r\n\r\n                ");
                __builder2.OpenElement(113, "div");
                __builder2.AddAttribute(114, "class", "form-group row");
                __builder2.AddMarkupContent(115, "\r\n                    ");
                __builder2.AddMarkupContent(116, "<label class=\"col-md-2 col-form-label\">Fibers/leads</label>\r\n                    ");
                __builder2.OpenElement(117, "div");
                __builder2.AddAttribute(118, "class", "col-md-4 ");
                __builder2.AddMarkupContent(119, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(120);
                __builder2.AddAttribute(121, "class", "form-control form-control-sm");
                __builder2.AddAttribute(122, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 61 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Cable\CableForm.razor"
                                                                                      Cable.FibLeads

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(123, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Cable.FibLeads = __value, Cable.FibLeads))));
                __builder2.AddAttribute(124, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Cable.FibLeads));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(125, "\r\n                        ");
                __Blazor.DocumentationTool.Client.Pages.Cable.CableForm.TypeInference.CreateValidationMessage_6(__builder2, 126, 127, 
#nullable restore
#line 62 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Cable\CableForm.razor"
                                                  () => Cable.FibLeads

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(128, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(129, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(130, "\r\n\r\n                ");
                __builder2.OpenElement(131, "div");
                __builder2.AddAttribute(132, "class", "form-group row");
                __builder2.AddMarkupContent(133, "\r\n                    ");
                __builder2.AddMarkupContent(134, "<label class=\"col-md-2 col-form-label\">Description</label>\r\n                    ");
                __builder2.OpenElement(135, "div");
                __builder2.AddAttribute(136, "class", "col-md-7 ");
                __builder2.AddMarkupContent(137, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(138);
                __builder2.AddAttribute(139, "class", "form-control");
                __builder2.AddAttribute(140, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 69 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Cable\CableForm.razor"
                                                                          Cable.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(141, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Cable.Description = __value, Cable.Description))));
                __builder2.AddAttribute(142, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Cable.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(143, "\r\n                        ");
                __Blazor.DocumentationTool.Client.Pages.Cable.CableForm.TypeInference.CreateValidationMessage_7(__builder2, 144, 145, 
#nullable restore
#line 70 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Cable\CableForm.razor"
                                                  () => Cable.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(146, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(147, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(148, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(149, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(150, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(151, "\r\n\r\n    ");
                __builder2.AddMarkupContent(152, "<button class=\"btn btn-primary\" type=\"submit\">Save Changes</button>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Pages\Cable\CableForm.razor"
       
    [Parameter] public Cable Cable { get; set; }
    [Parameter] public General General { get; set; }
    [Parameter] public EventCallback OnValidSubmit { get; set; }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.DocumentationTool.Client.Pages.Cable.CableForm
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
    }
}
#pragma warning restore 1591