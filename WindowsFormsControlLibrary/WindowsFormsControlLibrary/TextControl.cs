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
            textBox.TextAlignChanged += (sender, e) => eventHandler?.Invoke(sender, e);
        }

        public event EventHandler eventHandler;

        /// <summary>
        /// Событие, которое вызывается при изменении элемента
        /// </summary>
        public event EventHandler SpecEvent
        {
            add { eventHandler += value; }
            remove { eventHandler -= value; }
        }

        public int? ValueTextBox
        {
            get
            {
                if (CheckValueInt())
                {
                    labelError.BackColor = Color.Green;
                    return (Convert.ToInt32(textBox.Text));
                }
                else
                {
                    labelError.BackColor = Color.Red;
                    return (null);
                }
            }
            set
            {
                if (CheckValueInt())
                {
                    labelError.BackColor = Color.Green;
                    return;
                }
                ValueTextBox = Convert.ToInt32(textBox.Text);
                textBox.Text = value.ToString();
                 labelError.BackColor = Color.Red;
            }
        }

        private bool CheckValueInt()
        {
            return (int.TryParse(textBox.Text.ToString(), out int value) ? true : false);
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                textBox.ReadOnly = true;
                textBox.Text = null;
                textBox.BackColor = SystemColors.ScrollBar;
                labelError.BackColor = Color.Green;
            }
            else
            {
                labelError.BackColor = Color.Red;
                textBox.BackColor = SystemColors.Window;
                textBox.ReadOnly = false;
            }
            
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox.Text.ToString(), out int value))
            {
                ValueTextBox = Convert.ToInt32(textBox.Text);
            }
            else
            {
                ValueTextBox = null;
            }
        }
    }
}
