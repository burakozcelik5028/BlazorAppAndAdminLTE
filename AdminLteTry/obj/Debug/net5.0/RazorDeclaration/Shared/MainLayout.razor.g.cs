// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AdminLteTry.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 180 "C:\Users\BurakOzcelik\source\repos\BlazorAppAndAdminLTE\AdminLteTry\Shared\MainLayout.razor"
       
    protected override void OnParametersSet()
    {
        // content = null; for refreshing custom menu injectables per page.
        // no override; reset default to show parent menu content items.
        navBarLeftInjectableMenu.SetContent(null, false);
    }

    private DateTime dt = DateTime.Now;

    private void SeeAllMessages(Tuple<IDropdownFooter, MouseEventArgs> args)
    {
        NavigationManager.NavigateTo("messages/see-all-messages");
    }

    private void HandleContent(Tuple<INavBarMenuItem, MouseEventArgs> args)
    {
        NavigationManager.NavigateTo("messages/see-all-messages");
    }

    private void SeeAllNotifications(Tuple<IDropdownFooter, MouseEventArgs> args)
    {
        NavigationManager.NavigateTo("Counter");
    }

    protected override void OnAfterRender(bool isFirstRender)
    {
        layoutManager.IsFooterFixed = true;
        layoutManager.IsNavBarFixed = true;
        layoutManager.IsSideBarFixed = true;
        base.OnAfterRender(isFirstRender);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavBarLeftInjectableMenu navBarLeftInjectableMenu { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILayoutManager layoutManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
