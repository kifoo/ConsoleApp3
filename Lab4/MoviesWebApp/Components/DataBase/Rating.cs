using System.ComponentModel.DataAnnotations;

namespace MoviesWebApp.Components.DataBase
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }
        public int MovieId { get; set; }
        public string? UserId { get; set; }
        public double Value { get; set; }
    }
}
