#pragma checksum "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tfield\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "099a1f008aad76662ee2cffa5c51ae3ba298da79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tfield_Index), @"mvc.1.0.view", @"/Views/Tfield/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\_ViewImports.cshtml"
using OxyWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\_ViewImports.cshtml"
using OxyWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"099a1f008aad76662ee2cffa5c51ae3ba298da79", @"/Views/Tfield/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1083ec83a523b5769e737ebc5f0b2f10fdd7d201", @"/Views/_ViewImports.cshtml")]
    public class Views_Tfield_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OxyWeb.ViewModels.ViewField>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "5", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tfield\Index.cshtml"
  
    ViewData["Title"] = "Fields";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-md"">
    <div class=""row justify-content-between p-2 my-2 text-white rounded shadow-sm title-page"">
        <div class=""col-12 col-md-2"">
            <h5>Field</h5>
        </div>
        <div class=""col-12 col-md-2"">
            <div class=""row align-items-end"">
                <button class=""btn btn-primary"" id=""btn-create""><i class=""me-3 bi bi-plus-square""></i>Create</button>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-12"">
            <table id=""tableFull"" class=""table table-striped"" style=""width:100%"">
                <thead>
                    <tr>
                        <th>Nro.</th>
                        <th>Name</th>
                        <th width=""30%"">Actions</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 28 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tfield\Index.cshtml"
                     foreach (var item in Model.Lista)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 31 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tfield\Index.cshtml"
                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 32 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tfield\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                <div class=\"row text-center\">\r\n                                    <div class=\"col-12 col-md-4\">\r\n                                        <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1411, "\"", 1451, 1);
#nullable restore
#line 36 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tfield\Index.cshtml"
WriteAttributeValue("", 1419, Json.Serialize(item).ToString(), 1419, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                        <button type=""button"" class=""btn btn-secondary"" onclick=""Update(this)"">Update</button>
                                    </div>
                                    <div class=""col-12 col-md-4"">
                                        <input type=""hidden""");
            BeginWriteAttribute("value", " value=\"", 1756, "\"", 1796, 1);
#nullable restore
#line 40 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tfield\Index.cshtml"
WriteAttributeValue("", 1764, Json.Serialize(item).ToString(), 1764, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                        <button type=""button"" class=""btn btn-danger"" onclick=""Delete(this)"">Delete</button>
                                    </div>
                                    <div class=""col-12 col-md-4"">
                                        <button type=""button"" class=""btn btn-success""");
            BeginWriteAttribute("onclick", " onclick=\"", 2123, "\"", 2151, 3);
            WriteAttributeValue("", 2133, "GetItems(", 2133, 9, true);
