using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProjectPlanner
{
    class Item:Panel
    {
        int Id;
        string ItemName;
        string Info;
        string Owner;

        Label lblId, lblName, lblInfo, lblOwner;

        public Item(int id, string name, string info, string owner)
        {
            Id = id;
            ItemName = name;
            Info = info;
            Owner = owner;

            lblId = new Label
            {
                Text = Id.ToString(),
                Dock = DockStyle.Top
            };

            lblName = new Label
            {
                Text = ItemName,
                Dock = DockStyle.Top
            };

            lblInfo = new Label
            {
                Text = Info,
                Dock = DockStyle.Top
            };

            lblOwner = new Label
            {
                Text = Owner,
                Dock = DockStyle.Top
            };

            this.Controls.Add(lblId);
            this.Controls.Add(lblName);
            this.Controls.Add(lblInfo);
            this.Controls.Add(lblOwner);
        }
    }
}
