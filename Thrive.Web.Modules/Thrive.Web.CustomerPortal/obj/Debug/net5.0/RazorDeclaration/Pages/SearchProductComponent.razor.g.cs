// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Thrive.Web.CustomerPortal.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\lgiqwa\OneDrive - MineRP\GitHub\Thrive\Thrive.Web.Modules\Thrive.Web.CustomerPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lgiqwa\OneDrive - MineRP\GitHub\Thrive\Thrive.Web.Modules\Thrive.Web.CustomerPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lgiqwa\OneDrive - MineRP\GitHub\Thrive\Thrive.Web.Modules\Thrive.Web.CustomerPortal\_Imports.razor"
using Thrive.Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lgiqwa\OneDrive - MineRP\GitHub\Thrive\Thrive.Web.Modules\Thrive.Web.CustomerPortal\_Imports.razor"
using Thrive.UseCases.SearchProduct;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lgiqwa\OneDrive - MineRP\GitHub\Thrive\Thrive.Web.Modules\Thrive.Web.CustomerPortal\_Imports.razor"
using Thrive.UseCases.ViewProduct;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lgiqwa\OneDrive - MineRP\GitHub\Thrive\Thrive.Web.Modules\Thrive.Web.CustomerPortal\_Imports.razor"
using Thrive.Web.CustomerPortal.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lgiqwa\OneDrive - MineRP\GitHub\Thrive\Thrive.Web.Modules\Thrive.Web.CustomerPortal\Pages\SearchProductComponent.razor"
using Thrive.Web.Common.Controls;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/products")]
    public partial class SearchProductComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\lgiqwa\OneDrive - MineRP\GitHub\Thrive\Thrive.Web.Modules\Thrive.Web.CustomerPortal\Pages\SearchProductComponent.razor"
       

    private IEnumerable<Product> _products;

    protected override void OnInitialized()
    {
        base.OnInitialized();

        _products = _searchProduct.Execute();
    }

    private void HandleSearch(string filter)
    {
        _products = _searchProduct.Execute(filter);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISearchProduct _searchProduct { get; set; }
    }
}
#pragma warning restore 1591
