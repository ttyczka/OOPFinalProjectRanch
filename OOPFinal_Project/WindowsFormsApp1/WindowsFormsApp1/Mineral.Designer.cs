namespace WindowsFormsApp1
{
    partial class Mineral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mineral));
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dgvMTB = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lbBed = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbRecommended_Distribution_Rate = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.cbMineral_Name = new System.Windows.Forms.ComboBox();
            this.tbquantity = new System.Windows.Forms.TextBox();
            this.UserPassword = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DateCreated = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.mineral_TubRanchDataSet = new WindowsFormsApp1.Mineral_TubRanchDataSet();
            this.mineralTubInventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mineral_Tub_InventoryTableAdapter = new WindowsFormsApp1.Mineral_TubRanchDataSetTableAdapters.Mineral_Tub_InventoryTableAdapter();
            this.minIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mineralnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recommendedditributionrateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMTB)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mineral_TubRanchDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mineralTubInventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 42;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(561, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(564, 33);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 40;
            // 
            // dgvMTB
            // 
            this.dgvMTB.AutoGenerateColumns = false;
            this.dgvMTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMTB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.minIDDataGridViewTextBoxColumn,
            this.mineralnameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.recommendedditributionrateDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dgvMTB.DataSource = this.mineralTubInventoryBindingSource;
            this.dgvMTB.Location = new System.Drawing.Point(21, 338);
            this.dgvMTB.Name = "dgvMTB";
            this.dgvMTB.Size = new System.Drawing.Size(743, 222);
            this.dgvMTB.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(3, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 36;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lbBed
            // 
            this.lbBed.AutoSize = true;
            this.lbBed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBed.Location = new System.Drawing.Point(16, 17);
            this.lbBed.Name = "lbBed";
            this.lbBed.Size = new System.Drawing.Size(220, 25);
            this.lbBed.TabIndex = 35;
            this.lbBed.Text = "Mineral Tub Inventory";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66667F));
            this.tableLayoutPanel1.Controls.Add(this.tbRecommended_Distribution_Rate, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbPrice, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbMineral_Name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbquantity, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.UserPassword, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LastName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.DateCreated, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbSize, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 67);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(467, 246);
            this.tableLayoutPanel1.TabIndex = 34;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tbRecommended_Distribution_Rate
            // 
            this.tbRecommended_Distribution_Rate.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbRecommended_Distribution_Rate.Location = new System.Drawing.Point(158, 199);
            this.tbRecommended_Distribution_Rate.Name = "tbRecommended_Distribution_Rate";
            this.tbRecommended_Distribution_Rate.Size = new System.Drawing.Size(306, 20);
            this.tbRecommended_Distribution_Rate.TabIndex = 48;
            // 
            // tbPrice
            // 
            this.tbPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPrice.Location = new System.Drawing.Point(158, 150);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(306, 20);
            this.tbPrice.TabIndex = 47;
            // 
            // cbMineral_Name
            // 
            this.cbMineral_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbMineral_Name.FormattingEnabled = true;
            this.cbMineral_Name.Items.AddRange(new object[] {
            "Vitalix Inc. #7",
            "Vitalix Inc. #3",
            "Crystalyx Brigade"});
            this.cbMineral_Name.Location = new System.Drawing.Point(158, 3);
            this.cbMineral_Name.Name = "cbMineral_Name";
            this.cbMineral_Name.Size = new System.Drawing.Size(306, 21);
            this.cbMineral_Name.TabIndex = 43;
            // 
            // tbquantity
            // 
            this.tbquantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbquantity.Location = new System.Drawing.Point(158, 52);
            this.tbquantity.Name = "tbquantity";
            this.tbquantity.Size = new System.Drawing.Size(306, 20);
            this.tbquantity.TabIndex = 14;
            // 
            // UserPassword
            // 
            this.UserPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.UserPassword.AutoSize = true;
            this.UserPassword.Location = new System.Drawing.Point(80, 18);
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.Size = new System.Drawing.Size(72, 13);
            this.UserPassword.TabIndex = 2;
            this.UserPassword.Text = "Mineral Name";
            // 
            // LastName
            // 
            this.LastName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(106, 67);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(46, 13);
            this.LastName.TabIndex = 6;
            this.LastName.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Size";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Price";
            // 
            // DateCreated
            // 
            this.DateCreated.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DateCreated.AutoSize = true;
            this.DateCreated.Location = new System.Drawing.Point(15, 208);
            this.DateCreated.Name = "DateCreated";
            this.DateCreated.Size = new System.Drawing.Size(137, 26);
            this.DateCreated.TabIndex = 10;
            this.DateCreated.Text = "Recommended Distribution Rate";
            this.DateCreated.Click += new System.EventHandler(this.DateCreated_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.button2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnSubmit, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(780, 366);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(85, 167);
            this.tableLayoutPanel2.TabIndex = 46;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(519, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 257);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // cbSize
            // 
            this.cbSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Items.AddRange(new object[] {
            "Small Black Tub",
            "200 lb. Tub"});
            this.cbSize.Location = new System.Drawing.Point(158, 101);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(306, 21);
            this.cbSize.TabIndex = 49;
            // 
            // mineral_TubRanchDataSet
            // 
            this.mineral_TubRanchDataSet.DataSetName = "Mineral_TubRanchDataSet";
            this.mineral_TubRanchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mineralTubInventoryBindingSource
            // 
            this.mineralTubInventoryBindingSource.DataMember = "Mineral_Tub_Inventory";
            this.mineralTubInventoryBindingSource.DataSource = this.mineral_TubRanchDataSet;
            // 
            // mineral_Tub_InventoryTableAdapter
            // 
            this.mineral_Tub_InventoryTableAdapter.ClearBeforeFill = true;
            // 
            // minIDDataGridViewTextBoxColumn
            // 
            this.minIDDataGridViewTextBoxColumn.DataPropertyName = "minID";
            this.minIDDataGridViewTextBoxColumn.HeaderText = "minID";
            this.minIDDataGridViewTextBoxColumn.Name = "minIDDataGridViewTextBoxColumn";
            this.minIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mineralnameDataGridViewTextBoxColumn
            // 
            this.mineralnameDataGridViewTextBoxColumn.DataPropertyName = "Mineral_name";
            this.mineralnameDataGridViewTextBoxColumn.HeaderText = "Mineral_name";
            this.mineralnameDataGridViewTextBoxColumn.Name = "mineralnameDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // recommendedditributionrateDataGridViewTextBoxColumn
            // 
            this.recommendedditributionrateDataGridViewTextBoxColumn.DataPropertyName = "Recommended_ditribution_rate";
            this.recommendedditributionrateDataGridViewTextBoxColumn.HeaderText = "Recommended_ditribution_rate";
            this.recommendedditributionrateDataGridViewTextBoxColumn.Name = "recommendedditributionrateDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // Mineral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 572);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.dgvMTB);
            this.Controls.Add(this.lbBed);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mineral";
            this.Text = "Mineral Tub Inventory";
            this.Load += new System.EventHandler(this.Mineral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMTB)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mineral_TubRanchDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mineralTubInventoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DataGridView dgvMTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lbBed;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbquantity;
        private System.Windows.Forms.Label UserPassword;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DateCreated;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMineral_Name;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbRecommended_Distribution_Rate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbSize;
        private Mineral_TubRanchDataSet mineral_TubRanchDataSet;
        private System.Windows.Forms.BindingSource mineralTubInventoryBindingSource;
        private Mineral_TubRanchDataSetTableAdapters.Mineral_Tub_InventoryTableAdapter mineral_Tub_InventoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn minIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mineralnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recommendedditributionrateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}