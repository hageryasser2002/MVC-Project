using MVC_Projec2.Models;

namespace MVC_Projec2.Repository
{
    public class BookingRepository : IBookingReposirtory
    {
        MVCProjectContext _context;
        public BookingRepository(MVCProjectContext context)
        {
            _context = context;
        }

        public void Delete(Booking obj)
        {
            _context.Bookings.Remove(obj);
        }

        public List<Booking> GetAll()
        {
            return _context.Bookings.ToList();
        }

        public Booking GetById(int id)
        {
            return _context.Bookings.Where(a => a.Id == id).FirstOrDefault();
        }

        public void insert(Booking obj)
        {
            _context.Bookings.Add(obj);
        }

        public void Update(Booking obj)
        {
            _context.Bookings.Update(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
