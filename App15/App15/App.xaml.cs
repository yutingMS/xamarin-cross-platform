using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace App15
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new App15.MainPage();
		}

		protected override void OnStart ()
		{
            AppCenter.Start("android=25636ee3-00b9-4879-b160-443dcc4507d2;" + "uwp={Your UWP App secret here};" +
                   "ios={Your iOS App secret here}",
                   typeof(Analytics), typeof(Crashes));
            // Handle when your app starts
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