#nullable restore
#line 44 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tfield\Index.cshtml"
WriteAttributeValue("", 2142, item.Id, 2142, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2150, ")", 2150, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Items</button>\r\n                                    </div>\r\n                                </div>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 49 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tfield\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>
    </div>
</div>
<div class=""modal fade"" id=""ModalVendor"" data-bs-backdrop=""static"" data-bs-keyboard=""false"" tabindex=""-1"" aria-labelledby=""NewVendorLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""NewVendorLabel""></h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                <div class=""row"">
                    <div class=""col-12"">
                        <div class=""form-group mb-3"">
                            <label for=""Pass"">Name</label>
                            ");
#nullable restore
#line 67 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tfield\Index.cshtml"
                       Write(Html.TextBoxFor(m => m.Modelo.Name, new { @class = "form-control mt-2", onkeyup = "lengthText(this, 20,'TxtLen')", onkeydown = "lengthText(this, 20,'TxtLen')", placeholder = "Enter your field Name" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <div class=\"form-text\"><strong id=\"TxtLen\">0</strong>/20</div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-12\">\r\n");
#nullable restore
#line 74 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tfield\Index.cshtml"
                         if (Model.Modelo.idRol == (int)OxyWeb.Enums.UserRol.Root)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""form-group"">
                                <label class=""control-label"">Rol</label>
                                <div class=""col-md-12 mt-2"">
                                    <select id=""Modelo_idRol"" name=""Modelo.idRol"" class=""form-select"" style=""width:100%"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "099a1f008aad76662ee2cffa5c51ae3ba298da7911015", async() => {
                WriteLiteral("Baker");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "099a1f008aad76662ee2cffa5c51ae3ba298da7912214", async() => {
                WriteLiteral("Schlumberger");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "099a1f008aad76662ee2cffa5c51ae3ba298da7913420", async() => {
                WriteLiteral("Hall");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "099a1f008aad76662ee2cffa5c51ae3ba298da7914618", async() => {
                WriteLiteral("Borets");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "099a1f008aad76662ee2cffa5c51ae3ba298da7915818", async() => {
                WriteLiteral("HDE");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </select>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 88 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tfield\Index.cshtml"
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tfield\Index.cshtml"
                       Write(Html.HiddenFor(m => m.Modelo.idRol));

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tfield\Index.cshtml"
                                                                
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"modal-footer\">\r\n                ");
#nullable restore
#line 97 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tfield\Index.cshtml"
           Write(Html.HiddenFor(m => m.Accion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 98 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tfield\Index.cshtml"
           Write(Html.HiddenFor(m => m.Modelo.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                
                <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn btn-primary"" id=""btn-save"">Save Changes</button>
            </div>
        </div>
    </div>
</div>
<div class=""modal fade"" id=""ModalList"" data-bs-backdrop=""static"" data-bs-keyboard=""false"" tabindex=""-1"" aria-labelledby=""NewCleaningLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title""> Wells for Field</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                <div class=""row"">
                    <div class=""col-12"" id=""ItemsForVendor""></div>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn bt");
            WriteLiteral(@"n-secondary"" data-bs-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn btn-primary"" id=""btn-save"">Save Changes</button>
            </div>
        </div>
    </div>
</div>
<div class=""toast"" role=""alert"" id=""ToastDelete"" aria-live=""assertive"" aria-atomic=""true"">
    <div class=""toast-body"">
        <p>want to delete <strong id=""nameDelete""></strong>?</p>
        <div class=""mt-2 pt-2 border-top"">
            <button type=""button"" class=""btn btn-primary btn-sm"" id=""btn-accept-delete"">Delete</button>
            <button type=""button"" class=""btn btn-secondary btn-sm"" data-bs-dismiss=""toast"">Cancel</button>
        </div>
    </div>
</div>
");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        var Modal = new bootstrap.Modal(document.getElementById('ModalVendor'), { keyboard: false });
        var ModalList = new bootstrap.Modal(document.getElementById('ModalList'), { keyboard: false });
        var Toast = new bootstrap.Toast(document.getElementById('ToastDelete'), { positionClass: 'toast-top-center' });

        $(document).ready(function () {
            LoadTable(""tableFull"");

            $(""#btn-create"").click(function () {
                $(""#NewVendorLabel"").text(""New Field"");
                $(""#Modelo_Id"").val("""");
                $(""#Modelo_Name"").val("""");
                $(""#Accion"").val(0);
                Modal.show();
            });

            $(""#btn-save"").click(function () {
                var response;
                var Parameters = {
                    Accion: parseInt($(""#Accion"").val()),
                    Modelo: {
                        name: $.trim($(""#Modelo_Name"").val()),
                        ");
                WriteLiteral("idRol: $(\"#Modelo_idRol\").val()\r\n                    }\r\n                };\r\n\r\n                if (Parameters.Accion == 0) {\r\n                    response = JSON.parse(CrudTable(\'");
#nullable restore
#line 161 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tfield\Index.cshtml"
                                                Write(Url.Action("Crud", "TField"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\', \"POST\", Parameters));\r\n                } else {\r\n                    Parameters[\'Modelo\'][\'Id\'] = parseInt($(\"#Modelo_Id\").val());\r\n                    response = JSON.parse(CrudTable(\'");
#nullable restore
#line 164 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tfield\Index.cshtml"
                                                Write(Url.Action("Crud", "TField"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"', ""POST"", Parameters));
                }

                if (response != undefined) {
                    if (response.Number != 200) {
                        $(""#Alert"").show();
                        console.log(response.Message);
                    } else {
                        location.reload();
                    }
                } else {
                    Modal.hide();
                }
            });

            $(""#btn-accept-delete"").click(function () {
                var Parameters = {
                    Id: parseInt($(""#Modelo_Id"").val())
                };

                var response = JSON.parse(CrudTable('");
#nullable restore
#line 184 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tfield\Index.cshtml"
                                                Write(Url.Action("Crud", "TField"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"', ""DELETE"", Parameters));
                if (response != undefined) {
                    if (response.Number != 200) {
                        $(""#Alert"").show();
                        console.log(response.Message);
                    } else {
                        location.reload();
                    }
                } else {
                    Modal.hide();
                }
            });
        })

        function Update(item) {
            var Data = JSON.parse(item.parentElement.firstElementChild.value);
            $(""#Modelo_Id"").val(Data.id);
            $(""#Modelo_Name"").val($.trim(Data.name));
            $(""#TxtLen"").text($.trim(Data.name).length);
            $(""#Accion"").val(2);
            $(""#NewVendorLabel"").text(""Update Field"");
            Modal.show();
        }

        function Delete(item) {
            var Data = JSON.parse(item.parentElement.firstElementChild.value);
            $(""#Modelo_Id"").val(Data.id);
            $(""#Modelo_Name"").val($");
                WriteLiteral(@".trim(Data.name));
            $(""#nameDelete"").text(Data.name);
            Toast.show();
        }

        function GetItems(FielID) {
            var Parameters = {
                FielID: FielID
            };
            var Data = JSON.parse(CrudTable('");
#nullable restore
#line 220 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tfield\Index.cshtml"
                                        Write(Url.Action("GetItems", "TField"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"', ""GET"", Parameters));
            var Html = '<table id=""WellsField"" class=""table table-striped"" style=""width:100%"">';
            Html += '<thead><tr><th>Nro</th><th>Name</th></tr></thead><tbody>';
            $.each(Data, function (pos, item) {
                Html += '<tr><td>' + item.Id + '</td><td>' + item.Name + '</td></tr>';
            });
            Html += '</tbody></table>';
            $(""#ItemsForVendor"").html(Html);
            $(""#WellsField"").dataTable(tableOptions);
            ModalList.show();
        }
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OxyWeb.ViewModels.ViewField> Html { get; private set; }
    }
}
#pragma warning restore 1591