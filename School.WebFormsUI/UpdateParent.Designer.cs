namespace School.WebFormsUI
{
    partial class UpdateParent
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
            this.dgvRelations = new System.Windows.Forms.DataGridView();
            this.btnAddRelation = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbxFather = new System.Windows.Forms.ComboBox();
            this.cmbxMother = new System.Windows.Forms.ComboBox();
            this.dgvFatherList = new System.Windows.Forms.DataGridView();
            this.dgvMotherList = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxFLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxFFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtbxFPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateMother = new System.Windows.Forms.Button();
            this.tbxMLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxMFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbxMPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteMother = new System.Windows.Forms.Button();
            this.btnDeleteFather = new System.Windows.Forms.Button();
            this.btnUpdateFather = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFatherList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotherList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRelations
            // 
            this.dgvRelations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelations.Location = new System.Drawing.Point(200, 543);
            this.dgvRelations.Name = "dgvRelations";
            this.dgvRelations.Size = new System.Drawing.Size(367, 116);
            this.dgvRelations.TabIndex = 25;
            // 
            // btnAddRelation
            // 
            this.btnAddRelation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddRelation.Location = new System.Drawing.Point(598, 212);
            this.btnAddRelation.Name = "btnAddRelation";
            this.btnAddRelation.Size = new System.Drawing.Size(121, 35);
            this.btnAddRelation.TabIndex = 24;
            this.btnAddRelation.Text = "Add Relation";
            this.btnAddRelation.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(598, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Father\'s Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(598, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Mother\'s Name";
            // 
            // cmbxFather
            // 
            this.cmbxFather.FormattingEnabled = true;
            this.cmbxFather.Location = new System.Drawing.Point(598, 175);
            this.cmbxFather.Name = "cmbxFather";
            this.cmbxFather.Size = new System.Drawing.Size(121, 21);
            this.cmbxFather.TabIndex = 21;
            // 
            // cmbxMother
            // 
            this.cmbxMother.FormattingEnabled = true;
            this.cmbxMother.Location = new System.Drawing.Point(598, 115);
            this.cmbxMother.Name = "cmbxMother";
            this.cmbxMother.Size = new System.Drawing.Size(121, 21);
            this.cmbxMother.TabIndex = 20;
            // 
            // dgvFatherList
            // 
            this.dgvFatherList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFatherList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvFatherList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFatherList.Location = new System.Drawing.Point(403, 294);
            this.dgvFatherList.Name = "dgvFatherList";
            this.dgvFatherList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvFatherList.Size = new System.Drawing.Size(330, 243);
            this.dgvFatherList.TabIndex = 19;
            this.dgvFatherList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFatherList_CellClick);
            // 
            // dgvMotherList
            // 
            this.dgvMotherList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMotherList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvMotherList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMotherList.Location = new System.Drawing.Point(67, 294);
            this.dgvMotherList.Name = "dgvMotherList";
            this.dgvMotherList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvMotherList.Size = new System.Drawing.Size(330, 243);
            this.dgvMotherList.TabIndex = 18;
            this.dgvMotherList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMotherList_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteFather);
            this.groupBox2.Controls.Add(this.btnUpdateFather);
            this.groupBox2.Controls.Add(this.tbxFLastName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbxFFirstName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.mtbxFPhoneNumber);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(323, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 211);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Father\'s Info";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteMother);
            this.groupBox1.Controls.Add(this.btnUpdateMother);
            this.groupBox1.Controls.Add(this.tbxMLastName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxMFirstName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mtbxMPhoneNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(73, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 211);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mother\'s Info";
            // 
            // btnUpdateMother
            // 
            this.btnUpdateMother.BackColor = System.Drawing.Color.RosyBrown;
            this.btnUpdateMother.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdateMother.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateMother.Location = new System.Drawing.Point(15, 160);
            this.btnUpdateMother.Name = "btnUpdateMother";
            this.btnUpdateMother.Size = new System.Drawing.Size(102, 35);
            this.btnUpdateMother.TabIndex = 6;
            this.btnUpdateMother.Text = "Update";
            this.btnUpdateMother.UseVisualStyleBackColor = false;
            this.btnUpdateMother.Click += new System.EventHandler(this.btnUpdateMother_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone Number";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
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
            // btnDeleteMother
            // 
            this.btnDeleteMother.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDeleteMother.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteMother.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteMother.Location = new System.Drawing.Point(134, 160);
            this.btnDeleteMother.Name = "btnDeleteMother";
            this.btnDeleteMother.Size = new System.Drawing.Size(104, 35);
            this.btnDeleteMother.TabIndex = 7;
            this.btnDeleteMother.Text = "Delete";
            this.btnDeleteMother.UseVisualStyleBackColor = false;
            // 
            // btnDeleteFather
            // 
            this.btnDeleteFather.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDeleteFather.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteFather.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteFather.Location = new System.Drawing.Point(125, 160);
            this.btnDeleteFather.Name = "btnDeleteFather";
            this.btnDeleteFather.Size = new System.Drawing.Size(104, 35);
            this.btnDeleteFather.TabIndex = 9;
            this.btnDeleteFather.Text = "Delete";
            this.btnDeleteFather.UseVisualStyleBackColor = false;
            // 
            // btnUpdateFather
            // 
            this.btnUpdateFather.BackColor = System.Drawing.Color.RosyBrown;
            this.btnUpdateFather.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdateFather.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateFather.Location = new System.Drawing.Point(6, 160);
            this.btnUpdateFather.Name = "btnUpdateFather";
            this.btnUpdateFather.Size = new System.Drawing.Size(102, 35);
            this.btnUpdateFather.TabIndex = 8;
            this.btnUpdateFather.Text = "Update";
            this.btnUpdateFather.UseVisualStyleBackColor = false;
            this.btnUpdateFather.Click += new System.EventHandler(this.btnUpdateFather_Click);
            // 
            // UpdateParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 710);
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
            this.MaximizeBox = false;
            this.Name = "UpdateParent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateParent";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFatherList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotherList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRelations;
        private System.Windows.Forms.Button btnAddRelation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbxFather;
        private System.Windows.Forms.ComboBox cmbxMother;
        private System.Windows.Forms.DataGridView dgvFatherList;
        private System.Windows.Forms.DataGridView dgvMotherList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteFather;
        private System.Windows.Forms.Button btnUpdateFather;
        private System.Windows.Forms.TextBox tbxFLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxFFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtbxFPhoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteMother;
        private System.Windows.Forms.Button btnUpdateMother;
        private System.Windows.Forms.TextBox tbxMLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxMFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbxMPhoneNumber;
        private System.Windows.Forms.Label label1;
    }
}