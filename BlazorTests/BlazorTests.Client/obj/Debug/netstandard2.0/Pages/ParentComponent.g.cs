#pragma checksum "C:\Users\MIKE\Documents\Visual Studio 2017\Projects\BlazorTests\BlazorTests.Client\Pages\ParentComponent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5020a6be576c3a8d2832b13c1fe5be162a9694b"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorTests.Client.Pages
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
    using BlazorTests.Client;
    using BlazorTests.Client.Shared;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/ParentComponent")]
    public class ParentComponent : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "h1");
            builder.AddContent(1, "Parent-child example");
            builder.CloseElement();
            builder.AddContent(2, "\n\n");
            builder.OpenComponent<BlazorTests.Client.Pages.ChildComponent>(3);
            builder.AddAttribute(4, "Title", "Panel Title from Parent");
            builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Blazor.RenderFragment)((builder2) => {
                builder2.AddContent(6, "\n");
            }
            ));
            builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
