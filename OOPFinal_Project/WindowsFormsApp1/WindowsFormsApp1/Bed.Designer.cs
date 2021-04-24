namespace WindowsFormsApp1
{
    partial class Bed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bed));
            this.tbAvg_Replacement_Rate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DateCreated = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.UserPassword = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbquantity = new System.Windows.Forms.TextBox();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.cbMaterial = new System.Windows.Forms.ComboBox();
            this.lbBed = new System.Windows.Forms.Label();
            this.beddingInventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bedRanchDataSet = new WindowsFormsApp1.BedRanchDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bedding_InventoryTableAdapter = new WindowsFormsApp1.BedRanchDataSetTableAdapters.Bedding_InventoryTableAdapter();
            this.dgvBedding = new System.Windows.Forms.DataGridView();
            this.bedding_Quantity_RanchDataSet = new WindowsFormsApp1.Bedding_Quantity_RanchDataSet();
            this.beddingInventoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bedding_InventoryTableAdapter1 = new WindowsFormsApp1.Bedding_Quantity_RanchDataSetTableAdapters.Bedding_InventoryTableAdapter();
            this.bedIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgreplacementrateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beddingInventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedRanchDataSet)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBedding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedding_Quantity_RanchDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beddingInventoryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAvg_Replacement_Rate
            // 
            this.tbAvg_Replacement_Rate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAvg_Replacement_Rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAvg_Replacement_Rate.Location = new System.Drawing.Point(165, 211);
            this.tbAvg_Replacement_Rate.Multiline = true;
            this.tbAvg_Replacement_Rate.Name = "tbAvg_Replacement_Rate";
            this.tbAvg_Replacement_Rate.Size = new System.Drawing.Size(321, 46);
            this.tbAvg_Replacement_Rate.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 52);
            this.label1.TabIndex = 16;
            this.label1.Text = "Price";
            // 
            // DateCreated
            // 
            this.DateCreated.AutoSize = true;
            this.DateCreated.Dock = System.Windows.Forms.DockStyle.Right;
            this.DateCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateCreated.Location = new System.Drawing.Point(11, 208);
            this.DateCreated.Name = "DateCreated";
            this.DateCreated.Size = new System.Drawing.Size(148, 52);
            this.DateCreated.TabIndex = 10;
            this.DateCreated.Text = "Avg Replacement Rate";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Dock = System.Windows.Forms.DockStyle.Right;
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(103, 52);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(56, 52);
            this.LastName.TabIndex = 6;
            this.LastName.Text = "Quantity";
            // 
            // UserPassword
            // 
            this.UserPassword.AutoSize = true;
            this.UserPassword.Dock = System.Windows.Forms.DockStyle.Right;
            this.UserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPassword.Location = new System.Drawing.Point(103, 0);
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.Size = new System.Drawing.Size(56, 52);
            this.UserPassword.TabIndex = 2;
            this.UserPassword.Text = "Material";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66667F));
            this.tableLayoutPanel1.Controls.Add(this.tbquantity, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbUnit, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbPrice, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.LastName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbAvg_Replacement_Rate, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.DateCreated, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbMaterial, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.UserPassword, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 68);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(489, 260);
            this.tableLayoutPanel1.TabIndex = 8;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tbquantity
            // 
            this.tbquantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbquantity.Location = new System.Drawing.Point(165, 55);
            this.tbquantity.Name = "tbquantity";
            this.tbquantity.Size = new System.Drawing.Size(321, 21);
            this.tbquantity.TabIndex = 47;
            // 
            // cbUnit
            // 
            this.cbUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Items.AddRange(new object[] {
            "Handful ",
            "Small Pale",
            "5 Gallon Bucket ",
            "Skidloader Bucket ",
            "Hand Scoop",
            "Round Bale",
            "Wrapped Round Bale",
            "Square Bale",
            "Bag"});
            this.cbUnit.Location = new System.Drawing.Point(165, 107);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(321, 23);
            this.cbUnit.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 52);
            this.label3.TabIndex = 47;
            this.label3.Text = "Unit";
            // 
            // tbPrice
            // 
            this.tbPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(165, 159);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(321, 21);
            this.tbPrice.TabIndex = 25;
            // 
            // cbMaterial
            // 
            this.cbMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaterial.FormattingEnabled = true;
            this.cbMaterial.Items.AddRange(new object[] {
            "Staw",
            "Shavings",
            "Cornstalks"});
            this.cbMaterial.Location = new System.Drawing.Point(165, 3);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(321, 23);
            this.cbMaterial.TabIndex = 26;
            // 
            // lbBed
            // 
            this.lbBed.AutoSize = true;
            this.lbBed.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBed.Location = new System.Drawing.Point(7, 21);
            this.lbBed.Name = "lbBed";
            this.lbBed.Size = new System.Drawing.Size(206, 29);
            this.lbBed.TabIndex = 24;
            this.lbBed.Text = "Bedding Inventory";
            // 
            // beddingInventoryBindingSource
            // 
            this.beddingInventoryBindingSource.DataMember = "Bedding_Inventory";
            this.beddingInventoryBindingSource.DataSource = this.bedRanchDataSet;
            // 
            // bedRanchDataSet
            // 
            this.bedRanchDataSet.DataSetName = "BedRanchDataSet";
            this.bedRanchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 27);
            this.button1.TabIndex = 26;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(3, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(96, 27);
            this.btnSubmit.TabIndex = 25;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(552, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(555, 42);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(238, 22);
            this.dtpDate.TabIndex = 29;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 27);
            this.button2.TabIndex = 33;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnSubmit, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(753, 415);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(102, 99);
            this.tableLayoutPanel2.TabIndex = 45;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(542, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 277);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // bedding_InventoryTableAdapter
            // 
            this.bedding_InventoryTableAdapter.ClearBeforeFill = true;
            // 
            // dgvBedding
            // 
            this.dgvBedding.AutoGenerateColumns = false;
            this.dgvBedding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBedding.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bedIDDataGridViewTextBoxColumn1,
            this.materialDataGridViewTextBoxColumn1,
            this.quantityDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1,
            this.avgreplacementrateDataGridViewTextBoxColumn1,
            this.dateDataGridViewTextBoxColumn1});
            this.dgvBedding.DataSource = this.beddingInventoryBindingSource1;
            this.dgvBedding.Location = new System.Drawing.Point(12, 357);
            this.dgvBedding.Name = "dgvBedding";
            this.dgvBedding.Size = new System.Drawing.Size(730, 206);
            this.dgvBedding.TabIndex = 47;
            // 
            // bedding_Quantity_RanchDataSet
            // 
            this.bedding_Quantity_RanchDataSet.DataSetName = "Bedding_Quantity_RanchDataSet";
            this.bedding_Quantity_RanchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // beddingInventoryBindingSource1
            // 
            this.beddingInventoryBindingSource1.DataMember = "Bedding_Inventory";
            this.beddingInventoryBindingSource1.DataSource = this.bedding_Quantity_RanchDataSet;
            // 
            // bedding_InventoryTableAdapter1
            // 
            this.bedding_InventoryTableAdapter1.ClearBeforeFill = true;
            // 
            // bedIDDataGridViewTextBoxColumn1
            // 
            this.bedIDDataGridViewTextBoxColumn1.DataPropertyName = "bedID";
            this.bedIDDataGridViewTextBoxColumn1.HeaderText = "bedID";
            this.bedIDDataGridViewTextBoxColumn1.Name = "bedIDDataGridViewTextBoxColumn1";
            this.bedIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // materialDataGridViewTextBoxColumn1
            // 
            this.materialDataGridViewTextBoxColumn1.DataPropertyName = "Material";
            this.materialDataGridViewTextBoxColumn1.HeaderText = "Material";
            this.materialDataGridViewTextBoxColumn1.Name = "materialDataGridViewTextBoxColumn1";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // unitDataGridViewTextBoxColumn1
            // 
            this.unitDataGridViewTextBoxColumn1.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn1.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn1.Name = "unitDataGridViewTextBoxColumn1";
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            // 
            // avgreplacementrateDataGridViewTextBoxColumn1
            // 
            this.avgreplacementrateDataGridViewTextBoxColumn1.DataPropertyName = "avg_replacement_rate";
            this.avgreplacementrateDataGridViewTextBoxColumn1.HeaderText = "avg_replacement_rate";
            this.avgreplacementrateDataGridViewTextBoxColumn1.Name = "avgreplacementrateDataGridViewTextBoxColumn1";
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn1.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            // 
            // Bed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 572);
            this.Controls.Add(this.dgvBedding);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lbBed);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bed";
            this.Text = "Bed";
            this.Load += new System.EventHandler(this.Bed_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beddingInventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedRanchDataSet)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBedding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedding_Quantity_RanchDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beddingInventoryBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbAvg_Replacement_Rate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DateCreated;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label UserPassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbBed;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbMaterial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbquantity;
        private BedRanchDataSet bedRanchDataSet;
        private System.Windows.Forms.BindingSource beddingInventoryBindingSource;
        private BedRanchDataSetTableAdapters.Bedding_InventoryTableAdapter bedding_InventoryTableAdapter;
        private System.Windows.Forms.DataGridView dgvBedding;
        private Bedding_Quantity_RanchDataSet bedding_Quantity_RanchDataSet;
        private System.Windows.Forms.BindingSource beddingInventoryBindingSource1;
        private Bedding_Quantity_RanchDataSetTableAdapters.Bedding_InventoryTableAdapter bedding_InventoryTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgreplacementrateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}