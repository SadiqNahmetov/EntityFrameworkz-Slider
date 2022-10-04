using EntityFramework.Models;

using System.Collections.Generic;


namespace EntityFramework.ViewModels
{
    public class HomeVM
    {
        public   List<Slider> MyProperty { get; set; }

        public SliderDetail SliderDetail{ get; set; }
        public List<Slider> Sliders { get; internal set; }
    }
}
