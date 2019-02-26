using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_Archibald
{
    public interface IMedia<M>
    {        
        int[] Index { set; get; }
        string[] FileName { set; get; }
        string[] FileExtention { set; get; }
        string[] DateLastAccessed { set; get; }
        void Search();
        void PrintValues();
        void RetFileType(string[] location);
        }
}
