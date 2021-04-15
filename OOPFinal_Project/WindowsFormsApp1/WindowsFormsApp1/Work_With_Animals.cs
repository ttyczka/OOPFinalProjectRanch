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

        private void Work_With_Animals_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wWADataSet.Work_With_Animals' table. You can move, or remove it, as needed.
            this.work_With_AnimalsTableAdapter.Fill(this.wWADataSet.Work_With_Animals);

        }
        private bool validateForm()
        {
            bool isformvalid = true;
            if (txttagID.Text != null) { isformvalid = true; } else { isformvalid = false; MessageBox.Show("Missing Animal TagId"); }
            if (txtspecies.Text != null) { isformvalid = true; } else { isformvalid = false; MessageBox.Show("Missing Animal Species"); }
            if (txtbreed.Text != null) { isformvalid = true; } else { isformvalid = false; MessageBox.Show("Missing Animal Breed"); }
            if (txtsex.Text != null) { isformvalid = true; } else { isformvalid = false; MessageBox.Show("Missing Animal Sex"); }
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
                    cmd.Parameters.Add("@tagID", SqlDbType.NVarChar).Value = txttagID.Text;
                    cmd.Parameters.Add("@animal_name", SqlDbType.NVarChar).Value = txtanimal_name.Text;
                    cmd.Parameters.Add("@birthdate", SqlDbType.Date).Value = dtpdob.Value;
                    cmd.Parameters.Add("@species", SqlDbType.NVarChar).Value = txtspecies.Text;
                    cmd.Parameters.Add("@breed", SqlDbType.NVarChar).Value = txtbreed.Text;
                    cmd.Parameters.Add("@sex", SqlDbType.NVarChar).Value = txtsex.Text;
                    cmd.Parameters.Add("@health_concerns", SqlDbType.Date).Value = txthealth_concerns.Text;
                    cmd.Parameters.Add("@Photo", SqlDbType.VarBinary).Value = FileProcessor.GetBytesFromFile(txtphoto.Text);
                    cmd.Connection = conn;
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                }

            }
            this.work_With_AnimalsTableAdapter.Fill(this.wWADataSet.Work_With_Animals);
        }
    }
}
