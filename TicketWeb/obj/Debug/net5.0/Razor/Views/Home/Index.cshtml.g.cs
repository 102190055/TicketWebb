#pragma checksum "D:\Test\TicketWeb\TicketWeb\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d02a8f0b3c19c62cf4bcc9d92d92eb59aef85c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Test\TicketWeb\TicketWeb\Views\_ViewImports.cshtml"
using TicketWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Test\TicketWeb\TicketWeb\Views\_ViewImports.cshtml"
using TicketWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d02a8f0b3c19c62cf4bcc9d92d92eb59aef85c8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fb632d47e17aa42a9fa559e95a81be29ee3cc51", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("https://olala.vn/search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("accept-charset", new global::Microsoft.AspNetCore.Html.HtmlString("UTF-8"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("home-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Test\TicketWeb\TicketWeb\Views\Home\Index.cshtml"
  
    
    Layout = "_LayoutPortal";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""app"">
    <main class=""main-wrap"">
        <div class=""sidebar-left"">
            <div class=""nav-menu"">
                <ul class=""menu-list"">
                    <li class=""menu-item active"">
                        <a href=""index.html"" class=""menu-link"">
                            <span class=""icon"">
                                <img src=""https://olala.vn/images/datve.svg""");
            BeginWriteAttribute("alt", " alt=\"", 445, "\"", 451, 0);
            EndWriteAttribute();
            WriteLiteral(@" title=""Đặt vé máy bay"">
                            </span>
                            <span class=""menu-text"">Đặt vé máy bay</span>
                        </a>
                    </li>
                    <li class=""menu-item"">
                        <a href=""khuyen-mai.html"" class=""menu-link"">
                            <span class=""icon"">
                                <img src=""https://olala.vn/images/km.svg""");
            BeginWriteAttribute("alt", " alt=\"", 883, "\"", 889, 0);
            EndWriteAttribute();
            WriteLiteral(@" title=""Khuyến mại"">
                            </span>
                            <span class=""menu-text"">Khuyến mãi</span>
                        </a>
                    </li>
                    <li class=""menu-item"">
                        <a href=""cam-nang.html"" class=""menu-link"">
                            <span class=""icon"">
                                <img src=""https://olala.vn/images/camnang.svg""");
            BeginWriteAttribute("alt", " alt=\"", 1316, "\"", 1322, 0);
            EndWriteAttribute();
            WriteLiteral(@" title=""Cẩm nang du lịch"">
                            </span>
                            <span class=""menu-text"">Cẩm nang du lịch</span>
                        </a>
                    </li>
                    <li class=""menu-item"">
                        <a href=""thanh-toan.html"" class=""menu-link"">
                            <span class=""icon"">
                                <img src=""https://olala.vn/images/thanhtoan.svg""");
            BeginWriteAttribute("alt", " alt=\"", 1765, "\"", 1771, 0);
            EndWriteAttribute();
            WriteLiteral(@" title=""Thanh toán"">
                            </span>
                            <span class=""menu-text"">Thanh toán</span>
                        </a>
                    </li>
                    <li class=""menu-item"">
                        <a href=""lien-he.html"" class=""menu-link"">
                            <span class=""icon"">
                                <img src=""https://olala.vn/images/lienhe.svg""");
            BeginWriteAttribute("alt", " alt=\"", 2196, "\"", 2202, 0);
            EndWriteAttribute();
            WriteLiteral(" title=\"Liên hệ\">\r\n                            </span>\r\n                            <span class=\"menu-text\">Liên hệ</span>\r\n                        </a>\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n");
#nullable restore
#line 53 "D:\Test\TicketWeb\TicketWeb\Views\Home\Index.cshtml"
             if (!User.Identity.IsAuthenticated)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""user_fix"">
                    <div class=""login"">
                        <a href=""/Login"" data-toggle=""modal"" data-target=""#loginModal""
                           class=""d-flex align-items-center"">
                            <p class=""ic_user"">
                                <img src=""images/ic_user.png""");
            BeginWriteAttribute("alt", " alt=\"", 2834, "\"", 2840, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </p>\r\n                            <span>Đăng nhập</span>\r\n                        </a>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 66 "D:\Test\TicketWeb\TicketWeb\Views\Home\Index.cshtml"
            }
            else
            {

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <style>
            body {
                background-image: url('https://www.airlinequality.com/wp-content/uploads/2019/06/about-us-image.jpg?fbclid=IwAR0zdveSBU81rODnmtRSbt5_FQhpPKX3MBeaARunynmbIMxm4OkKUh7LqVg');
                background-repeat: no-repeat;
                background-attachment: fixed;
                background-size: 100% 100%;
            }
        </style>            <div class=""search-box"" id=""do-my-vue"">
            <div class=""search-box-title"">
                <h4>Đặt vé máy bay</h4>
            </div>
            <div class=""search-box-content"">
                <ul class=""nav nav-pills mb-3"" id=""pills-tab"">
                    <li class=""nav-item"">
                        <a class=""tab-link active"" id=""return-tab"" href=""javascript:;"" onclick=""changeTrip()"">
                            Khứ
                            hồi
                        </a>
                    </li>
                    <li class=""nav-item"">
                       ");
            WriteLiteral(" <a class=\"tab-link\" id=\"onway-tab\" href=\"javascript:;\" onclick=\"changeTrip(true)\">\r\n                            Một\r\n                            chiều\r\n                        </a>\r\n                    </li>\r\n                </ul>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d02a8f0b3c19c62cf4bcc9d92d92eb59aef85c810280", async() => {
                WriteLiteral(@"
                    <input type=""hidden"" name=""type"" v-model=""type"">
                    <div class=""tab-content"" id=""pills-tabContent"">
                        <div class=""tab-pane fade show active"" id=""return"" role=""tabpanel""
                             aria-labelledby=""return-tab"">
                            <div class=""box-flight d-flex flex-wrap"">
                                <div class=""d-flex city-box align-items-center"">
                                    <div class=""city-box-item city-start"" ref=""city_start"">
                                        <span class=""city-box-title"">Chọn nơi xuất phát</span>
                                        <div class=""select-city"" data-type=""start"">
                                            <input type=""text"" class=""input-city"" id=""keyboard_start""
                                                   data-type=""start"" onfocus=""focusSearch('city_start')""
                                                   onkeyup=""app.suggestAirport(this.value)"">
 ");
                WriteLiteral(@"                                           <div class=""holder"" onclick=""showCity('city_start')"">
                                                <span class=""city"">Khu Vực</span>
                                                <span class=""country"">Quốc gia</span>
                                            </div>
                                            <div class=""selected"" onclick=""showCity('city_start')"">
                                                <span class=""city"" v-html=""themeCity('start')""></span>
                                                <span class=""country"" v-html=""themeCountry('start')""></span>
                                            </div>
                                            <input type=""hidden"" name=""start"" class=""value"" id=""start""
                                                   :value=""cityCode('start')"">
                                        </div>
                                        <div class=""drop-list"">
                                        ");
                WriteLiteral(@"    <ul class=""city-list"" id=""suggest_start"" v-show=""showingSuggest()"">
                                                <li v-for=""item in suggest""
                                                    :class=""{'city-item': true, 'city-item-active': activeSuggest('start', item.value)}"">
                                                    <a href=""#"" class=""link-item""
                                                       onclick=""choiceAirport('start', item.value)"">
                                                        <span class=""city"" v-text=""item.label""></span>
                                                        <span class=""code-city"" v-text=""item.value""></span>
                                                    </a>
                                                </li>
                                            </ul>
                                            <div class=""list-his"" v-show=""showingHistory()"">
                                                <div class=""title"">
          ");
                WriteLiteral(@"                                          <a href=""javascript:;"" class=""del-his""
                                                       onclick=""clearHistory()"">Xóa</a>
                                                </div>
                                                <ul>
                                                    <li class=""his-item"" v-for=""item in historyArr""
                                                        style=""cursor: pointer""
                                                        onclick=""loadHistory(item.start, item.end)"">
                                                        <div class=""d-flex align-items-center"">
                                                            <div class=""item-city"">
                                                                <span class=""city"">
                                                                    <span class=""name""
                                                                          v-text=""item.start.city""></spa");
                WriteLiteral(@"n> ({{
                                                                            item.start.code }})
                                                                </span>
                                                                <br />
                                                                <span class=""country""
                                                                      v-text=""item.start.country""></span>
                                                            </div>
                                                            <span><i class=""fa fa-exchange""></i></span>
                                                            <div class=""item-city"">
                                                                <span class=""city"">
                                                                    <span class=""name""
                                                                          v-text=""item.end.city""></span> ({{
                                       ");
                WriteLiteral(@"                                     item.end.code }})
                                                                </span>
                                                                <br />
                                                                <span class=""country""
                                                                      v-text=""item.end.country""></span>
                                                            </div>
                                                        </div>
                                                    </li>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                    <span class=""ic_flight-center pt-4"">
                                        <img src=""https://olala.vn/images/ic_flight-gray.png""");
                BeginWriteAttribute("alt", "\r\n                                             alt=\"", 10512, "\"", 10564, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                    </span>
                                    <div class=""city-box-item city-end"" ref=""city_end"">
                                        <span class=""city-box-title"">Chọn nơi đến</span>
                                        <div class=""select-city"" data-type=""end"">
                                            <input type=""text"" class=""input-city"" id=""keyboard_end""
                                                   data-type=""end"" onfocus=""focusSearch('city_end')""
                                                   onkeyup=""app.suggestAirport(this.value)"">
                                            <div class=""holder"" onclick=""showCity('city_end')"">
                                                <span class=""city"">Khu Vực</span>
                                                <span class=""country"">Quốc gia</span>
                                            </div>
                                            <div class=""selected"" onclick=""showCity('city_end')"">");
                WriteLiteral(@"
                                                <span class=""city"" v-html=""themeCity('end')""></span>
                                                <span class=""country"" v-html=""themeCountry('end')""></span>
                                            </div>
                                            <input type=""hidden"" name=""destination"" class=""value"" id=""end""
                                                   :value=""cityCode('end')"">
                                        </div>
                                        <div class=""drop-list"">
                                            <ul class=""city-list"" id=""suggest_end"" v-show=""showingSuggest()"">
                                                <li v-for=""item in suggest""
                                                    :class=""{'city-item': true, 'city-item-active': activeSuggest('end', item.value)}"">
                                                    <a href=""#"" class=""link-item""
                                                      ");
                WriteLiteral(@" onclick=""choiceAirport('end', item.value)"">
                                                        <span class=""city"" v-text=""item.label""></span>
                                                        <span class=""code-city"" v-text=""item.value""></span>
                                                    </a>
                                                </li>
                                            </ul>
                                            <div class=""list-his"" v-show=""showingHistory()"">
                                                <div class=""title"">
                                                    <a href=""javascript:;"" class=""del-his""
                                                       onclick=""clearHistory()"">Xóa</a>
                                                </div>
                                                <ul>
                                                    <li class=""his-item"" v-for=""item in historyArr""
                                              ");
                WriteLiteral(@"          style=""cursor: pointer""
                                                        onclick=""loadHistory(item.start, item.end)"">
                                                        <div class=""d-flex align-items-center"">
                                                            <div class=""item-city"">
                                                                <span class=""city"">
                                                                    <span class=""name""
                                                                          v-text=""item.start.city""></span> ({{
                                                                            item.start.code }})
                                                                </span>
                                                                <br />
                                                                <span class=""country""
                                                                      v-text=""item.start.co");
                WriteLiteral(@"untry""></span>
                                                            </div>
                                                            <span><i class=""fa fa-exchange""></i></span>
                                                            <div class=""item-city"">
                                                                <span class=""city"">
                                                                    <span class=""name""
                                                                          v-text=""item.end.city""></span> ({{
                                                                            item.end.code }})
                                                                </span>
                                                                <br />
                                                                <span class=""country""
                                                                      v-text=""item.end.country""></span>
                                   ");
                WriteLiteral(@"                         </div>
                                                        </div>
                                                    </li>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""box-select-day"">
                                    <div class=""d-flex align-items-center"">
                                        <div class=""day-item"">
                                            <span class=""box-title"">ngày đi</span>
                                            <div class=""box-select d-flex flex-column-reverse"">
                                                <span class=""js-t2-cn"" v-text=""showDateName(start.time)""></span>
                                                <input type=""text""
                                                       class=""c");
                WriteLiteral(@"ontent-date-input js-date-begin-show day-null p-0""
                                                       placeholder=""Chọn"" v-model=""start.time""
                                                       name=""departure_date"">
                                                <input type=""text""
                                                       class=""content-date-input js-date-begin day-null p-0""
                                                       placeholder=""Chọn"" readonly=""readonly"">
                                            </div>
                                        </div>
                                        <div class=""day-item"" v-show=""!isOneWay"">
                                            <span class=""box-title"">ngày Về</span>
                                            <div class=""box-select d-flex flex-column-reverse"">
                                                <span class=""js-t2-cn"" v-text=""showDateName(end.time)""></span>
                                               ");
                WriteLiteral(@" <input type=""text""
                                                       class=""content-date-input js-date-end-show day-null p-0""
                                                       placeholder=""Chọn"" v-model=""end.time"" name=""return_date"">
                                                <input type=""text""
                                                       class=""content-date-input js-date-end day-null p-0""
                                                       placeholder=""Chọn"" readonly=""readonly"">
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""count-box w-100"">
                                    <div class=""d-flex"">
                                        <div class=""count-item d-flex"">
                                            <div class=""title-box"">
                                                <span cla");
                WriteLiteral(@"ss=""type"">Người lớn</span>
                                                <span class=""old"">≥ 12 tuổi</span>
                                            </div>
                                            <div class=""box-input"">
                                                <span class=""btn_change-val""
                                                      onclick=""changeNumber('adult', true)"">-</span>
                                                <input type=""text"" v-model=""adults"" name=""adults"" id=""adults""
                                                       readonly>
                                                <span class=""btn_change-val""
                                                      onclick=""changeNumber('adult')"">+</span>
                                            </div>
                                        </div>
                                        <div class=""count-item d-flex"">
                                            <div class=""title-box"">
                  ");
                WriteLiteral(@"                              <span class=""type"">Trẻ em</span>
                                                <span class=""old"">2 < 12 tuổi</span>
                                            </div>
                                            <div class=""box-input"">
                                                <span class=""btn_change-val""
                                                      onclick=""changeNumber('children', true)"">-</span>
                                                <input type=""text"" v-model=""children"" name=""children""
                                                       id=""children"" readonly>
                                                <span class=""btn_change-val""
                                                      onclick=""changeNumber('children')"">+</span>
                                            </div>
                                        </div>
                                        <div class=""count-item d-flex"">
                                     ");
                WriteLiteral(@"       <div class=""title-box"">
                                                <span class=""type"">Trẻ em</span>
                                                <span class=""old"">
                                                    < 2 tuổi
                                                </span>
                                            </div>
                                            <div class=""box-input"">
                                                <span class=""btn_change-val""
                                                      onclick=""changeNumber('infant', true)"">-</span>
                                                <input type=""text"" v-model=""infant"" name=""infant"" id=""infant""
                                                       readonly>
                                                <span class=""btn_change-val""
                                                      onclick=""changeNumber('infant')"">+</span>
                                            </div>
                 ");
                WriteLiteral("                       </div>\r\n                                        <div class=\"check_min-price d-flex align-items-center\">\r\n                                            <input type=\"checkbox\" class=\"input_check-price\"");
                BeginWriteAttribute("id", " id=\"", 22049, "\"", 22054, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""price"">
                                            <a href=""javascript:;"" class=""btn_search"" onclick=""submit()"">
                                                Tìm
                                                chuyến bay
                                            </a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </main>\r\n</div>\r\n            \r\n        \r\n\r\n");
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
