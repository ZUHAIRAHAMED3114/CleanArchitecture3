#pragma checksum "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.CustomerPortal\Controls\ProductCardComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "584da7e4d7988a8f13fb7333fc4eb0b5a8aed94d"
// <auto-generated/>
#pragma warning disable 1591
namespace eShop.Web.CustomerPortal.Controls
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
    public partial class ProductCardComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card m-2 p-2");
            __builder.AddAttribute(2, "style", "width:12rem;");
            __builder.OpenElement(3, "img");
            __builder.AddAttribute(4, "src", 
#nullable restore
#line 2 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.CustomerPortal\Controls\ProductCardComponent.razor"
               product.ImageLink

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "class", "card-img-top");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-body");
            __builder.OpenElement(9, "h5");
            __builder.AddAttribute(10, "class", "card-title");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(11);
            __builder.AddAttribute(12, "Href", 
#nullable restore
#line 5 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.CustomerPortal\Controls\ProductCardComponent.razor"
                         $"product/{product.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 6 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.CustomerPortal\Controls\ProductCardComponent.razor"
__builder2.AddContent(14, product.Name);

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n        ");
            __builder.OpenElement(16, "p");
            __builder.AddAttribute(17, "class", "card-text");
            __builder.AddAttribute(18, "style", "color:darkred");
#nullable restore
#line 11 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.CustomerPortal\Controls\ProductCardComponent.razor"
__builder.AddContent(19, product.Price.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.CustomerPortal\Controls\ProductCardComponent.razor"
       
    [Parameter]
    public Product product { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
