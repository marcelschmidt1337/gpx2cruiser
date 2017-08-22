// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace GPX2Cruiser
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSButton option_fr { get; set; }

		[Outlet]
		AppKit.NSButton option_tr { get; set; }

		[Outlet]
		AppKit.NSButton save_file { get; set; }

		[Outlet]
		AppKit.NSTextField status_route { get; set; }

		[Outlet]
		AppKit.NSTextField status_wp { get; set; }

		[Action ("open_file:")]
		partial void open_file (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (option_fr != null) {
				option_fr.Dispose ();
				option_fr = null;
			}

			if (option_tr != null) {
				option_tr.Dispose ();
				option_tr = null;
			}

			if (status_route != null) {
				status_route.Dispose ();
				status_route = null;
			}

			if (status_wp != null) {
				status_wp.Dispose ();
				status_wp = null;
			}

			if (save_file != null) {
				save_file.Dispose ();
				save_file = null;
			}
		}
	}
}
