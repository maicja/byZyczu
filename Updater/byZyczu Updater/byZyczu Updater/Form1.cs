using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace byZyczu_Updater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        WebClient client = new WebClient();
        string exepath = $"{System.IO.Directory.GetCurrentDirectory()}\\zyczumc\\zyczumc.exe";
        string dir = $"{System.IO.Directory.GetCurrentDirectory()}\\zyczumc";
        private async void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            await Task.Delay(100);
            try
            {
                byte[] zyczu = client.DownloadData("https://github.com/mksmaicja/byZyczu/raw/master/Launcher/byZyczu/bin/Release/byZyczu.exe");
                File.WriteAllBytes(exepath, zyczu);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Launcher spróbuje uruchomić się z najnowszej pobranej wersji", "Błąd podczas aktualizacji!");
            }
            System.Diagnostics.ProcessStartInfo startinfo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = exepath,
                ErrorDialog = true,
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                WorkingDirectory = dir
            };
            Process.Start(startinfo);
            await Task.Delay(400);
            Application.Exit();
        }
    }
}
