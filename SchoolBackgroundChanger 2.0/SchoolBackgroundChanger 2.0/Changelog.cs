using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolBackgroundChanger_2._0
{
    public partial class Changelog : MetroFramework.Forms.MetroForm
    {
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

        public Changelog()
        {
            InitializeComponent();
        }

        private void getTextFromServer()
        {
            if (CheckForInternetConnection())
            {
                txtChangelog.Text = "";
                WebClient webClient = new WebClient();
                Stream stream = webClient.OpenRead("https://proff001.github.io/SchoolBackgroundChanger/Changelog.txt");
                int counter = 0;
                string line;
                StreamReader file = new StreamReader(stream);
                while ((line = file.ReadLine()) != null)
                {
                    txtChangelog.Text += line + Environment.NewLine;
                    counter++;
                }
                file.Close();
                txtChangelog.ReadOnly = true;
                txtChangelog.GotFocus += new EventHandler(this.RTBGotFocus);
            }
        }

        void RTBGotFocus(object sender, EventArgs e)
        {
            SendKeys.Send("{tab}");
        }

        private void txtChangelog_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Changelog_Load(object sender, EventArgs e)
        {
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            metroStyleManager1.Owner = this;

            getTextFromServer();
        }
    }
}
