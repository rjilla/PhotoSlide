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
        bool exitPantalla = false;

        public void CargaDatos(string carpetaEjecuta)
        {
            carpeta = carpetaEjecuta;
            if (!string.IsNullOrWhiteSpace(ParseSettings.Audio))
                audioFile = new AudioFileReader(carpetaEjecuta + "\\" + ParseSettings.Audio);
        }
        public async void PlayPreset()
        {
            if (!string.IsNullOrWhiteSpace(ParseSettings.Audio))
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
                    if (exitPantalla)
                        break;
                    string img = carpeta + "\\" + item;
                    pbCavanas.Image = new Bitmap(img);
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
                if ((!ParseSettings.LoopPhotoCycle) | (exitPantalla))
                    break;
                if ((audioFile != null) && (ParseSettings.InitiateAudioEachCycle))
                    audioFile.Position = 0;
            }
            this.Close();
        }

        private void FrmShow_Shown(object sender, EventArgs e)
        {
            PlayPreset();
        }
        private void FrmShow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (outputDevice != null)
            {
                outputDevice.Stop();
                outputDevice.Dispose();
                outputDevice = null;
            }
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
            exitPantalla = true;
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
