
using System.ComponentModel.DataAnnotations;

namespace hometask112124.ViewModels.Sliders
{
    public class SliderCreateVM
    {
        [MaxLength(32, ErrorMessage = "Qeyd: 32 simvoldan cox olmamalidir."), Required]
        public string Title { get; set; }
        [Required]
        public string Subtitle { get; set; }
        public string Link { get; set; }
        [Required(ErrorMessage = "Fayl Secilmeyib")]
        public IFormFile File { get; set; }
    }
}
