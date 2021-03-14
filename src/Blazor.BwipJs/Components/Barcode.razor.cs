using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Blazor.BwipJs
{
    public partial class Barcode
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
        [Parameter] public Rotate Rotate { get; set; } = Rotate.N;

        private ElementReference CanvasReference { get; set; } = new();
        private Option Option => new (Text, BarcodeType, ScaleX, ScaleY, Height, Width, IncludeText, TextXAlign, TextYAlign, Rotate);

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await BwipJsInterop.Create(CanvasReference, Option);
            await base.OnAfterRenderAsync(firstRender);
        }
    }
}
