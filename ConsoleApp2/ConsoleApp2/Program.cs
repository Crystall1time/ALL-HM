using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2                                                                
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo fileInfo = new FileInfo(@"C:\temp\git.txt");
            var name = fileInfo.Name;
            var length = fileInfo.Length;
            var creationTime = fileInfo.CreationTime;
            var creationTimeUtc = fileInfo.CreationTimeUtc;

            FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite);

            byte[] guys = Encoding.Default.GetBytes("HELLO GUYS!");
            fileStream.Write(guys, 0,guys.Length);
            fileStream.Close();

            fileStream = fileInfo.Open(FileMode.Open, FileAccess.Read);
            byte[] text = new byte[fileStream.Length];
            fileStream.Read(text, 0, (int)fileStream.Length);
            fileStream.Close();

            Console.WriteLine(Encoding.Default.GetChars(text));
            Class1 class1 = new Class1();
            class1.GetDirectoryInfo();
            class1.GetListFiles();
            class1.createDirectory();
            Console.ReadKey();
        }
    }
}
