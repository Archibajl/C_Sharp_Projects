using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace HW4_Archibald
{
    class Data<T> : IEnumerable<T>
    {
        Data<T> dList = new Data<T>();
        //Data<int> FwdNode = null;
        //Data<int> PrevNode = null;
        //ICollection<int> Index = new ICollection<int>();
        //private string Index;
        //private Data<T>[] Files;
        //Data<>[] Calls(){
        public string FileDirectory { get; set; }
        public string FileName { get; set; }
        public string FileExtention { get; set; }
        public string DateAccessed { get; set; }
        
        public IEnumerator<T> GetEnumerator()
        {
            foreach(T d in dList)
            {
                yield return d;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return dList.GetEnumerator();
        }

         void Delete(T data)
        {
            dList.Delete(data);
        }

        void Add(T data)
        {
            dList.Add(data);
        }
    //    Data<T>(struct)
    //    {
    //        FwdNode = null;
    //        PrevNode = null;
    //        List<int> Index = new List<int>();
    //}

    //void Insert(string[] fileName, string[] fileExtention, string[] dateAccessed)
    //    {             
    //            for (int i = 0; i < fileName.Length; i++) {
    //            FileName = fileName[i];
    //            FileExtention = fileExtention[i];
    //            DateAccessed = dateAccessed[i];
    //            Files[i] = new Data<T>();
    //        }
    //        }
            //FileExtention = fileExtention;
            //DateAccessed = dateAccessed;
        //}
        
        //public void DeleteNode(int index)
        //{
        //    Files[index] 
        //}

        //public void ReturnNodes(int ind, ref string index, ref string fileName, ref string fileExt, ref string dateAcc)
        //{
        //        index = Index;
        //        fileName = FileName;
        //        fileExt = FileExtention;
        //        dateAcc = DateAccessed;          
        //}
    }
}
