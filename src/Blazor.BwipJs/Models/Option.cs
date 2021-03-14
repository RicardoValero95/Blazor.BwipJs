using System.Text.Json.Serialization;

namespace Blazor.BwipJs
{
    public record Option
    {
        public Option(string text, BarcodeType barcodeType, int scaleX, int? scaleY, int height, int? width, bool includeText, TextXAlign textXAlign, TextYAlign textYAlign, Rotate rotate)
        {
            Text = text;
            BarcodeType = barcodeType;
            ScaleX = scaleX;
            ScaleY = scaleY;
            Height = height;
            Width = width;
            IncludeText = includeText;
            TextXAlign = textXAlign;
            TextYAlign = textYAlign;
            Rotate = rotate;
        }

        public string Text { get; init; }
        [JsonConverter(typeof(EnumNameReplaceDashConverter<BarcodeType>))]
        public BarcodeType BarcodeType { get; init; }
        public int ScaleX { get; init; }
        public int? ScaleY { get; init; }
        public int Height { get; init; }
        public int? Width { get; init; }
        public bool IncludeText { get; init; }
        [JsonConverter(typeof(EnumNameConverter<TextXAlign>))]
        public TextXAlign TextXAlign { get; init; }
        [JsonConverter(typeof(EnumNameConverter<TextYAlign>))]
        public TextYAlign TextYAlign { get; init; }
        [JsonConverter(typeof(EnumNameConverter<Rotate>))]
        public Rotate Rotate { get; init; }
    }
}
