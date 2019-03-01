using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace HW4_Archibald
{
    class Data<T> : Search
    {
        //Data<T> dList = new Data<T>();
        string[] fileDirectory, fileName, fileExtention, dateLastAccessed;
        
        public string[] FileDirectory { get { return fileDirectory; } set { fileDirectory = value; } }
        public string[] FileName { get { return fileName; } set { fileName = value; } }
        public string[] FileExtention { get { return fileExtention; } set { fileExtention = value; } }
        public string[] DateLastAccessed { get { return dateLastAccessed; } set { dateLastAccessed = value; } }

        

        public void Search(string directory, string[] fileTypes)
        {
           
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

                    if (retstr != null)
                    {                        
                        RetFileType(retstr);
                        RetFileExtention(retstr);
                        fileDirectory = retstr;
                    }
                    tempLen = 0;
                    //if (FileName != null)
                    //{
                    //    tempLen = fileExtention.Length;
                    //    Array.Resize<int>(ref index, index.Length + temp.Length);
                    //}
                    //else
                    //{
                    //    Array.Resize<int>(ref index, temp.Length);
                }                
            }
        }

        public void RetFileType(string[] location)
        {
            int tempLen = 0;
            if (fileName != null)
            {
                tempLen = fileName.Length;
                Array.Resize<string>(ref fileName, fileName.Length + location.Length);
                Array.Resize<string>(ref dateLastAccessed, dateLastAccessed.Length + location.Length);
            }
            else
            {
                Array.Resize<string>(ref fileName, location.Length);
                Array.Resize<string>(ref dateLastAccessed, location.Length);
            }

            for (int i = 0; i < location.Length; i++)
            {
                DateLastAccessed[i] = Convert.ToString(Directory.GetLastAccessTime(location[i]));
                //string[] temp;
                string[] temp = @location[i].Split('\\').ToArray();
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
                Array.Resize<string>(ref fileExtention, location.Length);
            }
            for (int i = 0; i < location.Length; i++)
            {
                string[] temp;
                temp = location[i].Split('.').ToArray<string>();
                FileExtention[i + tempLen] = temp[temp.Length - 1];
            }
        }

        public void RemoveValue(int index)
        {
            for(int i = index; i < (FileName.Length -1); i++)
            {                
                FileName[i] = FileName[i + 1];
                FileExtention[i] = FileExtention[i + 1];
                FileDirectory[i] = FileDirectory[i + 1];
                DateLastAccessed[i] = DateLastAccessed[ i + 1];
            }
            Array.Resize<string>(ref fileName,  fileName.Length - 1);
            Array.Resize<string>(ref fileExtention, fileExtention.Length - 1);
            Array.Resize<string>(ref fileDirectory, fileDirectory.Length - 1);
            Array.Resize<string>(ref dateLastAccessed, dateLastAccessed.Length - 1);
        }
        
    }
}
