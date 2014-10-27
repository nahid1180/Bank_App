namespace BankApp
{
    partial class BankUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openingEntryTextBox = new System.Windows.Forms.TextBox();
            this.accountNumberEntryTextBox = new System.Windows.Forms.TextBox();
            this.emailEntryTextBox = new System.Windows.Forms.TextBox();
            this.customerNameEntryTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.depositButton = new System.Windows.Forms.Button();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.showInfoButton = new System.Windows.Forms.Button();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.openingDateDisplayTextBox = new System.Windows.Forms.TextBox();
            this.accountNumberDisplayTextBox = new System.Windows.Forms.TextBox();
            this.emailDisplayTextBox = new System.Windows.Forms.TextBox();
            this.customerNameDisplayTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.openingEntryTextBox);
            this.groupBox1.Controls.Add(this.accountNumberEntryTextBox);
            this.groupBox1.Controls.Add(this.emailEntryTextBox);
            this.groupBox1.Controls.Add(this.customerNameEntryTextBox);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer & Account info entry";
            // 
            // openingEntryTextBox
            // 
            this.openingEntryTextBox.Location = new System.Drawing.Point(130, 120);
            this.openingEntryTextBox.Name = "openingEntryTextBox";
            this.openingEntryTextBox.Size = new System.Drawing.Size(159, 20);
            this.openingEntryTextBox.TabIndex = 8;
            // 
            // accountNumberEntryTextBox
            // 
            this.accountNumberEntryTextBox.Location = new System.Drawing.Point(130, 83);
            this.accountNumberEntryTextBox.Name = "accountNumberEntryTextBox";
            this.accountNumberEntryTextBox.Size = new System.Drawing.Size(159, 20);
            this.accountNumberEntryTextBox.TabIndex = 7;
            // 
            // emailEntryTextBox
            // 
            this.emailEntryTextBox.Location = new System.Drawing.Point(130, 51);
            this.emailEntryTextBox.Name = "emailEntryTextBox";
            this.emailEntryTextBox.Size = new System.Drawing.Size(159, 20);
            this.emailEntryTextBox.TabIndex = 6;
            // 
            // customerNameEntryTextBox
            // 
            this.customerNameEntryTextBox.Location = new System.Drawing.Point(130, 19);
            this.customerNameEntryTextBox.Name = "customerNameEntryTextBox";
            this.customerNameEntryTextBox.Size = new System.Drawing.Size(159, 20);
            this.customerNameEntryTextBox.TabIndex = 5;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(244, 179);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Opening Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Account Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.withdrawButton);
            this.groupBox2.Controls.Add(this.depositButton);
            this.groupBox2.Controls.Add(this.amountTextBox);
            this.groupBox2.Location = new System.Drawing.Point(25, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 112);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Amount";
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(244, 59);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(75, 23);
            this.withdrawButton.TabIndex = 2;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(244, 16);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(75, 23);
            this.depositButton.TabIndex = 1;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(81, 20);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(131, 20);
            this.amountTextBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.showInfoButton);
            this.groupBox3.Controls.Add(this.balanceTextBox);
            this.groupBox3.Controls.Add(this.openingDateDisplayTextBox);
            this.groupBox3.Controls.Add(this.accountNumberDisplayTextBox);
            this.groupBox3.Controls.Add(this.emailDisplayTextBox);
            this.groupBox3.Controls.Add(this.customerNameDisplayTextBox);
            this.groupBox3.Location = new System.Drawing.Point(398, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(394, 208);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customer & Account Info";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(101, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(101, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Account Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(101, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Opening Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Balance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Customer Name";
            // 
            // showInfoButton
            // 
            this.showInfoButton.Location = new System.Drawing.Point(214, 20);
            this.showInfoButton.Name = "showInfoButton";
            this.showInfoButton.Size = new System.Drawing.Size(147, 23);
            this.showInfoButton.TabIndex = 5;
            this.showInfoButton.Text = "Show All Information";
            this.showInfoButton.UseVisualStyleBackColor = true;
            this.showInfoButton.Click += new System.EventHandler(this.showInfoButton_Click);
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(214, 165);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(147, 20);
            this.balanceTextBox.TabIndex = 4;
            // 
            // openingDateDisplayTextBox
            // 
            this.openingDateDisplayTextBox.Location = new System.Drawing.Point(214, 139);
            this.openingDateDisplayTextBox.Name = "openingDateDisplayTextBox";
            this.openingDateDisplayTextBox.Size = new System.Drawing.Size(147, 20);
            this.openingDateDisplayTextBox.TabIndex = 3;
            // 
            // accountNumberDisplayTextBox
            // 
            this.accountNumberDisplayTextBox.Location = new System.Drawing.Point(214, 113);
            this.accountNumberDisplayTextBox.Name = "accountNumberDisplayTextBox";
            this.accountNumberDisplayTextBox.Size = new System.Drawing.Size(147, 20);
            this.accountNumberDisplayTextBox.TabIndex = 2;
            // 
            // emailDisplayTextBox
            // 
            this.emailDisplayTextBox.Location = new System.Drawing.Point(214, 80);
            this.emailDisplayTextBox.Name = "emailDisplayTextBox";
            this.emailDisplayTextBox.Size = new System.Drawing.Size(147, 20);
            this.emailDisplayTextBox.TabIndex = 1;
            // 
            // customerNameDisplayTextBox
            // 
            this.customerNameDisplayTextBox.Location = new System.Drawing.Point(214, 51);
            this.customerNameDisplayTextBox.Name = "customerNameDisplayTextBox";
            this.customerNameDisplayTextBox.Size = new System.Drawing.Size(147, 20);
            this.customerNameDisplayTextBox.TabIndex = 0;
            // 
            // BankUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 359);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "BankUI";
            this.Text = "First Bank UI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox openingEntryTextBox;
        private System.Windows.Forms.TextBox accountNumberEntryTextBox;
        private System.Windows.Forms.TextBox emailEntryTextBox;
        private System.Windows.Forms.TextBox customerNameEntryTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button showInfoButton;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.TextBox openingDateDisplayTextBox;
        private System.Windows.Forms.TextBox accountNumberDisplayTextBox;
        private System.Windows.Forms.TextBox emailDisplayTextBox;
        private System.Windows.Forms.TextBox customerNameDisplayTextBox;
    }
}

