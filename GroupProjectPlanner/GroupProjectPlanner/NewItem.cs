using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProjectPlanner
{
    public partial class NewItem : Form
    {
        private Form1 main;
        public NewItem(Form1 parent)
        {
            InitializeComponent();
            main = parent;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("No name given.");
            }
            else if (txtInfo.Text.Trim() == "")
            {
                MessageBox.Show("No description given.");
            }
            else
            {
                main.AddItem(txtName.Text, txtInfo.Text);
                this.Close();
            }
        }
    }
}
