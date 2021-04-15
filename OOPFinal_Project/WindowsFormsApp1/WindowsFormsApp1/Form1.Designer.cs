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
            this.UsersForm = new System.Windows.Forms.Button();
            this.Animal = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.WorkWithAnimals = new System.Windows.Forms.Button();
            this.food = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.ControlText;
            label1.Location = new System.Drawing.Point(17, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(490, 36);
            label1.TabIndex = 19;
            label1.Text = "Welcome to Ranch Database";
            // 
            // UsersForm
            // 
            this.UsersForm.Location = new System.Drawing.Point(131, 371);
            this.UsersForm.Name = "UsersForm";
            this.UsersForm.Size = new System.Drawing.Size(75, 23);
            this.UsersForm.TabIndex = 13;
            this.UsersForm.Text = "Users";
            this.UsersForm.UseVisualStyleBackColor = true;
            // 
            // Animal
            // 
            this.Animal.Location = new System.Drawing.Point(207, 419);
            this.Animal.Name = "Animal";
            this.Animal.Size = new System.Drawing.Size(75, 23);
            this.Animal.TabIndex = 14;
            this.Animal.Text = "Animals";
            this.Animal.UseVisualStyleBackColor = true;
            this.Animal.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Mineral Tub";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // WorkWithAnimals
            // 
            this.WorkWithAnimals.Location = new System.Drawing.Point(251, 371);
            this.WorkWithAnimals.Name = "WorkWithAnimals";
            this.WorkWithAnimals.Size = new System.Drawing.Size(147, 23);
            this.WorkWithAnimals.TabIndex = 16;
            this.WorkWithAnimals.Text = "Work With Animals";
            this.WorkWithAnimals.UseVisualStyleBackColor = true;
            // 
            // food
            // 
            this.food.Location = new System.Drawing.Point(340, 419);
            this.food.Name = "food";
            this.food.Size = new System.Drawing.Size(75, 23);
            this.food.TabIndex = 17;
            this.food.Text = "Food";
            this.food.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(131, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 241);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.button2.Location = new System.Drawing.Point(177, 475);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Low Inventory";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // RanchDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 565);
            this.Controls.Add(this.button2);
            this.Controls.Add(label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.food);
            this.Controls.Add(this.WorkWithAnimals);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Animal);
            this.Controls.Add(this.UsersForm);
            this.Name = "RanchDatabase";
            this.Text = "Ranch Datatbase";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UsersForm;
        private System.Windows.Forms.Button Animal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button WorkWithAnimals;
        private System.Windows.Forms.Button food;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}

