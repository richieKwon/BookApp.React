using System;
using System.Threading.Tasks;
using BookApp.React.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static BookApp.React.Models.BookAppDBContext;

namespace TestBook
{
    [TestClass]
    public class BookRepositoryTest
    {
        [TestMethod]
        public async Task BookRepositoryAllMethodTest()
        {
            var options = new DbContextOptionsBuilder<BookAppDBContext>().UseInMemoryDatabase(
                databaseName: $"BookApp{Guid.NewGuid()}").Options;
            var serviceProvider = new ServiceCollection().AddLogging().BuildServiceProvider();
            var factory = serviceProvider.GetService<ILoggerFactory>();
        }
        using (var context = new BookAppDBContext(options))
        {
            context.Database.EnsureCreated();
            
            var reoposit

        }
    }
}   