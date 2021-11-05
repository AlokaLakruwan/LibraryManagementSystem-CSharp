namespace LibHelper
{
    partial class borrowBooks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBB_MId = new System.Windows.Forms.TextBox();
            this.borrowerDetails = new System.Windows.Forms.GroupBox();
            this.btnBBSearchX = new System.Windows.Forms.Button();
            this.txtBB_Nic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBBSearchY = new System.Windows.Forms.Button();
            this.txtBB_BTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBB_Bid = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerBB_Frd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBB_BDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBBClear = new System.Windows.Forms.Button();
            this.btnBBBorrow = new System.Windows.Forms.Button();
            this.borrowerDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBB_MId
            // 
            this.txtBB_MId.Location = new System.Drawing.Point(23, 64);
            this.txtBB_MId.MaxLength = 50;
            this.txtBB_MId.Name = "txtBB_MId";
            this.txtBB_MId.Size = new System.Drawing.Size(253, 25);
            this.txtBB_MId.TabIndex = 0;
            // 
            // borrowerDetails
            // 
            this.borrowerDetails.Controls.Add(this.btnBBSearchX);
            this.borrowerDetails.Controls.Add(this.txtBB_Nic);
            this.borrowerDetails.Controls.Add(this.label2);
            this.borrowerDetails.Controls.Add(this.label1);
            this.borrowerDetails.Controls.Add(this.txtBB_MId);
            this.borrowerDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowerDetails.Location = new System.Drawing.Point(21, 11);
            this.borrowerDetails.Name = "borrowerDetails";
            this.borrowerDetails.Size = new System.Drawing.Size(596, 100);
            this.borrowerDetails.TabIndex = 1;
            this.borrowerDetails.TabStop = false;
            this.borrowerDetails.Text = "Borrower Details";
            // 
            // btnBBSearchX
            // 
            this.btnBBSearchX.FlatAppearance.BorderSize = 0;
            this.btnBBSearchX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBBSearchX.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBBSearchX.Image = global::LibHelper.Properties.Resources.icons8_Search_25px;
            this.btnBBSearchX.Location = new System.Drawing.Point(242, 32);
            this.btnBBSearchX.Name = "btnBBSearchX";
            this.btnBBSearchX.Size = new System.Drawing.Size(34, 32);
            this.btnBBSearchX.TabIndex = 22;
            this.btnBBSearchX.UseVisualStyleBackColor = true;
            this.btnBBSearchX.Click += new System.EventHandler(this.btnBBSearchX_Click);
            // 
            // txtBB_Nic
            // 
            this.txtBB_Nic.Location = new System.Drawing.Point(316, 64);
            this.txtBB_Nic.MaxLength = 20;
            this.txtBB_Nic.Name = "txtBB_Nic";
            this.txtBB_Nic.ReadOnly = true;
            this.txtBB_Nic.Size = new System.Drawing.Size(250, 25);
            this.txtBB_Nic.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "NIC No / Postal ID / Passport ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Member ID*";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBBSearchY);
            this.groupBox1.Controls.Add(this.txtBB_BTitle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBB_Bid);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Details";
            // 
            // btnBBSearchY
            // 
            this.btnBBSearchY.FlatAppearance.BorderSize = 0;
            this.btnBBSearchY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBBSearchY.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBBSearchY.Image = global::LibHelper.Properties.Resources.icons8_Search_25px;
            this.btnBBSearchY.Location = new System.Drawing.Point(242, 32);
            this.btnBBSearchY.Name = "btnBBSearchY";
            this.btnBBSearchY.Size = new System.Drawing.Size(34, 32);
            this.btnBBSearchY.TabIndex = 23;
            this.btnBBSearchY.UseVisualStyleBackColor = true;
            this.btnBBSearchY.Click += new System.EventHandler(this.btnBBSearchY_Click);
            // 
            // txtBB_BTitle
            // 
            this.txtBB_BTitle.Location = new System.Drawing.Point(315, 64);
            this.txtBB_BTitle.MaxLength = 100;
            this.txtBB_BTitle.Name = "txtBB_BTitle";
            this.txtBB_BTitle.ReadOnly = true;
            this.txtBB_BTitle.Size = new System.Drawing.Size(250, 25);
            this.txtBB_BTitle.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Book Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Book ID*";
            // 
            // txtBB_Bid
            // 
            this.txtBB_Bid.Location = new System.Drawing.Point(23, 64);
            this.txtBB_Bid.MaxLength = 20;
            this.txtBB_Bid.Name = "txtBB_Bid";
            this.txtBB_Bid.Size = new System.Drawing.Size(253, 25);
            this.txtBB_Bid.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePickerBB_Frd);
            this.groupBox2.Controls.Add(this.dateTimePickerBB_BDate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(596, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Borrow Details";
            // 
            // dateTimePickerBB_Frd
            // 
            this.dateTimePickerBB_Frd.Location = new System.Drawing.Point(315, 60);
            this.dateTimePickerBB_Frd.Name = "dateTimePickerBB_Frd";
            this.dateTimePickerBB_Frd.Size = new System.Drawing.Size(250, 25);
            this.dateTimePickerBB_Frd.TabIndex = 4;
            // 
            // dateTimePickerBB_BDate
            // 
            this.dateTimePickerBB_BDate.Location = new System.Drawing.Point(22, 60);
            this.dateTimePickerBB_BDate.Name = "dateTimePickerBB_BDate";
            this.dateTimePickerBB_BDate.Size = new System.Drawing.Size(254, 25);
            this.dateTimePickerBB_BDate.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Final Return Date*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Borrowing Date";
            // 
            // btnBBClear
            // 
            this.btnBBClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBBClear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBBClear.Location = new System.Drawing.Point(530, 358);
            this.btnBBClear.Name = "btnBBClear";
            this.btnBBClear.Size = new System.Drawing.Size(87, 32);
            this.btnBBClear.TabIndex = 20;
            this.btnBBClear.Text = "Clear";
            this.btnBBClear.UseVisualStyleBackColor = true;
            this.btnBBClear.Click += new System.EventHandler(this.btnBBClear_Click);
            // 
            // btnBBBorrow
            // 
            this.btnBBBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBBBorrow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBBBorrow.Location = new System.Drawing.Point(414, 358);
            this.btnBBBorrow.Name = "btnBBBorrow";
            this.btnBBBorrow.Size = new System.Drawing.Size(113, 32);
            this.btnBBBorrow.TabIndex = 17;
            this.btnBBBorrow.Text = "Borrow Book";
            this.btnBBBorrow.UseVisualStyleBackColor = true;
            this.btnBBBorrow.Click += new System.EventHandler(this.btnBBBorrow_Click);
            // 
            // borrowBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnBBClear);
            this.Controls.Add(this.btnBBBorrow);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.borrowerDetails);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "borrowBooks";
            this.Size = new System.Drawing.Size(635, 400);
            this.borrowerDetails.ResumeLayout(false);
            this.borrowerDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBB_MId;
        private System.Windows.Forms.GroupBox borrowerDetails;
        private System.Windows.Forms.TextBox txtBB_Nic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBB_BTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBB_Bid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePickerBB_Frd;
        private System.Windows.Forms.DateTimePicker dateTimePickerBB_BDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBBClear;
        private System.Windows.Forms.Button btnBBBorrow;
        private System.Windows.Forms.Button btnBBSearchX;
        private System.Windows.Forms.Button btnBBSearchY;
    }
}
