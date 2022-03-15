using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinDirectory
{
    internal class WinDirectory
    {
        static void Main(string[] args)
        {
            string path = @"C:\GBEducation", indent = " ";
            CatalogInfo(path,indent);


        }

         static void CatalogInfo (string path, string indent = "")
        {
            DirectoryInfo catalog = new DirectoryInfo(path);   
            DirectoryInfo[] dirs = catalog.GetDirectories();
            for (int i = 0; i < dirs.Length; i++)
            {
                Console.WriteLine($"{indent}{dirs[i].Name}");
                CatalogInfo(dirs[i].FullName, indent + " ");
            }

            FileInfo[] files = catalog.GetFiles();
            for(int i = 0; i < files.Length; i++)
            {
                Console.WriteLine($"{indent}{files[i].Name}");
            }
        }
    }
}
