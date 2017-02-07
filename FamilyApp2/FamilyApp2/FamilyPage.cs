using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FamilyApp2
{
    class FamilyPage : ContentPage  
    {

        public FamilyPage()
        {
            Content = new StackLayout
            {

                BackgroundColor = Color.Pink,
                Spacing = 3.0,
                
                Children =
                {
                    new Label {Text = "Mee - my mother", TextColor = Color.Purple },
                    new Label {Text = "Nha - my father", TextColor = Color.Yellow },
                    new Label {Text = "Kong - me"},
                    new Label {Text = "Zachariah - my son" },
                    new Label {Text = "Nouzong - my wife" }
                }
               
            };

        }


    }
}
