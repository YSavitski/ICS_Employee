namespace ICS_Employee
{
    partial class AddEmployee
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
            this.tbSearchPeople = new System.Windows.Forms.TextBox();
            this.btnSearchPeople = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbSearchPosition = new System.Windows.Forms.TextBox();
            this.btnSearchPosition = new System.Windows.Forms.Button();
            this.dgvSearchPeople = new System.Windows.Forms.DataGridView();
            this.dgvSearchPosition = new System.Windows.Forms.DataGridView();
            this.btnInfoPeople = new System.Windows.Forms.Button();
            this.btnInfoPosition = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.tbBirthday = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddPeople = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchPosition)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSearchPeople);
            this.groupBox1.Controls.Add(this.btnSearchPeople);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search people:";
            // 
            // tbSearchPeople
            // 
            this.tbSearchPeople.Location = new System.Drawing.Point(7, 21);
            this.tbSearchPeople.Name = "tbSearchPeople";
            this.tbSearchPeople.Size = new System.Drawing.Size(148, 22);
            this.tbSearchPeople.TabIndex = 2;
            // 
            // btnSearchPeople
            // 
            this.btnSearchPeople.Location = new System.Drawing.Point(161, 21);
            this.btnSearchPeople.Name = "btnSearchPeople";
            this.btnSearchPeople.Size = new System.Drawing.Size(62, 23);
            this.btnSearchPeople.TabIndex = 1;
            this.btnSearchPeople.Text = "Search";
            this.btnSearchPeople.UseVisualStyleBackColor = true;
            this.btnSearchPeople.Click += new System.EventHandler(this.btnSearchPeople_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbSearchPosition);
            this.groupBox2.Controls.Add(this.btnSearchPosition);
            this.groupBox2.Location = new System.Drawing.Point(914, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 52);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search position:";
            // 
            // tbSearchPosition
            // 
            this.tbSearchPosition.Location = new System.Drawing.Point(7, 21);
            this.tbSearchPosition.Name = "tbSearchPosition";
            this.tbSearchPosition.Size = new System.Drawing.Size(138, 22);
            this.tbSearchPosition.TabIndex = 2;
            // 
            // btnSearchPosition
            // 
            this.btnSearchPosition.Location = new System.Drawing.Point(151, 21);
            this.btnSearchPosition.Name = "btnSearchPosition";
            this.btnSearchPosition.Size = new System.Drawing.Size(62, 23);
            this.btnSearchPosition.TabIndex = 1;
            this.btnSearchPosition.Text = "Search";
            this.btnSearchPosition.UseVisualStyleBackColor = true;
            this.btnSearchPosition.Click += new System.EventHandler(this.btnSearchPosition_Click);
            // 
            // dgvSearchPeople
            // 
            this.dgvSearchPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchPeople.Location = new System.Drawing.Point(20, 72);
            this.dgvSearchPeople.Name = "dgvSearchPeople";
            this.dgvSearchPeople.ReadOnly = true;
            this.dgvSearchPeople.RowTemplate.Height = 24;
            this.dgvSearchPeople.Size = new System.Drawing.Size(461, 247);
            this.dgvSearchPeople.TabIndex = 4;
            // 
            // dgvSearchPosition
            // 
            this.dgvSearchPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchPosition.Location = new System.Drawing.Point(914, 72);
            this.dgvSearchPosition.Name = "dgvSearchPosition";
            this.dgvSearchPosition.ReadOnly = true;
            this.dgvSearchPosition.RowTemplate.Height = 24;
            this.dgvSearchPosition.Size = new System.Drawing.Size(216, 247);
            this.dgvSearchPosition.TabIndex = 5;
            // 
            // btnInfoPeople
            // 
            this.btnInfoPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInfoPeople.Location = new System.Drawing.Point(487, 185);
            this.btnInfoPeople.Name = "btnInfoPeople";
            this.btnInfoPeople.Size = new System.Drawing.Size(43, 39);
            this.btnInfoPeople.TabIndex = 6;
            this.btnInfoPeople.Text = ">>";
            this.btnInfoPeople.UseVisualStyleBackColor = true;
            this.btnInfoPeople.Click += new System.EventHandler(this.btnInfoPeople_Click);
            // 
            // btnInfoPosition
            // 
            this.btnInfoPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInfoPosition.Location = new System.Drawing.Point(865, 185);
            this.btnInfoPosition.Name = "btnInfoPosition";
            this.btnInfoPosition.Size = new System.Drawing.Size(43, 39);
            this.btnInfoPosition.TabIndex = 7;
            this.btnInfoPosition.Text = "<<";
            this.btnInfoPosition.UseVisualStyleBackColor = true;
            this.btnInfoPosition.Click += new System.EventHandler(this.btnInfoPosition_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbSalary);
            this.groupBox3.Controls.Add(this.tbPosition);
            this.groupBox3.Controls.Add(this.tbBirthday);
            this.groupBox3.Controls.Add(this.tbLastName);
            this.groupBox3.Controls.Add(this.tbFirstName);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(536, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(323, 188);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "New employeee:";
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(111, 151);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(201, 22);
            this.tbSalary.TabIndex = 19;
            this.tbSalary.TextChanged += new System.EventHandler(this.tbSalary_TextChanged);
            // 
            // tbPosition
            // 
            this.tbPosition.Location = new System.Drawing.Point(111, 123);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.ReadOnly = true;
            this.tbPosition.Size = new System.Drawing.Size(201, 22);
            this.tbPosition.TabIndex = 18;
            // 
            // tbBirthday
            // 
            this.tbBirthday.Location = new System.Drawing.Point(111, 95);
            this.tbBirthday.Name = "tbBirthday";
            this.tbBirthday.ReadOnly = true;
            this.tbBirthday.Size = new System.Drawing.Size(201, 22);
            this.tbBirthday.TabIndex = 17;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(111, 67);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.ReadOnly = true;
            this.tbLastName.Size = new System.Drawing.Size(201, 22);
            this.tbLastName.TabIndex = 16;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(111, 39);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.ReadOnly = true;
            this.tbFirstName.Size = new System.Drawing.Size(201, 22);
            this.tbFirstName.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Salary:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Position:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Birthday:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Last name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "First name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // btnAddPeople
            // 
            this.btnAddPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddPeople.Location = new System.Drawing.Point(248, 13);
            this.btnAddPeople.Name = "btnAddPeople";
            this.btnAddPeople.Size = new System.Drawing.Size(105, 52);
            this.btnAddPeople.TabIndex = 9;
            this.btnAddPeople.Text = "Add new people";
            this.btnAddPeople.UseVisualStyleBackColor = true;
            this.btnAddPeople.Click += new System.EventHandler(this.btnAddPeople_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(777, 280);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 39);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOK.Location = new System.Drawing.Point(689, 280);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(82, 39);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 330);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddPeople);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnInfoPosition);
            this.Controls.Add(this.btnInfoPeople);
            this.Controls.Add(this.dgvSearchPosition);
            this.Controls.Add(this.dgvSearchPeople);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchPosition)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSearchPeople;
        private System.Windows.Forms.Button btnSearchPeople;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbSearchPosition;
        private System.Windows.Forms.Button btnSearchPosition;
        private System.Windows.Forms.DataGridView dgvSearchPeople;
        private System.Windows.Forms.DataGridView dgvSearchPosition;
        private System.Windows.Forms.Button btnInfoPeople;
        private System.Windows.Forms.Button btnInfoPosition;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddPeople;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.TextBox tbBirthday;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}