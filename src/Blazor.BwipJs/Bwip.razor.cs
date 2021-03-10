using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.BwipJs
{
    /// <summary>
    /// https://github.com/mariusmuntean/ChartJs.Blazor/blob/master/src/ChartJs.Blazor/Chart.razor
    /// https://github.com/KristofferStrube/Blazor.Popper
    /// https://code-maze.com/wrapping-javascript-libraries-with-csharp-in-blazor-webassembly/
    /// https://github.com/CodeMazeBlog/BlazorWasmJsInterop/tree/wrapping-js-library-blazor-webassembly/BlazorWasmJSInteropExamples/BlazorWasm.Toastr
    /// </summary>
    public partial class Bwip
    {
        [Inject] private IBwipJsInterop BwipJsInterop { get; set; }
        [Parameter] public BarcodeType BarcodeType { get; set; } = 0;
        [Parameter] public string Text { get; set; }
        [Parameter] public bool IncludeText { get; set; } = true;
        [Parameter] public TextXAlign TextXAlign { get; set; }
        [Parameter] public TextYAlign TextYAlign { get; set; }
        [Parameter] public int ScaleX { get; set; } = 2;
        [Parameter] public int? ScaleY { get; set; }
        [Parameter] public int Height { get; set; } = 10;
        [Parameter] public int? Width { get; set; }
        [Parameter] public Rotate Rotate { get; set; }

        public ElementReference CanvasReference { get; set; } = new ElementReference();
        private Option Option { get; set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            Option = new Option(Text, BarcodeType, ScaleX, ScaleY, Height, Width, IncludeText, TextXAlign, TextYAlign, Rotate);
            await BwipJsInterop.Create(CanvasReference, Option);
            await base.OnAfterRenderAsync(firstRender);
        }
    }
}
