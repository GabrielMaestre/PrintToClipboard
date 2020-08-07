
using System.Drawing;
using System.Windows.Forms;

namespace PrintoToClipboard
{
    class ScreenShot
    {


        public static bool saveToClipboard = true;

        public static void CaptureImage(bool showCursor, Size curSize, Point curPos, Point SourcePoint, Point DestinationPoint, Rectangle SelectionRectangle, string FilePath, string extension)
        {

            using (Bitmap bitmap = new Bitmap(SelectionRectangle.Width, SelectionRectangle.Height))
            {

                using (Graphics g = Graphics.FromImage(bitmap))
                {

                    g.CopyFromScreen(SourcePoint, DestinationPoint, SelectionRectangle.Size);

                    if (showCursor)
                    {

                        Rectangle cursorBounds = new Rectangle(curPos, curSize);
                        Cursors.Default.Draw(g, cursorBounds);

                    }

                }

                if (saveToClipboard)
                {

                    Image img = (Image)bitmap;
                    Clipboard.SetImage(img);

                }

            }

        }

    }
}
