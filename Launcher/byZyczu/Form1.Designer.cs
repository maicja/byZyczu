using byZyczu.Properties;
using System.Drawing.Text;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.IO;

namespace byZyczu
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonaccounts = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxnick = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonsettings = new System.Windows.Forms.Button();
            this.buttonownmods = new System.Windows.Forms.Button();
            this.buttonlaunch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelsettings = new System.Windows.Forms.Panel();
            this.checkBoxreinstalljava = new System.Windows.Forms.CheckBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.checkBoxnoverify = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxRAM = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttoncancessett = new System.Windows.Forms.Button();
            this.buttonsavechanges = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.paneldownload = new System.Windows.Forms.Panel();
            this.webBrowserdownload = new System.Windows.Forms.WebBrowser();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.downloadlabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelmodsmain = new System.Windows.Forms.Panel();
            this.panelmanageversions = new System.Windows.Forms.Panel();
            this.comboBoxmanageversions = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonclosemods = new System.Windows.Forms.Button();
            this.comboBoxmodpacks = new System.Windows.Forms.ComboBox();
            this.panelmodpacks = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textboxmodpackname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxmodsmcversion = new System.Windows.Forms.TextBox();
            this.buttonmanageversions = new System.Windows.Forms.Button();
            this.buttonmodpacks = new System.Windows.Forms.Button();
            this.buttonmanagemods = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.panelcreatenewmodpack = new System.Windows.Forms.Panel();
            this.textBoxpackcreatename = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBoxmodpackcreate = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panelconsole = new System.Windows.Forms.Panel();
            this.richTextBoxconsole = new System.Windows.Forms.RichTextBox();
            this.panelaccounts = new System.Windows.Forms.Panel();
            this.buttondeleteonline = new System.Windows.Forms.Button();
            this.buttondeleteoffline = new System.Windows.Forms.Button();
            this.comboBoxpremiumaccounts = new System.Windows.Forms.ComboBox();
            this.buttonloginpremium = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.buttonaddaccountpremium = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.comboBoxloginoffline = new System.Windows.Forms.ComboBox();
            this.buttonloginoffline = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.buttonaddaccountoffline = new System.Windows.Forms.Button();
            this.textBoxaddnick = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelsettings.SuspendLayout();
            this.paneldownload.SuspendLayout();
            this.panelmodsmain.SuspendLayout();
            this.panelmanageversions.SuspendLayout();
            this.panelmodpacks.SuspendLayout();
            this.panelcreatenewmodpack.SuspendLayout();
            this.panelconsole.SuspendLayout();
            this.panelaccounts.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonaccounts);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBoxnick);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonsettings);
            this.panel1.Controls.Add(this.buttonownmods);
            this.panel1.Controls.Add(this.buttonlaunch);
            this.panel1.Location = new System.Drawing.Point(480, 303);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 152);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonaccounts
            // 
            this.buttonaccounts.BackgroundImage = global::byZyczu.Properties.Resources._2000px_User_icon_2_svg_2723136580;
            this.buttonaccounts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonaccounts.Location = new System.Drawing.Point(56, 109);
            this.buttonaccounts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonaccounts.Name = "buttonaccounts";
            this.buttonaccounts.Size = new System.Drawing.Size(40, 40);
            this.buttonaccounts.TabIndex = 8;
            this.buttonaccounts.UseVisualStyleBackColor = true;
            this.buttonaccounts.Click += new System.EventHandler(this.buttonaccounts_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("MinecraftZyczu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(80, 74);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(253, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // textBoxnick
            // 
            this.textBoxnick.Font = new System.Drawing.Font("MinecraftZyczu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxnick.Location = new System.Drawing.Point(80, 43);
            this.textBoxnick.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxnick.Name = "textBoxnick";
            this.textBoxnick.ReadOnly = true;
            this.textBoxnick.Size = new System.Drawing.Size(253, 22);
            this.textBoxnick.TabIndex = 6;
            this.textBoxnick.Text = "your_nick";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MinecraftZyczu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Wersja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MinecraftZyczu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nick:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MinecraftZyczu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Minecraft Launcher by zyczu";
            // 
            // buttonsettings
            // 
            this.buttonsettings.BackgroundImage = global::byZyczu.Properties.Resources.package_settings;
            this.buttonsettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonsettings.Location = new System.Drawing.Point(8, 109);
            this.buttonsettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonsettings.Name = "buttonsettings";
            this.buttonsettings.Size = new System.Drawing.Size(40, 40);
            this.buttonsettings.TabIndex = 2;
            this.buttonsettings.UseVisualStyleBackColor = true;
            this.buttonsettings.Click += new System.EventHandler(this.buttonsettings_Click);
            // 
            // buttonownmods
            // 
            this.buttonownmods.Location = new System.Drawing.Point(104, 109);
            this.buttonownmods.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonownmods.Name = "buttonownmods";
            this.buttonownmods.Size = new System.Drawing.Size(110, 40);
            this.buttonownmods.TabIndex = 1;
            this.buttonownmods.Text = "Paczki modów";
            this.buttonownmods.UseVisualStyleBackColor = true;
            this.buttonownmods.Click += new System.EventHandler(this.buttonownmods_Click);
            // 
            // buttonlaunch
            // 
            this.buttonlaunch.Font = new System.Drawing.Font("MinecraftZyczu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlaunch.Location = new System.Drawing.Point(227, 109);
            this.buttonlaunch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonlaunch.Name = "buttonlaunch";
            this.buttonlaunch.Size = new System.Drawing.Size(109, 40);
            this.buttonlaunch.TabIndex = 0;
            this.buttonlaunch.Text = "Uruchom grę";
            this.buttonlaunch.UseVisualStyleBackColor = true;
            this.buttonlaunch.Click += new System.EventHandler(this.buttonlaunch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(660, 458);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "1.0 C# version by maicja";
            // 
            // panelsettings
            // 
            this.panelsettings.Controls.Add(this.checkBoxreinstalljava);
            this.panelsettings.Controls.Add(this.label28);
            this.panelsettings.Controls.Add(this.label29);
            this.panelsettings.Controls.Add(this.label19);
            this.panelsettings.Controls.Add(this.checkBoxnoverify);
            this.panelsettings.Controls.Add(this.label10);
            this.panelsettings.Controls.Add(this.label11);
            this.panelsettings.Controls.Add(this.comboBoxRAM);
            this.panelsettings.Controls.Add(this.label8);
            this.panelsettings.Controls.Add(this.label7);
            this.panelsettings.Controls.Add(this.buttoncancessett);
            this.panelsettings.Controls.Add(this.buttonsavechanges);
            this.panelsettings.Controls.Add(this.label6);
            this.panelsettings.Controls.Add(this.label5);
            this.panelsettings.Location = new System.Drawing.Point(701, 25);
            this.panelsettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelsettings.Name = "panelsettings";
            this.panelsettings.Size = new System.Drawing.Size(805, 405);
            this.panelsettings.TabIndex = 2;
            // 
            // checkBoxreinstalljava
            // 
            this.checkBoxreinstalljava.AutoSize = true;
            this.checkBoxreinstalljava.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxreinstalljava.Location = new System.Drawing.Point(52, 320);
            this.checkBoxreinstalljava.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxreinstalljava.Name = "checkBoxreinstalljava";
            this.checkBoxreinstalljava.Size = new System.Drawing.Size(122, 17);
            this.checkBoxreinstalljava.TabIndex = 14;
            this.checkBoxreinstalljava.Text = "ReInstall JAVA";
            this.checkBoxreinstalljava.UseVisualStyleBackColor = false;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("MinecraftZyczu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(48, 278);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(584, 32);
            this.label28.TabIndex = 13;
            this.label28.Text = "Jeżeli zaznaczysz tą opcję, JAVA zostanie przeinstalowana przy następnym \r\nurucho" +
    "mieniu gry";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("MinecraftZyczu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(12, 253);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(151, 20);
            this.label29.TabIndex = 12;
            this.label29.Text = "ReInstall Javy";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("MinecraftZyczu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(12, 256);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 20);
            this.label19.TabIndex = 11;
            // 
            // checkBoxnoverify
            // 
            this.checkBoxnoverify.AutoSize = true;
            this.checkBoxnoverify.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxnoverify.Location = new System.Drawing.Point(52, 227);
            this.checkBoxnoverify.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxnoverify.Name = "checkBoxnoverify";
            this.checkBoxnoverify.Size = new System.Drawing.Size(92, 17);
            this.checkBoxnoverify.TabIndex = 9;
            this.checkBoxnoverify.Text = "-noverify";
            this.checkBoxnoverify.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("MinecraftZyczu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(48, 181);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(579, 32);
            this.label10.TabIndex = 8;
            this.label10.Text = "Dodaje do argumentów uruchamiania opcje \"-noverify\" dzięki czemu wyłącza\r\nweryfik" +
    "ację dodatkowych klas w wybranej wersji gry.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("MinecraftZyczu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 156);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "No verify";
            // 
            // comboBoxRAM
            // 
            this.comboBoxRAM.FormattingEnabled = true;
            this.comboBoxRAM.Location = new System.Drawing.Point(192, 120);
            this.comboBoxRAM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxRAM.Name = "comboBoxRAM";
            this.comboBoxRAM.Size = new System.Drawing.Size(120, 21);
            this.comboBoxRAM.TabIndex = 6;
            this.comboBoxRAM.Text = "2048M";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("MinecraftZyczu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 122);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Ilość pamięci RAM:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MinecraftZyczu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 79);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(541, 32);
            this.label7.TabIndex = 4;
            this.label7.Text = "Dzięki temu ustawieniu możesz przypisać ile java ma używać pamięci ram,\r\npamiętaj" +
    " żeby nie ustawiać więcej niż masz wolnej pamięci!\r\n";
            // 
            // buttoncancessett
            // 
            this.buttoncancessett.Location = new System.Drawing.Point(405, 354);
            this.buttoncancessett.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttoncancessett.Name = "buttoncancessett";
            this.buttoncancessett.Size = new System.Drawing.Size(140, 40);
            this.buttoncancessett.TabIndex = 3;
            this.buttoncancessett.Text = "Anuluj";
            this.buttoncancessett.UseVisualStyleBackColor = true;
            this.buttoncancessett.Click += new System.EventHandler(this.buttoncancessett_Click);
            // 
            // buttonsavechanges
            // 
            this.buttonsavechanges.Location = new System.Drawing.Point(260, 354);
            this.buttonsavechanges.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonsavechanges.Name = "buttonsavechanges";
            this.buttonsavechanges.Size = new System.Drawing.Size(140, 40);
            this.buttonsavechanges.TabIndex = 2;
            this.buttonsavechanges.Text = "Zapisz zmiany";
            this.buttonsavechanges.UseVisualStyleBackColor = true;
            this.buttonsavechanges.Click += new System.EventHandler(this.buttonsavechanges_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MinecraftZyczu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(336, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ustawienia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MinecraftZyczu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Pamięć ram";
            // 
            // paneldownload
            // 
            this.paneldownload.Controls.Add(this.webBrowserdownload);
            this.paneldownload.Controls.Add(this.progressBar1);
            this.paneldownload.Controls.Add(this.downloadlabel);
            this.paneldownload.Controls.Add(this.label9);
            this.paneldownload.Location = new System.Drawing.Point(826, 12);
            this.paneldownload.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.paneldownload.Name = "paneldownload";
            this.paneldownload.Size = new System.Drawing.Size(805, 405);
            this.paneldownload.TabIndex = 10;
            // 
            // webBrowserdownload
            // 
            this.webBrowserdownload.Location = new System.Drawing.Point(24, 96);
            this.webBrowserdownload.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.webBrowserdownload.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserdownload.Name = "webBrowserdownload";
            this.webBrowserdownload.ScriptErrorsSuppressed = true;
            this.webBrowserdownload.Size = new System.Drawing.Size(756, 290);
            this.webBrowserdownload.TabIndex = 3;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 72);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(772, 17);
            this.progressBar1.TabIndex = 2;
            // 
            // downloadlabel
            // 
            this.downloadlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadlabel.AutoSize = true;
            this.downloadlabel.BackColor = System.Drawing.Color.Transparent;
            this.downloadlabel.Location = new System.Drawing.Point(328, 44);
            this.downloadlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.downloadlabel.Name = "downloadlabel";
            this.downloadlabel.Size = new System.Drawing.Size(114, 13);
            this.downloadlabel.TabIndex = 1;
            this.downloadlabel.Text = "Pobieranie gry...";
            this.downloadlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("MinecraftZyczu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(275, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(285, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Trwa instalacja modów...";
            // 
            // panelmodsmain
            // 
            this.panelmodsmain.Controls.Add(this.panelmanageversions);
            this.panelmodsmain.Controls.Add(this.buttonclosemods);
            this.panelmodsmain.Controls.Add(this.comboBoxmodpacks);
            this.panelmodsmain.Controls.Add(this.panelmodpacks);
            this.panelmodsmain.Controls.Add(this.buttonmanageversions);
            this.panelmodsmain.Controls.Add(this.buttonmodpacks);
            this.panelmodsmain.Controls.Add(this.buttonmanagemods);
            this.panelmodsmain.Controls.Add(this.label16);
            this.panelmodsmain.Location = new System.Drawing.Point(19, 45);
            this.panelmodsmain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelmodsmain.Name = "panelmodsmain";
            this.panelmodsmain.Size = new System.Drawing.Size(805, 405);
            this.panelmodsmain.TabIndex = 10;
            // 
            // panelmanageversions
            // 
            this.panelmanageversions.Controls.Add(this.comboBoxmanageversions);
            this.panelmanageversions.Controls.Add(this.button7);
            this.panelmanageversions.Location = new System.Drawing.Point(12, 72);
            this.panelmanageversions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelmanageversions.Name = "panelmanageversions";
            this.panelmanageversions.Size = new System.Drawing.Size(780, 329);
            this.panelmanageversions.TabIndex = 8;
            // 
            // comboBoxmanageversions
            // 
            this.comboBoxmanageversions.Font = new System.Drawing.Font("MinecraftZyczu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxmanageversions.FormattingEnabled = true;
            this.comboBoxmanageversions.Location = new System.Drawing.Point(24, 12);
            this.comboBoxmanageversions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxmanageversions.Name = "comboBoxmanageversions";
            this.comboBoxmanageversions.Size = new System.Drawing.Size(623, 21);
            this.comboBoxmanageversions.TabIndex = 6;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(655, 11);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 23);
            this.button7.TabIndex = 4;
            this.button7.Text = "Usuń";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // buttonclosemods
            // 
            this.buttonclosemods.BackColor = System.Drawing.Color.Transparent;
            this.buttonclosemods.BackgroundImage = global::byZyczu.Properties.Resources.zamknij;
            this.buttonclosemods.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonclosemods.Location = new System.Drawing.Point(765, 42);
            this.buttonclosemods.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonclosemods.Name = "buttonclosemods";
            this.buttonclosemods.Size = new System.Drawing.Size(27, 26);
            this.buttonclosemods.TabIndex = 6;
            this.buttonclosemods.UseVisualStyleBackColor = false;
            this.buttonclosemods.Click += new System.EventHandler(this.buttonclosemods_Click);
            // 
            // comboBoxmodpacks
            // 
            this.comboBoxmodpacks.Font = new System.Drawing.Font("MinecraftZyczu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxmodpacks.FormattingEnabled = true;
            this.comboBoxmodpacks.Location = new System.Drawing.Point(439, 45);
            this.comboBoxmodpacks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxmodpacks.Name = "comboBoxmodpacks";
            this.comboBoxmodpacks.Size = new System.Drawing.Size(325, 21);
            this.comboBoxmodpacks.TabIndex = 5;
            this.comboBoxmodpacks.SelectedIndexChanged += new System.EventHandler(this.comboBoxmodpacks_SelectedIndexChanged);
            this.comboBoxmodpacks.SelectionChangeCommitted += new System.EventHandler(this.comboBoxmodpacks_SelectionChangeCommitted);
            // 
            // panelmodpacks
            // 
            this.panelmodpacks.Controls.Add(this.button3);
            this.panelmodpacks.Controls.Add(this.button2);
            this.panelmodpacks.Controls.Add(this.button1);
            this.panelmodpacks.Controls.Add(this.textboxmodpackname);
            this.panelmodpacks.Controls.Add(this.label12);
            this.panelmodpacks.Controls.Add(this.textBoxmodsmcversion);
            this.panelmodpacks.Location = new System.Drawing.Point(12, 72);
            this.panelmodpacks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelmodpacks.Name = "panelmodpacks";
            this.panelmodpacks.Size = new System.Drawing.Size(780, 329);
            this.panelmodpacks.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(668, 11);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Nowa paczka";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(605, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Usuń";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Zmień nazwę";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textboxmodpackname
            // 
            this.textboxmodpackname.Location = new System.Drawing.Point(220, 11);
            this.textboxmodpackname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textboxmodpackname.Name = "textboxmodpackname";
            this.textboxmodpackname.Size = new System.Drawing.Size(272, 21);
            this.textboxmodpackname.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MinecraftZyczu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(196, 9);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 19);
            this.label12.TabIndex = 1;
            this.label12.Text = "-";
            // 
            // textBoxmodsmcversion
            // 
            this.textBoxmodsmcversion.Enabled = false;
            this.textBoxmodsmcversion.Location = new System.Drawing.Point(16, 11);
            this.textBoxmodsmcversion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxmodsmcversion.Name = "textBoxmodsmcversion";
            this.textBoxmodsmcversion.Size = new System.Drawing.Size(180, 21);
            this.textBoxmodsmcversion.TabIndex = 0;
            // 
            // buttonmanageversions
            // 
            this.buttonmanageversions.Location = new System.Drawing.Point(261, 53);
            this.buttonmanageversions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonmanageversions.Name = "buttonmanageversions";
            this.buttonmanageversions.Size = new System.Drawing.Size(170, 23);
            this.buttonmanageversions.TabIndex = 7;
            this.buttonmanageversions.Text = "Zarządzaj wersjami";
            this.buttonmanageversions.UseVisualStyleBackColor = true;
            this.buttonmanageversions.Click += new System.EventHandler(this.buttonmanageversions_Click);
            // 
            // buttonmodpacks
            // 
            this.buttonmodpacks.Location = new System.Drawing.Point(12, 53);
            this.buttonmodpacks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonmodpacks.Name = "buttonmodpacks";
            this.buttonmodpacks.Size = new System.Drawing.Size(101, 23);
            this.buttonmodpacks.TabIndex = 3;
            this.buttonmodpacks.Text = "Paczki modów";
            this.buttonmodpacks.UseVisualStyleBackColor = true;
            this.buttonmodpacks.Click += new System.EventHandler(this.buttonmodpacks_Click);
            // 
            // buttonmanagemods
            // 
            this.buttonmanagemods.Location = new System.Drawing.Point(117, 53);
            this.buttonmanagemods.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonmanagemods.Name = "buttonmanagemods";
            this.buttonmanagemods.Size = new System.Drawing.Size(140, 23);
            this.buttonmanagemods.TabIndex = 4;
            this.buttonmanagemods.Text = "Zarządzaj modami";
            this.buttonmanagemods.UseVisualStyleBackColor = true;
            this.buttonmanagemods.Click += new System.EventHandler(this.buttonmanagemods_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("MinecraftZyczu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(267, 15);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(256, 23);
            this.label16.TabIndex = 1;
            this.label16.Text = "Stwórz paczkę modów";
            // 
            // panelcreatenewmodpack
            // 
            this.panelcreatenewmodpack.Controls.Add(this.textBoxpackcreatename);
            this.panelcreatenewmodpack.Controls.Add(this.label17);
            this.panelcreatenewmodpack.Controls.Add(this.comboBoxmodpackcreate);
            this.panelcreatenewmodpack.Controls.Add(this.label15);
            this.panelcreatenewmodpack.Controls.Add(this.button5);
            this.panelcreatenewmodpack.Controls.Add(this.button4);
            this.panelcreatenewmodpack.Controls.Add(this.label13);
            this.panelcreatenewmodpack.Controls.Add(this.label14);
            this.panelcreatenewmodpack.Location = new System.Drawing.Point(836, 454);
            this.panelcreatenewmodpack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelcreatenewmodpack.Name = "panelcreatenewmodpack";
            this.panelcreatenewmodpack.Size = new System.Drawing.Size(805, 405);
            this.panelcreatenewmodpack.TabIndex = 11;
            // 
            // textBoxpackcreatename
            // 
            this.textBoxpackcreatename.Font = new System.Drawing.Font("MinecraftZyczu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxpackcreatename.Location = new System.Drawing.Point(232, 308);
            this.textBoxpackcreatename.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxpackcreatename.Name = "textBoxpackcreatename";
            this.textBoxpackcreatename.Size = new System.Drawing.Size(348, 22);
            this.textBoxpackcreatename.TabIndex = 8;
            this.textBoxpackcreatename.Text = "Moja paczka modów";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("MinecraftZyczu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(91, 308);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(131, 19);
            this.label17.TabIndex = 7;
            this.label17.Text = "Nazwa paczki:";
            // 
            // comboBoxmodpackcreate
            // 
            this.comboBoxmodpackcreate.Font = new System.Drawing.Font("MinecraftZyczu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxmodpackcreate.FormattingEnabled = true;
            this.comboBoxmodpackcreate.Location = new System.Drawing.Point(232, 205);
            this.comboBoxmodpackcreate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxmodpackcreate.Name = "comboBoxmodpackcreate";
            this.comboBoxmodpackcreate.Size = new System.Drawing.Size(348, 24);
            this.comboBoxmodpackcreate.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("MinecraftZyczu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(32, 206);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(194, 19);
            this.label15.TabIndex = 5;
            this.label15.Text = "Wybierz wersję gry:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(709, 375);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Dalej";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(24, 375);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Anuluj";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("MinecraftZyczu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 57);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(779, 304);
            this.label13.TabIndex = 2;
            this.label13.Text = resources.GetString("label13.Text");
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("MinecraftZyczu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(216, 13);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(361, 23);
            this.label14.TabIndex = 1;
            this.label14.Text = "Tworzenie nowej paczki modów";
            // 
            // panelconsole
            // 
            this.panelconsole.Controls.Add(this.richTextBoxconsole);
            this.panelconsole.Location = new System.Drawing.Point(23, 186);
            this.panelconsole.Name = "panelconsole";
            this.panelconsole.Size = new System.Drawing.Size(394, 270);
            this.panelconsole.TabIndex = 12;
            this.panelconsole.Visible = false;
            // 
            // richTextBoxconsole
            // 
            this.richTextBoxconsole.Location = new System.Drawing.Point(4, 4);
            this.richTextBoxconsole.Name = "richTextBoxconsole";
            this.richTextBoxconsole.ReadOnly = true;
            this.richTextBoxconsole.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBoxconsole.Size = new System.Drawing.Size(387, 262);
            this.richTextBoxconsole.TabIndex = 0;
            this.richTextBoxconsole.Text = "";
            // 
            // panelaccounts
            // 
            this.panelaccounts.Controls.Add(this.buttondeleteonline);
            this.panelaccounts.Controls.Add(this.buttondeleteoffline);
            this.panelaccounts.Controls.Add(this.comboBoxpremiumaccounts);
            this.panelaccounts.Controls.Add(this.buttonloginpremium);
            this.panelaccounts.Controls.Add(this.label27);
            this.panelaccounts.Controls.Add(this.buttonaddaccountpremium);
            this.panelaccounts.Controls.Add(this.label23);
            this.panelaccounts.Controls.Add(this.label26);
            this.panelaccounts.Controls.Add(this.comboBoxloginoffline);
            this.panelaccounts.Controls.Add(this.buttonloginoffline);
            this.panelaccounts.Controls.Add(this.label22);
            this.panelaccounts.Controls.Add(this.buttonaddaccountoffline);
            this.panelaccounts.Controls.Add(this.textBoxaddnick);
            this.panelaccounts.Controls.Add(this.label21);
            this.panelaccounts.Controls.Add(this.button9);
            this.panelaccounts.Controls.Add(this.label18);
            this.panelaccounts.Controls.Add(this.label20);
            this.panelaccounts.Controls.Add(this.label24);
            this.panelaccounts.Controls.Add(this.label25);
            this.panelaccounts.Location = new System.Drawing.Point(441, 418);
            this.panelaccounts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelaccounts.Name = "panelaccounts";
            this.panelaccounts.Size = new System.Drawing.Size(805, 405);
            this.panelaccounts.TabIndex = 12;
            // 
            // buttondeleteonline
            // 
            this.buttondeleteonline.Location = new System.Drawing.Point(460, 331);
            this.buttondeleteonline.Name = "buttondeleteonline";
            this.buttondeleteonline.Size = new System.Drawing.Size(75, 29);
            this.buttondeleteonline.TabIndex = 27;
            this.buttondeleteonline.Text = "Usuń";
            this.buttondeleteonline.UseVisualStyleBackColor = true;
            this.buttondeleteonline.Click += new System.EventHandler(this.buttondeleteonline_Click);
            // 
            // buttondeleteoffline
            // 
            this.buttondeleteoffline.Location = new System.Drawing.Point(460, 158);
            this.buttondeleteoffline.Name = "buttondeleteoffline";
            this.buttondeleteoffline.Size = new System.Drawing.Size(75, 29);
            this.buttondeleteoffline.TabIndex = 26;
            this.buttondeleteoffline.Text = "Usuń";
            this.buttondeleteoffline.UseVisualStyleBackColor = true;
            this.buttondeleteoffline.Click += new System.EventHandler(this.buttondeleteoffline_Click);
            // 
            // comboBoxpremiumaccounts
            // 
            this.comboBoxpremiumaccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxpremiumaccounts.FormattingEnabled = true;
            this.comboBoxpremiumaccounts.Location = new System.Drawing.Point(103, 336);
            this.comboBoxpremiumaccounts.Name = "comboBoxpremiumaccounts";
            this.comboBoxpremiumaccounts.Size = new System.Drawing.Size(186, 21);
            this.comboBoxpremiumaccounts.TabIndex = 25;
            // 
            // buttonloginpremium
            // 
            this.buttonloginpremium.Location = new System.Drawing.Point(315, 332);
            this.buttonloginpremium.Name = "buttonloginpremium";
            this.buttonloginpremium.Size = new System.Drawing.Size(133, 29);
            this.buttonloginpremium.TabIndex = 24;
            this.buttonloginpremium.Text = "Zaloguj się";
            this.buttonloginpremium.UseVisualStyleBackColor = true;
            this.buttonloginpremium.Click += new System.EventHandler(this.buttonloginpremium_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("MinecraftZyczu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(49, 337);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(39, 16);
            this.label27.TabIndex = 23;
            this.label27.Text = "Nick:";
            // 
            // buttonaddaccountpremium
            // 
            this.buttonaddaccountpremium.Location = new System.Drawing.Point(51, 301);
            this.buttonaddaccountpremium.Name = "buttonaddaccountpremium";
            this.buttonaddaccountpremium.Size = new System.Drawing.Size(133, 29);
            this.buttonaddaccountpremium.TabIndex = 22;
            this.buttonaddaccountpremium.Text = "Dodaj konto";
            this.buttonaddaccountpremium.UseVisualStyleBackColor = true;
            this.buttonaddaccountpremium.Click += new System.EventHandler(this.buttonaddaccountpremium_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("MinecraftZyczu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(48, 241);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(646, 48);
            this.label23.TabIndex = 21;
            this.label23.Text = "Aby dodać konto premium do listy, kliknij przycisk \"dodaj konto\" i postępuj zgodn" +
    "ie z \r\ndalszymi instrukcjami.\r\nAby zalagować się na konto wybierz je z listy i k" +
    "liknij \"zaloguj się\"";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("MinecraftZyczu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(12, 209);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(147, 20);
            this.label26.TabIndex = 20;
            this.label26.Text = "Konta premium";
            // 
            // comboBoxloginoffline
            // 
            this.comboBoxloginoffline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxloginoffline.FormattingEnabled = true;
            this.comboBoxloginoffline.Location = new System.Drawing.Point(103, 162);
            this.comboBoxloginoffline.Name = "comboBoxloginoffline";
            this.comboBoxloginoffline.Size = new System.Drawing.Size(186, 21);
            this.comboBoxloginoffline.TabIndex = 19;
            // 
            // buttonloginoffline
            // 
            this.buttonloginoffline.Location = new System.Drawing.Point(315, 158);
            this.buttonloginoffline.Name = "buttonloginoffline";
            this.buttonloginoffline.Size = new System.Drawing.Size(133, 29);
            this.buttonloginoffline.TabIndex = 18;
            this.buttonloginoffline.Text = "Zaloguj się";
            this.buttonloginoffline.UseVisualStyleBackColor = true;
            this.buttonloginoffline.Click += new System.EventHandler(this.buttonloginoffline_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("MinecraftZyczu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(49, 163);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(39, 16);
            this.label22.TabIndex = 16;
            this.label22.Text = "Nick:";
            // 
            // buttonaddaccountoffline
            // 
            this.buttonaddaccountoffline.Location = new System.Drawing.Point(315, 124);
            this.buttonaddaccountoffline.Name = "buttonaddaccountoffline";
            this.buttonaddaccountoffline.Size = new System.Drawing.Size(133, 29);
            this.buttonaddaccountoffline.TabIndex = 15;
            this.buttonaddaccountoffline.Text = "Dodaj konto";
            this.buttonaddaccountoffline.UseVisualStyleBackColor = true;
            this.buttonaddaccountoffline.Click += new System.EventHandler(this.buttonaddaccountoffline_Click);
            // 
            // textBoxaddnick
            // 
            this.textBoxaddnick.Location = new System.Drawing.Point(103, 128);
            this.textBoxaddnick.Name = "textBoxaddnick";
            this.textBoxaddnick.Size = new System.Drawing.Size(186, 21);
            this.textBoxaddnick.TabIndex = 14;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("MinecraftZyczu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(49, 129);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(39, 16);
            this.label21.TabIndex = 13;
            this.label21.Text = "Nick:";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.BackgroundImage = global::byZyczu.Properties.Resources.zamknij;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.Location = new System.Drawing.Point(771, 6);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(27, 26);
            this.button9.TabIndex = 12;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("MinecraftZyczu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(12, 256);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 20);
            this.label18.TabIndex = 11;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("MinecraftZyczu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(48, 86);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(736, 32);
            this.label20.TabIndex = 8;
            this.label20.Text = "Aby dodać konto non-premium do listy, wpisz swoją nazwę poniżej i kliknij przycis" +
    "k \"dodaj konto\".\r\nAby się zalogować wybierz konto z listy i kliknij \"zaloguj się" +
    "\"";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("MinecraftZyczu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(311, 10);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(181, 23);
            this.label24.TabIndex = 1;
            this.label24.Text = "Menedżer Kont";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("MinecraftZyczu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(12, 54);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(195, 20);
            this.label25.TabIndex = 0;
            this.label25.Text = "Konta non-premium";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::byZyczu.Properties.Resources.nowetlo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(853, 478);
            this.Controls.Add(this.panelaccounts);
            this.Controls.Add(this.paneldownload);
            this.Controls.Add(this.panelcreatenewmodpack);
            this.Controls.Add(this.panelmodsmain);
            this.Controls.Add(this.panelsettings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelconsole);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("MinecraftZyczu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Minecraft Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelsettings.ResumeLayout(false);
            this.panelsettings.PerformLayout();
            this.paneldownload.ResumeLayout(false);
            this.paneldownload.PerformLayout();
            this.panelmodsmain.ResumeLayout(false);
            this.panelmodsmain.PerformLayout();
            this.panelmanageversions.ResumeLayout(false);
            this.panelmodpacks.ResumeLayout(false);
            this.panelmodpacks.PerformLayout();
            this.panelcreatenewmodpack.ResumeLayout(false);
            this.panelcreatenewmodpack.PerformLayout();
            this.panelconsole.ResumeLayout(false);
            this.panelaccounts.ResumeLayout(false);
            this.panelaccounts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonsettings;
        private System.Windows.Forms.Button buttonownmods;
        private System.Windows.Forms.Button buttonlaunch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxnick;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelsettings;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttoncancessett;
        private System.Windows.Forms.Button buttonsavechanges;
        private System.Windows.Forms.ComboBox comboBoxRAM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBoxnoverify;
        private System.Windows.Forms.Panel paneldownload;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label downloadlabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelmodsmain;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panelmodpacks;
        private System.Windows.Forms.Button buttonmodpacks;
        private System.Windows.Forms.Button buttonclosemods;
        private System.Windows.Forms.ComboBox comboBoxmodpacks;
        private System.Windows.Forms.Button buttonmanagemods;
        private System.Windows.Forms.TextBox textboxmodpackname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxmodsmcversion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelcreatenewmodpack;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxpackcreatename;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBoxmodpackcreate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.WebBrowser webBrowserdownload;
        private System.Windows.Forms.Panel panelconsole;
        private System.Windows.Forms.RichTextBox richTextBoxconsole;
        private System.Windows.Forms.Button buttonmanageversions;
        private System.Windows.Forms.Panel panelmanageversions;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox comboBoxmanageversions;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button buttonaccounts;
        private System.Windows.Forms.Panel panelaccounts;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonaddaccountoffline;
        private System.Windows.Forms.TextBox textBoxaddnick;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox comboBoxpremiumaccounts;
        private System.Windows.Forms.Button buttonloginpremium;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button buttonaddaccountpremium;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox comboBoxloginoffline;
        private System.Windows.Forms.Button buttonloginoffline;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button buttondeleteonline;
        private System.Windows.Forms.Button buttondeleteoffline;
        private System.Windows.Forms.CheckBox checkBoxreinstalljava;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
    }
}

