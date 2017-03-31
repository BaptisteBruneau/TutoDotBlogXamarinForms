using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using TutoDotBlog.ViewModel;
using TutoDotBlog.Model;

namespace TutoDotBlog.View
{
    class BirdPage : ContentPage
    {
        public BirdPage()
        {
            Title = "Oiseaux";
            var list = new ListView
            {
                ItemsSource = new BirdsViewModel().BirdsList
            };
            var cell = new DataTemplate(typeof(TextCell));
            cell.SetBinding(TextCell.TextProperty, "Name");
            cell.SetBinding(TextCell.DetailProperty, "Description");
            list.ItemTemplate = cell;

            list.ItemTapped += (sender, args) =>
            {
                var bird = args.Item as Bird;
                if (bird == null)
                    return;
                Navigation.PushAsync(new DetailBird(bird));
                list.SelectedItem = null;
            };

            Content = list;
        }
    }
}
