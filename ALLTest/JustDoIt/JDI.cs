using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ToolLibrary;

namespace JustDoIt
{
    public partial class JDI : Form
    {
        string path="NONE";
        string paraPath = Application.StartupPath + "\\Init.txt";
        public JDI()
        {
            InitializeComponent();
            path=ToolBase.Read(paraPath);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            ABFactory.FactoryBase fb = new ABFactory.FactoryBase();
            fb.InitAssembly(path);
        }

        private void buttonselect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "程序集文件|*.dll";
            if (ofd.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                path = ofd.FileName;
                ToolBase.WriteNew(path,paraPath);
            }
            TextBoxMessageSet("Path:"+path, false);
        }


        private void TextBoxMessageSet(string message, bool clear)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((Action)(() =>
                {
                    if (clear)
                    {
                        textBoxMessage.Clear();
                    }

                    textBoxMessage.Text += (Environment.NewLine + message);
                    textBoxMessage.SelectionStart = textBoxMessage.Text.Length;
                    textBoxMessage.SelectionLength = 0;
                    textBoxMessage.ScrollToCaret();
                }
                    ));
            }
            else
            {
                if (clear)
                {
                    textBoxMessage.Clear();
                }

                textBoxMessage.Text += (Environment.NewLine + message);
                textBoxMessage.SelectionStart = textBoxMessage.Text.Length;
                textBoxMessage.SelectionLength = 0;
                textBoxMessage.ScrollToCaret();
            }
        }
    }
}
