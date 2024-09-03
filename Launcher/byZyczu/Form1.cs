using byZyczu.Properties;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace byZyczu
{
    public partial class Form1 : Form
    {
        //public static string url = "109.231.27.76";
        public static string url = "mksteam.ovh";
        public static string launcherdir = System.IO.Directory.GetCurrentDirectory();
        public static string configsdir = $"{System.IO.Directory.GetCurrentDirectory()}\\configs";

        public Form1()
        {
            InitializeComponent();


            if (!Directory.Exists(configsdir))
            {
                Directory.CreateDirectory(configsdir);
            }
            panel1.BackColor = Color.FromArgb(180, Color.White);
            panelconsole.BackColor = Color.FromArgb(160, Color.White);
            panelsettings.BackColor = Color.FromArgb(150, Color.White);
            panelaccounts.BackColor = Color.FromArgb(150, Color.White);
            buttonownmods.BackColor = Color.FromArgb(5, Color.White);
            buttonlaunch.BackColor = Color.FromArgb(5, Color.White);
            buttonsettings.BackColor = Color.FromArgb(5, Color.White);
            panelsettings.Visible = false;
            panelaccounts.Location = new Point(22, 66);
            panelsettings.Location = new Point(22, 66);
            paneldownload.Visible = false;
            paneldownload.Location = new Point(22, 66);
            paneldownload.BackColor = Color.FromArgb(150, Color.White);
            panelmodsmain.Visible = false;
            panelaccounts.Visible = false;
            panelmodsmain.Location = new Point(22, 66);
            panelmodsmain.BackColor = Color.FromArgb(150, Color.White);
            panelmodpacks.BackColor = Color.FromArgb(180, Color.White);
            panelmanageversions.BackColor = Color.FromArgb(180, Color.White);
            panelmanageversions.Visible = false;
            panelcreatenewmodpack.BackColor = Color.FromArgb(180, Color.White);
            panelcreatenewmodpack.Location = new Point(22, 66);
            panelcreatenewmodpack.Visible = false;
            comboBoxRAM.Items.Add("1024M");
            comboBoxRAM.Items.Add("2048M");
            comboBoxRAM.Items.Add("3072M");
            comboBoxRAM.Items.Add("4096M");
            comboBoxRAM.Items.Add("5120M");
            comboBoxRAM.Items.Add("6144M");
            comboBoxRAM.Items.Add("7164M");
            comboBoxRAM.Items.Add("8192M");
            comboBoxRAM.Items.Add("9216M");
            comboBoxRAM.Items.Add("10240M");
            comboBoxRAM.Items.Add("11264M");
            comboBoxRAM.Items.Add("12288M");
            comboBoxmodpackcreate.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxmodpacks.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRAM.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxmanageversions.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        public static string depsurl = "";
        WebClient webClientmks = new WebClient();
        public static string versionname;
        public static string versionzip;
        public static string versionargsp1;
        public static string versionargsp2;
        public static string versionline;
        public static string javapath;
        Random rand = new Random();
        bool downloaded = false;
        public static bool premiumlaunchwait = true;
        public static string version = "1.8.1";

        public void DownloadFile(string urlAddress, string location)
        {
            progressBar1.Visible = true;
            using (webClient = new WebClient())
            {
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

                Uri URL = urlAddress.StartsWith("http://", StringComparison.OrdinalIgnoreCase) ? new Uri(urlAddress) : new Uri("http://" + urlAddress);


                sw.Start();

                try
                {
                    webClient.DownloadFileAsync(URL, location);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        WebClient webClient;
        Stopwatch sw = new Stopwatch();
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            downloadlabel.Text = $"{(e.BytesReceived / 1024d / sw.Elapsed.TotalSeconds).ToString("0.0")} kb/s\r\n{(e.BytesReceived / 1024d / 1024d).ToString("0.0")} MB / {(e.TotalBytesToReceive / 1024d / 1024d).ToString("0.0")} MB";
            progressBar1.Value = e.ProgressPercentage;
        }

        public static bool discordaviable = false;
        public static bool newtowsonaviable = false;
        private async void Completed(object sender, AsyncCompletedEventArgs e)
        {

            sw.Reset();
            if (!discordaviable)
            {
                downloadlabel.Text = "";
                progressBar1.Value = 0;
                progressBar1.Visible = false;
                discordaviable = true;
            }
            else if (!newtowsonaviable)
            {
                downloadlabel.Text = "";
                progressBar1.Value = 0;
                progressBar1.Visible = false;
                newtowsonaviable = true;
            }
            else
            {
                if (e.Cancelled == true)
                {
                    MessageBox.Show("Pobieranie zostało anulowane");
                    progressBar1.Visible = false;
                }
                else
                {
                    downloadlabel.Text = "Wypakowywanie...";
                    progressBar1.Value = 0;
                    progressBar1.Visible = false;



                    Thread.Sleep(100);
                    if (File.Exists(launcherdir + "\\temp.zip"))
                    {
                        try
                        {
                            await Task.Run(() => ZipFile.ExtractToDirectory(launcherdir + "\\temp.zip", launcherdir));
                            await Task.Delay(100);
                        }
                        catch (Exception) { }
                        File.Delete(launcherdir + "\\temp.zip");
                        downloadlabel.Text = "";
                        downloaded = true;

                    }
                    else if (File.Exists(launcherdir + "\\tempjava.zip"))
                    {
                        await Task.Run(() => ZipFile.ExtractToDirectory(launcherdir + "\\tempjava.zip", launcherdir));
                        await Task.Delay(100);
                        File.Delete(launcherdir + "\\tempjava.zip");
                        downloadlabel.Text = "";
                        javadwnld = false;
                    }
                }
            }
        }
        static void OutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            Console.WriteLine(outLine.Data);
        }
        public static bool javadwnld = false;
        public static bool deatach = false;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttoncancessett_Click(object sender, EventArgs e)
        {
            panelsettings.Visible = false;
        }

        private void buttonsettings_Click(object sender, EventArgs e)
        {
            panelsettings.Visible = true;
        }

        private void buttonsavechanges_Click(object sender, EventArgs e)
        {
            string noverify = "UNSET";
            if (checkBoxnoverify.Checked)
            {
                noverify = "true";
            }
            else
            {
                noverify = "false";
            }
            if (!File.Exists(configsdir + "\\settings.mks"))
            {
                using (FileStream fs = File.Create(configsdir + "\\settings.mks"))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("RAM;" + comboBoxRAM.Text + "\r\nnoverify;" + noverify);
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }
            }
            else
            {
                File.WriteAllText(configsdir + "\\settings.mks", "RAM;" + comboBoxRAM.Text + "\r\nnoverify;" + noverify);
            }
            panelsettings.Visible = false;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            textBoxnick.Text = "ODŚWIEŻANIE KONT, CZEKAJ!";
            HttpClient clienthttp = new HttpClient();
            if (!Directory.Exists(launcherdir + "\\accounts"))
            {
                Directory.CreateDirectory(launcherdir + "\\accounts");
            }
            if (!File.Exists(launcherdir + "\\accounts\\accsprem.mks"))
            {
                using (FileStream fs = File.Create(launcherdir + "\\accounts\\accsprem.mks"))
                {
                }
            }
            if (!File.Exists(launcherdir + "\\accounts\\accsoff.mks"))
            {
                using (FileStream fs = File.Create(launcherdir + "\\accounts\\accsoff.mks"))
                {
                }
            }
            if (!File.Exists(launcherdir + "\\accounts\\selectedacc.mks"))
            {
                using (FileStream fs = File.Create(launcherdir + "\\accounts\\selectedacc.mks"))
                {
                }
            }
            try
            {
                clienthttp.Timeout = TimeSpan.FromSeconds(4);
                await clienthttp.GetAsync("http://" + url + "/index.html");
            }
            catch (Exception ex)
            {
                url = "dev.mksteam.ovh";
                try
                {
                    await clienthttp.GetAsync("http://" + url + "/index.html");
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.Message + "\r\nLauncher spróbuje uruchomić się w trybie offline", "BŁĄD POŁĄCZENIA");
                    url = "offline";
                }
            }
            try
            {
                depsurl = "http://" + url + "/minecraft/deps/";
                await Task.Delay(500);
                if (!File.Exists(launcherdir + "\\usermodpacks.mks"))
                {
                    using (FileStream fs = File.Create(launcherdir + "\\usermodpacks.mks"))
                    {
                        byte[] info = new UTF8Encoding(true).GetBytes(" ");
                        fs.Write(info, 0, info.Length);
                    }
                }
                label1.Text = version + " C# version by maicja";


                comboBox1.Items.Clear();
                if (url != "offline")
                {
                    webClientmks.DownloadFile(depsurl + "relases.txt", launcherdir + "\\relases.list");
                }
                foreach (var line in File.ReadLines(launcherdir + "\\relases.list"))
                {
                    if (url == "offline")
                    {
                        if (File.Exists(launcherdir + "\\" + line.Split(';')[2]))
                        {
                            string name = line.Split(';')[0];
                            comboBox1.Items.Add(name);
                        }
                    }
                    else
                    {
                        string name = line.Split(';')[0];
                        comboBox1.Items.Add(name);
                    }

                }

                foreach (var line in File.ReadLines(launcherdir + "\\usermodpacks.mks"))
                {
                    if (line.Contains("-"))
                    {
                        if (line.Contains(';'))
                        {
                            if (url == "offline")
                            {
                                if (File.Exists(launcherdir + "\\" + line.Split(';')[2]))
                                {
                                    string modpackname = line.Split(';')[0];
                                    comboBox1.Items.Add(modpackname);
                                }
                            }
                            else
                            {
                                string modpackname = line.Split(';')[0];
                                comboBox1.Items.Add(modpackname);
                            }

                        }
                    }
                }


                if (!File.Exists(".\\DiscordRPC.dll"))
                {
                    DownloadFile("http://" + url + "/minecraft/DiscordRPC.dll", ".\\DiscordRPC.dll");
                    await Task.Delay(500);
                }
                else
                {
                    discordaviable = true;
                }
                await Task.Delay(10);
                while (!discordaviable)
                {
                    await Task.Delay(100);
                }
                await Task.Delay(10);
                if (!File.Exists(".\\Newtonsoft.Json.dll"))
                {
                    DownloadFile("http://" + url + "/minecraft/Newtonsoft.Json.dll", ".\\Newtonsoft.Json.dll");
                    await Task.Delay(500);
                }
                else
                {
                    newtowsonaviable = true;
                }
                await Task.Delay(10);
                while (!newtowsonaviable)
                {
                    await Task.Delay(100);
                }
                await Task.Delay(10);
                /*
                
                discordaviable = true;
                newtowsonaviable = true;
                */
                Modules.DiscordPresence.initializediscord("W Launcherze");
                if (File.Exists(configsdir + "\\settings.mks"))
                {
                    string ram = "UNSET0";
                    bool noverify = false;
                    foreach (string s in File.ReadAllLines(configsdir + "\\settings.mks"))
                    {
                        if (s.Contains("RAM"))
                        {
                            string state = s.Split(';')[1];
                            ram = state;
                        }
                        else if (s.Contains("noverify"))
                        {
                            string state = s.Split(';')[1];
                            if (state == "true")
                            {
                                noverify = true;
                            }
                            else
                            {
                                noverify = false;
                            }
                        }
                    }
                    comboBoxRAM.SelectedItem = ram;
                    checkBoxnoverify.Checked = noverify;
                }
                else
                {
                    comboBoxRAM.SelectedItem = "2048M";
                }
                comboBoxloginoffline.Items.Clear();
                foreach (var line in File.ReadAllLines(launcherdir + "\\accounts\\accsoff.mks"))
                {
                    if (line.Contains(">"))
                    {
                        comboBoxloginoffline.Items.Add(line.Split('>')[0]);

                    }
                }

                //start odswiezania listy kont
                comboBoxpremiumaccounts.Items.Clear();
                string selecteduuid = "cracked";
                if (File.Exists(launcherdir + "\\accounts\\selectedacc.mks"))
                {
                    string data = File.ReadAllText(launcherdir + "\\accounts\\selectedacc.mks");
                    if (data.Contains(">"))
                    {
                        if (data.Contains(">cracked"))
                        {
                            mcusername = data.Split('>')[0];
                            comboBoxloginoffline.SelectedItem = mcusername;
                            mcuuid = "cracked";
                            mctoken = "cracked";

                        }
                        else
                        {
                            selecteduuid = data.Split('>')[1];
                        }
                    }
                    else
                    {
                        textBoxnick.Text = "";
                    }
                }
                else
                {
                    textBoxnick.Text = "";
                }
                bool isfirst = true;
                string towrite = "\r\n";
                foreach (var line in File.ReadAllLines(launcherdir + "\\accounts\\accsprem.mks"))
                {
                    try
                    {


                        if (line.Contains(">"))
                        {
                            textBoxnick.Text = "ODŚWIEŻANIE: " + line.Split('>')[0];
                            if (!isfirst)
                            {
                                await Task.Delay(5000);
                            }
                            else
                            {
                                await Task.Delay(500);
                            }
                            string accdata = RefreshAccountData(line.Split('>')[2]);
                            comboBoxpremiumaccounts.Items.Add(accdata.Split('>')[0]);
                            towrite = towrite + accdata.Split('<')[0] + "\r\n";
                            string formatedsel = accdata.Split('>')[0] + ">" + accdata.Split('>')[1];
                            if (accdata.Split('>')[1].Contains(selecteduuid))
                            {
                                File.WriteAllText(launcherdir + "\\accounts\\selectedacc.mks", formatedsel);
                                mcusername = accdata.Split('>')[0];
                                comboBoxpremiumaccounts.SelectedItem = mcusername;
                                mcuuid = selecteduuid;
                                mctoken = accdata.Split('<')[1];
                            }
                            isfirst = false;
                        }
                    }
                    catch (Exception ew)
                    {
                        MessageBox.Show("Błąd przy odświeżaniu konta " + line.Split('>')[0] + "\r\n" + ew.Message, "BŁĄD");
                    }
                }
                textBoxnick.Text = mcusername;
                await Task.Delay(10);
                File.WriteAllText(launcherdir + "\\accounts\\accsprem.mks", towrite);
                //koniec odswiezania


                if (File.Exists(configsdir + "\\lastversion.mks"))
                {
                    try
                    {
                        string takk = File.ReadAllText(configsdir + "\\lastversion.mks");
                        comboBox1.SelectedItem = takk;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Failed to load last used version");
                    }
                }
                while (true)
                {
                    if (mclaunched)
                    {
                        if (stream2 == " ")
                        {

                        }
                        else
                        {
                            if (richTextBoxconsole.Text.Length > 2147480647)
                            {
                                richTextBoxconsole.Text = "LOGI GRY:";
                            }
                            panelconsole.Visible = true;
                            richTextBoxconsole.Text = richTextBoxconsole.Text + "\r\n" + stream2;


                            stream2 = " ";
                            richTextBoxconsole.SelectionStart = richTextBoxconsole.TextLength;
                            richTextBoxconsole.ScrollToCaret();
                        }

                    }
                    else
                    {
                        panelconsole.Visible = false;
                        stream2 = "LOGI GRY:";
                        richTextBoxconsole.Text = "";
                    }
                    await Task.Delay(1000);
                }
            }
            catch (Exception ex)
            {
                if (url == "offline")
                {
                    MessageBox.Show(ex.Message + "\r\nLauncher nie będzie działać, ponieważ nie ma pobranych wymaganych bibliotek! Aby je pobrać włącz launcher z dostępem do internetu", "BŁĄD OFFLINE!");
                }
            }
        }
        public static PrivateFontCollection fr = new PrivateFontCollection();
        public static bool mclaunched = false;
        private async void buttonlaunch_Click(object sender, EventArgs e)
        {
            try
            {
                bool cancontinue = true;
                string username = textBoxnick.Text;

                if (username.Length > 16)
                {
                    cancontinue = false;
                    MessageBox.Show("Masz za długi nick!");

                }
                else if (username.Length < 3)
                {
                    cancontinue = false;
                    MessageBox.Show("Masz za krótki nick!");
                }
                string allowedChars = "1234567890qwertyuioplkjhgfdsazxcvbnmQWERTYUIOPLKJHGFDSAZXCVBNM_";
                foreach (char c in username)
                {
                    if (!allowedChars.Contains(c))
                    {
                        cancontinue = false;
                        MessageBox.Show($"Nick zawiera niedozwolony znak: \"{c}\"");
                    }
                }

                if (!cancontinue)
                {
                    return;
                }

                bool offline = false;
                if (url == "offline")
                {
                    offline = true;
                }
                if (!offline)
                {
                    webBrowserdownload.Url = new Uri("https://mksteam.ovh/");
                }


                string versionselected = comboBox1.SelectedItem.ToString();
                if (!File.Exists(configsdir + "\\lastversion.mks"))
                {
                    using (FileStream fs = File.Create(configsdir + "\\lastversion.mks"))
                    {
                        byte[] info = new UTF8Encoding(true).GetBytes(versionselected);
                        // Add some information to the file.
                        fs.Write(info, 0, info.Length);
                    }
                }
                else
                {
                    File.WriteAllText(configsdir + "\\lastversion.mks", versionselected);
                }

                if (mclaunched)
                {
                    java.Kill();
                }
                else
                {
                    paneldownload.Visible = true;

                    deatach = false;
                    downloaded = false;
                    javadwnld = true;

                    {

                        bool iscustom = true;
                        string mcvertemp = comboBox1.SelectedItem.ToString();
                        foreach (var line in File.ReadAllLines(launcherdir + "\\relases.list"))
                        {
                            string name = line.Split(';')[0];
                            if (name == comboBox1.SelectedItem.ToString())
                            {
                                if (!offline)
                                {
                                    webClientmks.DownloadFile(depsurl + line.Split(';')[2], launcherdir + "\\" + line.Split(';')[2]);
                                }
                                iscustom = false;
                                versionname = name;
                                versionzip = line.Split(';')[1];
                                versionargsp1 = File.ReadAllText(launcherdir + "\\" + line.Split(';')[2]).Replace("--username", "&").Split('&')[0];
                                versionargsp2 = "--username" + File.ReadAllText(launcherdir + "\\" + line.Split(';')[2]).Replace("--username", "&").Split('&')[1];
                                string ram = comboBoxRAM.SelectedItem.ToString().Replace("M", "");
                                versionargsp1 = versionargsp1.Replace("RAMMB", ram);
                                versionargsp1 = versionargsp1.Replace("LAUNCHERPATHJAVA", launcherdir);
                                versionargsp1 = versionargsp1.Replace("LAUNCHERPATH", launcherdir + "\\" + versionzip.Split('.')[0]);
                                versionargsp2 = versionargsp2.Replace("LAUNCHERPATH", launcherdir + "\\" + versionzip.Split('.')[0]);



                                versionargsp2 = versionargsp2.Replace("USERNAMEMOD", textBoxnick.Text);


                                if (File.Exists(launcherdir + "\\" + versionzip.Split('.')[0] + "\\game\\tempModList-1703628101391"))
                                {
                                    string ddd = File.ReadAllText(launcherdir + "\\" + versionzip.Split('.')[0] + "\\game\\tempModList-1703628101391");
                                    if (ddd.Contains("LAUNCHERPATH"))
                                    {
                                        string fixedfor1122optifine = launcherdir + "\\" + versionzip.Split('.')[0];
                                        fixedfor1122optifine = fixedfor1122optifine.Replace("\\", "\\\\");
                                        ddd = ddd.Replace("LAUNCHERPATH", fixedfor1122optifine);

                                        File.WriteAllText(launcherdir + "\\" + versionzip.Split('.')[0] + "\\game\\tempModList-1703628101391", ddd);
                                    }
                                    else
                                    {
                                        string libspath = ddd.Replace("{\"repositoryRoot\":\"absolute:", "").Replace("\",\"modRef\":[\"optifine:OptiFine:1.12.2_HD_U_G5\"]}", "");
                                        if (!Directory.Exists(libspath))
                                        {
                                            ddd = ddd.Replace(libspath, "LAUNCHERPATH" + "\\game\\libraries");
                                            string fixedfor1122optifine = launcherdir + "\\" + versionzip.Split('.')[0];
                                            fixedfor1122optifine = fixedfor1122optifine.Replace("\\", "\\\\");
                                            ddd = ddd.Replace("LAUNCHERPATH", fixedfor1122optifine);
                                            File.WriteAllText(launcherdir + "\\" + versionzip.Split('.')[0] + "\\game\\tempModList-1703628101391", ddd);
                                        }
                                    }
                                }
                                string uuid = "892";
                                string token = "mks";
                                for (int i = 3; i < 32; i++)
                                {
                                    uuid = uuid + rand.Next(0, 9).ToString();
                                    token = token + rand.Next(0, 9).ToString();
                                }

                                premiumlaunchwait = false;
                                if (mctoken != "cracked")
                                {
                                    versionargsp2 = versionargsp2.Replace("UUID32", mcuuid);
                                    versionargsp2 = versionargsp2.Replace("TOKEN32", mctoken);

                                    if (mcvertemp.Contains("R 1.18.2") || mcvertemp.Contains("R 1.20.4") || mcvertemp.Contains("R 1.16.5") || mcvertemp.Contains("R 1.19.2"))
                                    {
                                        versionargsp2 = versionargsp2.Replace("--userType legacy", "--userType mojang");
                                    }
                                    else
                                    {
                                        versionargsp2 = versionargsp2.Replace("--userType legacy", "--userType msa");
                                    }

                                }
                                else
                                {
                                    versionargsp2 = versionargsp2.Replace("UUID32", uuid);
                                    versionargsp2 = versionargsp2.Replace("TOKEN32", token);
                                }


                                javapath = versionargsp1.Split('|')[0];
                                versionargsp1 = versionargsp1.Split('|')[1];


                            }
                        }
                        if (iscustom)
                        {
                            foreach (var line in File.ReadLines(launcherdir + "\\usermodpacks.mks"))
                            {
                                string name = line.Split(';')[0];
                                if (name == comboBox1.SelectedItem.ToString())
                                {
                                    versionname = name;
                                    versionzip = line.Split(';')[1];
                                    string argsfile = "unset";
                                    foreach (var line2 in File.ReadLines(launcherdir + "\\relases.list"))
                                    {
                                        if (line2.Contains(name.Split('-')[1] + ";"))
                                        {
                                            argsfile = line2.Split(';')[2];
                                        }
                                    }

                                    if (!offline)
                                    {
                                        webClientmks.DownloadFile(depsurl + argsfile, launcherdir + "\\" + argsfile);
                                    }
                                    versionname = name;
                                    versionzip = line.Split(';')[1];



                                    versionargsp1 = File.ReadAllText(launcherdir + "\\" + argsfile).Replace("--username", "&").Split('&')[0];
                                    versionargsp2 = "--username" + File.ReadAllText(launcherdir + "\\" + argsfile).Replace("--username", "&").Split('&')[1];
                                    string ram = comboBoxRAM.SelectedItem.ToString().Replace("M", "");
                                    versionargsp1 = versionargsp1.Replace("RAMMB", ram);
                                    versionargsp1 = versionargsp1.Replace("LAUNCHERPATHJAVA", launcherdir);
                                    versionargsp1 = versionargsp1.Replace("LAUNCHERPATH", launcherdir + "\\" + versionzip);
                                    versionargsp2 = versionargsp2.Replace("LAUNCHERPATH", launcherdir + "\\" + versionzip);


                                    versionargsp2 = versionargsp2.Replace("USERNAMEMOD", textBoxnick.Text);



                                    if (File.Exists(launcherdir + "\\" + versionzip + "\\game\\tempModList-1703628101391"))
                                    {
                                        string ddd = File.ReadAllText(launcherdir + "\\" + versionzip + "\\game\\tempModList-1703628101391");
                                        if (ddd.Contains("LAUNCHERPATH"))
                                        {
                                            string fixedfor1122optifine = launcherdir + "\\" + versionzip;
                                            fixedfor1122optifine = fixedfor1122optifine.Replace("\\", "\\\\");
                                            ddd = ddd.Replace("LAUNCHERPATH", fixedfor1122optifine);

                                            File.WriteAllText(launcherdir + "\\" + versionzip + "\\game\\tempModList-1703628101391", ddd);
                                        }
                                        else
                                        {
                                            string libspath = ddd.Replace("{\"repositoryRoot\":\"absolute:", "").Replace("\",\"modRef\":[\"optifine:OptiFine:1.12.2_HD_U_G5\"]}", "");
                                            if (!Directory.Exists(libspath))
                                            {
                                                ddd = ddd.Replace(libspath, "LAUNCHERPATH" + "\\game\\libraries");
                                                string fixedfor1122optifine = launcherdir + "\\" + versionzip;
                                                fixedfor1122optifine = fixedfor1122optifine.Replace("\\", "\\\\");
                                                ddd = ddd.Replace("LAUNCHERPATH", fixedfor1122optifine);
                                                File.WriteAllText(launcherdir + "\\" + versionzip + "\\game\\tempModList-1703628101391", ddd);
                                            }
                                        }
                                    }
                                    string uuid = "892";
                                    string token = "mks";
                                    for (int i = 3; i < 32; i++)
                                    {
                                        uuid = uuid + rand.Next(0, 9).ToString();
                                        token = token + rand.Next(0, 9).ToString();
                                    }

                                    premiumlaunchwait = false;
                                    if (mctoken != "cracked")
                                    {
                                        versionargsp2 = versionargsp2.Replace("UUID32", mcuuid);
                                        versionargsp2 = versionargsp2.Replace("TOKEN32", mctoken);
                                        if (mcvertemp.Contains("R 1.18.2") || mcvertemp.Contains("R 1.20.4") || mcvertemp.Contains("R 1.16.5") || mcvertemp.Contains("R 1.19.2"))
                                        {
                                            versionargsp2 = versionargsp2.Replace("--userType legacy", "--userType mojang");
                                        }
                                        else
                                        {
                                            versionargsp2 = versionargsp2.Replace("--userType legacy", "--userType msa");
                                        }
                                    }
                                    else
                                    {
                                        versionargsp2 = versionargsp2.Replace("UUID32", uuid);
                                        versionargsp2 = versionargsp2.Replace("TOKEN32", token);
                                    }

                                    javapath = versionargsp1.Split('|')[0];
                                    versionargsp1 = versionargsp1.Split('|')[1];


                                }
                            }
                        }
                        
                        if (checkBoxreinstalljava.Checked) //to do reinstallu javy 
                        {
                            checkBoxreinstalljava.Checked = false;
                            if (Directory.Exists(launcherdir + "\\jre"))
                            {
                                Directory.Delete(launcherdir + "\\jre", true);
                            }
                        }
                        if (false) //do reinstallu wersji
                        {
                            if (Directory.Exists(launcherdir + "\\" + versionzip.Split('.')[0]))
                            {
                                Directory.Delete(launcherdir + "\\" + versionzip.Split('.')[0], true);
                            }
                        }
                        if (!Directory.Exists(launcherdir + "\\" + "jre"))
                        {
                            javadwnld = true;
                            downloadlabel.Text = "JAVA nie jest pobrana!";
                            await Task.Delay(1000);
                            downloadlabel.Text = "Pobieranie środowiska java...";
                            await Task.Delay(1000);
                            DownloadFile(depsurl + "MCJAVA.zip", launcherdir + "\\tempjava.zip");
                            await Task.Delay(100);
                        }
                        else
                        {
                            javadwnld = false;
                        }
                        while (javadwnld)
                        {
                            await Task.Delay(1000);
                        }
                        if (!iscustom)
                        {
                            if (!Directory.Exists(launcherdir + "\\" + versionzip.Split('.')[0]))
                            {
                                downloaded = false;
                                DownloadFile(depsurl + versionzip, launcherdir + "\\temp.zip");
                            }
                            else
                            {
                                downloaded = true;
                            }
                        }
                        else
                        {
                            downloaded = true;
                        }

                        while (!downloaded)
                        {
                            await Task.Delay(1000);
                        }

                        if (downloaded)
                        {

                            string wersjaczycosnwm = versionzip.Split('.')[0];
                            if (iscustom)
                            {
                                wersjaczycosnwm = versionzip;
                            }
                            buttonlaunch.Text = "Włączanie!";
                            if (false) //kopiowanie java args
                            {
                                MessageBox.Show(javapath, "JAVA PATH");
                                MessageBox.Show(versionargsp1 + versionargsp2, "GAME ARGS");
                                Clipboard.SetText(javapath + " " + versionargsp1 + versionargsp2);
                                MessageBox.Show("java + args copied to clipboard!", "CLIPBOARD");
                            }
                            if (checkBoxnoverify.Checked)
                            {
                                versionargsp1 = "-noverify " + versionargsp1;
                            }
                            System.Diagnostics.ProcessStartInfo startinfo = new System.Diagnostics.ProcessStartInfo
                            {
                                FileName = javapath,
                                Arguments = versionargsp1 + versionargsp2,
                                ErrorDialog = true,
                                RedirectStandardError = true,
                                RedirectStandardOutput = true,
                                UseShellExecute = false,

                                WorkingDirectory = launcherdir + "\\" + wersjaczycosnwm
                            };
                            java = Process.Start(startinfo);

                            stream = java.StandardOutput;

                            Modules.DiscordPresence.SetPresence("Nick: " + textBoxnick.Text, "Gra w " + versionname);
                            paneldownload.Visible = false;
                            buttonlaunch.Text = "Zabij gre";
                            Task.Run(() => {
                                readstream();
                            });
                            while (!deatach)
                            {
                                if (!java.HasExited)
                                {
                                    mclaunched = true;
                                    java.Refresh();

                                }
                                else
                                {
                                    deatach = true;
                                }
                                await Task.Delay(1000);
                            }

                            //TU PO DEATACH/EXIT
                            Modules.DiscordPresence.SetPresence("W Launcherze", "byZyczu | " + Form1.version);
                            mclaunched = false;
                            buttonlaunch.Text = "Uruchom grę";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                deatach = true;
                MessageBox.Show("Paczka z którą chcesz włączyć grę prawdopodobnie została przez ciebie usunięta! Jeżeli uważasz, że gre wywala z winy programu wyślij screena tego błędu na naszego discorda!\r\nSzczegółowy błąd: " + ex.Message, "BŁĄD PODCZAS WŁĄCZANIA GRY!");
                Modules.DiscordPresence.SetPresence("W Launcherze", "byZyczu | " + Form1.version);
                paneldownload.Visible = false;
                mclaunched = false;
                buttonlaunch.Text = "Uruchom grę";
            }
        }
        public static StreamReader stream;
        public static async void readstream()
        {
            while (!deatach)
            {
                try
                {
                    while (!stream.EndOfStream)
                    {
                        stream2 = stream2 + "\r\n" + stream.ReadLine();
                    }
                }
                catch (Exception) { }
            }
        }
        public static string stream2 = "LOGI GRY:";
        public async void updateusermodpacks()
        {
            if (File.Exists(configsdir + "\\lastmodpack.mks"))
            {
                try
                {
                    if (comboBoxmodpacks.SelectedItem.ToString().Length > 1)
                    {
                        File.WriteAllText(configsdir + "\\lastmodpack.mks", comboBoxmodpacks.SelectedItem.ToString());
                    }
                }
                catch (Exception) { }
            }
            else
            {
                try
                {
                    if (comboBoxmodpacks.SelectedItem.ToString().Length > 1)
                    {
                        using (FileStream fs = File.Create(configsdir + "\\lastmodpack.mks"))
                        {

                            byte[] info = new UTF8Encoding(true).GetBytes(comboBoxmodpacks.SelectedItem.ToString());
                            // Add some information to the file.
                            fs.Write(info, 0, info.Length);
                        }
                    }
                }
                catch (Exception) { }
            }
            await Task.Delay(50);
            comboBoxmodpacks.Items.Clear();
            foreach (string line in File.ReadAllLines(launcherdir + "\\usermodpacks.mks"))
            {
                if (line.Contains("-"))
                {
                    if (line.Contains(';'))
                    {
                        if (url == "offline")
                        {
                            if (File.Exists(launcherdir + "\\" + line.Split(';')[2]))
                            {
                                string modpackname = line.Split(';')[0];
                                comboBoxmodpacks.Items.Add(modpackname);
                            }
                        }
                        else
                        {
                            string modpackname = line.Split(';')[0];
                            comboBoxmodpacks.Items.Add(modpackname);
                        }

                    }
                }
            }
            comboBox1.Items.Clear();
            if (url != "offline")
            {
                webClientmks.DownloadFile(depsurl + "relases.txt", launcherdir + "\\relases.list");
            }
            foreach (var line in File.ReadLines(launcherdir + "\\relases.list"))
            {
                if (url == "offline")
                {
                    if (File.Exists(launcherdir + "\\" + line.Split(';')[2]))
                    {
                        string name = line.Split(';')[0];
                        comboBox1.Items.Add(name);
                    }
                }
                else
                {
                    string name = line.Split(';')[0];
                    comboBox1.Items.Add(name);
                }
            }
            foreach (var line in File.ReadLines(launcherdir + "\\usermodpacks.mks"))
            {
                if (line.Contains("-"))
                {
                    if (line.Contains(';'))
                    {
                        if (url == "offline")
                        {
                            if (File.Exists(launcherdir + "\\" + line.Split(';')[2]))
                            {
                                string modpackname = line.Split(';')[0];
                                comboBox1.Items.Add(modpackname);
                            }
                        }
                        else
                        {
                            string modpackname = line.Split(';')[0];
                            comboBox1.Items.Add(modpackname);
                        }

                    }
                }
            }
            try
            {
                comboBox1.SelectedItem = File.ReadAllText(configsdir + "\\lastversion.mks").Split(';')[0];
                if (File.Exists(configsdir + "\\lastmodpack.mks"))
                {
                    comboBoxmodpacks.SelectedItem = File.ReadAllText(configsdir + "\\lastmodpack.mks");
                    string mcver = comboBoxmodpacks.SelectedItem.ToString().Split('-')[0];
                    string modpackname = comboBoxmodpacks.SelectedItem.ToString().Split('-')[1];
                    textBoxmodsmcversion.Text = modpackname;
                    textboxmodpackname.Text = mcver;
                }
            }
            catch (Exception) { }
        }

        private void buttonownmods_Click(object sender, EventArgs e)
        {
            updateusermodpacks();
            panelmodsmain.Visible = true;
        }

        private void buttonclosemods_Click(object sender, EventArgs e)
        {
            panelmodsmain.Visible = false;
        }

        private void comboBoxmodpacks_SelectionChangeCommitted(object sender, EventArgs e)
        {
            updateusermodpacks();
        }

        private async void button1_Click(object sender, EventArgs e) //zmiana nazwy
        {
            try
            {
                if (textboxmodpackname.Text.StartsWith(" "))
                {
                    MessageBox.Show("Nazwa paczki nie może zaczynać się spacją!");
                }
                else if (textboxmodpackname.Text.EndsWith(" "))
                {
                    MessageBox.Show("Nazwa paczki nie może kończyć się spacją!");
                }
                else if (textboxmodpackname.Text.Contains('\\') || textboxmodpackname.Text.Contains('/') || textboxmodpackname.Text.Contains(':') || textboxmodpackname.Text.Contains('*') || textboxmodpackname.Text.Contains('?') || textboxmodpackname.Text.Contains('"') || textboxmodpackname.Text.Contains('<') || textboxmodpackname.Text.Contains('>') || textboxmodpackname.Text.Contains('|') || textboxmodpackname.Text.Contains('-'))
                {
                    MessageBox.Show("Nazwa paczki zawiera niedozwolone znaki!");
                }
                else
                {

                    string newfile = "";
                    foreach (string line in File.ReadAllLines(launcherdir + "\\usermodpacks.mks"))
                    {
                        string fr;
                        if (line.Split(';')[0] == comboBoxmodpacks.SelectedItem.ToString())
                        {
                            string args = line.Split(';')[2];
                            string mcver2 = line.Split(';')[1];
                            string mcver = line.Split(';')[0];
                            string tomove = mcver2;
                            mcver = mcver.Split('-')[1];
                            string modpackname = textboxmodpackname.Text;
                            string modpacknamemyslnik = modpackname.Replace(" ", "-");
                            fr = modpackname + "-" + mcver + ";" + modpacknamemyslnik + "-" + mcver.Replace(" ", "-") + ";" + args;
                            Directory.Move(launcherdir + "\\" + tomove, launcherdir + "\\" + modpacknamemyslnik + "-" + mcver.Replace(" ", "-"));
                            newfile = newfile + "\r\n" + fr;
                        }
                        else if (line.Contains('-'))
                        {
                            fr = line;
                            newfile = newfile + "\r\n" + fr;
                        }

                    }
                    File.WriteAllText(launcherdir + "\\usermodpacks.mks", newfile);
                    await Task.Delay(100);
                    updateusermodpacks();
                }
            }
            catch (Exception) { }
        }

        private async void button2_Click(object sender, EventArgs e) //chyba delete modpack 
        {

            string newfile = "";
            foreach (string line in File.ReadAllLines(launcherdir + "\\usermodpacks.mks"))
            {
                string fr;
                if (line.Split(';')[0] == comboBoxmodpacks.SelectedItem.ToString())
                {
                    Directory.Delete(launcherdir + "\\" + line.Split(';')[1], true);
                }
                else
                {
                    fr = line;
                    newfile = newfile + "\r\n" + fr;
                }
            }

            File.WriteAllText(launcherdir + "\\usermodpacks.mks", newfile);

            comboBoxmodpacks.Items.Clear();
            updateusermodpacks();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelcreatenewmodpack.Visible = false;
            panelmodsmain.Visible = true;
        }

        private async void button5_Click(object sender, EventArgs e) //dalej w tworzeniu modpacka
        {
            string modpackver = comboBoxmodpackcreate.SelectedItem.ToString();
            string modpackname = textBoxpackcreatename.Text;
            if (modpackname.StartsWith(" "))
            {
                MessageBox.Show("Nazwa paczki nie może zaczynać się spacją!");
            }
            else if (modpackname.EndsWith(" "))
            {
                MessageBox.Show("Nazwa paczki nie może kończyć się spacją!");
            }
            else if (modpackname.Contains('\\') || modpackname.Contains('/') || modpackname.Contains(':') || modpackname.Contains('*') || modpackname.Contains('?') || modpackname.Contains('"') || modpackname.Contains('<') || modpackname.Contains('>') || modpackname.Contains('|') || modpackname.Contains('-'))
            {
                MessageBox.Show("Nazwa paczki zawiera niedozwolone znaki!");
            }
            else
            {
                panelcreatenewmodpack.Visible = false;

                foreach (string line in File.ReadAllLines(launcherdir + "\\relases.list"))
                {
                    if (line.Contains(modpackver + ";"))
                    {
                        if (Directory.Exists(launcherdir + "\\" + modpackname + "-" + line.Split(';')[1]))
                        {
                            MessageBox.Show("Paczka modów z taką nazwą już istnieje!");
                        }
                        else
                        {
                            modpackname = modpackname.Replace(" ", "-");
                            CopyDirectory(launcherdir + "\\" + line.Split(';')[1].Replace(".zip", ""), launcherdir + "\\" + modpackname + "-" + line.Split(';')[1]);
                            string userversions = File.ReadAllText(launcherdir + "\\usermodpacks.mks");
                            userversions = userversions + "\r\n" + modpackname.Replace("-", " ") + "-" + modpackver + ";" + modpackname + "-" + line.Split(';')[1] + ";" + line.Split(';')[2];
                            await Task.Delay(100);
                            File.WriteAllText(launcherdir + "\\usermodpacks.mks", userversions);
                        }
                    }
                }
                updateusermodpacks();
                panelmodsmain.Visible = true;


            }
        }
        private static void CopyDirectory(string sourcePath, string targetPath)
        {
            foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
            }
            foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
            {
                File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            panelcreatenewmodpack.Visible = true;
            panelmodsmain.Visible = false;
            comboBoxmodpackcreate.Items.Clear();
            foreach (string line in File.ReadAllLines(launcherdir + "\\relases.list"))
            {
                if (line.Contains("Forge") || line.Contains("Fabric") || line.Contains("mods"))
                {
                    if (Directory.Exists(launcherdir + "\\" + line.Split(';')[1].Replace(".zip", "")))
                    {
                        if (url == "offline")
                        {
                            if (File.Exists(launcherdir + "\\" + line.Split(';')[2]))
                            {
                                comboBoxmodpackcreate.Items.Add(line.Split(';')[0]);
                            }
                        }
                        else
                        {
                            comboBoxmodpackcreate.Items.Add(line.Split(';')[0]);
                        }
                    }
                }
            }
        }

        Process java;

        private void buttonmanagemods_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (string line in File.ReadAllLines(launcherdir + "\\usermodpacks.mks"))
                {
                    if (line.Split(';')[0] == comboBoxmodpacks.SelectedItem.ToString())
                    {
                        Process.Start(launcherdir + "\\" + line.Split(';')[1] + "\\game\\mods");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie wybrałeś paczki modów! Pełny błąd:\r\n" + ex.Message, "BŁĄD");
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string versionselected = comboBox1.SelectedItem.ToString();
            if (!File.Exists(configsdir + "\\lastversion.mks"))
            {
                using (FileStream fs = File.Create(configsdir + "\\lastversion.mks"))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(versionselected);
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }
            }
            else
            {
                File.WriteAllText(configsdir + "\\lastversion.mks", versionselected);
            }
        }

        private void buttonmodpacks_Click(object sender, EventArgs e)
        {
            panelmodpacks.Visible = true;
            panelmanageversions.Visible = false;
            comboBoxmodpacks.Visible = true;
            buttonmanagemods.Visible = true;
        }

        private void buttonmanageversions_Click(object sender, EventArgs e)
        {
            panelmanageversions.Visible = true;
            panelmodpacks.Visible = false;
            comboBoxmodpacks.Visible = false;
            buttonmanagemods.Visible = false;
            comboBoxmanageversions.Items.Clear();
            foreach (var line in File.ReadLines(launcherdir + "\\relases.list"))
            {
                string name = line.Split(';')[0];
                string folder = line.Split(';')[1].Replace(".zip", "");

                if (Directory.Exists(launcherdir + "\\" + folder))
                {
                    comboBoxmanageversions.Items.Add(name);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (var line in File.ReadLines(launcherdir + "\\relases.list"))
            {
                if (line.Split(';')[0] == comboBoxmanageversions.SelectedItem.ToString())
                {
                    string name = line.Split(';')[0];
                    string folder = line.Split(';')[1].Replace(".zip", "");
                    if (Directory.Exists(launcherdir + "\\" + folder))
                    {
                        string[] allfolders = Directory.GetDirectories(launcherdir);
                        bool shoulddel = true;
                        for (int i = 0; i < allfolders.Length; i++)
                        {
                            if (allfolders[i].Contains("-" + folder + ".zip"))
                            {
                                shoulddel = false;
                                DialogResult dialogResult = MessageBox.Show("Masz jedną lub więcej paczek modów powiązanych z tą wersją gry. Jeżeli ją usuniesz mogą one przestać działać! Czy na pewno chcesz usunąć tą wersję?", "OSTRZEŻENIE!", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    shoulddel = true;
                                }
                                else if (dialogResult == DialogResult.No)
                                {
                                    shoulddel = false;
                                    return;
                                }
                            }

                        }
                        if (shoulddel)
                        {
                            Directory.Delete(launcherdir + "\\" + folder, true);
                        }
                    }
                }
            }
            comboBoxmanageversions.Items.Clear();
            foreach (var line in File.ReadLines(launcherdir + "\\relases.list"))
            {
                string name = line.Split(';')[0];
                string folder = line.Split(';')[1].Replace(".zip", "");
                if (Directory.Exists(launcherdir + "\\" + folder))
                {
                    comboBoxmanageversions.Items.Add(name);
                }
            }
        }
        WebClient premiumweb = new WebClient();
        void premiumlogin()
        {
            try
            {
                //logging in to microsoft account
                string coderesponse = premiumweb.DownloadString("https://login.microsoftonline.com/consumers/oauth2/v2.0/devicecode?client_id=499546d9-bbfe-4b9b-a086-eb3d75afb78f&scope=XboxLive.signin%20offline_access");
                string usercode = coderesponse.Replace("\"user_code\":\"", ">").Split('>')[1].Split('"')[0];
                string verifyurl = coderesponse.Replace("\"verification_uri\":\"", ">").Split('>')[1].Split('"')[0];
                string devicecode = coderesponse.Replace("\"device_code\":\"", ">").Split('>')[1].Split('"')[0];
                Clipboard.SetText(usercode);
                Process.Start(verifyurl);
                MessageBox.Show($"Wejdź na {verifyurl} na przeglądarce i wpisz kod {usercode} (skopiowano do schowka) aby kontynuować logowanie\r\n\r\nMOŻESZ ZAMKNĄĆ TE OKNO DOPIERO PO ZALOGOWANIU SIĘ W PRZEGLĄDARCE, INACZEJ LOGOWANIE SIE NIE UDA!\r\nPamiętaj że dodawanie większej ilości kont premium zwiększa czas ładowania launchera!", "LOGOWANIE PREMIUM");

                //getting mstoken + refreshtoken
                string spamrequest = $"client_id=499546d9-bbfe-4b9b-a086-eb3d75afb78f&code={devicecode}&grant_type=urn%3Aietf%3Aparams%3Aoauth%3Agrant-type%3Adevice_code";
                WebRequest webRequest = WebRequest.Create("https://login.microsoftonline.com/consumers/oauth2/v2.0/token");
                webRequest.Timeout = 5000;
                webRequest.Method = "POST";
                webRequest.Headers.Add("Cookie", "esctx=PAQABAAEAAAAmoFfGtYxvRrNriQdPKIZ-N1P_MEcnyzSjOqDSJiFM7mL9hTzkvRZDiQnF8oxfy0UDFCE9QVbyMFtCPdcO7LTrN_eGz0Fuk4sXL38g7azDkEZ82a4qVcU6FQsDj0wGq0tu4dHlTuSQU_n5UY5vnjtNLyvxkfvQixzDk-GA7-flAXkwJhTHDb-gnlM60MPN54sgAA; stsservicecookie=estsfd; fpc=Aq7Yu-WVxD9KsIRK63eSKH1jHbnPFAAAALiBXN0OAAAA; x-ms-gateway-slice=estsfd");
                webRequest.ContentLength = (long)spamrequest.Length;
                StreamWriter streamWriter = new StreamWriter(webRequest.GetRequestStream());
                streamWriter.Write(spamrequest.ToCharArray(), 0, spamrequest.Length);
                streamWriter.Close();
                StreamReader streamReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                string spamresponse = streamReader.ReadToEnd();
                string tokenspam = spamresponse.Replace("\"access_token\":\"", ">").Split('>')[1].Split('"')[0];
                string refreshtokenspam = spamresponse.Replace("\"refresh_token\":\"", ">").Split('>')[1].Split('"')[0];



                //getting authenticate token
                string authrequest = $"{{\r\n   \"Properties\" : {{\r\n      \"AuthMethod\" : \"RPS\",\r\n      \"RpsTicket\" : \"d={tokenspam}\",\r\n      \"SiteName\" : \"user.auth.xboxlive.com\"\r\n   }},\r\n   \"RelyingParty\" : \"http://auth.xboxlive.com\",\r\n   \"TokenType\" : \"JWT\"\r\n}}";
                WebRequest authwebRequest = WebRequest.Create("https://user.auth.xboxlive.com/user/authenticate");
                authwebRequest.Timeout = 5000;
                authwebRequest.Method = "POST";
                authwebRequest.ContentType = "application/json";
                authwebRequest.ContentLength = (long)authrequest.Length;
                StreamWriter authstreamWriter = new StreamWriter(authwebRequest.GetRequestStream());
                authstreamWriter.Write(authrequest.ToCharArray(), 0, authrequest.Length);
                authstreamWriter.Close();
                StreamReader authstreamReader = new StreamReader(authwebRequest.GetResponse().GetResponseStream());
                string authresponse = authstreamReader.ReadToEnd();
                string authtoken = authresponse.Replace("\"Token\":\"", ">").Split('>')[1].Split('"')[0];


                //getting authorizetoken + uhs
                string authorizerequest = $"{{\r\n   \"Properties\" : {{\r\n      \"SandboxId\" : \"RETAIL\",\r\n      \"UserTokens\" : [\r\n         \"{authtoken}\"\r\n      ]\r\n   }},\r\n   \"RelyingParty\" : \"rp://api.minecraftservices.com/\",\r\n   \"TokenType\" : \"JWT\"\r\n}}";
                WebRequest authorizewebRequest = WebRequest.Create("https://xsts.auth.xboxlive.com/xsts/authorize");
                authorizewebRequest.Timeout = 5000;
                authorizewebRequest.Method = "POST";
                authorizewebRequest.ContentType = "application/json";
                authorizewebRequest.ContentLength = (long)authorizerequest.Length;
                StreamWriter authorizestreamWriter = new StreamWriter(authorizewebRequest.GetRequestStream());
                authorizestreamWriter.Write(authorizerequest.ToCharArray(), 0, authorizerequest.Length);
                authorizestreamWriter.Close();
                StreamReader authorizestreamReader = new StreamReader(authorizewebRequest.GetResponse().GetResponseStream());
                string authorizeresponse = authorizestreamReader.ReadToEnd();
                string authorizetoken = authorizeresponse.Replace("\"Token\":\"", ">").Split('>')[1].Split('"')[0];
                string uhs = authorizeresponse.Replace("\"uhs\":\"", ">").Split('>')[1].Split('"')[0];

                //getting minecraft accesstoken
                string loginreqrequest = $"{{\r\n   \"platform\" : \"PC_LAUNCHER\",\r\n   \"xtoken\" : \"XBL3.0 x={uhs};{authorizetoken}\"\r\n}}";
                WebRequest loginreqwebRequest = WebRequest.Create("https://api.minecraftservices.com/launcher/login");
                loginreqwebRequest.Timeout = 5000;
                loginreqwebRequest.Method = "POST";
                loginreqwebRequest.ContentType = "application/json";
                loginreqwebRequest.ContentLength = (long)loginreqrequest.Length;
                StreamWriter loginreqstreamWriter = new StreamWriter(loginreqwebRequest.GetRequestStream());
                loginreqstreamWriter.Write(loginreqrequest.ToCharArray(), 0, loginreqrequest.Length);
                loginreqstreamWriter.Close();
                StreamReader loginreqstreamReader = new StreamReader(loginreqwebRequest.GetResponse().GetResponseStream());
                string loginreqresponse = loginreqstreamReader.ReadToEnd();
                string mcaccesstoken = loginreqresponse.Replace("\"access_token\" : \"", ">").Split('>')[1].Split('"')[0];

                //gettings username + uuid
                WebClient premiumprofileweb = new WebClient();
                premiumprofileweb.Headers.Add("Authorization", $"Bearer {mcaccesstoken}");
                string getprofileresponse = premiumprofileweb.DownloadString("https://api.minecraftservices.com/minecraft/profile");
                string username = getprofileresponse.Replace("\"name\" : \"", ">").Split('>')[1].Split('"')[0];
                string uuid = getprofileresponse.Split('[')[0].Replace("\"id\" : \"", ">").Split('>')[1].Split('"')[0];


                bool isadded = false;
                if (mcaccesstoken.Length > 1)
                {
                    if (username.Length > 1)
                    {
                        if (uuid.Length > 1)
                        {
                            isadded = true;
                            AddAccountPremium(username, uuid, refreshtokenspam);
                            MessageBox.Show($"Dodano konto:\r\nusername: {username}\r\nuuid: {uuid}");
                        }
                    }
                }
                if (!isadded)
                {
                    MessageBox.Show($"Błąd przy dodawaniu konto! Zebrane informacje:\r\nusername: {username}\r\nUUID: {uuid}\r\ntoken: {mcaccesstoken}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BŁĄD PRZY DODAWANIU KONTA PREMIUM: " + ex.Message, "BŁĄD");
            }
        }

        void AddAccountPremium(string username, string uuid, string refreshtoken)
        {
            if (!Directory.Exists(launcherdir + "\\accounts"))
            {
                Directory.CreateDirectory(launcherdir + "\\accounts");
            }
            if (!File.Exists(launcherdir + "\\accounts\\accsprem.mks"))
            {
                using (FileStream fs = File.Create(launcherdir + "\\accounts\\accsprem.mks"))
                {
                }
            }
            string tosave = "";
            foreach (var line in File.ReadAllLines(launcherdir + "\\accounts\\accsprem.mks"))
            {
                if (line.Contains(">"))
                {
                    tosave = tosave + "\r\n" + line;
                }
            }
            tosave = tosave + "\r\n" + $"{username}>{uuid}>{refreshtoken}";
            comboBoxpremiumaccounts.Items.Add(username);
            File.WriteAllText(launcherdir + "\\accounts\\accsprem.mks", tosave);
        }

       
        string RefreshAccountData(string refreshtoken)
        {
            try
            {
                //getting mstoken + refreshtoken
                string spamrequest = $"client_id=499546d9-bbfe-4b9b-a086-eb3d75afb78f&grant_type=refresh_token&refresh_token={refreshtoken}";
                WebRequest webRequest = WebRequest.Create("https://login.microsoftonline.com/consumers/oauth2/v2.0/token");
                webRequest.Timeout = 5000;
                webRequest.Method = "POST";
                webRequest.ContentLength = (long)spamrequest.Length;
                StreamWriter streamWriter = new StreamWriter(webRequest.GetRequestStream());
                streamWriter.Write(spamrequest.ToCharArray(), 0, spamrequest.Length);
                streamWriter.Close();
                StreamReader streamReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                string spamresponse = streamReader.ReadToEnd();
                string tokenspam = spamresponse.Replace("\"access_token\":\"", ">").Split('>')[1].Split('"')[0];
                string refreshtokenspam = spamresponse.Replace("\"refresh_token\":\"", ">").Split('>')[1].Split('"')[0];

                //getting authenticate token
                string authrequest = $"{{\r\n   \"Properties\" : {{\r\n      \"AuthMethod\" : \"RPS\",\r\n      \"RpsTicket\" : \"d={tokenspam}\",\r\n      \"SiteName\" : \"user.auth.xboxlive.com\"\r\n   }},\r\n   \"RelyingParty\" : \"http://auth.xboxlive.com\",\r\n   \"TokenType\" : \"JWT\"\r\n}}";
                WebRequest authwebRequest = WebRequest.Create("https://user.auth.xboxlive.com/user/authenticate");
                authwebRequest.Timeout = 5000;
                authwebRequest.Method = "POST";
                authwebRequest.ContentType = "application/json";
                authwebRequest.ContentLength = (long)authrequest.Length;
                StreamWriter authstreamWriter = new StreamWriter(authwebRequest.GetRequestStream());
                authstreamWriter.Write(authrequest.ToCharArray(), 0, authrequest.Length);
                authstreamWriter.Close();
                StreamReader authstreamReader = new StreamReader(authwebRequest.GetResponse().GetResponseStream());
                string authresponse = authstreamReader.ReadToEnd();
                string authtoken = authresponse.Replace("\"Token\":\"", ">").Split('>')[1].Split('"')[0];

                //getting authorizetoken + uhs
                string authorizerequest = $"{{\r\n   \"Properties\" : {{\r\n      \"SandboxId\" : \"RETAIL\",\r\n      \"UserTokens\" : [\r\n         \"{authtoken}\"\r\n      ]\r\n   }},\r\n   \"RelyingParty\" : \"rp://api.minecraftservices.com/\",\r\n   \"TokenType\" : \"JWT\"\r\n}}";
                WebRequest authorizewebRequest = WebRequest.Create("https://xsts.auth.xboxlive.com/xsts/authorize");
                authorizewebRequest.Timeout = 5000;
                authorizewebRequest.Method = "POST";
                authorizewebRequest.ContentType = "application/json";
                authorizewebRequest.ContentLength = (long)authorizerequest.Length;
                StreamWriter authorizestreamWriter = new StreamWriter(authorizewebRequest.GetRequestStream());
                authorizestreamWriter.Write(authorizerequest.ToCharArray(), 0, authorizerequest.Length);
                authorizestreamWriter.Close();
                StreamReader authorizestreamReader = new StreamReader(authorizewebRequest.GetResponse().GetResponseStream());
                string authorizeresponse = authorizestreamReader.ReadToEnd();
                string authorizetoken = authorizeresponse.Replace("\"Token\":\"", ">").Split('>')[1].Split('"')[0];
                string uhs = authorizeresponse.Replace("\"uhs\":\"", ">").Split('>')[1].Split('"')[0];

                //getting mcaccesstoken
                string loginreqrequest = $"{{\r\n   \"platform\" : \"PC_LAUNCHER\",\r\n   \"xtoken\" : \"XBL3.0 x={uhs};{authorizetoken}\"\r\n}}";
                WebRequest loginreqwebRequest = WebRequest.Create("https://api.minecraftservices.com/launcher/login");
                loginreqwebRequest.Timeout = 5000;
                loginreqwebRequest.Method = "POST";
                loginreqwebRequest.ContentType = "application/json";
                loginreqwebRequest.ContentLength = (long)loginreqrequest.Length;
                StreamWriter loginreqstreamWriter = new StreamWriter(loginreqwebRequest.GetRequestStream());
                loginreqstreamWriter.Write(loginreqrequest.ToCharArray(), 0, loginreqrequest.Length);
                loginreqstreamWriter.Close();
                StreamReader loginreqstreamReader = new StreamReader(loginreqwebRequest.GetResponse().GetResponseStream());
                string loginreqresponse = loginreqstreamReader.ReadToEnd();
                string mcaccesstoken = loginreqresponse.Replace("\"access_token\" : \"", ">").Split('>')[1].Split('"')[0];

                //getting username + UUID
                WebClient premiumprofileweb = new WebClient();
                premiumprofileweb.Headers.Add("Authorization", $"Bearer {mcaccesstoken}");
                string getprofileresponse = premiumprofileweb.DownloadString("https://api.minecraftservices.com/minecraft/profile");
                Clipboard.SetText(getprofileresponse);
                //MessageBox.Show(getprofileresponse);
                string username = getprofileresponse.Replace("\"name\" : \"", ">").Split('>')[1].Split('"')[0];
                string uuid = getprofileresponse.Split('[')[0].Replace("\"id\" : \"", ">").Split('>')[1].Split('"')[0];
                return $"{username}>{uuid}>{refreshtokenspam}<{mcaccesstoken}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("BŁĄD PRZY ODŚWIEŻANIU KONTA PREMIUM: " + ex.Message, "BŁĄD");
                return "error>error>error<error";
            }
        }

        string mctoken = "cracked";
        string mcusername = "N";
        string mcuuid = "cracked";

        private void buttonaccounts_Click(object sender, EventArgs e)
        {
            panelaccounts.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panelaccounts.Visible = false;
        }

        private void buttonaddaccountpremium_Click(object sender, EventArgs e)
        {
            premiumlogin();
            
        }

        private void buttonloginpremium_Click(object sender, EventArgs e)
        {
            try
            {
                string accountdata = GetDataViaUsername(comboBoxpremiumaccounts.SelectedItem.ToString());
                string newdata = RefreshAccountData(accountdata.Split('>')[2]);
                mctoken = newdata.Split('<')[1];
                mcusername = newdata.Split('>')[0];
                mcuuid = newdata.Split('>')[1];



                string towrite = "\r\n";
                foreach (var line in File.ReadAllLines(launcherdir + "\\accounts\\accsprem.mks"))
                {

                    if (line.Contains($"{mcuuid}>"))
                    {
                        towrite = towrite + $"{mcusername}>{mcuuid}>{newdata.Split('<')[0].Split('>')[2]}" + "\r\n";
                    }
                    else
                    {
                        towrite = towrite + line + "'\r\n";
                    }
                }



                if (!File.Exists(launcherdir + "\\accounts\\selectedacc.mks"))
                {
                    using (FileStream fs = File.Create(launcherdir + "\\accounts\\selectedacc.mks"))
                    {
                    }
                }
                Task.Delay(500);
                File.WriteAllText(launcherdir + "\\accounts\\selectedacc.mks", $"{mcusername}>{mcuuid}");
                textBoxnick.Text = mcusername;
                MessageBox.Show("Zalogowano do:\r\n" + mcusername);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BŁĄD PRZY LOGOWANIU NA KONTO PREMIUM: " + ex.Message, "BŁĄD");
            }
        }

        string GetDataViaUsername(string username)
        {
            try
            {
                foreach (var line in File.ReadAllLines(launcherdir + "\\accounts\\accsprem.mks"))
                {
                    if (line.Contains($"{username}>"))
                    {
                        return line;
                    }
                }
                return "NOTFOUND";
            }
            catch (Exception ex)
            {
                MessageBox.Show("BŁĄD PRZY WCZYTYWANIU ZAPISANYCH INFORMACJI KONTA: " + ex.Message, "BŁĄD");
                return "error";
            }
        }

        void AddOfflineAccount(string username)
        {
            try
            {
                if (!Directory.Exists(launcherdir + "\\accounts"))
                {
                    Directory.CreateDirectory(launcherdir + "\\accounts");
                }
                if (!File.Exists(launcherdir + "\\accounts\\accsoff.mks"))
                {
                    using (FileStream fs = File.Create(launcherdir + "\\accounts\\accsoff.mks"))
                    {
                    }
                }
                string tosave = "";
                foreach (var line in File.ReadAllLines(launcherdir + "\\accounts\\accsoff.mks"))
                {
                    if (line.Contains(">"))
                    {
                        tosave = tosave + "\r\n" + line;
                    }
                }
                tosave = tosave + "\r\n" + $"{username}>cracked>cracked";
                File.WriteAllText(launcherdir + "\\accounts\\accsoff.mks", tosave);
                Task.Delay(300);
                comboBoxloginoffline.Items.Clear();
                foreach (var line in File.ReadAllLines(launcherdir + "\\accounts\\accsoff.mks"))
                {
                    if (line.Contains(">"))
                    {
                        comboBoxloginoffline.Items.Add(line.Split('>')[0]);

                    }
                }
                MessageBox.Show("Dodano konto!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("BŁĄD PRZY DODAWANIU KONTA OFFLINE: " + ex.Message, "BŁĄD");
            }
        }

        private void buttonaddaccountoffline_Click(object sender, EventArgs e)
        {
            AddOfflineAccount(textBoxaddnick.Text);
        }

        private void buttonloginoffline_Click(object sender, EventArgs e)
        {
            mcusername = comboBoxloginoffline.SelectedItem.ToString();
            File.WriteAllText(launcherdir + "\\accounts\\selectedacc.mks", $"{mcusername}>cracked");
            mcuuid = "cracked";
            mctoken = "cracked";
            textBoxnick.Text = mcusername;
            MessageBox.Show("Zalogowano na: " + mcusername);
        }

        private void buttondeleteoffline_Click(object sender, EventArgs e)
        {
            try
            {

                string tosave = "";
                foreach (var line in File.ReadAllLines(launcherdir + "\\accounts\\accsoff.mks"))
                {
                    if (line.Contains(">"))
                    {
                        if (line.Contains(comboBoxloginoffline.SelectedItem.ToString() + ">cracked>cracked"))
                        {

                        }
                        else
                        {
                            tosave = tosave + "\r\n" + line;
                        }

                    }
                }
                File.WriteAllText(launcherdir + "\\accounts\\accsoff.mks", tosave);


                string temp = File.ReadAllText(launcherdir + "\\accounts\\selectedacc.mks");
                if (temp.Contains(comboBoxloginoffline.SelectedItem.ToString() + ">cracked"))
                {
                    File.WriteAllText(launcherdir + "\\accounts\\selectedacc.mks", "");
                    textBoxnick.Text = "";
                }

                comboBoxloginoffline.Items.Clear();
                foreach (var line in File.ReadAllLines(launcherdir + "\\accounts\\accsoff.mks"))
                {
                    if (line.Contains(">"))
                    {
                        comboBoxloginoffline.Items.Add(line.Split('>')[0]);

                    }
                }
                MessageBox.Show("Usunięto konto!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("BŁĄD PRZY USUWANIU KONTA OFFLINE: " + ex.Message, "BŁĄD");
            }
        }

        private void buttondeleteonline_Click(object sender, EventArgs e)
        {
            try
            {
                string tosave = "";
                foreach (var line in File.ReadAllLines(launcherdir + "\\accounts\\accsprem.mks"))
                {
                    if (line.Contains(">"))
                    {
                        if (line.StartsWith(comboBoxpremiumaccounts.SelectedItem.ToString() + ">"))
                        {

                        }
                        else
                        {
                            tosave = tosave + "\r\n" + line;
                        }

                    }
                }
                File.WriteAllText(launcherdir + "\\accounts\\accsprem.mks", tosave);

                if (File.ReadAllText(launcherdir + "\\accounts\\selectedacc.mks").Contains(comboBoxpremiumaccounts.SelectedItem.ToString() + ">"))
                {
                    Task.Delay(200);
                    File.WriteAllText(launcherdir + "\\accounts\\selectedacc.mks", "");
                    textBoxnick.Text = "";
                }

                comboBoxpremiumaccounts.Items.Clear();
                foreach (var line in File.ReadAllLines(launcherdir + "\\accounts\\accsprem.mks"))
                {
                    if (line.Contains(">"))
                    {
                        comboBoxpremiumaccounts.Items.Add(line.Split('>')[0]);

                    }
                }

                MessageBox.Show("Usunięto konto!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("BŁĄD PRZY USUWANIU KONTA ONLINE: " + ex.Message, "BŁĄD");
            }
        }

        private void comboBoxmodpacks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}