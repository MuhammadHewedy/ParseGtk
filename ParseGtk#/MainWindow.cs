using System;
using Gtk;
using Parse;
using System.Threading.Tasks;

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
		Task saveTask = testObject.SaveAsync ();
		IndicateAsSending ();

		await saveTask;
		IndicateAsFinishSending ();
	}

	private void IndicateAsSending(){
		this.postBody.Buffer.Text += " \n sending ...";
	}

	private void IndicateAsFinishSending(){
		ClearInputs ();
	}

	private void ClearInputs()
	{
		this.postText.Text = "";
		this.postBody.Buffer.Clear ();
	}
}
