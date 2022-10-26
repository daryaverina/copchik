using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary
{
    public partial class ListboxControl : UserControl
    {
        public ListboxControl()
        {
            InitializeComponent();
            listBox.SelectedIndexChanged+=(sender, e)=> eventHandler?.Invoke(sender,e);
        }

        public string SelectedElement
        {
            get
            {
                if (listBox.SelectedItem == null)
                {
                    return string.Empty;
                }

                return listBox.SelectedItem.ToString();
            }
            set
            {
                listBox.SelectedItem = value;
            }
        }

        public void FillList(List<string> acceptedText)
        {
            foreach (string acceptedTextItem in acceptedText)
            {
                listBox.Items.Add(acceptedTextItem);
            }
        }

        public void Clear()
        {
            listBox.Items.Clear();
        }

        public event EventHandler eventHandler;

        public event EventHandler SpecEvent
        {
            add { eventHandler += value; }
            remove { eventHandler -= value; }
        }


        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("You selected " + SelectedElement.ToString());  
        }
    }
}
