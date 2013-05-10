namespace ToolBox.TCPListens
{
    partial class ListenerAndSender
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListenerAndSender));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.textBoxXPort = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonXStop = new DevComponents.DotNetBar.ButtonX();
            this.textBoxXSend = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxXBack = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonXListen = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.清除所有ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(629, 390);
            this.splitContainer1.SplitterDistance = 209;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.White;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Green;
            this.groupPanel1.Controls.Add(this.comboBoxEx1);
            this.groupPanel1.Controls.Add(this.buttonX1);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.textBoxXPort);
            this.groupPanel1.Controls.Add(this.buttonXStop);
            this.groupPanel1.Controls.Add(this.textBoxXSend);
            this.groupPanel1.Controls.Add(this.textBoxXBack);
            this.groupPanel1.Controls.Add(this.buttonXListen);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(629, 209);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.Style.BackColor2 = System.Drawing.SystemColors.Control;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "Server";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(20, 26);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(49, 20);
            this.labelX2.TabIndex = 7;
            this.labelX2.Text = "端口：";
            // 
            // textBoxXPort
            // 
            this.textBoxXPort.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxXPort.Border.Class = "TextBoxBorder";
            this.textBoxXPort.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxXPort.ForeColor = System.Drawing.Color.Black;
            this.textBoxXPort.Location = new System.Drawing.Point(75, 25);
            this.textBoxXPort.Name = "textBoxXPort";
            this.textBoxXPort.Size = new System.Drawing.Size(75, 21);
            this.textBoxXPort.TabIndex = 5;
            this.textBoxXPort.Text = "22222";
            // 
            // buttonXStop
            // 
            this.buttonXStop.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonXStop.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonXStop.Location = new System.Drawing.Point(75, 124);
            this.buttonXStop.Name = "buttonXStop";
            this.buttonXStop.Size = new System.Drawing.Size(75, 23);
            this.buttonXStop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonXStop.TabIndex = 4;
            this.buttonXStop.Text = "停止";
            this.buttonXStop.Click += new System.EventHandler(this.buttonXStop_Click);
            // 
            // textBoxXSend
            // 
            this.textBoxXSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxXSend.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxXSend.Border.Class = "TextBoxBorder";
            this.textBoxXSend.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxXSend.ForeColor = System.Drawing.Color.Black;
            this.textBoxXSend.Location = new System.Drawing.Point(75, 153);
            this.textBoxXSend.Name = "textBoxXSend";
            this.textBoxXSend.Size = new System.Drawing.Size(497, 21);
            this.textBoxXSend.TabIndex = 3;
            this.textBoxXSend.DoubleClick += new System.EventHandler(this.textBoxXSend_DoubleClick);
            // 
            // textBoxXBack
            // 
            this.textBoxXBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxXBack.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxXBack.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxXBack.ContextMenuStrip = this.contextMenuStrip1;
            this.textBoxXBack.ForeColor = System.Drawing.Color.Black;
            this.textBoxXBack.Location = new System.Drawing.Point(207, 3);
            this.textBoxXBack.Multiline = true;
            this.textBoxXBack.Name = "textBoxXBack";
            this.textBoxXBack.ReadOnly = true;
            this.textBoxXBack.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxXBack.Size = new System.Drawing.Size(413, 144);
            this.textBoxXBack.TabIndex = 2;
            // 
            // buttonXListen
            // 
            this.buttonXListen.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonXListen.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonXListen.Location = new System.Drawing.Point(75, 95);
            this.buttonXListen.Name = "buttonXListen";
            this.buttonXListen.Size = new System.Drawing.Size(75, 23);
            this.buttonXListen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonXListen.TabIndex = 1;
            this.buttonXListen.Text = "监听";
            this.buttonXListen.Click += new System.EventHandler(this.buttonXListen_Click);
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.White;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Green;
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel2.Location = new System.Drawing.Point(0, 0);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(629, 177);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(217)))), ((int)(((byte)(185)))));
            this.groupPanel2.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(191)))), ((int)(((byte)(139)))));
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(164)))), ((int)(((byte)(90)))));
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(74)))), ((int)(((byte)(31)))));
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 1;
            this.groupPanel2.Text = "Client";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonX1.BackgroundImage")));
            this.buttonX1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.ImageFixedSize = new System.Drawing.Size(18, 18);
            this.buttonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.buttonX1.Location = new System.Drawing.Point(591, 153);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(29, 21);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 8;
            this.buttonX1.ThemeAware = true;
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEx1.DisplayMember = "Text";
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEx1.FormattingEnabled = true;
            this.comboBoxEx1.ItemHeight = 15;
            this.comboBoxEx1.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.comboBoxEx1.Location = new System.Drawing.Point(75, 153);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(497, 21);
            this.comboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx1.TabIndex = 9;
            this.comboBoxEx1.Visible = false;
            this.comboBoxEx1.SelectionChangeCommitted += new System.EventHandler(this.comboBoxEx1_SelectionChangeCommitted);
            this.comboBoxEx1.DropDownClosed += new System.EventHandler(this.comboBoxEx1_DropDownClosed);
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "38-00-00-10-00-00-00-00-00-01-00-08-01-00-03-00";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "38-10-00-10-00-00-00-00-00-51-00-08-01-06-03-00";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清除所有ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 26);
            // 
            // 清除所有ToolStripMenuItem
            // 
            this.清除所有ToolStripMenuItem.Name = "清除所有ToolStripMenuItem";
            this.清除所有ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.清除所有ToolStripMenuItem.Text = "清除所有";
            this.清除所有ToolStripMenuItem.Click += new System.EventHandler(this.清除所有ToolStripMenuItem_Click);
            // 
            // ListenerAndSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ListenerAndSender";
            this.Size = new System.Drawing.Size(629, 390);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxXPort;
        private DevComponents.DotNetBar.ButtonX buttonXStop;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxXSend;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxXBack;
        private DevComponents.DotNetBar.ButtonX buttonXListen;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 清除所有ToolStripMenuItem;
    }
}
