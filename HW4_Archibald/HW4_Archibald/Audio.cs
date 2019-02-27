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

        string[] fileName = null, fileExtention = null, dateLastAccessed = null;
        int[] index = null;

        public int Length;
        public int[] Index { set { index = value; } get { return index; } }
        public string[] FileName { set { fileName = value; } get { return fileName; } }
        public string[] FileExtention { set { fileExtention = value; } get { return fileExtention; } }
        public string[] DateLastAccessed { set { dateLastAccessed = value; } get { return dateLastAccessed; } }

        public void Search(string directory)
        {
            string[] fileTypes = { ".mp3", ".mp4", ".wav" };
            string[] retstr = null;

            for (int b = 0; b < fileTypes.Length; b++)
            {
                string[] temp;
                int tempLen = 0;
                retstr = ReturnFilePath(directory, fileTypes[b]);
                temp = retstr;
                if (retstr != null)
                {
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

                    RetFileType(temp);
                    RetFileExtention(temp);

                    tempLen = 0;
                    if (index != null)
                    {
                        tempLen = fileExtention.Length;
                        Array.Resize<int>(ref index, index.Length + temp.Length);
                    }
                    else
                    {
                        Array.Resize<int>(ref index, temp.Length);
                    }
                    for (int i = 0; i < retstr.Length; i++)
                    {
                        Index[i] = i;
                        da.FileName.Insert(Index[i], FileName[i]);
                        da.FileExtention.Insert(Index[i], FileExtention[i]);
                        da.DateAccessed.Insert(Index[i], DateLastAccessed[i]);
                        da.FileDirectory.Insert(Index[i], retstr[i]);
                        da = new Data<Audio>();
                        Length = i;
                    }
                }
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
            int tempLen = 0;
            if (fileName != null) {
                tempLen = fileName.Length;
                Array.Resize<string>(ref fileName, fileName.Length + location.Length);
                Array.Resize<string>(ref dateLastAccessed, dateLastAccessed.Length + location.Length);
            }else
            {
                Array.Resize<string>(ref fileName, location.Length);
                Array.Resize<string>(ref dateLastAccessed, location.Length);
            }

            for (int i =0; i < location.Length; i++)
            {
                DateLastAccessed[i] = Convert.ToString(Directory.GetLastAccessTime(location[i]));                
                string[] temp;
                temp = location[i].Split('\\').ToArray<string>();
                FileName[i] = temp[temp.Length - 1];
                                
            }
        }
        public void RetFileExtention(string[] location)
        {
            int tempLen = 0;
            if (fileExtention != null)
            {
                tempLen = fileExtention.Length;
                Array.Resize<string>(ref fileExtention, fileExtention.Length + location.Length);
            }
            else
            {
                Array.Resize<string>(ref fileExtention,  location.Length);
            }
            for (int i = 0; i < location.Length; i++)
            {
                string[] temp;
                temp = location[i].Split('.').ToArray<string>();
                FileExtention[i + tempLen] = temp[temp.Length - 1];
            }
        }
    }
}
