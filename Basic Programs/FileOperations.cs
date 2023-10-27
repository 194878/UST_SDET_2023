using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class FileOperations
    {
        public void CreateFile()
        {
            FileInfo fi = new FileInfo("C:\\Users\\Administrator\\Desktop\\File\\sample.txt");
            using StreamWriter str=fi.CreateText();
            Console.WriteLine("File has been created");
            str.WriteLine("hello there");
            str.WriteLine("Hi");
            str.WriteLine("Are you there");

        }

        public void WriteData() {
            FileStream fs = new FileStream("C:\\Users\\Administrator\\Desktop\\File\\sample2.txt", FileMode.CreateNew, FileAccess.Write);
               StreamWriter sw=new StreamWriter(fs);
            Console.WriteLine("Enter the text with"+"you want to write to the file");
            string? str=Console.ReadLine();
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            fs.Close();

        }
        public void ReadData() 
        {
            FileStream fs = new FileStream("C:\\Users\\Administrator\\Desktop\\File\\sample.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr=new StreamReader(fs);
            sr.BaseStream.Seek(3, SeekOrigin.Begin);
            string str=sr.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            sr.Close();
            fs.Close();


        }
        public void DeleteFile()
        {

            FileInfo fi = new FileInfo("C:\\Users\\Administrator\\Desktop\\File\\Sample2.txt");
            fi.Delete();
        }
        public void FileProperties()
        {
            FileInfo fileInfo = new FileInfo("C:\\Users\\Administrator\\Desktop\\File\\Sample2.txt");
            Console.WriteLine(fileInfo.FullName);
            Console.WriteLine(fileInfo.CreationTime);
            Console.WriteLine(fileInfo.LastAccessTime);
            Console.WriteLine(fileInfo.Extension);
            Console.WriteLine(fileInfo.Length.ToString());
            Console.WriteLine(fileInfo.Exists);
            Console.WriteLine(fileInfo.LastWriteTime);
        }
    }
}
