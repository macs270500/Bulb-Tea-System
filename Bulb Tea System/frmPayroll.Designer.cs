namespace Bulb_Tea_System
{
    partial class frmPayroll
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
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cBempID = new System.Windows.Forms.ComboBox();
            this.txtIN = new System.Windows.Forms.TextBox();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.txttotalsal = new System.Windows.Forms.TextBox();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.txthours = new System.Windows.Forms.TextBox();
            this.txtovertime = new System.Windows.Forms.TextBox();
            this.txtprevsal = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Employee ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 408);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Total Salary: Rs";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Salary: Rs";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Hours Work:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Overtime: Rs";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 256);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Previous Total: Rs";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 172);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Time OUT:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 124);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Time IN:";
            // 
            // cBempID
            // 
            this.cBempID.FormattingEnabled = true;
            this.cBempID.Location = new System.Drawing.Point(131, 81);
            this.cBempID.Name = "cBempID";
            this.cBempID.Size = new System.Drawing.Size(121, 21);
            this.cBempID.TabIndex = 0;
            this.cBempID.SelectedIndexChanged += new System.EventHandler(this.cBempID_SelectedIndexChanged);
            // 
            // txtIN
            // 
            this.txtIN.Location = new System.Drawing.Point(131, 121);
            this.txtIN.Name = "txtIN";
            this.txtIN.Size = new System.Drawing.Size(121, 20);
            this.txtIN.TabIndex = 1;
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(131, 169);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(121, 20);
            this.txtOut.TabIndex = 2;
            // 
            // txttotalsal
            // 
            this.txttotalsal.Location = new System.Drawing.Point(131, 405);
            this.txttotalsal.Name = "txttotalsal";
            this.txttotalsal.ReadOnly = true;
            this.txttotalsal.Size = new System.Drawing.Size(121, 20);
            this.txttotalsal.TabIndex = 11;
            this.txttotalsal.TabStop = false;
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(131, 362);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.ReadOnly = true;
            this.txtsalary.Size = new System.Drawing.Size(121, 20);
            this.txtsalary.TabIndex = 10;
            this.txtsalary.TabStop = false;
            // 
            // txthours
            // 
            this.txthours.Location = new System.Drawing.Point(131, 328);
            this.txthours.Name = "txthours";
            this.txthours.ReadOnly = true;
            this.txthours.Size = new System.Drawing.Size(121, 20);
            this.txthours.TabIndex = 9;
            this.txthours.TabStop = false;
            // 
            // txtovertime
            // 
            this.txtovertime.Location = new System.Drawing.Point(131, 293);
            this.txtovertime.Name = "txtovertime";
            this.txtovertime.ReadOnly = true;
            this.txtovertime.Size = new System.Drawing.Size(121, 20);
            this.txtovertime.TabIndex = 8;
            this.txtovertime.TabStop = false;
            // 
            // txtprevsal
            // 
            this.txtprevsal.Location = new System.Drawing.Point(131, 253);
            this.txtprevsal.Name = "txtprevsal";
            this.txtprevsal.ReadOnly = true;
            this.txtprevsal.Size = new System.Drawing.Size(121, 20);
            this.txtprevsal.TabIndex = 7;
            this.txtprevsal.TabStop = false;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(332, 81);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(107, 34);
            this.btnProcess.TabIndex = 3;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(332, 193);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(107, 34);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(332, 253);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 34);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(332, 135);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(107, 34);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // frmPayroll
            // 
            this.ClientSize = new System.Drawing.Size(481, 481);
            this.ControlBox = false;
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.txtprevsal);
            this.Controls.Add(this.txtovertime);
            this.Controls.Add(this.txthours);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.txttotalsal);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.txtIN);
            this.Controls.Add(this.cBempID);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Name = "frmPayroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll";
            this.Load += new System.EventHandler(this.frmPayroll_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cBempID;
        private System.Windows.Forms.TextBox txtIN;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.TextBox txttotalsal;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.TextBox txthours;
        private System.Windows.Forms.TextBox txtovertime;
        private System.Windows.Forms.TextBox txtprevsal;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnView;

    }
}