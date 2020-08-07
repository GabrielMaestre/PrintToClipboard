using System;
using System.Drawing;
using System.Windows.Forms;

namespace PrintoToClipboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double opacityForm;

        string ScreenPath;
        private static bool TipsShowing;

        private Form m_InstanceRef = null;
        public Form InstanceRef;

        private void trackbarOpacity_Scroll(object sender, EventArgs e)
        {
            opacityForm = trackbarOpacity.Value;

            this.Opacity = System.Windows.Forms.Form.ActiveForm.Opacity = ((double)(trackbarOpacity.Value) / 100.0);

            lblValueOpacity.Text = "Opacity: " + this.trackbarOpacity.Value.ToString() + "%";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 1.0;
        }

        private void btnPrintArea_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ground groundform = new Ground();
            groundform.InstanceRef = this;
            groundform.Show();
        }

        private void btnPrintFullScreen_Click(object sender, EventArgs e)
        {
            screenCapture(false);
        }

        public void screenCapture(bool showCursor)
        {

            Point curPos = new Point(Cursor.Position.X, Cursor.Position.Y);
            Size curSize = new Size();
            curSize.Height = Cursor.Current.Size.Height;
            curSize.Width = Cursor.Current.Size.Width;

            ScreenPath = "";

            if (!ScreenShot.saveToClipboard)
            {

            }



            if (ScreenShot.saveToClipboard)
            {

                //Conceal this form while the screen capture takes place
                this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
                this.TopMost = false;

                //Allow 250 milliseconds for the screen to repaint itself (we don't want to include this form in the capture)
                System.Threading.Thread.Sleep(250);

                Rectangle bounds = Screen.GetBounds(Screen.GetBounds(Point.Empty));
                string fi = "";

                //if (ScreenPath != "")
                //{

                //    fi = new FileInfo(ScreenPath).Extension;

                //}

                ScreenShot.CaptureImage(showCursor, curSize, curPos, Point.Empty, Point.Empty, bounds, ScreenPath, fi);

                //The screen has been captured and saved to a file so bring this form back into the foreground
                this.WindowState = System.Windows.Forms.FormWindowState.Normal;
                this.TopMost = true;

                if (ScreenShot.saveToClipboard)
                {

                    MessageBox.Show("Saved to Clipboard", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                    //MessageBox.Show("Saved to File", "Info", MessageBoxButtons.OK);

                }


            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("the printscreen, don't show your Cursor and this Window \n" +
                "Print Area: select with your mouse the: WIDTH and HEIGHT. \n" +
                "You can drag-move the rectangle and adjuste in Bords. \n" +
                "If you press: P  you print the screen. \n" +
                "If you press: C  you cancel the print. \n" +
                "", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
