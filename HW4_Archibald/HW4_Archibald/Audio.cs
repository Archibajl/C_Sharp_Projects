using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW4_Archibald
{
    class Audio : Search, IMedia<Audio>
    {
        Data<Audio> da = new Data<Audio>();

        string[]  fileName, fileExtention, dateLastAccessed;
        int[] index;

        public int Length;
        public int[] Index { set { index = value; } get { return index; } }
        public string[] FileName { set { fileName = value; } get { return fileName; } }
        public string[] FileExtention { set { fileExtention = value; } get { return fileExtention; } }
        public string[] DateLastAccessed { set { dateLastAccessed = value; } get { return dateLastAccessed; } }

        public void Search()
        {

            string[] fileTypes = { "MP3", "MP4", "WAV" };
            string[] retstr = null;

            for (int b = 0; b < fileTypes.Length; b++) {
                string[] temp;
                int tempLen;
                temp = ReturnFilePath(fileTypes[b], fileTypes[b]);

                tempLen = retstr.Length;
                Array.Resize<string>(ref retstr, retstr.Length + temp.Length);

                for (int c = 0; c < temp.Length; c++)
                {
                    if (tempLen != 0)
                    {
                        retstr[c + tempLen] = temp[c];
                    }
                    else
                    {
                        retstr[c] = temp[c];
                    }
                }
            }

            for (int i = 0; i < retstr.Length; i++)
            {
                Index[i] = i;
                da.FileName.Insert(Index[i], FileName[i]);
                da.FileExtention.Insert(Index[i], FileExtention[i]);
                da.DateAccessed.Insert(Index[i], DateLastAccessed[i]);
                da.FileDirectory.Insert( Index[i],retstr[i]);
                da = new Data<Audio>();
                Length = i;
            }
        }
        public void PrintValues()
        {
            Console.WriteLine($"File Name: {da.FileName}\n File Extention {da.FileExtention} \n Date Last accessed {da.DateAccessed}");
            for (int i = 0; i < Length; i++)
            {                                
                Console.WriteLine($" Index: {i} \n File name: {FileName} \n File Extention: {FileExtention}\n Date Last Accessed {DateLastAccessed}");
            }            
        }
        public void RetFileType(string[] location)
        {
            for(int i =0; i < location.Length; i++)
            {
                string[] temp;
                temp = location[i].Split('/').ToArray<string>();
                FileName[i] = temp[temp.Length - 1];
                temp = location[i].Split('.').ToArray<string>();
                FileExtention[i] = temp[temp.Length - 1];
                DateLastAccessed[i] = Convert.ToString( Directory.GetLastAccessTime(location[i]));

            }
        }
    }
}
