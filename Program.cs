using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder();
Console.WriteLine(builder.Environment.EnvironmentName);
var host = builder.Build();
var confService = host.Services.GetService(typeof(IConfiguration)) as IConfiguration;
var url = confService.GetValue<string>("UrlOfThatImportantService");
Console.WriteLine($"UrlOfThatImportantService: {url}");