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
#line 2 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 8 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using eShop.UI;

#line default
#line hidden
#line 9 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using eShop.UI.Shared;

#line default
#line hidden
#line 13 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using eShop.Web;

#line default
#line hidden
#line 14 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using eShop.Web.CustomerPortal.Controls;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/product/{id:int}")]
    public partial class ViewProductComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 18 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.CustomerPortal\Pages\ViewProductComponent.razor"
       

    private Product product;

    [Parameter]
    public int Id { get; set; }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        if(Id>0)
        product = viewProduct.Execute(Id);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IViewProduct viewProduct { get; set; }
    }
}
#pragma warning restore 1591