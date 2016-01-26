namespace Expense_Summary_App
{
    partial class frmAddItem
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
            this.lblReceiptDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalMiles = new System.Windows.Forms.Label();
            this.dtpReceiptDate = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtTotalMiles = new System.Windows.Forms.TextBox();
            this.btnAttachReceipt = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExpenseCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtTotalExpense = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMileageTotal = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSection = new System.Windows.Forms.Label();
            this.lblReceiptFile = new System.Windows.Forms.Label();
            this.txtReceiptFile = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtWriteInTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReceiptDate
            // 
            this.lblReceiptDate.AutoSize = true;
            this.lblReceiptDate.Location = new System.Drawing.Point(6, 47);
            this.lblReceiptDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReceiptDate.Name = "lblReceiptDate";
            this.lblReceiptDate.Size = new System.Drawing.Size(76, 13);
            this.lblReceiptDate.TabIndex = 0;
            this.lblReceiptDate.Text = "Receipt Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description :";
            // 
            // lblTotalMiles
            // 
            this.lblTotalMiles.AutoSize = true;
            this.lblTotalMiles.Location = new System.Drawing.Point(7, 14);
            this.lblTotalMiles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalMiles.Name = "lblTotalMiles";
            this.lblTotalMiles.Size = new System.Drawing.Size(64, 13);
            this.lblTotalMiles.TabIndex = 2;
            this.lblTotalMiles.Text = "Total Miles :";
            // 
            // dtpReceiptDate
            // 
            this.dtpReceiptDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReceiptDate.Location = new System.Drawing.Point(92, 43);
            this.dtpReceiptDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpReceiptDate.Name = "dtpReceiptDate";
            this.dtpReceiptDate.Size = new System.Drawing.Size(105, 20);
            this.dtpReceiptDate.TabIndex = 5;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(8, 129);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(303, 76);
            this.txtDescription.TabIndex = 6;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(8, 9);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Mileage?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtTotalMiles
            // 
            this.txtTotalMiles.Location = new System.Drawing.Point(76, 14);
            this.txtTotalMiles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotalMiles.Name = "txtTotalMiles";
            this.txtTotalMiles.Size = new System.Drawing.Size(55, 20);
            this.txtTotalMiles.TabIndex = 8;
            // 
            // btnAttachReceipt
            // 
            this.btnAttachReceipt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAttachReceipt.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAttachReceipt.Location = new System.Drawing.Point(213, 39);
            this.btnAttachReceipt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAttachReceipt.Name = "btnAttachReceipt";
            this.btnAttachReceipt.Size = new System.Drawing.Size(99, 29);
            this.btnAttachReceipt.TabIndex = 9;
            this.btnAttachReceipt.Text = "&Attach Receipt";
            this.btnAttachReceipt.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSubmit.Location = new System.Drawing.Point(60, 425);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(99, 44);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Expense Type :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "meals & entertainment",
            "employee vehicle auto reimbursment",
            "company vehicle fuel",
            "company vehicle repairs & maintance",
            "employee relations",
            "travel, cab fare, car rental, etc.",
            "Selling Telecommunicatons",
            "1 - other expenses to be itemized",
            "2 - other expenses to be itemized",
            "3 - other expenses to be itemized",
            "4 - other expenses to be itemized"});
            this.comboBox1.Location = new System.Drawing.Point(93, 11);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(175, 425);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 44);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Expense Code :";
            // 
            // txtExpenseCode
            // 
            this.txtExpenseCode.Location = new System.Drawing.Point(93, 37);
            this.txtExpenseCode.Name = "txtExpenseCode";
            this.txtExpenseCode.ReadOnly = true;
            this.txtExpenseCode.Size = new System.Drawing.Size(76, 20);
            this.txtExpenseCode.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Rate :";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(76, 46);
            this.txtRate.Name = "txtRate";
            this.txtRate.ReadOnly = true;
            this.txtRate.Size = new System.Drawing.Size(46, 20);
            this.txtRate.TabIndex = 17;
            // 
            // txtTotalExpense
            // 
            this.txtTotalExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalExpense.Location = new System.Drawing.Point(109, 379);
            this.txtTotalExpense.Name = "txtTotalExpense";
            this.txtTotalExpense.ReadOnly = true;
            this.txtTotalExpense.Size = new System.Drawing.Size(100, 19);
            this.txtTotalExpense.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Total Expense :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(158, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Mileage $ Total :";
            // 
            // txtMileageTotal
            // 
            this.txtMileageTotal.Location = new System.Drawing.Point(243, 46);
            this.txtMileageTotal.Name = "txtMileageTotal";
            this.txtMileageTotal.ReadOnly = true;
            this.txtMileageTotal.Size = new System.Drawing.Size(62, 20);
            this.txtMileageTotal.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMileageTotal);
            this.panel1.Controls.Add(this.lblTotalMiles);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtTotalMiles);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtRate);
            this.panel1.Location = new System.Drawing.Point(-1, 264);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 81);
            this.panel1.TabIndex = 22;
            this.panel1.Visible = false;
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSection.Location = new System.Drawing.Point(4, 238);
            this.lblSection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(165, 23);
            this.lblSection.TabIndex = 23;
            this.lblSection.Text = "Non-Mileage Expense";
            // 
            // lblReceiptFile
            // 
            this.lblReceiptFile.AutoSize = true;
            this.lblReceiptFile.Location = new System.Drawing.Point(5, 84);
            this.lblReceiptFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReceiptFile.Name = "lblReceiptFile";
            this.lblReceiptFile.Size = new System.Drawing.Size(69, 13);
            this.lblReceiptFile.TabIndex = 24;
            this.lblReceiptFile.Text = "Receipt File :";
            // 
            // txtReceiptFile
            // 
            this.txtReceiptFile.Location = new System.Drawing.Point(92, 84);
            this.txtReceiptFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtReceiptFile.Name = "txtReceiptFile";
            this.txtReceiptFile.ReadOnly = true;
            this.txtReceiptFile.Size = new System.Drawing.Size(222, 20);
            this.txtReceiptFile.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtWriteInTotal);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtExpenseCode);
            this.panel2.Location = new System.Drawing.Point(-1, 264);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 81);
            this.panel2.TabIndex = 26;
            // 
            // txtWriteInTotal
            // 
            this.txtWriteInTotal.Location = new System.Drawing.Point(93, 59);
            this.txtWriteInTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtWriteInTotal.Name = "txtWriteInTotal";
            this.txtWriteInTotal.Size = new System.Drawing.Size(76, 20);
            this.txtWriteInTotal.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 59);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Write-In Total :";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(185, 240);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(73, 19);
            this.btnCalculate.TabIndex = 27;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Visible = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(262, 240);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(56, 19);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 483);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtReceiptFile);
            this.Controls.Add(this.lblReceiptFile);
            this.Controls.Add(this.lblSection);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotalExpense);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnAttachReceipt);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.dtpReceiptDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblReceiptDate);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAddItem";
            this.Text = "Add Expense Item";
            this.Load += new System.EventHandler(this.frmAddItem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReceiptDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalMiles;
        private System.Windows.Forms.DateTimePicker dtpReceiptDate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtTotalMiles;
        private System.Windows.Forms.Button btnAttachReceipt;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExpenseCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtTotalExpense;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMileageTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Label lblReceiptFile;
        private System.Windows.Forms.TextBox txtReceiptFile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtWriteInTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
    }
}