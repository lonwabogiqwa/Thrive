// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Thrive.Web.Common.Controls
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\lgiqwa\OneDrive - MineRP\GitHub\Thrive\Thrive.Web.Modules\Thrive.Web.Common\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lgiqwa\OneDrive - MineRP\GitHub\Thrive\Thrive.Web.Modules\Thrive.Web.Common\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
    public partial class SearchBarComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\lgiqwa\OneDrive - MineRP\GitHub\Thrive\Thrive.Web.Modules\Thrive.Web.Common\Controls\SearchBarComponent.razor"
       
    private string _filter;

    [Parameter]
    public EventCallback<string> OnSearch { get; set; }

    private void HandleSearch()
    {
        OnSearch.InvokeAsync(_filter);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
