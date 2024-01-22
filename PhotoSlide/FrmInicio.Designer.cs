namespace PhotoSlide
{
    partial class FrmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txSVPFile = new TextBox();
            btRunPreset = new Button();
            txPresetName = new TextBox();
            txAuthor = new TextBox();
            txWebsite = new TextBox();
            txMaxWinSize = new TextBox();
            txEmail = new TextBox();
            txTimePerPic = new TextBox();
            txFullScreen = new TextBox();
            txAudio = new TextBox();
            txDescription = new TextBox();
            lbSVPFile = new Label();
            lbPresetName = new Label();
            lbAutor = new Label();
            lbWebsite = new Label();
            lbMaxWinSize = new Label();
            lbDescription = new Label();
            lbEmail = new Label();
            lbTimePerPic = new Label();
            lbFullScreen = new Label();
            lbAudio = new Label();
            pbAvatar = new PictureBox();
            lbAvatar = new Label();
            txAvatar = new TextBox();
            lbxPhotoList = new ListBox();
            lbPhotoList = new Label();
            ckInitiateAudioEachCycle = new CheckBox();
            ckLoopPhotoCycle = new CheckBox();
            gbRunPreset = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).BeginInit();
            gbRunPreset.SuspendLayout();
            SuspendLayout();
            // 
            // txSVPFile
            // 
            txSVPFile.BackColor = SystemColors.Info;
            txSVPFile.Location = new Point(98, 12);
            txSVPFile.Name = "txSVPFile";
            txSVPFile.ReadOnly = true;
            txSVPFile.Size = new Size(553, 23);
            txSVPFile.TabIndex = 0;
            // 
            // btRunPreset
            // 
            btRunPreset.Location = new Point(183, 56);
            btRunPreset.Name = "btRunPreset";
            btRunPreset.Size = new Size(75, 23);
            btRunPreset.TabIndex = 1;
            btRunPreset.Text = "&Run";
            btRunPreset.UseVisualStyleBackColor = true;
            btRunPreset.Click += BtRunPreset_Click;
            // 
            // txPresetName
            // 
            txPresetName.BackColor = SystemColors.Info;
            txPresetName.Location = new Point(98, 40);
            txPresetName.Name = "txPresetName";
            txPresetName.ReadOnly = true;
            txPresetName.Size = new Size(198, 23);
            txPresetName.TabIndex = 2;
            // 
            // txAuthor
            // 
            txAuthor.BackColor = SystemColors.Info;
            txAuthor.Location = new Point(389, 40);
            txAuthor.Name = "txAuthor";
            txAuthor.ReadOnly = true;
            txAuthor.Size = new Size(142, 23);
            txAuthor.TabIndex = 3;
            // 
            // txWebsite
            // 
            txWebsite.BackColor = SystemColors.Info;
            txWebsite.Location = new Point(98, 170);
            txWebsite.Name = "txWebsite";
            txWebsite.ReadOnly = true;
            txWebsite.Size = new Size(198, 23);
            txWebsite.TabIndex = 4;
            // 
            // txMaxWinSize
            // 
            txMaxWinSize.BackColor = SystemColors.Info;
            txMaxWinSize.Location = new Point(98, 254);
            txMaxWinSize.Name = "txMaxWinSize";
            txMaxWinSize.ReadOnly = true;
            txMaxWinSize.Size = new Size(72, 23);
            txMaxWinSize.TabIndex = 5;
            // 
            // txEmail
            // 
            txEmail.BackColor = SystemColors.Info;
            txEmail.Location = new Point(98, 198);
            txEmail.Name = "txEmail";
            txEmail.ReadOnly = true;
            txEmail.Size = new Size(198, 23);
            txEmail.TabIndex = 6;
            // 
            // txTimePerPic
            // 
            txTimePerPic.BackColor = SystemColors.Info;
            txTimePerPic.Location = new Point(98, 226);
            txTimePerPic.Name = "txTimePerPic";
            txTimePerPic.ReadOnly = true;
            txTimePerPic.Size = new Size(72, 23);
            txTimePerPic.TabIndex = 7;
            // 
            // txFullScreen
            // 
            txFullScreen.BackColor = SystemColors.Info;
            txFullScreen.Location = new Point(98, 282);
            txFullScreen.Name = "txFullScreen";
            txFullScreen.ReadOnly = true;
            txFullScreen.Size = new Size(39, 23);
            txFullScreen.TabIndex = 8;
            // 
            // txAudio
            // 
            txAudio.BackColor = SystemColors.Info;
            txAudio.Location = new Point(98, 310);
            txAudio.Name = "txAudio";
            txAudio.ReadOnly = true;
            txAudio.Size = new Size(198, 23);
            txAudio.TabIndex = 9;
            // 
            // txDescription
            // 
            txDescription.BackColor = SystemColors.Info;
            txDescription.Location = new Point(98, 68);
            txDescription.Multiline = true;
            txDescription.Name = "txDescription";
            txDescription.ReadOnly = true;
            txDescription.Size = new Size(433, 96);
            txDescription.TabIndex = 11;
            // 
            // lbSVPFile
            // 
            lbSVPFile.AutoSize = true;
            lbSVPFile.Location = new Point(44, 15);
            lbSVPFile.Name = "lbSVPFile";
            lbSVPFile.Size = new Size(48, 15);
            lbSVPFile.TabIndex = 13;
            lbSVPFile.Text = "SVP File";
            // 
            // lbPresetName
            // 
            lbPresetName.AutoSize = true;
            lbPresetName.Location = new Point(18, 43);
            lbPresetName.Name = "lbPresetName";
            lbPresetName.Size = new Size(74, 15);
            lbPresetName.TabIndex = 14;
            lbPresetName.Text = "Preset Name";
            // 
            // lbAutor
            // 
            lbAutor.AutoSize = true;
            lbAutor.Location = new Point(342, 43);
            lbAutor.Name = "lbAutor";
            lbAutor.Size = new Size(37, 15);
            lbAutor.TabIndex = 15;
            lbAutor.Text = "Autor";
            // 
            // lbWebsite
            // 
            lbWebsite.AutoSize = true;
            lbWebsite.Location = new Point(43, 173);
            lbWebsite.Name = "lbWebsite";
            lbWebsite.Size = new Size(49, 15);
            lbWebsite.TabIndex = 16;
            lbWebsite.Text = "Website";
            // 
            // lbMaxWinSize
            // 
            lbMaxWinSize.AutoSize = true;
            lbMaxWinSize.Location = new Point(21, 257);
            lbMaxWinSize.Name = "lbMaxWinSize";
            lbMaxWinSize.Size = new Size(71, 15);
            lbMaxWinSize.TabIndex = 17;
            lbMaxWinSize.Text = "MaxWinSize";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(26, 71);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(67, 15);
            lbDescription.TabIndex = 18;
            lbDescription.Text = "Description";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(56, 201);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 19;
            lbEmail.Text = "Email";
            // 
            // lbTimePerPic
            // 
            lbTimePerPic.AutoSize = true;
            lbTimePerPic.Location = new Point(26, 229);
            lbTimePerPic.Name = "lbTimePerPic";
            lbTimePerPic.Size = new Size(66, 15);
            lbTimePerPic.TabIndex = 20;
            lbTimePerPic.Text = "TimePerPic";
            // 
            // lbFullScreen
            // 
            lbFullScreen.AutoSize = true;
            lbFullScreen.Location = new Point(31, 285);
            lbFullScreen.Name = "lbFullScreen";
            lbFullScreen.Size = new Size(61, 15);
            lbFullScreen.TabIndex = 21;
            lbFullScreen.Text = "FullScreen";
            // 
            // lbAudio
            // 
            lbAudio.AutoSize = true;
            lbAudio.Location = new Point(53, 313);
            lbAudio.Name = "lbAudio";
            lbAudio.Size = new Size(39, 15);
            lbAudio.TabIndex = 22;
            lbAudio.Text = "Audio";
            // 
            // pbAvatar
            // 
            pbAvatar.Location = new Point(312, 213);
            pbAvatar.Name = "pbAvatar";
            pbAvatar.Size = new Size(233, 122);
            pbAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            pbAvatar.TabIndex = 23;
            pbAvatar.TabStop = false;
            // 
            // lbAvatar
            // 
            lbAvatar.AutoSize = true;
            lbAvatar.Location = new Point(338, 188);
            lbAvatar.Name = "lbAvatar";
            lbAvatar.Size = new Size(41, 15);
            lbAvatar.TabIndex = 25;
            lbAvatar.Text = "Avatar";
            // 
            // txAvatar
            // 
            txAvatar.BackColor = SystemColors.Info;
            txAvatar.Location = new Point(389, 184);
            txAvatar.Name = "txAvatar";
            txAvatar.ReadOnly = true;
            txAvatar.Size = new Size(142, 23);
            txAvatar.TabIndex = 24;
            // 
            // lbxPhotoList
            // 
            lbxPhotoList.BackColor = SystemColors.Info;
            lbxPhotoList.FormattingEnabled = true;
            lbxPhotoList.ItemHeight = 15;
            lbxPhotoList.Location = new Point(579, 70);
            lbxPhotoList.Name = "lbxPhotoList";
            lbxPhotoList.Size = new Size(209, 349);
            lbxPhotoList.TabIndex = 26;
            // 
            // lbPhotoList
            // 
            lbPhotoList.AutoSize = true;
            lbPhotoList.Location = new Point(661, 52);
            lbPhotoList.Name = "lbPhotoList";
            lbPhotoList.Size = new Size(60, 15);
            lbPhotoList.TabIndex = 27;
            lbPhotoList.Text = "Photo List";
            // 
            // ckInitiateAudioEachCycle
            // 
            ckInitiateAudioEachCycle.AutoSize = true;
            ckInitiateAudioEachCycle.Location = new Point(16, 30);
            ckInitiateAudioEachCycle.Name = "ckInitiateAudioEachCycle";
            ckInitiateAudioEachCycle.Size = new Size(157, 19);
            ckInitiateAudioEachCycle.TabIndex = 28;
            ckInitiateAudioEachCycle.Text = "Initiate Audio Each Cycle";
            ckInitiateAudioEachCycle.UseVisualStyleBackColor = true;
            ckInitiateAudioEachCycle.CheckedChanged += CkInitiateAudioEachCycle_CheckedChanged;
            // 
            // ckLoopPhotoCycle
            // 
            ckLoopPhotoCycle.AutoSize = true;
            ckLoopPhotoCycle.Location = new Point(16, 59);
            ckLoopPhotoCycle.Name = "ckLoopPhotoCycle";
            ckLoopPhotoCycle.Size = new Size(120, 19);
            ckLoopPhotoCycle.TabIndex = 29;
            ckLoopPhotoCycle.Text = "Loop Photo Cycle";
            ckLoopPhotoCycle.UseVisualStyleBackColor = true;
            ckLoopPhotoCycle.CheckedChanged += CkLoopPhotoCycle_CheckedChanged;
            // 
            // gbRunPreset
            // 
            gbRunPreset.Controls.Add(ckInitiateAudioEachCycle);
            gbRunPreset.Controls.Add(ckLoopPhotoCycle);
            gbRunPreset.Controls.Add(btRunPreset);
            gbRunPreset.ForeColor = Color.Blue;
            gbRunPreset.Location = new Point(186, 338);
            gbRunPreset.Name = "gbRunPreset";
            gbRunPreset.Size = new Size(274, 100);
            gbRunPreset.TabIndex = 30;
            gbRunPreset.TabStop = false;
            gbRunPreset.Text = "Run Preset";
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbRunPreset);
            Controls.Add(lbPhotoList);
            Controls.Add(lbxPhotoList);
            Controls.Add(lbAvatar);
            Controls.Add(txAvatar);
            Controls.Add(pbAvatar);
            Controls.Add(lbAudio);
            Controls.Add(lbFullScreen);
            Controls.Add(lbTimePerPic);
            Controls.Add(lbEmail);
            Controls.Add(lbDescription);
            Controls.Add(lbMaxWinSize);
            Controls.Add(lbWebsite);
            Controls.Add(lbAutor);
            Controls.Add(lbPresetName);
            Controls.Add(lbSVPFile);
            Controls.Add(txDescription);
            Controls.Add(txAudio);
            Controls.Add(txFullScreen);
            Controls.Add(txTimePerPic);
            Controls.Add(txEmail);
            Controls.Add(txMaxWinSize);
            Controls.Add(txWebsite);
            Controls.Add(txAuthor);
            Controls.Add(txPresetName);
            Controls.Add(txSVPFile);
            Name = "FrmInicio";
            ShowIcon = false;
            Text = "Setting";
            FormClosing += FrmInicio_FormClosing;
            Load += FrmInicio_Load;
            ((System.ComponentModel.ISupportInitialize)pbAvatar).EndInit();
            gbRunPreset.ResumeLayout(false);
            gbRunPreset.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txSVPFile;
        private Button btRunPreset;
        private TextBox txPresetName;
        private TextBox txAuthor;
        private TextBox txWebsite;
        private TextBox txMaxWinSize;
        private TextBox txEmail;
        private TextBox txTimePerPic;
        private TextBox txFullScreen;
        private TextBox txAudio;
        private TextBox txDescription;
        private Label lbSVPFile;
        private Label lbPresetName;
        private Label lbAutor;
        private Label lbWebsite;
        private Label lbMaxWinSize;
        private Label lbDescription;
        private Label lbEmail;
        private Label lbTimePerPic;
        private Label lbFullScreen;
        private Label lbAudio;
        private PictureBox pbAvatar;
        private Label lbAvatar;
        private TextBox txAvatar;
        private ListBox lbxPhotoList;
        private Label lbPhotoList;
        private CheckBox ckInitiateAudioEachCycle;
        private CheckBox ckLoopPhotoCycle;
        private GroupBox gbRunPreset;
    }
}