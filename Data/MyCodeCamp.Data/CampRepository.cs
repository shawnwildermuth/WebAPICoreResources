using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyCodeCamp.Data.Entities;

namespace MyCodeCamp.Data
{
  public class CampRepository : ICampRepository
  {
    private CampContext _context;

    public CampRepository(CampContext context)
    {
      _context = context;
    }

    public void Add<T>(T entity) where T : class
    {
      _context.Add(entity);
    }

    public void Delete<T>(T entity) where T : class
    {
      _context.Remove(entity);
    }

    public IEnumerable<Camp> GetAllCamps()
    {
      return _context.Camps.ToList();
    }

    public Camp GetCamp(int id)
    {
      return _context.Camps
        .Include(c => c.Location)
        .Where(c => c.Id == id)
        .FirstOrDefault();
    }

    public Camp GetCampWithSpeakers(int id)
    {
      return _context.Camps
        .Include(c => c.Location)
        .Include(c => c.Speakers)
        .ThenInclude(s => s.Talks)
        .Where(c => c.Id == id)
        .FirstOrDefault();
    }

    public async Task<bool> SaveAllAsync()
    {
      return (await _context.SaveChangesAsync()) > 0;
    }
  }
}
