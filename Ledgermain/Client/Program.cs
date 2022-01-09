using Ledgermain.Client;
using Ledgermain.Shared;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

using System.Reactive.Subjects;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// ?????

builder.Services.AddScoped(sp => new Subject<Transaction>());

// ?????

await builder.Build().RunAsync();
