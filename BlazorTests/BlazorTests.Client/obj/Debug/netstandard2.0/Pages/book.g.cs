#pragma checksum "C:\Users\MIKE\Documents\GitHub\BlazorTests\BlazorTests\BlazorTests.Client\Pages\book.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73208c0cce209ccf2d5d6178fde1003c898d7336"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorTests.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
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
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "h1");
            builder.AddContent(1, "Books");
            builder.CloseElement();
            builder.AddContent(2, "\n\n");
            builder.OpenElement(3, "p");
            builder.AddContent(4, "This component demonstrates fetching data from the server.");
            builder.CloseElement();
            builder.AddContent(5, "\n\n");
#line 9 "C:\Users\MIKE\Documents\GitHub\BlazorTests\BlazorTests\BlazorTests.Client\Pages\book.cshtml"
 if (authors == null)
{

#line default
#line hidden
            builder.AddContent(6, "    ");
            builder.OpenElement(7, "p");
            builder.OpenElement(8, "em");
            builder.AddContent(9, "Loading...");
            builder.CloseElement();
            builder.CloseElement();
            builder.AddContent(10, "\n");
#line 12 "C:\Users\MIKE\Documents\GitHub\BlazorTests\BlazorTests\BlazorTests.Client\Pages\book.cshtml"
}
else
{

#line default
#line hidden
            builder.AddContent(11, "    ");
            builder.OpenElement(12, "select");
            builder.AddAttribute(13, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(SelectedAuthorId));
            builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => SelectedAuthorId = __value, SelectedAuthorId));
            builder.AddContent(15, "\n        ");
            builder.OpenElement(16, "option");
            builder.AddAttribute(17, "value", 0);
            builder.CloseElement();
            builder.AddContent(18, "\n");
#line 17 "C:\Users\MIKE\Documents\GitHub\BlazorTests\BlazorTests\BlazorTests.Client\Pages\book.cshtml"
         foreach (var author in authors)
        {

#line default
#line hidden
            builder.AddContent(19, "            ");
            builder.OpenElement(20, "option");
            builder.AddAttribute(21, "value", author.AuthorId);
            builder.AddContent(22, author.Name);
            builder.CloseElement();
            builder.AddContent(23, "\n");
#line 20 "C:\Users\MIKE\Documents\GitHub\BlazorTests\BlazorTests\BlazorTests.Client\Pages\book.cshtml"
        }

#line default
#line hidden
            builder.AddContent(24, "    ");
            builder.CloseElement();
            builder.AddContent(25, "\n");
#line 22 "C:\Users\MIKE\Documents\GitHub\BlazorTests\BlazorTests\BlazorTests.Client\Pages\book.cshtml"
}

#line default
#line hidden
            builder.AddContent(26, "\n");
#line 24 "C:\Users\MIKE\Documents\GitHub\BlazorTests\BlazorTests\BlazorTests.Client\Pages\book.cshtml"
 if (SelectedAuthorId != default)
{
    var books = authors.Single(x => x.AuthorId == SelectedAuthorId).Books;


#line default
#line hidden
            builder.AddContent(27, "    ");
            builder.OpenElement(28, "select");
            builder.AddAttribute(29, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(SelectedBookId));
            builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => SelectedBookId = __value, SelectedBookId));
            builder.AddContent(31, "\n        ");
            builder.OpenElement(32, "option");
            builder.AddAttribute(33, "value", 0);
            builder.CloseElement();
            builder.AddContent(34, "\n");
#line 30 "C:\Users\MIKE\Documents\GitHub\BlazorTests\BlazorTests\BlazorTests.Client\Pages\book.cshtml"
         foreach (var book in books)
        {

#line default
#line hidden
            builder.AddContent(35, "            ");
            builder.OpenElement(36, "option");
            builder.AddAttribute(37, "value", book.BookId);
            builder.AddContent(38, book.Title);
            builder.CloseElement();
            builder.AddContent(39, "\n");
#line 33 "C:\Users\MIKE\Documents\GitHub\BlazorTests\BlazorTests\BlazorTests.Client\Pages\book.cshtml"
        }

#line default
#line hidden
            builder.AddContent(40, "    ");
            builder.CloseElement();
            builder.AddContent(41, "\n");
#line 35 "C:\Users\MIKE\Documents\GitHub\BlazorTests\BlazorTests\BlazorTests.Client\Pages\book.cshtml"

    var selectedBook = books.FirstOrDefault(x => x.BookId == SelectedBookId);
    

#line default
#line hidden
#line 37 "C:\Users\MIKE\Documents\GitHub\BlazorTests\BlazorTests\BlazorTests.Client\Pages\book.cshtml"
     if (selectedBook != null)
    {

#line default
#line hidden
            builder.AddContent(42, "        ");
            builder.OpenElement(43, "div");
            builder.AddContent(44, "\n            Title: ");
            builder.AddContent(45, selectedBook.Title);
            builder.OpenElement(46, "br");
            builder.CloseElement();
            builder.AddContent(47, "\n            Year published: ");
            builder.AddContent(48, selectedBook.YearPublished);
            builder.OpenElement(49, "br");
            builder.CloseElement();
            builder.AddContent(50, "\n            Price: ");
            builder.AddContent(51, selectedBook.Price);
            builder.AddContent(52, "\n        ");
            builder.CloseElement();
            builder.AddContent(53, "\n");
#line 44 "C:\Users\MIKE\Documents\GitHub\BlazorTests\BlazorTests\BlazorTests.Client\Pages\book.cshtml"
    }

#line default
#line hidden
#line 44 "C:\Users\MIKE\Documents\GitHub\BlazorTests\BlazorTests\BlazorTests.Client\Pages\book.cshtml"
     
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 47 "C:\Users\MIKE\Documents\GitHub\BlazorTests\BlazorTests\BlazorTests.Client\Pages\book.cshtml"
            
Author[] authors;

// Track the selected author ID, and when it's written to, reset SelectedBookId
int _selectedAuthorId;
int SelectedAuthorId
{
    get => _selectedAuthorId;
    set
    {
        _selectedAuthorId = value;
        SelectedBookId = default;
    }
}

int SelectedBookId { get; set; }

protected override async Task OnInitAsync()
{
    authors = await http.GetJsonAsync<Author[]>("/api/book");
}

#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
