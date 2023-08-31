using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoices.src.models
{
    public class FileExplorer
    {
        /// <summary>
        /// Opens a dialog box to select a file to copied from one location to the given destination folder.
        /// </summary>
        /// <param name="destinationFolder">The destination folder.</param>
        public void copyFileThroughDialogBox(string destinationFolder) 
        {
            //Let's first try to get our quote.
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = fileDialog.FileName;
                string fileName = Path.GetFileName(filePath);
                bool overwrite = true;

                File.Copy(filePath, destinationFolder + fileName, overwrite);
            }
        }

        /// <summary>
        /// Gets the subfolder names from a given parent folder path.
        /// </summary>
        /// <param name="parentFolder">The parent folder.</param>
        /// <returns>List of folders.</returns>
        public List<string> getSubfolderNames(string parentFolder) 
        {
            List<string> subfolderPaths = Directory.GetDirectories(parentFolder).ToList();
            List<string>  subfolderNames = new List<string>();
            string folderName = "";
            foreach (string folderPath in subfolderPaths)
            {
                //The outer call will get the file name which will be the last directoy name in the path.
                folderName = Path.GetFileName(folderPath);
                subfolderNames.Add(folderName);
            }

            return subfolderNames;
        }

        public List<string> getFilesInFolder(string folderPath) 
        {
            List<string> fileNames = new List<string>();
            DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);
            FileInfo[] Files = directoryInfo.GetFiles("*", SearchOption.AllDirectories);

            //int nameLength;
            foreach (FileInfo file in Files)
            {
                //nameLength = fileName.Length - 4;
                ////This is to remove the .txt extension
                //fileName = fileName.Substring(0, nameLength);
                fileNames.Add(file.Name);
            }

            return fileNames;
        }
    }
}
