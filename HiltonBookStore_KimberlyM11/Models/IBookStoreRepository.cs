namespace HiltonBookStore_KimberlyM11.Models
{
    public interface IBookStoreRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
