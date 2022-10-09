using Boilerplate.Libraries.Data;
using Boilerplate.Libraries.Repositories;
using Boilerplate.Libraries.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddDbContext<Context>(
        options => options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddBoilerplateRepositories();
builder.Services.AddBoilerplateServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
