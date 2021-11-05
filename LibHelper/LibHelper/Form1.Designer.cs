namespace LibHelper
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidePanel1 = new System.Windows.Forms.Panel();
            this.btnLO = new System.Windows.Forms.Button();
            this.btnVD = new System.Windows.Forms.Button();
            this.btnMU = new System.Windows.Forms.Button();
            this.btnMM = new System.Windows.Forms.Button();
            this.btnMB = new System.Windows.Forms.Button();
            this.btnRB = new System.Windows.Forms.Button();
            this.btnBB = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.manageBooks1 = new LibHelper.manageBooks();
            this.borrowBooks = new LibHelper.borrowBooks();
            this.returnBooks1 = new LibHelper.returnBooks();
            this.manageMembers1 = new LibHelper.manageMembers();
            this.manageUsers1 = new LibHelper.manageUsers();
            this.viewData1 = new LibHelper.viewData();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.sidePanel1);
            this.panel1.Controls.Add(this.btnLO);
            this.panel1.Controls.Add(this.btnVD);
            this.panel1.Controls.Add(this.btnMU);
            this.panel1.Controls.Add(this.btnMM);
            this.panel1.Controls.Add(this.btnMB);
            this.panel1.Controls.Add(this.btnRB);
            this.panel1.Controls.Add(this.btnBB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 511);
            this.panel1.TabIndex = 0;
            // 
            // sidePanel1
            // 
            this.sidePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.sidePanel1.Location = new System.Drawing.Point(0, 45);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(10, 45);
            this.sidePanel1.TabIndex = 4;
            // 
            // btnLO
            // 
            this.btnLO.FlatAppearance.BorderSize = 0;
            this.btnLO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLO.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLO.ForeColor = System.Drawing.Color.White;
            this.btnLO.Image = global::LibHelper.Properties.Resources.icons8_Sign_Out_45px;
            this.btnLO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLO.Location = new System.Drawing.Point(11, 351);
            this.btnLO.Name = "btnLO";
            this.btnLO.Size = new System.Drawing.Size(181, 50);
            this.btnLO.TabIndex = 2;
            this.btnLO.Text = "Log Out";
            this.btnLO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLO.UseVisualStyleBackColor = true;
            this.btnLO.Click += new System.EventHandler(this.btnLO_Click);
            // 
            // btnVD
            // 
            this.btnVD.FlatAppearance.BorderSize = 0;
            this.btnVD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVD.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVD.ForeColor = System.Drawing.Color.White;
            this.btnVD.Image = global::LibHelper.Properties.Resources.icons8_View_45px;
            this.btnVD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVD.Location = new System.Drawing.Point(11, 300);
            this.btnVD.Name = "btnVD";
            this.btnVD.Size = new System.Drawing.Size(181, 50);
            this.btnVD.TabIndex = 2;
            this.btnVD.Text = "View Data";
            this.btnVD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVD.UseVisualStyleBackColor = true;
            this.btnVD.Click += new System.EventHandler(this.btnMU_Click);
            // 
            // btnMU
            // 
            this.btnMU.FlatAppearance.BorderSize = 0;
            this.btnMU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMU.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMU.ForeColor = System.Drawing.Color.White;
            this.btnMU.Image = global::LibHelper.Properties.Resources.icons8_Access_45px;
            this.btnMU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMU.Location = new System.Drawing.Point(11, 249);
            this.btnMU.Name = "btnMU";
            this.btnMU.Size = new System.Drawing.Size(181, 50);
            this.btnMU.TabIndex = 2;
            this.btnMU.Text = "Manage Users";
            this.btnMU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMU.UseVisualStyleBackColor = true;
            this.btnMU.Click += new System.EventHandler(this.btnVD_Click);
            // 
            // btnMM
            // 
            this.btnMM.FlatAppearance.BorderSize = 0;
            this.btnMM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMM.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMM.ForeColor = System.Drawing.Color.White;
            this.btnMM.Image = global::LibHelper.Properties.Resources.icons8_Team_45px;
            this.btnMM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMM.Location = new System.Drawing.Point(11, 198);
            this.btnMM.Name = "btnMM";
            this.btnMM.Size = new System.Drawing.Size(181, 50);
            this.btnMM.TabIndex = 2;
            this.btnMM.Text = "Manage Members";
            this.btnMM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMM.UseVisualStyleBackColor = true;
            this.btnMM.Click += new System.EventHandler(this.btnMM_Click);
            // 
            // btnMB
            // 
            this.btnMB.FlatAppearance.BorderSize = 0;
            this.btnMB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMB.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMB.ForeColor = System.Drawing.Color.White;
            this.btnMB.Image = global::LibHelper.Properties.Resources.icons8_Books_45px;
            this.btnMB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMB.Location = new System.Drawing.Point(11, 147);
            this.btnMB.Name = "btnMB";
            this.btnMB.Size = new System.Drawing.Size(181, 50);
            this.btnMB.TabIndex = 2;
            this.btnMB.Text = "Manage Books";
            this.btnMB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMB.UseVisualStyleBackColor = true;
            this.btnMB.Click += new System.EventHandler(this.btnMB_Click);
            // 
            // btnRB
            // 
            this.btnRB.FlatAppearance.BorderSize = 0;
            this.btnRB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRB.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRB.ForeColor = System.Drawing.Color.White;
            this.btnRB.Image = global::LibHelper.Properties.Resources.icons8_Borrow_Book_45px;
            this.btnRB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRB.Location = new System.Drawing.Point(11, 96);
            this.btnRB.Name = "btnRB";
            this.btnRB.Size = new System.Drawing.Size(181, 50);
            this.btnRB.TabIndex = 2;
            this.btnRB.Text = "Return Books";
            this.btnRB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRB.UseVisualStyleBackColor = true;
            this.btnRB.Click += new System.EventHandler(this.btnRB_Click);
            // 
            // btnBB
            // 
            this.btnBB.FlatAppearance.BorderSize = 0;
            this.btnBB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBB.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBB.ForeColor = System.Drawing.Color.White;
            this.btnBB.Image = global::LibHelper.Properties.Resources.icons8_Return_Book_45px_2;
            this.btnBB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBB.Location = new System.Drawing.Point(11, 45);
            this.btnBB.Name = "btnBB";
            this.btnBB.Size = new System.Drawing.Size(181, 50);
            this.btnBB.TabIndex = 1;
            this.btnBB.Text = "Borrow Books";
            this.btnBB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBB.UseVisualStyleBackColor = true;
            this.btnBB.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(192, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(658, 10);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(192, 501);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(658, 10);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(840, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 491);
            this.panel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 71);
            this.label1.TabIndex = 7;
            this.label1.Text = "Library Helper";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Library  Management System";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::LibHelper.Properties.Resources.icons8_Minimize_Window_30px;
            this.button2.Location = new System.Drawing.Point(780, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Image = global::LibHelper.Properties.Resources.icons8_Close_Window_30px;
            this.btnExit.Location = new System.Drawing.Point(807, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // manageBooks1
            // 
            this.manageBooks1.Location = new System.Drawing.Point(198, 96);
            this.manageBooks1.Name = "manageBooks1";
            this.manageBooks1.Size = new System.Drawing.Size(635, 400);
            this.manageBooks1.TabIndex = 14;
            // 
            // borrowBooks
            // 
            this.borrowBooks.BackColor = System.Drawing.SystemColors.Control;
            this.borrowBooks.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowBooks.Location = new System.Drawing.Point(198, 95);
            this.borrowBooks.Name = "borrowBooks";
            this.borrowBooks.Size = new System.Drawing.Size(635, 400);
            this.borrowBooks.TabIndex = 12;
            // 
            // returnBooks1
            // 
            this.returnBooks1.BackColor = System.Drawing.SystemColors.Control;
            this.returnBooks1.Location = new System.Drawing.Point(198, 96);
            this.returnBooks1.Name = "returnBooks1";
            this.returnBooks1.Size = new System.Drawing.Size(636, 401);
            this.returnBooks1.TabIndex = 11;
            // 
            // manageMembers1
            // 
            this.manageMembers1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageMembers1.Location = new System.Drawing.Point(198, 96);
            this.manageMembers1.Name = "manageMembers1";
            this.manageMembers1.Size = new System.Drawing.Size(635, 400);
            this.manageMembers1.TabIndex = 15;
            // 
            // manageUsers1
            // 
            this.manageUsers1.Location = new System.Drawing.Point(198, 95);
            this.manageUsers1.Name = "manageUsers1";
            this.manageUsers1.Size = new System.Drawing.Size(635, 400);
            this.manageUsers1.TabIndex = 16;
            // 
            // viewData1
            // 
            this.viewData1.Location = new System.Drawing.Point(198, 96);
            this.viewData1.Name = "viewData1";
            this.viewData1.Size = new System.Drawing.Size(635, 400);
            this.viewData1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 511);
            this.Controls.Add(this.viewData1);
            this.Controls.Add(this.manageUsers1);
            this.Controls.Add(this.manageMembers1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.returnBooks1);
            this.Controls.Add(this.borrowBooks);
            this.Controls.Add(this.manageBooks1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel sidePanel1;
        private System.Windows.Forms.Button btnLO;
        private System.Windows.Forms.Button btnVD;
        private System.Windows.Forms.Button btnMU;
        private System.Windows.Forms.Button btnMM;
        private System.Windows.Forms.Button btnMB;
        private System.Windows.Forms.Button btnRB;
        private System.Windows.Forms.Button btnBB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private manageBooks manageBooks1;
        private borrowBooks borrowBooks;
        private returnBooks returnBooks1;
        private manageMembers manageMembers1;
        private manageUsers manageUsers1;
        private viewData viewData1;
    }
}

