using System;
using System.Collections.Generic;
using System.IO;

namespace Camera_Purge
{
    class SourceHandler
    {
        public string fileHandler(string source_fol, string destFoto_fol, string destVideo_fol)
        {
            string ausgabe = "";
            if (Directory.Exists(source_fol) && Directory.Exists(destFoto_fol) && Directory.Exists(destVideo_fol))
            {

                // Variablen
                var files = GetAllFiles(source_fol);

                foreach (var file in files)
                {
                    // Variablen
                    string extension = Path.GetExtension(file).ToUpper();
                    string fileName = Path.GetFileName(file);
                    DateTime fileCreated = File.GetLastWriteTime(file);
                    string destPathFoto = destFoto_fol + "\\" + fileCreated.Year + "\\" + fileCreated.ToString("MM") + "\\" + fileCreated.ToString("yyyy-MM-dd") + "\\" + fileName;
                    string destPathVideo = destVideo_fol + "\\" + fileCreated.Year + "\\" + fileCreated.ToString("MM") + "\\" + fileCreated.ToString("yyyy-MM-dd") + "\\" + fileName;


                    if (extension.Contains("CR2") || extension.Contains("DNG") || extension.Contains("JPG") || extension.Contains("PNG") || extension.Contains("GIF") || extension.Contains("JPEG"))
                    {
                        //ausgabe += file.ToString() + Environment.NewLine;
                        //ausgabe += "Foto" + Environment.NewLine;
                        //ausgabe += fileCreated.ToString() + Environment.NewLine;
                        //ausgabe += fileName + Environment.NewLine;

                        //ausgabe += "Jahr:" + fileCreated.Year + Environment.NewLine;
                        //ausgabe += "Monat:" + fileCreated.Month + Environment.NewLine;
                        //ausgabe += "Tag:" + fileCreated.ToString("yyyy-MM-dd") + Environment.NewLine;

                        ausgabe += file + Environment.NewLine;
                        ausgabe += destPathFoto + Environment.NewLine;
                        string pathToCreate = Path.GetDirectoryName(destPathFoto);
                        ausgabe += "Ziel:" + pathToCreate + Environment.NewLine;
                        // Scharf
                        if (!FileCopy(file, destPathFoto))
                        {
                            //MessageBox.Show("ERROR=The file: " + file + " could not be copied.");
                        }

                    }
                    if (extension.Contains("MP4") || extension.Contains("MOV") || extension.Contains("M4V"))
                    {
                        //ausgabe += file.ToString() + Environment.NewLine;
                        //ausgabe += "Video" + Environment.NewLine;
                        
                        ausgabe += file + Environment.NewLine;
                        ausgabe += destPathVideo + Environment.NewLine;
                        string pathToCreate = Path.GetDirectoryName(destPathVideo);
                        ausgabe += "Ziel:" + pathToCreate + Environment.NewLine;

                        // Scharf
                        if (!FileCopy(file, destPathVideo))
                        {
                            //MessageBox.Show("ERROR=The file: " + file + " could not be copied.");
                        }

                    }
                    extension = null;
                }
            }
            //System.Windows.Forms.MessageBox.Show(ausgabe);
            return ausgabe;
        }

        public List<string> GetAllFiles(string sDirt)
        {
            List<string> files = new List<string>();

            try
            {
                foreach (string file in Directory.GetFiles(sDirt))
                {
                    files.Add(file);
                }
                foreach (string fl in Directory.GetDirectories(sDirt))
                {
                    files.AddRange(GetAllFiles(fl));
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }



            return files;
        }

       public bool FileCopy (string SourPath, string DestPath)
        {
            bool rueckgabewert = false;
            string pathToCreate = Path.GetDirectoryName(DestPath);
            try
            {
                if (!Directory.Exists(pathToCreate))
                {
                    Directory.CreateDirectory(pathToCreate);
                }
                File.Copy(SourPath, DestPath, false);
                rueckgabewert = true;
            }
            catch (Exception)
            {
                rueckgabewert = false;
            }
            
            return rueckgabewert;
        }
    }
}
