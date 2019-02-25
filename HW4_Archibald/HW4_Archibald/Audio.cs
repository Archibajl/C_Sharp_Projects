using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_Archibald
{
    class Audio : IMedia
    {
        public string Index { set; get; }
        public string FileName { set; get; }
        public string FileExtention { set; get; }
        public string DateLastAccessed { set; get; }
        public void Search()
        {

        }
    }
}
