using _5LettersSolver;
using _5LettersSolver.Core;
using _5LettersSolver.Data;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

//SQLitePCL.Batteries_V2.Init();

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IWordsServices, WordsServices>();
builder.Services.AddScoped<IWordsRepository, JsonWordsRepository>();

await builder.Build().RunAsync();
