namespace LibHelper
{
    partial class returnBooks
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerRB_Frd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerRB_BDate = new System.Windows.Forms.DateTimePicker();
            this.txtRB_PPD = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRB_DueDays = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRB_Tot = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerRB_Rdate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRBSearchY = new System.Windows.Forms.Button();
            this.txtRB_BTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRB_Bid = new System.Windows.Forms.TextBox();
            this.borrowerDetails = new System.Windows.Forms.GroupBox();
            this.btnRBSearchX = new System.Windows.Forms.Button();
            this.txtRB_Nic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRB_Id = new System.Windows.Forms.TextBox();
            this.btnRBClear = new System.Windows.Forms.Button();
            this.btnRBUpdate = new System.Windows.Forms.Button();
            this.btnRBSave = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.borrowerDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePickerRB_Frd);
            this.groupBox2.Controls.Add(this.dateTimePickerRB_BDate);
            this.groupBox2.Controls.Add(this.txtRB_PPD);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtRB_DueDays);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtRB_Tot);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dateTimePickerRB_Rdate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(20, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(596, 150);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Return Details";
            // 
            // dateTimePickerRB_Frd
            // 
            this.dateTimePickerRB_Frd.Location = new System.Drawing.Point(315, 48);
            this.dateTimePickerRB_Frd.Name = "dateTimePickerRB_Frd";
            this.dateTimePickerRB_Frd.Size = new System.Drawing.Size(250, 25);
            this.dateTimePickerRB_Frd.TabIndex = 16;
            // 
            // dateTimePickerRB_BDate
            // 
            this.dateTimePickerRB_BDate.Location = new System.Drawing.Point(22, 48);
            this.dateTimePickerRB_BDate.Name = "dateTimePickerRB_BDate";
            this.dateTimePickerRB_BDate.Size = new System.Drawing.Size(254, 25);
            this.dateTimePickerRB_BDate.TabIndex = 15;
            // 
            // txtRB_PPD
            // 
            this.txtRB_PPD.Location = new System.Drawing.Point(351, 108);
            this.txtRB_PPD.Name = "txtRB_PPD";
            this.txtRB_PPD.Size = new System.Drawing.Size(138, 25);
            this.txtRB_PPD.TabIndex = 14;
            this.txtRB_PPD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRB_PPD_KeyPress);
            this.txtRB_PPD.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRB_PPD_KeyUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(352, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 19);
            this.label11.TabIndex = 13;
            this.label11.Text = "Panelty Per Day (Rs.)";
            // 
            // txtRB_DueDays
            // 
            this.txtRB_DueDays.Location = new System.Drawing.Point(266, 108);
            this.txtRB_DueDays.Name = "txtRB_DueDays";
            this.txtRB_DueDays.ReadOnly = true;
            this.txtRB_DueDays.Size = new System.Drawing.Size(79, 25);
            this.txtRB_DueDays.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(506, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "Total (Rs.)";
            // 
            // txtRB_Tot
            // 
            this.txtRB_Tot.Location = new System.Drawing.Point(495, 108);
            this.txtRB_Tot.Name = "txtRB_Tot";
            this.txtRB_Tot.ReadOnly = true;
            this.txtRB_Tot.Size = new System.Drawing.Size(99, 25);
            this.txtRB_Tot.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Final Return Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "Borrowed Date";
            // 
            // dateTimePickerRB_Rdate
            // 
            this.dateTimePickerRB_Rdate.Checked = false;
            this.dateTimePickerRB_Rdate.Location = new System.Drawing.Point(22, 108);
            this.dateTimePickerRB_Rdate.Name = "dateTimePickerRB_Rdate";
            this.dateTimePickerRB_Rdate.Size = new System.Drawing.Size(236, 25);
            this.dateTimePickerRB_Rdate.TabIndex = 3;
            this.dateTimePickerRB_Rdate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dateTimePickerRB_Rdate_MouseUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Due Days";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Returning Date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRBSearchY);
            this.groupBox1.Controls.Add(this.txtRB_BTitle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtRB_Bid);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 82);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Details";
            // 
            // btnRBSearchY
            // 
            this.btnRBSearchY.FlatAppearance.BorderSize = 0;
            this.btnRBSearchY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRBSearchY.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRBSearchY.Image = global::LibHelper.Properties.Resources.icons8_Search_25px;
            this.btnRBSearchY.Location = new System.Drawing.Point(241, 11);
            this.btnRBSearchY.Name = "btnRBSearchY";
            this.btnRBSearchY.Size = new System.Drawing.Size(34, 32);
            this.btnRBSearchY.TabIndex = 24;
            this.btnRBSearchY.UseVisualStyleBackColor = true;
            this.btnRBSearchY.Click += new System.EventHandler(this.btnRBSearchY_Click);
            // 
            // txtRB_BTitle
            // 
            this.txtRB_BTitle.Location = new System.Drawing.Point(315, 43);
            this.txtRB_BTitle.MaxLength = 100;
            this.txtRB_BTitle.Name = "txtRB_BTitle";
            this.txtRB_BTitle.ReadOnly = true;
            this.txtRB_BTitle.Size = new System.Drawing.Size(250, 25);
            this.txtRB_BTitle.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Book Title*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Book ID*";
            // 
            // txtRB_Bid
            // 
            this.txtRB_Bid.Location = new System.Drawing.Point(23, 43);
            this.txtRB_Bid.MaxLength = 20;
            this.txtRB_Bid.Name = "txtRB_Bid";
            this.txtRB_Bid.Size = new System.Drawing.Size(253, 25);
            this.txtRB_Bid.TabIndex = 0;
            // 
            // borrowerDetails
            // 
            this.borrowerDetails.Controls.Add(this.btnRBSearchX);
            this.borrowerDetails.Controls.Add(this.txtRB_Nic);
            this.borrowerDetails.Controls.Add(this.label2);
            this.borrowerDetails.Controls.Add(this.label1);
            this.borrowerDetails.Controls.Add(this.txtRB_Id);
            this.borrowerDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowerDetails.Location = new System.Drawing.Point(20, 12);
            this.borrowerDetails.Name = "borrowerDetails";
            this.borrowerDetails.Size = new System.Drawing.Size(596, 82);
            this.borrowerDetails.TabIndex = 6;
            this.borrowerDetails.TabStop = false;
            this.borrowerDetails.Text = "Borrower Details";
            // 
            // btnRBSearchX
            // 
            this.btnRBSearchX.FlatAppearance.BorderSize = 0;
            this.btnRBSearchX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRBSearchX.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRBSearchX.Image = global::LibHelper.Properties.Resources.icons8_Search_25px;
            this.btnRBSearchX.Location = new System.Drawing.Point(241, 11);
            this.btnRBSearchX.Name = "btnRBSearchX";
            this.btnRBSearchX.Size = new System.Drawing.Size(34, 32);
            this.btnRBSearchX.TabIndex = 23;
            this.btnRBSearchX.UseVisualStyleBackColor = true;
            this.btnRBSearchX.Click += new System.EventHandler(this.btnRBSearchX_Click);
            // 
            // txtRB_Nic
            // 
            this.txtRB_Nic.Location = new System.Drawing.Point(315, 43);
            this.txtRB_Nic.MaxLength = 20;
            this.txtRB_Nic.Name = "txtRB_Nic";
            this.txtRB_Nic.ReadOnly = true;
            this.txtRB_Nic.Size = new System.Drawing.Size(250, 25);
            this.txtRB_Nic.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "NIC No / Postal ID / Passport ID*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Member ID*";
            // 
            // txtRB_Id
            // 
            this.txtRB_Id.Location = new System.Drawing.Point(22, 43);
            this.txtRB_Id.MaxLength = 50;
            this.txtRB_Id.Name = "txtRB_Id";
            this.txtRB_Id.Size = new System.Drawing.Size(253, 25);
            this.txtRB_Id.TabIndex = 0;
            // 
            // btnRBClear
            // 
            this.btnRBClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRBClear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRBClear.Location = new System.Drawing.Point(529, 358);
            this.btnRBClear.Name = "btnRBClear";
            this.btnRBClear.Size = new System.Drawing.Size(87, 32);
            this.btnRBClear.TabIndex = 20;
            this.btnRBClear.Text = "Clear";
            this.btnRBClear.UseVisualStyleBackColor = true;
            this.btnRBClear.Click += new System.EventHandler(this.btnRBClear_Click);
            // 
            // btnRBUpdate
            // 
            this.btnRBUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRBUpdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRBUpdate.Location = new System.Drawing.Point(363, 358);
            this.btnRBUpdate.Name = "btnRBUpdate";
            this.btnRBUpdate.Size = new System.Drawing.Size(163, 32);
            this.btnRBUpdate.TabIndex = 18;
            this.btnRBUpdate.Text = "Extend Return Date";
            this.btnRBUpdate.UseVisualStyleBackColor = true;
            this.btnRBUpdate.Click += new System.EventHandler(this.btnRBUpdate_Click);
            // 
            // btnRBSave
            // 
            this.btnRBSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRBSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRBSave.Location = new System.Drawing.Point(175, 358);
            this.btnRBSave.Name = "btnRBSave";
            this.btnRBSave.Size = new System.Drawing.Size(185, 32);
            this.btnRBSave.TabIndex = 17;
            this.btnRBSave.Text = "Return Burrowed Book";
            this.btnRBSave.UseVisualStyleBackColor = true;
            this.btnRBSave.Click += new System.EventHandler(this.btnRBSave_Click);
            // 
            // returnBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnRBClear);
            this.Controls.Add(this.btnRBUpdate);
            this.Controls.Add(this.btnRBSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.borrowerDetails);
            this.Name = "returnBooks";
            this.Size = new System.Drawing.Size(635, 400);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.borrowerDetails.ResumeLayout(false);
            this.borrowerDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRB_Tot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerRB_Rdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRB_BTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRB_Bid;
        private System.Windows.Forms.GroupBox borrowerDetails;
        private System.Windows.Forms.TextBox txtRB_Nic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRB_Id;
        private System.Windows.Forms.TextBox txtRB_PPD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRB_DueDays;
        private System.Windows.Forms.Button btnRBClear;
        private System.Windows.Forms.Button btnRBUpdate;
        private System.Windows.Forms.Button btnRBSave;
        private System.Windows.Forms.Button btnRBSearchX;
        private System.Windows.Forms.Button btnRBSearchY;
        private System.Windows.Forms.DateTimePicker dateTimePickerRB_Frd;
        private System.Windows.Forms.DateTimePicker dateTimePickerRB_BDate;
    }
}
