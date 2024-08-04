using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace HW3_Archibald
{
    class CopySpecifiedFiles : CopyFile
    {
        public string CopyFile(string[] directoryLocation)
        {
            string output = null;
            string filePath = @CurrentFilePath() ;
            string desiredFilePath = filePath + @"\CopiedFiles\";            
            
            //Creates a file if none exists.
               System.IO.Directory.CreateDirectory(desiredFilePath);
            
            //Coppies every file that has been found matching the type of file requested under the folder input.
            for (int i = 0; i < directoryLocation.Length; i++)
            {
                if (directoryLocation[i] != "No files found")
                {
                    try
                    {//Copies the files to the specified directory.
                        File.Copy(directoryLocation[i], desiredFilePath + @"\\" + ReturnFileName(directoryLocation[i]), true);
                    }
                    catch (FieldAccessException e)
                    {
                        Console.WriteLine("Unable to copy {0}", directoryLocation[i]);
                    }
                }
            }
            if (directoryLocation[0] == "No files found")
            {
                output = "No files found to copy";
            }
            else
            {
                output = desiredFilePath;
            }
            
            return output;
        }

        //Returns the current filepath of the program.
        private string CurrentFilePath()
        {
            string output;
            output = @Environment.CurrentDirectory;
            return output;
        }
        //I didn't return the names of the files just the location.
        //This takes the last part of the location which is the file name and copies it, so that it can be used to copy the file.
        private string ReturnFileName(string cutFileName)
        {
            string[] splitName = null;
            string retName = null;
            splitName = cutFileName.Split('\\').ToArray<string>();
            for(int i = 0; i< splitName.Length; i++)
            {
                if(i == (splitName.Length - 1))
                {
                    retName = splitName[i];
                }                
            }
            return retName;
        }
    }
}
