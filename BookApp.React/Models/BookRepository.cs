using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Dul.Articles;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BookApp.React.Models
{
    public class BookRepository : IBookRepository
    {
        private readonly BookAppDBContext _context;
        private readonly ILogger _logger;
        
        public BookRepository(BookAppDBContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger(nameof(BookRepository));
        }

        #region AddAsync

        public async Task<Book> AddAsync(Book model)
        {
            try
            {
                _context.Books.Add(model);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                _logger?.LogError($"e.Message");
            }

            // throw new System.NotImplementedException();
            return model;
        }

        #endregion

        #region GetAllAsync

        public async Task<List<Book>> GetAllAsync()
        {
            return await _context.Books.OrderByDescending(m => m.Id).ToListAsync();
        }

        #endregion

        public async Task<Book> GetByIdAsync(int id)
        {
            var model = await _context.Books.SingleOrDefaultAsync(m=>m.Id==id);
            // var model = await _context.Books.SingleOrDefault(m=>m.Id==id);
            return model;
        }

        public async Task<bool> UpdateAsync(Book model)
        {
            try
            {
                _context.Update(model);
                return (await _context.SaveChangesAsync() > 0 ? true : false);

            }
            catch (Exception e)
            {
                _logger?.LogError($"e.Message");
            }

            return false;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                var model = await _context.Books.FindAsync(id);
                _context.Remove(model);
                return (await _context.SaveChangesAsync() > 0 ? true : false);
            }
            catch (Exception e)
            {
                _logger?.LogError($"e.Message");
            }

            return false;
        }

        public Task<ArticleSet<Book, int>> GetArticlesAsync<TParentIdentifier>(int pageIndex, int pageSize, string searchField, string searchQuery,
            string sortOrder, TParentIdentifier parentIdentifier)
        {
            throw new NotImplementedException();
        }
    }
}