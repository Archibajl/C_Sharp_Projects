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
                Array.Resize<string>(ref retstr, 0);
                retstr = ReturnFilePath(directory, fileTypes[b]);                                     
            }
            if (retstr != null)
            {
                RetFileType(retstr);
                RetFileExtention(retstr);
            }
        }

        void RetFileType(string[] location)
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
                DateLastAccessed[i + tempLen] = Convert.ToString(Directory.GetLastAccessTime(location[i]));
                string[] temp = @location[i].Split('\\').ToArray();
                FileName[i + tempLen] = temp[temp.Length - 1];
            }
        }

        void RetFileExtention(string[] location)
        {
            int tempLen = 0;
            if (fileExtention != null)
            {
                int nlen = fileExtention.Length; 
                Array.Resize<string>(ref fileExtention, fileExtention.Length + location.Length);
                Array.Resize<string>(ref fileDirectory, fileDirectory.Length + location.Length);               
            }
            else
            {
                Array.Resize<string>(ref fileExtention, location.Length);
                Array.Resize<string>(ref fileDirectory, location.Length);                
            }

            for (int i = 0; i < location.Length; i++)
            {
                string[] temp;
                fileDirectory[i + tempLen] = location[i];
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
                FileDirectory[i] = @FileDirectory[i + 1];
                DateLastAccessed[i] = DateLastAccessed[ i + 1];
            }
            Array.Resize<string>(ref fileName,  fileName.Length - 1);
            Array.Resize<string>(ref fileExtention, fileExtention.Length - 1);
            Array.Resize<string>(ref fileDirectory, fileDirectory.Length - 1);
            Array.Resize<string>(ref dateLastAccessed, dateLastAccessed.Length - 1);
        }
        public void TouchIndex(int index)
        {
            System.IO.FileInfo fileInfo = new System.IO.FileInfo(FileDirectory[index]);
            DateTime lastWriteTime = fileInfo.LastAccessTime;
            fileInfo.LastAccessTime = DateTime.Now;
            DateLastAccessed[index] = Convert.ToString(DateTime.Now);            
        }

        public void SortName()
        {
                        
            bool sorted = false;
            if (FileName != null)
            {
                int length = FileName.Length;
                if (length > 1)
                {
                    while (sorted == false)
                    {
                        {
                            int itt = length - 1;
                            sorted = true;
                            for (int i = 0; i < (length / 2); i++)
                            {
                                char a = FileName[i].First<char>();
                                char b = FileName[itt].First<char>();
                                if (a > b)
                                {
                                    string temp1, temp2, temp3, temp4;
                                    temp1 = FileName[i];
                                    temp2 = FileExtention[i];
                                    temp3 = @FileDirectory[i];
                                    temp4 = DateLastAccessed[i];
                                    FileName[i] = FileName[itt];
                                    FileExtention[i] = FileExtention[itt];
                                    FileDirectory[i] = @FileDirectory[itt];
                                    DateLastAccessed[i] = DateLastAccessed[itt];
                                    FileName[itt] = temp1;
                                    FileExtention[itt] = temp2;
                                    FileDirectory[itt] = @temp3;
                                    DateLastAccessed[itt] = temp4;
                                    sorted = false;
                                }
                                itt--;
                            }
                        }
                    }
                    sorted = false;

                    while (sorted == false)
                    {
                        sorted = true;
                        for (int i = 0; i < length; i++)
                        {
                            for (int b = i + 1; b < length; b++)
                            {
                                if (FileName[i].First<char>() > FileName[b].First<char>())
                                {
                                    string temp1, temp2, temp3, temp4;
                                    temp1 = FileName[i];
                                    temp2 = FileExtention[i];
                                    temp3 = @FileDirectory[i];
                                    temp4 = DateLastAccessed[i];
                                    FileName[i] = FileName[b];
                                    FileExtention[i] = FileExtention[b];
                                    FileDirectory[i] = @FileDirectory[b];
                                    DateLastAccessed[i] = DateLastAccessed[b];
                                    FileName[b] = temp1;
                                    FileExtention[b] = temp2;
                                    FileDirectory[b] = @temp3;
                                    DateLastAccessed[b] = temp4;
                                    sorted = false;
                                }
                            }
                        }
                    }
                }
            }
        }

        public void SortFType(string[] extention)
        {
            bool sorted = false;
            while (sorted == false)
            {
                sorted = true;
                for (int i = 0; i < length; i++)
                {
                    for (int b = i + 1; b < length; b++)
                    {
                        if (FileName[i].First<char>() > FileName[b].First<char>())
                        {
                            string temp1, temp2, temp3, temp4;
                            temp1 = FileName[i];
                            temp2 = FileExtention[i];
                            temp3 = @FileDirectory[i];
                            temp4 = DateLastAccessed[i];
                            FileName[i] = FileName[b];
                            FileExtention[i] = FileExtention[b];
                            FileDirectory[i] = @FileDirectory[b];
                            DateLastAccessed[i] = DateLastAccessed[b];
                            FileName[b] = temp1;
                            FileExtention[b] = temp2;
                            FileDirectory[b] = @temp3;
                            DateLastAccessed[b] = temp4;
                            sorted = false;
                        }
                    }
                }
            }
        }
    }
}
