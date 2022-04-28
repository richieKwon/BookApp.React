using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Dul.Articles;

namespace BookApp.React.Models
{
    

    // public interface ICrudRepository<T, Tidentifier>
    // {
    //     Task<T> AddAsync(T model);
    //     Task<List<T>> GetAllAsync();
    //     Task<T> GetByIdAsync(Tidentifier id);
    //     Task<bool> UpdateAsync(T model);
    //     Task<bool> DeleteAsync(Tidentifier id);
    // }
    
    public interface IBookCrudRepository<T>: ICrudRepositoryBase<T, int> where T : class
    {
   
    }

    public interface IBookRepository : IBookCrudRepository<Book>
    {
        
    }

}