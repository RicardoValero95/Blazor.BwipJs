# Blazor.BwipJs
A Blazor wrapper for the JavaScript library [bwip-js (Barcode Writer in Pure Javascript)](http://bwip-js.metafloor.com/)

**Please note**
- Work in progress
- Tested with client-side Blazor Wasm **only**

## Demo
https://ricardovalero95.github.io/Blazor.BwipJs/

## Prerequisites
- [.NET 5.0](https://dotnet.microsoft.com/download/dotnet/5.0) or newer

## Getting Started
### Installation
*Work in progress.*

Install the package
```bash
dotnet add package Blazor.BwipJs
```
### Assets
Add a reference to the JavaScript library in `index.html` (client-side) or `_Host.cshtml` (server-side) in the `body` tag after the `_framework` reference
```html
<script src="https://cdn.jsdelivr.net/npm/bwip-js@2.1.1/dist/bwip-js.min.js"></script>
```
### Imports
Add a reference to the package in `_Imports.razor`
```razor
@using Blazor.BwipJs
```
### Services
Register the service
- in `Program.cs` (client-side)
```csharp
builder.Services.AddBlazorBwipJs();
```
- or in `Startup.cs` (server-side)
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
This Blazor wrapper was built based on 
- learning about wrapping a JavaScript library 
  - [Wrapping JavaScript libraries in Blazor WebAssembly/WASM](https://blog.elmah.io/wrapping-javascript-libraries-in-blazor-webassembly-wasm/)
  - [Wrapping JavaScript Libraries with C# in Blazor WebAssembly](https://code-maze.com/wrapping-javascript-libraries-with-csharp-in-blazor-webassembly/)
- learning about GitHub actions 
  - [Deploy .NET Core web application using GitHub Actions](https://rajbos.github.io/blog/2019/10/26/Deploy-dotnetcore-webapp-with-GitHub-Actions)
  - [Publish NuGet packages using GitHub Actions](https://netlicensing.medium.com/publish-nuget-packages-using-github-actions-9ac5e97d07d4)
- taking inspiration (mainly for file and folder structure)
  - [MudBlazor](https://github.com/Garderoben/MudBlazor)
  - [Blazor-ApexCharts](https://github.com/joadan/Blazor-ApexCharts)
  - [Plotly.Blazor](https://github.com/LayTec-AG/Plotly.Blazor)
  - [ChartJs.Blazor](https://github.com/mariusmuntean/ChartJs.Blazor)
  - [BlazorAudioFFT](https://github.com/sonicmouse/BlazorAudioFFT)
  - [Razor.SweetAlert2](https://github.com/Basaingeal/Razor.SweetAlert2)

Useful GitHub docs
- [Building and testing .NET](https://docs.github.com/en/actions/guides/building-and-testing-net)
- [Managing releases in a repository](https://docs.github.com/en/github/administering-a-repository/managing-releases-in-a-repository)

This is my first ever public repo, if you have any suggestions please contact me on Gitter or create an issue.
