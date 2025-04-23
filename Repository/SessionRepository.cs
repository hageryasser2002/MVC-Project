using MVC_Projec2.Models;

namespace MVC_Projec2.Repository
{
    public class SessionRepository:ISessionRepository
    {
        MVCProjectContext _context;
        public SessionRepository(MVCProjectContext context)
        {
            _context = context;
        }

        public void Delete(Session obj)
        {
            _context.Sessions.Remove(obj);
        }

        public List<Session> GetAll()
        {
            return _context.Sessions.ToList();
        }

        public Session GetById(int id)
        {
            return _context.Sessions.Where(s => s.Id == id).FirstOrDefault();
        }

        public void insert(Session obj)
        {
            _context.Sessions.Add(obj);
        }

        public void Update(Session obj)
        {
            _context.Sessions.Update(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
