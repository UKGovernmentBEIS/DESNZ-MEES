using Desnz.Mees.DataTool.Data;
using Desnz.Mees.DataTool.Data.Repositories;
using Desnz.Mees.DataTool.Domain.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//
builder.Services.AddOptions();
builder.Services.Configure<DataConfiguration>(builder.Configuration.GetSection("DataConfiguration"));
builder.Services.AddSingleton(cfg => cfg.GetService<IOptions<DataConfiguration>>()!.Value);
builder.Services.AddScoped<IEpcSummaryRepository, EpcSummaryRepository>();

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
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();