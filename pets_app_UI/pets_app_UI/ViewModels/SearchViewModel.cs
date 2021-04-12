using pets_app_laura_gonzalez.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace pets_app_laura_gonzalez.ViewModels
{
   public class SearchViewModel
    {
        public ObservableCollection<Pets> Pets { get; set; }

        public SearchViewModel()
        {
            Pets = new ObservableCollection<Pets>
            {
                new Pets{Category = "Vet Clinics", Image = "Image_005", BackgroundColor = "#15464e", TextColor = "#ffffff", Position = 1},
                new Pets{Category = "Places to eat", Image = "Image_006", BackgroundColor = "#c9e193", TextColor = "#1a2e35", Position = 2},
                new Pets{Category = "Places to walk", Image = "Image_004", BackgroundColor = "#00b7b7", TextColor = "#ffffff", Position = 1},
                new Pets{Category = "Spas & Salons", Image = "Image_007", BackgroundColor = "#b6dddf", TextColor = "#1a2e35", Position = 2},
                new Pets{Category = "Shops & Products", Image = "Image_011", BackgroundColor = "#c9e193", TextColor = "#1a2e35", Position = 1},
                new Pets{Category = "Walk groups", Image = "Image_003", BackgroundColor = "#15464e", TextColor = "#ffffff", Position = 2},
                new Pets{Category = "Animals in adoption", Image = "Image_001", BackgroundColor = "#b6dddf", TextColor = "#1a2e35", Position = 1},
                new Pets{Category = "Dogs walkers", Image = "Image_008", BackgroundColor = "#00b7b7", TextColor = "#ffffff", Position = 2}

            };
        }
    }
}
