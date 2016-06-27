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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddPeople = new System.Windows.Forms.Button();
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
            this.groupBox2.Location = new System.Drawing.Point(957, 13);
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
            this.dgvSearchPeople.Size = new System.Drawing.Size(487, 297);
            this.dgvSearchPeople.TabIndex = 4;
            // 
            // dgvSearchPosition
            // 
            this.dgvSearchPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchPosition.Location = new System.Drawing.Point(957, 71);
            this.dgvSearchPosition.Name = "dgvSearchPosition";
            this.dgvSearchPosition.ReadOnly = true;
            this.dgvSearchPosition.RowTemplate.Height = 24;
            this.dgvSearchPosition.Size = new System.Drawing.Size(216, 298);
            this.dgvSearchPosition.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(513, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(908, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 39);
            this.button2.TabIndex = 7;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(590, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(288, 297);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
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
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 381);
            this.Controls.Add(this.btnAddPeople);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddPeople;
    }
}