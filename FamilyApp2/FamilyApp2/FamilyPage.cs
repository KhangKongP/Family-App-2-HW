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
                    new Label {Text = "Mee - my mother", TextColor = Color.Purple, FontAttributes = FontAttributes.Bold },
                    new Label {Text = "Nha - my father", TextColor = Color.Yellow },
                    new Label {Text = "Kong - me", TextColor = Color.Orange},
                    new Label {Text = "Zachariah - my son", TextColor = Color.Blue },
                    new Label {Text = "Nouzong - my wife", TextColor = Color.Pink }
                }
               
            };

        }


    }
}
