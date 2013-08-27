using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ToolLibrary
{
    public class ToolBase
    {

        public static string Read(string path)
        {
            if (!File.Exists(path))
            {
                return "None File";
            }
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(fs, Encoding.Default);
            var result = sr.ReadToEnd();
            sr.Close();
            sr.Dispose();
            fs.Close();
            GC.Collect();
            return result;
        }

        public static void WriteNew(string log, string path)
        {
            if (path == null)
            {
                return;
            }
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            sw.WriteLine(DateTime.Now.ToString() + "------" + log);
            sw.Flush();
            sw.Close();
            sw.Dispose();
            fs.Close();
            GC.Collect();
            //Thread.Sleep(100);
        }

        public static void Write(string log, string path)
        {
            if (path == null)
            {
                return;
            }
            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            sw.WriteLine(DateTime.Now.ToString() + "------" + log);
            sw.Flush();
            sw.Close();
            sw.Dispose();
            fs.Close();
            GC.Collect();
            //Thread.Sleep(100);
        }

        public static void Write(string title, byte[] log, string path)
        {
            if (path == null)
            {
                return;
            }
            string temp = null;
            temp = "\r\n" + BitConverter.ToString(log);
            int pos = 2;
            while (true)
            {
                pos += 48;
                if (pos > temp.Length)
                    break;
                temp = temp.Insert(pos, "\r\n");
                pos += 2;
            }

            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            sw.WriteLine(DateTime.Now.ToString() + "------" + title + ":" + temp);
            sw.Flush();
            sw.Close();
            sw.Dispose();
            fs.Close();
            GC.Collect();
            //Thread.Sleep(100);

        }
    }
}
