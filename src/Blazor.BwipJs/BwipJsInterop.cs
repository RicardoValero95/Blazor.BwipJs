using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace Blazor.BwipJs
{
    public interface IBwipJsInterop : IAsyncDisposable
    {
		ValueTask Create(ElementReference canvasReference, Option option);
    }
    public class BwipJsInterop : IBwipJsInterop
    {
        private readonly Lazy<Task<IJSObjectReference>> moduleTask;

        public BwipJsInterop(IJSRuntime jsRuntime)
        {
            moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
               "import", "./_content/Blazor.BwipJs/bwipJsInterop.js").AsTask());
        }

        public async ValueTask Create(ElementReference canvasReference, Option option)
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("create", canvasReference, option);
        }

        public async ValueTask DisposeAsync()
        {
            if (moduleTask.IsValueCreated)
            {
                var module = await moduleTask.Value;
                await module.DisposeAsync();
            }
        }
    }
}
