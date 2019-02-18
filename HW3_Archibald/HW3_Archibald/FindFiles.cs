using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//using System.Collections;


namespace HW3_Archibald
{
    class FindFiles : CopyFile
    {
        public string[] ReturnFilePath(string st, string fType)
        {
            string[] output = null;
            string retStr = null;

            retStr = RetFiles(st, fType);
           
            if (retStr != null) {
                output = BreakUpString(retStr);
            }
            else
            {
                output[0] = "No files found,";
            }
            return output;
        }

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
                }
                //string[] directory = Directory.GetDirectories(start); 
                for (int i = 0; i < directory.Length; i++)
                {
                    retStr += RetFiles(directory[i], fileType);
                }                
            }
            catch (FieldAccessException e)
            {
                Console.WriteLine( "Can not access file, {0}", start);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine( "File path does not exist, {0}", start);
            }
            return retStr;
        }

        string[] BreakUpString(string cutter)
        {
            string[] retStr = null;
            string[] tempStr;
            int retCounter = 0;
            tempStr = cutter.Split(',').ToArray<string>();
            Array.Resize(ref retStr, tempStr.Length -1);
            for (int i =0; i< tempStr.Length; i++)
            {
                if(tempStr[i] != "")
                {
                    retStr[retCounter] = tempStr[i];
                    retCounter += 1;
                }
            }
            return retStr;
        }
    }
}
