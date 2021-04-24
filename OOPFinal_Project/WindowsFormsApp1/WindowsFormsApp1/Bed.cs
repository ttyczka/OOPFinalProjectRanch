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
    public partial class Bed : Form
    {
        public Bed()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserName_Click(object sender, EventArgs e)
        {

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
            if (TestValue(cbMaterial.Text)) { } else { isformvalid = false; MessageBox.Show("Missing Material"); }
            if (TestValue(tbquantity.Text)) { } else { isformvalid = false; MessageBox.Show("Missing Quantity"); }
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
                    cmd.CommandText = "INSERT Bedding_Inventory ([Material],[Quantity],[Unit],[Price],[avg_replacement_rate],[date]) VALUES (@Material,@Quantity,@Unit,@Price,@avg_replacement_rate,@date)";
                    cmd.Parameters.Add("@Material", SqlDbType.NVarChar).Value = cbMaterial.Text;
                    cmd.Parameters.Add("@Quantity", SqlDbType.NVarChar).Value = tbquantity.Text;
                    cmd.Parameters.Add("@Unit", SqlDbType.NVarChar).Value = cbUnit.Text;
                    cmd.Parameters.Add("@Price", SqlDbType.NVarChar).Value = tbPrice.Text;
                    cmd.Parameters.Add("@avg_replacement_rate", SqlDbType.NVarChar).Value = tbAvg_Replacement_Rate.Text;
                    cmd.Parameters.Add("@date", SqlDbType.Date).Value = dtpDate.Value;

                    cmd.Connection = conn;
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    cmd.CommandText = "UPDATE Current_Bed_Inventory SET Quantity= Quantity+@NewQuantity WHERE Material=@Material2";
                    int Quantity = int.Parse(tbquantity.Text);
                    cmd.Parameters.Add("@NewQuantity", SqlDbType.NVarChar).Value = tbquantity.Text;
                    cmd.Parameters.Add("@Material2", SqlDbType.NVarChar).Value = cbMaterial.Text;
                    cmd.ExecuteNonQuery();
                }
               
            }

            this.bedding_InventoryTableAdapter1.Fill(this.bedding_Quantity_RanchDataSet.Bedding_Inventory);
            MessageBox.Show("Bedding added to inventroy. ");
        }

        //private void btnEdit_Click(object sender, EventArgs e)
        //{
        //    if (btnEdit.Text.Equals("Edit"))
        //    {
        //        int rowindex = dgvBedding.CurrentRow.Index;
        //        DataGridViewRow row = dgvBedding.Rows[rowindex];
        //        string Material = row.Cells[0].Value.ToString();
        //        string quantity = row.Cells[1].Value.ToString();
        //        string Unit = row.Cells[2].Value.ToString();
        //        string Price = row.Cells[3].Value.ToString();
        //        string avg_replacement_rate = row.Cells[4].Value.ToString();
        //        string date = row.Cells[5].Value.ToString();
        //        //Add more

        //        cbMaterial.Text = Material;
        //        tbquantity.Text = quantity;
        //        cbUnit.Text = Unit;
        //        tbPrice.Text = Price;
        //        tbAvg_Replacement_Rate.Text = avg_replacement_rate;
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
        //                cmd.Parameters.Add("@Material", SqlDbType.NVarChar).Value = cbMaterial.Text;
        //                cmd.Parameters.Add("@Quantity", SqlDbType.NVarChar).Value = tbquantity.Text;
        //                cmd.Parameters.Add("@Unit", SqlDbType.NVarChar).Value = cbUnit.Text;
        //                cmd.Parameters.Add("@Price", SqlDbType.NVarChar).Value = tbPrice.Text;
        //                cmd.Parameters.Add("@avg_replacement_rate", SqlDbType.NVarChar).Value = tbAvg_Replacement_Rate.Text;
        //                cmd.Parameters.Add("@date", SqlDbType.Date).Value = dtpDate.Value;

        //                cmd.Connection = conn;
        //                conn.Open();
        //                int rowsAffected = cmd.ExecuteNonQuery();
        //            }

        //        }
        //                    this.bedding_InventoryTableAdapter1.Fill(this.bedding_Quantity_RanchDataSet.Bedding_Inventory);
        //        btnEdit.Text = "Edit";
        //    }
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            int rowindex = dgvBedding.CurrentRow.Index;
            DataGridViewRow row = dgvBedding.Rows[rowindex];
            string bedID = row.Cells[0].Value.ToString();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.RanchConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    
                    cmd.CommandType = CommandType.Text;
                  cmd.CommandText = "DELETE FROM  Bedding_Inventory WHERE bedID=@bedID";
                  cmd.Parameters.Add("@bedID", SqlDbType.NVarChar).Value = bedID;
                    cmd.Connection = conn;
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    cmd.CommandText = "UPDATE Current_Bed_Inventory SET Quantity= Quantity-@NewQuantity WHERE Material=@Material2";
                    int Quantity = int.Parse(tbquantity.Text);
                    cmd.Parameters.Add("@NewQuantity", SqlDbType.NVarChar).Value = tbquantity.Text;
                    cmd.Parameters.Add("@Material2", SqlDbType.NVarChar).Value = cbMaterial.Text;
                    cmd.ExecuteNonQuery();
                }

            }
            this.bedding_InventoryTableAdapter1.Fill(this.bedding_Quantity_RanchDataSet.Bedding_Inventory);
        }

        private void Bed_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bedding_Quantity_RanchDataSet.Bedding_Inventory' table. You can move, or remove it, as needed.
            this.bedding_InventoryTableAdapter1.Fill(this.bedding_Quantity_RanchDataSet.Bedding_Inventory);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
