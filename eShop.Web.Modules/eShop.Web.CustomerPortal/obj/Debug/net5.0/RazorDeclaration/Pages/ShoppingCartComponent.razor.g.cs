// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace eShop.Web.CustomerPortal.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using eShop.CoreBusiness.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using eShop.UseCases.PlugInInterfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using eShop.UseCases.SearchProductScreen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using eShop.UseCases.ViewProductScreen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using eShop.Web.Common.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using eShop.Web.CustomerPortal.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using eShop.UseCases.ShoppingCartScreen.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using eShop.UseCases.PlugInInterfaces.StateStore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cart")]
    public partial class ShoppingCartComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.CustomerPortal\Pages\ShoppingCartComponent.razor"
       
    private Order order;
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {

        if (firstRender)
        {
            order = await viewShoppingCartUseCase.Execute();
            StateHasChanged();
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IViewShoppingCartUseCase viewShoppingCartUseCase { get; set; }
    }
}
#pragma warning restore 1591
