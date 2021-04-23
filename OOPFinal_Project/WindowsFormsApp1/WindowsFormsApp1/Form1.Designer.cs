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
            this.Animal = new System.Windows.Forms.Button();
            this.MineralTub = new System.Windows.Forms.Button();
            this.WorkWithAnimals = new System.Windows.Forms.Button();
            this.food = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Low_Inventory = new System.Windows.Forms.Button();
            this.Bed = new System.Windows.Forms.Button();
            this.btnWho_Has_Been_Fed = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.ControlText;
            label1.Location = new System.Drawing.Point(12, 37);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(490, 36);
            label1.TabIndex = 19;
            label1.Text = "Welcome to Ranch Database";
            // 
            // Animal
            // 
            this.Animal.Location = new System.Drawing.Point(177, 419);
            this.Animal.Name = "Animal";
            this.Animal.Size = new System.Drawing.Size(75, 23);
            this.Animal.TabIndex = 14;
            this.Animal.Text = "Animals";
            this.Animal.UseVisualStyleBackColor = true;
            this.Animal.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MineralTub
            // 
            this.MineralTub.Location = new System.Drawing.Point(96, 419);
            this.MineralTub.Name = "MineralTub";
            this.MineralTub.Size = new System.Drawing.Size(75, 23);
            this.MineralTub.TabIndex = 15;
            this.MineralTub.Text = "Mineral Tub";
            this.MineralTub.UseVisualStyleBackColor = true;
            this.MineralTub.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // WorkWithAnimals
            // 
            this.WorkWithAnimals.Location = new System.Drawing.Point(177, 380);
            this.WorkWithAnimals.Name = "WorkWithAnimals";
            this.WorkWithAnimals.Size = new System.Drawing.Size(147, 23);
            this.WorkWithAnimals.TabIndex = 16;
            this.WorkWithAnimals.Text = "Work With Animals";
            this.WorkWithAnimals.UseVisualStyleBackColor = true;
            this.WorkWithAnimals.Click += new System.EventHandler(this.WorkWithAnimals_Click);
            // 
            // food
            // 
            this.food.Location = new System.Drawing.Point(258, 419);
            this.food.Name = "food";
            this.food.Size = new System.Drawing.Size(75, 23);
            this.food.TabIndex = 17;
            this.food.Text = "Feed";
            this.food.UseVisualStyleBackColor = true;
            this.food.Click += new System.EventHandler(this.food_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(128, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 241);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Low_Inventory
            // 
            this.Low_Inventory.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.Low_Inventory.Location = new System.Drawing.Point(96, 458);
            this.Low_Inventory.Name = "Low_Inventory";
            this.Low_Inventory.Size = new System.Drawing.Size(143, 23);
            this.Low_Inventory.TabIndex = 20;
            this.Low_Inventory.Text = "Low Inventory";
            this.Low_Inventory.UseVisualStyleBackColor = true;
            this.Low_Inventory.Click += new System.EventHandler(this.button2_Click);
            // 
            // Bed
            // 
            this.Bed.Location = new System.Drawing.Point(339, 419);
            this.Bed.Name = "Bed";
            this.Bed.Size = new System.Drawing.Size(75, 23);
            this.Bed.TabIndex = 21;
            this.Bed.Text = "Bedding";
            this.Bed.UseVisualStyleBackColor = true;
            this.Bed.Click += new System.EventHandler(this.Bed_Click);
            // 
            // btnWho_Has_Been_Fed
            // 
            this.btnWho_Has_Been_Fed.Location = new System.Drawing.Point(267, 458);
            this.btnWho_Has_Been_Fed.Name = "btnWho_Has_Been_Fed";
            this.btnWho_Has_Been_Fed.Size = new System.Drawing.Size(147, 23);
            this.btnWho_Has_Been_Fed.TabIndex = 22;
            this.btnWho_Has_Been_Fed.Text = "Who Has Been Fed";
            this.btnWho_Has_Been_Fed.UseVisualStyleBackColor = true;
            this.btnWho_Has_Been_Fed.Click += new System.EventHandler(this.btnWho_Has_Been_Fed_Click);
            // 
            // RanchDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 565);
            this.Controls.Add(this.btnWho_Has_Been_Fed);
            this.Controls.Add(this.Bed);
            this.Controls.Add(this.Low_Inventory);
            this.Controls.Add(label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.food);
            this.Controls.Add(this.WorkWithAnimals);
            this.Controls.Add(this.MineralTub);
            this.Controls.Add(this.Animal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RanchDatabase";
            this.Text = "Ranch Datatbase";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}

