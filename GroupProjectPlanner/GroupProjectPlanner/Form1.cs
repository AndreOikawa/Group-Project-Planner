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
    public partial class Form1 : Form
    {
        Model m;

        public Form1()
        {
            InitializeComponent();
            m = new Model();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitUsers();
        }

        public void InitUsers()
        {
            var users = m.GetUsers();
            int len = users.Count;
            Object[] objs = new Object[len];
            for (int i = 0; i < len; i++)
            {
                objs[i] = users[i];
            }
            cmbUsers.Items.Clear();
            cmbUsers.Items.AddRange(objs);
            cmbUsers.SelectedItem = "Anonymous";
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            NewUser form2 = new NewUser(this);
            form2.Show();
       
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            if (cmbUsers.Text == "Anonymous")
            {
                MessageBox.Show("Cannot remove Anonymous");
            } else
            {
                m.RemoveUser(cmbUsers.Text);
                InitUsers();
            }
        }

        private void btnAddDefined_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("clicked");
            NewItem form2 = new NewItem(this);
            form2.Show();
        }


        public bool AddUser(string name)
        {
            return m.AddUser(name);
        }
        public void AddItem(string name, string info)
        {
            m.AddItem("defined", name, info, cmbUsers.SelectedText);
        }
    }
}
