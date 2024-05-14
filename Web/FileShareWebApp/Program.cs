using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);
IWebHostEnvironment env=builder.Environment;
var app = builder.Build();
var protoProvider = new FileExtensionContentTypeProvider();
    protoProvider.Mappings.Clear();
    protoProvider.Mappings[".proto"] = "text/plain";

app.UseStaticFiles(new StaticFileOptions
    {
        FileProvider = new PhysicalFileProvider(Path.Combine(env.ContentRootPath, "Share\\Protos")),
        RequestPath = "/Share/protos",
        ContentTypeProvider = protoProvider

    });
app.UseDirectoryBrowser(new DirectoryBrowserOptions
{
    FileProvider = new PhysicalFileProvider(Path.Combine(env.ContentRootPath, "Share")),
    RequestPath = "/share"
});

app.MapGet("/", () => "Hello World!");

app.Run();
