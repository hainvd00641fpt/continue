#pragma checksum "C:\Users\Admin\source\repos\dotNetT1708M1\ProductNetCore\ProductNetCore\Views\Product\GetList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe2d56f8843ab8ff3eeab3a799642ee591973661"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_GetList), @"mvc.1.0.view", @"/Views/Product/GetList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/GetList.cshtml", typeof(AspNetCore.Views_Product_GetList))]
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
#line 1 "C:\Users\Admin\source\repos\dotNetT1708M1\ProductNetCore\ProductNetCore\Views\_ViewImports.cshtml"
using ProductNetCore;

#line default
#line hidden
#line 2 "C:\Users\Admin\source\repos\dotNetT1708M1\ProductNetCore\ProductNetCore\Views\_ViewImports.cshtml"
using ProductNetCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe2d56f8843ab8ff3eeab3a799642ee591973661", @"/Views/Product/GetList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"007a8562562bd4c83bd9dc30e203f7dd6b047f09", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_GetList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Admin\source\repos\dotNetT1708M1\ProductNetCore\ProductNetCore\Views\Product\GetList.cshtml"
  
    ViewData["Title"] = "GetList";

#line default
#line hidden
            BeginContext(45, 47, true);
            WriteLiteral("\r\n<h2>GetList</h2>\r\n<div class=\"alert-success\">");
            EndContext();
            BeginContext(93, 19, false);
#line 7 "C:\Users\Admin\source\repos\dotNetT1708M1\ProductNetCore\ProductNetCore\Views\Product\GetList.cshtml"
                      Write(TempData["message"]);

#line default
#line hidden
            EndContext();
            BeginContext(112, 236, true);
            WriteLiteral("</div>\r\n<input type=\"checkbox\" id=\"check-all\" />\r\n<span>Check all</span>\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <th>Name</th>\r\n            <th>Price</th>\r\n            <th>Handle</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 19 "C:\Users\Admin\source\repos\dotNetT1708M1\ProductNetCore\ProductNetCore\Views\Product\GetList.cshtml"
         foreach (var product in Model)
        {


#line default
#line hidden
            BeginContext(402, 60, true);
            WriteLiteral("            <tr>\r\n                <td><input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 462, "\"", 487, 2);
            WriteAttributeValue("", 467, "check-id-", 467, 9, true);
#line 23 "C:\Users\Admin\source\repos\dotNetT1708M1\ProductNetCore\ProductNetCore\Views\Product\GetList.cshtml"
WriteAttributeValue("", 476, product.Id, 476, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(488, 30, true);
            WriteLiteral(" /></td>\r\n                <td>");
            EndContext();
            BeginContext(519, 12, false);
#line 24 "C:\Users\Admin\source\repos\dotNetT1708M1\ProductNetCore\ProductNetCore\Views\Product\GetList.cshtml"
               Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(531, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(559, 13, false);
#line 25 "C:\Users\Admin\source\repos\dotNetT1708M1\ProductNetCore\ProductNetCore\Views\Product\GetList.cshtml"
               Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(572, 51, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 623, "\"", 660, 2);
            WriteAttributeValue("", 630, "/Product/Update?id=", 630, 19, true);
#line 27 "C:\Users\Admin\source\repos\dotNetT1708M1\ProductNetCore\ProductNetCore\Views\Product\GetList.cshtml"
WriteAttributeValue("", 649, product.Id, 649, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(661, 42, true);
            WriteLiteral(">Edit</a>\r\n                    <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 703, "\"", 719, 1);
#line 28 "C:\Users\Admin\source\repos\dotNetT1708M1\ProductNetCore\ProductNetCore\Views\Product\GetList.cshtml"
WriteAttributeValue("", 708, product.Id, 708, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(720, 74, true);
            WriteLiteral(" class=\"btn-delete\">Delete</a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 31 "C:\Users\Admin\source\repos\dotNetT1708M1\ProductNetCore\ProductNetCore\Views\Product\GetList.cshtml"
        }

#line default
#line hidden
            BeginContext(805, 2208, true);
            WriteLiteral(@"    </tbody>
</table>
<button  id=""delete-all"">Delete All</button>
<script>
    var listBtnDelete = document.getElementsByClassName(""btn-delete"");
    for (var i = 0; i < listBtnDelete.length; i++) {
        listBtnDelete[i].onclick = function () {
            if (confirm(""Are you sure ?"")) {
                var currentDeleteButton = this;
                var deleteId = this.id;
                var xmlHttpRequest = new XMLHttpRequest();
                xmlHttpRequest.onreadystatechange = function () {
                    if (this.readyState === 4 && this.status === 200) {
                        alert(""Delete success"");
                        currentDeleteButton.parentElement.remove();
                    }
                }
                xmlHttpRequest.open(""DELETE"", ""/Product/Delete?id="" + deleteId, true);
                xmlHttpRequest.send();
            }
        };
    }

        var checkAll = document.getElementById(""check-all"");
        var listCheckBox = document.getElemen");
            WriteLiteral(@"tsByClassName(""check-Item"");
        checkAll.onclick = function () {
            for (var i = 0; i < listCheckBox.length; i++) {
                listCheckBox[i].checked = this.checked;
            }
        }
        var deleteAll = document.getElementById(""delete-all"");
        deleteAll.onclick = function () {
            var checkedItems = document.querySelectorAll("".check-item:checked"");
            var deleteIds = new Array();
            for (var i = 0; i < checkedItems.length; i++) {
                deleteIds.push(checkedItems[i].id.replace(""check-id"", """"));
            }
            Console.log(deleteIds);
            if (deleteIds.length === 0) {
                alert(""Please choose at least 1 item"");
                return;
            }
            //ajax
            var xmlHttpRequest = new XMLHttpRequest();
            xmlHttpRequest.onreadystatechange = function () {
                if (this.readyState == && this.status === 200) {
                    alert(""Delete success""");
            WriteLiteral(");\r\n                }\r\n            }\r\n            xamlHttpRequest.open(\"DELETE\", \"Product/DeleteMany?id=\" + deleteIds, true);\r\n        }\r\n    }\r\n\r\n</script>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
