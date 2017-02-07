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

            var stackNew = new StackLayout
            {

                BackgroundColor = Color.Black,
                Spacing = 3.0,
                Orientation = StackOrientation.Vertical,
                Children =
                {
                    
                    new Label {Text = "Mee - my mother ", TextColor = Color.Purple,  FontAttributes = FontAttributes.Bold, FontSize = 20, VerticalOptions = LayoutOptions.StartAndExpand, BackgroundColor = Color.Green  },
                    new Label {Text = "Nha - my father", TextColor = Color.Yellow, FontSize = 30, FontAttributes = FontAttributes.Bold },
                    new Label {Text = "Kong - me ", TextColor = Color.Orange, FontSize = 41, FontAttributes = FontAttributes.Bold},
                    new Label {Text = "Zachariah - my son", TextColor = Color.Blue, FontSize = 42, FontAttributes = FontAttributes.Bold },
                    new Label {Text = "Nouzong - my wife", TextColor = Color.Pink, FontSize = 43, FontAttributes = FontAttributes.Bold }

                }
            

            };

            Content = new ScrollView
            {
                Orientation = ScrollOrientation.Vertical,
                Content = stackNew
                
            };


        }


    }
}
