#pragma checksum "H:\Project\Blazor\BlazorApp-Server\BlazorApp-Server\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cd0803b79b9218b30fc59a3a3df90d4e9e4e2ce"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp_Server.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "H:\Project\Blazor\BlazorApp-Server\BlazorApp-Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\Project\Blazor\BlazorApp-Server\BlazorApp-Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "H:\Project\Blazor\BlazorApp-Server\BlazorApp-Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "H:\Project\Blazor\BlazorApp-Server\BlazorApp-Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "H:\Project\Blazor\BlazorApp-Server\BlazorApp-Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "H:\Project\Blazor\BlazorApp-Server\BlazorApp-Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "H:\Project\Blazor\BlazorApp-Server\BlazorApp-Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "H:\Project\Blazor\BlazorApp-Server\BlazorApp-Server\_Imports.razor"
using BlazorApp_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "H:\Project\Blazor\BlazorApp-Server\BlazorApp-Server\_Imports.razor"
using BlazorApp_Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "H:\Project\Blazor\BlazorApp-Server\BlazorApp-Server\Pages\FetchData.razor"
using BlazorApp_Server.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "H:\Project\Blazor\BlazorApp-Server\BlazorApp-Server\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now); 
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
