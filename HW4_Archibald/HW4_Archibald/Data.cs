using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW4_Archibald
{
    public class Data<T>
    {
        private Data<T> Node = new Data<T>();

        Data<T> FwdNode { get; set; }
        Data<T> RevNode { get; set; }
        Data<string> Index { get; set; }
        Data<string> FileName { get; set; }
        Data<string> FileExtention { get; set; }
        Data<string> DateAccessed { get; set; }
        


        public Data()
        {
            
            this.Node = new Data<T>();
            FwdNode = null;
            RevNode = null;
        }

        public void AddNode(T newLocation)
        {
            if(this.FwdNode == null)
            {
                
            }
            
        }

        void Add(string index, string fName, string fExt, string dateAcc)
        {
            
        }

        public void DeleteNode(T e)
        {
            if (FwdNode != null)
            {
                this.Node = RevNode;
                FwdNode = null;
            }else
            {
                Object temp;
                temp = FwdNode;
                this.Node = null;

                Node = this.RevNode;
                this.FwdNode = temp;
            }

        }

        public string ReturnNodes()
        {
            if(FwdNode != null)
            {

            }
        }
    }
}
