using NAudio.Wave;

namespace PhotoSlide
{
    public partial class FrmShow : Form
    {
        public FrmShow()
        {
            InitializeComponent();
        }

        WaveOutEvent? outputDevice = new();
        readonly AudioFileReader? audioFile = ParseSettings.AudioFile;

        private async void FrmShow_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ParseSettings.Audio))
            {
                if (ParseSettings.SonidoOff)
                    outputDevice = null;
                if (outputDevice != null)
                {
                    outputDevice.Init(audioFile);
                    outputDevice.Volume = 0.20f;
                    outputDevice.Play();
                }
            }
            btStopAudio.BackColor = Color.LightGreen;
            int tiempo = Convert.ToInt32(ParseSettings.TimePerPic);
            while (true)
            {
                foreach (var item in ParseSettings.PhotoList)
                {
                    pbCavanas.Image = new Bitmap(item);
                    await Task.Delay(tiempo);
                    if ((outputDevice != null) && (outputDevice.PlaybackState == PlaybackState.Stopped))
                    {
                        if (audioFile != null)
                        {
                            audioFile.Position = 0;
                            outputDevice.Play();
                        }
                    }
                }
                if (!ParseSettings.LoopPhotoCycle)
                    Application.Exit();
                if ((audioFile != null) && (ParseSettings.InitiateAudioEachCycle))
                    audioFile.Position = 0;
            }
        }
        private void FrmShow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (outputDevice != null)
            {
                outputDevice.Stop();
                outputDevice.Dispose();
                outputDevice = null;
            }
            Application.Exit();
        }
        private void FrmShow_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                Application.Exit();
        }

        private void OnButtonStopClick(object sender, EventArgs args)
        {
            if (outputDevice?.PlaybackState == PlaybackState.Paused)
            {
                outputDevice?.Play();
                btStopAudio.BackColor = Color.LightGreen;
                tbVolumen.Visible = true;
            }
            else
            {
                outputDevice?.Pause();
                btStopAudio.BackColor = Color.Salmon;
                tbVolumen.Visible = false;
            }
        }
        private void ExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MaxClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        private void MinClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TbVolumen_Scroll(object sender, EventArgs e)
        {
            if (outputDevice != null)
                outputDevice.Volume = tbVolumen.Value / 100f;
        }
        bool verBotones = true;
        private void BtApagaBotones_Click(object sender, EventArgs e)
        {
            if (verBotones)
                verBotones = false;
            else
                verBotones = true;
            btExit.Visible = verBotones;
            btMax.Visible = verBotones;
            btMin.Visible = verBotones;
            btStopAudio.Visible = verBotones;
            tbVolumen.Visible = verBotones;
        }
    }
}
