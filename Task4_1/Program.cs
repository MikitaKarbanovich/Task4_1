using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_1
{
    public class Program
    {
        static void Main()
        {
            FolderCreator folderCreator = new FolderCreator();
            folderCreator.CreateFolder();
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}