using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar;

namespace ToolBox
{
    public partial class MainToolBox : DevComponents.DotNetBar.OfficeForm
    {
        private bool Isdrag = false;
        MouseEventArgs mouseLoc;

        public MainToolBox()
        {
            
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelEx1_MouseDown(object sender, MouseEventArgs e)
        {
            Isdrag = true;
            mouseLoc = e;
        }

        private void panelEx1_MouseUp(object sender, MouseEventArgs e)
        {
            Isdrag = false;
        }

        private void MainToolBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (Isdrag)
            {
                this.Location.Offset(new Point(e.Location.X - mouseLoc.Location.X, e.Location.Y - mouseLoc.Location.Y));
            }
        }

        private void panelEx1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Isdrag)
            {
                var temp = this.Location;
                temp .Offset(new Point(e.Location.X - mouseLoc.Location.X, e.Location.Y - mouseLoc.Location.Y));
                this.Location = temp;
            }
        }

        private void LableToolBox_MouseDown(object sender, MouseEventArgs e)
        {
            panelEx1_MouseDown(sender,e);
        }

        private void LableToolBox_MouseUp(object sender, MouseEventArgs e)
        {
            panelEx1_MouseUp(sender, e);
        }

        private void LableToolBox_MouseMove(object sender, MouseEventArgs e)
        {
            panelEx1_MouseMove(sender,e);
        }
       
    }
}
