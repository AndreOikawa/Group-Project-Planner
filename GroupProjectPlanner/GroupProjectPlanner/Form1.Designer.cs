namespace GroupProjectPlanner
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnControl = new System.Windows.Forms.Panel();
            this.pnDisplay = new System.Windows.Forms.Panel();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.lblUsers = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDefined = new System.Windows.Forms.Label();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.btnAddDefined = new System.Windows.Forms.PictureBox();
            this.pnControl.SuspendLayout();
            this.pnDisplay.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddDefined)).BeginInit();
            this.SuspendLayout();
            // 
            // pnControl
            // 
            this.pnControl.Controls.Add(this.btnRemoveUser);
            this.pnControl.Controls.Add(this.btnAddUser);
            this.pnControl.Controls.Add(this.lblUsers);
            this.pnControl.Controls.Add(this.cmbUsers);
            this.pnControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnControl.Location = new System.Drawing.Point(0, 0);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(630, 100);
            this.pnControl.TabIndex = 0;
            // 
            // pnDisplay
            // 
            this.pnDisplay.Controls.Add(this.panel1);
            this.pnDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDisplay.Location = new System.Drawing.Point(0, 100);
            this.pnDisplay.Name = "pnDisplay";
            this.pnDisplay.Size = new System.Drawing.Size(630, 382);
            this.pnDisplay.TabIndex = 1;
            // 
            // cmbUsers
            // 
            this.cmbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(12, 37);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(121, 24);
            this.cmbUsers.TabIndex = 0;
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Location = new System.Drawing.Point(13, 13);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(81, 17);
            this.lblUsers.TabIndex = 1;
            this.lblUsers.Text = "Select User";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(139, 20);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(61, 57);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "Create User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAddDefined);
            this.panel1.Controls.Add(this.lblDefined);
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 364);
            this.panel1.TabIndex = 0;
            // 
            // lblDefined
            // 
            this.lblDefined.AutoSize = true;
            this.lblDefined.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDefined.Location = new System.Drawing.Point(0, 0);
            this.lblDefined.Name = "lblDefined";
            this.lblDefined.Size = new System.Drawing.Size(57, 17);
            this.lblDefined.TabIndex = 1;
            this.lblDefined.Text = "Defined";
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Location = new System.Drawing.Point(206, 20);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(88, 57);
            this.btnRemoveUser.TabIndex = 3;
            this.btnRemoveUser.Text = "Remove User";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // btnAddDefined
            // 
            this.btnAddDefined.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDefined.Image")));
            this.btnAddDefined.Location = new System.Drawing.Point(126, 0);
            this.btnAddDefined.Name = "btnAddDefined";
            this.btnAddDefined.Size = new System.Drawing.Size(20, 20);
            this.btnAddDefined.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnAddDefined.TabIndex = 2;
            this.btnAddDefined.TabStop = false;
            this.btnAddDefined.Click += new System.EventHandler(this.btnAddDefined_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(630, 482);
            this.Controls.Add(this.pnDisplay);
            this.Controls.Add(this.pnControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnControl.ResumeLayout(false);
            this.pnControl.PerformLayout();
            this.pnDisplay.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddDefined)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnControl;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.Panel pnDisplay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDefined;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.PictureBox btnAddDefined;
    }
}

