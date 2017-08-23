using System;
using AppKit;
using Foundation;

namespace GPX2Cruiser.MacOS
{
    public partial class ViewController : NSViewController
    {
        private Shared.Main GPX2Cruiser = new Shared.Main();

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
            option_fr.Activated += SetSettingsValue;
            option_tr.Activated += SetSettingsValue;
            save_file.Activated += SaveFile;
		}

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        private void SetSettingsValue (object sender, EventArgs e)
        {
            var cb = sender as NSButton;

            if(cb.Tag == 0)
            {
                throw new NotImplementedException();
            }
            else if(cb.Tag == 1)
            {
                GPX2Cruiser.Settings.ForbidTollRoads = cb.State == NSCellStateValue.On;
            }
            else if(cb.Tag == 2)
            {
				GPX2Cruiser.Settings.ForbidFerries = cb.State == NSCellStateValue.On;
			}
        }

        partial void open_file(Foundation.NSObject sender)
        {
            var path = IO.ShowOpenFileDialogue();
            if(!string.IsNullOrEmpty(path))
            {
				GPX2Cruiser.OpenFile(path);
			}

            save_file.Enabled = GPX2Cruiser.HasLoadedValidRoute;
            status_route.StringValue = GPX2Cruiser.HasLoadedValidRoute ? "Route found!" : "Invalid route!";

            status_wp.StringValue = string.Format("Waypoints: {0}", GPX2Cruiser.LoadedWayPoints);
            status_wp.Hidden = !GPX2Cruiser.HasLoadedValidRoute;
		}

        private void SaveFile(object sender, EventArgs e)
        {
            var path = IO.ShowSaveFileDialogue(GPX2Cruiser.LoadedFileName);
            if(!string.IsNullOrEmpty(path))
            {
			  GPX2Cruiser.Export(path);
			}
		}
    }
}
