#pragma checksum "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\GeneralSH\GeneralForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b546e7a1b187e5dd878f5f22eb3e7b02519b0e55"
// <auto-generated/>
#pragma warning disable 1591
namespace DocumentationTool.Client.Shared.GeneralSH
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
#line 6 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Hardware;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Contacts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.Entities.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Excel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Hardware;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Shared.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Contacts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\_Imports.razor"
using DocumentationTool.Client.Repository.Infrastucture;

#line default
#line hidden
#nullable disable
    public partial class GeneralForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>General</h3>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 2 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\GeneralSH\GeneralForm.razor"
                 General

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
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
#line 10 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\GeneralSH\GeneralForm.razor"
                                                                                      General.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => General.Title = __value, General.Title))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => General.Title));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n                        ");
                __Blazor.DocumentationTool.Client.Shared.GeneralSH.GeneralForm.TypeInference.CreateValidationMessage_0(__builder2, 29, 30, 
#nullable restore
#line 11 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\GeneralSH\GeneralForm.razor"
                                                  () => General.Title

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
                __builder2.AddMarkupContent(37, "<label class=\"col-md-2 col-form-label\">Category</label>\r\n                    ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "col-md-4");
                __builder2.AddMarkupContent(40, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(41);
                __builder2.AddAttribute(42, "class", "form-control form-control-sm");
                __builder2.AddAttribute(43, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\GeneralSH\GeneralForm.razor"
                                                                                      General.Category

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => General.Category = __value, General.Category))));
                __builder2.AddAttribute(45, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => General.Category));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n                        ");
                __Blazor.DocumentationTool.Client.Shared.GeneralSH.GeneralForm.TypeInference.CreateValidationMessage_1(__builder2, 47, 48, 
#nullable restore
#line 19 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\GeneralSH\GeneralForm.razor"
                                                  () => General.Category

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(49, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n\r\n                ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "form-group row");
                __builder2.AddMarkupContent(54, "\r\n                    ");
                __builder2.AddMarkupContent(55, "<label class=\"col-md-2 col-form-label\">Purpose</label>\r\n                    ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "col-md-4");
                __builder2.AddMarkupContent(58, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(59);
                __builder2.AddAttribute(60, "class", "form-control form-control-sm");
                __builder2.AddAttribute(61, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\GeneralSH\GeneralForm.razor"
                                                                                      General.Purpose

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => General.Purpose = __value, General.Purpose))));
                __builder2.AddAttribute(63, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => General.Purpose));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(64, "\r\n                        ");
                __Blazor.DocumentationTool.Client.Shared.GeneralSH.GeneralForm.TypeInference.CreateValidationMessage_2(__builder2, 65, 66, 
#nullable restore
#line 27 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\GeneralSH\GeneralForm.razor"
                                                  () => General.Purpose

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(67, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n\r\n                ");
                __builder2.OpenElement(70, "div");
                __builder2.AddAttribute(71, "class", "form-group row");
                __builder2.AddMarkupContent(72, "\r\n                    ");
                __builder2.AddMarkupContent(73, "<label class=\"col-md-2 col-form-label\">Creatio date</label>\r\n                    ");
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "class", "col-md-4");
                __builder2.AddMarkupContent(76, "\r\n                        ");
                __builder2.OpenElement(77, "input");
                __builder2.AddAttribute(78, "disabled", "disabled");
                __builder2.AddAttribute(79, "read", true);
                __builder2.AddAttribute(80, "class", "form-control form-control-sm");
                __builder2.AddAttribute(81, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\GeneralSH\GeneralForm.razor"
                                                                                                     General.CreatioDate

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(82, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => General.CreatioDate = __value, General.CreatioDate));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n\r\n                ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "form-group row");
                __builder2.AddMarkupContent(88, "\r\n                    ");
                __builder2.AddMarkupContent(89, "<label class=\"col-md-2 col-form-label\">Date of Change</label>\r\n                    ");
                __builder2.OpenElement(90, "div");
                __builder2.AddAttribute(91, "class", "col-md-4");
                __builder2.AddMarkupContent(92, "\r\n                        ");
                __builder2.OpenElement(93, "input");
                __builder2.AddAttribute(94, "disabled", "disabled");
                __builder2.AddAttribute(95, "class", "form-control form-control-sm");
                __builder2.AddAttribute(96, "readonly", true);
                __builder2.AddAttribute(97, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\GeneralSH\GeneralForm.razor"
                                                                                                         General.DateOfChange

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(98, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => General.DateOfChange = __value, General.DateOfChange));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n\r\n                ");
                __builder2.OpenElement(102, "div");
                __builder2.AddAttribute(103, "class", "form-group row");
                __builder2.AddMarkupContent(104, "\r\n                    ");
                __builder2.AddMarkupContent(105, "<label class=\"col-md-2 col-form-label\">Condition</label>\r\n                    ");
                __builder2.OpenElement(106, "div");
                __builder2.AddAttribute(107, "class", "col-md-4");
                __builder2.AddMarkupContent(108, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(109);
                __builder2.AddAttribute(110, "class", "form-control form-control-sm");
                __builder2.AddAttribute(111, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 50 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\GeneralSH\GeneralForm.razor"
                                                                                      General.Condition

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(112, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => General.Condition = __value, General.Condition))));
                __builder2.AddAttribute(113, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => General.Condition));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(114, "\r\n                        ");
                __Blazor.DocumentationTool.Client.Shared.GeneralSH.GeneralForm.TypeInference.CreateValidationMessage_3(__builder2, 115, 116, 
#nullable restore
#line 51 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\GeneralSH\GeneralForm.razor"
                                                  () => General.Condition

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(117, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(118, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(119, "\r\n                ");
                __builder2.OpenElement(120, "div");
                __builder2.AddAttribute(121, "class", "form-group row");
                __builder2.AddMarkupContent(122, "\r\n                    ");
                __builder2.AddMarkupContent(123, "<label class=\"col-md-2 col-form-label\">CMDB status</label>\r\n                    ");
                __builder2.OpenElement(124, "div");
                __builder2.AddAttribute(125, "class", "col-md-4");
                __builder2.AddMarkupContent(126, "\r\n                        ");
                __Blazor.DocumentationTool.Client.Shared.GeneralSH.GeneralForm.TypeInference.CreateInputSelect_4(__builder2, 127, 128, "form-control form-control-sm", 129, 
#nullable restore
#line 57 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\GeneralSH\GeneralForm.razor"
                                                                                        General.CMDBStatus

#line default
#line hidden
#nullable disable
                , 130, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => General.CMDBStatus = __value, General.CMDBStatus)), 131, () => General.CMDBStatus, 132, (__builder3) => {
                    __builder3.AddMarkupContent(133, "\r\n                            ");
                    __builder3.AddMarkupContent(134, "<option value>Select status...</option>\r\n                            ");
                    __builder3.AddMarkupContent(135, "<option>defect</option>\r\n                            ");
                    __builder3.AddMarkupContent(136, "<option>delivered</option>\r\n                            ");
                    __builder3.AddMarkupContent(137, "<option>in operation</option>\r\n                            ");
                    __builder3.AddMarkupContent(138, "<option>ordered</option>\r\n                            ");
                    __builder3.AddMarkupContent(139, "<option>planned</option>\r\n                        ");
                }
                );
                __builder2.AddMarkupContent(140, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(141, "\r\n                    ");
                __Blazor.DocumentationTool.Client.Shared.GeneralSH.GeneralForm.TypeInference.CreateValidationMessage_5(__builder2, 142, 143, 
#nullable restore
#line 66 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\GeneralSH\GeneralForm.razor"
                                              () => General.CMDBStatus

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(144, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(145, "\r\n\r\n                ");
                __builder2.OpenElement(146, "div");
                __builder2.AddAttribute(147, "class", "form-group row");
                __builder2.AddMarkupContent(148, "\r\n                    ");
                __builder2.AddMarkupContent(149, "<label class=\"col-md-2 col-form-label\">Object ID</label>\r\n                    ");
                __builder2.OpenElement(150, "div");
                __builder2.AddAttribute(151, "class", "col-md-4");
                __builder2.AddMarkupContent(152, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(153);
                __builder2.AddAttribute(154, "class", "form-control form-control-sm");
                __builder2.AddAttribute(155, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 72 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\GeneralSH\GeneralForm.razor"
                                                                                      General.ObjectID

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(156, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => General.ObjectID = __value, General.ObjectID))));
                __builder2.AddAttribute(157, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => General.ObjectID));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(158, "\r\n                        ");
                __Blazor.DocumentationTool.Client.Shared.GeneralSH.GeneralForm.TypeInference.CreateValidationMessage_6(__builder2, 159, 160, 
#nullable restore
#line 73 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\GeneralSH\GeneralForm.razor"
                                                  () => General.ObjectID

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(161, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(162, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(163, "\r\n\r\n                ");
                __builder2.OpenElement(164, "div");
                __builder2.AddAttribute(165, "class", "form-group row");
                __builder2.AddMarkupContent(166, "\r\n                    ");
                __builder2.AddMarkupContent(167, "<label class=\"col-md-2 col-form-label\">Onject type</label>\r\n                    ");
                __builder2.OpenElement(168, "div");
                __builder2.AddAttribute(169, "class", "col-md-4");
                __builder2.AddMarkupContent(170, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(171);
                __builder2.AddAttribute(172, "class", "form-control form-control-sm");
                __builder2.AddAttribute(173, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 80 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\GeneralSH\GeneralForm.razor"
                                                                                      General.ObjectType

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(174, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => General.ObjectType = __value, General.ObjectType))));
                __builder2.AddAttribute(175, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => General.ObjectType));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(176, "\r\n                        ");
                __Blazor.DocumentationTool.Client.Shared.GeneralSH.GeneralForm.TypeInference.CreateValidationMessage_7(__builder2, 177, 178, 
#nullable restore
#line 81 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\GeneralSH\GeneralForm.razor"
                                                  () => General.ObjectType

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(179, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(180, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(181, "\r\n\r\n                ");
                __builder2.OpenElement(182, "div");
                __builder2.AddAttribute(183, "class", "form-group row");
                __builder2.AddMarkupContent(184, "\r\n                    ");
                __builder2.AddMarkupContent(185, "<label class=\"col-md-2 col-form-label\">SYSID</label>\r\n                    ");
                __builder2.OpenElement(186, "div");
                __builder2.AddAttribute(187, "class", "col-md-4");
                __builder2.AddMarkupContent(188, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(189);
                __builder2.AddAttribute(190, "class", "form-control form-control-sm");
                __builder2.AddAttribute(191, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 88 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\GeneralSH\GeneralForm.razor"
                                                                                      General.SYSID

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(192, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => General.SYSID = __value, General.SYSID))));
                __builder2.AddAttribute(193, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => General.SYSID));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(194, "\r\n                        ");
                __Blazor.DocumentationTool.Client.Shared.GeneralSH.GeneralForm.TypeInference.CreateValidationMessage_8(__builder2, 195, 196, 
#nullable restore
#line 89 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\GeneralSH\GeneralForm.razor"
                                                  () => General.SYSID

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(197, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(198, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(199, "\r\n\r\n                ");
                __builder2.OpenElement(200, "div");
                __builder2.AddAttribute(201, "class", "form-group row");
                __builder2.AddMarkupContent(202, "\r\n                    ");
                __builder2.AddMarkupContent(203, "<label class=\"col-md-2 col-form-label\">Description</label>\r\n                    ");
                __builder2.OpenElement(204, "div");
                __builder2.AddAttribute(205, "class", "col-md-7");
                __builder2.AddMarkupContent(206, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(207);
                __builder2.AddAttribute(208, "class", "form-control");
                __builder2.AddAttribute(209, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 96 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\GeneralSH\GeneralForm.razor"
                                                                          General.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(210, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => General.Description = __value, General.Description))));
                __builder2.AddAttribute(211, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => General.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(212, "\r\n                        ");
                __Blazor.DocumentationTool.Client.Shared.GeneralSH.GeneralForm.TypeInference.CreateValidationMessage_9(__builder2, 213, 214, 
#nullable restore
#line 97 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\GeneralSH\GeneralForm.razor"
                                                  () => General.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(215, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(216, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(217, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(218, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(219, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(220, "\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 106 "B:\Documents\Github\CV\DocumentationTool\DocumentationTool\Client\Shared\GeneralSH\GeneralForm.razor"
       
    [Parameter] public General General { get; set; }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.DocumentationTool.Client.Shared.GeneralSH.GeneralForm
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