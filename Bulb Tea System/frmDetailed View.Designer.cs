namespace Bulb_Tea_System
{
    partial class frmDetailed_View
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
            this.DetailedDataGridView = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DetailedDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DetailedDataGridView
            // 
            this.DetailedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetailedDataGridView.Location = new System.Drawing.Point(8, 45);
            this.DetailedDataGridView.Name = "DetailedDataGridView";
            this.DetailedDataGridView.ReadOnly = true;
            this.DetailedDataGridView.Size = new System.Drawing.Size(642, 216);
            this.DetailedDataGridView.TabIndex = 1;
            this.DetailedDataGridView.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(290, 284);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Detailed view on all Products:";
            // 
            // Detailed_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 325);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.DetailedDataGridView);
            this.MaximumSize = new System.Drawing.Size(670, 364);
            this.MinimumSize = new System.Drawing.Size(670, 364);
            this.Name = "Detailed_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detailed View";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Detailed_View_FormClosed);
            this.Load += new System.EventHandler(this.Detailed_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DetailedDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DetailedDataGridView;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;

    }
}