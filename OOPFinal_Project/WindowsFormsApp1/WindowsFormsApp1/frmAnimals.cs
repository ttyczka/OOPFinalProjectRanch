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
    public partial class frmAnimals : Form
    {
        public frmAnimals()
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
        private bool validateForm() 
        {
            bool isformvalid = true;
            if (txttagID.Text != null) { isformvalid = true; } else { isformvalid = false; MessageBox.Show("Missing Animal TagId");}
            if (txtspecies.Text != null) { isformvalid = true;} else { isformvalid = false; MessageBox.Show("Missing Animal Species");}
            if (txtbreed.Text != null) { isformvalid = true;} else { isformvalid = false; MessageBox.Show("Missing Animal Breed");}
            if (txtsex.Text != null) { isformvalid = true; } else { isformvalid = false; MessageBox.Show("Missing Animal Sex");}
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
                    cmd.CommandText = "INSERT Ranch_Animal([tagID], [animal_name], [birthdate], [species], [breed], [sex], [photo]) VALUES (@tagID, @animal_name, @birthdate, @species, @breed, @sex, @photo)";
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
            this.ranch_AnimalTableAdapter.Fill(this.ranch_Animal_DataSet.Ranch_Animal);
        }

        private void frmAnimals_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ranch_Animal_DataSet.Ranch_Animal' table. You can move, or remove it, as needed.
            this.ranch_AnimalTableAdapter.Fill(this.ranch_Animal_DataSet.Ranch_Animal);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
            this.ranch_AnimalTableAdapter.Fill(this.ranch_Animal_DataSet.Ranch_Animal);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text.Equals("Edit"))
            {
                int rowindex = dataGridView1.CurrentRow.Index;
                DataGridViewRow row = dataGridView1.Rows[rowindex];
                string tagID = row.Cells[0].Value.ToString();
                string animal_name = row.Cells[1].Value.ToString();
                string birthdate = row.Cells[2].Value.ToString();
                string species = row.Cells[3].Value.ToString();
                string breed = row.Cells[4].Value.ToString();
                string sex = row.Cells[5].Value.ToString();
                string health_concerns = row.Cells[6].Value.ToString();
                string photo = row.Cells[7].Value.ToString();
                string status = row.Cells[8].Value.ToString();
            //Add more
                txttagID.Text = tagID;
                txtanimal_name.Text = animal_name;
                dtpdob.Value = DateTime.Parse(birthdate);
                txtspecies.Text = species;
                txtbreed.Text = breed;
                txtsex.Text = sex;
                txthealth_concerns.Text = health_concerns;
                txtphoto.Text = photo;
                

                button2.Text = "Save Changes";
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.RanchConnectionString"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        //feild =@feild,
                        if (txtphoto.Text.Length < 1)
                        {
                            //Update statment without photo
                            cmd.CommandText = "UPDATE Ranch_Animal SET animal_name=@animal_name, WHERE tagID=@tagID";
                            
                        }
                        else
                        {
                            //Update statment with photo
                            cmd.CommandText = "UPDATE Ranch_Animal SET animal_name=@animal_name, WHERE tagID=@tagID";
                            cmd.Parameters.Add("@Photo", SqlDbType.VarBinary).Value = FileProcessor.GetBytesFromFile(txtphoto.Text);
                        }
                        
                        cmd.Parameters.Add("@tagID", SqlDbType.NVarChar).Value = txttagID.Text;
                        cmd.Parameters.Add("@animal_name", SqlDbType.NVarChar).Value = txtanimal_name.Text;
                        cmd.Parameters.Add("@birthdate", SqlDbType.Date).Value = dtpdob.Value;
                        cmd.Parameters.Add("@species", SqlDbType.NVarChar).Value = txtspecies.Text;
                        cmd.Parameters.Add("@breed", SqlDbType.NVarChar).Value = txtbreed.Text;
                        cmd.Parameters.Add("@sex", SqlDbType.NVarChar).Value = txtsex.Text;
                        cmd.Parameters.Add("@health_concerns", SqlDbType.Date).Value = txthealth_concerns.Text;
                        
                        cmd.Connection = conn;
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                    }

                }
                this.ranch_AnimalTableAdapter.Fill(this.ranch_Animal_DataSet.Ranch_Animal);
                button2.Text = "Edit";
            }
         
        }

        private void txtspecies_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
