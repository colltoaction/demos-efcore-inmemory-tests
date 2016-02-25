using Microsoft.Data.Entity;
using Service.Controllers;
using Service.Models;
using System;
using Xunit;

namespace Service.Test
{
    public class ValuesControllerTests
    {
        [Fact]
        public void ReturnDatabaseValues()
        {
            var id = Guid.NewGuid();
            var optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseInMemoryDatabase();
            var ctx = new ServiceContext(optionsBuilder.Options);
            ctx.People.Add(new Person { Id = id });
            ctx.SaveChanges();
            var ctr = new ValuesController(ctx);
            Assert.Equal(ctr.Get(), new string[] { id.ToString() });
        }
    }
}
