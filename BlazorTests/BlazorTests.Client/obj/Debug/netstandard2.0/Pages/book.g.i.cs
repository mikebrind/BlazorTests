#pragma checksum "C:\Users\MIKE\Documents\Visual Studio 2017\Projects\BlazorTests\BlazorTests.Client\Pages\book.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9212f6808340f9830ffa63681fe39010e1244fdb"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    using BlazorTests.Shared;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/books")]
    public class book : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 52 "C:\Users\MIKE\Documents\Visual Studio 2017\Projects\BlazorTests\BlazorTests.Client\Pages\book.cshtml"
            
    string inOrOut = "OUT";

    void OnMouseOver()
    {
        inOrOut = "IN!";
    }

    void OnMouseOut()
    {
        inOrOut = "OUT";
    }
    Author[] authors;
    Book[] books;
    Book selectedBook;
    ElementRef bookSelect;


    protected override async Task OnInitAsync()
    {
        authors = await http.GetJsonAsync<Author[]>("/api/book");
    }


    void AuthorSelectionChanged(UIChangeEventArgs e)
    {
        books = null;
        if (int.TryParse(e.Value.ToString(), out int id))
        {
            books = authors.First(a => a.AuthorId == id).Books.ToArray();
        }
        bookSelect.ResetSelectedIndex();
    }

    void BookSelectionChanged(UIChangeEventArgs e)
    {
        if (int.TryParse(e.Value.ToString(), out int id))
        {
            selectedBook = books.FirstOrDefault(b => b.BookId == id);
        }
        else
        {
            selectedBook = null;
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
