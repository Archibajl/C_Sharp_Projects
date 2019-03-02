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
        string[] fileDirectory, fileName, fileExtention;
        DateTime[] dateLastAccessed;
        //Accessors.
        public string[] FileDirectory { get { return fileDirectory; } set { fileDirectory = value; } }
        public string[] FileName { get { return fileName; } set { fileName = value; } }
        public string[] FileExtention { get { return fileExtention; } set { fileExtention = value; } }
        public DateTime[] DateLastAccessed { get { return dateLastAccessed; } set { dateLastAccessed = value; } }

        //returns values from searching all directories
        public void Search(string directory, string[] fileTypes)
        {
           
            string[] retstr = null;
            //loads all filetypes into arrays.
            for (int b = 0; b < fileTypes.Length; b++)
            {
                //returns search results
                Array.Resize<string>(ref retstr, 0);
                retstr = ReturnFilePath(directory, fileTypes[b]);                                     
            }
            if (retstr != null)
            {
                //Breaks up and returns parts of the search that are nessicarry.
                //Returns file name and date last accessed.
                RetFileType(retstr);
                //Returns 
                RetFileExtention(retstr);
            }
        }

        void RetFileType(string[] location)
        {
            int tempLen = 0;
            //resizes the arrays.
            if (fileName != null)
            {
                tempLen = fileName.Length;                
                Array.Resize<string>(ref fileName, fileName.Length + location.Length);
                Array.Resize<DateTime>(ref dateLastAccessed, dateLastAccessed.Length + location.Length);                
            }
            else
            {
                Array.Resize<string>(ref fileName, location.Length);
                Array.Resize<DateTime>(ref dateLastAccessed, location.Length);                
            }
            //Inputs new characters into the arrays.
            for (int i = 0; i < location.Length; i++)
            {
                DateLastAccessed[i + tempLen] = Directory.GetLastAccessTime(location[i]);
                string[] temp = @location[i].Split('\\').ToArray();
                FileName[i + tempLen] = temp[temp.Length - 1];
            }
        }

        void RetFileExtention(string[] location)
        {
            int tempLen = 0;
            //Resizes the arrays.
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
            //Inputs required values into the arrays.
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
            //moves each value back one space to overwrite the removed value.
            for(int i = index; i < (FileName.Length -1); i++)
            {                
                FileName[i] = FileName[i + 1];
                FileExtention[i] = FileExtention[i + 1];
                FileDirectory[i] = @FileDirectory[i + 1];
                DateLastAccessed[i] = DateLastAccessed[ i + 1];
            }
            //Resizes the array to remove 1 from the length.
            Array.Resize<string>(ref fileName,  fileName.Length - 1);
            Array.Resize<string>(ref fileExtention, fileExtention.Length - 1);
            Array.Resize<string>(ref fileDirectory, fileDirectory.Length - 1);
            Array.Resize<DateTime>(ref dateLastAccessed, dateLastAccessed.Length - 1);
        }
        public void TouchIndex(int index)
        {
            //Updates the date and time accessed to the current time.
            System.IO.FileInfo fileInfo = new System.IO.FileInfo(FileDirectory[index]);
            DateTime lastWriteTime = fileInfo.LastAccessTime;
            fileInfo.LastAccessTime = DateTime.Now;
            DateLastAccessed[index] = DateTime.Now;            
        }



        public void SortName()
        {
                        
            bool sorted = false;
            if (FileName != null)
            {
                int length = FileName.Length;
                if (length > 1)
                {
                    //continues when a value in an entire itteration fails.
                    while (sorted == false)
                    {
                        {
                            int itt = length - 1;
                            sorted = true;
                            //Searches each index incrementing from front and back to swap larger values.
                            for (int i = 0; i < (length / 2); i++)
                            {
                                //Tests the first character of the string against a character on the opposite end.
                                char a = FileName[i].First<char>();
                                char b = FileName[itt].First<char>();
                                if (a > b)
                                {
                                    //Swaps values, would have been easier with an array list, but i think my call already took the spot of the array list.
                                    string temp1, temp2, temp3;
                                    DateTime temp4;
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
                                    //An itteration failed, so the program must run another check when finished.
                                    sorted = false;
                                }
                                itt--;
                            }
                        }
                    }
                    sorted = false;

                    //Runs another search and swap, this time through the whole list .
                    while (sorted == false)
                    {
                        sorted = true;
                        for (int i = 0; i < length; i++)
                        {
                            for (int b = i + 1; b < length; b++)
                            {
                                if (FileName[i].First<char>() > FileName[b].First<char>())
                                {
                                    string temp1, temp2, temp3;
                                    DateTime temp4;
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


        //Sorts via the types of files.
        public void SortFType(string[] fileType)
        {
            int length = FileName.Length;
            int index = 0;
            bool sorted = false;
            //runs a sort of loops for every file type.
            foreach (string type in fileType)
            {
                //reruns the sort every time a value changes.
                while (sorted == false)
                {
                    sorted = true;
                    //Goes through each index that still needs to be sorted.
                    for (int i = index; i < length; i++)
                    {
                        //If the file extention is the right type it swaps it with the most recent location.
                        if (type == FileExtention[i])
                            {
                            string temp1, temp2, temp3;
                            DateTime temp4;
                                temp1 = FileName[index];
                                temp2 = FileExtention[index];
                                temp3 = @FileDirectory[index];
                                temp4 = DateLastAccessed[index];
                                FileName[index] = FileName[i];
                                FileExtention[index] = FileExtention[i];
                                FileDirectory[index] = @FileDirectory[i];
                                DateLastAccessed[index] = DateLastAccessed[i];
                                FileName[i] = temp1;
                                FileExtention[i] = temp2;
                                FileDirectory[i] = @temp3;
                                DateLastAccessed[i] = temp4;
                            //increases current position to place the file type.
                                index++;
                                sorted = false;
                        }
                    }
                }
            }
        }


        //Preformes the same ordering from SortName but compares and sorts date and time last accessed.
        public void SortAccDate()
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
                                
                                if (DateLastAccessed[i]  > DateLastAccessed[itt])
                                {
                                    string temp1, temp2, temp3;
                                    DateTime temp4;
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
                                if (DateLastAccessed[i] > DateLastAccessed[b])
                                {
                                    string temp1, temp2, temp3;
                                    DateTime temp4;
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
    }
}
