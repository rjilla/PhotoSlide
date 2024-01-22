namespace PhotoSlide
{
    partial class FrmShow
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
            pbCavanas = new PictureBox();
            btExit = new Button();
            btMax = new Button();
            btMin = new Button();
            btStopAudio = new Button();
            tbVolumen = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)pbCavanas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbVolumen).BeginInit();
            SuspendLayout();
            // 
            // pbCavanas
            // 
            pbCavanas.BackgroundImageLayout = ImageLayout.None;
            pbCavanas.Dock = DockStyle.Fill;
            pbCavanas.Location = new Point(0, 0);
            pbCavanas.Name = "pbCavanas";
            pbCavanas.Size = new Size(1030, 724);
            pbCavanas.SizeMode = PictureBoxSizeMode.Zoom;
            pbCavanas.TabIndex = 0;
            pbCavanas.TabStop = false;
            // 
            // btExit
            // 
            btExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btExit.BackColor = SystemColors.ButtonFace;
            btExit.FlatAppearance.BorderSize = 0;
            btExit.FlatStyle = FlatStyle.Flat;
            btExit.Location = new Point(1007, 0);
            btExit.Name = "btExit";
            btExit.Size = new Size(23, 23);
            btExit.TabIndex = 0;
            btExit.Text = "X";
            btExit.UseVisualStyleBackColor = false;
            btExit.Click += ExitClick;
            // 
            // btMax
            // 
            btMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btMax.BackColor = SystemColors.ButtonFace;
            btMax.FlatAppearance.BorderSize = 0;
            btMax.FlatStyle = FlatStyle.Flat;
            btMax.Location = new Point(984, 0);
            btMax.Name = "btMax";
            btMax.Size = new Size(23, 23);
            btMax.TabIndex = 1;
            btMax.Text = "[]";
            btMax.UseVisualStyleBackColor = false;
            btMax.Click += MaxClick;
            // 
            // btMin
            // 
            btMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btMin.BackColor = SystemColors.ButtonFace;
            btMin.FlatAppearance.BorderSize = 0;
            btMin.FlatStyle = FlatStyle.Flat;
            btMin.Location = new Point(961, 0);
            btMin.Name = "btMin";
            btMin.Size = new Size(23, 23);
            btMin.TabIndex = 2;
            btMin.Text = "__";
            btMin.UseVisualStyleBackColor = false;
            btMin.Click += MinClick;
            // 
            // btStopAudio
            // 
            btStopAudio.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btStopAudio.BackColor = SystemColors.ButtonFace;
            btStopAudio.FlatAppearance.BorderSize = 0;
            btStopAudio.FlatStyle = FlatStyle.Flat;
            btStopAudio.Location = new Point(939, 690);
            btStopAudio.Name = "btStopAudio";
            btStopAudio.Size = new Size(36, 23);
            btStopAudio.TabIndex = 3;
            btStopAudio.Text = "<)))";
            btStopAudio.UseVisualStyleBackColor = false;
            btStopAudio.Click += OnButtonStopClick;
            // 
            // tbVolumen
            // 
            tbVolumen.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tbVolumen.Location = new Point(975, 679);
            tbVolumen.Maximum = 100;
            tbVolumen.Name = "tbVolumen";
            tbVolumen.Size = new Size(60, 45);
            tbVolumen.TabIndex = 4;
            tbVolumen.TickFrequency = 10;
            tbVolumen.TickStyle = TickStyle.TopLeft;
            tbVolumen.Value = 20;
            tbVolumen.Scroll += TbVolumen_Scroll;
            // 
            // FrmShow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 724);
            ControlBox = false;
            Controls.Add(tbVolumen);
            Controls.Add(btStopAudio);
            Controls.Add(btMin);
            Controls.Add(btMax);
            Controls.Add(btExit);
            Controls.Add(pbCavanas);
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmShow";
            ShowIcon = false;
            WindowState = FormWindowState.Maximized;
            FormClosing += FrmShow_FormClosing;
            Load += FrmShow_Load;
            KeyPress += FrmShow_KeyPress;
            ((System.ComponentModel.ISupportInitialize)pbCavanas).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbVolumen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbCavanas;
        private Button btExit;
        private Button btMax;
        private Button btMin;
        private Button btStopAudio;
        private TrackBar tbVolumen;
    }
}
