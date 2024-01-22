namespace PhotoSlide
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        bool exitByRunPreset = false;
        private void FrmInicio_Load(object sender, EventArgs e)
        {
            txSVPFile.Text = ParseSettings.ArchivoSetting;
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
                pbAvatar.Image = new Bitmap(ParseSettings.Avatar);
            lbxPhotoList.DataSource = ParseSettings.PhotoList;
        }
        private void BtRunPreset_Click(object sender, EventArgs e)
        {
            FrmShow preset = new();
            preset.Show();
            preset.BringToFront();
            exitByRunPreset = true;
            this.Close();
        }
        private void CkLoopPhotoCycle_CheckedChanged(object sender, EventArgs e)
        {
            ParseSettings.LoopPhotoCycle = ckLoopPhotoCycle.Checked;
        }
        private void CkInitiateAudioEachCycle_CheckedChanged(object sender, EventArgs e)
        {
            ParseSettings.InitiateAudioEachCycle = ckInitiateAudioEachCycle.Checked;
        }

        private void FrmInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!exitByRunPreset)
                Application.Exit();
        }
    }
}
