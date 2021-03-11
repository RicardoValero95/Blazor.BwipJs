# Blazor.BwipJs
A Blazor wrapper for the JavaScript library [bwip-js (Barcode Writer in Pure Javascript)](http://bwip-js.metafloor.com/).
*It's only been tested for client-side Blazor Wasm.*

## Demo
*Work in progress.*

## Prerequisites
- [.NET 5.0](https://dotnet.microsoft.com/download/dotnet/5.0) or newer

## Getting Started
### Installation
*Work in progress.*
Install the package.
```bash
dotnet add package Blazor.BwipJs
```
### Assets
Add a reference to the JavaScript library in `index.html` (client-side) or `_Host.cshtml` (server-side) in the `body`.
```html
<script src="https://cdn.jsdelivr.net/npm/bwip-js@2.1.1/dist/bwip-js.min.js"></script>
```
### Import
Add a reference to the package in `_Imports.razor`.
```razor
@using Blazor.BwipJs
```
### Service
Register the service
- in `Program.cs` (client-side)
```csharp
builder.Services.AddBlazorBwipJs();
```
- or in `Startup.cs` (server-side).
```csharp
services.AddBlazorBwipJs();
```
## Usage
```razor
<Barcode BarcodeType="@BarcodeType"
         Text="@Text"
         IncludeText="@IncludeText"
         TextXAlign="@TextXAlign"
         TextYAlign="@TextYAlign"
         ScaleX="@ScaleX"
         ScaleY="@ScaleY"
         Height="@Height"
         Width="@Width"
         Rotate="@Rotate" />
```

## References
This Blazor wrapper was build 
- based on these articles
  - [Wrapping JavaScript libraries in Blazor WebAssembly/WASM](https://blog.elmah.io/wrapping-javascript-libraries-in-blazor-webassembly-wasm/)
  - [Wrapping JavaScript Libraries with C# in Blazor WebAssembly](https://code-maze.com/wrapping-javascript-libraries-with-csharp-in-blazor-webassembly/)
- and took inspiration on these projects
  - [MudBlazor](https://github.com/Garderoben/MudBlazor)
  - [Plotly.Blazor](https://github.com/LayTec-AG/Plotly.Blazor)
  - [ChartJs.Blazor](https://github.com/mariusmuntean/ChartJs.Blazor)
  - [BlazorAudioFFT](https://github.com/sonicmouse/BlazorAudioFFT)
  - [Razor.SweetAlert2](https://github.com/Basaingeal/Razor.SweetAlert2)
