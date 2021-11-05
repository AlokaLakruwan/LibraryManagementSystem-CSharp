namespace LibHelper
{
    partial class manageUsers
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMU_Pw2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMU_Pw1 = new System.Windows.Forms.TextBox();
            this.borrowerDetails = new System.Windows.Forms.GroupBox();
            this.btnMUSearchX = new System.Windows.Forms.Button();
            this.comboBoxMU_UType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMU_UName = new System.Windows.Forms.TextBox();
            this.btnMUClear = new System.Windows.Forms.Button();
            this.btnMUDelete = new System.Windows.Forms.Button();
            this.btnMUUpdate = new System.Windows.Forms.Button();
            this.btnMUSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.borrowerDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMU_Pw2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMU_Pw1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Password";
            // 
            // txtMU_Pw2
            // 
            this.txtMU_Pw2.Location = new System.Drawing.Point(315, 64);
            this.txtMU_Pw2.MaxLength = 50;
            this.txtMU_Pw2.Name = "txtMU_Pw2";
            this.txtMU_Pw2.PasswordChar = '*';
            this.txtMU_Pw2.Size = new System.Drawing.Size(253, 25);
            this.txtMU_Pw2.TabIndex = 3;
            this.txtMU_Pw2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Re-enter New Password*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "New Password*";
            // 
            // txtMU_Pw1
            // 
            this.txtMU_Pw1.Location = new System.Drawing.Point(23, 64);
            this.txtMU_Pw1.MaxLength = 50;
            this.txtMU_Pw1.Name = "txtMU_Pw1";
            this.txtMU_Pw1.PasswordChar = '*';
            this.txtMU_Pw1.Size = new System.Drawing.Size(253, 25);
            this.txtMU_Pw1.TabIndex = 0;
            this.txtMU_Pw1.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // borrowerDetails
            // 
            this.borrowerDetails.Controls.Add(this.btnMUSearchX);
            this.borrowerDetails.Controls.Add(this.comboBoxMU_UType);
            this.borrowerDetails.Controls.Add(this.label2);
            this.borrowerDetails.Controls.Add(this.label1);
            this.borrowerDetails.Controls.Add(this.txtMU_UName);
            this.borrowerDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowerDetails.Location = new System.Drawing.Point(17, 19);
            this.borrowerDetails.Name = "borrowerDetails";
            this.borrowerDetails.Size = new System.Drawing.Size(596, 100);
            this.borrowerDetails.TabIndex = 5;
            this.borrowerDetails.TabStop = false;
            this.borrowerDetails.Text = "User Account";
            // 
            // btnMUSearchX
            // 
            this.btnMUSearchX.FlatAppearance.BorderSize = 0;
            this.btnMUSearchX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMUSearchX.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMUSearchX.Image = global::LibHelper.Properties.Resources.icons8_Search_25px;
            this.btnMUSearchX.Location = new System.Drawing.Point(242, 32);
            this.btnMUSearchX.Name = "btnMUSearchX";
            this.btnMUSearchX.Size = new System.Drawing.Size(34, 32);
            this.btnMUSearchX.TabIndex = 26;
            this.btnMUSearchX.UseVisualStyleBackColor = true;
            this.btnMUSearchX.Click += new System.EventHandler(this.btnMUSearchX_Click);
            // 
            // comboBoxMU_UType
            // 
            this.comboBoxMU_UType.FormattingEnabled = true;
            this.comboBoxMU_UType.Items.AddRange(new object[] {
            "Admin",
            "Librarion"});
            this.comboBoxMU_UType.Location = new System.Drawing.Point(315, 64);
            this.comboBoxMU_UType.Name = "comboBoxMU_UType";
            this.comboBoxMU_UType.Size = new System.Drawing.Size(253, 25);
            this.comboBoxMU_UType.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Type*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username*";
            // 
            // txtMU_UName
            // 
            this.txtMU_UName.Location = new System.Drawing.Point(23, 64);
            this.txtMU_UName.MaxLength = 50;
            this.txtMU_UName.Name = "txtMU_UName";
            this.txtMU_UName.Size = new System.Drawing.Size(253, 25);
            this.txtMU_UName.TabIndex = 0;
            // 
            // btnMUClear
            // 
            this.btnMUClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMUClear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMUClear.Location = new System.Drawing.Point(526, 357);
            this.btnMUClear.Name = "btnMUClear";
            this.btnMUClear.Size = new System.Drawing.Size(87, 32);
            this.btnMUClear.TabIndex = 20;
            this.btnMUClear.Text = "Clear";
            this.btnMUClear.UseVisualStyleBackColor = true;
            this.btnMUClear.Click += new System.EventHandler(this.btnMUClear_Click);
            // 
            // btnMUDelete
            // 
            this.btnMUDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMUDelete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMUDelete.Location = new System.Drawing.Point(403, 357);
            this.btnMUDelete.Name = "btnMUDelete";
            this.btnMUDelete.Size = new System.Drawing.Size(121, 32);
            this.btnMUDelete.TabIndex = 19;
            this.btnMUDelete.Text = "Remove User";
            this.btnMUDelete.UseVisualStyleBackColor = true;
            this.btnMUDelete.Click += new System.EventHandler(this.btnMUDelete_Click);
            // 
            // btnMUUpdate
            // 
            this.btnMUUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMUUpdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMUUpdate.Location = new System.Drawing.Point(247, 357);
            this.btnMUUpdate.Name = "btnMUUpdate";
            this.btnMUUpdate.Size = new System.Drawing.Size(154, 32);
            this.btnMUUpdate.TabIndex = 18;
            this.btnMUUpdate.Text = "Update Password";
            this.btnMUUpdate.UseVisualStyleBackColor = true;
            this.btnMUUpdate.Click += new System.EventHandler(this.btnMUUpdate_Click);
            // 
            // btnMUSave
            // 
            this.btnMUSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMUSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMUSave.Location = new System.Drawing.Point(158, 357);
            this.btnMUSave.Name = "btnMUSave";
            this.btnMUSave.Size = new System.Drawing.Size(87, 32);
            this.btnMUSave.TabIndex = 17;
            this.btnMUSave.Text = "Save";
            this.btnMUSave.UseVisualStyleBackColor = true;
            this.btnMUSave.Click += new System.EventHandler(this.btnMUSave_Click);
            // 
            // manageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnMUClear);
            this.Controls.Add(this.btnMUDelete);
            this.Controls.Add(this.btnMUUpdate);
            this.Controls.Add(this.btnMUSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.borrowerDetails);
            this.Name = "manageUsers";
            this.Size = new System.Drawing.Size(635, 400);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.borrowerDetails.ResumeLayout(false);
            this.borrowerDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMU_Pw2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMU_Pw1;
        private System.Windows.Forms.GroupBox borrowerDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMU_UName;
        private System.Windows.Forms.ComboBox comboBoxMU_UType;
        private System.Windows.Forms.Button btnMUClear;
        private System.Windows.Forms.Button btnMUDelete;
        private System.Windows.Forms.Button btnMUUpdate;
        private System.Windows.Forms.Button btnMUSave;
        private System.Windows.Forms.Button btnMUSearchX;
    }
}
