using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class1
    {
        public void GetDirectoryInfo()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Program Files");
            Console.WriteLine($"Dir name - {directoryInfo.Name}");
            Console.WriteLine($"Dir name - {directoryInfo.CreationTime}");
            Console.ReadLine();
        }
        public void GetListFiles()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Windows");
            directoryInfo.GetFiles();
            FileInfo[] fileInfos = directoryInfo.GetFiles();
            foreach (var file in fileInfos)
            {
                Console.WriteLine(file.Name);
                Console.WriteLine(file.CreationTime);
                Console.WriteLine(file.Length);
            }
        }
        public void createDirectory()
        {
            const string NewDirectoryName = @"C:\Windows Copy";
            Directory.CreateDirectory(NewDirectoryName);
            DirectoryInfo directory = new DirectoryInfo(@"C:\Windows");
            var file = directory.GetFiles().FirstOrDefault();
            file.CopyTo(NewDirectoryName + "\\" + file.Name);
        }
    }
}
