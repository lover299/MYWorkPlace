using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace ToolBox
{
    public partial class TabTest : DevComponents.DotNetBar.OfficeForm
    {
        SuperTabItem item = new SuperTabItem() { Name="iii",Text="TEST"};
        SuperTabControlPanel panel = new SuperTabControlPanel() {Name="qqq" };
        private DevComponents.DotNetBar.SuperTabControl superTabControl1=new SuperTabControl();
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1=new SuperTabControlPanel();
        private DevComponents.DotNetBar.SuperTabItem superTabItem1=new SuperTabItem();

        public TabTest()
        {
            InitializeComponent();

            
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).BeginInit();
           this.superTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // superTabControl1
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl1.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl1.ControlBox.MenuBox.Name = "";
            this.superTabControl1.ControlBox.Name = "";
            this.superTabControl1.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl1.ControlBox.MenuBox,
            this.superTabControl1.ControlBox.CloseBox});
            this.superTabControl1.Controls.Add(this.superTabControlPanel1);
            this.superTabControl1.Location = new System.Drawing.Point(39, 44);
            this.superTabControl1.Name = "superTabControl1";
            this.superTabControl1.ReorderTabsEnabled = true;
            this.superTabControl1.SelectedTabFont = new System.Drawing.Font("ËÎÌו", 9F, System.Drawing.FontStyle.Bold);
            this.superTabControl1.SelectedTabIndex = 0;
            this.superTabControl1.Size = new System.Drawing.Size(412, 273);
            this.superTabControl1.TabFont = new System.Drawing.Font("ËÎÌו", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.superTabControl1.TabIndex = 0;
            this.superTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem1});
            this.superTabControl1.Text = "superTabControl1";
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.superTabControlPanel1;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Text = "superTabItem1";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 24);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(412, 249);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.superTabItem1;
            // 
            // TabTest
            // 
            this.ClientSize = new System.Drawing.Size(676, 410);
            this.Controls.Add(this.superTabControl1);
            this.Name = "TabTest";
            this.Text = "TabTest";
            
            this.superTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);












            item.AttachedControl =this. panel;
            item.GlobalItem = false;
            

            panel.TabItem = item;
            panel.TabIndex = 2;
            panel.Dock = DockStyle.Fill;
            panel.Size = new System.Drawing.Size(412, 249);
            panel.Location = new System.Drawing.Point(0, 24);
            panel.Controls.Add(new Button() {Text="22" });

            superTabControl1.Controls.Add(panel);
            superTabControl1.Tabs.Add(item);

            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).EndInit();

        }
    }
}