namespace WindowsFormsApp1
{
    partial class Animal_Inventory
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Animal_Inventory));
            this.BacktoMain = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsex = new System.Windows.Forms.TextBox();
            this.txtbreed = new System.Windows.Forms.TextBox();
            this.txtspecies = new System.Windows.Forms.TextBox();
            this.txtanimal_name = new System.Windows.Forms.TextBox();
            this.arrival_date = new System.Windows.Forms.Label();
            this.Sex = new System.Windows.Forms.Label();
            this.dtpdob = new System.Windows.Forms.DateTimePicker();
            this.Species = new System.Windows.Forms.Label();
            this.Animal_Name = new System.Windows.Forms.Label();
            this.TagID = new System.Windows.Forms.Label();
            this.txttagID = new System.Windows.Forms.TextBox();
            this.breed = new System.Windows.Forms.Label();
            this.txtphoto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txthealth_concerns = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tagIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.healthconcernsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.ranchAnimalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ranch_Animal_DataSet = new WindowsFormsApp1.Ranch_Animal_DataSet();
            this.ranch_AnimalTableAdapter = new WindowsFormsApp1.Ranch_Animal_DataSetTableAdapters.Ranch_AnimalTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.btnARemove = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbBed = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranchAnimalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranch_Animal_DataSet)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BacktoMain
            // 
            this.BacktoMain.Location = new System.Drawing.Point(3, 126);
            this.BacktoMain.Name = "BacktoMain";
            this.BacktoMain.Size = new System.Drawing.Size(75, 23);
            this.BacktoMain.TabIndex = 11;
            this.BacktoMain.Text = "Back";
            this.BacktoMain.UseVisualStyleBackColor = true;
            this.BacktoMain.Click += new System.EventHandler(this.BacktoMain_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtsex, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtbreed, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtspecies, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtanimal_name, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.arrival_date, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Sex, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dtpdob, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.Species, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Animal_Name, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TagID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txttagID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.breed, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtphoto, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txthealth_concerns, 1, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(381, 274);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Health Concerns";
            // 
            // txtsex
            // 
            this.txtsex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtsex.Location = new System.Drawing.Point(130, 139);
            this.txtsex.Name = "txtsex";
            this.txtsex.Size = new System.Drawing.Size(248, 20);
            this.txtsex.TabIndex = 15;
            // 
            // txtbreed
            // 
            this.txtbreed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbreed.Location = new System.Drawing.Point(130, 105);
            this.txtbreed.Name = "txtbreed";
            this.txtbreed.Size = new System.Drawing.Size(248, 20);
            this.txtbreed.TabIndex = 14;
            // 
            // txtspecies
            // 
            this.txtspecies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtspecies.Location = new System.Drawing.Point(130, 71);
            this.txtspecies.Name = "txtspecies";
            this.txtspecies.Size = new System.Drawing.Size(248, 20);
            this.txtspecies.TabIndex = 13;
            this.txtspecies.TextChanged += new System.EventHandler(this.txtspecies_TextChanged);
            // 
            // txtanimal_name
            // 
            this.txtanimal_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtanimal_name.Location = new System.Drawing.Point(130, 37);
            this.txtanimal_name.Name = "txtanimal_name";
            this.txtanimal_name.Size = new System.Drawing.Size(248, 20);
            this.txtanimal_name.TabIndex = 12;
            // 
            // arrival_date
            // 
            this.arrival_date.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.arrival_date.AutoSize = true;
            this.arrival_date.Location = new System.Drawing.Point(62, 180);
            this.arrival_date.Name = "arrival_date";
            this.arrival_date.Size = new System.Drawing.Size(62, 13);
            this.arrival_date.TabIndex = 10;
            this.arrival_date.Text = "Arrival Date";
            // 
            // Sex
            // 
            this.Sex.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Sex.AutoSize = true;
            this.Sex.Location = new System.Drawing.Point(99, 146);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(25, 13);
            this.Sex.TabIndex = 8;
            this.Sex.Text = "Sex";
            // 
            // dtpdob
            // 
            this.dtpdob.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpdob.Location = new System.Drawing.Point(130, 173);
            this.dtpdob.Name = "dtpdob";
            this.dtpdob.Size = new System.Drawing.Size(248, 20);
            this.dtpdob.TabIndex = 1;
            // 
            // Species
            // 
            this.Species.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Species.AutoSize = true;
            this.Species.Location = new System.Drawing.Point(79, 78);
            this.Species.Name = "Species";
            this.Species.Size = new System.Drawing.Size(45, 13);
            this.Species.TabIndex = 4;
            this.Species.Text = "Species";
            // 
            // Animal_Name
            // 
            this.Animal_Name.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Animal_Name.AutoSize = true;
            this.Animal_Name.Location = new System.Drawing.Point(55, 44);
            this.Animal_Name.Name = "Animal_Name";
            this.Animal_Name.Size = new System.Drawing.Size(69, 13);
            this.Animal_Name.TabIndex = 2;
            this.Animal_Name.Text = "Animal Name";
            // 
            // TagID
            // 
            this.TagID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TagID.AutoSize = true;
            this.TagID.Location = new System.Drawing.Point(87, 10);
            this.TagID.Name = "TagID";
            this.TagID.Size = new System.Drawing.Size(37, 13);
            this.TagID.TabIndex = 0;
            this.TagID.Text = "TagID";
            // 
            // txttagID
            // 
            this.txttagID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txttagID.Location = new System.Drawing.Point(130, 3);
            this.txttagID.Name = "txttagID";
            this.txttagID.Size = new System.Drawing.Size(248, 20);
            this.txttagID.TabIndex = 11;
            // 
            // breed
            // 
            this.breed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.breed.AutoSize = true;
            this.breed.Location = new System.Drawing.Point(89, 112);
            this.breed.Name = "breed";
            this.breed.Size = new System.Drawing.Size(35, 13);
            this.breed.TabIndex = 6;
            this.breed.Text = "Breed";
            // 
            // txtphoto
            // 
            this.txtphoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtphoto.Location = new System.Drawing.Point(130, 207);
            this.txtphoto.Name = "txtphoto";
            this.txtphoto.Size = new System.Drawing.Size(248, 20);
            this.txtphoto.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Photo";
            // 
            // txthealth_concerns
            // 
            this.txthealth_concerns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txthealth_concerns.Location = new System.Drawing.Point(130, 241);
            this.txthealth_concerns.Name = "txthealth_concerns";
            this.txthealth_concerns.Size = new System.Drawing.Size(248, 20);
            this.txthealth_concerns.TabIndex = 19;
            this.txthealth_concerns.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(414, 264);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(75, 23);
            this.btnbrowse.TabIndex = 12;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tagIDDataGridViewTextBoxColumn,
            this.animalnameDataGridViewTextBoxColumn,
            this.birthdateDataGridViewTextBoxColumn,
            this.speciesDataGridViewTextBoxColumn,
            this.breedDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.healthconcernsDataGridViewTextBoxColumn,
            this.photoDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.ranchAnimalBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 347);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(845, 213);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tagIDDataGridViewTextBoxColumn
            // 
            this.tagIDDataGridViewTextBoxColumn.DataPropertyName = "tagID";
            this.tagIDDataGridViewTextBoxColumn.HeaderText = "tagID";
            this.tagIDDataGridViewTextBoxColumn.Name = "tagIDDataGridViewTextBoxColumn";
            // 
            // animalnameDataGridViewTextBoxColumn
            // 
            this.animalnameDataGridViewTextBoxColumn.DataPropertyName = "animal_name";
            this.animalnameDataGridViewTextBoxColumn.HeaderText = "animal_name";
            this.animalnameDataGridViewTextBoxColumn.Name = "animalnameDataGridViewTextBoxColumn";
            // 
            // birthdateDataGridViewTextBoxColumn
            // 
            this.birthdateDataGridViewTextBoxColumn.DataPropertyName = "birthdate";
            this.birthdateDataGridViewTextBoxColumn.HeaderText = "birthdate";
            this.birthdateDataGridViewTextBoxColumn.Name = "birthdateDataGridViewTextBoxColumn";
            // 
            // speciesDataGridViewTextBoxColumn
            // 
            this.speciesDataGridViewTextBoxColumn.DataPropertyName = "species";
            this.speciesDataGridViewTextBoxColumn.HeaderText = "species";
            this.speciesDataGridViewTextBoxColumn.Name = "speciesDataGridViewTextBoxColumn";
            // 
            // breedDataGridViewTextBoxColumn
            // 
            this.breedDataGridViewTextBoxColumn.DataPropertyName = "breed";
            this.breedDataGridViewTextBoxColumn.HeaderText = "breed";
            this.breedDataGridViewTextBoxColumn.Name = "breedDataGridViewTextBoxColumn";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            // 
            // healthconcernsDataGridViewTextBoxColumn
            // 
            this.healthconcernsDataGridViewTextBoxColumn.DataPropertyName = "health_concerns";
            this.healthconcernsDataGridViewTextBoxColumn.HeaderText = "health_concerns";
            this.healthconcernsDataGridViewTextBoxColumn.Name = "healthconcernsDataGridViewTextBoxColumn";
            // 
            // photoDataGridViewImageColumn
            // 
            this.photoDataGridViewImageColumn.DataPropertyName = "photo";
            this.photoDataGridViewImageColumn.HeaderText = "photo";
            this.photoDataGridViewImageColumn.Name = "photoDataGridViewImageColumn";
            // 
            // ranchAnimalBindingSource
            // 
            this.ranchAnimalBindingSource.DataMember = "Ranch_Animal";
            this.ranchAnimalBindingSource.DataSource = this.ranch_Animal_DataSet;
            // 
            // ranch_Animal_DataSet
            // 
            this.ranch_Animal_DataSet.DataSetName = "Ranch_Animal_DataSet";
            this.ranch_Animal_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ranch_AnimalTableAdapter
            // 
            this.ranch_AnimalTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnARemove
            // 
            this.btnARemove.Location = new System.Drawing.Point(3, 85);
            this.btnARemove.Name = "btnARemove";
            this.btnARemove.Size = new System.Drawing.Size(75, 23);
            this.btnARemove.TabIndex = 15;
            this.btnARemove.Text = "Remove";
            this.btnARemove.UseVisualStyleBackColor = true;
            this.btnARemove.Click += new System.EventHandler(this.btnARemove_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BacktoMain, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.button2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnARemove, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(873, 374);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(85, 167);
            this.tableLayoutPanel2.TabIndex = 45;
            // 
            // lbBed
            // 
            this.lbBed.AutoSize = true;
            this.lbBed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBed.Location = new System.Drawing.Point(12, 18);
            this.lbBed.Name = "lbBed";
            this.lbBed.Size = new System.Drawing.Size(171, 25);
            this.lbBed.TabIndex = 26;
            this.lbBed.Text = "Animal Inventory";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(584, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 311);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // Animal_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 572);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.lbBed);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnbrowse);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Animal_Inventory";
            this.Text = "Animal Inventory";
            this.Load += new System.EventHandler(this.frmAnimals_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranchAnimalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranch_Animal_DataSet)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BacktoMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtsex;
        private System.Windows.Forms.TextBox txtbreed;
        private System.Windows.Forms.TextBox txtspecies;
        private System.Windows.Forms.TextBox txtanimal_name;
        private System.Windows.Forms.Label arrival_date;
        private System.Windows.Forms.Label Sex;
        private System.Windows.Forms.DateTimePicker dtpdob;
        private System.Windows.Forms.Label Species;
        private System.Windows.Forms.Label Animal_Name;
        private System.Windows.Forms.Label TagID;
        private System.Windows.Forms.TextBox txttagID;
        private System.Windows.Forms.Label breed;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtphoto;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Ranch_Animal_DataSet ranch_Animal_DataSet;
        private System.Windows.Forms.BindingSource ranchAnimalBindingSource;
        private Ranch_Animal_DataSetTableAdapters.Ranch_AnimalTableAdapter ranch_AnimalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn breedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn healthconcernsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn photoDataGridViewImageColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txthealth_concerns;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnARemove;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbBed;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}