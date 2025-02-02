﻿using SimpleDataApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_des_clients
{
    public partial class Navigation : Form
    {
        public Navigation()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens the NewCustomer form as a dialog box,
        /// which returns focus to the calling form when it is closed.
        /// </summary>
        private void btnGoToAdd_Click(object sender, EventArgs e)
        {
            Form frm = new AddClients();
            frm.Show();
        }
        /// <summary>
        /// Opens the FillorCancel form as a dialog box.
        /// </summary>

        private void btnManageClients_Click(object sender, EventArgs e)
        {
            Form frm = new ManageClients();
            frm.ShowDialog();
        }

        /// <summary>
        /// Closes the application (not just the Navigation form).
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
