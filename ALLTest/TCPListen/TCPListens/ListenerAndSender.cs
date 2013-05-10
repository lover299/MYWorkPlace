using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SmallP;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ToolBox.TCPListens
{
    public partial class ListenerAndSender : UserControl
    {
        public event Action<object, string> StatusChanged;
        public ListenerAndSender()
        {
            InitializeComponent();
            groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            StatusChanged += new Action<object, string>(ListenerAndSender_StatusChanged);
        }

        #region Listener
        bool Running;
        int connect = 0;
        IPAddress ipadress=IPAddress.Any;
        int port=0;

        void ListenerAndSender_StatusChanged(object arg1, string arg2)
        {
            //throw new NotImplementedException();
        }

        private void SetReceiveStatus(string Status)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((Action)(() =>
                    {
                        this.textBoxXBack.Text += (Status + Environment.NewLine);
                    }
                    ));
            }
            else
            {
                this.textBoxXBack.Text += (Status + Environment.NewLine);
            }
        }

        private byte[] GetSend()
        {
            byte[] temp = new byte[999];
            if (textBoxXSend.Text.Length != 0)
            {
                if (this.InvokeRequired)
                {
                    this.Invoke((Action)(() =>
                    {
                        temp = SmallP_LocalConfig.StringToByteArray(textBoxXSend.Text.Trim());
                    }
                        ));
                }
                else
                {
                    temp = SmallP_LocalConfig.StringToByteArray(textBoxXSend.Text.Trim());
                }

            }
            return temp;
        }

        private void ListenerE(int port)
        {
            TcpListener listener=null;
            try
            {

                 listener = new TcpListener(IPAddress.Any, port);
                ipadress =((IPEndPoint) (listener.LocalEndpoint)).Address;
                listener.Start(10);
                while (Running)
                {
                    var tempclient = listener.AcceptTcpClient();
                    SetReceiveStatus("接入:" + ((IPEndPoint)(tempclient.Client.LocalEndPoint)).Address.ToString());
                    tempclient.ReceiveTimeout = 1000;
                    var stream = tempclient.GetStream();
                    byte[] message = new byte[100];
                    stream.Read(message, 0, 100);
                    var realmessage = MessageDele(message, 6);
                    SetReceiveStatus("收:" + BitConverter.ToString(realmessage));
                    var sendmessage = MessageDele(GetSend(),6);
                    stream.Write(sendmessage, 0, sendmessage.Length);
                    SetReceiveStatus("发:" + BitConverter.ToString(sendmessage));
                    tempclient.Close();
                  
                }
                this.Invoke((Action)(() =>
                {
                    this.buttonXListen.Enabled = true;
                }
                      ));
                listener.Stop();
                
            }
            catch (Exception e)
            {
                SetReceiveStatus("错误:" + e.Message);
                this.Invoke((Action)(() =>
                {
                    this.buttonXListen.Enabled = true;
                }
                      ));
                if (listener!=null)
                {
                    listener.Stop();
                }
                
            }

        }


        private byte[] MessageDele(byte[] message, int count)
        {
            List<byte> temp = new List<byte>();
            //if (message.Count() < count)
            //{
            //    return new byte[1];
            //}
            int zerocount = 0;
            for (int i = 0; i < message.Count(); i++)
            {
                temp.Add(message[i]);
                if (message[i] == 0)
                {
                    zerocount++;
                }
                else
                {
                    zerocount = 0;
                }
                if (zerocount == count)
                {
                    temp.RemoveRange(temp.Count - count , count);
                    break;
                }
            }

            if (temp.Count != 0)
            {
                return temp.ToArray();
            }
            else
            {
                return new byte[1];
            }

        }

        private void buttonXListen_Click(object sender, EventArgs e)
        {
            //int port;
            if (int.TryParse(textBoxXPort.Text.Trim(), out port))
            {
                if (port <= 0 || port > 65535)
                {
                    MessageBox.Show("端口填写错误！");
                    return;
                }
                buttonXListen.Enabled = false;
                Running = true;
                SetReceiveStatus("监听端口:"+port.ToString());
                Thread thread = new Thread(() =>
                {
                    this.ListenerE(port);
                }
                );
                thread.IsBackground = true;
                thread.Start();

            }
            else
            {
                MessageBox.Show("端口填写错误！");
            }
        }

        private void buttonXStop_Click(object sender, EventArgs e)
        {
            Running = false;
            if (this.textBoxXPort.Text.Length != 0)
            {
                try
                {
                    TcpClient tclient = new TcpClient();
                    tclient.Connect((IPAddress)(System.Net.Dns.Resolve(System.Net.Dns.GetHostName()).AddressList.GetValue(0)), port);
                    tclient.Client.Blocking = true;
                    tclient.Client.Send(new byte[] { 0x00 });
                    tclient.Close();
                }
                catch
                {
                }
            }
            
        }
        #endregion

        private void textBoxXSend_DoubleClick(object sender, EventArgs e)
        {
            comboBoxEx1.Visible = true;
            comboBoxEx1.DroppedDown = true;
            comboBoxEx1.Items.Insert(0, textBoxXSend.Text);
            comboBoxEx1.SelectedIndex = 0;
        }

        private void comboBoxEx1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.textBoxXSend.Text = comboBoxEx1.SelectedItem.ToString();
            this.comboBoxEx1.Visible = false;
        }

        private void comboBoxEx1_DropDownClosed(object sender, EventArgs e)
        {
            comboBoxEx1.Items.RemoveAt(0);
            this.comboBoxEx1.Visible = false;
        }

        private void 清除所有ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxXBack.Clear();
        }
    }
}
