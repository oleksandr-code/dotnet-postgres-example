using System;
using System.Linq;
using ExampleSolution.Db;
using Xunit;

namespace ExampleSolution.TestProject
{
    [Collection("Database")]
    public abstract class DatabaseTest
    {
        protected readonly MyDbContext DbContext;

        protected DatabaseTest(DatabaseFixture databaseFixture)
        {
            DbContext = databaseFixture.DbContext;
        }
    }
}