namespace WinFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            trackBar1 = new TrackBar();
            label1 = new Label();
            debuglbl = new Label();
            boxpic = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boxpic).BeginInit();
            SuspendLayout();
            // 
            // trackBar1
            // 
            trackBar1.BackColor = SystemColors.ButtonHighlight;
            trackBar1.Location = new Point(64, 691);
            trackBar1.Maximum = 5;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(1014, 45);
            trackBar1.TabIndex = 0;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 673);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 1;
            label1.Text = "Select Photo:";
            // 
            // debuglbl
            // 
            debuglbl.AutoSize = true;
            debuglbl.ForeColor = SystemColors.ControlLight;
            debuglbl.Location = new Point(12, 760);
            debuglbl.Name = "debuglbl";
            debuglbl.Size = new Size(47, 15);
            debuglbl.TabIndex = 2;
            debuglbl.Text = "DEBUG:";
            // 
            // boxpic
            // 
            boxpic.Anchor = AnchorStyles.Top;
            boxpic.BackColor = SystemColors.ControlLight;
            boxpic.BackgroundImageLayout = ImageLayout.Center;
            boxpic.InitialImage = (Image)resources.GetObject("boxpic.InitialImage");
            boxpic.Location = new Point(64, 12);
            boxpic.MaximumSize = new Size(1014, 630);
            boxpic.MinimumSize = new Size(1014, 630);
            boxpic.Name = "boxpic";
            boxpic.Size = new Size(1014, 630);
            boxpic.SizeMode = PictureBoxSizeMode.CenterImage;
            boxpic.TabIndex = 3;
            boxpic.TabStop = false;
            boxpic.WaitOnLoad = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1151, 784);
            Controls.Add(trackBar1);
            Controls.Add(debuglbl);
            Controls.Add(label1);
            Controls.Add(boxpic);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "homer collage";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)boxpic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBar1;
        private Label label1;
        private Label debuglbl;
        private PictureBox boxpic;
    }
}