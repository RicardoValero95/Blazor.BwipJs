using Microsoft.Extensions.DependencyInjection;

namespace Blazor.BwipJs
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBlazorBwipJs(this IServiceCollection services)
            => services.AddScoped<IBwipJsInterop, BwipJsInterop>();
    }
}