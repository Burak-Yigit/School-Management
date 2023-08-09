namespace School.WebFormsUI
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
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.cmbxDepartment = new System.Windows.Forms.ComboBox();
            this.cmbxPosition = new System.Windows.Forms.ComboBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxBranch = new System.Windows.Forms.ComboBox();
            this.tbxSalary = new System.Windows.Forms.TextBox();
            this.mtbxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnMarried = new System.Windows.Forms.RadioButton();
            this.rbtnSingle = new System.Windows.Forms.RadioButton();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(131, 153);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(150, 20);
            this.tbxFirstName.TabIndex = 0;
            // 
            // cmbxDepartment
            // 
            this.cmbxDepartment.FormattingEnabled = true;
            this.cmbxDepartment.Location = new System.Drawing.Point(131, 40);
            this.cmbxDepartment.Name = "cmbxDepartment";
            this.cmbxDepartment.Size = new System.Drawing.Size(150, 21);
            this.cmbxDepartment.TabIndex = 1;
            // 
            // cmbxPosition
            // 
            this.cmbxPosition.FormattingEnabled = true;
            this.cmbxPosition.Location = new System.Drawing.Point(131, 77);
            this.cmbxPosition.Name = "cmbxPosition";
            this.cmbxPosition.Size = new System.Drawing.Size(150, 21);
            this.cmbxPosition.TabIndex = 2;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(131, 193);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(150, 20);
            this.tbxLastName.TabIndex = 3;
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Location = new System.Drawing.Point(131, 232);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(150, 20);
            this.dtpBirthdate.TabIndex = 4;
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Location = new System.Drawing.Point(131, 276);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(150, 20);
            this.dtpHireDate.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddEmp);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblLastName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbxBranch);
            this.groupBox1.Controls.Add(this.tbxSalary);
            this.groupBox1.Controls.Add(this.mtbxPhoneNumber);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dtpBirthdate);
            this.groupBox1.Controls.Add(this.dtpHireDate);
            this.groupBox1.Controls.Add(this.tbxFirstName);
            this.groupBox1.Controls.Add(this.cmbxDepartment);
            this.groupBox1.Controls.Add(this.tbxLastName);
            this.groupBox1.Controls.Add(this.cmbxPosition);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 493);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add an Employee";
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Location = new System.Drawing.Point(131, 436);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(150, 41);
            this.btnAddEmp.TabIndex = 20;
            this.btnAddEmp.Text = "Add an Employee";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(77, 407);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Salary";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Phone Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Marital Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Hire Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Birthdate";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(55, 196);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 14;
            this.lblLastName.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Branch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Position";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Department";
            // 
            // cmbxBranch
            // 
            this.cmbxBranch.FormattingEnabled = true;
            this.cmbxBranch.Location = new System.Drawing.Point(131, 114);
            this.cmbxBranch.Name = "cmbxBranch";
            this.cmbxBranch.Size = new System.Drawing.Size(150, 21);
            this.cmbxBranch.TabIndex = 9;
            // 
            // tbxSalary
            // 
            this.tbxSalary.Location = new System.Drawing.Point(131, 400);
            this.tbxSalary.Name = "tbxSalary";
            this.tbxSalary.Size = new System.Drawing.Size(150, 20);
            this.tbxSalary.TabIndex = 8;
            // 
            // mtbxPhoneNumber
            // 
            this.mtbxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.mtbxPhoneNumber.Location = new System.Drawing.Point(131, 356);
            this.mtbxPhoneNumber.Mask = "(999) 000-0000";
            this.mtbxPhoneNumber.Name = "mtbxPhoneNumber";
            this.mtbxPhoneNumber.Size = new System.Drawing.Size(150, 30);
            this.mtbxPhoneNumber.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnMarried);
            this.groupBox2.Controls.Add(this.rbtnSingle);
            this.groupBox2.Location = new System.Drawing.Point(131, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 42);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // rbtnMarried
            // 
            this.rbtnMarried.AutoSize = true;
            this.rbtnMarried.Location = new System.Drawing.Point(84, 15);
            this.rbtnMarried.Name = "rbtnMarried";
            this.rbtnMarried.Size = new System.Drawing.Size(60, 17);
            this.rbtnMarried.TabIndex = 1;
            this.rbtnMarried.TabStop = true;
            this.rbtnMarried.Text = "Married";
            this.rbtnMarried.UseVisualStyleBackColor = true;
            // 
            // rbtnSingle
            // 
            this.rbtnSingle.AutoSize = true;
            this.rbtnSingle.Location = new System.Drawing.Point(6, 15);
            this.rbtnSingle.Name = "rbtnSingle";
            this.rbtnSingle.Size = new System.Drawing.Size(54, 17);
            this.rbtnSingle.TabIndex = 0;
            this.rbtnSingle.TabStop = true;
            this.rbtnSingle.Text = "Single";
            this.rbtnSingle.UseVisualStyleBackColor = true;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(403, 35);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.Size = new System.Drawing.Size(786, 485);
            this.dgvEmployee.TabIndex = 7;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 550);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEmployee";
            this.Load += new System.EventHandler(this.btnAddEmployee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.ComboBox cmbxDepartment;
        private System.Windows.Forms.ComboBox cmbxPosition;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnMarried;
        private System.Windows.Forms.RadioButton rbtnSingle;
        private System.Windows.Forms.MaskedTextBox mtbxPhoneNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbxBranch;
        private System.Windows.Forms.TextBox tbxSalary;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Button btnAddEmp;
    }
}