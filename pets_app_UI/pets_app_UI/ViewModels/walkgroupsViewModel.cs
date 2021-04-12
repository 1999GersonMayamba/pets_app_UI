using pets_app_laura_gonzalez.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace pets_app_laura_gonzalez.ViewModels
{
   public class walkgroupsViewModel
    {
        public ObservableCollection<walkgroup> walkgroups { get; set; }
        public ObservableCollection<Product> products { get; set; }
        public walkgroupsViewModel()
        {
            walkgroups = new ObservableCollection<walkgroup>
            {
                new walkgroup{Name = "Meet our lovely dogs walking with us!", Adress = "Valencia, Spain", NumerOfMembers = "8 members", OrganizetedBy = "Laura", Image = "Image_013"},
                new walkgroup{Name = "Meet our lovely dogs walking with us!", Adress = "Valencia, Spain", NumerOfMembers = "8 members", OrganizetedBy = "Laura",Image = "Image_014"},
                new walkgroup{Name = "Meet our lovely dogs walking with us!", Adress = "Valencia, Spain", NumerOfMembers = "8 members", OrganizetedBy = "Laura", Image = "Image_013"},
                new walkgroup{Name = "Meet our lovely dogs walking with us!", Adress = "Valencia, Spain", NumerOfMembers = "8 members", OrganizetedBy = "Laura", Image = "Image_013"},
                new walkgroup{Name = "Meet our lovely dogs walking with us!", Adress = "Valencia, Spain", NumerOfMembers = "8 members", OrganizetedBy = "Laura",Image = "Image_014"}
            };

            products = new ObservableCollection<Product>
            {
                new Product{Image = "Image_010"},
                new Product{Image = "Image_009"}
            };
        }
    }
}
