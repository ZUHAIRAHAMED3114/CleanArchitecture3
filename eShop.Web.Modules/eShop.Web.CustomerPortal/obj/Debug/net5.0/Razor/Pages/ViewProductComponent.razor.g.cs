#pragma checksum "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.CustomerPortal\Pages\ViewProductComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdff0f641a1cb3b516e6270cb895e9b4ec82c646"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/product/{id:int}")]
    public partial class ViewProductComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Product Details</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card");
            __builder.AddAttribute(3, "style", "width:28rem;");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.OpenElement(6, "h5");
            __builder.AddAttribute(7, "class", "card-title");
#nullable restore
#line 9 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.CustomerPortal\Pages\ViewProductComponent.razor"
__builder.AddContent(8, product.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "img");
            __builder.AddAttribute(11, "src", 
#nullable restore
#line 10 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.CustomerPortal\Pages\ViewProductComponent.razor"
                   product.ImageLink

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "h6");
            __builder.AddAttribute(14, "class", "card-subtitle mb-2 text-muted");
#nullable restore
#line 11 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.CustomerPortal\Pages\ViewProductComponent.razor"
__builder.AddContent(15, product.Brand);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "p");
            __builder.AddAttribute(18, "class", "card-text");
#nullable restore
#line 12 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.CustomerPortal\Pages\ViewProductComponent.razor"
__builder.AddContent(19, product.Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        <hr>\r\n        Price:");
            __builder.OpenElement(21, "label");
            __builder.AddAttribute(22, "style", "color:darkred");
#nullable restore
#line 14 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.CustomerPortal\Pages\ViewProductComponent.razor"
__builder.AddContent(23, product.Price.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "class", "btn btn-primary");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.CustomerPortal\Pages\ViewProductComponent.razor"
                                               AddToCart

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(28, "Add To Cart..\\");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n<br>\r\n ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(30);
            __builder.AddAttribute(31, "href", "products");
            __builder.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(33, "Back To Products ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.CustomerPortal\Pages\ViewProductComponent.razor"
       

    private Product product;

    [Parameter]
    public int Id { get; set; }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        if(Id>0)
            product = viewProduct.Execute(Id);
    }

    void AddToCart() {
        addProductToCart.Execute(product.Id);
        navigationManager.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAddProductToCartUseCase addProductToCart { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IViewProductUseCase viewProduct { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
