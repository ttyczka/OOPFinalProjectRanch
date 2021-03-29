namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Birth_Date = new System.Windows.Forms.Label();
            this.Sex = new System.Windows.Forms.Label();
            this.Species = new System.Windows.Forms.Label();
            this.Animal_Name = new System.Windows.Forms.Label();
            this.TagID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.breed = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UsersForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Location = new System.Drawing.Point(191, 218);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(187, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1132, 599);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(12, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(506, 506);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Logo.TabIndex = 3;
            this.Logo.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Birth_Date, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Sex, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.Species, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Animal_Name, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TagID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.breed, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(524, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(381, 262);
            this.tableLayoutPanel1.TabIndex = 4;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // textBox5
            // 
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox5.Location = new System.Drawing.Point(191, 175);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(187, 20);
            this.textBox5.TabIndex = 15;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Location = new System.Drawing.Point(191, 132);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(187, 20);
            this.textBox4.TabIndex = 14;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(191, 89);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(187, 20);
            this.textBox3.TabIndex = 13;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(191, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(187, 20);
            this.textBox2.TabIndex = 12;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Birth_Date
            // 
            this.Birth_Date.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Birth_Date.AutoSize = true;
            this.Birth_Date.Location = new System.Drawing.Point(128, 232);
            this.Birth_Date.Name = "Birth_Date";
            this.Birth_Date.Size = new System.Drawing.Size(57, 13);
            this.Birth_Date.TabIndex = 10;
            this.Birth_Date.Text = "Birth Date:";
            // 
            // Sex
            // 
            this.Sex.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Sex.AutoSize = true;
            this.Sex.Location = new System.Drawing.Point(157, 187);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(28, 13);
            this.Sex.TabIndex = 8;
            this.Sex.Text = "Sex:";
            // 
            // Species
            // 
            this.Species.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Species.AutoSize = true;
            this.Species.Location = new System.Drawing.Point(137, 101);
            this.Species.Name = "Species";
            this.Species.Size = new System.Drawing.Size(48, 13);
            this.Species.TabIndex = 4;
            this.Species.Text = "Species:";
            // 
            // Animal_Name
            // 
            this.Animal_Name.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Animal_Name.AutoSize = true;
            this.Animal_Name.Location = new System.Drawing.Point(113, 58);
            this.Animal_Name.Name = "Animal_Name";
            this.Animal_Name.Size = new System.Drawing.Size(72, 13);
            this.Animal_Name.TabIndex = 2;
            this.Animal_Name.Text = "Animal Name:";
            // 
            // TagID
            // 
            this.TagID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TagID.AutoSize = true;
            this.TagID.Location = new System.Drawing.Point(145, 15);
            this.TagID.Name = "TagID";
            this.TagID.Size = new System.Drawing.Size(40, 13);
            this.TagID.TabIndex = 0;
            this.TagID.Text = "TagID:";
            this.TagID.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(191, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // breed
            // 
            this.breed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.breed.AutoSize = true;
            this.breed.Location = new System.Drawing.Point(147, 144);
            this.breed.Name = "breed";
            this.breed.Size = new System.Drawing.Size(38, 13);
            this.breed.TabIndex = 6;
            this.breed.Text = "Breed:";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(1274, 599);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(674, 378);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // UsersForm
            // 
            this.UsersForm.Location = new System.Drawing.Point(1237, 421);
            this.UsersForm.Name = "UsersForm";
            this.UsersForm.Size = new System.Drawing.Size(75, 23);
            this.UsersForm.TabIndex = 7;
            this.UsersForm.Text = "Users";
            this.UsersForm.UseVisualStyleBackColor = true;
            this.UsersForm.Click += new System.EventHandler(this.UsersForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 652);
            this.Controls.Add(this.UsersForm);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "New Animal Database Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Birth_Date;
        private System.Windows.Forms.Label Sex;
        private System.Windows.Forms.Label breed;
        private System.Windows.Forms.Label Species;
        private System.Windows.Forms.Label Animal_Name;
        private System.Windows.Forms.Label TagID;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button UsersForm;
    }
}

