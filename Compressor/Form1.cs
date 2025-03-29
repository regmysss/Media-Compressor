using System.Diagnostics;

namespace Compressor
{
    public partial class Form1 : Form
    {
        private string[] pathInput = [""];
        private string pathOutput = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos));
        private Dictionary<string, string> codecV = new Dictionary<string, string>()
        {
            {"Default","h264_nvenc"},
            {"H.264 (CUDA)", "h264_nvenc" },
            {"H.264 (CPU)", "h264" },
            {"H.265 (CPU)", "libx265" },
            {"H.265 (CUDA)", "hevc_nvenc" },
            {"VP9", "libvpx-vp9" },
            {"AV1", "libaom-av1" },
            {"MPEG-4", "mpeg4" },
            {"MJPEG", "libx265" }
        };

        private Dictionary<string, string> codecA = new Dictionary<string, string>()
        {
            {"Default","libmp3lame"},
            {"AAC", "aac" },
            {"MP3", "libmp3lame" },
            {"Opus", "libopus" },
            {"WAV", "pcm_s16le" },
            {"Dolby AC-3", "ac3" },
            {"DTS", "dca" }
        };

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = pathOutput;

            nameCodecVideo.Items.AddRange(codecV.Keys.ToArray());
            nameCodecAudio.Items.AddRange(codecA.Keys.ToArray());

            nameCodecVideo.SelectedIndex = 0;
            nameCodecAudio.SelectedIndex = 0;
            bitrateVideo.SelectedIndex = 0;
            bitrateAudio.SelectedIndex = 0;
        }

        private Task StartFfmpeg(string arguments)
        {
            Process process = new Process();
            process.StartInfo.FileName = "ffmpeg";
            process.StartInfo.Arguments = arguments;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            process.EnableRaisingEvents = true;
            process.Exited += (sender, e) =>
            {
                loadingProcess.Invoke(delegate
                {
                    timer1.Enabled = false;
                    loadingProcess.Text = "Compression of your media file is successful!";
                });

                process.Dispose();
            };

            process.Start();

            return Task.CompletedTask;
        }

        private string ParseArguments()
        {
            if (pathInput[0] == "")
            {
                MessageBox.Show("Choose the path of your media!",
                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }

            string arguments = $"-i \"{pathInput[0]}\" -c:v {codecV[nameCodecVideo.Text]} -c:a {codecA[nameCodecAudio.Text]}";

            if (compressionValue.Value != 0)
            {
                arguments += $" -crf {compressionValue.Value}";
            }

            if (bitrateVideo.Text != "Default")
            {
                arguments += $" -b:v {bitrateVideo.Text}M";
            }

            if (bitrateAudio.Text != "Default")
            {
                arguments += $" -b:a {bitrateAudio.Text}k";
            }

            arguments += $" \"{CheckCloneFile()}\"";

            return arguments;
        }

        private string CheckCloneFile()
        {
            string baseFileName = $"{nameFile.Text}.{formatFile.Text}";
            string filePath = Path.Combine(pathOutput, baseFileName);

            if (!File.Exists(filePath))
            {
                return filePath;
            }

            int counter = 1;
            string newFileName;
            do
            {
                newFileName = $"{nameFile.Text} ({counter}).{formatFile.Text}";
                filePath = Path.Combine(pathOutput, newFileName);
                counter++;
            } while (File.Exists(filePath));

            return filePath;
        }

        private void InputPath_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathInput[0] = openFileDialog1.FileName;
                InputPath.Text = pathInput[0];
            }
        }

        private void InputPath_DragDrop(object sender, DragEventArgs e)
        {
            pathInput = (string[])e.Data.GetData(DataFormats.FileDrop);
            InputPath.Text = pathInput[0];
        }

        private void InputPath_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string arguments = ParseArguments();

            if (arguments != "")
            {
                timer1.Enabled = true;
                await StartFfmpeg(arguments);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                pathOutput = folderBrowserDialog1.SelectedPath;
                textBox2.Text = pathOutput;
            }
        }

        private int loadTick = 0;
        private string loadMess = "Wait! Your media file is processing.";
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (loadTick)
            {
                case 0:
                    {
                        loadingProcess.Text = loadMess + ".";
                        loadTick++;
                        break;
                    }

                case 1:
                    {
                        loadingProcess.Text = loadMess + "..";
                        loadTick++;
                        break;
                    }

                case 2:
                    {
                        loadingProcess.Text = loadMess;
                        loadTick = 0;
                        break;
                    }
            }
        }
    }
}
