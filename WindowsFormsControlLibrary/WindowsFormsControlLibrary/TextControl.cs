using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;

namespace WindowsFormsControlLibrary
{
    public partial class TextControl : UserControl
    {
        public TextControl()
        {
            InitializeComponent();
        }

        public int? Number
        {
            set
            {
                checkBox.Checked = !value.HasValue;
                textBox.Text = value.ToString();
            }
            get
            {
                if (checkBox.Checked)
                {
                    return null;
                }
                else if (string.IsNullOrEmpty(textBox.Text))
                {
                    throw new Exception("Fill in a value or check a checkbox");
                }
                else
                {
                    int? number = null;
                    try
                    {
                        number = Convert.ToInt32(textBox.Text);
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    return number;
                }
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            textBox.Enabled = !checkBox.Checked;
        }

    }
}