using System;
using ExampleSolution.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Xunit;

namespace ExampleSolution.TestProject
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class DatabaseFixture : IDisposable
    {
        public MyDbContext DbContext { get; }

        public DatabaseFixture()
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.test.json").Build();

            var builder = new DbContextOptionsBuilder<MyDbContext>();
            builder.UseNpgsql(configuration["ConnectionStrings:MyDatabase"]);
            DbContext = new MyDbContext(builder.Options);
            DbContext.Database.EnsureCreated();
        }

        public void Dispose()
        {
        }
    }
    
    [CollectionDefinition("Database")]
    public class DatabaseCollectionFixture : ICollectionFixture<DatabaseFixture>
    {
    }
}