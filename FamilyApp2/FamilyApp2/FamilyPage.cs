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
            Content = new Label
            {

                BackgroundColor = Color.Pink,

                FormattedText = new FormattedString
                {
                    Spans =
                    {
                        new Span
                        {
                        Text = "Nha Vang Khang  Daddy " + Environment.NewLine,
                        FontAttributes = FontAttributes.Bold,
                        BackgroundColor = Color.Yellow

                        },
                        new Span
                        {
                            Text = "Mee Y Khang  Mommy" + Environment.NewLine,
                            FontAttributes = FontAttributes.Bold,
                            BackgroundColor = Color.Blue
                        },
                        new Span
                        {
                            Text = "Kong P Khang ME!" + Environment.NewLine,
                            FontAttributes = FontAttributes.Bold,
                            BackgroundColor = Color.Red
                        }
                    }
                }
            };

        }


    }
}
