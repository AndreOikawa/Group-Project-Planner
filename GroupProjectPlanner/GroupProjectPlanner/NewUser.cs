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
    public partial class NewUser : Form
    {
        private Form1 main;
        public NewUser(Form1 parent)
        {
            InitializeComponent();
            main = parent;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!(txtName.Text.Trim() == ""))
            {
                if (main.AddUser(txtName.Text))
                {
                    main.InitUsers();
                    this.Close();
                } else
                {
                    MessageBox.Show("Username already exists");
                }
            } else
            {
                MessageBox.Show("Bad Username");
            }

        }
    }
}
