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
            this.label10 = new System.Windows.Forms.Label();
            this.txtWriteInTotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReceiptDate
            // 
            this.lblReceiptDate.AutoSize = true;
            this.lblReceiptDate.Location = new System.Drawing.Point(8, 58);
            this.lblReceiptDate.Name = "lblReceiptDate";
            this.lblReceiptDate.Size = new System.Drawing.Size(98, 17);
            this.lblReceiptDate.TabIndex = 0;
            this.lblReceiptDate.Text = "Receipt Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description :";
            // 
            // lblTotalMiles
            // 
            this.lblTotalMiles.AutoSize = true;
            this.lblTotalMiles.Location = new System.Drawing.Point(9, 17);
            this.lblTotalMiles.Name = "lblTotalMiles";
            this.lblTotalMiles.Size = new System.Drawing.Size(84, 17);
            this.lblTotalMiles.TabIndex = 2;
            this.lblTotalMiles.Text = "Total Miles :";
            // 
            // dtpReceiptDate
            // 
            this.dtpReceiptDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReceiptDate.Location = new System.Drawing.Point(122, 53);
            this.dtpReceiptDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpReceiptDate.Name = "dtpReceiptDate";
            this.dtpReceiptDate.Size = new System.Drawing.Size(139, 22);
            this.dtpReceiptDate.TabIndex = 5;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(11, 159);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(403, 93);
            this.txtDescription.TabIndex = 6;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(11, 11);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(87, 21);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Mileage?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtTotalMiles
            // 
            this.txtTotalMiles.Location = new System.Drawing.Point(101, 17);
            this.txtTotalMiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalMiles.Name = "txtTotalMiles";
            this.txtTotalMiles.Size = new System.Drawing.Size(72, 22);
            this.txtTotalMiles.TabIndex = 8;
            // 
            // btnAttachReceipt
            // 
            this.btnAttachReceipt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAttachReceipt.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAttachReceipt.Location = new System.Drawing.Point(284, 48);
            this.btnAttachReceipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAttachReceipt.Name = "btnAttachReceipt";
            this.btnAttachReceipt.Size = new System.Drawing.Size(132, 36);
            this.btnAttachReceipt.TabIndex = 9;
            this.btnAttachReceipt.Text = "&Attach Receipt";
            this.btnAttachReceipt.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(80, 523);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(132, 54);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
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
            this.comboBox1.Location = new System.Drawing.Point(124, 14);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(268, 24);
            this.comboBox1.TabIndex = 12;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(233, 523);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 54);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Expense Code :";
            // 
            // txtExpenseCode
            // 
            this.txtExpenseCode.Location = new System.Drawing.Point(124, 43);
            this.txtExpenseCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtExpenseCode.Name = "txtExpenseCode";
            this.txtExpenseCode.ReadOnly = true;
            this.txtExpenseCode.Size = new System.Drawing.Size(100, 22);
            this.txtExpenseCode.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Rate :";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(101, 57);
            this.txtRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtRate.Name = "txtRate";
            this.txtRate.ReadOnly = true;
            this.txtRate.Size = new System.Drawing.Size(60, 22);
            this.txtRate.TabIndex = 17;
            // 
            // txtTotalExpense
            // 
            this.txtTotalExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalExpense.Location = new System.Drawing.Point(145, 466);
            this.txtTotalExpense.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalExpense.Name = "txtTotalExpense";
            this.txtTotalExpense.ReadOnly = true;
            this.txtTotalExpense.Size = new System.Drawing.Size(132, 22);
            this.txtTotalExpense.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 463);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "Total Expense :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 60);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Mileage $ Total :";
            // 
            // txtMileageTotal
            // 
            this.txtMileageTotal.Location = new System.Drawing.Point(324, 56);
            this.txtMileageTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtMileageTotal.Name = "txtMileageTotal";
            this.txtMileageTotal.ReadOnly = true;
            this.txtMileageTotal.Size = new System.Drawing.Size(81, 22);
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
            this.panel1.Location = new System.Drawing.Point(-1, 325);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 100);
            this.panel1.TabIndex = 22;
            this.panel1.Visible = false;
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSection.Location = new System.Drawing.Point(6, 293);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(207, 29);
            this.lblSection.TabIndex = 23;
            this.lblSection.Text = "Non-Mileage Expense";
            // 
            // lblReceiptFile
            // 
            this.lblReceiptFile.AutoSize = true;
            this.lblReceiptFile.Location = new System.Drawing.Point(7, 104);
            this.lblReceiptFile.Name = "lblReceiptFile";
            this.lblReceiptFile.Size = new System.Drawing.Size(90, 17);
            this.lblReceiptFile.TabIndex = 24;
            this.lblReceiptFile.Text = "Receipt File :";
            // 
            // txtReceiptFile
            // 
            this.txtReceiptFile.Location = new System.Drawing.Point(122, 104);
            this.txtReceiptFile.Name = "txtReceiptFile";
            this.txtReceiptFile.ReadOnly = true;
            this.txtReceiptFile.Size = new System.Drawing.Size(294, 22);
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
            this.panel2.Location = new System.Drawing.Point(-1, 325);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(426, 100);
            this.panel2.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Write-In Total :";
            // 
            // txtWriteInTotal
            // 
            this.txtWriteInTotal.Location = new System.Drawing.Point(124, 73);
            this.txtWriteInTotal.Name = "txtWriteInTotal";
            this.txtWriteInTotal.Size = new System.Drawing.Size(100, 22);
            this.txtWriteInTotal.TabIndex = 17;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(247, 296);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 27;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Visible = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(350, 296);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 595);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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