namespace PhotoSlideMaker
{
    partial class FrmDepura
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
            lbxAdicionales = new ListBox();
            pbImagen = new PictureBox();
            btAgregarImagen = new Button();
            btEliminarImagen = new Button();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            SuspendLayout();
            // 
            // lbxAdicionales
            // 
            lbxAdicionales.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbxAdicionales.BackColor = SystemColors.Info;
            lbxAdicionales.FormattingEnabled = true;
            lbxAdicionales.ItemHeight = 15;
            lbxAdicionales.Location = new Point(27, 34);
            lbxAdicionales.Name = "lbxAdicionales";
            lbxAdicionales.Size = new Size(579, 394);
            lbxAdicionales.TabIndex = 55;
            lbxAdicionales.MouseDoubleClick += LbxAdicionales_MouseDoubleClick;
            // 
            // pbImagen
            // 
            pbImagen.BorderStyle = BorderStyle.FixedSingle;
            pbImagen.Location = new Point(632, 62);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new Size(261, 188);
            pbImagen.SizeMode = PictureBoxSizeMode.Zoom;
            pbImagen.TabIndex = 56;
            pbImagen.TabStop = false;
            // 
            // btAgregarImagen
            // 
            btAgregarImagen.BackColor = Color.White;
            btAgregarImagen.Image = Properties.Resources.WRITE07A;
            btAgregarImagen.Location = new Point(632, 274);
            btAgregarImagen.Name = "btAgregarImagen";
            btAgregarImagen.Size = new Size(89, 74);
            btAgregarImagen.TabIndex = 57;
            btAgregarImagen.Text = "&Agregar al PhotoList";
            btAgregarImagen.TextImageRelation = TextImageRelation.ImageAboveText;
            btAgregarImagen.UseVisualStyleBackColor = false;
            btAgregarImagen.Click += BtAgregarImagen_Click;
            // 
            // btEliminarImagen
            // 
            btEliminarImagen.BackColor = Color.White;
            btEliminarImagen.Image = Properties.Resources.CheckX;
            btEliminarImagen.Location = new Point(804, 274);
            btEliminarImagen.Name = "btEliminarImagen";
            btEliminarImagen.Size = new Size(89, 74);
            btEliminarImagen.TabIndex = 58;
            btEliminarImagen.Text = "&Eliminar Imagen";
            btEliminarImagen.TextImageRelation = TextImageRelation.ImageAboveText;
            btEliminarImagen.UseVisualStyleBackColor = false;
            // 
            // FrmDepura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 450);
            Controls.Add(btEliminarImagen);
            Controls.Add(btAgregarImagen);
            Controls.Add(pbImagen);
            Controls.Add(lbxAdicionales);
            Name = "FrmDepura";
            ShowIcon = false;
            FormClosing += FrmShow_FormClosing;
            Load += FrmShow_Load;
            ((System.ComponentModel.ISupportInitialize)pbImagen).EndInit();
            ResumeLayout(false);
        }

        #endregion


        private ListBox lbxAdicionales;
        private PictureBox pbImagen;
        private Button btAgregarImagen;
        private Button btEliminarImagen;
    }
}
