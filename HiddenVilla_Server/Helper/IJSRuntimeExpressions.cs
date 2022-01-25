using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace HiddenVilla_Server.Helper
{
    public static class IJSRuntimeExpressions
    {
        public static async ValueTask ToastrWarning(this IJSRuntime JSRuntime, string message)
        {
            await JSRuntime.InvokeVoidAsync("ShowToastr", "warning", message);
        }

        public static async ValueTask ToastrSuccess(this IJSRuntime JSRuntime, string message)
        {
            await JSRuntime.InvokeVoidAsync("ShowToastr", "success", message);
        }

        public static async ValueTask ToastrError(this IJSRuntime JSRuntime, string message)
        {
            await JSRuntime.InvokeVoidAsync("ShowToastr", "error", message);
        }

        public static async ValueTask SwalSuccess(this IJSRuntime JSRuntime, string messageOne, string messageTwo)
        {
            await JSRuntime.InvokeVoidAsync("ShowSwal", "success", messageOne, messageTwo);
        }

        public static async ValueTask SwalWarning(this IJSRuntime JSRuntime, string messageOne, string messageTwo)
        {
            await JSRuntime.InvokeVoidAsync("ShowSwal", "warning", messageOne, messageTwo);
        }

        public static async ValueTask SwalError(this IJSRuntime JSRuntime, string messageOne, string messageTwo)
        {
            await JSRuntime.InvokeVoidAsync("ShowSwal", "error", messageOne, messageTwo);
        }
    }
}
