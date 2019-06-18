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
	public partial class MyReservations : TabbedPage
	{
		public MyReservations ()
		{
			InitializeComponent ();
            Children.Add(new Active());
            Children.Add(new Paste());
            BarBackgroundColor = Color.White;
            BarTextColor = Color.Gray;
		}
	}
}