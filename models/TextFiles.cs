using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices.src.models
{
    //Class for handling all the CSV related tasks
    class TextFiles
    {
        const char delimeter = '|';

        /// <summary>
        /// Reads a text file with delimeter '|' and returns a 2 dimensional array of the information in the file
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns>List<List<Strings>> representing the full CSV Contents</returns>
        public List<List<String>> readTextFile(string path) 
        {
            List<string> allLines = System.IO.File.ReadAllLines(path).ToList<String>();
            List<List<String>> splittedLines = new List<List<string>>();
            
            foreach (string line in allLines) 
            {
                splittedLines.Add(line.Split(delimeter).ToList<String>());
            }

            return splittedLines; 
        }

        public void writeTextFile(string path, List<List<String>> data) 
        {
            List<String> allLines = new List<string>();

            foreach (List<String> singleLine in data) 
            {
                allLines.Add(String.Join(delimeter.ToString(),singleLine));
            }
            System.IO.File.WriteAllLines(path, allLines);
        }
    }
}
