using System.Runtime.InteropServices;

namespace DesktopPin
{
    public partial class MainForm : Form
    {

        public const int WS_EX_TRANSPARENT = 0x20;
        public const int GWL_EXSTYLE = (-20);
        public bool isInteractiveForm = false;

        public MainForm()
        {
            InitializeComponent();
            TopMost = true;
            BackColor = Color.Black;
            Opacity = 0.5;
        }

        protected override void OnLoad(EventArgs e)
        {
            tsInteractiveForm_Click(null, null);
        }

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        private void tsExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsInteractiveForm_Click(object sender, EventArgs e)
        {

            if (isInteractiveForm)
            {
                //Deactivate
                // Formun özelliklerini ve uzantı stillerini ayarlayın
                TopMost = true;
                FormBorderStyle = FormBorderStyle.None;
                BackColor = Color.Black;
                SetStyle(ControlStyles.Selectable, false);
                int exstyle = (int)GetWindowLong(this.Handle, GWL_EXSTYLE);
                exstyle |= WS_EX_TRANSPARENT;
                SetWindowLong(this.Handle, GWL_EXSTYLE, (IntPtr)exstyle);
                isInteractiveForm = false;
                panel1.Visible = false;

            }
            else
            {
                //Activate
                TopMost = false;
                FormBorderStyle = FormBorderStyle.Sizable;
                BackColor = SystemColors.Control;
                SetStyle(ControlStyles.Selectable, true);
                int exstyle = (int)GetWindowLong(this.Handle, GWL_EXSTYLE);
                exstyle &= ~WS_EX_TRANSPARENT;
                SetWindowLong(this.Handle, GWL_EXSTYLE, (IntPtr)exstyle);
                isInteractiveForm = true;
                panel1.Visible = true;
            }
        }

        private void btnDisableFormInteractive_Click(object sender, EventArgs e)
        {
            tsInteractiveForm_Click(null, null);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            Opacity = trackBar1.Value / 10.0;
        }
    }
}