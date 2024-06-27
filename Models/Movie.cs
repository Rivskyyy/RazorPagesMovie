using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int id { get; set; }
        public string? Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaaseDate { get; set; }
        public string? Genre { get; set; }

        [Column(TypeName = "decimal(18,2")]
        public decimal Price { get; set; }

    }
}
