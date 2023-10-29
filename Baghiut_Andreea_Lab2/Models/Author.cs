using Microsoft.EntityFrameworkCore.Migrations;

namespace Baghiut_Andreea_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }
    }
}