using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;
using System.Collections;
using System.Data;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            var list = new List<string>();
            string startDirectory = "FolderTree";
            int index = 1;
            string fDirectory;
                //= Directory.GetFiles(@"FolderTree", ".", SearchOption.AllDirectories);
            WriteLine(pr.DirSearch(startDirectory));
            //string file in fDirectory;

            //WriteLine(pr.DirSearch( ));
        }

        string DirSearch( string start )
        {
            string output = "File does not exist.";
            
                foreach( string directory in Directory.GetDirectories(start))
                {
                    foreach (string file in Directory.GetFiles(directory, "."))
                    {
                        if(file != null) { 
                        output = directory + file;
                        }
                    }
                }
                
            return output;
        }
        
    }
}
