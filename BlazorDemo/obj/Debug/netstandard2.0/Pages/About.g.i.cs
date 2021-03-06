#pragma checksum "D:\ASP.NET\BlazorDemo\BlazorDemo\Pages\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0adba86ae0658007972ee31053df9b9d795d7aa2"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorDemo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Microsoft.AspNetCore.Blazor.Browser.Interop;
    using BlazorDemo;
    using BlazorDemo.Shared;
    using Microsoft.AspNetCore.Blazor.Services;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/about")]
    public class About : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 49 "D:\ASP.NET\BlazorDemo\BlazorDemo\Pages\About.cshtml"
 

private string _name;
private string _color = "#fff";
private bool _checkboxstatus = true;

private void NameChanged(UIChangeEventArgs e)
{
    _name = e.Value as string;
}

private void BtnSendClick()
{
    UriHelper.NavigateTo($"/myname/{_name}");
}

private void ColorKeyUp(UIKeyboardEventArgs e)
{
    _color = RegisteredFunction.Invoke<string>("GetDOMValue", "color");
}

#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private IUriHelper UriHelper { get; set; }
    }
}
#pragma warning restore 1591
