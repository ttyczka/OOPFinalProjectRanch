using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Feed : Form
    {
        public Feed()
        {
            InitializeComponent();
        }

        private void lbBed_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool TestValue(string valuetest)
        {
            bool resultstatus = false;
            try
            {
                string teststring;
                teststring = valuetest;
                if (teststring.Length > 0)
                {
                    resultstatus = true;
                }
            }
            catch
            {
                resultstatus = false;
            }
            return resultstatus;
        }
        private bool validateForm()
        {
            bool isformvalid = true;
            if (TestValue(cbFood_Type.Text)) { } else { isformvalid = false; MessageBox.Show("Missing Feed Type"); }
            if (TestValue(txQuantity.Text)) { } else { isformvalid = false; MessageBox.Show("Missing Quantity"); }
            if (TestValue(cbUnit.Text)) { } else { isformvalid = false; MessageBox.Show("Missing Unit"); }
            if (TestValue(tbPrice.Text)) { } else { isformvalid = false; MessageBox.Show("Missing Price"); }
            if (TestValue(dtpDate.Value.ToString())) { } else { isformvalid = false; MessageBox.Show("Missing Date"); }
            return isformvalid;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!validateForm()) { return; }

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.RanchConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT Feed_Inventory ([Feed_Type],[Quantity],[Unit],[Price],[recommended_feed_rate],[date]) VALUES (@Feed_Type,@Quantity,@Unit,@Price,@recommended_feed_rate,@date)";
                    cmd.Parameters.Add("@Feed_Type", SqlDbType.NVarChar).Value = cbFood_Type.Text;
                    cmd.Parameters.Add("@Quantity", SqlDbType.NVarChar).Value = txQuantity.Text;
                    cmd.Parameters.Add("@Unit", SqlDbType.NVarChar).Value = cbUnit.Text;
                    cmd.Parameters.Add("@Price", SqlDbType.NVarChar).Value = tbPrice.Text;
                    cmd.Parameters.Add("@recommended_feed_rate", SqlDbType.NVarChar).Value = tbRecommended_Feed_Rate.Text;
                    cmd.Parameters.Add("@date", SqlDbType.Date).Value = dtpDate.Value;

                    cmd.Connection = conn;
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    cmd.CommandText = "UPDATE Currrent_Feed_Inventory SET Quantity= Quantity+@NewQuantity WHERE Feed_Type=@Feed_Type2";
                    int Quantity = int.Parse(txQuantity.Text);
                    cmd.Parameters.Add("@NewQuantity", SqlDbType.NVarChar).Value = txQuantity.Text;
                    cmd.Parameters.Add("@Feed_Type2", SqlDbType.NVarChar).Value = cbFood_Type.Text;
                    cmd.ExecuteNonQuery();
                }
                

            }

            this.feed_InventoryTableAdapter.Fill(this.feedRanchDataSet.Feed_Inventory);
            MessageBox.Show("Feed added to inventroy. ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rowindex = dgvWWA.CurrentRow.Index;
            DataGridViewRow row = dgvWWA.Rows[rowindex];
            string feedID = row.Cells[0].Value.ToString();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.RanchConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE FROM  Feed_Inventory WHERE feedID=@feedID";
                    cmd.Parameters.Add("@feedID", SqlDbType.NVarChar).Value = feedID;
                    cmd.Connection = conn;
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    cmd.CommandText = "UPDATE Currrent_Feed_Inventory SET Quantity= Quantity-@NewQuantity WHERE Feed_Type=@Feed_Type2";
                    int Quantity = int.Parse(txQuantity.Text);
                    cmd.Parameters.Add("@NewQuantity", SqlDbType.NVarChar).Value = txQuantity.Text;
                    cmd.Parameters.Add("@Feed_Type2", SqlDbType.NVarChar).Value = cbFood_Type.Text;
                    cmd.ExecuteNonQuery();
                }

            }
            this.feed_InventoryTableAdapter.Fill(this.feedRanchDataSet.Feed_Inventory);

        }

        //private void btnEdit_Click(object sender, EventArgs e)
        //{
        //    if (btnEdit.Text.Equals("Edit"))
        //    {
        //        int rowindex = dgvWWA.CurrentRow.Index;
        //        DataGridViewRow row = dgvWWA.Rows[rowindex];
        //        string Food_Type = row.Cells[0].Value.ToString();
        //        string quantity = row.Cells[1].Value.ToString();
        //        string Unit = row.Cells[2].Value.ToString();
        //        string Price = row.Cells[3].Value.ToString();
        //        string Recommended_Feed_Rate = row.Cells[4].Value.ToString();
        //        string date = row.Cells[5].Value.ToString();
        //        //Add more

        //        cbFood_Type.Text = Food_Type;
        //        txQuantity.Text = quantity;
        //        cbUnit.Text = Unit;
        //        tbPrice.Text = Price;
        //        tbRecommended_Feed_Rate.Text = Recommended_Feed_Rate;
        //        dtpDate.Value = DateTime.Parse(date);


        //        btnEdit.Text = "Save Changes";
        //    }
        //    else
        //    {
        //        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.RanchConnectionString"].ConnectionString))
        //        {
        //            using (SqlCommand cmd = new SqlCommand())
        //            {//add each feild to update statment 
        //                //cmd.CommandText = "UPDATE Bedding_Inventory SET animal_name=@animal_name, WHERE bedID=@bedID";
        //                cmd.Parameters.Add("@Feed_Type", SqlDbType.NVarChar).Value = cbFood_Type.Text;
        //                cmd.Parameters.Add("@Quantity", SqlDbType.NVarChar).Value = txQuantity.Text;
        //                cmd.Parameters.Add("@Unit", SqlDbType.NVarChar).Value = cbUnit.Text;
        //                cmd.Parameters.Add("@Price", SqlDbType.NVarChar).Value = tbPrice.Text;
        //                cmd.Parameters.Add("@recommended_feed_rate", SqlDbType.NVarChar).Value = tbRecommended_Feed_Rate.Text;
        //                cmd.Parameters.Add("@date", SqlDbType.Date).Value = dtpDate.Value;

        //                cmd.Connection = conn;
        //                conn.Open();
        //                int rowsAffected = cmd.ExecuteNonQuery();
        //            }

        //        }
        //        this.feed_InventoryTableAdapter.Fill(this.feedRanchDataSet.Feed_Inventory);

        //        btnEdit.Text = "Edit";
        //    }
        //}

        private void Feed_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'feedRanchDataSet.Feed_Inventory' table. You can move, or remove it, as needed.
            this.feed_InventoryTableAdapter.Fill(this.feedRanchDataSet.Feed_Inventory);

        }
    }
}

