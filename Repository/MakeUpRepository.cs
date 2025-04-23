using MVC_Projec2.Models;

namespace MVC_Projec2.Repository
{
    public class MakeUpRepository : IMakeUpRepository
    {
        MVCProjectContext _context;
        public MakeUpRepository(MVCProjectContext context)
        {
            _context = context;
        }

        public void Delete(MakeUp_Service obj)
        {
            _context.MakeUpServices.Remove(obj);
        }

        public List<MakeUp_Service> GetAll()
        {
            return _context.MakeUpServices.ToList();
        }

        public MakeUp_Service GetById(int id)
        {
            return _context.MakeUpServices.Where(m => m.Id == id).FirstOrDefault();
        }

        public void insert(MakeUp_Service obj)
        {
            _context.MakeUpServices.Add(obj);
        }

        public void Update(MakeUp_Service obj)
        {
            _context.MakeUpServices.Update(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
