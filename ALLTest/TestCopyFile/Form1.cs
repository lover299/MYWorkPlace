using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TestCopyFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string path = Application.StartupPath+"//";


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string soursePath = path + opf.SafeFileName;
                    File.Copy(opf.FileName, soursePath);
                }
                catch (System.Exception ex)
                {
                	
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Get<int>(1);
        }

        public void Get<T>(T test)
        {


            List<T> temp = new List<T>();
            temp.Add(default(T));
            temp.Add(default(T));
            temp.Add(default(T));
            temp.Add(default(T));
            temp.Add(test);
            //temp.Add("1");
            temp.RemoveAll(x => x == null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //List<int> tem = new List<int>() { 1, 3, 5, 7, 9 };
            // tem.Reverse();
            //int[] tem2 = new int[] { 2, 4, 6, 8 };
            //var a2 = tem.Reverse<int>();
            double i1 = -13.0001;
            uint i2 = (uint)i1;
            ushort m = 1024;
            var tem = m / 1000.0;
            int i = (int)MyEnum.qqq;
            MyEnum k = (MyEnum)i;
            UInt64 p = 0x01ff;
            var temp = p >> 9;
        }
    }

    enum MyEnum:byte 
    {
        qqq=0x38,
        www
    }
}
