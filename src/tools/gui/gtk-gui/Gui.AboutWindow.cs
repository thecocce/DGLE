
// This file has been generated by the GUI designer. Do not modify.
namespace Gui
{
	public partial class AboutWindow
	{
		private global::Gtk.VBox vbox1;
		private global::Gtk.Image imageLogo;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TextView textviewAbout;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Gui.AboutWindow
			this.WidthRequest = 300;
			this.HeightRequest = 225;
			this.Name = "Gui.AboutWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("About");
			this.TypeHint = ((global::Gdk.WindowTypeHint)(1));
			this.Modal = true;
			this.Resizable = false;
			// Container child Gui.AboutWindow.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			this.vbox1.BorderWidth = ((uint)(6));
			// Container child vbox1.Gtk.Box+BoxChild
			this.imageLogo = new global::Gtk.Image ();
			this.imageLogo.Name = "imageLogo";
			this.imageLogo.Pixbuf = new global::Gdk.Pixbuf (global::System.IO.Path.Combine (global::System.AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\misc\\dgle2_logo.png"));
			this.vbox1.Add (this.imageLogo);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.imageLogo]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.textviewAbout = new global::Gtk.TextView ();
			this.textviewAbout.Buffer.Text = "About";
			this.textviewAbout.Sensitive = false;
			this.textviewAbout.CanFocus = true;
			this.textviewAbout.Name = "textviewAbout";
			this.textviewAbout.Editable = false;
			this.textviewAbout.CursorVisible = false;
			this.textviewAbout.AcceptsTab = false;
			this.textviewAbout.Justification = ((global::Gtk.Justification)(2));
			this.textviewAbout.WrapMode = ((global::Gtk.WrapMode)(2));
			this.textviewAbout.PixelsAboveLines = 6;
			this.textviewAbout.LeftMargin = 6;
			this.textviewAbout.RightMargin = 6;
			this.GtkScrolledWindow.Add (this.textviewAbout);
			this.vbox1.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.GtkScrolledWindow]));
			w3.Position = 1;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 300;
			this.DefaultHeight = 200;
			this.Hide ();
		}
	}
}
