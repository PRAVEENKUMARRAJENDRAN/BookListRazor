using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookListRazor.Models
{
    public class Book
    {

        //The id identifier is required by the database for primary key..
        public int Id { get; set; }
        public string bookName { get; set; } = string.Empty;

        // THe datatype line is to mention the format of the releasedate as Date 
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

    }
}
