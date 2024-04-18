namespace PhotoSlideMaker
{
    public partial class FrmDepura : Form
    {
        public FrmDepura()
        {
            InitializeComponent();
        }

        string? carpeta;

        public void CargaDatos(string carpetaEjecuta)
        {
            carpeta = carpetaEjecuta;
            string[] fotos = Directory.GetFiles(carpetaEjecuta, "*.*");
            string[] noList = new string[fotos.Length];
            bool incluido;
            int i = 0;

            foreach (string foto in fotos)
            {
                incluido = false;
                if (Path.GetFileName(foto) == ParseSettings.Avatar)
                    incluido = true;
                if (Path.GetExtension(foto).ToLower() == ".svp")
                    incluido = true;
                if (Path.GetExtension(foto).ToLower() == ".mp3")
                    incluido = true;
                foreach (string item in ParseSettings.PhotoList)
                {
                    if (item == Path.GetFileName(foto))
                        incluido = true;
                }
                if (!incluido)
                {
                    noList[i] = foto;
                    incluido = false;
                    i++;
                }
            }
            lbxAdicionales.DataSource = noList;
        }

        private void LbxAdicionales_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbxAdicionales.SelectedIndex >= 0)
            {
                string? item = lbxAdicionales.SelectedItem.ToString();
                try
                {
                    if (item != null)
                        pbImagen.Image = new Bitmap(item);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this.Owner, ex.Message);
                }
            }
        }

        private void BtAgregarImagen_Click(object sender, EventArgs e)
        {
            if (lbxAdicionales.SelectedIndex >= 0)
            {
                string? item = lbxAdicionales.SelectedItem.ToString();
                try
                {
                    if (item != null)
                    {
                        ParseSettings.PhotoList.Add(Path.GetFileName(item));
                        if (carpeta != null)
                            CargaDatos(carpeta);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this.Owner, ex.Message);
                }
            }
        }

        private void BtEliminarImagen_Click(object sender, EventArgs e)
        {

        }
    }
}
