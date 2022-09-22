using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormdControlLibrary;

namespace View
{
    public partial class ViewMain : Form
    {


        public ViewMain()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            List<string> list2 = new List<string>();

            list2.Add("1 line");
            list2.Add("2 line");
            list2.Add("3 line");
            list2.Add("4 line");
            list2.Add("5 line");

            myControl1.FillList(list2);
        }

        private void button_Click(object sender, EventArgs e)
        {
        }

        private void ViewMain_Load(object sender, EventArgs e)
        {

        }

        public class MyObject
        {
            public string name { get; set; }

            public int age { get; set; }
        }

        private void tableControl_Load(object sender, EventArgs e)
        {
            List<MyObject> TableList = new List<MyObject>();

            MyObject objMy = new MyObject();
            objMy.age = 9;
            objMy.name = "оля";
            TableList.Add(objMy);

            MyObject objMy2 = new MyObject();
            objMy2.age = 12;
            objMy2.name = "Таня";
            TableList.Add(objMy2);

            MyObject objMy3 = new MyObject();
            objMy3.age = 12;
            objMy3.name = "юля";
            TableList.Add(objMy3);

            ColumnsDataGrid column = new ColumnsDataGrid();
            column.CountColumn = 2;
            column.NameColumn = new string[] { "name", "age" };
            column.Width = new int[] { 80, 50 };
            column.Visible = new bool[] { true, true };
            column.PropertiesObject = new string[] { "name", "age" };
            tableControl.ConfigColumn(column);

            tableControl.FillTable(TableList);
        }

        private void ClearList_Click(object sender, EventArgs e)
        {
            myControl1.Clear();
        }
    }
}