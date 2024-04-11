using Microsoft.VisualBasic.Devices;
using NAudio.Wave;

namespace PhotoSlideMaker
{
    public partial class FrmShow : Form
    {
        public FrmShow()
        {
            InitializeComponent();
        }
        WaveOutEvent? outputDevice = new();
        AudioFileReader? audioFile;
        string? carpeta;

        public void CargaDatos(string carpetaEjecuta)
        {
            carpeta = carpetaEjecuta;
            audioFile = new AudioFileReader(carpetaEjecuta + "\\" + ParseSettings.Audio);
        }    
        

        private async void FrmShow_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ParseSettings.Audio))
            {
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
                    string img = carpeta + "\\" + item;
                    pbCavanas.Image = new Bitmap(img);
                    await Task.Delay(tiempo); 
                    if (outputDevice?.PlaybackState == PlaybackState.Stopped)
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
    }
}
