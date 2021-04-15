namespace WindowsFormsApp1
{
    partial class lowInventory
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
            this.dgvWWA = new System.Windows.Forms.DataGridView();
            this.BacktoMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWWA)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWWA
            // 
            this.dgvWWA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWWA.Location = new System.Drawing.Point(21, 24);
            this.dgvWWA.Name = "dgvWWA";
            this.dgvWWA.Size = new System.Drawing.Size(657, 403);
            this.dgvWWA.TabIndex = 40;
            // 
            // BacktoMain
            // 
            this.BacktoMain.Location = new System.Drawing.Point(703, 394);
            this.BacktoMain.Name = "BacktoMain";
            this.BacktoMain.Size = new System.Drawing.Size(75, 23);
            this.BacktoMain.TabIndex = 41;
            this.BacktoMain.Text = "Back";
            this.BacktoMain.UseVisualStyleBackColor = true;
            // 
            // lowInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BacktoMain);
            this.Controls.Add(this.dgvWWA);
            this.Name = "lowInventory";
            this.Text = "lowInventory";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWWA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWWA;
        private System.Windows.Forms.Button BacktoMain;
    }
}