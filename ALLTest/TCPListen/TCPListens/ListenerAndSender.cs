using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ToolBox.TCPListens
{
    public partial class ListenerAndSender : UserControl
    {
        public ListenerAndSender()
        {
            InitializeComponent();
            groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
        }
    }
}
