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
        public string[] ReturnFilePath(string start, string fileType)
        {
            string[] output = null;
            string retStr = null;

            try
            {                
                string[] directory = Directory.GetDirectories(start);
                string[] firstFiles = Directory.GetFiles(start);

                for (int b = 1; b < firstFiles.Length; b++)
                {
                    if (firstFiles[b].Contains(fileType))
                    {
                        if (retStr != null)
                        {
                            retStr += "," + firstFiles[b];
                        }else
                        { retStr +=  firstFiles[b]; }
                    }
                }
                //string[] directory = Directory.GetDirectories(start); 
                for (int i = 0; i < directory.Length; i++) {
                    string[] files = Directory.GetFiles(directory[i]);
                    for(int b = 0; b< files.Length; b++)
                    {
                        if(files[b].Contains(fileType))
                            retStr += "," + files[b] ;
                        
                    }
                }
                
            }
            catch (FieldAccessException e)
            {
                retStr += "Can not access file,";                
            }
            catch (FileNotFoundException e)
            {
                retStr += "File path does not exist,";
            }
            if (retStr != null) {
                output = BreakUpString(retStr);
            }
            else
            {
                output[0] = "No files found,";
            }
            return output;
        }

        string[] BreakUpString(string cutter)
        {
            string[] retStr;
            retStr = cutter.Split(',').ToArray<string>();
            return retStr;
        }
    }
}
