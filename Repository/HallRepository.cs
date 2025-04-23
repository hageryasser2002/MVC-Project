using MVC_Projec2.Models;

namespace MVC_Projec2.Repository
{
    public class HallRepository : IHallRepository
    {
        MVCProjectContext _context;
        public HallRepository(MVCProjectContext context)
        {
            _context = context;
        }

        public void Delete(Hall obj)
        {
            _context.Halls.Remove(obj);
        }

        public List<Hall> GetAll()
        {
           return _context.Halls.ToList();
        }

        public Hall GetById(int id)
        {
            return _context.Halls.Where(h => h.Id == id).FirstOrDefault();
        }

        public void insert(Hall obj)
        {
            _context.Halls.Add(obj);
        }

        public void Update(Hall obj)
        {
            _context.Halls.Update(obj);
        }
        
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
