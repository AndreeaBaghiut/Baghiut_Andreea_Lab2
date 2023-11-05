namespace Baghiut_Andreea_Lab2.Models
{
    public class BookData
    {
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<Category> Category { get; set; }
        public IEnumerable<BookCategory> BookCategories { get; set; }
    }
}
