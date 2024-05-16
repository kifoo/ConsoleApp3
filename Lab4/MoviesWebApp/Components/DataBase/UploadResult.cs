using System.ComponentModel.DataAnnotations;

namespace MoviesWebApp.Components.DataBase
{
    public class UploadResult
    {
        [Key]
        public int Id { get; set; }
        public int? MovieId { get; set; }
        public string? FileName { get; set; }
        public string? StoredFileName { get; set; }
        public string? ContentType { get; set; }
    }
}
