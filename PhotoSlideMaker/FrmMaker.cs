using Microsoft.VisualBasic.Devices;
using NAudio.Wave;
using System.ComponentModel;

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
            if (string.IsNullOrEmpty(ParseSettings.Avatar))
                pbAvatar.Image = null;
            else
                pbAvatar.Image = new Bitmap(txCarpeta.Text + '\\' + txAvatar.Text);

            imagenes.Clear();
            foreach (var item in ParseSettings.PhotoList)
            {
                imagenes.Add(item);
            }
            lbxPhotoList.DataSource = imagenes;
            txTotalFotos.Text = imagenes.Count.ToString();
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
            try
            {
                if (string.IsNullOrEmpty(txCarpeta.Text))
                {
                    MessageBox.Show("Debe elegir la carpeta del preset.");
                    return;
                }
                ofdBuscaArchivo.Multiselect = false;
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
            catch (Exception ex)
            {
                MessageBox.Show(this.Owner, ex.Message);
                txAvatar.Text = string.Empty;
            }
        }
        private void BtBuscaAudio_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txCarpeta.Text))
                {
                    MessageBox.Show(this.Owner, "Debe elegir la carpeta del preset.");
                    return;
                }
                ofdBuscaArchivo.Multiselect = false;
                DialogResult result = ofdBuscaArchivo.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txAudio.Text = ofdBuscaArchivo.SafeFileName;
                    string fileDestino = txCarpeta.Text + '\\' + ofdBuscaArchivo.SafeFileName;
                    if (!File.Exists(fileDestino))
                        File.Copy(ofdBuscaArchivo.FileName, fileDestino, true);
                    AudioFileReader AudioFile;
                    if (!string.IsNullOrEmpty(txAudio.Text))
                        AudioFile = new AudioFileReader(fileDestino);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.Owner, ex.Message);
                txAvatar.Text = string.Empty;
            }
        }
        private void BtAgregaImagen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txCarpeta.Text))
            {
                MessageBox.Show(this.Owner, "Debe elegir la carpeta del preset.");
                return;
            }
            ofdBuscaArchivo.Multiselect = true;
            DialogResult result = ofdBuscaArchivo.ShowDialog();
            if (result == DialogResult.OK)
            {
                foreach (var item in ofdBuscaArchivo.FileNames)
                {
                    string file = Path.GetFileName(item);
                    string fileDestino = txCarpeta.Text + '\\' + file;
                    if (!File.Exists(fileDestino))
                        File.Copy(item, fileDestino, true);
                    imagenes.Add(file);
                    txTotalFotos.Text = imagenes.Count.ToString();
                }
            }
        }
        private void BtGrabar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txCarpeta.Text))
            {
                MessageBox.Show(this.Owner, "Debe elegir la carpeta del preset.");
                return;
            }
            if (string.IsNullOrEmpty(txSVPFile.Text))
            {
                MessageBox.Show(this.Owner, "Debe definir el nombre del SVP File.");
                return;
            }
            string fileDestino = txCarpeta.Text + '\\' + txSVPFile.Text;
            if (Path.GetExtension(fileDestino.ToLower()) != ".svp")
            {
                string ver = Path.GetExtension(fileDestino.ToLower());
                MessageBox.Show(this.Owner, "La extensión del SVP File debe ser <.svp>. \r Se ingresó " + ver);
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
                MessageBox.Show(this.Owner, "Se generó con exito el preset.");
            else
                MessageBox.Show(this.Owner, "ERROR al generar el preset.");
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
            try
            {
                if (string.IsNullOrEmpty(txCarpeta.Text))
                {
                    MessageBox.Show("Debe elegir la carpeta del preset.");
                    return;
                }
                int inx = lbxPhotoList.SelectedIndex;
                string? item = lbxPhotoList.SelectedItem.ToString();
                if (inx >= 0)
                {
                    DialogResult result = MessageBox.Show(this.Owner, "Desea eliminar " + item + " de la lista ?", "Eliminar Item", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                        imagenes.RemoveAt(inx);
                    txTotalFotos.Text = imagenes.Count.ToString();
                }
                else
                    MessageBox.Show(this.Owner, "Debe seleccionar el item que desea borrar. ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.Owner, ex.Message);
            }
        }
        private void BtLimpiarPantalla_Click(object sender, EventArgs e)
        {
            ParseSettings.ClearSetting();
            CargaPantalla();
        }
        private void CkLoopPhotoCycle_CheckedChanged(object sender, EventArgs e)
        {
            ParseSettings.LoopPhotoCycle = ckLoopPhotoCycle.Checked;
        }
        private void CkInitiateAudioEachCycle_CheckedChanged(object sender, EventArgs e)
        {
            ParseSettings.InitiateAudioEachCycle = ckInitiateAudioEachCycle.Checked;
        }

        private void BtRunPreset_Click(object sender, EventArgs e)
        {
            FrmShow preset = new();
            preset.CargaDatos(txCarpeta.Text);
            preset.ShowDialog();
            preset.Dispose();   
        }

        private void BtDepura_Click(object sender, EventArgs e)
        {
            FrmDepura depura = new();
            depura.CargaDatos(txCarpeta.Text);
            depura.ShowDialog();
            CargaPantalla();
        }
       
    }
}
