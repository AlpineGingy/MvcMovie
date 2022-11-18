using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Title { get; set; }
        
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        // [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        // [Required]
        // [StringLength(30)]
        [Display(Name = "Genre")]
        public int GenreId { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string Rating {get; set; }

        [Display(Name = "Image URL")]
        [DataType(DataType.ImageUrl)]
        public string? ImageUrl {get; set; }

        // nav properties

        public Genre Genre { get; set; }

    }
}