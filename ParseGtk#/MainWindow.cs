using System;
using Gtk;
using Parse;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected async void SendPostToParse (object sender, EventArgs e)
	{
		var testObject = new ParseObject ("Post");
		testObject ["title"] = this.postText.Text;
		testObject ["body"] = this.postBody.Buffer.Text;
		await testObject.SaveAsync ();
		clearInputs ();
	}

	private void clearInputs()
	{
		this.postText.Text = "";
		this.postBody.Buffer.Clear ();
	}
}
