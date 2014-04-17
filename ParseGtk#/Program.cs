using System;
using Gtk;
using Parse;

namespace ParseGtk
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			ParseClient.Initialize("JXf0jelkdSPdEP2x6VnwO4SysUPq5mJc0Hz8OfYh", "Fo6WNk7q3JIBis3e8zkfVu72z1NtOEWbReXawPWg");

			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();
			Application.Run ();
		}
	}
}
