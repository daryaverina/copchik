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


namespace WindowsFormsControlLibrary
{
    public partial class TableControl : UserControl
    {
        public TableControl()
        {
            InitializeComponent();
        }

        public int IndexRow
        {
            get { return dataGridView.SelectedRows[0].Index; }
            set
            {
                if (dataGridView.SelectedRows.Count <= value || value < 0)
                    throw new ArgumentException(string.Format("{0} is an invalid row index.", value));
                else
                {
                    dataGridView.ClearSelection();
                    dataGridView.Rows[value].Selected = true;
                }
            }
        }

        public T GetSelectedObjectIntoRow<T>()
        {
            T objectMy = (T)Activator.CreateInstance(typeof(T));
            var propertiesObj = typeof(T).GetProperties();

            foreach (var properties in propertiesObj)
            {
                bool propIsExist = false;
                int columnIndex = 0;
                for (; columnIndex < dataGridView.Columns.Count; columnIndex++)
                {
                    if (dataGridView.Columns[columnIndex].DataPropertyName.ToString() == properties.Name)
                    {
                        propIsExist = true;
                        break;
                    }
                }
                if (!propIsExist) { throw new Exception("can not find propertie"); };
                object value = dataGridView.SelectedRows[0].Cells[columnIndex].Value;
                properties.SetValue(objectMy, value);
            }
            return objectMy;
        }

        public void ClearDataGrid()
        {
            dataGridView.DataSource = null;

        }

        public void ConfigColumn(ColumnsDataGrid columnsData)
        {
            dataGridView.ColumnCount = columnsData.CountColumn;
            for (int i = 0; i < columnsData.CountColumn; i++)
            {
                dataGridView.Columns[i].Name = columnsData.NameColumn[i];
                dataGridView.Columns[i].Width = columnsData.Width[i];
                dataGridView.Columns[i].Visible = columnsData.Visible[i];
                dataGridView.Columns[i].DataPropertyName = columnsData.PropertiesObject[i];
            }
        }

        public void FillTable<T>(List<T> obj) where T : class
        {
            int count = dataGridView.Columns.Count;
            string[] objValue = new string[count];
            
            foreach (T objItem in obj)
            {
                int j = 0;
                foreach (var prop in typeof(T).GetProperties())
                {
                    objValue[j] = prop.GetValue(objItem).ToString();
                    Console.WriteLine(prop);
                    j++;
                }
                int rowId = dataGridView.Rows.Add();
                var row = dataGridView.Rows[rowId];
                for (int i = 0; i < count; i++)
                {
                    row.Cells[i].Value = objValue[i];
                }
            }
        }

    }
}
