using System.Windows.Forms;

namespace GPX2Cruiser.Windows
{
    public class IO
    {
        public static string ShowOpenFileDialogue()
        {
            using (var openFileDialogue = new OpenFileDialog())
            {
                openFileDialogue.DefaultExt = "gpx";
                openFileDialogue.Filter = "gpx file (*.gpx)|*gpx";
                openFileDialogue.CheckFileExists = true;
                openFileDialogue.CheckPathExists = true;

                if (openFileDialogue.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialogue.FileName;
                }
                return string.Empty;
            }
        }

        public static string ShowSaveFileDialogue(string fileName)
        {
            using (var saveFileDialogue = new SaveFileDialog())
            {
                saveFileDialogue.DefaultExt = "cruiser";
                saveFileDialogue.Filter = "cruiser file (*.cruiser)|*cruiser";
                saveFileDialogue.CheckPathExists = true;
                saveFileDialogue.FileName = fileName;
                saveFileDialogue.OverwritePrompt = true;

                if (saveFileDialogue.ShowDialog() == DialogResult.OK)
                {
                    return saveFileDialogue.FileName;
                }

                return string.Empty;
            }
        }
    }
}
