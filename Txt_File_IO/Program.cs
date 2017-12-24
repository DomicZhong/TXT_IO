using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Txt_File_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"C:\Users\jhk\Desktop\test.txt";   //文件路径
            string path2 = @"C:\Users\jhk\Desktop\test1.txt";
            string[] strings;

            strings = TxtFileIO.TxtFileRead(path1);

            foreach (string str in strings)     //输出path1文件内容
            {
                Console.WriteLine(str);
            }

            TxtFileIO.TxtFileWrite(path2, strings, true); //在path2文件写入strings里的内容

            Console.ReadLine();
        }
    }
}
