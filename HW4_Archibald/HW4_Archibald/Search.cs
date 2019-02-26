using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW4_Archibald
{
    class Search
    {
        public string[] ReturnFilePath(string st, string fType)
        {
            string[] output = null;
            string retStr = null;

            retStr = RetFiles(st, fType);

            if (retStr != null)
            {
                output = BreakUpString(retStr);
            }
            else
            {
                output[0] = "No files found,";
            }
            return output;
        }

        //Returns the locations of files in a string.
        string RetFiles(string start, string fileType)
        {
            string retStr = null;
            try
            {
                string[] directory = Directory.GetDirectories(start);
                string[] firstFiles = Directory.GetFiles(start);

                for (int b = 1; b < firstFiles.Length; b++)
                {
                    if (firstFiles[b].Contains(fileType))
                    {
                        retStr += firstFiles[b] + ",";

                    }
                } //calls recursion for each file found.                
                for (int i = 0; i < directory.Length; i++)
                {
                    retStr += RetFiles(directory[i], fileType);
                }
            } //lets the user know that this file can not be accessed.
            catch (FieldAccessException )
            {
                Console.WriteLine("Can not access file, {0}", start);
            }//supposed to let the user know that there is no file here.
            catch (FileNotFoundException)
            {
                Console.WriteLine("File path does not exist, {0}", start);
            }
            return retStr;
        }
        //Returns the string in an array of strings, which are locations of each file.
        string[] BreakUpString(string cutter)
        {
            string[] retStr = null;
            string[] tempStr;
            int retCounter = 0;
            tempStr = cutter.Split(',').ToArray<string>();
            Array.Resize(ref retStr, tempStr.Length - 1);
            for (int i = 0; i < tempStr.Length; i++)
            {
                if (tempStr[i] != "")
                {
                    retStr[retCounter] = tempStr[i];
                    retCounter += 1;
                }
            }
            return retStr;
        }
    }
}
