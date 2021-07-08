namespace Bulb_Tea_System
{
    partial class Stock_Management
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
            this.txtProdID = new System.Windows.Forms.TextBox();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.txtProdQuantity = new System.Windows.Forms.TextBox();
            this.txtRestock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MtxtDate = new System.Windows.Forms.MaskedTextBox();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProdPrice = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnCheckStock = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.toolTipCheckStock = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDetailedView = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipFirstRecord = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPreviousRecord = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipNextRecord = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipLastRecord = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtProdID
            // 
            this.txtProdID.Location = new System.Drawing.Point(158, 24);
            this.txtProdID.Name = "txtProdID";
            this.txtProdID.ReadOnly = true;
            this.txtProdID.Size = new System.Drawing.Size(132, 20);
            this.txtProdID.TabIndex = 7;
            this.txtProdID.TabStop = false;
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(158, 53);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.ReadOnly = true;
            this.txtProdName.Size = new System.Drawing.Size(132, 20);
            this.txtProdName.TabIndex = 8;
            this.txtProdName.TabStop = false;
            // 
            // txtProdQuantity
            // 
            this.txtProdQuantity.Location = new System.Drawing.Point(158, 111);
            this.txtProdQuantity.Name = "txtProdQuantity";
            this.txtProdQuantity.ReadOnly = true;
            this.txtProdQuantity.Size = new System.Drawing.Size(132, 20);
            this.txtProdQuantity.TabIndex = 10;
            this.txtProdQuantity.TabStop = false;
            // 
            // txtRestock
            // 
            this.txtRestock.Location = new System.Drawing.Point(158, 140);
            this.txtRestock.Name = "txtRestock";
            this.txtRestock.ReadOnly = true;
            this.txtRestock.Size = new System.Drawing.Size(132, 20);
            this.txtRestock.TabIndex = 11;
            this.txtRestock.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "ProductID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Product Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Product Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Has to restock?:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Date:";
            // 
            // MtxtDate
            // 
            this.MtxtDate.Location = new System.Drawing.Point(158, 169);
            this.MtxtDate.Mask = "00/00/0000";
            this.MtxtDate.Name = "MtxtDate";
            this.MtxtDate.ReadOnly = true;
            this.MtxtDate.Size = new System.Drawing.Size(132, 20);
            this.MtxtDate.TabIndex = 12;
            this.MtxtDate.TabStop = false;
            this.MtxtDate.ValidatingType = typeof(System.DateTime);
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(284, 226);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(110, 23);
            this.btnDetail.TabIndex = 6;
            this.btnDetail.Text = "Detailed View";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(166, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Product Price:";
            // 
            // txtProdPrice
            // 
            this.txtProdPrice.Location = new System.Drawing.Point(158, 82);
            this.txtProdPrice.Name = "txtProdPrice";
            this.txtProdPrice.ReadOnly = true;
            this.txtProdPrice.Size = new System.Drawing.Size(132, 20);
            this.txtProdPrice.TabIndex = 9;
            this.txtProdPrice.TabStop = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(136, 197);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(82, 23);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(224, 197);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(82, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnCheckStock
            // 
            this.btnCheckStock.Location = new System.Drawing.Point(48, 226);
            this.btnCheckStock.Name = "btnCheckStock";
            this.btnCheckStock.Size = new System.Drawing.Size(110, 23);
            this.btnCheckStock.TabIndex = 4;
            this.btnCheckStock.Text = "Check Stock Level";
            this.btnCheckStock.UseVisualStyleBackColor = true;
            this.btnCheckStock.Click += new System.EventHandler(this.btnCheckStock_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(312, 197);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(82, 23);
            this.btnLast.TabIndex = 3;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(48, 197);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(82, 23);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // toolTipCheckStock
            // 
            this.toolTipCheckStock.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipCheckStock.ToolTipTitle = "Info:";
            // 
            // toolTipDetailedView
            // 
            this.toolTipDetailedView.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipDetailedView.ToolTipTitle = "Info:";
            // 
            // Stock_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 272);
            this.ControlBox = false;
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnCheckStock);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtProdPrice);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.MtxtDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRestock);
            this.Controls.Add(this.txtProdQuantity);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.txtProdID);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(459, 311);
            this.MinimumSize = new System.Drawing.Size(459, 311);
            this.Name = "Stock_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Management";
            this.Load += new System.EventHandler(this.frmStockManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProdID;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.TextBox txtProdQuantity;
        private System.Windows.Forms.TextBox txtRestock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox MtxtDate;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProdPrice;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCheckStock;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.ToolTip toolTipCheckStock;
        private System.Windows.Forms.ToolTip toolTipDetailedView;
        private System.Windows.Forms.ToolTip toolTipFirstRecord;
        private System.Windows.Forms.ToolTip toolTipPreviousRecord;
        private System.Windows.Forms.ToolTip toolTipNextRecord;
        private System.Windows.Forms.ToolTip toolTipLastRecord;
    }
}