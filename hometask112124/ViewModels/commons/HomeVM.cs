using hometask112124.Models;
using hometask112124.ViewModels.Sliders;

namespace hometask112124.ViewModels.commons
{
    public class HomeVM
    {
        public IEnumerable<SliderListItemVM> Sliders { get; set; }
        public IEnumerable<Brand> Brands { get; set; }
       

    }
}
