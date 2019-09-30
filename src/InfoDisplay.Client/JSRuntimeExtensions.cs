using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace InfoDisplay.Client
{
    public static class JSRuntimeExtensions
    {
        public static ValueTask<bool> Confirm(this IJSRuntime jsRuntime, string message)
        {
            return new ValueTask<bool>(jsRuntime.InvokeAsync<bool>("confirm", message));
        }
    }
}