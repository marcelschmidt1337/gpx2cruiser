using AppKit;

namespace GPX2Cruiser.MacOS
{
    public class IO
    {
        public static string ShowOpenFileDialogue()
        {
            var dialogue = NSOpenPanel.OpenPanel;
            dialogue.AllowsMultipleSelection = false;
            dialogue.CanChooseFiles = true;
            dialogue.CanChooseDirectories = false;
            dialogue.AllowedFileTypes = new string[] { "gpx" };

            if(dialogue.RunModal() == (long)NSModalResponse.OK)
            {
                var url = dialogue.Url;

                if(url != null)
                {
                    return url.Path;
                }
                return string.Empty;
            }

            return string.Empty;
        }

        public static string ShowSaveFileDialogue(string fileName)
        {
            var dialogue = NSSavePanel.SavePanel;
            dialogue.AllowsOtherFileTypes = false;
            dialogue.CanCreateDirectories = true;
            dialogue.NameFieldStringValue = fileName;

			dialogue.AllowedFileTypes = new string[] { "cruiser" };

			if (dialogue.RunModal() == (long)NSModalResponse.OK)
			{
				var url = dialogue.Url;

				if (url != null)
				{
					return url.Path;
				}
				return string.Empty;
			}

			return string.Empty;
        }
    }
}
