namespace ToolBox.TCPListens
{
    partial class TCPListener
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupPanelListen = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.groupPanelListen);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Red;
            this.splitContainer1.Size = new System.Drawing.Size(532, 343);
            this.splitContainer1.SplitterDistance = 176;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupPanelListen
            // 
            this.groupPanelListen.BackColor = System.Drawing.Color.White;
            this.groupPanelListen.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelListen.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.groupPanelListen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanelListen.Location = new System.Drawing.Point(0, 0);
            this.groupPanelListen.Name = "groupPanelListen";
            this.groupPanelListen.Size = new System.Drawing.Size(532, 176);
            // 
            // 
            // 
            this.groupPanelListen.Style.BackColor = System.Drawing.Color.White;
            this.groupPanelListen.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanelListen.Style.BackColorGradientAngle = 90;
            this.groupPanelListen.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelListen.Style.BorderBottomWidth = 1;
            this.groupPanelListen.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuBorder;
            this.groupPanelListen.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelListen.Style.BorderLeftWidth = 1;
            this.groupPanelListen.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelListen.Style.BorderRightWidth = 1;
            this.groupPanelListen.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelListen.Style.BorderTopWidth = 1;
            this.groupPanelListen.Style.CornerDiameter = 4;
            this.groupPanelListen.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelListen.Style.TextColor = System.Drawing.Color.Black;
            this.groupPanelListen.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelListen.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanelListen.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanelListen.TabIndex = 0;
            this.groupPanelListen.Text = "Listen";
            this.groupPanelListen.MarkupLinkClick += new DevComponents.DotNetBar.MarkupLinkClickEventHandler(this.groupPanelListen_MarkupLinkClick);
            // 
            // TCPListener
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.splitContainer1);
            this.Name = "TCPListener";
            this.Size = new System.Drawing.Size(532, 343);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelListen;
    }
}
