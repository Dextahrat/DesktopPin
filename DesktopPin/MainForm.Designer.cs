namespace DesktopPin
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            tsInteractiveForm = new ToolStripMenuItem();
            tsExit = new ToolStripMenuItem();
            panel1 = new Panel();
            btnExit = new Button();
            btnDisableFormInteractive = new Button();
            label1 = new Label();
            trackBar1 = new TrackBar();
            contextMenuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { tsInteractiveForm, tsExit });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(186, 52);
            // 
            // tsInteractiveForm
            // 
            tsInteractiveForm.Name = "tsInteractiveForm";
            tsInteractiveForm.Size = new Size(185, 24);
            tsInteractiveForm.Text = "Interactive Form";
            tsInteractiveForm.Click += tsInteractiveForm_Click;
            // 
            // tsExit
            // 
            tsExit.Name = "tsExit";
            tsExit.Size = new Size(185, 24);
            tsExit.Text = "Exit";
            tsExit.Click += tsExit_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnDisableFormInteractive);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(trackBar1);
            panel1.Location = new Point(1, 533);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(912, 65);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(802, 20);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(86, 31);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnDisableFormInteractive
            // 
            btnDisableFormInteractive.Location = new Point(710, 20);
            btnDisableFormInteractive.Margin = new Padding(3, 4, 3, 4);
            btnDisableFormInteractive.Name = "btnDisableFormInteractive";
            btnDisableFormInteractive.Size = new Size(86, 31);
            btnDisableFormInteractive.TabIndex = 2;
            btnDisableFormInteractive.Text = "Deactivate";
            btnDisableFormInteractive.UseVisualStyleBackColor = true;
            btnDisableFormInteractive.Click += btnDisableFormInteractive_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 5);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 1;
            label1.Text = "Opacity";
            // 
            // trackBar1
            // 
            trackBar1.AutoSize = false;
            trackBar1.Location = new Point(13, 20);
            trackBar1.Margin = new Padding(3, 4, 3, 4);
            trackBar1.Minimum = 2;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(210, 31);
            trackBar1.TabIndex = 0;
            trackBar1.Value = 5;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            ShowInTaskbar = false;
            Text = "MainForm";
            Load += MainForm_Load;
            contextMenuStrip1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private NotifyIcon notifyIcon1;
        private Panel panel1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem tsInteractiveForm;
        private ToolStripMenuItem tsExit;
        private Label label1;
        private TrackBar trackBar1;
        private Button btnDisableFormInteractive;
        private Button btnExit;
    }
}