#pragma checksum "C:\Users\BurakOzcelik\source\repos\BlazorAppAndAdminLTE\AdminLteTry\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46c856bc5526b5d18bb90d2142518d7795540dc9"
// <auto-generated/>
#pragma warning disable 1591
namespace AdminLteTry.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\BurakOzcelik\source\repos\BlazorAppAndAdminLTE\AdminLteTry\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BurakOzcelik\source\repos\BlazorAppAndAdminLTE\AdminLteTry\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\BurakOzcelik\source\repos\BlazorAppAndAdminLTE\AdminLteTry\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\BurakOzcelik\source\repos\BlazorAppAndAdminLTE\AdminLteTry\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\BurakOzcelik\source\repos\BlazorAppAndAdminLTE\AdminLteTry\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\BurakOzcelik\source\repos\BlazorAppAndAdminLTE\AdminLteTry\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\BurakOzcelik\source\repos\BlazorAppAndAdminLTE\AdminLteTry\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\BurakOzcelik\source\repos\BlazorAppAndAdminLTE\AdminLteTry\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\BurakOzcelik\source\repos\BlazorAppAndAdminLTE\AdminLteTry\_Imports.razor"
using AdminLteTry;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\BurakOzcelik\source\repos\BlazorAppAndAdminLTE\AdminLteTry\_Imports.razor"
using AdminLteTry.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\BurakOzcelik\source\repos\BlazorAppAndAdminLTE\AdminLteTry\_Imports.razor"
using Blazor.AdminLte;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazor.AdminLte.ContentHeader>(0);
            __builder.AddAttribute(1, "Header", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazor.AdminLte.PageTitle>(2);
                __builder2.AddAttribute(3, "Title", "Index");
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenComponent<Blazor.AdminLte.ContentMain>(5);
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col-md-6");
                __builder2.OpenComponent<Blazor.AdminLte.Card>(9);
                __builder2.AddAttribute(10, "Title", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazor.AdminLte.CardTitle>(11);
                    __builder3.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(13, "Title");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddAttribute(14, "Body", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(15, "\r\n                Contents\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
