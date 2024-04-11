using NAudio.Wave;
using System.Text;
using System.Windows.Forms;

namespace PhotoSlideMaker
{
    internal static class ParseSettings
    {
        static ParseSettings() 
        { 
        }

        internal static AudioFileReader? AudioFile;
        internal static bool InitiateAudioEachCycle = false;
        internal static bool LoopPhotoCycle = false; 
        
        internal static string ArchivoSetting = string.Empty;
        
        internal static readonly string endList = "./.";
        internal static string Audio = string.Empty;
        internal static string Author = string.Empty;
        internal static string Avatar = string.Empty;
        internal static string Description = string.Empty;
        internal static string Email = string.Empty;
        internal static string Fullscreen = string.Empty;
        internal static string MaxWinSize = string.Empty;
        internal static string PresetName = string.Empty;
        internal static string TimePerPic = string.Empty;
        internal static string Website = string.Empty;

        internal static readonly List<string> PhotoList = new();

        internal static void ClearSetting()
        {
            ArchivoSetting = string.Empty;

            Audio = string.Empty;
            Author = string.Empty;
            Avatar = string.Empty;
            Description = string.Empty;
            Email = string.Empty;
            Fullscreen = string.Empty;
            MaxWinSize = string.Empty;
            PresetName = string.Empty;
            TimePerPic = string.Empty;
            Website = string.Empty;
            PhotoList.Clear();
            PhotoList.TrimExcess();
        }

        internal static bool CargaSetting(string pArchivo)
        {
            ArchivoSetting = pArchivo;
            StringBuilder strDescripcion = new();
            StreamReader reader = new(ArchivoSetting);
            string currentLine = reader.ReadLine() ?? string.Empty;
            string lineType = string.Empty;    
            do
            {                
                switch (currentLine)
                {
                    case "[Preset_Name]":
                        lineType = "Preset_Name";
                        break;
                    case "[Author]":
                        lineType = "Author";
                        break;
                    case "[Website]":
                        lineType = "Website";
                        break;
                    case "[MaxWinSize]":
                        lineType = "MaxWinSize";
                        break;
                    case "[Email]":
                        lineType = "Email";
                        break;
                    case "[Avatar]":
                        lineType = "Avatar";
                        break;
                    case "[TimePerPic]":
                        lineType = "TimePerPic";
                        break;
                    case "[Fullscreen]":
                        lineType = "Fullscreen";
                        break;
                    case "[audio]":
                        lineType = "audio";
                        break;
                    case "[Description]":
                        lineType = "Description";
                        break;
                    case "[PhotoList]":
                        lineType = "PhotoList";
                        break;
                    default:
                        break;
                }   
                currentLine = reader.ReadLine() ?? string.Empty;
                switch (lineType)
                {
                    case "Preset_Name":
                        PresetName = currentLine;
                        lineType = string.Empty;
                        break;
                    case "Author":
                        Author = currentLine;
                        lineType = string.Empty;
                        break;
                    case "Website":
                        Website = currentLine;
                        lineType = string.Empty;
                        break;
                    case "MaxWinSize":
                        MaxWinSize = currentLine;
                        lineType = string.Empty;
                        break;
                    case "Email":
                        Email = currentLine;
                        lineType = string.Empty;
                        break;
                    case "Avatar":
                        Avatar = currentLine;
                        lineType = string.Empty;
                        break;
                    case "TimePerPic":
                        TimePerPic = currentLine;
                        lineType = string.Empty;
                        break;
                    case "Fullscreen":
                        Fullscreen = currentLine;
                        lineType = string.Empty;
                        break;
                    case "audio":
                        Audio = currentLine;
                        if (!string.IsNullOrEmpty(Audio))
                        lineType = string.Empty;
                        break;
                    case "Description":
                        if (currentLine == endList)
                        {
                            Description = strDescripcion.ToString();
                            lineType = string.Empty;
                        }
                        else
                            strDescripcion.AppendLine(currentLine);
                        break;
                    case "PhotoList":
                        if (currentLine == endList)
                            lineType = string.Empty;
                        else
                        {
                            if (!string.IsNullOrEmpty(currentLine))
                                PhotoList.Add(currentLine);
                        }
                        break;
                    default:
                        break;
                }
            } while (!reader.EndOfStream);
            reader.Close();
            reader.Dispose();
            return true;
        }

        internal static bool GrabaSettings(string pArchivo)
        {
            string fileName = pArchivo;
            try
            {
                using StreamWriter writer = new(fileName);
                writer.WriteLine("[Preset_Name]");
                writer.WriteLine(PresetName);
                writer.WriteLine("[Author]");
                writer.WriteLine(Author);
                writer.WriteLine("[Website]");
                writer.WriteLine(Website);
                writer.WriteLine("[MaxWinSize]");
                writer.WriteLine(MaxWinSize);
                writer.WriteLine("[Email]");
                writer.WriteLine(Email);
                writer.WriteLine("[Avatar]");
                writer.WriteLine(Avatar);
                writer.WriteLine("[TimePerPic]");
                writer.WriteLine(TimePerPic);
                writer.WriteLine("[Fullscreen]");
                writer.WriteLine(Fullscreen);
                writer.WriteLine("[audio]");
                writer.WriteLine(Audio);
                writer.WriteLine("[Description]");
                foreach (var item in Description.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None))
                {
                    writer.WriteLine(item);
                }
                writer.WriteLine(endList);
                writer.WriteLine("[PhotoList]");
                foreach (var item in PhotoList)
                {
                    writer.WriteLine(item);
                }
                writer.WriteLine(endList);
                writer.Flush();
                writer.Close();
                writer.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}