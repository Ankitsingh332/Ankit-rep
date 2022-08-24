
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodeLibrary
{
    public class program6
    {
        public static void FirstFile()
        {
            string path = @"D:\Mphasis 24th\exercise\MyApp\FirstFile.txt";
            File.Create(path);
        }
    }
}
