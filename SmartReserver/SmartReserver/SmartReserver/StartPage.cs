using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

using Xamarin.Forms;
using Xamarin.Forms.StyleSheets;

namespace SmartReserver
{
	public class StartPage : ContentPage
	{
        
        Button User;
        Button Restorant;
        Image Logo;

		public StartPage ()
		{
            BackgroundImage = "background.jpg";
            Title = "Test1";
            User = new Button();
            User.Text = "User";
            User.Clicked += UserClicked;
            User.BackgroundColor = new Color(1, 1, 1, 0);
            User.TextColor = Color.White;
            User.FontSize = 24;
            User.FontFamily = "Roboto";
            User.FontAttributes = FontAttributes.Bold;

            Restorant = new Button();
            Restorant.Text = "Restorant";
            Restorant.Clicked += RestorantClicked;
            Restorant.BackgroundColor = new Color(1, 1, 1, 0);
            Restorant.TextColor = Color.White;
            Restorant.FontSize = 24;
            Restorant.FontFamily = "Roboto";
            Restorant.FontAttributes = FontAttributes.Bold;

            Logo = new Image();
            Logo.VerticalOptions = LayoutOptions.FillAndExpand;
            Logo.HorizontalOptions = LayoutOptions.FillAndExpand;
            Logo.Aspect = Aspect.AspectFill;
            Logo.Source = ImageSource.FromResource("SmartReserver.Resourses.logo.jpg");

            Grid content = new Grid()
            {
                Padding = 0,
                Margin = 0,
                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(3, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                }
            };
            //content.BackgroundColor = Color.White;
            content.Children.Add(Logo, 0, 0);
            content.Children.Add(Restorant, 0, 2);
            content.Children.Add(User, 0, 3);
            Content = content;
		}

        private async void RestorantClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SignInUp(true));
        }
        
        private async void UserClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SignInUp(false));
        }
    }
}