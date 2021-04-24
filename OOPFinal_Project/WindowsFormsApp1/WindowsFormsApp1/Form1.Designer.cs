namespace WindowsFormsApp1
{
    partial class RanchDatabase
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
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RanchDatabase));
            System.Windows.Forms.Label label2;
            this.Animal = new System.Windows.Forms.Button();
            this.MineralTub = new System.Windows.Forms.Button();
            this.WorkWithAnimals = new System.Windows.Forms.Button();
            this.food = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Low_Inventory = new System.Windows.Forms.Button();
            this.Bed = new System.Windows.Forms.Button();
            this.btnWho_Has_Been_Fed = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.SystemColors.MenuBar;
            label1.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.ControlText;
            label1.Location = new System.Drawing.Point(232, 49);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(228, 38);
            label1.TabIndex = 19;
            label1.Text = "Welcome To ";
            label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Animal
            // 
            this.Animal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Animal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animal.Location = new System.Drawing.Point(489, 3);
            this.Animal.Name = "Animal";
            this.Animal.Size = new System.Drawing.Size(156, 36);
            this.Animal.TabIndex = 14;
            this.Animal.Text = "Animals";
            this.Animal.UseVisualStyleBackColor = true;
            this.Animal.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MineralTub
            // 
            this.MineralTub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MineralTub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MineralTub.Location = new System.Drawing.Point(327, 45);
            this.MineralTub.Name = "MineralTub";
            this.MineralTub.Size = new System.Drawing.Size(156, 36);
            this.MineralTub.TabIndex = 15;
            this.MineralTub.Text = "Mineral Tub";
            this.MineralTub.UseVisualStyleBackColor = true;
            this.MineralTub.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // WorkWithAnimals
            // 
            this.WorkWithAnimals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkWithAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkWithAnimals.Location = new System.Drawing.Point(3, 3);
            this.WorkWithAnimals.Name = "WorkWithAnimals";
            this.WorkWithAnimals.Size = new System.Drawing.Size(156, 36);
            this.WorkWithAnimals.TabIndex = 16;
            this.WorkWithAnimals.Text = "Work With Animals";
            this.WorkWithAnimals.UseVisualStyleBackColor = true;
            this.WorkWithAnimals.Click += new System.EventHandler(this.WorkWithAnimals_Click);
            // 
            // food
            // 
            this.food.Dock = System.Windows.Forms.DockStyle.Fill;
            this.food.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.food.Location = new System.Drawing.Point(165, 45);
            this.food.Name = "food";
            this.food.Size = new System.Drawing.Size(156, 36);
            this.food.TabIndex = 17;
            this.food.Text = "Feed";
            this.food.UseVisualStyleBackColor = true;
            this.food.Click += new System.EventHandler(this.food_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(224, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 241);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Low_Inventory
            // 
            this.Low_Inventory.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.Low_Inventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Low_Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Low_Inventory.Location = new System.Drawing.Point(165, 3);
            this.Low_Inventory.Name = "Low_Inventory";
            this.Low_Inventory.Size = new System.Drawing.Size(156, 36);
            this.Low_Inventory.TabIndex = 20;
            this.Low_Inventory.Text = "Low Inventory";
            this.Low_Inventory.UseVisualStyleBackColor = true;
            this.Low_Inventory.Click += new System.EventHandler(this.button2_Click);
            // 
            // Bed
            // 
            this.Bed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bed.Location = new System.Drawing.Point(3, 45);
            this.Bed.Name = "Bed";
            this.Bed.Size = new System.Drawing.Size(156, 36);
            this.Bed.TabIndex = 21;
            this.Bed.Text = "Bedding";
            this.Bed.UseVisualStyleBackColor = true;
            this.Bed.Click += new System.EventHandler(this.Bed_Click);
            // 
            // btnWho_Has_Been_Fed
            // 
            this.btnWho_Has_Been_Fed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWho_Has_Been_Fed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWho_Has_Been_Fed.Location = new System.Drawing.Point(327, 3);
            this.btnWho_Has_Been_Fed.Name = "btnWho_Has_Been_Fed";
            this.btnWho_Has_Been_Fed.Size = new System.Drawing.Size(156, 36);
            this.btnWho_Has_Been_Fed.TabIndex = 22;
            this.btnWho_Has_Been_Fed.Text = "Who Has Been Fed";
            this.btnWho_Has_Been_Fed.UseVisualStyleBackColor = true;
            this.btnWho_Has_Been_Fed.Click += new System.EventHandler(this.btnWho_Has_Been_Fed_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(489, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 36);
            this.button1.TabIndex = 23;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.WorkWithAnimals, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.MineralTub, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Low_Inventory, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Bed, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Animal, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnWho_Has_Been_Fed, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.food, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(26, 436);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(648, 84);
            this.tableLayoutPanel1.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.SystemColors.MenuBar;
            label2.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.ControlText;
            label2.Location = new System.Drawing.Point(172, 87);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(350, 38);
            label2.TabIndex = 53;
            label2.Text = "The Ranch Database";
            // 
            // RanchDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(702, 565);
            this.Controls.Add(label2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RanchDatabase";
            this.Text = "Ranch Datatbase";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Animal;
        private System.Windows.Forms.Button MineralTub;
        private System.Windows.Forms.Button WorkWithAnimals;
        private System.Windows.Forms.Button food;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Low_Inventory;
        private System.Windows.Forms.Button Bed;
        private System.Windows.Forms.Button btnWho_Has_Been_Fed;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

