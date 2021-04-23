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
    public partial class Who_Has_Been_Fed : Form
    {
        public Who_Has_Been_Fed()
        {
            InitializeComponent();
        }

        private void BacktoMain_Click(object sender, EventArgs e)
        {
            RanchDatabase RanchDatabaseForm = new RanchDatabase();
            RanchDatabaseForm.Show();
        }

        private void Who_Has_Been_Fed_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'who_has_Been_FedRanchDataSet.Who_has_Been_Fed_View' table. You can move, or remove it, as needed.
            this.who_has_Been_Fed_ViewTableAdapter.Fill(this.who_has_Been_FedRanchDataSet.Who_has_Been_Fed_View);

        }
    }
    }

