#pragma checksum "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dec8273325308a73d80f990826c1dfd62b8e4958"
// <auto-generated/>
#pragma warning disable 1591
namespace DocumentationTool.Client.Shared.HostAddressSH
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
    public partial class HostAddressForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Create</h3>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressForm.razor"
                 HostAddress

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
                __builder2.AddAttribute(8, "class", "form-group row pt-4");
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
                __builder2.AddMarkupContent(19, "<label class=\"col-sm-2 col-form-label\">Type</label>\r\n                    ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "col-sm-4");
                __builder2.AddMarkupContent(22, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "class", "form-control form-control-sm");
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressForm.razor"
                                                                                      HostAddress.Type

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HostAddress.Type = __value, HostAddress.Type))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => HostAddress.Type));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n                        ");
                __Blazor.DocumentationTool.Client.Shared.HostAddressSH.HostAddressForm.TypeInference.CreateValidationMessage_0(__builder2, 29, 30, 
#nullable restore
#line 15 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressForm.razor"
                                                  () => HostAddress.Type

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
                __builder2.AddMarkupContent(37, "<label class=\"col-sm-2 col-form-label\">Address allocation</label>\r\n                    ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "col-sm-4");
                __builder2.AddMarkupContent(40, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(41);
                __builder2.AddAttribute(42, "class", "form-control form-control-sm");
                __builder2.AddAttribute(43, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressForm.razor"
                                                                                      HostAddress.AddressAllocation

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HostAddress.AddressAllocation = __value, HostAddress.AddressAllocation))));
                __builder2.AddAttribute(45, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => HostAddress.AddressAllocation));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n                        ");
                __Blazor.DocumentationTool.Client.Shared.HostAddressSH.HostAddressForm.TypeInference.CreateValidationMessage_1(__builder2, 47, 48, 
#nullable restore
#line 23 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressForm.razor"
                                                  () => HostAddress.AddressAllocation

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
                __builder2.AddMarkupContent(55, "<label class=\"col-sm-2 col-form-label\">Hostname</label>\r\n                    ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "col-sm-4");
                __builder2.AddMarkupContent(58, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(59);
                __builder2.AddAttribute(60, "class", "form-control form-control-sm");
                __builder2.AddAttribute(61, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressForm.razor"
                                                                                      HostAddress.HostName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HostAddress.HostName = __value, HostAddress.HostName))));
                __builder2.AddAttribute(63, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => HostAddress.HostName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(64, "\r\n                        ");
                __Blazor.DocumentationTool.Client.Shared.HostAddressSH.HostAddressForm.TypeInference.CreateValidationMessage_2(__builder2, 65, 66, 
#nullable restore
#line 31 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressForm.razor"
                                                  () => HostAddress.HostName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(67, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n\r\n");
#nullable restore
#line 35 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressForm.razor"
                 if (LayerThreeNets != null)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(70, "                    ");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "form-group row");
                __builder2.AddMarkupContent(73, "\r\n                        ");
                __builder2.AddMarkupContent(74, "<label class=\"col-sm-2 col-form-label\">Net Assignment</label>\r\n                        ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "col-sm-4");
                __builder2.AddMarkupContent(77, "\r\n                            ");
                __builder2.OpenElement(78, "select");
                __builder2.AddAttribute(79, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressForm.razor"
                                                () => LoadIps()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(80, "class", "form-control form-control-sm");
                __builder2.AddAttribute(81, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 40 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressForm.razor"
                                                                                                               LayerThreeNet

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(82, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => LayerThreeNet = __value, LayerThreeNet));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(83, "\r\n");
#nullable restore
#line 41 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressForm.razor"
                                 foreach (var item in LayerThreeNets)
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(84, "                                    ");
                __builder2.OpenElement(85, "option");
                __builder2.AddAttribute(86, "value", 
#nullable restore
#line 43 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressForm.razor"
                                                    item.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(87, 
#nullable restore
#line 43 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressForm.razor"
                                                              item.General.Title

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n");
#nullable restore
#line 44 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressForm.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(89, "                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n");
#nullable restore
#line 48 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressForm.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressForm.razor"
                 if (iPLists != null)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(93, "                    ");
                __builder2.OpenElement(94, "div");
                __builder2.AddAttribute(95, "class", "form-group row");
                __builder2.AddMarkupContent(96, "\r\n                        ");
                __builder2.AddMarkupContent(97, "<label class=\"col-sm-2 col-form-label\">Address</label>\r\n                        ");
                __builder2.OpenElement(98, "div");
                __builder2.AddAttribute(99, "class", "col-sm-4");
                __builder2.AddMarkupContent(100, "\r\n                            ");
                __builder2.OpenElement(101, "select");
                __builder2.AddAttribute(102, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressForm.razor"
                                                () => LoadIP()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(103, "class", "form-control form-control-sm");
                __builder2.AddAttribute(104, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 54 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressForm.razor"
                                                                                                              IpId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(105, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => IpId = __value, IpId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(106, "\r\n");
#nullable restore
#line 55 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressForm.razor"
                                 foreach (var item in iPLists)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressForm.razor"
                                     if (HostAddress.NetAssignment != null &&
                                        HostAddress.NetAssignment.Id == item.LayerThreeNetId)
                                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(107, "                                        ");
                __builder2.OpenElement(108, "option");
                __builder2.AddAttribute(109, "value", 
#nullable restore
#line 60 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressForm.razor"
                                                        item.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(110, 
#nullable restore
#line 60 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressForm.razor"
                                                                  item.IpAddress

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(111, "\r\n");
#nullable restore
#line 61 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressForm.razor"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressForm.razor"
                                     
                                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(112, "                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(113, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\r\n");
#nullable restore
#line 66 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressForm.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(116, "                    ");
                __builder2.OpenElement(117, "div");
                __builder2.AddAttribute(118, "class", "form-group row");
                __builder2.AddMarkupContent(119, "\r\n                        ");
                __builder2.AddMarkupContent(120, "<label class=\"col-sm-2 col-form-label\">Address</label>\r\n                        ");
                __builder2.OpenElement(121, "div");
                __builder2.AddAttribute(122, "class", "col-sm-4");
                __builder2.AddMarkupContent(123, "\r\n                            ");
                __builder2.OpenElement(124, "input");
                __builder2.AddAttribute(125, "disabled", true);
                __builder2.AddAttribute(126, "class", "form-control form-control-sm");
                __builder2.AddAttribute(127, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 72 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressForm.razor"
                                                                                         Broadcast

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(128, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Broadcast = __value, Broadcast));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(129, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(130, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(131, "\r\n");
#nullable restore
#line 75 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressForm.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(132, "                ");
                __builder2.OpenElement(133, "div");
                __builder2.AddAttribute(134, "class", "form-group row");
                __builder2.AddMarkupContent(135, "\r\n                    ");
                __builder2.AddMarkupContent(136, "<label class=\"col-sm-2 col-form-label\">Description</label>\r\n                    ");
                __builder2.OpenElement(137, "div");
                __builder2.AddAttribute(138, "class", "col-sm-7");
                __builder2.AddMarkupContent(139, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(140);
                __builder2.AddAttribute(141, "class", "form-control");
                __builder2.AddAttribute(142, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 79 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressForm.razor"
                                                                          HostAddress.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(143, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HostAddress.Description = __value, HostAddress.Description))));
                __builder2.AddAttribute(144, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => HostAddress.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(145, "\r\n                        ");
                __Blazor.DocumentationTool.Client.Shared.HostAddressSH.HostAddressForm.TypeInference.CreateValidationMessage_3(__builder2, 146, 147, 
#nullable restore
#line 80 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressForm.razor"
                                                  () => HostAddress.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(148, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(149, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(150, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(151, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(152, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(153, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 88 "B:\Documents\Final\DocumentationTool\DocumentationTool\Client\Shared\HostAddressSH\HostAddressForm.razor"
       
    [Parameter] public HostAddress HostAddress { get; set; }
    [Parameter] public string Device { get; set; }

    public List<LayerThreeNet> LayerThreeNets { get; set; }
    public List<IPList> iPLists { get; set; }

    public int LayerThreeNet { get; set; }
    public int IpId { get; set; }
    public string Broadcast { get; set; }

    protected override async Task OnInitializedAsync()
    {
        try
        {
            await LoadData();
        }
        catch (Exception ex)
        {

        }
    }

    private async Task LoadIP()
    {
        if(IpId != 0)
        {
            HostAddress.Address = await iplistRepository.GetIpListById(IpId);
        }
    }

    private async Task LoadIps()
    {
        if (LayerThreeNet != 0)
        {
            HostAddress.NetAssignment = await networkRepository.GetLayerThreeNet(LayerThreeNet);
            iPLists = await iplistRepository.GetIPlists(LayerThreeNet);
            if (Device == "switch" || Device == "router")
            {
                Broadcast = HostAddress.NetAssignment.Broadcast;
                iPLists = null;
            }
        }
    }

    private async Task LoadData()
    {
        LayerThreeNets = await networkRepository.GetAllLayerThreeNet();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INetworkRepository networkRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IIPListRepository iplistRepository { get; set; }
    }
}
namespace __Blazor.DocumentationTool.Client.Shared.HostAddressSH.HostAddressForm
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
    }
}
#pragma warning restore 1591