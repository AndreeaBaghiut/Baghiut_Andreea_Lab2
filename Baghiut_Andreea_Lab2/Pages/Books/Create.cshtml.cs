using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Baghiut_Andreea_Lab2.Data;
using Baghiut_Andreea_Lab2.Models;

namespace Baghiut_Andreea_Lab2.Pages.Books
{
    public class CreateModel : BookCategoriesPageModel
    {
        private readonly Baghiut_Andreea_Lab2.Data.Baghiut_Andreea_Lab2Context _context;

        public CreateModel(Baghiut_Andreea_Lab2.Data.Baghiut_Andreea_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
             var authorList = _context.Author.Select(x => new
             {
             x.ID,
             FullName = x.LastName + " " + x.FirstName
             });
            
            // daca am adaugat o proprietate FullName in clasa Author
            ViewData["AuthorID"] = new SelectList(authorList, "ID", "FullName");
            ViewData["PublisherID"] = new SelectList(_context.Publisher, "ID",
           "PublisherName");

            var book = new Book();
            book.BookCategory = new List<BookCategory>();
            PopulateAssignedCategoryData(_context, book);
            return Page();
        }
        [BindProperty]
        public Book Book { get; set; }
        public async Task<IActionResult> OnPostAsync(string[] selectedCategories)
        {
            var newBook = new Book();
            if (selectedCategories != null)
            {
                newBook.BookCategory = new List<BookCategory>();
                foreach (var cat in selectedCategories)
                {
                    var catToAdd = new BookCategory
                    {
                        CategoryID = int.Parse(cat)
                    };
                    newBook.BookCategory.Add(catToAdd);
                }
            }
            Book.BookCategory = newBook.BookCategory;
            _context.Book.Add(Book);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }

    }
}