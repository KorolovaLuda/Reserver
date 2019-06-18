using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SmartReserver
{
	public class SignIn : ContentPage
	{
        bool Type;
        Label Error;
        Entry Username;
        Entry Password;
        Button Enter;
		public SignIn (bool type)
		{
            Title = "Test";
            Type = type;
            BackgroundImage = "background.jpg";
            Grid content = new Grid()
            {
                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(2, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(2, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(5, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                }

            };

            Label logo = new Label();
            logo.Text = "Smart Reserver";
            logo.FontSize = 36;
            logo.TextColor = Color.White;
            logo.FontFamily = "Robotic";
            logo.HorizontalTextAlignment = TextAlignment.Center;
            logo.VerticalTextAlignment = TextAlignment.Center;

            Label restorant = new Label();
            restorant.Text = "Restorant";
            restorant.FontSize = 28;
            restorant.TextColor = Color.White;
            restorant.FontFamily = "Robotic";
            restorant.HorizontalTextAlignment = TextAlignment.Center;
            restorant.VerticalTextAlignment = TextAlignment.Center;
            restorant.FontAttributes = FontAttributes.Italic;

            Error = new Label();
            Error.FontSize = 24;
            Error.TextColor = Color.Red;
            Error.FontFamily = "Robotic";
            Error.HorizontalTextAlignment = TextAlignment.Center;
            Error.VerticalTextAlignment = TextAlignment.Center;

            Username = new Entry();
            Username.Placeholder = "Login";
            Username.PlaceholderColor = Color.GhostWhite;
            Username.FontSize = 24;
            Username.FontFamily = "Roboto";
            Username.TextColor = Color.White;

            Password = new Entry();
            Password.Placeholder = "Password";
            Password.PlaceholderColor = Color.GhostWhite;
            Password.FontSize = 24;
            Password.FontFamily = "Roboto";
            Password.TextColor = Color.White;
            Password.IsPassword = true;

            Enter = new Button();
            Enter.Text = "Sign in";
            Enter.Clicked += SignInClicked;
            Enter.BackgroundColor = new Color(1, 1, 1, 0);
            Enter.TextColor = Color.White;
            Enter.FontSize = 18;
            Enter.FontFamily = "Roboto";
            Enter.FontAttributes = FontAttributes.Bold;

            content.Children.Add(logo, 1, 0);
            if (Type)
                content.Children.Add(restorant, 1, 1);
            content.Children.Add(Error, 1, 2);
            content.Children.Add(Username, 1, 3);
            content.Children.Add(Password, 1, 4);
            content.Children.Add(Enter, 1, 6);
            Content = content;
        }
        private async void SignInClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new User());
        }
    }
}