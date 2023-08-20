namespace School.WebFormsUI
{
    partial class MainMenuForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForms));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnUpdateParent = new System.Windows.Forms.Button();
            this.btnAddParent = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdateClass = new System.Windows.Forms.Button();
            this.btnAddingClassEvents = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "--------- School Administration Panel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(941, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdateStudent);
            this.groupBox1.Controls.Add(this.btnAddStudent);
            this.groupBox1.Controls.Add(this.btnUpdateParent);
            this.groupBox1.Controls.Add(this.btnAddParent);
            this.groupBox1.Location = new System.Drawing.Point(23, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 184);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Registration and Update Panels";
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.BackColor = System.Drawing.Color.Cornsilk;
            this.btnUpdateStudent.Location = new System.Drawing.Point(168, 99);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(156, 80);
            this.btnUpdateStudent.TabIndex = 4;
            this.btnUpdateStudent.Text = "Update a Student";
            this.btnUpdateStudent.UseVisualStyleBackColor = false;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.FloralWhite;
            this.btnAddStudent.Location = new System.Drawing.Point(2, 99);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(156, 80);
            this.btnAddStudent.TabIndex = 3;
            this.btnAddStudent.Text = "Add a Student";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnUpdateParent
            // 
            this.btnUpdateParent.BackColor = System.Drawing.Color.Cornsilk;
            this.btnUpdateParent.Location = new System.Drawing.Point(168, 19);
            this.btnUpdateParent.Name = "btnUpdateParent";
            this.btnUpdateParent.Size = new System.Drawing.Size(156, 80);
            this.btnUpdateParent.TabIndex = 1;
            this.btnUpdateParent.Text = "Update a Parent";
            this.btnUpdateParent.UseVisualStyleBackColor = false;
            this.btnUpdateParent.Click += new System.EventHandler(this.btnUpdateParent_Click);
            // 
            // btnAddParent
            // 
            this.btnAddParent.BackColor = System.Drawing.Color.FloralWhite;
            this.btnAddParent.Location = new System.Drawing.Point(2, 19);
            this.btnAddParent.Name = "btnAddParent";
            this.btnAddParent.Size = new System.Drawing.Size(156, 80);
            this.btnAddParent.TabIndex = 0;
            this.btnAddParent.Text = "Add a Parent";
            this.btnAddParent.UseVisualStyleBackColor = false;
            this.btnAddParent.Click += new System.EventHandler(this.btnAddParent_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdateClass);
            this.groupBox2.Controls.Add(this.btnAddingClassEvents);
            this.groupBox2.Location = new System.Drawing.Point(623, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 184);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Class Registration and Update Panels";
            // 
            // btnUpdateClass
            // 
            this.btnUpdateClass.BackColor = System.Drawing.Color.Cornsilk;
            this.btnUpdateClass.Location = new System.Drawing.Point(168, 19);
            this.btnUpdateClass.Name = "btnUpdateClass";
            this.btnUpdateClass.Size = new System.Drawing.Size(156, 159);
            this.btnUpdateClass.TabIndex = 6;
            this.btnUpdateClass.Text = "Update a Class";
            this.btnUpdateClass.UseVisualStyleBackColor = false;
            this.btnUpdateClass.Click += new System.EventHandler(this.btnUpdateClass_Click);
            // 
            // btnAddingClassEvents
            // 
            this.btnAddingClassEvents.BackColor = System.Drawing.Color.FloralWhite;
            this.btnAddingClassEvents.Location = new System.Drawing.Point(6, 19);
            this.btnAddingClassEvents.Name = "btnAddingClassEvents";
            this.btnAddingClassEvents.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddingClassEvents.Size = new System.Drawing.Size(156, 159);
            this.btnAddingClassEvents.TabIndex = 5;
            this.btnAddingClassEvents.Text = "Class Adding Events";
            this.btnAddingClassEvents.UseVisualStyleBackColor = false;
            this.btnAddingClassEvents.Click += new System.EventHandler(this.btnAddingClassEvents_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUpdateEmployee);
            this.groupBox3.Controls.Add(this.btnAddEmployee);
            this.groupBox3.Location = new System.Drawing.Point(377, 281);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 184);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Teacher Registration and Update Panels";
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.BackColor = System.Drawing.Color.Cornsilk;
            this.btnUpdateEmployee.Location = new System.Drawing.Point(117, 20);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(105, 159);
            this.btnUpdateEmployee.TabIndex = 7;
            this.btnUpdateEmployee.Text = "Update an Employee";
            this.btnUpdateEmployee.UseVisualStyleBackColor = false;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.FloralWhite;
            this.btnAddEmployee.Location = new System.Drawing.Point(6, 19);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(105, 159);
            this.btnAddEmployee.TabIndex = 6;
            this.btnAddEmployee.Text = "Add an Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.RosyBrown;
            this.btnLogout.Location = new System.Drawing.Point(797, 489);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(156, 44);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainMenuForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(970, 545);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "MainMenuForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenuForms";
            this.Load += new System.EventHandler(this.MainMenuForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdateParent;
        private System.Windows.Forms.Button btnAddParent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnUpdateClass;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnAddingClassEvents;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUpdateEmployee;
    }
}