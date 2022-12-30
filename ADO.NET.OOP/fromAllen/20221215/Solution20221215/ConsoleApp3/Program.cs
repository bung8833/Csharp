using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //參數要寫在constructor or method?
            string path = @"d:\temp\demo.txt";
            string path2 = @"d:\temp\demo2.txt";

            string content = "Hello,Allen";
            string content2 = "Hello,Simon";

            new FileHelper(path).Save(content);
            new FileHelper(path2).Save(content2);

            var helper = new FileHelperB();
            helper.Save(path, content);
            helper.Save(path2, content2);
        }
    }

    public class FileHelper
    {
        public FileHelper(string fileName)
        {
            FileName = fileName;
        }

        public string FileName { get; }
        /// <summary>
        /// 將內容存檔
        /// </summary>
        /// <param name="content"></param>
        public void Save(string content)
        {

        }
    }
}
