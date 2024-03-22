using HiltonBookStore_KimberlyM11.Models;
namespace HiltonBookStore_KimberlyM11.Models
{
    public class EFBookStoreRepository : IBookStoreRepository
    {
        private readonly BookstoreContext _context;

        public EFBookStoreRepository(BookstoreContext context)
        {
            _context = context;
        }

        // get table and load
        public IQueryable<Book> Books => _context.Books;
    }
}

