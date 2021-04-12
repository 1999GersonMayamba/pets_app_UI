using pets_app_laura_gonzalez.ContentViews;
using pets_app_laura_gonzalez.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace pets_app_laura_gonzalez.Templates
{
    public class PetsDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate Left { get; private set; }
        public DataTemplate Rigth { get; private set; }

        public PetsDataTemplateSelector()
        {
            Left = new DataTemplate(typeof(PetsContentViewLeft));
            Rigth = new DataTemplate(typeof(PetsContentViewRight));
        } 
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is Pets pets)
            {
                if (pets.Position == 1)
                    return Left;

                if (pets.Position == 2)
                    return Rigth;
            }

            return Left;
        }
    }
}
