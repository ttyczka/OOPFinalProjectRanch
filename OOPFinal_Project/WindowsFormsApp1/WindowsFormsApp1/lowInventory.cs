﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class lowInventory : Form
    {
        public lowInventory()
        {
            InitializeComponent();
        }

        private void BacktoMain_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void lowInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'low_Inventory_RanchDataSet.Low_Inventory_View' table. You can move, or remove it, as needed.
            this.low_Inventory_ViewTableAdapter.Fill(this.low_Inventory_RanchDataSet.Low_Inventory_View);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
    }

