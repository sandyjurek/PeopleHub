using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.CompilerServices;

namespace PeopleHub
{
    class FileUtility
    {
        // file: static class
        // fileinfo: 'instance' class - have to new it up (does file check on installation

        //CRUD - create, read, update, delete (file now, this will be a database later)

        //    [bool canAppend]

        // iDisposable (garbage collector) -- using statement, encapsulates it nicely (DirectoryInfo: Directory)
        //when using methods, check file permissions too

  

        public static void CreateFile(string fileName1)
        {
            string filePath1 = "file.txt";
        }

        public static void WriteToFile(string fileName1)
        {
            StreamWriter writer = new StreamWriter("file.txt");
            writer.Write("Word");
            writer.WriteLine("word 2");
            writer.WriteLine("Line");
        }

        public static void ReadFile(string fileName1)
        {
            StreamReader reader = new StreamReader("file.txt");
            while (true)
            {
                string line = reader.ReadLine();
                if (line == null)
                {
                    break;
                }
            
            Console.WriteLine(line);   //prints line
            }
        }
    }
}
