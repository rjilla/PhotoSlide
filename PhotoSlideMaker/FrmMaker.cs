using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Linq;

namespace PhotoSlideMaker
{
    public partial class FrmMaker : Form
    {
        public FrmMaker()
        {
            InitializeComponent();
        }

        readonly BindingList<string> imagenes = new();
        void CargaPantalla()
        {
            txAudio.Text = ParseSettings.Audio;
            txAuthor.Text = ParseSettings.Author;
            txAvatar.Text = ParseSettings.Avatar;
            txDescription.Text = ParseSettings.Description;
            txEmail.Text = ParseSettings.Email;
            txFullScreen.Text = ParseSettings.Fullscreen;
            txMaxWinSize.Text = ParseSettings.MaxWinSize;
            txPresetName.Text = ParseSettings.PresetName;
            txTimePerPic.Text = ParseSettings.TimePerPic;
            txWebsite.Text = ParseSettings.Website;
            if (!string.IsNullOrEmpty(ParseSettings.Avatar))
                pbAvatar.Image = new Bitmap(txCarpeta.Text + '\\' + txAvatar.Text);
            imagenes.Clear();
            foreach (var item in ParseSettings.PhotoList)
            {
                imagenes.Add(item);
            }
            lbxPhotoList.DataSource = imagenes;
        }

        private void BtBuscaCarpeta_Click(object sender, EventArgs e)
        {
            DialogResult result = fbdBuscaCarpeta.ShowDialog();
            if (result == DialogResult.OK)
            {
                txCarpeta.Text = fbdBuscaCarpeta.SelectedPath;
                ParseSettings.ClearSetting();
                CargaPantalla();
            }
        }
        private void BtBuscaAvatar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txCarpeta.Text))
            {
                MessageBox.Show("Debe elegir la carpeta del preset.");
                return;
            }
            DialogResult result = ofdBuscaArchivo.ShowDialog();
            if (result == DialogResult.OK)
            {
                txAvatar.Text = ofdBuscaArchivo.SafeFileName;
                string fileDestino = txCarpeta.Text + '\\' + ofdBuscaArchivo.SafeFileName;
                if (!File.Exists(fileDestino))
                    File.Copy(ofdBuscaArchivo.FileName, fileDestino, true);
                pbAvatar.Image = new Bitmap(fileDestino);
            }
        }
        private void BtBuscaAudio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txCarpeta.Text))
            {
                MessageBox.Show("Debe elegir la carpeta del preset.");
                return;
            }
            DialogResult result = ofdBuscaArchivo.ShowDialog();
            if (result == DialogResult.OK)
            {
                txAudio.Text = ofdBuscaArchivo.SafeFileName;
                string fileDestino = txCarpeta.Text + '\\' + ofdBuscaArchivo.SafeFileName;
                if (!File.Exists(fileDestino))
                    File.Copy(ofdBuscaArchivo.FileName, fileDestino, true);
            }
        }
        private void BtAgregaImagen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txCarpeta.Text))
            {
                MessageBox.Show("Debe elegir la carpeta del preset.");
                return;
            }
            DialogResult result = ofdBuscaArchivo.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileDestino = txCarpeta.Text + '\\' + ofdBuscaArchivo.SafeFileName;
                if (!File.Exists(fileDestino))
                    File.Copy(ofdBuscaArchivo.FileName, fileDestino, true);
                imagenes.Add(ofdBuscaArchivo.SafeFileName);
            }
        }
        private void BtGrabar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txCarpeta.Text))
            {
                MessageBox.Show("Debe elegir la carpeta del preset.");
                return;
            }
            if (string.IsNullOrEmpty(txSVPFile.Text))
            {
                MessageBox.Show("Debe definir el nombre del SVP File.");
                return;
            }
            string fileDestino = txCarpeta.Text + '\\' + txSVPFile.Text;
            if (Path.GetExtension(fileDestino.ToLower()) != ".svp")
            {
                string ver = Path.GetExtension(fileDestino.ToLower());
                MessageBox.Show("La extensión del SVP File debe ser <.svp>. \r Se ingresó " + ver);
                return;
            }

            ParseSettings.Audio = txAudio.Text;
            ParseSettings.Author = txAuthor.Text;
            ParseSettings.Avatar = txAvatar.Text;
            ParseSettings.Description = txDescription.Text;
            ParseSettings.Email = txEmail.Text;
            ParseSettings.Fullscreen = txFullScreen.Text;
            ParseSettings.MaxWinSize = txMaxWinSize.Text;
            ParseSettings.PresetName = txPresetName.Text;
            ParseSettings.TimePerPic = txTimePerPic.Text;
            ParseSettings.Website = txWebsite.Text;
            ParseSettings.PhotoList.Clear();
            foreach (var item in imagenes)
            {
                ParseSettings.PhotoList.Add(item);
            }
            if (ParseSettings.GrabaSettings(fileDestino))
                MessageBox.Show("Se generó con exito el preset.");
            else
                MessageBox.Show("ERROR al generar el preset.");
        }
        private void BtCargaPreset_Click(object sender, EventArgs e)
        {
            DialogResult result = ofdBuscaArchivo.ShowDialog();
            if (result == DialogResult.OK)
            {
                txCarpeta.Text = Path.GetDirectoryName(ofdBuscaArchivo.FileName);
                txSVPFile.Text = ofdBuscaArchivo.SafeFileName;
                ParseSettings.CargaSetting(ofdBuscaArchivo.FileName);
                CargaPantalla();
            }
        }
        private void BtBorraImagen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Función en desarrollo");
        }
        private void BtLimpiarPantalla_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Función en desarrollo");
        }
    }
}
