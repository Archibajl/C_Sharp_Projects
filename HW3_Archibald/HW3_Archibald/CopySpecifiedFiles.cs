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
            //if (!Directory.Exists(desiredFilePath))
            
               System.IO.Directory.CreateDirectory(desiredFilePath);
                   // System.IO.Directory.CreateDirectory(filePath) = "CopiedFiles";
            

            for (int i = 0; i < directoryLocation.Length; i++)
            {
                try
                {
                    File.Copy( directoryLocation[i], desiredFilePath + @"\\" + ReturnFileName(directoryLocation[i]), true);
                }
                catch(FieldAccessException e)
                {
                    Console.WriteLine("Unable to copy {0}", directoryLocation[i]);
                }
            }
            output = desiredFilePath;
            return output;
        }

        private string CurrentFilePath()
        {
            string output;
            output = @Environment.CurrentDirectory;
            return output;
        }
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
