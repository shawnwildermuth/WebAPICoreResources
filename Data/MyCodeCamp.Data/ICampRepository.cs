using System.Collections.Generic;
using System.Threading.Tasks;
using MyCodeCamp.Data.Entities;

namespace MyCodeCamp.Data
{
  public interface ICampRepository
  {
    // Basic DB Operations
    void Add<T>(T entity) where T : class;
    void Delete<T>(T entity) where T : class;
    Task<bool> SaveAllAsync();

    // Queries
    IEnumerable<Camp> GetAllCamps();
    Camp GetCamp(int id);
  }
}