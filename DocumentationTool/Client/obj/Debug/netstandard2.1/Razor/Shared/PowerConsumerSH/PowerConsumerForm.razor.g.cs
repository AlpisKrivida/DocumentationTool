#pragma checksum "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerSH\PowerConsumerForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50cc678ebda65a02f1145da5e974f203a5c54d10"
// <auto-generated/>
#pragma warning disable 1591
namespace DocumentationTool.Client.Shared.PowerConsumerSH
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
    public partial class PowerConsumerForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Power Consumer</h3>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 2 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerSH\PowerConsumerForm.razor"
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
                __builder2.AddAttribute(8, "class", "form-group row");
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "col-md-8");
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "formInputModel");
                __builder2.AddMarkupContent(15, "\r\n                ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-group row");
                __builder2.AddMarkupContent(18, "\r\n                    ");
                __builder2.AddMarkupContent(19, "<label class=\"col-md-2 col-form-label\">Title</label>\r\n                    ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "col-md-4");
                __builder2.AddMarkupContent(22, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "class", "form-control form-control-sm");
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerSH\PowerConsumerForm.razor"
                                                                                      PowerConsumer.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => PowerConsumer.Title = __value, PowerConsumer.Title))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => PowerConsumer.Title));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n                        ");
                __Blazor.DocumentationTool.Client.Shared.PowerConsumerSH.PowerConsumerForm.TypeInference.CreateValidationMessage_0(__builder2, 29, 30, 
#nullable restore
#line 12 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerSH\PowerConsumerForm.razor"
                                                  () => PowerConsumer.Title

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(31, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n\r\n                ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "form-group row");
                __builder2.AddMarkupContent(36, "\r\n                    ");
                __builder2.AddMarkupContent(37, "<label class=\"col-md-2 col-form-label\">Active</label>\r\n                    ");
                __builder2.OpenElement(38, "div");
                __builder2.AddMarkupContent(39, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(40);
                __builder2.AddAttribute(41, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerSH\PowerConsumerForm.razor"
                                                     PowerConsumer.Active

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => PowerConsumer.Active = __value, PowerConsumer.Active))));
                __builder2.AddAttribute(43, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => PowerConsumer.Active));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n                        ");
                __Blazor.DocumentationTool.Client.Shared.PowerConsumerSH.PowerConsumerForm.TypeInference.CreateValidationMessage_1(__builder2, 45, 46, 
#nullable restore
#line 20 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerSH\PowerConsumerForm.razor"
                                                  () => PowerConsumer.Active

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(47, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n\r\n                ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "form-group row");
                __builder2.AddMarkupContent(52, "\r\n                    ");
                __builder2.AddMarkupContent(53, "<label class=\"col-md-2 col-form-label\">Manufactutrer</label>\r\n                    ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "col-md-4 ");
                __builder2.AddMarkupContent(56, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(57);
                __builder2.AddAttribute(58, "class", "form-control form-control-sm");
                __builder2.AddAttribute(59, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerSH\PowerConsumerForm.razor"
                                                                                      PowerConsumer.Manufacturer

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(60, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => PowerConsumer.Manufacturer = __value, PowerConsumer.Manufacturer))));
                __builder2.AddAttribute(61, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => PowerConsumer.Manufacturer));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\r\n                        ");
                __Blazor.DocumentationTool.Client.Shared.PowerConsumerSH.PowerConsumerForm.TypeInference.CreateValidationMessage_2(__builder2, 63, 64, 
#nullable restore
#line 28 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerSH\PowerConsumerForm.razor"
                                                  () => PowerConsumer.Manufacturer

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(65, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n\r\n                ");
                __builder2.OpenElement(68, "div");
                __builder2.AddAttribute(69, "class", "form-group row");
                __builder2.AddMarkupContent(70, "\r\n                    ");
                __builder2.AddMarkupContent(71, "<label class=\"col-md-2 col-form-label\">PowerModel</label>\r\n                    ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "col-md-4 ");
                __builder2.AddMarkupContent(74, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(75);
                __builder2.AddAttribute(76, "class", "form-control form-control-sm");
                __builder2.AddAttribute(77, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerSH\PowerConsumerForm.razor"
                                                                                      PowerConsumer.PowerModel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(78, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => PowerConsumer.PowerModel = __value, PowerConsumer.PowerModel))));
                __builder2.AddAttribute(79, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => PowerConsumer.PowerModel));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(80, "\r\n                        ");
                __Blazor.DocumentationTool.Client.Shared.PowerConsumerSH.PowerConsumerForm.TypeInference.CreateValidationMessage_3(__builder2, 81, 82, 
#nullable restore
#line 36 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerSH\PowerConsumerForm.razor"
                                                  () => PowerConsumer.PowerModel

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(83, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n\r\n                ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "form-group row");
                __builder2.AddMarkupContent(88, "\r\n                    ");
                __builder2.AddMarkupContent(89, "<label class=\"col-md-2 col-form-label\">Volt</label>\r\n                    ");
                __builder2.OpenElement(90, "div");
                __builder2.AddAttribute(91, "class", "col-md-4 ");
                __builder2.AddMarkupContent(92, "\r\n                        ");
                __Blazor.DocumentationTool.Client.Shared.PowerConsumerSH.PowerConsumerForm.TypeInference.CreateInputNumber_4(__builder2, 93, 94, "form-control form-control-sm", 95, 
#nullable restore
#line 43 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerSH\PowerConsumerForm.razor"
                                                                                        PowerConsumer.Volt

#line default
#line hidden
#nullable disable
                , 96, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => PowerConsumer.Volt = __value, PowerConsumer.Volt)), 97, () => PowerConsumer.Volt);
                __builder2.AddMarkupContent(98, "\r\n                        ");
                __Blazor.DocumentationTool.Client.Shared.PowerConsumerSH.PowerConsumerForm.TypeInference.CreateValidationMessage_5(__builder2, 99, 100, 
#nullable restore
#line 44 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerSH\PowerConsumerForm.razor"
                                                  () => PowerConsumer.Volt

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(101, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n\r\n                ");
                __builder2.OpenElement(104, "div");
                __builder2.AddAttribute(105, "class", "form-group row");
                __builder2.AddMarkupContent(106, "\r\n                    ");
                __builder2.AddMarkupContent(107, "<label class=\"col-md-2 col-form-label\">Watt</label>\r\n                    ");
                __builder2.OpenElement(108, "div");
                __builder2.AddAttribute(109, "class", "col-md-4");
                __builder2.AddMarkupContent(110, "\r\n                        ");
                __Blazor.DocumentationTool.Client.Shared.PowerConsumerSH.PowerConsumerForm.TypeInference.CreateInputNumber_6(__builder2, 111, 112, "form-control form-control-sm", 113, 
#nullable restore
#line 51 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerSH\PowerConsumerForm.razor"
                                                                                        PowerConsumer.Watt

#line default
#line hidden
#nullable disable
                , 114, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => PowerConsumer.Watt = __value, PowerConsumer.Watt)), 115, () => PowerConsumer.Watt);
                __builder2.AddMarkupContent(116, "\r\n                        ");
                __Blazor.DocumentationTool.Client.Shared.PowerConsumerSH.PowerConsumerForm.TypeInference.CreateValidationMessage_7(__builder2, 117, 118, 
#nullable restore
#line 52 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerSH\PowerConsumerForm.razor"
                                                  () => PowerConsumer.Watt

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(119, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(120, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(121, "\r\n\r\n                ");
                __builder2.OpenElement(122, "div");
                __builder2.AddAttribute(123, "class", "form-group row");
                __builder2.AddMarkupContent(124, "\r\n                    ");
                __builder2.AddMarkupContent(125, "<label class=\"col-md-2 col-form-label\">Ampere</label>\r\n                    ");
                __builder2.OpenElement(126, "div");
                __builder2.AddAttribute(127, "class", "col-md-4");
                __builder2.AddMarkupContent(128, "\r\n                        ");
                __Blazor.DocumentationTool.Client.Shared.PowerConsumerSH.PowerConsumerForm.TypeInference.CreateInputNumber_8(__builder2, 129, 130, "form-control form-control-sm", 131, 
#nullable restore
#line 59 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerSH\PowerConsumerForm.razor"
                                                                                        PowerConsumer.Ampere

#line default
#line hidden
#nullable disable
                , 132, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => PowerConsumer.Ampere = __value, PowerConsumer.Ampere)), 133, () => PowerConsumer.Ampere);
                __builder2.AddMarkupContent(134, "\r\n                        ");
                __Blazor.DocumentationTool.Client.Shared.PowerConsumerSH.PowerConsumerForm.TypeInference.CreateValidationMessage_9(__builder2, 135, 136, 
#nullable restore
#line 60 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerSH\PowerConsumerForm.razor"
                                                  () => PowerConsumer.Ampere

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(137, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(138, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(139, "\r\n\r\n                ");
                __builder2.OpenElement(140, "div");
                __builder2.AddAttribute(141, "class", "form-group row");
                __builder2.AddMarkupContent(142, "\r\n                    ");
                __builder2.AddMarkupContent(143, "<label class=\"col-md-2 col-form-label\">BTU</label>\r\n                    ");
                __builder2.OpenElement(144, "div");
                __builder2.AddAttribute(145, "class", "col-md-4");
                __builder2.AddMarkupContent(146, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(147);
                __builder2.AddAttribute(148, "class", "form-control form-control-sm");
                __builder2.AddAttribute(149, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 67 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerSH\PowerConsumerForm.razor"
                                                                                      PowerConsumer.BTU

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(150, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => PowerConsumer.BTU = __value, PowerConsumer.BTU))));
                __builder2.AddAttribute(151, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => PowerConsumer.BTU));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(152, "\r\n                        ");
                __Blazor.DocumentationTool.Client.Shared.PowerConsumerSH.PowerConsumerForm.TypeInference.CreateValidationMessage_10(__builder2, 153, 154, 
#nullable restore
#line 68 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerSH\PowerConsumerForm.razor"
                                                  () => PowerConsumer.BTU

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(155, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(156, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(157, "\r\n\r\n                ");
                __builder2.OpenElement(158, "div");
                __builder2.AddAttribute(159, "class", "form-group row");
                __builder2.AddMarkupContent(160, "\r\n                    ");
                __builder2.AddMarkupContent(161, "<label class=\"col-md-2 col-form-label\">Description</label>\r\n                    ");
                __builder2.OpenElement(162, "div");
                __builder2.AddAttribute(163, "class", "col-md-7");
                __builder2.AddMarkupContent(164, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(165);
                __builder2.AddAttribute(166, "class", "form-control");
                __builder2.AddAttribute(167, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 75 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerSH\PowerConsumerForm.razor"
                                                                          PowerConsumer.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(168, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => PowerConsumer.Description = __value, PowerConsumer.Description))));
                __builder2.AddAttribute(169, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => PowerConsumer.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(170, "\r\n                        ");
                __Blazor.DocumentationTool.Client.Shared.PowerConsumerSH.PowerConsumerForm.TypeInference.CreateValidationMessage_11(__builder2, 171, 172, 
#nullable restore
#line 76 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerSH\PowerConsumerForm.razor"
                                                  () => PowerConsumer.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(173, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(174, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(175, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(176, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(177, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(178, "\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\PowerConsumerSH\PowerConsumerForm.razor"
       
    [Parameter] public PowerConsumer PowerConsumer { get; set; }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.DocumentationTool.Client.Shared.PowerConsumerSH.PowerConsumerForm
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
        public static void CreateInputNumber_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
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