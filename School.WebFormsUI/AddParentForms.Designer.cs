namespace School.WebFormsUI
{
    partial class AddParentForms
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
            this.tbxMFirstName = new System.Windows.Forms.TextBox();
            this.tbxMLastName = new System.Windows.Forms.TextBox();
            this.mtbxMPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddMother = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddFather = new System.Windows.Forms.Button();
            this.tbxFLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxFFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtbxFPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvMotherList = new System.Windows.Forms.DataGridView();
            this.dgvFatherList = new System.Windows.Forms.DataGridView();
            this.cmbxMother = new System.Windows.Forms.ComboBox();
            this.cmbxFather = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddRelation = new System.Windows.Forms.Button();
            this.dgvRelations = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotherList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFatherList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelations)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxMFirstName
            // 
            this.tbxMFirstName.BackColor = System.Drawing.SystemColors.Info;
            this.tbxMFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxMFirstName.Location = new System.Drawing.Point(96, 52);
            this.tbxMFirstName.Name = "tbxMFirstName";
            this.tbxMFirstName.Size = new System.Drawing.Size(126, 13);
            this.tbxMFirstName.TabIndex = 0;
            // 
            // tbxMLastName
            // 
            this.tbxMLastName.BackColor = System.Drawing.SystemColors.Info;
            this.tbxMLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxMLastName.Location = new System.Drawing.Point(96, 89);
            this.tbxMLastName.Name = "tbxMLastName";
            this.tbxMLastName.Size = new System.Drawing.Size(126, 13);
            this.tbxMLastName.TabIndex = 1;
            // 
            // mtbxMPhoneNumber
            // 
            this.mtbxMPhoneNumber.BackColor = System.Drawing.SystemColors.Info;
            this.mtbxMPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbxMPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.mtbxMPhoneNumber.Location = new System.Drawing.Point(96, 124);
            this.mtbxMPhoneNumber.Mask = "(999) 000-0000";
            this.mtbxMPhoneNumber.Name = "mtbxMPhoneNumber";
            this.mtbxMPhoneNumber.Size = new System.Drawing.Size(126, 20);
            this.mtbxMPhoneNumber.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone Number";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddMother);
            this.groupBox1.Controls.Add(this.tbxMLastName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxMFirstName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mtbxMPhoneNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 211);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mother\'s Info";
            // 
            // btnAddMother
            // 
            this.btnAddMother.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAddMother.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddMother.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMother.Location = new System.Drawing.Point(96, 160);
            this.btnAddMother.Name = "btnAddMother";
            this.btnAddMother.Size = new System.Drawing.Size(126, 35);
            this.btnAddMother.TabIndex = 6;
            this.btnAddMother.Text = "Add";
            this.btnAddMother.UseVisualStyleBackColor = false;
            this.btnAddMother.Click += new System.EventHandler(this.btnAddMother_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddFather);
            this.groupBox2.Controls.Add(this.tbxFLastName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbxFFirstName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.mtbxFPhoneNumber);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(262, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 211);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Father\'s Info";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnAddFather
            // 
            this.btnAddFather.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAddFather.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddFather.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFather.Location = new System.Drawing.Point(96, 160);
            this.btnAddFather.Name = "btnAddFather";
            this.btnAddFather.Size = new System.Drawing.Size(126, 35);
            this.btnAddFather.TabIndex = 6;
            this.btnAddFather.Text = "Add";
            this.btnAddFather.UseVisualStyleBackColor = false;
            this.btnAddFather.Click += new System.EventHandler(this.btnAddFather_Click);
            // 
            // tbxFLastName
            // 
            this.tbxFLastName.BackColor = System.Drawing.SystemColors.Info;
            this.tbxFLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxFLastName.Location = new System.Drawing.Point(96, 89);
            this.tbxFLastName.Name = "tbxFLastName";
            this.tbxFLastName.Size = new System.Drawing.Size(126, 13);
            this.tbxFLastName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone Number";
            // 
            // tbxFFirstName
            // 
            this.tbxFFirstName.BackColor = System.Drawing.SystemColors.Info;
            this.tbxFFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxFFirstName.Location = new System.Drawing.Point(96, 52);
            this.tbxFFirstName.Name = "tbxFFirstName";
            this.tbxFFirstName.Size = new System.Drawing.Size(126, 13);
            this.tbxFFirstName.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Last Name";
            // 
            // mtbxFPhoneNumber
            // 
            this.mtbxFPhoneNumber.BackColor = System.Drawing.SystemColors.Info;
            this.mtbxFPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbxFPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.mtbxFPhoneNumber.Location = new System.Drawing.Point(96, 124);
            this.mtbxFPhoneNumber.Mask = "(999) 000-0000";
            this.mtbxFPhoneNumber.Name = "mtbxFPhoneNumber";
            this.mtbxFPhoneNumber.Size = new System.Drawing.Size(126, 20);
            this.mtbxFPhoneNumber.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "First Name";
            // 
            // dgvMotherList
            // 
            this.dgvMotherList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMotherList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvMotherList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMotherList.Location = new System.Drawing.Point(6, 254);
            this.dgvMotherList.Name = "dgvMotherList";
            this.dgvMotherList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvMotherList.Size = new System.Drawing.Size(330, 243);
            this.dgvMotherList.TabIndex = 8;
            // 
            // dgvFatherList
            // 
            this.dgvFatherList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFatherList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvFatherList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFatherList.Location = new System.Drawing.Point(342, 254);
            this.dgvFatherList.Name = "dgvFatherList";
            this.dgvFatherList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvFatherList.Size = new System.Drawing.Size(330, 243);
            this.dgvFatherList.TabIndex = 9;
            // 
            // cmbxMother
            // 
            this.cmbxMother.FormattingEnabled = true;
            this.cmbxMother.Location = new System.Drawing.Point(537, 75);
            this.cmbxMother.Name = "cmbxMother";
            this.cmbxMother.Size = new System.Drawing.Size(121, 21);
            this.cmbxMother.TabIndex = 10;
            // 
            // cmbxFather
            // 
            this.cmbxFather.FormattingEnabled = true;
            this.cmbxFather.Location = new System.Drawing.Point(537, 135);
            this.cmbxFather.Name = "cmbxFather";
            this.cmbxFather.Size = new System.Drawing.Size(121, 21);
            this.cmbxFather.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(537, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mother\'s Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(537, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Father\'s Name";
            // 
            // btnAddRelation
            // 
            this.btnAddRelation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddRelation.Location = new System.Drawing.Point(537, 172);
            this.btnAddRelation.Name = "btnAddRelation";
            this.btnAddRelation.Size = new System.Drawing.Size(121, 35);
            this.btnAddRelation.TabIndex = 14;
            this.btnAddRelation.Text = "Add Relation";
            this.btnAddRelation.UseVisualStyleBackColor = true;
            this.btnAddRelation.Click += new System.EventHandler(this.btnAddRelation_Click);
            // 
            // dgvRelations
            // 
            this.dgvRelations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelations.Location = new System.Drawing.Point(139, 503);
            this.dgvRelations.Name = "dgvRelations";
            this.dgvRelations.Size = new System.Drawing.Size(367, 116);
            this.dgvRelations.TabIndex = 15;
            // 
            // AddParentForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 631);
            this.Controls.Add(this.dgvRelations);
            this.Controls.Add(this.btnAddRelation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbxFather);
            this.Controls.Add(this.cmbxMother);
            this.Controls.Add(this.dgvFatherList);
            this.Controls.Add(this.dgvMotherList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddParentForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddParentForms";
            this.Load += new System.EventHandler(this.AddParentForms_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotherList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFatherList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxMFirstName;
        private System.Windows.Forms.TextBox tbxMLastName;
        private System.Windows.Forms.MaskedTextBox mtbxMPhoneNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddMother;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddFather;
        private System.Windows.Forms.TextBox tbxFLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxFFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtbxFPhoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvMotherList;
        private System.Windows.Forms.DataGridView dgvFatherList;
        private System.Windows.Forms.ComboBox cmbxMother;
        private System.Windows.Forms.ComboBox cmbxFather;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddRelation;
        private System.Windows.Forms.DataGridView dgvRelations;
    }
}