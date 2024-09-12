using Microsoft.JSInterop;

namespace LearnBlazor.Helpers
{
    // static class can not be instantiated. members can be used directly on the class ??
    public static class IJSRuntimeExtension
    {
        // Extending the IJSRuntime class with customized methods
        public static async Task ToastrSuccess(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("showToastr", "success", message);
        }
        public static async Task ToastrError(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("showToastr", "error", message);
        }
    }
}
