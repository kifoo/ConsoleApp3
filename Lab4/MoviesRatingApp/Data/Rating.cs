using System.ComponentModel.DataAnnotations;

namespace MoviesRatingApp.Data
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
