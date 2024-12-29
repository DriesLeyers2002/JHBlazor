using Jeugdhuis;
using Jeugdhuis.Components;
using Jeugdhuis.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Radzen;
using System.Net;
using System.Net.Security;

ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, errors) =>
{
    // local dev, just approve all certs
    return true;
};

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient<PayconiqService>();
builder.Services.AddSingleton<IConfiguration>(builder.Configuration);
builder.Services.AddControllers();
builder.Services.AddSignalR();

builder.Services.AddResponseCompression(opts =>
{
    opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
        ["application/octet-stream"]);
});

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped<ThemeService>();
builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<ContextMenuService>();
builder.Services.AddScoped<TooltipService>();
builder.Services.AddScoped<DialogService>();
builder.Services.AddSingleton<NfcService>();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
    new MySqlServerVersion(new Version(8, 3, 0)))
            .EnableSensitiveDataLogging());

builder.Services.AddIdentity<Boardmember, IdentityRole>() 
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddAuthorizationCore();

builder.Services.AddScoped<CookieEvents>();

builder.Services.ConfigureApplicationCookie(opt =>
{
    opt.EventsType = typeof(CookieEvents);
});

builder.WebHost.ConfigureKestrel(serverOptions =>
{
    serverOptions.Listen(IPAddress.Any, 44300, listenOptions => // For HTTPS
    {
        listenOptions.UseHttps(); // Ensure you have SSL certificates configured
    });
});

var app = builder.Build();

app.MapControllers();

app.UseResponseCompression();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseMiddleware<BlazorCookieLoginMiddleware>();

app.UseAntiforgery();

app.MapRazorComponents<App>().AddInteractiveServerRenderMode();


app.MapHub<PaymentHub>("/paymentHub");



app.Run();
