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
    }
}
