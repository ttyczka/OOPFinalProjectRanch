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
    public partial class Work_With_Animals : Form
    {
        public Work_With_Animals()
        {
            InitializeComponent();
        }

        private void cbSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!validateForm()) { return; }

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.RanchConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT Work_With_Animals ([species],[action],[type],[quantity],[unit],[date]) VALUES (@species,@action,@type,@quantity,@unit,@date)";
                    cmd.Parameters.Add("@species", SqlDbType.NVarChar).Value = cbSpecies.Text;
                    cmd.Parameters.Add("@action", SqlDbType.NVarChar).Value = cbAction.Text;
                    cmd.Parameters.Add("@type", SqlDbType.NVarChar).Value = cbType.Text;
                    cmd.Parameters.Add("@quantity", SqlDbType.NVarChar).Value = tbQuantity.Text;
                    cmd.Parameters.Add("@unit", SqlDbType.NVarChar).Value = cbUnit.Text;
                    cmd.Parameters.Add("@date", SqlDbType.Date).Value = dtpDate.Value;
                   
                    cmd.Connection = conn;
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                }

            }
            this.work_With_AnimalsTableAdapter.Fill(this.wWADataSet.Work_With_Animals);
        }

        private void Work_With_Animals_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wWADataSet.Work_With_Animals' table. You can move, or remove it, as needed.
            this.work_With_AnimalsTableAdapter.Fill(this.wWADataSet.Work_With_Animals);

        }

        private bool TestValue(string valuetest)
        {
            bool resultstatus = false;
            try 
            {
                string teststring;
                teststring = valuetest;
                if (teststring.Length> 0)
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
            if (TestValue(cbSpecies.Text) ) {  } else { isformvalid = false; MessageBox.Show("Missing Species"); }
            if (TestValue(cbAction.Text)) {  } else { isformvalid = false; MessageBox.Show("Missing Action"); }
            if (TestValue(cbType.Text )) {  } else { isformvalid = false; MessageBox.Show("Missing Type"); }
            if (TestValue(tbQuantity.Text)) { } else { isformvalid = false; MessageBox.Show("Missing Quantity"); }
            if (TestValue(dtpDate.Value.ToString())) {  } else { isformvalid = false; MessageBox.Show("Missing Date"); }
            return isformvalid;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!validateForm()) { return; }

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.RanchConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("work_with_animals_insert"))
                { 
                    cmd.CommandType = CommandType.StoredProcedure;
                    //Change feilds to match table 
                    
                    cmd.Parameters.Add("@species", SqlDbType.NVarChar).Value = cbSpecies.Text;
                    cmd.Parameters.Add("@action", SqlDbType.NVarChar).Value = cbAction.Text;
                    cmd.Parameters.Add("@type", SqlDbType.NVarChar).Value = cbType.Text;
                    cmd.Parameters.Add("@quantity", SqlDbType.NVarChar).Value = tbQuantity.Text;
                    cmd.Parameters.Add("@unit", SqlDbType.NVarChar).Value = cbUnit.Text;
                    cmd.Parameters.Add("@date", SqlDbType.Date).Value = dtpDate.Value;
                    cmd.Connection = conn;
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();
                    //SqlCommand cmd2 = new SqlCommand();
                    //cmd2.Connection = conn;
                    //conn.Open();
                    //cmd2.CommandType = CommandType.Text;
                    
                    //if (cbAction.Text =="Feed")
                    //{
                    //    cmd2.CommandText = "UPDATE Currrent_Feed_Inventory SET Quantity= Quantity-@NewQuantity WHERE Feed_Type=@type";
                    //    int Quantity = int.Parse(tbQuantity.Text);
                    //    cmd2.Parameters.Add("@NewQuantity", SqlDbType.NVarChar).Value = tbQuantity.Text;
                    //    cmd2.Parameters.Add("@type", SqlDbType.NVarChar).Value = cbType.Text;
                    //    cmd2.ExecuteNonQuery();
                    //}
                    //else if (cbAction.Text =="Bed")
                    //{

                    //    cmd2.CommandText = "UPDATE Current_Bed_Inventory SET Quantity= Quantity-@NewQuantity WHERE Material=@type";
                    //    int Quantity = int.Parse(tbQuantity.Text);
                    //    cmd2.Parameters.Add("@NewQuantity", SqlDbType.NVarChar).Value = tbQuantity.Text;
                    //    cmd2.Parameters.Add("@type", SqlDbType.NVarChar).Value = cbType.Text;
                    //    cmd2.ExecuteNonQuery();
                    //}
                    //else
                    //{
                    //    cmd2.CommandText = "UPDATE Current_Mineral_Inventory SET Quantity= Quantity-@NewQuantity WHERE Mineral_Type=@type";
                    //    int Quantity = int.Parse(tbQuantity.Text);
                    //    cmd2.Parameters.Add("@NewQuantity", SqlDbType.NVarChar).Value = tbQuantity.Text;
                    //    cmd2.Parameters.Add("@type", SqlDbType.NVarChar).Value = cbType.Text;
                    //    cmd2.ExecuteNonQuery();
                    //}
                    //conn.Close();
                    MessageBox.Show("Work Added");
                }

            }
            this.work_With_AnimalsTableAdapter.Fill(this.wWADataSet.Work_With_Animals);
        }

        private void lbSpecies_Click(object sender, EventArgs e)
        {

        }

        private void lbAction_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void btnEdit_Click(object sender, EventArgs e)
        //{
        //    if (button2.Text.Equals("Edit"))
        //    {
        //        int rowindex = dgvWWA.CurrentRow.Index;
        //        DataGridViewRow row = dgvWWA.Rows[rowindex];
        //        string species = row.Cells[0].Value.ToString();
        //        string action = row.Cells[1].Value.ToString();
        //        string type = row.Cells[2].Value.ToString();
        //        string quantity = row.Cells[3].Value.ToString();
        //        string unit = row.Cells[4].Value.ToString();
        //        string date = row.Cells[5].Value.ToString();
        //        //Add more
        //        cbSpecies.Text = species;
        //        cbAction.Text = action;
        //        cbType.Text = type;
        //        tbQuantity.Text = quantity;
        //        cbUnit.Text = unit;
        //        dtpDate.Value= DateTime.Parse(date);


        //        button2.Text = "Save Changes";
        //    }
        //    else
        //    {
        //        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.RanchConnectionString"].ConnectionString))
        //        {
        //            using (SqlCommand cmd = new SqlCommand())
        //            {
        //                //add each feild to update statment 
        //                //cmd.CommandText = "UPDATE Bedding_Inventory SET animal_name=@animal_name, WHERE bedID=@bedID";
        //                cmd.Parameters.Add("@species", SqlDbType.NVarChar).Value = cbSpecies.Text;
        //                cmd.Parameters.Add("@action", SqlDbType.NVarChar).Value = cbAction.Text;
        //                cmd.Parameters.Add("@type", SqlDbType.NVarChar).Value = cbType.Text;
        //                cmd.Parameters.Add("@quantity", SqlDbType.NVarChar).Value = tbQuantity.Text;
        //                cmd.Parameters.Add("@unit", SqlDbType.NVarChar).Value = cbUnit.Text;
        //                cmd.Parameters.Add("@date", SqlDbType.Date).Value = dtpDate.Value;
        //                cmd.Connection = conn;
        //                conn.Open();
        //                int rowsAffected = cmd.ExecuteNonQuery();
        //            }

        //        }
        //        this.work_With_AnimalsTableAdapter.Fill(this.wWADataSet.Work_With_Animals);
        //        button2.Text = "Edit";
        //    }

       // }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowindex = dgvWWA.CurrentRow.Index;
            DataGridViewRow row = dgvWWA.Rows[rowindex];
            string workID = row.Cells[0].Value.ToString();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.RanchConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE FROM  Work_With_Animals WHERE workID=@workID";
                    cmd.Parameters.Add("@workID", SqlDbType.NVarChar).Value = workID;
                    cmd.Connection = conn;
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                }

            }
            this.work_With_AnimalsTableAdapter.Fill(this.wWADataSet.Work_With_Animals);
        }

        private void dgvWWA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

