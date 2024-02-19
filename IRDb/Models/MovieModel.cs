using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IRDb.Models
{
    public class MovieModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Director { get; set; }
        public int Year { get; set; }
        public string? Genre { get; set; }
        public int Duration { get; set; }
        public double Rating { get; set; }
    }
}