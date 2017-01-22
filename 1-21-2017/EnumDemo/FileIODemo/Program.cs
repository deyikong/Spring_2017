using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(File.ReadAllText("NameList.txt"));
            //File.WriteAllText("NameList.txt", "Huijie Li");
            //Console.WriteLine(File.ReadAllText("NameList.txt"));

            try
            {
                FileStream fileStream = new FileStream("NameList.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("NameList.txt"))
                {
                    string line;
                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (OutOfMemoryException e)
            {

                throw;
            }
        }
    }
}
