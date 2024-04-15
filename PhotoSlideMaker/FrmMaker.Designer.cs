namespace PhotoSlideMaker
{
    partial class FrmMaker
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
            gbRunPreset = new GroupBox();
            ckInitiateAudioEachCycle = new CheckBox();
            ckLoopPhotoCycle = new CheckBox();
            btRunPreset = new Button();
            lbPhotoList = new Label();
            lbxPhotoList = new ListBox();
            lbAvatar = new Label();
            txAvatar = new TextBox();
            pbAvatar = new PictureBox();
            lbAudio = new Label();
            lbFullScreen = new Label();
            lbTimePerPic = new Label();
            lbEmail = new Label();
            lbDescription = new Label();
            lbMaxWinSize = new Label();
            lbWebsite = new Label();
            lbAutor = new Label();
            lbPresetName = new Label();
            lbSVPFile = new Label();
            txDescription = new TextBox();
            txAudio = new TextBox();
            txFullScreen = new TextBox();
            txTimePerPic = new TextBox();
            txEmail = new TextBox();
            txMaxWinSize = new TextBox();
            txWebsite = new TextBox();
            txAuthor = new TextBox();
            txPresetName = new TextBox();
            txSVPFile = new TextBox();
            fbdBuscaCarpeta = new FolderBrowserDialog();
            lbCarpeta = new Label();
            txCarpeta = new TextBox();
            btBuscaCarpeta = new Button();
            btBuscaAvatar = new Button();
            ofdBuscaArchivo = new OpenFileDialog();
            btAgregaImagen = new Button();
            btBorraImagen = new Button();
            btGrabar = new Button();
            btBuscaAudio = new Button();
            btCargaPreset = new Button();
            btLimpiarPantalla = new Button();
            lbSinUso1 = new Label();
            lbSinEfecto = new Label();
            txTotalFotos = new TextBox();
            gbRunPreset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).BeginInit();
            SuspendLayout();
            // 
            // gbRunPreset
            // 
            gbRunPreset.Controls.Add(ckInitiateAudioEachCycle);
            gbRunPreset.Controls.Add(ckLoopPhotoCycle);
            gbRunPreset.Controls.Add(btRunPreset);
            gbRunPreset.ForeColor = Color.Blue;
            gbRunPreset.Location = new Point(24, 360);
            gbRunPreset.Name = "gbRunPreset";
            gbRunPreset.Size = new Size(274, 81);
            gbRunPreset.TabIndex = 56;
            gbRunPreset.TabStop = false;
            gbRunPreset.Text = "Run Preset";
            // 
            // ckInitiateAudioEachCycle
            // 
            ckInitiateAudioEachCycle.AutoSize = true;
            ckInitiateAudioEachCycle.Location = new Point(15, 22);
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
            ckLoopPhotoCycle.Location = new Point(15, 51);
            ckLoopPhotoCycle.Name = "ckLoopPhotoCycle";
            ckLoopPhotoCycle.Size = new Size(120, 19);
            ckLoopPhotoCycle.TabIndex = 29;
            ckLoopPhotoCycle.Text = "Loop Photo Cycle";
            ckLoopPhotoCycle.UseVisualStyleBackColor = true;
            ckLoopPhotoCycle.CheckedChanged += CkLoopPhotoCycle_CheckedChanged;
            // 
            // btRunPreset
            // 
            btRunPreset.Location = new Point(178, 33);
            btRunPreset.Name = "btRunPreset";
            btRunPreset.Size = new Size(75, 28);
            btRunPreset.TabIndex = 1;
            btRunPreset.Text = "&Run";
            btRunPreset.UseVisualStyleBackColor = true;
            btRunPreset.Click += BtRunPreset_Click;
            // 
            // lbPhotoList
            // 
            lbPhotoList.AutoSize = true;
            lbPhotoList.Location = new Point(663, 15);
            lbPhotoList.Name = "lbPhotoList";
            lbPhotoList.Size = new Size(60, 15);
            lbPhotoList.TabIndex = 55;
            lbPhotoList.Text = "Photo List";
            // 
            // lbxPhotoList
            // 
            lbxPhotoList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbxPhotoList.BackColor = SystemColors.Info;
            lbxPhotoList.FormattingEnabled = true;
            lbxPhotoList.ItemHeight = 15;
            lbxPhotoList.Location = new Point(586, 32);
            lbxPhotoList.Name = "lbxPhotoList";
            lbxPhotoList.Size = new Size(209, 409);
            lbxPhotoList.TabIndex = 54;
            // 
            // lbAvatar
            // 
            lbAvatar.AutoSize = true;
            lbAvatar.Location = new Point(311, 209);
            lbAvatar.Name = "lbAvatar";
            lbAvatar.Size = new Size(41, 15);
            lbAvatar.TabIndex = 53;
            lbAvatar.Text = "Avatar";
            // 
            // txAvatar
            // 
            txAvatar.BackColor = SystemColors.Window;
            txAvatar.Location = new Point(358, 205);
            txAvatar.Name = "txAvatar";
            txAvatar.Size = new Size(142, 23);
            txAvatar.TabIndex = 52;
            // 
            // pbAvatar
            // 
            pbAvatar.Location = new Point(310, 234);
            pbAvatar.Name = "pbAvatar";
            pbAvatar.Size = new Size(233, 122);
            pbAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            pbAvatar.TabIndex = 51;
            pbAvatar.TabStop = false;
            // 
            // lbAudio
            // 
            lbAudio.AutoSize = true;
            lbAudio.Location = new Point(51, 334);
            lbAudio.Name = "lbAudio";
            lbAudio.Size = new Size(39, 15);
            lbAudio.TabIndex = 50;
            lbAudio.Text = "Audio";
            // 
            // lbFullScreen
            // 
            lbFullScreen.AutoSize = true;
            lbFullScreen.Location = new Point(29, 306);
            lbFullScreen.Name = "lbFullScreen";
            lbFullScreen.Size = new Size(61, 15);
            lbFullScreen.TabIndex = 49;
            lbFullScreen.Text = "FullScreen";
            // 
            // lbTimePerPic
            // 
            lbTimePerPic.AutoSize = true;
            lbTimePerPic.Location = new Point(24, 250);
            lbTimePerPic.Name = "lbTimePerPic";
            lbTimePerPic.Size = new Size(66, 15);
            lbTimePerPic.TabIndex = 48;
            lbTimePerPic.Text = "TimePerPic";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(54, 222);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 47;
            lbEmail.Text = "Email";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(24, 92);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(67, 15);
            lbDescription.TabIndex = 46;
            lbDescription.Text = "Description";
            // 
            // lbMaxWinSize
            // 
            lbMaxWinSize.AutoSize = true;
            lbMaxWinSize.Location = new Point(19, 278);
            lbMaxWinSize.Name = "lbMaxWinSize";
            lbMaxWinSize.Size = new Size(71, 15);
            lbMaxWinSize.TabIndex = 45;
            lbMaxWinSize.Text = "MaxWinSize";
            // 
            // lbWebsite
            // 
            lbWebsite.AutoSize = true;
            lbWebsite.Location = new Point(41, 194);
            lbWebsite.Name = "lbWebsite";
            lbWebsite.Size = new Size(49, 15);
            lbWebsite.TabIndex = 44;
            lbWebsite.Text = "Website";
            // 
            // lbAutor
            // 
            lbAutor.AutoSize = true;
            lbAutor.Location = new Point(358, 64);
            lbAutor.Name = "lbAutor";
            lbAutor.Size = new Size(37, 15);
            lbAutor.TabIndex = 43;
            lbAutor.Text = "Autor";
            // 
            // lbPresetName
            // 
            lbPresetName.AutoSize = true;
            lbPresetName.Location = new Point(16, 64);
            lbPresetName.Name = "lbPresetName";
            lbPresetName.Size = new Size(74, 15);
            lbPresetName.TabIndex = 42;
            lbPresetName.Text = "Preset Name";
            // 
            // lbSVPFile
            // 
            lbSVPFile.AutoSize = true;
            lbSVPFile.Location = new Point(42, 36);
            lbSVPFile.Name = "lbSVPFile";
            lbSVPFile.Size = new Size(48, 15);
            lbSVPFile.TabIndex = 41;
            lbSVPFile.Text = "SVP File";
            // 
            // txDescription
            // 
            txDescription.BackColor = SystemColors.Window;
            txDescription.Location = new Point(96, 89);
            txDescription.Multiline = true;
            txDescription.Name = "txDescription";
            txDescription.Size = new Size(447, 96);
            txDescription.TabIndex = 40;
            // 
            // txAudio
            // 
            txAudio.BackColor = SystemColors.Window;
            txAudio.Location = new Point(96, 331);
            txAudio.Name = "txAudio";
            txAudio.Size = new Size(173, 23);
            txAudio.TabIndex = 39;
            // 
            // txFullScreen
            // 
            txFullScreen.BackColor = SystemColors.Window;
            txFullScreen.Location = new Point(96, 303);
            txFullScreen.Name = "txFullScreen";
            txFullScreen.Size = new Size(39, 23);
            txFullScreen.TabIndex = 38;
            // 
            // txTimePerPic
            // 
            txTimePerPic.BackColor = SystemColors.Window;
            txTimePerPic.Location = new Point(96, 247);
            txTimePerPic.Name = "txTimePerPic";
            txTimePerPic.Size = new Size(72, 23);
            txTimePerPic.TabIndex = 37;
            // 
            // txEmail
            // 
            txEmail.BackColor = SystemColors.Window;
            txEmail.Location = new Point(96, 219);
            txEmail.Name = "txEmail";
            txEmail.Size = new Size(198, 23);
            txEmail.TabIndex = 36;
            // 
            // txMaxWinSize
            // 
            txMaxWinSize.BackColor = SystemColors.Window;
            txMaxWinSize.Location = new Point(96, 275);
            txMaxWinSize.Name = "txMaxWinSize";
            txMaxWinSize.Size = new Size(72, 23);
            txMaxWinSize.TabIndex = 35;
            // 
            // txWebsite
            // 
            txWebsite.BackColor = SystemColors.Window;
            txWebsite.Location = new Point(96, 191);
            txWebsite.Name = "txWebsite";
            txWebsite.Size = new Size(198, 23);
            txWebsite.TabIndex = 34;
            // 
            // txAuthor
            // 
            txAuthor.BackColor = SystemColors.Window;
            txAuthor.Location = new Point(401, 61);
            txAuthor.Name = "txAuthor";
            txAuthor.Size = new Size(142, 23);
            txAuthor.TabIndex = 33;
            // 
            // txPresetName
            // 
            txPresetName.BackColor = SystemColors.Window;
            txPresetName.Location = new Point(96, 61);
            txPresetName.Name = "txPresetName";
            txPresetName.Size = new Size(198, 23);
            txPresetName.TabIndex = 32;
            // 
            // txSVPFile
            // 
            txSVPFile.BackColor = SystemColors.Window;
            txSVPFile.Location = new Point(96, 33);
            txSVPFile.Name = "txSVPFile";
            txSVPFile.Size = new Size(236, 23);
            txSVPFile.TabIndex = 31;
            // 
            // lbCarpeta
            // 
            lbCarpeta.AutoSize = true;
            lbCarpeta.Location = new Point(42, 7);
            lbCarpeta.Name = "lbCarpeta";
            lbCarpeta.Size = new Size(48, 15);
            lbCarpeta.TabIndex = 58;
            lbCarpeta.Text = "Carpeta";
            // 
            // txCarpeta
            // 
            txCarpeta.BackColor = SystemColors.Window;
            txCarpeta.Location = new Point(96, 4);
            txCarpeta.Name = "txCarpeta";
            txCarpeta.Size = new Size(236, 23);
            txCarpeta.TabIndex = 57;
            // 
            // btBuscaCarpeta
            // 
            btBuscaCarpeta.BackColor = Color.White;
            btBuscaCarpeta.BackgroundImage = Properties.Resources.buscar;
            btBuscaCarpeta.BackgroundImageLayout = ImageLayout.Zoom;
            btBuscaCarpeta.Location = new Point(338, 4);
            btBuscaCarpeta.Name = "btBuscaCarpeta";
            btBuscaCarpeta.Size = new Size(29, 23);
            btBuscaCarpeta.TabIndex = 59;
            btBuscaCarpeta.UseVisualStyleBackColor = false;
            btBuscaCarpeta.Click += BtBuscaCarpeta_Click;
            // 
            // btBuscaAvatar
            // 
            btBuscaAvatar.BackColor = Color.White;
            btBuscaAvatar.BackgroundImage = Properties.Resources.buscar;
            btBuscaAvatar.BackgroundImageLayout = ImageLayout.Zoom;
            btBuscaAvatar.Location = new Point(506, 205);
            btBuscaAvatar.Name = "btBuscaAvatar";
            btBuscaAvatar.Size = new Size(29, 23);
            btBuscaAvatar.TabIndex = 60;
            btBuscaAvatar.UseVisualStyleBackColor = false;
            btBuscaAvatar.Click += BtBuscaAvatar_Click;
            // 
            // ofdBuscaArchivo
            // 
            ofdBuscaArchivo.Title = "Busca Imagen";
            // 
            // btAgregaImagen
            // 
            btAgregaImagen.BackColor = Color.White;
            btAgregaImagen.BackgroundImage = Properties.Resources.add_24;
            btAgregaImagen.BackgroundImageLayout = ImageLayout.Zoom;
            btAgregaImagen.Location = new Point(550, 44);
            btAgregaImagen.Name = "btAgregaImagen";
            btAgregaImagen.Size = new Size(30, 26);
            btAgregaImagen.TabIndex = 61;
            btAgregaImagen.UseVisualStyleBackColor = false;
            btAgregaImagen.Click += BtAgregaImagen_Click;
            // 
            // btBorraImagen
            // 
            btBorraImagen.BackColor = Color.White;
            btBorraImagen.BackgroundImage = Properties.Resources.delete_24;
            btBorraImagen.BackgroundImageLayout = ImageLayout.Zoom;
            btBorraImagen.Location = new Point(550, 406);
            btBorraImagen.Name = "btBorraImagen";
            btBorraImagen.Size = new Size(30, 26);
            btBorraImagen.TabIndex = 62;
            btBorraImagen.UseVisualStyleBackColor = false;
            btBorraImagen.Click += BtBorraImagen_Click;
            // 
            // btGrabar
            // 
            btGrabar.BackColor = Color.Red;
            btGrabar.FlatStyle = FlatStyle.Flat;
            btGrabar.Location = new Point(390, 394);
            btGrabar.Name = "btGrabar";
            btGrabar.Size = new Size(75, 28);
            btGrabar.TabIndex = 63;
            btGrabar.Text = "&Grabar";
            btGrabar.UseVisualStyleBackColor = false;
            btGrabar.Click += BtGrabar_Click;
            // 
            // btBuscaAudio
            // 
            btBuscaAudio.BackColor = Color.White;
            btBuscaAudio.BackgroundImage = Properties.Resources.buscar;
            btBuscaAudio.BackgroundImageLayout = ImageLayout.Zoom;
            btBuscaAudio.Location = new Point(275, 331);
            btBuscaAudio.Name = "btBuscaAudio";
            btBuscaAudio.Size = new Size(29, 23);
            btBuscaAudio.TabIndex = 64;
            btBuscaAudio.UseVisualStyleBackColor = false;
            btBuscaAudio.Click += BtBuscaAudio_Click;
            // 
            // btCargaPreset
            // 
            btCargaPreset.BackColor = Color.FromArgb(128, 255, 255);
            btCargaPreset.Location = new Point(373, 4);
            btCargaPreset.Name = "btCargaPreset";
            btCargaPreset.Size = new Size(75, 44);
            btCargaPreset.TabIndex = 65;
            btCargaPreset.Text = "&Carga Preset";
            btCargaPreset.UseVisualStyleBackColor = false;
            btCargaPreset.Click += BtCargaPreset_Click;
            // 
            // btLimpiarPantalla
            // 
            btLimpiarPantalla.Location = new Point(454, 4);
            btLimpiarPantalla.Name = "btLimpiarPantalla";
            btLimpiarPantalla.Size = new Size(75, 44);
            btLimpiarPantalla.TabIndex = 66;
            btLimpiarPantalla.Text = "&Limpiar Pantalla";
            btLimpiarPantalla.UseVisualStyleBackColor = true;
            btLimpiarPantalla.Click += BtLimpiarPantalla_Click;
            // 
            // lbSinUso1
            // 
            lbSinUso1.AutoSize = true;
            lbSinUso1.ForeColor = Color.Maroon;
            lbSinUso1.Location = new Point(174, 278);
            lbSinUso1.Name = "lbSinUso1";
            lbSinUso1.Size = new Size(67, 15);
            lbSinUso1.TabIndex = 67;
            lbSinUso1.Text = "(Sin Efecto)";
            // 
            // lbSinEfecto
            // 
            lbSinEfecto.AutoSize = true;
            lbSinEfecto.ForeColor = Color.Maroon;
            lbSinEfecto.Location = new Point(141, 306);
            lbSinEfecto.Name = "lbSinEfecto";
            lbSinEfecto.Size = new Size(67, 15);
            lbSinEfecto.TabIndex = 68;
            lbSinEfecto.Text = "(Sin Efecto)";
            // 
            // txTotalFotos
            // 
            txTotalFotos.BackColor = SystemColors.Info;
            txTotalFotos.Location = new Point(747, 4);
            txTotalFotos.Name = "txTotalFotos";
            txTotalFotos.ReadOnly = true;
            txTotalFotos.Size = new Size(48, 23);
            txTotalFotos.TabIndex = 69;
            txTotalFotos.TextAlign = HorizontalAlignment.Center;
            // 
            // FrmMaker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 450);
            Controls.Add(txTotalFotos);
            Controls.Add(lbSinEfecto);
            Controls.Add(lbSinUso1);
            Controls.Add(btLimpiarPantalla);
            Controls.Add(btCargaPreset);
            Controls.Add(btBuscaAudio);
            Controls.Add(btGrabar);
            Controls.Add(btBorraImagen);
            Controls.Add(btAgregaImagen);
            Controls.Add(btBuscaAvatar);
            Controls.Add(btBuscaCarpeta);
            Controls.Add(lbCarpeta);
            Controls.Add(txCarpeta);
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
            Name = "FrmMaker";
            ShowIcon = false;
            Text = "Maker";
            FormClosing += FrmMaker_FormClosing;
            gbRunPreset.ResumeLayout(false);
            gbRunPreset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbRunPreset;
        private CheckBox ckInitiateAudioEachCycle;
        private CheckBox ckLoopPhotoCycle;
        private Button btRunPreset;
        private Label lbPhotoList;
        private ListBox lbxPhotoList;
        private Label lbAvatar;
        private TextBox txAvatar;
        private PictureBox pbAvatar;
        private Label lbAudio;
        private Label lbFullScreen;
        private Label lbTimePerPic;
        private Label lbEmail;
        private Label lbDescription;
        private Label lbMaxWinSize;
        private Label lbWebsite;
        private Label lbAutor;
        private Label lbPresetName;
        private Label lbSVPFile;
        private TextBox txDescription;
        private TextBox txAudio;
        private TextBox txFullScreen;
        private TextBox txTimePerPic;
        private TextBox txEmail;
        private TextBox txMaxWinSize;
        private TextBox txWebsite;
        private TextBox txAuthor;
        private TextBox txPresetName;
        private TextBox txSVPFile;
        private FolderBrowserDialog fbdBuscaCarpeta;
        private Label lbCarpeta;
        private TextBox txCarpeta;
        private Button btBuscaCarpeta;
        private Button btBuscaAvatar;
        private OpenFileDialog ofdBuscaArchivo;
        private Button btAgregaImagen;
        private Button btBorraImagen;
        private Button btGrabar;
        private Button btBuscaAudio;
        private Button btCargaPreset;
        private Button btLimpiarPantalla;
        private Label lbSinUso1;
        private Label lbSinEfecto;
        private TextBox txTotalFotos;
    }
}
