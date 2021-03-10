using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.BwipJs
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBlazorBwipJs(this IServiceCollection services)
            => services.AddScoped<IBwipJsInterop, BwipJsInterop>();
    }
}
