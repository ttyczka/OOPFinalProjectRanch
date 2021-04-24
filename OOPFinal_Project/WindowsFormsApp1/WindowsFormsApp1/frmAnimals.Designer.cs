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
            this.label2 = new System.Windows.Forms.Label();
            this.txtsex = new System.Windows.Forms.TextBox();
            this.txtbreed = new System.Windows.Forms.TextBox();
            this.txtspecies = new System.Windows.Forms.TextBox();
            this.arrival_date = new System.Windows.Forms.Label();
            this.Sex = new System.Windows.Forms.Label();
            this.dtpdob = new System.Windows.Forms.DateTimePicker();
            this.Species = new System.Windows.Forms.Label();
            this.Animal_Name = new System.Windows.Forms.Label();
            this.breed = new System.Windows.Forms.Label();
            this.txtphoto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txthealth_concerns = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.ranchAnimalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ranch_Animal_DataSet = new WindowsFormsApp1.Ranch_Animal_DataSet();
            this.ranch_AnimalTableAdapter = new WindowsFormsApp1.Ranch_Animal_DataSetTableAdapters.Ranch_AnimalTableAdapter();
            this.btnARemove = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbBed = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txttagID = new System.Windows.Forms.TextBox();
            this.txtanimal_name = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TagID = new System.Windows.Forms.Label();
            this.animals_With_ArrivalDateRanchDataSet = new WindowsFormsApp1.Animals_With_ArrivalDateRanchDataSet();
            this.ranchAnimalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ranch_AnimalTableAdapter1 = new WindowsFormsApp1.Animals_With_ArrivalDateRanchDataSetTableAdapters.Ranch_AnimalTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tagIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivaldateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breedDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.healthconcernsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ranchAnimalBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ranchAnimalwithArrivalDateRanchDataSet = new WindowsFormsApp1.RanchAnimalwithArrivalDateRanchDataSet();
            this.ranch_AnimalTableAdapter2 = new WindowsFormsApp1.RanchAnimalwithArrivalDateRanchDataSetTableAdapters.Ranch_AnimalTableAdapter();
            this.BacktoMain = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ranchAnimalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranch_Animal_DataSet)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animals_With_ArrivalDateRanchDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranchAnimalBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranchAnimalBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranchAnimalwithArrivalDateRanchDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 39);
            this.label2.TabIndex = 18;
            this.label2.Text = "Health Concerns";
            // 
            // txtsex
            // 
            this.txtsex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtsex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsex.Location = new System.Drawing.Point(133, 143);
            this.txtsex.Name = "txtsex";
            this.txtsex.Size = new System.Drawing.Size(255, 21);
            this.txtsex.TabIndex = 15;
            // 
            // txtbreed
            // 
            this.txtbreed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbreed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbreed.Location = new System.Drawing.Point(133, 108);
            this.txtbreed.Name = "txtbreed";
            this.txtbreed.Size = new System.Drawing.Size(255, 21);
            this.txtbreed.TabIndex = 14;
            // 
            // txtspecies
            // 
            this.txtspecies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtspecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtspecies.Location = new System.Drawing.Point(133, 73);
            this.txtspecies.Name = "txtspecies";
            this.txtspecies.Size = new System.Drawing.Size(255, 21);
            this.txtspecies.TabIndex = 13;
            this.txtspecies.TextChanged += new System.EventHandler(this.txtspecies_TextChanged);
            // 
            // arrival_date
            // 
            this.arrival_date.AutoSize = true;
            this.arrival_date.Dock = System.Windows.Forms.DockStyle.Right;
            this.arrival_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrival_date.Location = new System.Drawing.Point(49, 175);
            this.arrival_date.Name = "arrival_date";
            this.arrival_date.Size = new System.Drawing.Size(78, 35);
            this.arrival_date.TabIndex = 10;
            this.arrival_date.Text = "Arrival Date";
            // 
            // Sex
            // 
            this.Sex.AutoSize = true;
            this.Sex.Dock = System.Windows.Forms.DockStyle.Right;
            this.Sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sex.Location = new System.Drawing.Point(96, 140);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(31, 35);
            this.Sex.TabIndex = 8;
            this.Sex.Text = "Sex";
            // 
            // dtpdob
            // 
            this.dtpdob.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpdob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdob.Location = new System.Drawing.Point(133, 178);
            this.dtpdob.Name = "dtpdob";
            this.dtpdob.Size = new System.Drawing.Size(255, 21);
            this.dtpdob.TabIndex = 1;
            // 
            // Species
            // 
            this.Species.AutoSize = true;
            this.Species.Dock = System.Windows.Forms.DockStyle.Right;
            this.Species.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Species.Location = new System.Drawing.Point(69, 70);
            this.Species.Name = "Species";
            this.Species.Size = new System.Drawing.Size(58, 35);
            this.Species.TabIndex = 4;
            this.Species.Text = "Species";
            // 
            // Animal_Name
            // 
            this.Animal_Name.AutoSize = true;
            this.Animal_Name.Dock = System.Windows.Forms.DockStyle.Right;
            this.Animal_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animal_Name.Location = new System.Drawing.Point(38, 35);
            this.Animal_Name.Name = "Animal_Name";
            this.Animal_Name.Size = new System.Drawing.Size(89, 35);
            this.Animal_Name.TabIndex = 2;
            this.Animal_Name.Text = "Animal Name";
            // 
            // breed
            // 
            this.breed.AutoSize = true;
            this.breed.Dock = System.Windows.Forms.DockStyle.Right;
            this.breed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breed.Location = new System.Drawing.Point(82, 105);
            this.breed.Name = "breed";
            this.breed.Size = new System.Drawing.Size(45, 35);
            this.breed.TabIndex = 6;
            this.breed.Text = "Breed";
            // 
            // txtphoto
            // 
            this.txtphoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtphoto.Location = new System.Drawing.Point(133, 213);
            this.txtphoto.Name = "txtphoto";
            this.txtphoto.Size = new System.Drawing.Size(255, 20);
            this.txtphoto.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 35);
            this.label1.TabIndex = 16;
            this.label1.Text = "Photo";
            // 
            // txthealth_concerns
            // 
            this.txthealth_concerns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txthealth_concerns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthealth_concerns.Location = new System.Drawing.Point(133, 248);
            this.txthealth_concerns.Name = "txthealth_concerns";
            this.txthealth_concerns.Size = new System.Drawing.Size(255, 21);
            this.txthealth_concerns.TabIndex = 19;
            this.txthealth_concerns.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnbrowse
            // 
            this.btnbrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrowse.Location = new System.Drawing.Point(411, 263);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(75, 23);
            this.btnbrowse.TabIndex = 12;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
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
            // btnARemove
            // 
            this.btnARemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnARemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnARemove.Location = new System.Drawing.Point(3, 69);
            this.btnARemove.Name = "btnARemove";
            this.btnARemove.Size = new System.Drawing.Size(90, 27);
            this.btnARemove.TabIndex = 15;
            this.btnARemove.Text = "Inactivate";
            this.btnARemove.UseVisualStyleBackColor = true;
            this.btnARemove.Click += new System.EventHandler(this.btnARemove_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.Delete, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BacktoMain, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnARemove, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(973, 394);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(96, 133);
            this.tableLayoutPanel2.TabIndex = 45;
            // 
            // lbBed
            // 
            this.lbBed.AutoSize = true;
            this.lbBed.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBed.Location = new System.Drawing.Point(12, 14);
            this.lbBed.Name = "lbBed";
            this.lbBed.Size = new System.Drawing.Size(188, 29);
            this.lbBed.TabIndex = 26;
            this.lbBed.Text = "Animal Inventory";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(541, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 311);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(816, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(232, 311);
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // txttagID
            // 
            this.txttagID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txttagID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttagID.Location = new System.Drawing.Point(133, 3);
            this.txttagID.Name = "txttagID";
            this.txttagID.Size = new System.Drawing.Size(255, 21);
            this.txttagID.TabIndex = 49;
            // 
            // txtanimal_name
            // 
            this.txtanimal_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtanimal_name.Location = new System.Drawing.Point(133, 38);
            this.txtanimal_name.Name = "txtanimal_name";
            this.txtanimal_name.Size = new System.Drawing.Size(255, 20);
            this.txtanimal_name.TabIndex = 50;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66667F));
            this.tableLayoutPanel1.Controls.Add(this.TagID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txttagID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Animal_Name, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtanimal_name, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtphoto, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.Species, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtspecies, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txthealth_concerns, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.dtpdob, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.arrival_date, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtbreed, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtsex, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.breed, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Sex, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 50);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(391, 284);
            this.tableLayoutPanel1.TabIndex = 51;
            // 
            // TagID
            // 
            this.TagID.AutoSize = true;
            this.TagID.Dock = System.Windows.Forms.DockStyle.Right;
            this.TagID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TagID.Location = new System.Drawing.Point(81, 0);
            this.TagID.Name = "TagID";
            this.TagID.Size = new System.Drawing.Size(46, 35);
            this.TagID.TabIndex = 51;
            this.TagID.Text = "TagID";
            this.TagID.Click += new System.EventHandler(this.label4_Click);
            // 
            // animals_With_ArrivalDateRanchDataSet
            // 
            this.animals_With_ArrivalDateRanchDataSet.DataSetName = "Animals_With_ArrivalDateRanchDataSet";
            this.animals_With_ArrivalDateRanchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ranchAnimalBindingSource1
            // 
            this.ranchAnimalBindingSource1.DataMember = "Ranch_Animal";
            this.ranchAnimalBindingSource1.DataSource = this.animals_With_ArrivalDateRanchDataSet;
            // 
            // ranch_AnimalTableAdapter1
            // 
            this.ranch_AnimalTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tagIDDataGridViewTextBoxColumn1,
            this.animalnameDataGridViewTextBoxColumn1,
            this.arrivaldateDataGridViewTextBoxColumn,
            this.speciesDataGridViewTextBoxColumn1,
            this.breedDataGridViewTextBoxColumn1,
            this.sexDataGridViewTextBoxColumn1,
            this.healthconcernsDataGridViewTextBoxColumn1,
            this.photoDataGridViewImageColumn1,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ranchAnimalBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(17, 348);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(946, 212);
            this.dataGridView1.TabIndex = 52;
            // 
            // tagIDDataGridViewTextBoxColumn1
            // 
            this.tagIDDataGridViewTextBoxColumn1.DataPropertyName = "tagID";
            this.tagIDDataGridViewTextBoxColumn1.HeaderText = "tagID";
            this.tagIDDataGridViewTextBoxColumn1.Name = "tagIDDataGridViewTextBoxColumn1";
            // 
            // animalnameDataGridViewTextBoxColumn1
            // 
            this.animalnameDataGridViewTextBoxColumn1.DataPropertyName = "animal_name";
            this.animalnameDataGridViewTextBoxColumn1.HeaderText = "animal_name";
            this.animalnameDataGridViewTextBoxColumn1.Name = "animalnameDataGridViewTextBoxColumn1";
            // 
            // arrivaldateDataGridViewTextBoxColumn
            // 
            this.arrivaldateDataGridViewTextBoxColumn.DataPropertyName = "arrival_date";
            this.arrivaldateDataGridViewTextBoxColumn.HeaderText = "arrival_date";
            this.arrivaldateDataGridViewTextBoxColumn.Name = "arrivaldateDataGridViewTextBoxColumn";
            // 
            // speciesDataGridViewTextBoxColumn1
            // 
            this.speciesDataGridViewTextBoxColumn1.DataPropertyName = "species";
            this.speciesDataGridViewTextBoxColumn1.HeaderText = "species";
            this.speciesDataGridViewTextBoxColumn1.Name = "speciesDataGridViewTextBoxColumn1";
            // 
            // breedDataGridViewTextBoxColumn1
            // 
            this.breedDataGridViewTextBoxColumn1.DataPropertyName = "breed";
            this.breedDataGridViewTextBoxColumn1.HeaderText = "breed";
            this.breedDataGridViewTextBoxColumn1.Name = "breedDataGridViewTextBoxColumn1";
            // 
            // sexDataGridViewTextBoxColumn1
            // 
            this.sexDataGridViewTextBoxColumn1.DataPropertyName = "sex";
            this.sexDataGridViewTextBoxColumn1.HeaderText = "sex";
            this.sexDataGridViewTextBoxColumn1.Name = "sexDataGridViewTextBoxColumn1";
            // 
            // healthconcernsDataGridViewTextBoxColumn1
            // 
            this.healthconcernsDataGridViewTextBoxColumn1.DataPropertyName = "health_concerns";
            this.healthconcernsDataGridViewTextBoxColumn1.HeaderText = "health_concerns";
            this.healthconcernsDataGridViewTextBoxColumn1.Name = "healthconcernsDataGridViewTextBoxColumn1";
            // 
            // photoDataGridViewImageColumn1
            // 
            this.photoDataGridViewImageColumn1.DataPropertyName = "photo";
            this.photoDataGridViewImageColumn1.HeaderText = "photo";
            this.photoDataGridViewImageColumn1.Name = "photoDataGridViewImageColumn1";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // ranchAnimalBindingSource2
            // 
            this.ranchAnimalBindingSource2.DataMember = "Ranch_Animal";
            this.ranchAnimalBindingSource2.DataSource = this.ranchAnimalwithArrivalDateRanchDataSet;
            // 
            // ranchAnimalwithArrivalDateRanchDataSet
            // 
            this.ranchAnimalwithArrivalDateRanchDataSet.DataSetName = "RanchAnimalwithArrivalDateRanchDataSet";
            this.ranchAnimalwithArrivalDateRanchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ranch_AnimalTableAdapter2
            // 
            this.ranch_AnimalTableAdapter2.ClearBeforeFill = true;
            // 
            // BacktoMain
            // 
            this.BacktoMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BacktoMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BacktoMain.Location = new System.Drawing.Point(3, 102);
            this.BacktoMain.Name = "BacktoMain";
            this.BacktoMain.Size = new System.Drawing.Size(90, 28);
            this.BacktoMain.TabIndex = 11;
            this.BacktoMain.Text = "Back";
            this.BacktoMain.UseVisualStyleBackColor = true;
            this.BacktoMain.Click += new System.EventHandler(this.BacktoMain_Click);
            // 
            // Delete
            // 
            this.Delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(3, 36);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(90, 27);
            this.Delete.TabIndex = 53;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Animal_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 572);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.lbBed);
            this.Controls.Add(this.btnbrowse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Animal_Inventory";
            this.Text = "Animal Inventory";
            this.Load += new System.EventHandler(this.frmAnimals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ranchAnimalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranch_Animal_DataSet)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animals_With_ArrivalDateRanchDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranchAnimalBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranchAnimalBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranchAnimalwithArrivalDateRanchDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtsex;
        private System.Windows.Forms.TextBox txtbreed;
        private System.Windows.Forms.TextBox txtspecies;
        private System.Windows.Forms.Label arrival_date;
        private System.Windows.Forms.Label Sex;
        private System.Windows.Forms.DateTimePicker dtpdob;
        private System.Windows.Forms.Label Species;
        private System.Windows.Forms.Label Animal_Name;
        private System.Windows.Forms.Label breed;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtphoto;
        private System.Windows.Forms.Button btnbrowse;
        private Ranch_Animal_DataSet ranch_Animal_DataSet;
        private System.Windows.Forms.BindingSource ranchAnimalBindingSource;
        private Ranch_Animal_DataSetTableAdapters.Ranch_AnimalTableAdapter ranch_AnimalTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txthealth_concerns;
        private System.Windows.Forms.Button btnARemove;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbBed;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txttagID;
        private System.Windows.Forms.TextBox txtanimal_name;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label TagID;
        private Animals_With_ArrivalDateRanchDataSet animals_With_ArrivalDateRanchDataSet;
        private System.Windows.Forms.BindingSource ranchAnimalBindingSource1;
        private Animals_With_ArrivalDateRanchDataSetTableAdapters.Ranch_AnimalTableAdapter ranch_AnimalTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RanchAnimalwithArrivalDateRanchDataSet ranchAnimalwithArrivalDateRanchDataSet;
        private System.Windows.Forms.BindingSource ranchAnimalBindingSource2;
        private RanchAnimalwithArrivalDateRanchDataSetTableAdapters.Ranch_AnimalTableAdapter ranch_AnimalTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivaldateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn breedDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn healthconcernsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn photoDataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button BacktoMain;
    }
}