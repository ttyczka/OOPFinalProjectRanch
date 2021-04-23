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
    public partial class Mineral : Form
    {
        public Mineral()
        {
            InitializeComponent();
        }

        private void DateCreated_Click(object sender, EventArgs e)
        {

        }

        private void Cows_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Mineral_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mineral_TubRanchDataSet.Mineral_Tub_Inventory' table. You can move, or remove it, as needed.
            this.mineral_Tub_InventoryTableAdapter.Fill(this.mineral_TubRanchDataSet.Mineral_Tub_Inventory);

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
            if (TestValue(cbMineral_Name.Text)) { } else { isformvalid = false; MessageBox.Show("Missing Material"); }
            if (TestValue(tbquantity.Text)) { } else { isformvalid = false; MessageBox.Show("Missing Quantity"); }
            if (TestValue(cbSize.Text)) { } else { isformvalid = false; MessageBox.Show("Missing Unit"); }
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
                    cmd.CommandText = "INSERT Mineral_Tub_Inventory ([Mineral_name],[Quantity],[Size],[Price],[Recommended_ditribution_rate],[date]) VALUES (@Mineral_name,@Quantity,@Size,@Price,@Recommended_ditribution_rate,@date)";
                    cmd.Parameters.Add("@Mineral_name", SqlDbType.NVarChar).Value = cbMineral_Name.Text;
                    cmd.Parameters.Add("@Quantity", SqlDbType.NVarChar).Value = tbquantity.Text;
                    cmd.Parameters.Add("@Size", SqlDbType.NVarChar).Value = cbSize.Text;
                    cmd.Parameters.Add("@Price", SqlDbType.NVarChar).Value = tbPrice.Text;
                    cmd.Parameters.Add("@Recommended_ditribution_rate", SqlDbType.NVarChar).Value = tbRecommended_Distribution_Rate.Text;
                    cmd.Parameters.Add("@date", SqlDbType.Date).Value = dtpDate.Value;

                    cmd.Connection = conn;
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    cmd.CommandText = "UPDATE Currrent_Feed_Inventory SET Quantity= Quantity+@NewQuantity WHERE Mineral_name=@Mineral_name";
                    int Quantity = int.Parse(tbquantity.Text);
                    cmd.Parameters.Add("@NewQuantity", SqlDbType.NVarChar).Value = tbquantity.Text;
                    cmd.Parameters.Add("@Mineral_name", SqlDbType.NVarChar).Value = cbMineral_Name.Text;
                    cmd.ExecuteNonQuery();
                }
            }

            
            this.mineral_Tub_InventoryTableAdapter.Fill(this.mineral_TubRanchDataSet.Mineral_Tub_Inventory);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowindex = dgvMTB.CurrentRow.Index;
            DataGridViewRow row = dgvMTB.Rows[rowindex];
            string minID = row.Cells[0].Value.ToString();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.RanchConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE FROM  Mineral_Tub_Inventory WHERE minID=@minID";
                    cmd.Parameters.Add("@minID", SqlDbType.NVarChar).Value = minID;
                    cmd.Connection = conn;
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    cmd.CommandText = "UPDATE Currrent_Feed_Inventory SET Quantity= Quantity-@NewQuantity WHERE Mineral_name=@Mineral_name";
                    int Quantity = int.Parse(tbquantity.Text);
                    cmd.Parameters.Add("@NewQuantity", SqlDbType.NVarChar).Value = tbquantity.Text;
                    cmd.Parameters.Add("@Mineral_name", SqlDbType.NVarChar).Value = cbMineral_Name.Text;
                    cmd.ExecuteNonQuery();
                }

            }
            this.mineral_Tub_InventoryTableAdapter.Fill(this.mineral_TubRanchDataSet.Mineral_Tub_Inventory);
        }

        //private void btnEdit_Click(object sender, EventArgs e)
        //{
        //    if (btnEdit.Text.Equals("Edit"))
        //    {
        //        int rowindex = dgvMTB.CurrentRow.Index;
        //        DataGridViewRow row = dgvMTB.Rows[rowindex];
        //        string Mineral_Name = row.Cells[0].Value.ToString();
        //        string quantity = row.Cells[1].Value.ToString();
        //        string size = row.Cells[2].Value.ToString();
        //        string Price = row.Cells[3].Value.ToString();
        //        string Recommended_Distribution_Rate = row.Cells[4].Value.ToString();
        //        string date = row.Cells[5].Value.ToString();
        //        //Add more

        //        cbMineral_Name.Text = Mineral_Name;
        //        tbquantity.Text = quantity;
        //        cbSize.Text = size;
        //        tbPrice.Text = Price;
        //        tbRecommended_Distribution_Rate.Text = Recommended_Distribution_Rate;
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
        //                cmd.Parameters.Add("@Mineral_name", SqlDbType.NVarChar).Value = cbMineral_Name.Text;
        //                cmd.Parameters.Add("@Quantity", SqlDbType.NVarChar).Value = tbquantity.Text;
        //                cmd.Parameters.Add("@Size", SqlDbType.NVarChar).Value = cbSize.Text;
        //                cmd.Parameters.Add("@Price", SqlDbType.NVarChar).Value = tbPrice.Text;
        //                cmd.Parameters.Add("@Recommended_ditribution_rate", SqlDbType.NVarChar).Value = tbRecommended_Distribution_Rate.Text;
        //                cmd.Parameters.Add("@date", SqlDbType.Date).Value = dtpDate.Value;

        //                cmd.Connection = conn;
        //                conn.Open();
        //                int rowsAffected = cmd.ExecuteNonQuery();
        //            }

        //        }
        //        this.mineral_Tub_InventoryTableAdapter.Fill(this.mineral_TubRanchDataSet.Mineral_Tub_Inventory);
        //        btnEdit.Text = "Edit";
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            RanchDatabase RanchDatabaseForm = new RanchDatabase();
            RanchDatabaseForm.Show();
        }
    }
    }

