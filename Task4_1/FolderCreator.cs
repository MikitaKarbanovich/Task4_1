using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_1
{
    public class FolderCreator
    {
        public void CreateFolder()
        {
            string PATH_TO_READ_FILE = @"D:\new7.txt";
            string path = string.Empty;
            string folderName = string.Empty;
            string keyboardInput = string.Empty;
            string path_FolderName = string.Empty;
            string path_FolderName_FileName = string.Empty;

            System.Console.WriteLine("Enter the path, where you want to create the folder.");
            keyboardInput = Console.ReadLine();
            while (!Directory.Exists(keyboardInput))
            {
                Console.WriteLine("Bad path, try again.");
                keyboardInput = Console.ReadLine();
            }
            path = keyboardInput;
            System.Console.WriteLine("Enter the folder name.");
            keyboardInput = Console.ReadLine();
            folderName = keyboardInput;
            path_FolderName = System.IO.Path.Combine(path, folderName);
            Directory.CreateDirectory(path_FolderName);
            string fileName = "MyNewFile.txt";

            path_FolderName_FileName = System.IO.Path.Combine(path_FolderName, fileName);

            Console.WriteLine("Path to my file: {0}\n", path_FolderName_FileName);

            if (!File.Exists(path_FolderName_FileName))
            {
                try
                {
                    string[] newlines = new String[20];
                    string[] lines = File.ReadAllLines(PATH_TO_READ_FILE);
                    int arrayBorder;
                    if (lines.Length > 20)
                    {
                        arrayBorder = 19;
                    }
                    else
                    {
                        arrayBorder = lines.Length;
                    }
                    for (int i = 0; i <= arrayBorder; i++)
                    {
                        newlines[i] = lines[i];
                    }
                    File.WriteAllLines(path_FolderName_FileName, newlines);
                }
                catch (System.IO.IOException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine("File \"{0}\" already exists.", fileName);
                return;
            }
        }
    }
}