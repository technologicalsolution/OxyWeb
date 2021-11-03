#pragma checksum "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tequipment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5653faee3c22a3ceb7dac2c116c8d4a4567f93a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tequipment_Index), @"mvc.1.0.view", @"/Views/Tequipment/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5653faee3c22a3ceb7dac2c116c8d4a4567f93a", @"/Views/Tequipment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1083ec83a523b5769e737ebc5f0b2f10fdd7d201", @"/Views/_ViewImports.cshtml")]
    public class Views_Tequipment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OxyWeb.ViewModels.ViewEquipment>
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tequipment\Index.cshtml"
  
    ViewData["Title"] = "List Equipments";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-md"">
    <div class=""row justify-content-between p-2 my-2 text-white rounded shadow-sm title-page"">
        <div class=""col-12 col-md-2"">
            <h5>Equipment</h5>
        </div>
        <div class=""col-12 col-md-2"">
            <div class=""row align-items-end"">
                <button class=""btn btn-primary"" id=""btn-create""><i class=""me-3 bi bi-plus-square""></i>Create</button>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-12 table-responsive"">
            <table id=""tableFull"" class=""table table-striped"" style=""width:100%"">
                <thead>
                    <tr>
                        <th>Vendor</th>
                        <th>Nro.</th>
                        <th>EquipmentType</th>
                        <th>PartNumber</th>
                        <th>SerialNumber</th>
                        <th>EquipmentDescription</th>
                        <th>EquipmentTag</th>
                        <th>EqpTag");
            WriteLiteral("Date</th>\r\n                        <th>EqpPrice</th>\r\n                        <th width=\"30%\">Actions</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 36 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tequipment\Index.cshtml"
                     foreach (var item in Model.Lista)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 39 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tequipment\Index.cshtml"
                           Write(item.TvendorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 40 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tequipment\Index.cshtml"
                           Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 41 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tequipment\Index.cshtml"
                           Write(item.EquipmentType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 42 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tequipment\Index.cshtml"
                           Write(item.PartNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 43 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tequipment\Index.cshtml"
                           Write(item.SerialNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 44 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tequipment\Index.cshtml"
                           Write(item.EquipmentDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 45 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tequipment\Index.cshtml"
                           Write(item.EquipmentTag);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 46 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tequipment\Index.cshtml"
                           Write(item.EqpTagDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 47 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tequipment\Index.cshtml"
                           Write(item.EqpPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                <div class=\"row\">\r\n                                    <div class=\"col-12 col-md-6\">\r\n                                        <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 2174, "\"", 2214, 1);
#nullable restore
#line 51 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tequipment\Index.cshtml"
WriteAttributeValue("", 2182, Json.Serialize(item).ToString(), 2182, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                        <button type=""button"" class=""btn btn-secondary"" onclick=""Update(this)"">Update</button>
                                    </div>
                                    <div class=""col-12 col-md-6"">
                                        <input type=""hidden""");
            BeginWriteAttribute("value", " value=\"", 2519, "\"", 2559, 1);
#nullable restore
#line 55 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tequipment\Index.cshtml"
WriteAttributeValue("", 2527, Json.Serialize(item).ToString(), 2527, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                        <button type=""button"" class=""btn btn-danger"" onclick=""Delete(this)"">Delete</button>
                                    </div>
                                </div>
                            </td>
                        </tr>
");
#nullable restore
#line 61 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tequipment\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>
    </div>
</div>
<div class=""modal fade"" id=""ModalEquipment"" data-bs-backdrop=""static"" data-bs-keyboard=""false"" tabindex=""-1"" aria-labelledby=""NewEquipmentLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""NewEquipmentLabel""></h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                <div class=""row"">
                    <div class=""col-12 col-md-6"">
                        <div class=""form-group mb-3"">
                            <label for=""Pass"">EquipmentType</label>
                            ");
#nullable restore
#line 79 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tequipment\Index.cshtml"
                       Write(Html.TextBoxFor(m => m.Modelo.EquipmentType, new { @class = "form-control mt-2", onkeyup = "lengthText(this, 20,'TxtLenEquipmentType')", onkeydown = "lengthText(this, 20,'TxtLenEquipmentType')", placeholder = "Enter your Equipment Type" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            <div class=""form-text""><strong id=""TxtLenEquipmentType"">0</strong>/20</div>
                        </div>
                    </div>
                    <div class=""col-12 col-md-6"">
                        <div class=""form-group"">
                            <label class=""control-label"">Vendors</label>
                            <div class=""col-md-12 mt-2"">
                                <select id=""Modelo_VendorID"" name=""Modelo.VendorID"" class=""form-select"" data-init-plugin=""select2"" style=""width:100%""></select>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-12 col-md-6"">
                        <div class=""form-group mb-3"">
                            <label for=""Pass"">EquipmentDescription</label>
                            ");
#nullable restore
#line 96 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tequipment\Index.cshtml"
                       Write(Html.TextBoxFor(m => m.Modelo.EquipmentDescription, new { @class = "form-control mt-2", onkeyup = "lengthText(this, 50,'TxtLenEquipmentDescription')", onkeydown = "lengthText(this, 50,'TxtLenEquipmentDescription')", placeholder = "Enter your Equipment Description" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            
                            <div class=""form-text""><strong id=""TxtLenEquipmentDescription"">0</strong>/50</div>
                        </div>
                    </div>
                    <div class=""col-12 col-md-6"">
                        <div class=""form-group mb-3"">
                            <label for=""Pass"">EquipmentTag</label>
                            ");
#nullable restore
#line 103 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tequipment\Index.cshtml"
                       Write(Html.TextBoxFor(m => m.Modelo.EquipmentTag, new { @class = "form-control mt-2", onkeyup = "lengthText(this, 50,'TxtLenEquipmentTag')", onkeydown = "lengthText(this, 50,'TxtLenEquipmentTag')", placeholder = "Enter your Equipment Tag" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            
                            <div class=""form-text""><strong id=""TxtLenEquipmentTag"">0</strong>/50</div>
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-12 col-md-6"">
                        <div class=""form-group mb-3"">
                            <label for=""Pass"">PartNumber</label>
                            ");
#nullable restore
#line 112 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tequipment\Index.cshtml"
                       Write(Html.TextBoxFor(m => m.Modelo.PartNumber, new { @class = "form-control mt-2", onkeyup = "lengthText(this, 10,'TxtLenPartNumber')", onkeydown = "lengthText(this, 10,'TxtLenPartNumber')", placeholder = "Enter your Part Number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            
                            <div class=""form-text""><strong id=""TxtLenPartNumber"">0</strong>/10</div>
                        </div>
                    </div>
                    <div class=""col-12 col-md-6"">
                        <div class=""form-group mb-3"">
                            <label for=""Pass"">SerialNumber</label>
                            ");
#nullable restore
#line 119 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tequipment\Index.cshtml"
                       Write(Html.TextBoxFor(m => m.Modelo.SerialNumber, new { @class = "form-control mt-2", onkeyup = "lengthText(this, 10,'TxtLenSerialNumber')", onkeydown = "lengthText(this, 10,'TxtLenSerialNumber')", placeholder = "Enter your SerialNumber" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            
                            <div class=""form-text""><strong id=""TxtLenSerialNumber"">0</strong>/10</div>
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-12 col-md-6"">
                        <div class=""form-group mb-3"">
                            <label for=""Pass"">EqpTagDate</label>
                            ");
#nullable restore
#line 128 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tequipment\Index.cshtml"
                       Write(Html.TextBoxFor(m => m.Modelo.EqpTagDate, new { @type = "date", @class="form-control mt-2"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""col-12 col-md-6"">
                        <div class=""form-group mb-3"">
                            <label for=""Pass"">EqpPrice</label>
                            ");
#nullable restore
#line 134 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tequipment\Index.cshtml"
                       Write(Html.TextBoxFor(m => m.Modelo.EqpPrice, new { @type = "number", @class = "form-control mt-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                            \r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-12\">\r\n");
#nullable restore
#line 140 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tequipment\Index.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5653faee3c22a3ceb7dac2c116c8d4a4567f93a18066", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5653faee3c22a3ceb7dac2c116c8d4a4567f93a19265", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5653faee3c22a3ceb7dac2c116c8d4a4567f93a20471", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5653faee3c22a3ceb7dac2c116c8d4a4567f93a21669", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5653faee3c22a3ceb7dac2c116c8d4a4567f93a22869", async() => {
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
#line 154 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tequipment\Index.cshtml"
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 157 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tequipment\Index.cshtml"
                       Write(Html.HiddenFor(m => m.Modelo.idRol));

#line default
#line hidden
#nullable disable
#nullable restore
#line 157 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tequipment\Index.cshtml"
                                                                
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"modal-footer\">\r\n                ");
#nullable restore
#line 163 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tequipment\Index.cshtml"
           Write(Html.HiddenFor(m => m.Modelo.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 164 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tequipment\Index.cshtml"
           Write(Html.HiddenFor(m => m.Accion));

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
        var Modal = new bootstrap.Modal(document.getElementById('ModalEquipment'), { keyboard: false });
        var Toast = new bootstrap.Toast(document.getElementById('ToastDelete'), { positionClass: 'toast-top-center' });       

        $(document).ready(function () {
            LoadTable(""tableFull"");

            $(""#btn-create"").click(function () {
                $(""#NewEquipmentLabel"").text(""New Equipment"");
                LoadVendors();
                $(""#Accion"").val(0);
                Modal.show();
            });

            $(""#btn-save"").click(function () {
                var response;
                var Parameters = {
                    Accion: parseInt($(""#Accion"").val()),
                    Modelo: {
                        EquipmentType: $.trim($(""#Modelo_EquipmentType"").val()),
                        VendorID: $.trim($(""#Modelo_VendorID"").val()),
                        PartNumber: $.trim($(""#Modelo_PartNumber"").val()),
");
                WriteLiteral(@"                        SerialNumber: $.trim($(""#Modelo_SerialNumber"").val()),
                        EquipmentDescription: $.trim($(""#Modelo_EquipmentDescription"").val()),
                        EquipmentTag: $.trim($(""#Modelo_EquipmentTag"").val()),
                        EqpTagDate: $.trim($(""#Modelo_EqpTagDate"").val()),
                        EqpPrice: parseFloat($(""#Modelo_EqpPrice"").val()),
                        idRol: parseInt($(""#Modelo_idRol"").val())
                    }
                };

                if (Parameters.Accion == 0) {
                    response = JSON.parse(CrudTable('");
#nullable restore
#line 213 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tequipment\Index.cshtml"
                                                Write(Url.Action("Crud", "Tequipment"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\', \"POST\", Parameters));\r\n                } else {\r\n                    Parameters[\'Modelo\'][\'id\'] = parseInt($(\"#Modelo_id\").val());\r\n                    response = JSON.parse(CrudTable(\'");
#nullable restore
#line 216 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tequipment\Index.cshtml"
                                                Write(Url.Action("Crud", "Tequipment"));

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
                    Id: parseInt($(""#Modelo_VendorID"").val()),                    
                }

                var response = CrudTable('");
#nullable restore
#line 235 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tequipment\Index.cshtml"
                                     Write(Url.Action("Crud", "Tequipment"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"', ""DELETE"", Parameters);
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
            LoadVendors();
            var Data = JSON.parse(item.parentElement.firstElementChild.value);
            $(""#Modelo_id"").val(Data.id);
            $(""#Modelo_EquipmentType"").val(Data.equipmentType);
            $(""#TxtLenEquipmentType"").text(Data.equipmentType.length);
            $(""#Modelo_EquipmentDescription"").val(Data.equipmentDescription);
            $(""#TxtLenEquipmentDescription"").text(Data.equipmentDescription.length);
            $(""#Modelo_EquipmentTag"").val(Data.equipmentTag);
            $(""#TxtLenEquipmentTag"").text(");
                WriteLiteral(@"Data.equipmentTag.length);
            $(""#Modelo_PartNumber"").val(Data.partNumber);
            $(""#TxtLenPartNumber"").text(Data.partNumber.length);
            $(""#Modelo_SerialNumber"").val(Data.serialNumber);
            $(""#TxtLenSerialNumber"").text(Data.serialNumber.length);
            $(""#Modelo_VendorID"").val(Data.vendorID);
            var date = Data.eqpTagDate.split('T')
            $(""#Modelo_EqpTagDate"").val(date[0]);
            $(""#Modelo_EqpPrice"").val(Data.eqpPrice);

            $(""#Accion"").val(2);
            $(""#NewEquipmentLabel"").text(""Update Equipment"");
            Modal.show();
        }

        function Delete(item) {
            var Data = JSON.parse(item.parentElement.firstElementChild.value);
            $(""#IdEquipment"").val(Data.id);
            $(""#nameDelete"").text(Data.name);
            Toast.show();
        }

        function LoadVendors() {
            var idRol = $(""#Modelo_idRol"").val();
            $.ajax({
                url: '");
#nullable restore
#line 283 "D:\Alexander\OxyN\OxyWeb\OxyWeb\Views\Tequipment\Index.cshtml"
                 Write(Url.RouteUrl("AllVendor"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"/' + idRol ,
                type: 'GET',
                crossDomain: true,
                dataType: 'json',
                xhrFields: {
                    withCredentials: true
                },
                success: function (result) {
                    var Html = '';
                    var Data = JSON.parse(result);
                    $.each(Data, function (pos, item) {
                        Html += '<option value=""' + item.Id + '"">' + $.trim(item.Name) + '</option>';
                    })
                    $(""#Modelo_VendorID"").html(Html);
                },
                error: function (data) {
                    $(""#Alert"").show();
                    console.log(data);
                },
            });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OxyWeb.ViewModels.ViewEquipment> Html { get; private set; }
    }
}
#pragma warning restore 1591
