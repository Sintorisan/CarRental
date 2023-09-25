using CarRental.App;
using CarRental.BusinessLogic.Classes;
using CarRental.Data.Classes;
using CarRental.Common.Interfaces;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddSingleton<BookingLogic>();
builder.Services.AddSingleton<IData, CollectionData>();


await builder.Build().RunAsync();
