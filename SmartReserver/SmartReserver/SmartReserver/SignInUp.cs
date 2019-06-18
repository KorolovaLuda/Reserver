using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SmartReserver
{
	public class SignInUp : ContentPage
	{
        Button SignIn;
        Button SignUp;
        Image Logo;
        bool Type;
        public SignInUp(bool type)
        {
            BackgroundImage = "background.jpg";

            SignIn = new Button();
            SignIn.Text = "Sign In";
            SignIn.Clicked += SignInClicked;
            SignIn.BackgroundColor = new Color(1, 1, 1, 0);
            SignIn.TextColor = Color.White;
            SignIn.FontSize = 18;
            SignIn.FontFamily = "Roboto";
            SignIn.FontAttributes = FontAttributes.Bold;

            SignUp = new Button();
            SignUp.Text = "Sign Up";
            SignUp.Clicked += SignUpClicked;
            SignUp.BackgroundColor = new Color(1, 1, 1, 0);
            SignUp.TextColor = Color.White;
            SignUp.FontSize = 18;
            SignUp.FontFamily = "Roboto";
            SignUp.FontAttributes = FontAttributes.Bold;

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
                    new RowDefinition { Height = new GridLength(5, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(2, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(2, GridUnitType.Star) }
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                }
            };
            Type = type;
            if (type==true)
            {
                Label label = new Label();
                label.Text = "Restoraunt";
                label.FontSize = 30;
                label.TextColor = Color.White;
                label.FontFamily = "Robotic";
                label.HorizontalTextAlignment = TextAlignment.Center;
                label.VerticalTextAlignment = TextAlignment.Center;
                label.FontAttributes = FontAttributes.Italic;
                content.Children.Add(label, 0, 1);
            }
            content.Children.Add(Logo, 0, 0);
            content.Children.Add(SignUp, 0, 2);
            content.Children.Add(SignIn, 0, 3);
            Content = content;
        }

        private async void SignUpClicked(object sender, EventArgs e)
        {
            /*if (Type)
                await Navigation.PushModalAsync(new RestorantRegistration());
            else*/
                await Navigation.PushModalAsync(new UserRegistration());
        }

        private async void SignInClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SignIn(Type));
        }
    }
}