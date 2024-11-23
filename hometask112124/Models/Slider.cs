using System.ComponentModel.DataAnnotations;

namespace hometask112124.Models
{
    public class Slider
    {
        [MaxLength(32)]
        public string Title { get; set; } = null!;
        [MaxLength(64)]
        public string Subtite { get; set; } = null!;
        public string Link { get; set; }
        public string ImageUrl { get; set; } = null!;
    }
}
