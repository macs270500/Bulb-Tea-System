namespace Bulb_Tea_System
{
    partial class frmRestock
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
            this.RestockDataGridView = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RestockDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RestockDataGridView
            // 
            this.RestockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RestockDataGridView.Location = new System.Drawing.Point(21, 42);
            this.RestockDataGridView.Name = "RestockDataGridView";
            this.RestockDataGridView.ReadOnly = true;
            this.RestockDataGridView.Size = new System.Drawing.Size(442, 175);
            this.RestockDataGridView.TabIndex = 1;
            this.RestockDataGridView.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(203, 229);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "List of Items that need to be restocked:";
            // 
            // frmRestock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 263);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.RestockDataGridView);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(496, 302);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(496, 302);
            this.Name = "frmRestock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restock";
            this.Load += new System.EventHandler(this.frmRestock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RestockDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }        
    
    #endregion

    private System.Windows.Forms.DataGridView RestockDataGridView;
    private System.Windows.Forms.Button btnBack;
    private System.Windows.Forms.Label label1;
    }
}
