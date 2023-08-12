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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(200, 201);
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
            this.groupBox2.Location = new System.Drawing.Point(255, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 201);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add a Teacher to a Class";
            // 
            // cmbxLessons
            // 
            this.cmbxLessons.FormattingEnabled = true;
            this.cmbxLessons.Location = new System.Drawing.Point(25, 106);
            this.cmbxLessons.Name = "cmbxLessons";
            this.cmbxLessons.Size = new System.Drawing.Size(150, 21);
            this.cmbxLessons.TabIndex = 12;
            // 
            // ClassListForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 664);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ClassListForms";
            this.Text = "ClassListForms";
            this.Load += new System.EventHandler(this.ClassListForms_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
    }
}