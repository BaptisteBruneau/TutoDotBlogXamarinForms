using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using TutoDotBlog.Model;

namespace TutoDotBlog.View
{
    public class DetailBird : ContentPage
    {
        public DetailBird(Bird bird)
        {
            Title = bird.Name;
            var stack = new StackLayout
            {
                Orientation = StackOrientation.Vertical
            };
            stack.Children.Add(AddRow("Nom: ", bird.Name));
            stack.Children.Add(AddRow("Nom latin: ", bird.LatinName));
            stack.Children.Add(AddRow("Poids moyen: ", string.Format("{0}g", bird.AverrageWeight.ToString())));
            stack.Children.Add(AddRow("Description: ", bird.Description));

            Content = new ScrollView { Padding = 20, Margin = 10, Content = stack };
        }

        private Layout<Xamarin.Forms.View> AddRow (string label, string content)
        {
            var stack = new StackLayout
            {
                Orientation = StackOrientation.Horizontal
            };
            stack.Children.Add(new Label
            {
                Text = label,
                TextColor = Color.Gray,
            });
            stack.Children.Add(new Label
            {
                Text = content,
                //Personnalise la couleur selon la plateforme
                TextColor = Device.OnPlatform(Color.Default, Color.Orange, Color.Green)
            });

            return stack;
        }
    }
}
