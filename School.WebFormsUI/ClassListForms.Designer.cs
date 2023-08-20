namespace School.WebFormsUI
{
    partial class ClassListForms
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
            this.cmbxGradeId = new System.Windows.Forms.ComboBox();
            this.cmbxClassCode = new System.Windows.Forms.ComboBox();
            this.cmbxTeacherId = new System.Windows.Forms.ComboBox();
            this.btnAddTeacherToClass = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbxTClass = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbxTGrade = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbxLessons = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbxLClass = new System.Windows.Forms.ComboBox();
            this.cmbxLStudentName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddStudentToClass = new System.Windows.Forms.Button();
            this.cmbxLGrade = new System.Windows.Forms.ComboBox();
            this.dgvTeacherList = new System.Windows.Forms.DataGridView();
            this.dgvStudentList = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbxGradeId
            // 
            this.cmbxGradeId.FormattingEnabled = true;
            this.cmbxGradeId.Location = new System.Drawing.Point(28, 45);
            this.cmbxGradeId.Name = "cmbxGradeId";
            this.cmbxGradeId.Size = new System.Drawing.Size(65, 21);
            this.cmbxGradeId.TabIndex = 0;
            // 
            // cmbxClassCode
            // 
            this.cmbxClassCode.FormattingEnabled = true;
            this.cmbxClassCode.Location = new System.Drawing.Point(99, 45);
            this.cmbxClassCode.Name = "cmbxClassCode";
            this.cmbxClassCode.Size = new System.Drawing.Size(65, 21);
            this.cmbxClassCode.TabIndex = 1;
            // 
            // cmbxTeacherId
            // 
            this.cmbxTeacherId.FormattingEnabled = true;
            this.cmbxTeacherId.Location = new System.Drawing.Point(25, 70);
            this.cmbxTeacherId.Name = "cmbxTeacherId";
            this.cmbxTeacherId.Size = new System.Drawing.Size(150, 21);
            this.cmbxTeacherId.TabIndex = 2;
            this.cmbxTeacherId.SelectedIndexChanged += new System.EventHandler(this.cmbxTeacherId_SelectedIndexChanged);
            // 
            // btnAddTeacherToClass
            // 
            this.btnAddTeacherToClass.Location = new System.Drawing.Point(25, 133);
            this.btnAddTeacherToClass.Name = "btnAddTeacherToClass";
            this.btnAddTeacherToClass.Size = new System.Drawing.Size(150, 33);
            this.btnAddTeacherToClass.TabIndex = 3;
            this.btnAddTeacherToClass.Text = "Add the teacher to the class";
            this.btnAddTeacherToClass.UseVisualStyleBackColor = true;
            this.btnAddTeacherToClass.Click += new System.EventHandler(this.btnAddTeacherToClass_Click);
            // 
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(28, 86);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(136, 28);
            this.btnAddClass.TabIndex = 4;
            this.btnAddClass.Text = "Add a New Class";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Grade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Class";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbxClassCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbxGradeId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAddClass);
            this.groupBox1.Location = new System.Drawing.Point(23, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 180);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a New Class";
            // 
            // cmbxTClass
            // 
            this.cmbxTClass.FormattingEnabled = true;
            this.cmbxTClass.Location = new System.Drawing.Point(110, 31);
            this.cmbxTClass.Name = "cmbxTClass";
            this.cmbxTClass.Size = new System.Drawing.Size(65, 21);
            this.cmbxTClass.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Class";
            // 
            // cmbxTGrade
            // 
            this.cmbxTGrade.FormattingEnabled = true;
            this.cmbxTGrade.Location = new System.Drawing.Point(25, 31);
            this.cmbxTGrade.Name = "cmbxTGrade";
            this.cmbxTGrade.Size = new System.Drawing.Size(65, 21);
            this.cmbxTGrade.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Grade";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbxLessons);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbxTClass);
            this.groupBox2.Controls.Add(this.cmbxTeacherId);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnAddTeacherToClass);
            this.groupBox2.Controls.Add(this.cmbxTGrade);
            this.groupBox2.Location = new System.Drawing.Point(247, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 180);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add a Teacher to a class";
            // 
            // cmbxLessons
            // 
            this.cmbxLessons.FormattingEnabled = true;
            this.cmbxLessons.Location = new System.Drawing.Point(25, 106);
            this.cmbxLessons.Name = "cmbxLessons";
            this.cmbxLessons.Size = new System.Drawing.Size(150, 21);
            this.cmbxLessons.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cmbxLClass);
            this.groupBox3.Controls.Add(this.cmbxLStudentName);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnAddStudentToClass);
            this.groupBox3.Controls.Add(this.cmbxLGrade);
            this.groupBox3.Location = new System.Drawing.Point(468, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 180);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add a Student to a class";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Grade";
            // 
            // cmbxLClass
            // 
            this.cmbxLClass.FormattingEnabled = true;
            this.cmbxLClass.Location = new System.Drawing.Point(110, 31);
            this.cmbxLClass.Name = "cmbxLClass";
            this.cmbxLClass.Size = new System.Drawing.Size(65, 21);
            this.cmbxLClass.TabIndex = 9;
            // 
            // cmbxLStudentName
            // 
            this.cmbxLStudentName.FormattingEnabled = true;
            this.cmbxLStudentName.Location = new System.Drawing.Point(25, 70);
            this.cmbxLStudentName.Name = "cmbxLStudentName";
            this.cmbxLStudentName.Size = new System.Drawing.Size(150, 21);
            this.cmbxLStudentName.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Class";
            // 
            // btnAddStudentToClass
            // 
            this.btnAddStudentToClass.Location = new System.Drawing.Point(25, 106);
            this.btnAddStudentToClass.Name = "btnAddStudentToClass";
            this.btnAddStudentToClass.Size = new System.Drawing.Size(150, 33);
            this.btnAddStudentToClass.TabIndex = 3;
            this.btnAddStudentToClass.Text = "Add the student to the class";
            this.btnAddStudentToClass.UseVisualStyleBackColor = true;
            this.btnAddStudentToClass.Click += new System.EventHandler(this.btnAddStudentToClass_Click);
            // 
            // cmbxLGrade
            // 
            this.cmbxLGrade.FormattingEnabled = true;
            this.cmbxLGrade.Location = new System.Drawing.Point(25, 31);
            this.cmbxLGrade.Name = "cmbxLGrade";
            this.cmbxLGrade.Size = new System.Drawing.Size(65, 21);
            this.cmbxLGrade.TabIndex = 8;
            // 
            // dgvTeacherList
            // 
            this.dgvTeacherList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeacherList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dgvTeacherList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacherList.Location = new System.Drawing.Point(12, 252);
            this.dgvTeacherList.Name = "dgvTeacherList";
            this.dgvTeacherList.Size = new System.Drawing.Size(311, 390);
            this.dgvTeacherList.TabIndex = 14;
            // 
            // dgvStudentList
            // 
            this.dgvStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentList.Location = new System.Drawing.Point(354, 252);
            this.dgvStudentList.Name = "dgvStudentList";
            this.dgvStudentList.Size = new System.Drawing.Size(311, 390);
            this.dgvStudentList.TabIndex = 15;
            // 
            // ClassListForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 664);
            this.Controls.Add(this.dgvStudentList);
            this.Controls.Add(this.dgvTeacherList);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ClassListForms";
            this.Text = "ClassListForms";
            this.Load += new System.EventHandler(this.ClassListForms_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbxGradeId;
        private System.Windows.Forms.ComboBox cmbxClassCode;
        private System.Windows.Forms.ComboBox cmbxTeacherId;
        private System.Windows.Forms.Button btnAddTeacherToClass;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbxTClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbxTGrade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbxLessons;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbxLClass;
        private System.Windows.Forms.ComboBox cmbxLStudentName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddStudentToClass;
        private System.Windows.Forms.ComboBox cmbxLGrade;
        private System.Windows.Forms.DataGridView dgvTeacherList;
        private System.Windows.Forms.DataGridView dgvStudentList;
    }
}