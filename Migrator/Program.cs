using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;
using System.CommandLine;
using Microsoft.Extensions.Configuration;

AppDomain.CurrentDomain.UnhandledException += (sender, e) => Environment.Exit(1);

var upOption = new Option<bool>("--up", description: "Migrate Up", getDefaultValue: () => false);
var downOption = new Option<long>("--down", description: "Rollback database to a version", getDefaultValue: () => -1);

var rootCommand = new RootCommand("BIAS Fluent Migrator Runner")
{
    upOption,
    downOption,
};

rootCommand.SetHandler((up, down) =>
{
    var serviceProvider = CreateServices();

    using var scope = serviceProvider.CreateScope();
    if (up)
        UpdateDatabase(scope.ServiceProvider);

    if (down > -1)
        RollbackDatabase(scope.ServiceProvider, down);
    
}, upOption, downOption);

await rootCommand.InvokeAsync(args);
return;

static ServiceProvider CreateServices()
{
    var config = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appSettings.json", optional: true, reloadOnChange: true)
        .Build();
    
    var conn = config["ConnectionStrings:DefaultConnection"];
    
    return new ServiceCollection()
        // Add common FluentMigrator services
        .AddFluentMigratorCore()
        .ConfigureRunner(rb => rb
            // Add Postgres support to FluentMigrator
            .AddPostgres()
            // Set the connection string
            .WithGlobalConnectionString(conn) // Define the assembly containing the migrations
            .ScanIn(typeof(_0001_CreateUserTable).Assembly).For.Migrations())
        // Enable logging to console in the FluentMigrator way
        .AddLogging(lb => lb.AddFluentMigratorConsole())
        // Build the service provider
        .BuildServiceProvider(false);
}

static void UpdateDatabase(IServiceProvider serviceProvider)
{
    Console.WriteLine("Going up...");
    var runner = serviceProvider.GetRequiredService<IMigrationRunner>();
    runner.MigrateUp();
}

static void RollbackDatabase(IServiceProvider serviceProvider, long rollbackVersion)
{
    Console.WriteLine("Going down...");
    var runner = serviceProvider.GetRequiredService<IMigrationRunner>();
    runner.MigrateDown(rollbackVersion);
}