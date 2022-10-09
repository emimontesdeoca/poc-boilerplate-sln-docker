using Boilerplate.Libraries.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

// Build configuration
Console.WriteLine($"Setting configurations");
var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", false)
    .Build();

// Services
Console.WriteLine($"Setting services");
var serviceProvider = new ServiceCollection()
.AddDbContext<Context>(
        options => options.UseSqlServer(configuration.GetConnectionString("Default")))
.BuildServiceProvider();

// Get context
Console.WriteLine($"Getting context");
var context = serviceProvider.GetRequiredService<Context>();

// Run migrations
Console.WriteLine($"Running migrations");
context.Database.Migrate();

Console.WriteLine($"Migrations finished");