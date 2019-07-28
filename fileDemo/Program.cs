using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"d:\test.txt";

            if (!File.Exists(path))
            {
                StreamWriter sw = File.CreateText(path);
                sw.WriteLine("yoyoyo1");
                sw.WriteLine("yoyoyo2");
                sw.Close();
            }

            if (File.Exists(path))
            {
                StreamReader sr = File.OpenText(path);
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                sr.Close();

            }   

            if (File.Exists(path))
            {
                StreamWriter sw = File.AppendText(path);
                sw.WriteLine("yoyoyo3-appendText");
                sw.Close();

            }
        }
    }
}
