#pragma checksum "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Router\RouterForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b97595f774d13fb73b743673598f6b45aa9e758"
// <auto-generated/>
#pragma warning disable 1591
namespace DocumentationTool.Client.Pages.Router
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
using DocumentationTool.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Shared.Tags;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Excel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Hardware;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Contacts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Infrastucture;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Software;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Sowftware;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Network;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Hardware;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Contacts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Information;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Network;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Router\RouterForm.razor"
using DocumentationTool.Client.Shared.PowerConsumerSH;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Router\RouterForm.razor"
using DocumentationTool.Client.Shared.GeneralSH;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Router\RouterForm.razor"
using DocumentationTool.Client.Shared.ModelSH;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Router\RouterForm.razor"
using DocumentationTool.Client.Shared.FormFactorSH;

#line default
#line hidden
#nullable disable
    public partial class RouterForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Routers</h3>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Router\RouterForm.razor"
                     RouterDevice

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Router\RouterForm.razor"
                                                  OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n\r\n        ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "form-group row");
                __builder2.AddMarkupContent(10, "\r\n            ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-md-8");
                __builder2.AddMarkupContent(13, "\r\n                ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "formInputModel");
                __builder2.AddMarkupContent(16, "\r\n                    ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "form-group row");
                __builder2.AddMarkupContent(19, "\r\n                        ");
                __builder2.AddMarkupContent(20, "<label class=\"col-md-2 col-form-label\">Routing protocol</label>\r\n                        ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "col-md-4");
                __builder2.AddMarkupContent(23, "\r\n                            ");
                __Blazor.DocumentationTool.Client.Pages.Router.RouterForm.TypeInference.CreateInputSelect_0(__builder2, 24, 25, "form-control form-control-sm", 26, 
#nullable restore
#line 17 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Router\RouterForm.razor"
                                                                                            RouterDevice.RoutingProtocol

#line default
#line hidden
#nullable disable
                , 27, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => RouterDevice.RoutingProtocol = __value, RouterDevice.RoutingProtocol)), 28, () => RouterDevice.RoutingProtocol, 29, (__builder3) => {
                    __builder3.AddMarkupContent(30, "\r\n                                ");
                    __builder3.AddMarkupContent(31, "<option value>Select protocol...</option>\r\n                                ");
                    __builder3.AddMarkupContent(32, "<option>RIP</option>\r\n                                ");
                    __builder3.AddMarkupContent(33, "<option>Static</option>\r\n                                ");
                    __builder3.AddMarkupContent(34, "<option>OSPF</option>\r\n                                ");
                    __builder3.AddMarkupContent(35, "<option>BGP</option>\r\n                                ");
                    __builder3.AddMarkupContent(36, "<option>IGRP/EGRP</option>\r\n                            ");
                }
                );
                __builder2.AddMarkupContent(37, "\r\n                            ");
                __Blazor.DocumentationTool.Client.Pages.Router.RouterForm.TypeInference.CreateValidationMessage_1(__builder2, 38, 39, 
#nullable restore
#line 25 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Router\RouterForm.razor"
                                                      () => RouterDevice.RoutingProtocol

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(40, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n\r\n\r\n                    ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "form-group row");
                __builder2.AddMarkupContent(45, "\r\n                        ");
                __builder2.AddMarkupContent(46, "<label class=\"col-md-2 col-form-label\">Gateway address</label>\r\n                        ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "col-md-4 ");
                __builder2.AddMarkupContent(49, "\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(50);
                __builder2.AddAttribute(51, "class", "form-control form-control-sm");
                __builder2.AddAttribute(52, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Router\RouterForm.razor"
                                                                                          RouterDevice.GatewayAddress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => RouterDevice.GatewayAddress = __value, RouterDevice.GatewayAddress))));
                __builder2.AddAttribute(54, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => RouterDevice.GatewayAddress));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(55, "\r\n                            ");
                __Blazor.DocumentationTool.Client.Pages.Router.RouterForm.TypeInference.CreateValidationMessage_2(__builder2, 56, 57, 
#nullable restore
#line 34 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Router\RouterForm.razor"
                                                      () => RouterDevice.GatewayAddress

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(58, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n\r\n                    ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "form-group row");
                __builder2.AddMarkupContent(63, "\r\n                        ");
                __builder2.AddMarkupContent(64, "<label class=\"col-md-2 col-form-label\">Description</label>\r\n                        ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "col-md-4 ");
                __builder2.AddMarkupContent(67, "\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(68);
                __builder2.AddAttribute(69, "class", "form-control");
                __builder2.AddAttribute(70, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Router\RouterForm.razor"
                                                                              RouterDevice.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(71, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => RouterDevice.Description = __value, RouterDevice.Description))));
                __builder2.AddAttribute(72, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => RouterDevice.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(73, "\r\n                            ");
                __Blazor.DocumentationTool.Client.Pages.Router.RouterForm.TypeInference.CreateValidationMessage_3(__builder2, 74, 75, 
#nullable restore
#line 42 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Router\RouterForm.razor"
                                                      () => RouterDevice.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(76, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n\r\n        ");
                __builder2.OpenComponent<DocumentationTool.Client.Shared.ModelSH.ModelForm>(82);
                __builder2.AddAttribute(83, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DocumentationTool.Shared.Entities.Hardware.Model>(
#nullable restore
#line 49 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Router\RouterForm.razor"
                          Model

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(84, "\r\n        ");
                __builder2.OpenComponent<DocumentationTool.Client.Shared.FormFactorSH.FormFactorForm>(85);
                __builder2.AddAttribute(86, "FormFactor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DocumentationTool.Shared.Entities.Shared.FormFactor>(
#nullable restore
#line 50 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Router\RouterForm.razor"
                                    FormFactor

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(87, "\r\n        ");
                __builder2.OpenComponent<DocumentationTool.Client.Shared.PowerConsumerSH.PowerConsumerForm>(88);
                __builder2.AddAttribute(89, "PowerConsumer", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DocumentationTool.Shared.Entities.Shared.PowerConsumer>(
#nullable restore
#line 51 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Router\RouterForm.razor"
                                          PowerConsumer

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(90, "\r\n        ");
                __builder2.OpenComponent<DocumentationTool.Client.Shared.GeneralSH.GeneralForm>(91);
                __builder2.AddAttribute(92, "General", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DocumentationTool.Shared.Entities.Hardware.General>(
#nullable restore
#line 52 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Router\RouterForm.razor"
                              General

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(93, "\r\n\r\n        ");
                __builder2.AddMarkupContent(94, "<button class=\"btn btn-primary\" type=\"submit\">Save Changes</button>\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Pages\Router\RouterForm.razor"
       
    [Parameter] public RouterDevice RouterDevice { get; set; }
    [Parameter] public Model Model { get; set; }
    [Parameter] public General General { get; set; }
    [Parameter] public FormFactor FormFactor { get; set; }
    [Parameter] public PowerConsumer PowerConsumer { get; set; }
    [Parameter] public EventCallback OnValidSubmit { get; set; }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.DocumentationTool.Client.Pages.Router.RouterForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
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
    }
}
#pragma warning restore 1591
