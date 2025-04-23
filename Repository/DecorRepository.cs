using MVC_Projec2.Models;

namespace MVC_Projec2.Repository
{
    public class DecorRepository : IDecorRepository
    {
        MVCProjectContext _context;
        public DecorRepository(MVCProjectContext context)
        {
            _context = context;
        }

        public void Delete(Decor obj)
        {
            _context.Decors.Remove(obj);
        }

        public List<Decor> GetAll()
        {
            return _context.Decors.ToList();
        }

        public Decor GetById(int id)
        {
            return _context.Decors.Where(d => d.Id == id).FirstOrDefault();
        }

        public void insert(Decor obj)
        {
            _context.Decors.Add(obj);
        }

        public void Update(Decor obj)
        {
            _context.Decors.Update(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
