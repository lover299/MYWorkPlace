﻿using System;
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
    public partial class Main : MetroForm
    {
        public Main()
        {
            InitializeComponent();
           // var temp = new TCPListen.TCPListen();
           // temp.Dock = DockStyle.Fill;
           // this.superTabControlPanel1.Controls.Add(temp);
            //this.CircleProgressStart();
        }

        #region 辅助函数
        public void SetStatus(string status)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((Action)(() =>
                    {
                        labelItem_status.Text = status;
                    }
                    ));
            }
            else
            {
                labelItem_status.Text = status;
            }
        }

        public void CircleProgressStart()
        {
            if (this.InvokeRequired)
            {
                this.Invoke((Action)(() =>
                {
                    circularProgressItem1.Start();
                }
                    ));
            }
            else
            {
                circularProgressItem1.Start();
            }
        }
        public void CircleProgressStop()
        {
            if (this.InvokeRequired)
            {
                this.Invoke((Action)(() =>
                {
                    circularProgressItem1.Stop();
                }
                    ));
            }
            else
            {
                circularProgressItem1.Stop();
            }
        }
        #endregion
    }
}
