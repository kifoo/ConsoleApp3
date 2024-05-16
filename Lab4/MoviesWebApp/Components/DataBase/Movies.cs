using System.ComponentModel.DataAnnotations;

namespace MoviesWebApp.Components.DataBase
{
    public class Movies
    {
        [Key]
        public int Id { get; set; }
        public string? UserId { get; set; }
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public int? Year { get; set; }
        public double Rating { get; set; }
    }
}
