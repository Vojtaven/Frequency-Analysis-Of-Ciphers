using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frequency_Analysis_Of_Ciphers
{
    public partial class Form1 : Form
    {
        TreeViewFiller treeViewFiller;
        public Form1()
        {
            InitializeComponent();
            treeViewFiller = new TreeViewFiller(this);
        }

        private void tbIN_TextChanged(object sender, EventArgs e)
        {
            tbOut.Text = "";
            foreach (char item in tbIN.Text)
            {
                if (item == ' ')
                    tbOut.Text += ' ';
                else if(item == ',')
                    tbOut.Text += ',';
                else if(item == '.')
                    tbOut.Text += '.';
                else if (item == ';')
                    tbOut.Text += ';';
                else if (item == '-')
                    tbOut.Text += '-';
                else
                    tbOut.Text += '*';
            }
        }
    }
}
