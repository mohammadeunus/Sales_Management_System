﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace superShopManagementSystem.forms
{ 
    public partial class adminHomePage_CheckList : Form
    {
        string querry; 
        public adminHomePage_CheckList()
        { 
            InitializeComponent();
            datashow();
        }
        private void datashow()
        {
            Connection CN = new Connection();
            if (radioButtonclassBase.optionRadio == ENUMsalesManORmanager.salesMan)
            {
                //querryadmin
                querry = "SELECT * FROM salesman";
                label1.Text = "AdminPage: salesMan's List";

            }
            else
            {
                //inventory_login
                querry = "SELECT * FROM inventory_login";
                label1.Text = "AdminPage: inventory Manager's List";
            }
            SqlDataAdapter sda = new SqlDataAdapter(querry, CN.thisConnection);
            DataTable ftable = new DataTable();
            sda.Fill(ftable);
            dataGridView1.DataSource = ftable;
            CN.thisConnection.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            datashow();
        }
    }
}
