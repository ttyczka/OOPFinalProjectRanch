using System;
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
    public partial class RanchDatabase : Form
    {
        public RanchDatabase()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsersForm_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Animal_Inventory NewAnimalForm = new Animal_Inventory();
            NewAnimalForm.Show();
        }

        private void WorkWithAnimals_Click(object sender, EventArgs e)
        {
            Work_With_Animals Work_With_AnimalsForm = new Work_With_Animals();
            Work_With_AnimalsForm.Show();
        }

        private void food_Click(object sender, EventArgs e)
        {
            Feed Feed_Inventory_Form = new Feed();
            Feed_Inventory_Form.Show();
        }

        private void Bed_Click(object sender, EventArgs e)
        {
            Bed Bed_Inventory_Form = new Bed();
            Bed_Inventory_Form.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Mineral Mineral_Inventory_Form = new Mineral();
            Mineral_Inventory_Form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lowInventory Low_Inventory_Form = new lowInventory();
            Low_Inventory_Form.Show();
        }

        private void btnWho_Has_Been_Fed_Click(object sender, EventArgs e)
        {
            Who_Has_Been_Fed Who_Has_Been_Fed_Form = new Who_Has_Been_Fed();
            Who_Has_Been_Fed_Form.Show();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
