
// This file has been generated by the GUI designer. Do not modify.
namespace R7.TaskGen
{
	public partial class MainForm
	{
		private global::Gtk.UIManager UIManager;
		private global::Gtk.Action mediaPlayAction;
		private global::Gtk.Action copyAction;
		private global::Gtk.Action FileAction;
		private global::Gtk.Action quitAction;
		private global::Gtk.Action HelpAction;
		private global::Gtk.Action aboutAction;
		private global::Gtk.Action helpAction;
		private global::Gtk.Action openAction;
		private global::Gtk.VBox vbox1;
		private global::Gtk.MenuBar menubar1;
		private global::Gtk.Toolbar toolbar1;
		private global::Gtk.HBox hbox3;
		private global::Gtk.VBox vbox2;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Table table1;
		private global::Gtk.Button button3;
		private global::Gtk.ComboBoxEntry cbeName;
		private global::Gtk.ComboBox comboTheme;
		private global::Gtk.Label labelName;
		private global::Gtk.Label labelTheme;
		private global::Gtk.Label labelThemeDesc;
		private global::Gtk.Label labelVerticalExpand;
		private global::Gtk.CheckButton chkOpenBook;
		private global::Gtk.Table table2;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TextView textview1;
		private global::Gtk.Statusbar statusbar1;
		private global::Gtk.Image imgStatus;
		private global::Gtk.Label lblStatus;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget R7.TaskGen.MainForm
			this.UIManager = new global::Gtk.UIManager ();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
			this.mediaPlayAction = new global::Gtk.Action ("mediaPlayAction", global::Mono.Unix.Catalog.GetString ("My Variant"), global::Mono.Unix.Catalog.GetString ("Generate variant"), "gtk-media-play");
			this.mediaPlayAction.IsImportant = true;
			this.mediaPlayAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("My Variant");
			w1.Add (this.mediaPlayAction, "Return");
			this.copyAction = new global::Gtk.Action ("copyAction", global::Mono.Unix.Catalog.GetString ("Copy"), global::Mono.Unix.Catalog.GetString ("Copy last variant to clipboard"), "gtk-copy");
			this.copyAction.IsImportant = true;
			this.copyAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Copy");
			w1.Add (this.copyAction, "<Control>c");
			this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("_File"), null, null);
			this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_File");
			w1.Add (this.FileAction, null);
			this.quitAction = new global::Gtk.Action ("quitAction", global::Mono.Unix.Catalog.GetString ("_Quit"), null, "gtk-quit");
			this.quitAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Quit");
			w1.Add (this.quitAction, null);
			this.HelpAction = new global::Gtk.Action ("HelpAction", global::Mono.Unix.Catalog.GetString ("_Help"), null, null);
			this.HelpAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Help");
			w1.Add (this.HelpAction, null);
			this.aboutAction = new global::Gtk.Action ("aboutAction", global::Mono.Unix.Catalog.GetString ("_About"), null, "gtk-about");
			this.aboutAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_About");
			w1.Add (this.aboutAction, null);
			this.helpAction = new global::Gtk.Action ("helpAction", global::Mono.Unix.Catalog.GetString ("_Help (in russian)"), null, "gtk-help");
			this.helpAction.IsImportant = true;
			this.helpAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Help");
			w1.Add (this.helpAction, "F1");
			this.openAction = new global::Gtk.Action ("openAction", global::Mono.Unix.Catalog.GetString ("Open _books folder..."), null, "gtk-open");
			this.openAction.IsImportant = true;
			this.openAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Books");
			w1.Add (this.openAction, null);
			this.UIManager.InsertActionGroup (w1, 0);
			this.AddAccelGroup (this.UIManager.AccelGroup);
			this.Name = "R7.TaskGen.MainForm";
			this.Title = "MainForm";
			this.Icon = global::Gdk.Pixbuf.LoadFromResource ("R7.TaskGen.icons.taskgen-d8.png");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child R7.TaskGen.MainForm.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString ("<ui><menubar name='menubar1'><menu name='FileAction' action='FileAction'><menuitem name='openAction' action='openAction'/><separator/><menuitem name='quitAction' action='quitAction'/></menu><menu name='HelpAction' action='HelpAction'><menuitem name='helpAction' action='helpAction'/><menuitem name='aboutAction' action='aboutAction'/></menu></menubar></ui>");
			this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar1")));
			this.menubar1.Name = "menubar1";
			this.vbox1.Add (this.menubar1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.menubar1]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString ("<ui><toolbar name='toolbar1'><toolitem name='mediaPlayAction' action='mediaPlayAction'/><toolitem name='copyAction' action='copyAction'/><toolitem name='openAction' action='openAction'/><separator/><toolitem name='helpAction' action='helpAction'/></toolbar></ui>");
			this.toolbar1 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget ("/toolbar1")));
			this.toolbar1.Name = "toolbar1";
			this.toolbar1.ShowArrow = false;
			this.vbox1.Add (this.toolbar1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.toolbar1]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			this.hbox3.BorderWidth = ((uint)(6));
			// Container child hbox3.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(3)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.button3 = new global::Gtk.Button ();
			this.button3.CanFocus = true;
			this.button3.Name = "button3";
			this.button3.UseUnderline = true;
			this.button3.Label = "GtkButton";
			this.table1.Add (this.button3);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.button3]));
			w4.TopAttach = ((uint)(2));
			w4.BottomAttach = ((uint)(3));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.cbeName = global::Gtk.ComboBoxEntry.NewText ();
			this.cbeName.TooltipMarkup = "Enter your full name, separate name parts with spaces";
			this.cbeName.Name = "cbeName";
			this.table1.Add (this.cbeName);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.cbeName]));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.comboTheme = global::Gtk.ComboBox.NewText ();
			this.comboTheme.TooltipMarkup = "Choose theme of laboratory or practice work. Please be careful - theme name in a list may be not literally same as theme of your course!";
			this.comboTheme.Name = "comboTheme";
			this.table1.Add (this.comboTheme);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.comboTheme]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelName = new global::Gtk.Label ();
			this.labelName.Name = "labelName";
			this.labelName.Xalign = 1F;
			this.labelName.LabelProp = global::Mono.Unix.Catalog.GetString ("Full name:");
			this.labelName.Justify = ((global::Gtk.Justification)(1));
			this.table1.Add (this.labelName);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelName]));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelTheme = new global::Gtk.Label ();
			this.labelTheme.Name = "labelTheme";
			this.labelTheme.Xalign = 1F;
			this.labelTheme.LabelProp = global::Mono.Unix.Catalog.GetString ("Theme:");
			this.labelTheme.Justify = ((global::Gtk.Justification)(1));
			this.table1.Add (this.labelTheme);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelTheme]));
			w8.TopAttach = ((uint)(1));
			w8.BottomAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelThemeDesc = new global::Gtk.Label ();
			this.labelThemeDesc.Name = "labelThemeDesc";
			this.labelThemeDesc.Xalign = 0F;
			this.labelThemeDesc.LabelProp = "Annotation of choosen theme must be here!";
			this.labelThemeDesc.UseMarkup = true;
			this.labelThemeDesc.Wrap = true;
			this.table1.Add (this.labelThemeDesc);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelThemeDesc]));
			w9.TopAttach = ((uint)(2));
			w9.BottomAttach = ((uint)(3));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox2.Add (this.table1);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.table1]));
			w10.Position = 0;
			this.vbox2.Add (this.hbox2);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox2]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.labelVerticalExpand = new global::Gtk.Label ();
			this.labelVerticalExpand.Name = "labelVerticalExpand";
			this.vbox2.Add (this.labelVerticalExpand);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.labelVerticalExpand]));
			w12.Position = 1;
			// Container child vbox2.Gtk.Box+BoxChild
			this.chkOpenBook = new global::Gtk.CheckButton ();
			this.chkOpenBook.CanFocus = true;
			this.chkOpenBook.Name = "chkOpenBook";
			this.chkOpenBook.Label = global::Mono.Unix.Catalog.GetString ("Open task book then button is clicked");
			this.chkOpenBook.Active = true;
			this.chkOpenBook.DrawIndicator = true;
			this.chkOpenBook.UseUnderline = true;
			this.vbox2.Add (this.chkOpenBook);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.chkOpenBook]));
			w13.Position = 2;
			w13.Expand = false;
			w13.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.table2 = new global::Gtk.Table (((uint)(2)), ((uint)(10)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(3));
			this.table2.ColumnSpacing = ((uint)(3));
			this.vbox2.Add (this.table2);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.table2]));
			w14.Position = 3;
			w14.Expand = false;
			w14.Fill = false;
			this.hbox3.Add (this.vbox2);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.vbox2]));
			w15.Position = 0;
			// Container child hbox3.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.WidthRequest = 150;
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.textview1 = new global::Gtk.TextView ();
			this.textview1.CanFocus = true;
			this.textview1.Name = "textview1";
			this.textview1.Editable = false;
			this.textview1.WrapMode = ((global::Gtk.WrapMode)(3));
			this.textview1.PixelsAboveLines = 4;
			this.textview1.LeftMargin = 4;
			this.textview1.RightMargin = 4;
			this.GtkScrolledWindow.Add (this.textview1);
			this.hbox3.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.GtkScrolledWindow]));
			w17.Position = 1;
			this.vbox1.Add (this.hbox3);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox3]));
			w18.Position = 2;
			// Container child vbox1.Gtk.Box+BoxChild
			this.statusbar1 = new global::Gtk.Statusbar ();
			this.statusbar1.Name = "statusbar1";
			this.statusbar1.Spacing = 6;
			this.statusbar1.BorderWidth = ((uint)(3));
			// Container child statusbar1.Gtk.Box+BoxChild
			this.imgStatus = new global::Gtk.Image ();
			this.imgStatus.Name = "imgStatus";
			this.imgStatus.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "stock_dialog-info", global::Gtk.IconSize.Menu);
			this.statusbar1.Add (this.imgStatus);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.statusbar1 [this.imgStatus]));
			w19.Position = 0;
			w19.Expand = false;
			w19.Fill = false;
			w19.Padding = ((uint)(2));
			// Container child statusbar1.Gtk.Box+BoxChild
			this.lblStatus = new global::Gtk.Label ();
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Xalign = 1F;
			this.statusbar1.Add (this.lblStatus);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.statusbar1 [this.lblStatus]));
			w20.Position = 1;
			w20.Expand = false;
			w20.Fill = false;
			this.vbox1.Add (this.statusbar1);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.statusbar1]));
			w21.Position = 3;
			w21.Expand = false;
			w21.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 721;
			this.DefaultHeight = 322;
			this.button3.Hide ();
			this.labelTheme.MnemonicWidget = this.comboTheme;
			this.labelThemeDesc.Hide ();
			this.chkOpenBook.Hide ();
			this.table2.Hide ();
			this.Show ();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
			this.mediaPlayAction.Activated += new global::System.EventHandler (this.OnActionGenerateActivated);
			this.copyAction.Activated += new global::System.EventHandler (this.OnActionCopyActivated);
			this.quitAction.Activated += new global::System.EventHandler (this.OnQuitActionActivated);
			this.aboutAction.Activated += new global::System.EventHandler (this.OnAboutAction1Activated);
			this.helpAction.Activated += new global::System.EventHandler (this.OnActionHelpActivated);
			this.openAction.Activated += new global::System.EventHandler (this.OnOpenTaskbookFolderActionActivated);
			this.comboTheme.Changed += new global::System.EventHandler (this.OnComboThemeChanged);
			this.cbeName.Changed += new global::System.EventHandler (this.OnCbeNameChanged);
			this.button3.Clicked += new global::System.EventHandler (this.OnButton3Clicked);
		}
	}
}