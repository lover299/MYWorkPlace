using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.SuperGrid;
using System.Threading.Tasks;
using System.Threading;

namespace DataGridViewRowAdd
{
    public partial class Form1 : Form
    {
        private int PageItemsCount=2000;
        private int PageCount = 1;
        List<GridRow> rowss = new List<GridRow>();
        List<GridRow> rowTemp = new List<GridRow>();
        bool stop = false;
        public static ManualResetEvent WaitFill = new ManualResetEvent(true);
        public static ManualResetEvent WaitCreate = new ManualResetEvent(true);
        public static DividePage.Divide<List<DataRow>> Pages = new DividePage.Divide<List<DataRow>>();
        private int NowPage = 1;
        public static object Locker = new object();
        public static object LockerFill = new object();

        public Form1()
        {
            InitializeComponent();
            
            
        }

        public List<GridRow> GetRowsFromList(List<DataRow> data)
        {
            return data.Select(x=>new GridRow(x.T1,x.T2)).ToList();
        }

        public List<DataRow> SetRowsToList(List<GridRow> data)
        {
            return data.Select(x => new DataRow() 
            { 
                T1 = x.Cells[0].Value.ToString(), T2 = x.Cells[1].Value.ToString() 
            }
                ).ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            comboBoxEx1.Items.Add(1);
            //comboBoxEx1.Items.Add(2);
            comboBoxEx1.SelectedIndex = 0;
            Pages.TempFloder = Application.StartupPath;
            Task task1=new Task( AddRow);
            task1.Start();
            Colloction();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            //stop = (!stop);
            //throw new NotImplementedException();
        }

        void GetSelectNumber()
        {
            try
            {
               
                    this.Invoke((Action)(() =>
                        {
                            string ttttt = comboBoxEx1.Text;
                            if (ttttt == "")
                            {
                                return;
                            }
                            NowPage = int.Parse(ttttt);
                        }
                        ));
                
                //NowPage = int.Parse(comboBoxEx1.SelectedText);
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        void Colloction()
        {
             Task task = new Task(() =>
            {
                int i = 0;
                do
                {
                    GC.Collect();
                    Thread.Sleep(1000);
                } while (!stop);

            }
            );
            task.Start();
        }

        void CheckCount()
        {
            Task task = new Task(() =>
            {
                int i = 0;
                do
                {
                    if (superGridControl1.PrimaryGrid.Rows.Count>500)
                    {
                        this.Invoke((Action)(() => superGridControl1.PrimaryGrid.Rows.Clear()));
                    }
                    Thread.Sleep(5);
                } while (!stop);

            }
            );
            task.Start();
        }


        GridRow createrow(string data1, string data2)
        {
            var rows = new GridRow();
            rows.Cells.Add(new GridCell(data1));
            rows.Cells.Add(new GridCell(data2));
            return rows;
        }

        bool CheckPageIsLast()
        {
            GetSelectNumber();
            if (NowPage!=PageCount)
            {
                return false;
            }
            return true;
        }

        bool CheckPageLastOr()
        {
            GetSelectNumber();
            if (NowPage == PageCount || NowPage == PageCount - 1)
            {
                return true;
            }
            return false;
        }

        //添加页
        void PageAdd(List<GridRow> rows)
        {
            Pages.SetPage(SetRowsToList( rows), PageCount);
            PageCount++;
            this.Invoke((Action)(()=>comboBoxEx1.Items.Add(PageCount.ToString())));
        }


        void FillRow(List<GridRow> rows)
        {

            Monitor.Enter(LockerFill);
            this.Invoke((Action)(() => this.comboBoxEx1.Enabled = false));
                //if (CheckPageIsLast())
               // {
                    //WaitCreate.WaitOne();
                   // WaitCreate.Reset();
                //}
                //this.comboBoxEx1.Enabled = false;
                foreach (var item in rows)
                {
                    GridViewAddRow(item);
                }
                this.Invoke((Action)(() => this.comboBoxEx1.Enabled = true));
                Monitor.Exit(LockerFill);
                //this.comboBoxEx1.Enabled = true;
                //WaitCreate.Set();
        }

        void AddRow()
        {
            Thread.Sleep(1000);
            int i = 0;
                do
                {
                    //Thread.Sleep(2);
                    i++;
                    var row = createrow(i.ToString(), (i * 2).ToString());
//                     WaitCreate.WaitOne();
//                     WaitCreate.Reset();
                    Monitor.Enter(LockerFill);
                    this.rowss.Add(row);
                    if (CheckPageIsLast())
                    {
                        GridViewAddRow(row);
                    }
                    if (rowss.Count == PageItemsCount)
                    {
                        PageAdd(rowss);
                        rowss.Clear();
                        if (CheckPageLastOr())
                        {
                            this.Invoke((Action)(() => 
                                {
                                    superGridControl1.PrimaryGrid.Rows.Clear();
                                    comboBoxEx1.Text = PageCount.ToString();
                                }
                                ));
                        }
                    }
                    Monitor.Exit(LockerFill);
                    if (i == 1000000)
                    {
                        break;
                    }
                    //WaitCreate.Set();
                    //GC.WaitForPendingFinalizers();
                } while (!stop);
        }

        void GridViewAddRow(GridRow rows)
        {

                if (this.InvokeRequired)
                {
                    this.Invoke((Action)(() => 
                        {
                        this.superGridControl1.PrimaryGrid.Rows.Add(rows);
                        rows.EnsureVisible(false);
                        }
                        
                        ));
                    

                }
                else
                {
                    this.superGridControl1.PrimaryGrid.Rows.Add(rows);
                    rows.EnsureVisible(false);
                }
        }

        void FillRows(List<GridRow> row)
        {
            Task task = new Task(()=>FillRow(row));
            task.Start();
        }

        private void comboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CheckPageIsLast())
            {
                 FillRows(this.rowss);
            }
            else
            {
                var rows =GetRowsFromList( Pages.GetPage(int.Parse(comboBoxEx1.Text)));
                superGridControl1.PrimaryGrid.Rows.Clear();
                FillRows(rows);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Pages.Dispose();
        }
    }


    [Serializable]
    public class DataRow
    {
        public string T1 { get; set; }
        public string T2 { get; set; }
    }

}
