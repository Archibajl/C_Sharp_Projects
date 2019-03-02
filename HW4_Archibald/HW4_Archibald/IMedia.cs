using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_Archibald
{
    public interface IMedia<M>
    {          
        void Search(string directory);
        void LibraryMenu();
        void PrintValues();
        void Remove(int Index);
        }
}
