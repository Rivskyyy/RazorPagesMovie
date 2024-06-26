using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int id { get; set; }
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaaseDate { get; set; }
        public string? Genre { get; set; }
        public decimal Price { get; set; }

    }
}
