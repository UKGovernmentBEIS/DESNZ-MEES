using System.Security.Claims;
using Desnz.Mees.DataTool.Data;
using Desnz.Mees.DataTool.Data.Repositories;
using Desnz.Mees.DataTool.Domain.Configuration;
using idunno.Authentication.Basic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Basic Auth
builder.Services.AddAuthentication(BasicAuthenticationDefaults.AuthenticationScheme)
    .AddBasic(BasicAuthenticationDefaults.AuthenticationScheme, options =>
    {
        options.Realm = "Desnz.Mees";
        options.Events = new BasicAuthenticationEvents
        {
            OnValidateCredentials = context =>
            {
                var webConfig = context.HttpContext.RequestServices.GetService<IOptions<WebConfiguration>>();
                
                if (context.Username != webConfig!.Value.Username || context.Password != webConfig!.Value.Password) 
                    return Task.CompletedTask;
                
                var claims = new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, context.Username, ClaimValueTypes.String, context.Options.ClaimsIssuer),
                    new Claim(ClaimTypes.Name, context.Username, ClaimValueTypes.String, context.Options.ClaimsIssuer),
                };
                context.Principal = new ClaimsPrincipal(new ClaimsIdentity(claims, context.Scheme.Name));
                context.Success();
                
                return Task.CompletedTask;
            }
        };
    });
builder.Services.AddAuthorization();

// Add services to the container.
builder.Services.AddControllersWithViews(options =>
{
    var policy = new AuthorizationPolicyBuilder()
        .RequireAuthenticatedUser()
        .Build();
    options.Filters.Add(new AuthorizeFilter(policy));
    options.Filters.Add(new RequireHttpsAttribute());
});
// Config
builder.Services.AddOptions();
builder.Services.Configure<DataConfiguration>(builder.Configuration.GetSection("DataConfiguration"));
builder.Services.AddSingleton(cfg => cfg.GetService<IOptions<DataConfiguration>>()!.Value);
builder.Services.Configure<WebConfiguration>(builder.Configuration.GetSection("WebConfiguration"));
builder.Services.AddSingleton(cfg => cfg.GetService<IOptions<WebConfiguration>>()!.Value);
// repo
builder.Services.AddScoped<IEpcSummaryRepository, EpcSummaryRepository>();
// DBContext
var dataConfig = builder.Configuration.GetSection("DataConfiguration").Get<DataConfiguration>();
builder.Services.AddDbContext<DataToolContext>(options =>
    options.UseNpgsql(dataConfig!.DbConnectionString!));
builder.Services.AddScoped<IDataToolContext, DataToolContext>(provider => provider.GetService<DataToolContext>()!);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseHsts();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();