using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//needed imports
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MangaKaDownloader
{
    

    public partial class Form1 : Form
    {
        string lang;
        string tempPath;
        string selectedSite;

        //this is a bad solution
        public static bool singleChapterDown;

        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            this.BackColor = ColorTranslator.FromHtml("#151515");
            urlTextBox.BackColor = ColorTranslator.FromHtml("#151515");
            siteList.BackColor = ColorTranslator.FromHtml("#151515");

            
            pictureBox1.SendToBack();
            panel1.SendToBack();

            languageSwitch("ENGLISH");

            new ToolTip().SetToolTip(fastDownloadButton, "Downloads a chapter every 0.5 seconds");
            new ToolTip().SetToolTip(safeDownloadButton, "Downloads a chapter every 2.5 seconds");


        }


        private void downloadButton_Click(object sender, EventArgs e)
        {
            if (IsValidPath(tempPath))
            {
                selectedSite = siteList.Text;
                switch (selectedSite)
                {
                    //mangakakalot recently changed the html class names to the ones that manganelo uses

                    case "mangakakalot.com":
                        System.Threading.Tasks.Task.Factory.StartNew(new Action(() =>
                        {
                            mangakakalotmanganelo.mangaKakalotManganelo(urlTextBox.Text, tempPath, "class", "container-chapter-reader");
                        }));
                        break;

                    case "manganelo.com":
                        System.Threading.Tasks.Task.Factory.StartNew(new Action(() =>
                        {
                            mangakakalotmanganelo.mangaKakalotManganelo(urlTextBox.Text, tempPath, "class", "container-chapter-reader");
                        }));
                        break;
                    case "comicextra.com":
                        System.Threading.Tasks.Task.Factory.StartNew(new Action(() =>
                        {
                            comicextra.comicDown(urlTextBox.Text, tempPath);
                        }));
                        break;
                }
            }
            else
            {
                MessageBox.Show("select correct path!");
            }
        }

        private bool IsValidPath(string path, bool allowRelativePaths = false)
        {
            bool isValid = true;

            try
            {
                string fullPath = Path.GetFullPath(path);

                if (allowRelativePaths)
                {
                    isValid = Path.IsPathRooted(path);
                }
                else
                {
                    string root = Path.GetPathRoot(path);
                    isValid = string.IsNullOrEmpty(root.Trim(new char[] { '\\', '/' })) == false;
                }
            }
            catch (Exception)
            {
                isValid = false;
            }

            return isValid;
        }

        public static void pathWarn()
        {
            MessageBox.Show("Incorrect URL. Make sure you have selected site in the drop down menu!");   
        }

        private void selectPathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            

            if (browser.ShowDialog() == DialogResult.OK)
            {
                tempPath = browser.SelectedPath;
                pathLabel.Text = tempPath;
            }
        }

        private void showDestinationButton_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(tempPath);
            }
            catch
            {
                MessageBox.Show("no path detected!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mangakakalotmanganelo.downSpeed = 500;
            downSpeedLabel.Text = "Download speed: FAST";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mangakakalotmanganelo.downSpeed = 2500;
            downSpeedLabel.Text = "Download speed: SAFE";
        }

        private void siteVisitButton_Click(object sender, EventArgs e)
        {
            if (siteList.Text == String.Empty)
            {
                MessageBox.Show("You have to choose a site first");
            }
            else
            {
                System.Diagnostics.Process.Start("https://" + siteList.Text);
            }
            
        }

        bool mouseDwn;
        private Point offset;

        private void mouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDwn = true;
        }

        private void mouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDwn)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X,
                    currentScreenPos.Y - offset.Y);
            }
        }

        private void mouseUp(object sender, MouseEventArgs e)
        {
            mouseDwn = false;
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Version: something \n" +
                "------------------------ \n" +
                "Github link: https://github.com/vojjtar/MangaKatDownloader \n" +
                "------------------------ \n" +
                "Something \n" +
                "------------------------ \n");
        }

        private void czechButton_Click(object sender, EventArgs e)
        {
            languageSwitch("CZECH");
        }

        private void englishButton_Click(object sender, EventArgs e)
        {
            languageSwitch("ENGLISH");
        }

        private void languageSwitch(string language)
        {
            lang = language;

            dynamic jsonFile = JsonConvert.DeserializeObject(File.ReadAllText("language.json"));
            
            downloadButton.Text = jsonFile[language]["downloadButton"];
            pathLabel.Text = jsonFile[language]["path"];
            showDestinationButton.Text = jsonFile[language]["showDestination"];
            selectPathButton.Text = jsonFile[language]["selectPath"];
            //downSpeedLabel.Text = jsonFile[language]["downloadSpeed"];
            fastDownloadButton.Text = jsonFile[language]["fast"];
            safeDownloadButton.Text = jsonFile[language]["safe"];
            siteVisitButton.Text = jsonFile[language]["takeMetoTheSite"];

        }

        private void singleChapterCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (singleChapterCheck.Checked == true) singleChapterDown = true;
            else singleChapterDown = false;
        }
    }
}
