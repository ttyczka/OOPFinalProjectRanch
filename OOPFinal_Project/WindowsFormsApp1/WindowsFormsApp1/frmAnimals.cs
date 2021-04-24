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
    public partial class Animal_Inventory : Form
    {
        public Animal_Inventory()
        {
            InitializeComponent();
        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                // InitialDirectory = @"C:\",
                Title = "Browse Image Files",

                CheckFileExists = true,
                CheckPathExists = true,

                // DefaultExt = "txt",
                //Filter = "PNG files (*.png)|*.png",
                //FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtphoto.Text = openFileDialog1.FileName;
            }

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
            if (TestValue(txttagID.Text)) { } else { isformvalid = false; MessageBox.Show("Missing Animal TagId"); }
            if (TestValue(txtspecies.Text)) { } else { isformvalid = false; MessageBox.Show("Missing Animal Species"); }
            if (TestValue(txtbreed.Text)) { } else { isformvalid = false; MessageBox.Show("Missing Animal Breed"); }
            if (TestValue(txtsex.Text)) { } else { isformvalid = false; MessageBox.Show("Missing Animal Sex"); }
            if (TestValue(dtpdob.Value.ToString())) { } else { isformvalid = false; MessageBox.Show("Missing Date"); }
            return isformvalid;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!validateForm()) { return; }

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.RanchConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT Ranch_Animal([tagID], [animal_name], [arrival_date], [species], [breed], [sex], [photo]) VALUES (@tagID, @animal_name, @arrival_date, @species, @breed, @sex, @photo)";
                    cmd.Parameters.Add("@tagID", SqlDbType.NVarChar).Value = txttagID.Text;
                    cmd.Parameters.Add("@animal_name", SqlDbType.NVarChar).Value = txtanimal_name.Text;
                    cmd.Parameters.Add("@arrival_date", SqlDbType.Date).Value = dtpdob.Value;
                    cmd.Parameters.Add("@species", SqlDbType.NVarChar).Value = txtspecies.Text;
                    cmd.Parameters.Add("@breed", SqlDbType.NVarChar).Value = txtbreed.Text;
                    cmd.Parameters.Add("@sex", SqlDbType.NVarChar).Value = txtsex.Text;
                    cmd.Parameters.Add("@health_concerns", SqlDbType.NVarChar).Value = txthealth_concerns.Text;
                    cmd.Parameters.Add("@Photo", SqlDbType.VarBinary).Value = FileProcessor.GetBytesFromFile(txtphoto.Text);
                    cmd.Connection = conn;
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Animal Added");
            }
            this.ranch_AnimalTableAdapter2.Fill(this.ranchAnimalwithArrivalDateRanchDataSet.Ranch_Animal);
        }

        private void frmAnimals_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ranchAnimalwithArrivalDateRanchDataSet.Ranch_Animal' table. You can move, or remove it, as needed.
            this.ranch_AnimalTableAdapter2.Fill(this.ranchAnimalwithArrivalDateRanchDataSet.Ranch_Animal);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void Delete_Click(object sender, EventArgs e)
            {
            int rowindex = dataGridView1.CurrentRow.Index;
            DataGridViewRow row = dataGridView1.Rows[rowindex];
            string tagID = row.Cells[0].Value.ToString();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.RanchConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE FROM Ranch_Animal WHERE tagID=@tagID";
                    cmd.Parameters.Add("@tagID", SqlDbType.NVarChar).Value = tagID;
                    cmd.Connection = conn;
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            this.ranch_AnimalTableAdapter2.Fill(this.ranchAnimalwithArrivalDateRanchDataSet.Ranch_Animal);
        }
        private void btnARemove_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentRow.Index;
            DataGridViewRow row = dataGridView1.Rows[rowindex];
            string tagID = row.Cells[0].Value.ToString();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.RanchConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE Ranch_Animal SET Status='I' WHERE tagID= @tagID";
                    cmd.Parameters.Add("@tagID", SqlDbType.NVarChar).Value = tagID;
                    cmd.Connection = conn;
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                }

            }
            this.ranch_AnimalTableAdapter2.Fill(this.ranchAnimalwithArrivalDateRanchDataSet.Ranch_Animal);
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    if (button2.Text.Equals("Edit"))
        //    {
        //        int rowindex = dataGridView1.CurrentRow.Index;
        //        DataGridViewRow row = dataGridView1.Rows[rowindex];
        //        string tagID = row.Cells[0].Value.ToString();
        //        string animal_name = row.Cells[1].Value.ToString();
        //        string arrival_date = row.Cells[2].Value.ToString();
        //        string species = row.Cells[3].Value.ToString();
        //        string breed = row.Cells[4].Value.ToString();
        //        string sex = row.Cells[5].Value.ToString();
        //        string health_concerns = row.Cells[6].Value.ToString();
        //        string photo = row.Cells[7].Value.ToString();
        //        string status = row.Cells[8].Value.ToString();
        //        //Add more
        //        txttagID.Text = tagID;
        //        txtanimal_name.Text = animal_name;
        //        dtpdob.Value = DateTime.Parse(arrival_date);
        //        txtspecies.Text = species;
        //        txtbreed.Text = breed;
        //        txtsex.Text = sex;
        //        txthealth_concerns.Text = health_concerns;
        //        txtphoto.Text = photo;


        //        button2.Text = "Save Changes";
        //    }
        //    else
        //    {
        //        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.RanchConnectionString"].ConnectionString))
        //        {
        //            using (SqlCommand cmd = new SqlCommand())
        //            {
        //                cmd.CommandType = CommandType.Text;
        //                //feild =@feild,
        //                if (txtphoto.Text.Length < 1)
        //                {
        //                    //add each feild to update statment 
        //                    //Update statment without photo
        //                    cmd.CommandText = "UPDATE Ranch_Animal SET animal_name=@animal_name, arrival_date=@arrival_date,species=@species,breed=@breed,sex=@sex,health_concerns=@health_concerns WHERE tagID=@tagID";

        //                }
        //                else
        //                {//add each feild to update statment 
        //                 //Update statment with photo
        //                    cmd.CommandText = "UPDATE Ranch_Animal SET animal_name=@animal_name, arrival_date=@arrival_date,species=@species,breed=@breed,sex=@sex,health_concerns=@health_concerns,Photo=@Photo WHERE tagID=@tagID";
        //                    cmd.Parameters.Add("@Photo", SqlDbType.VarBinary).Value = FileProcessor.GetBytesFromFile(txtphoto.Text);
        //                }

        //                cmd.Parameters.Add("@tagID", SqlDbType.NVarChar).Value = txttagID.Text;
        //                cmd.Parameters.Add("@animal_name", SqlDbType.NVarChar).Value = txtanimal_name.Text;
        //                cmd.Parameters.Add("@arrival_date", SqlDbType.Date).Value = dtpdob.Value;
        //                cmd.Parameters.Add("@species", SqlDbType.NVarChar).Value = txtspecies.Text;
        //                cmd.Parameters.Add("@breed", SqlDbType.NVarChar).Value = txtbreed.Text;
        //                cmd.Parameters.Add("@sex", SqlDbType.NVarChar).Value = txtsex.Text;
        //                cmd.Parameters.Add("@health_concerns", SqlDbType.NVarChar).Value = txthealth_concerns.Text;

        //                cmd.Connection = conn;
        //                conn.Open();
        //                int rowsAffected = cmd.ExecuteNonQuery();
        //            }

        //        }
        //        this.ranch_AnimalTableAdapter2.Fill(this.ranchAnimalwithArrivalDateRanchDataSet.Ranch_Animal);
        //        button2.Text = "Edit";
        //        MessageBox.Show("Edits Saved");
        //    }



        private void txtspecies_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BacktoMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

       
    }
}

   

