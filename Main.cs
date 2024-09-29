using System.Net;
using System.Diagnostics;
using System.IO;

namespace MonkeMenuManager
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.InitialDirectory = "C:\\";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dialog.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dir = textBox1.Text;
            string url = "https://github.com/breathemonoxide/MonkeMenuManagerResources/releases/download/mods/ii.s.stupid.menu.dll";
            string directoryPath = dir;
            string fileName = "ii's stupid menu.dll";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);

                }
                catch (Exception ex)
                {


                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string dir = textBox1.Text;
            string url = "https://github.com/breathemonoxide/MonkeMenuManagerResources/releases/download/mods/Shiba.Genesis.dll";
            string directoryPath = dir;
            string fileName = "Shiba Genesis.dll";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);

                }
                catch (Exception ex)
                {


                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string dir = textBox1.Text;
            string url = "https://github.com/breathemonoxide/MonkeMenuManagerResources/releases/download/mods/displyy.dll";
            string directoryPath = dir;
            string fileName = "displyy.dll";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);

                }
                catch (Exception ex)
                {

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string dir = textBox1.Text;
            string url = "https://github.com/breathemonoxide/MonkeMenuManagerResources/releases/download/mods/rexon.paid.dll";
            string directoryPath = dir;
            string fileName = "rexon paid.dll";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);

                }
                catch (Exception ex)
                {

                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string dir = textBox1.Text;
            string url = "https://github.com/breathemonoxide/MonkeMenuManagerResources/releases/download/mods/mooclient.dll";
            string directoryPath = dir;
            string fileName = "mooclient.dll";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);

                }
                catch (Exception ex)
                {
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string dir = textBox1.Text;
            string url = "https://github.com/breathemonoxide/MonkeMenuManagerResources/releases/download/mods/heal.dll";
            string directoryPath = dir;
            string fileName = "heal.dll";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);

                }
                catch (Exception ex)
                {
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string dir = textBox1.Text;
            string url = "https://github.com/breathemonoxide/MonkeMenuManagerResources/releases/download/mods/space.dll";
            string directoryPath = dir;
            string fileName = "space.dll";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);

                }
                catch (Exception ex)
                {
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string dir = textBox1.Text;
            string url = "https://github.com/breathemonoxide/MonkeMenuManagerResources/releases/download/mods/PlayerTrakkar.dll";
            string directoryPath = dir;
            string fileName = "playertrakkar.dll";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);

                }
                catch (Exception ex)
                {
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string dir = textBox1.Text;
            string url = "https://github.com/breathemonoxide/MonkeMenuManagerResources/releases/download/mods/Utilla.dll";
            string directoryPath = dir;
            string fileName = "modded utilla.dll";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);

                }
                catch (Exception ex)
                {
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string dir = textBox1.Text;
            string url = "https://github.com/breathemonoxide/MonkeMenuManagerResources/releases/download/mods/walksimpubs.dll";
            string directoryPath = dir;
            string fileName = "walksimpubs.dll";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);

                }
                catch (Exception ex)
                {
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string dir = textBox1.Text;
            string url = "https://github.com/breathemonoxide/MonkeMenuManagerResources/releases/download/mods/Cosmetix.dll";
            string directoryPath = dir;
            string fileName = "cosmetix.dll";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);

                }
                catch (Exception ex)
                {
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string dir = textBox1.Text;
            string url = "https://github.com/breathemonoxide/MonkeMenuManagerResources/releases/download/mods/nametags.dll";
            string directoryPath = dir;
            string fileName = "nametags.dll";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);

                }
                catch (Exception ex)
                {
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string dir = textBox1.Text;
            string url = "https://github.com/breathemonoxide/MonkeMenuManagerResources/releases/download/mods/rigspam.dll";
            string directoryPath = dir;
            string fileName = "rigspam.dll";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);

                }
                catch (Exception ex)
                {
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string dir = textBox1.Text;
            string url = "https://github.com/breathemonoxide/MonkeMenuManagerResources/releases/download/mods/LobbyCrash.dll";
            string directoryPath = dir;
            string fileName = "LobbyCrash.dll";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);

                }
                catch (Exception ex)
                {
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string dir = textBox1.Text;

            string url = "https://github.com/breathemonoxide/MonkeMenuManagerResources/releases/download/mods/BannedServersUtilla.dll";
            string directoryPath = dir;
            string fileName = "BannedServersUtilla.dll";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);

                }
                catch (Exception ex)
                {
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo

            {

                FileName = "https://www.youtube.com/watch?v=dQw4w9WgXcQ",

                UseShellExecute = true

            };

            Process.Start(psi);
        }

        private void Main_Load(object sender, EventArgs e)
        {
          
        }
    }
}

            
    

