Blazor.registerFunction('BlazorFocus.ResetSelectedIndex', function (element) {
    if (element !== null) {
        element.selectedIndex = -1;
    }
});