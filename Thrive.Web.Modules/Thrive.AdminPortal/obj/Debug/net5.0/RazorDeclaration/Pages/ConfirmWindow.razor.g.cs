// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Thrive.AdminPortal.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\lgiqwa\OneDrive - MineRP\GitHub\Thrive\Thrive.Web.Modules\Thrive.AdminPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lgiqwa\OneDrive - MineRP\GitHub\Thrive\Thrive.Web.Modules\Thrive.AdminPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lgiqwa\OneDrive - MineRP\GitHub\Thrive\Thrive.Web.Modules\Thrive.AdminPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lgiqwa\OneDrive - MineRP\GitHub\Thrive\Thrive.Web.Modules\Thrive.AdminPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lgiqwa\OneDrive - MineRP\GitHub\Thrive\Thrive.Web.Modules\Thrive.AdminPortal\_Imports.razor"
using Telerik.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lgiqwa\OneDrive - MineRP\GitHub\Thrive\Thrive.Web.Modules\Thrive.AdminPortal\_Imports.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
    public partial class ConfirmWindow : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\lgiqwa\OneDrive - MineRP\GitHub\Thrive\Thrive.Web.Modules\Thrive.AdminPortal\Pages\ConfirmWindow.razor"
      
    [Parameter] public string ConfirmTitle { get; set; }

    [Parameter] public string ConfirmText { get; set; }

    [Parameter] public bool Visible { get; set; }

    [Parameter] public EventCallback OnConfirm { get; set; }

    [Parameter] public EventCallback OnCancel { get; set; }


    async void RaiseConfirm()
    {
        Visible = false;
        await OnConfirm.InvokeAsync(null);
    }

    async void RaiseCancel()
    {
        Visible = false;
        await OnCancel.InvokeAsync(null);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
