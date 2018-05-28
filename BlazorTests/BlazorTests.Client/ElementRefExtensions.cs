using System;
using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Blazor.Browser.Interop;

namespace BlazorTests.Client
{
    public static class ElementRefExtensions
    {
        public static void ResetSelectedIndex(this ElementRef elementRef)
        {
            RegisteredFunction.Invoke<object>("BlazorFocus.ResetSelectedIndex", elementRef);
        }
    }
}