using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;

namespace SchoolBackgroundChanger_2._0
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public string uName = Environment.UserName;
        public string user;
        public string copyPath;
        public int current_update = 7;
        Image img;

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (WebClient webClient = new WebClient())
                using (webClient.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void reloadExplorer()
        {
            Process process = new Process();
            Process[] processes = Process.GetProcesses();
            for (int i = 0; i < processes.Length; i++)
            {
                Process process2 = processes[i];
                if (process2.ProcessName == "explorer")
                {
                    process2.Kill();
                }
            }
            if (File.Exists(Application.StartupPath + "/scaled.jpg"))
            {
                File.Delete(Application.StartupPath + "/scaled.jpg");
            }
            text_path.Text = "";
        }

        Image Resize(Image image, int w, int h)
        {
            Bitmap bmp = new Bitmap(w, h);
            Graphics graphic = Graphics.FromImage(bmp);
            graphic.DrawImage(image, 0, 0, w, h);
            graphic.Dispose();

            return bmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (metroCheckBox1.Checked == true)
            {
                int w = Convert.ToInt32("3840"), h = Convert.ToInt32("2160");
                img = Resize(img, w, h);
                img.Save(Application.StartupPath + "/scaled.jpg", ImageFormat.Jpeg);
                scaledChangeBackground();
            }
            else
            {
                changeBackground();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "C:/Users/" + uName + "/Desktop";
            ofd.Filter = "All image files|*.png; *.jpg; *.jpeg; *.gif";
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                text_path.Text = ofd.FileName;
                img = Image.FromFile(ofd.FileName);
            }
        }

        private void scaledChangeBackground()
        {
            if (text_path.Text != "")
            {
                user = Application.StartupPath + "/scaled.jpg";
                copyPath = "C:/Users/" + uName + "/AppData/Roaming/Microsoft/Windows/Themes";
                if (File.Exists(copyPath + "/TranscodedWallpaper"))
                {
                    File.Delete(copyPath + "/TranscodedWallpaper");
                }
                if (File.Exists(copyPath + "/CachedFiles/CachedImage_1366_768_POS3.jpg"))
                {
                    File.Delete(copyPath + "/CachedFiles/CachedImage_1366_768_POS3.jpg");
                }
                File.Copy(user, copyPath + "/TranscodedWallpaper");
                File.Copy(user, copyPath + "/CachedFiles/CachedImage_1366_768_POS3.jpg");
                Console.WriteLine(File.GetAttributes(user));
                File.GetAttributes(user);
                reloadExplorer();
                button1.Enabled = false;
            }
        }

        private void changeBackground()
        {
            if (text_path.Text != "")
            {
                copyPath = "C:/Users/" + uName + "/AppData/Roaming/Microsoft/Windows/Themes";
                if (File.Exists(copyPath + "/TranscodedWallpaper"))
                {
                    File.Delete(copyPath + "/TranscodedWallpaper");
                }
                if (File.Exists(copyPath + "/CachedFiles/CachedImage_1366_768_POS3.jpg"))
                {
                    File.Delete(copyPath + "/CachedFiles/CachedImage_1366_768_POS3.jpg");
                }
                File.Copy(text_path.Text, copyPath + "/TranscodedWallpaper");
                File.Copy(text_path.Text, copyPath + "/CachedFiles/CachedImage_1366_768_POS3.jpg");
                Console.WriteLine(File.GetAttributes(text_path.Text));
                File.GetAttributes(text_path.Text);
                reloadExplorer();
                button1.Enabled = false;
            }
        }

        public List<string> getBannedUsers()
        {
            List<string> bannedUsers = new List<string>();
            if (CheckForInternetConnection())
            {
                WebClient client = new WebClient();
                using (var stream = client.OpenRead("https://proff001.github.io/SchoolBackgroundChanger/banned.txt"))
                using (var reader = new StreamReader(stream))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        bannedUsers.Add(line);
                    }
                }
            }

            return bannedUsers;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Changelog chlog = new Changelog();
            chlog.ShowDialog();
            chlog.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_updateStatus.Text = "No Wifi Connection";
            button3.Enabled = false;

            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            metroStyleManager1.Owner = this;

            for (int i = 0; i < getBannedUsers().Count; i++)
            {

                if (this.uName == getBannedUsers()[i])
                {
                    MessageBox.Show("You are banned from using this Software please contact me or someone i know who can help", "You Are Banned", MessageBoxButtons.OK);
                    bool messageLoop = Application.MessageLoop;
                    if (messageLoop)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        Environment.Exit(1);
                    }
                }
            }


            if (CheckForInternetConnection())
            {
                WebClient webClient = new WebClient();
                if (File.Exists(Directory.GetCurrentDirectory() + "/autoUpdateBC.exe"))
                {
                    File.Delete(Directory.GetCurrentDirectory() + "/autoUpdateBC.exe");
                }
                if (Convert.ToInt32(webClient.DownloadString("https://proff001.github.io/SchoolBackgroundChanger/index.html")) > current_update)
                {
                    button3.Enabled = true;
                    label_updateStatus.Text = "Update Status: Ready";

                    if (MessageBox.Show("There is an update ready to be installed do you want to update now", "Update ready", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        downloadUpdate();
                    }

                }
                else
                {
                    button3.Enabled = false;
                    label_updateStatus.Text = "Update Status: Not Ready";
                }
            }

            for (int i = 0; i < getDevAccountsUsers().Count; i++)
            {

                if (this.uName == getDevAccountsUsers()[i])
                {
                    if(uName == "thomasmel.hole")
                    {
                        lblWelcome.Text = "Welcome Owner Thomas";
                    }
                    else
                    {
                        lblWelcome.Text = "Welcome  " + uName;
                    }
                }
            }
        }
        
        public void downloadUpdate()
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFileAsync(new Uri("https://proff001.github.io/SchoolBackgroundChanger/downloads/autoUpdateBC.exe"), "autoUpdateBC.exe");
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadComplete);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            downloadUpdate();
        }

        private void DownloadComplete(object sender, AsyncCompletedEventArgs e)
        {
            Process.Start(Application.StartupPath + "/autoUpdateBC.exe");
            if (Application.MessageLoop)
            {
                Application.Exit();
            }
            else
            {
                Environment.Exit(1);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (text_path.Text == "")
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        public List<string> getDevAccountsUsers()
        {
            List<string> DevUsers = new List<string>();
            if (CheckForInternetConnection())
            {
                WebClient client = new WebClient();
                using (var stream = client.OpenRead("https://showcasekys.github.io/SchoolBackgroundChanger/Devs.txt"))
                using (var reader = new StreamReader(stream))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        DevUsers.Add(line);
                    }
                }
            }

            return DevUsers;
        }
    }
}
