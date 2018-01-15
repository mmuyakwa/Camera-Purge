using Camera_Purge.Properties;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace Camera_Purge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            source_txt.Text = Settings.Default["source_txt"].ToString();
            destinationFoto_txt.Text = Settings.Default["destinationFoto_txt"].ToString();
            destinationVideo_txt.Text = Settings.Default["destinationVideo_txt"].ToString();

            //if (Environment.MachineName.Contains("TINYROOT2"))
            //{
            //    source_txt.Text = "H:\\Testumgebung\\Source";
            //    destinationFoto_txt.Text = "H:\\Testumgebung\\Fotos";
            //    destinationVideo_txt.Text = "H:\\Testumgebung\\Videos";
            //}
        }

        public string source_fol = null;
        public string destinationFoto_fol = null;
        public string destinationVideo_fol = null;

        private void source_btn_Click(object sender, EventArgs e)
        {
            using (var SourceFolderDialog = new FolderBrowserDialog())
            {
                if (SourceFolderDialog.ShowDialog() == DialogResult.OK)
                {
                    source_txt.Text = SourceFolderDialog.SelectedPath;
                    source_fol = SourceFolderDialog.SelectedPath;
                }
            }
        }

        private void destination_btn_Click(object sender, EventArgs e)
        {
            using (var DestinationFolderDialog = new FolderBrowserDialog())
            {
                if (DestinationFolderDialog.ShowDialog() == DialogResult.OK)
                {
                    destinationFoto_txt.Text = DestinationFolderDialog.SelectedPath;
                    destinationFoto_fol = DestinationFolderDialog.SelectedPath;
                }
            }
        }

        private void run_btn_Click(object sender, EventArgs e)
        {

            info_lbl.Text = "Looks fine for now.";

            int checker = 0;
            source_fol = source_txt.Text;
            destinationFoto_fol = destinationFoto_txt.Text;
            destinationVideo_fol = destinationVideo_txt.Text;
            if ((destinationFoto_fol != null) && (destinationVideo_fol != null) && (source_fol != null))
            {
                if (Directory.Exists(destinationFoto_fol)) checker += 1;
                if (Directory.Exists(destinationVideo_fol)) checker += 1;
                if (Directory.Exists(source_fol)) checker += 1;

                if (checker != 3)
                {
                    info_lbl.Text = "Source- and/or Destination-Folder don't exist.";
                }
                else
                {
                    var handler = new SourceHandler();
                    ausgabe_txt.Text = handler.fileHandler(source_fol, destinationFoto_fol, destinationVideo_fol);

                    //backgroundWorker1.RunWorkerAsync();

                    Settings.Default["source_txt"] = source_txt.Text;
                    Settings.Default["destinationFoto_txt"] = destinationFoto_txt.Text;
                    Settings.Default["destinationVideo_txt"] = destinationVideo_txt.Text;
                    Settings.Default.Save();

                }
            }
            else
            {
                info_lbl.Text = "Source- and Destination-Folder have to be set.";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var DestinationFolderDialog = new FolderBrowserDialog())
            {
                if (DestinationFolderDialog.ShowDialog() == DialogResult.OK)
                {
                    destinationVideo_txt.Text = DestinationFolderDialog.SelectedPath;
                    destinationVideo_fol = DestinationFolderDialog.SelectedPath;
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
                        
        }
    }
}
