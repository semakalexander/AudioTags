using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CsQuery;
using System.Net;
using System.Diagnostics;
using System.Collections.Generic;
using AudioTags.Models;

namespace AudioTags
{
    public partial class Form1 : Form
    {
        Stopwatch sw = new Stopwatch();
        const string url = "http://www.songlyrics.com"; //Site with lyrics

        public Form1()
        {
            InitializeComponent();
        }

        private void openDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {                     
            string path = null;
            using (var dialog = new FolderBrowserDialog())
                if (dialog.ShowDialog() == DialogResult.OK)
                {                    
                    path = dialog.SelectedPath;
                    sw.Start();
                    List<AudioFile> list = new List<AudioFile>();
                    DirectoryInfo dir = new DirectoryInfo(path);
                    foreach (FileInfo file in dir.GetFiles("*.mp3"))
                    {
                        TagLib.File audio = TagLib.File.Create(file.FullName);
                        audio.Tag.Lyrics = GetLyrics(audio.Tag.Title, audio.Tag.FirstPerformer);
                        audio.Save();
                        AudioFile af = new AudioFile
                        {                            
                            Title = audio.Tag.Title,
                            Author = audio.Tag.FirstPerformer,
                            Lyrics = audio.Tag.Lyrics
                        };
                        list.Add(af);
                    }
                    dataGridViewAudioFiles.DataSource = list;
                    sw.Stop();
                    MessageBox.Show("done" + sw.Elapsed);
                }
        }

        private string GetLyrics(string Title, string Author)
        {
            string lyrics = null;
            try
            {
                Title = Title.Replace(' ', '-');
                Author = Author.Replace(' ', '-');
                Uri uri = new Uri($"{url}/{Author}/{Title}-lyrics/");
                string html = new WebClient().DownloadString(uri);

                CQ cq = CQ.Create(html);
                var p = cq.Find("#songLyricsDiv");
                if (p.Text().Length > Title.Length)
                    lyrics = p.Text();
                else
                    throw new Exception();
            }
            catch
            {
                richTextBoxErrorSongs.Text += $"{Author} - {Title} error\n";
            }
            return lyrics;
        }

    }
}
