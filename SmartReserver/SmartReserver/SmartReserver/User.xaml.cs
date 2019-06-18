using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartReserver
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class User : MasterDetailPage
	{
		public User ()
		{
			InitializeComponent ();
            back.Source = ImageSource.FromResource("SmartReserver.Resourses.background.jpg");
            back.Aspect = Aspect.Fill;
            Feed.BackgroundColor = new Color(0, 0, 0, 0);
            Account.BackgroundColor = new Color(0, 0, 0, 0);
            MyReservations.BackgroundColor = new Color(0, 0, 0, 0);
            LogOut.BackgroundColor = new Color(0, 0, 0, 0);
            Detail = new NavigationPage(new Feed())
            {
                BarBackgroundColor = Color.White,
                BarTextColor = Color.White
            };
		}

        private void FeedClicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Feed())
            {
                BarBackgroundColor = Color.White,
                BarTextColor = Color.White
            };
            IsPresented = false;
        }

        private void AccountClicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Account())
            {
                BarBackgroundColor = Color.White,
                BarTextColor = Color.White
            };
            IsPresented = false;
        }

        private void MyReservationsClicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new MyReservations())
            {
                BarBackgroundColor = Color.White,
                BarTextColor = Color.White
            };
            IsPresented = false;
        }

        private async void LogOutClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new StartPage());
        }
    }
}