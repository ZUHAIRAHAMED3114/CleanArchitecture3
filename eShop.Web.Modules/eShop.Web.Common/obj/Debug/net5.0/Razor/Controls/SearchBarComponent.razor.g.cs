#pragma checksum "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.Common\Controls\SearchBarComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8b9cd360c09ef603a90f34cc35282c403f74658"
// <auto-generated/>
#pragma warning disable 1591
namespace eShop.Web.Common.Controls
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.Common\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.Common\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.Common\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.Common\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    public partial class SearchBarComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "form");
            __builder.AddAttribute(1, "class", "form-inline");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "form-group mx-sm-3 mb-2");
            __builder.AddMarkupContent(4, "<label for=\"filter\"> Search :&nbsp;</label>\r\n        ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "class", "form-control");
            __builder.AddAttribute(8, "id", "filter");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.Common\Controls\SearchBarComponent.razor"
                                                                         filter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => filter = __value, filter));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n     ");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "type", "button");
            __builder.AddAttribute(14, "class", "btn btn-primary mb-2");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.Common\Controls\SearchBarComponent.razor"
                                                                  HandleSearch

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, " Search ");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\shaik zuhair ahamed\OneDrive\Desktop\Lecture\Sms_Call_Chat_Video_Sms\CleanArchitecure3\eShop.Web.Modules\eShop.Web.Common\Controls\SearchBarComponent.razor"
       

    private string filter;
    [Parameter]
    public EventCallback<string> onSearch { get; set; }

    void HandleSearch() {
        onSearch.InvokeAsync(filter);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
