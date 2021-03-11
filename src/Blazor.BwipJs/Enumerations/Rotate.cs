using System.ComponentModel;

namespace Blazor.BwipJs
{
    public enum Rotate
    {
        [Description("Normal")] N,
        [Description("Clockwise(right) 90 degree rotate")] R,
        [Description("Counter-clockwise (left) 90 degree rotate")] L,
        [Description("Inverted 180 degree rotate")] I
    }
}
