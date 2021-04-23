namespace WindowsFormsApp1
{
    partial class Who_Has_Been_Fed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Who_Has_Been_Fed));
            this.lbBed = new System.Windows.Forms.Label();
            this.BacktoMain = new System.Windows.Forms.Button();
            this.dgvWWA = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.who_has_Been_FedRanchDataSet = new WindowsFormsApp1.Who_has_Been_FedRanchDataSet();
            this.whohasBeenFedViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.who_has_Been_Fed_ViewTableAdapter = new WindowsFormsApp1.Who_has_Been_FedRanchDataSetTableAdapters.Who_has_Been_Fed_ViewTableAdapter();
            this.speciesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWWA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.who_has_Been_FedRanchDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whohasBeenFedViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbBed
            // 
            this.lbBed.AutoSize = true;
            this.lbBed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBed.Location = new System.Drawing.Point(26, 18);
            this.lbBed.Name = "lbBed";
            this.lbBed.Size = new System.Drawing.Size(199, 25);
            this.lbBed.TabIndex = 47;
            this.lbBed.Text = "Who Has Been Fed";
            // 
            // BacktoMain
            // 
            this.BacktoMain.Location = new System.Drawing.Point(689, 399);
            this.BacktoMain.Name = "BacktoMain";
            this.BacktoMain.Size = new System.Drawing.Size(75, 23);
            this.BacktoMain.TabIndex = 46;
            this.BacktoMain.Text = "Back";
            this.BacktoMain.UseVisualStyleBackColor = true;
            this.BacktoMain.Click += new System.EventHandler(this.BacktoMain_Click);
            // 
            // dgvWWA
            // 
            this.dgvWWA.AutoGenerateColumns = false;
            this.dgvWWA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWWA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.speciesDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn});
            this.dgvWWA.DataSource = this.whohasBeenFedViewBindingSource;
            this.dgvWWA.Location = new System.Drawing.Point(31, 61);
            this.dgvWWA.Name = "dgvWWA";
            this.dgvWWA.Size = new System.Drawing.Size(444, 478);
            this.dgvWWA.TabIndex = 45;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(608, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 316);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // who_has_Been_FedRanchDataSet
            // 
            this.who_has_Been_FedRanchDataSet.DataSetName = "Who_has_Been_FedRanchDataSet";
            this.who_has_Been_FedRanchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // whohasBeenFedViewBindingSource
            // 
            this.whohasBeenFedViewBindingSource.DataMember = "Who_has_Been_Fed_View";
            this.whohasBeenFedViewBindingSource.DataSource = this.who_has_Been_FedRanchDataSet;
            // 
            // who_has_Been_Fed_ViewTableAdapter
            // 
            this.who_has_Been_Fed_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // speciesDataGridViewTextBoxColumn
            // 
            this.speciesDataGridViewTextBoxColumn.DataPropertyName = "species";
            this.speciesDataGridViewTextBoxColumn.HeaderText = "species";
            this.speciesDataGridViewTextBoxColumn.Name = "speciesDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "unit";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            // 
            // Who_Has_Been_Fed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 572);
            this.Controls.Add(this.lbBed);
            this.Controls.Add(this.BacktoMain);
            this.Controls.Add(this.dgvWWA);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Who_Has_Been_Fed";
            this.Text = "Who Has Been Fed";
            this.Load += new System.EventHandler(this.Who_Has_Been_Fed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWWA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.who_has_Been_FedRanchDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whohasBeenFedViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbBed;
        private System.Windows.Forms.Button BacktoMain;
        private System.Windows.Forms.DataGridView dgvWWA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Who_has_Been_FedRanchDataSet who_has_Been_FedRanchDataSet;
        private System.Windows.Forms.BindingSource whohasBeenFedViewBindingSource;
        private Who_has_Been_FedRanchDataSetTableAdapters.Who_has_Been_Fed_ViewTableAdapter who_has_Been_Fed_ViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
    }
}