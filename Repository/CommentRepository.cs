using MVC_Projec2.Models;

namespace MVC_Projec2.Repository
{
    public class CommentRepository : ICommentRepository
    {
        MVCProjectContext _context;
        public CommentRepository(MVCProjectContext context)
        {
            _context = context;
        }

        public void Delete(Comment obj)
        {
            _context.Comments.Remove(obj);
        }

        public List<Comment> GetAll()
        {
            return _context.Comments.ToList();
        }

        public Comment GetById(int id)
        {
            return _context.Comments.Where(c => c.Id == id).FirstOrDefault();
        }

        public void insert(Comment obj)
        {
            _context.Comments.Add(obj);
        }

        public void Update(Comment obj)
        {
            _context.Comments.Update(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
