
using MediaToolkit;
using MediaToolkit.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;

namespace toMp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void SaveMP3(string SaveToFolder, string VideoURL, string MP3Name)
        {
            string source = SaveToFolder;
            var youtube = YouTube.Default;
            var vid = youtube.GetVideo(VideoURL);
            string videopath = Path.Combine(source, vid.FullName);
            File.WriteAllBytes(videopath, vid.GetBytes());

            var inputFile = new MediaFile { Filename = Path.Combine(source, vid.FullName) };
            var outputFile = new MediaFile { Filename = Path.Combine(source, $"{MP3Name}.mp3") };

            using (var engine = new Engine())
            {
                engine.GetMetadata(inputFile);


                engine.Convert(inputFile, outputFile);
            }


            File.Delete(Path.Combine(source, vid.FullName));

        }

        private void SaveMP4(string SaveToFolder, string VideoURL, string MP4Name)
        {
            string source = SaveToFolder;
            var youtube = YouTube.Default;
            var vid = youtube.GetVideo(VideoURL);
            string videopath = Path.Combine(source, vid.FullName);
            File.WriteAllBytes(videopath, vid.GetBytes());

            var inputFile = new MediaFile { Filename = Path.Combine(source, vid.FullName) };
            var outputFile = new MediaFile { Filename = Path.Combine(source, $"{MP4Name}.mp4") };

            using (var engine = new Engine())
            {
                engine.GetMetadata(inputFile);


                engine.Convert(inputFile, outputFile);
            }


            File.Delete(Path.Combine(source, vid.FullName));

        }
        public static void GoToSite(string url)
        {
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = url;
            System.Diagnostics.Process.Start(psi);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string URL = txtURL.Text;
            if (URL.Equals(""))
            {
                MessageBox.Show(text: "Please enter a URL");
            }
            else
            {
                try
                {
                    GoToSite(URL);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(text: "Error: " + ex);

                    throw;
                }
            }



        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            string URL = txtURL.Text;
            string name = "";
            string path = "";

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "|*.ext|All Files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
  

            if (URL.Equals(""))
                {
                    MessageBox.Show(text: "Please enter a URL");
                }
         
                else
                {
                    try
                    {
                    saveFileDialog1.ShowDialog();
                    path = saveFileDialog1.InitialDirectory;
                    name = saveFileDialog1.FileName;
                    SaveMP3(path, URL, name);
                    MessageBox.Show(text: "Su audio se esta descargando");

                }
                catch (Exception ex)
                    {
                        MessageBox.Show(text: "Error: " + ex);

                        throw;
                    }
                }
            }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            string URL = txtURL.Text;
            string name = "";
            string path = "";

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FilterIndex = 1;


            if (URL.Equals(""))
            {
                MessageBox.Show(text: "Please enter a URL");
            }

            else
            {
                try
                {
                    saveFileDialog1.ShowDialog();
                    path = saveFileDialog1.InitialDirectory;
                    name = saveFileDialog1.FileName;
                    SaveMP4(path, URL, name);
                    MessageBox.Show(text: "Su video se esta descargando");


                }
                catch (Exception ex)
                {
                    MessageBox.Show(text: "Error: " + ex);

                    throw;
                }
            }
        }
    }
}
