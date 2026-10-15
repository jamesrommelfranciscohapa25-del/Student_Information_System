namespace Student_Information_System
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
            this.InputStudentID = new System.Windows.Forms.TextBox();
            this.InputFullName = new System.Windows.Forms.TextBox();
            this.InputGender = new System.Windows.Forms.TextBox();
            this.InputYearLevel = new System.Windows.Forms.TextBox();
            this.InputProgram = new System.Windows.Forms.TextBox();
            this.InputContactNumber = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DropDownB = new System.Windows.Forms.ComboBox();
            this.DropDownA = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClearFieldsButton = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputStudentID
            // 
            this.InputStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputStudentID.Location = new System.Drawing.Point(23, 339);
            this.InputStudentID.Name = "InputStudentID";
            this.InputStudentID.Size = new System.Drawing.Size(259, 23);
            this.InputStudentID.TabIndex = 0;
            this.InputStudentID.Tag = "";
            this.InputStudentID.Text = "Student ID:";
            this.InputStudentID.TextChanged += new System.EventHandler(this.InputStudentID_TextChanged);
            // 
            // InputFullName
            // 
            this.InputFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputFullName.Location = new System.Drawing.Point(23, 281);
            this.InputFullName.Name = "InputFullName";
            this.InputFullName.Size = new System.Drawing.Size(257, 23);
            this.InputFullName.TabIndex = 2;
            this.InputFullName.Text = "Student Name:";
            this.InputFullName.TextChanged += new System.EventHandler(this.InputFullName_TextChanged);
            // 
            // InputGender
            // 
            this.InputGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputGender.Location = new System.Drawing.Point(23, 412);
            this.InputGender.Name = "InputGender";
            this.InputGender.Size = new System.Drawing.Size(259, 23);
            this.InputGender.TabIndex = 4;
            this.InputGender.Text = "Gender";
            this.InputGender.TextChanged += new System.EventHandler(this.InputGender_TextChanged);
            // 
            // InputYearLevel
            // 
            this.InputYearLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputYearLevel.Location = new System.Drawing.Point(23, 486);
            this.InputYearLevel.Name = "InputYearLevel";
            this.InputYearLevel.Size = new System.Drawing.Size(259, 23);
            this.InputYearLevel.TabIndex = 6;
            this.InputYearLevel.Text = "Year Level";
            this.InputYearLevel.TextChanged += new System.EventHandler(this.InputYearLevel_TextChanged);
            // 
            // InputProgram
            // 
            this.InputProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputProgram.Location = new System.Drawing.Point(23, 554);
            this.InputProgram.Name = "InputProgram";
            this.InputProgram.Size = new System.Drawing.Size(259, 23);
            this.InputProgram.TabIndex = 8;
            this.InputProgram.Text = "Program";
            this.InputProgram.TextChanged += new System.EventHandler(this.InputProgram_TextChanged);
            // 
            // InputContactNumber
            // 
            this.InputContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputContactNumber.Location = new System.Drawing.Point(23, 624);
            this.InputContactNumber.Name = "InputContactNumber";
            this.InputContactNumber.Size = new System.Drawing.Size(259, 23);
            this.InputContactNumber.TabIndex = 10;
            this.InputContactNumber.Text = "Contact Number";
            this.InputContactNumber.TextChanged += new System.EventHandler(this.InputContactNumber_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Student_Information_System.Properties.Resources.Screenshot_2026_10_05_221822;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 250);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.HeaderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeaderPanel.Controls.Add(this.label1);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1424, 100);
            this.HeaderPanel.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Information System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 941);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1424, 100);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.InputStudentID);
            this.panel2.Controls.Add(this.InputFullName);
            this.panel2.Controls.Add(this.InputGender);
            this.panel2.Controls.Add(this.InputYearLevel);
            this.panel2.Controls.Add(this.InputProgram);
            this.panel2.Controls.Add(this.InputContactNumber);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 841);
            this.panel2.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.DropDownB);
            this.panel3.Controls.Add(this.DropDownA);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(300, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1124, 841);
            this.panel3.TabIndex = 22;
            // 
            // DropDownB
            // 
            this.DropDownB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DropDownB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropDownB.FormattingEnabled = true;
            this.DropDownB.Items.AddRange(new object[] {
            "Blocks "});
            this.DropDownB.Location = new System.Drawing.Point(321, 98);
            this.DropDownB.Name = "DropDownB";
            this.DropDownB.Size = new System.Drawing.Size(183, 28);
            this.DropDownB.TabIndex = 25;
            // 
            // DropDownA
            // 
            this.DropDownA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DropDownA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropDownA.FormattingEnabled = true;
            this.DropDownA.Items.AddRange(new object[] {
            "Program",
            "Year Level"});
            this.DropDownA.Location = new System.Drawing.Point(80, 98);
            this.DropDownA.Name = "DropDownA";
            this.DropDownA.Size = new System.Drawing.Size(183, 28);
            this.DropDownA.TabIndex = 24;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Controls.Add(this.ClearFieldsButton);
            this.panel5.Controls.Add(this.ButtonAdd);
            this.panel5.Controls.Add(this.ButtonDelete);
            this.panel5.Controls.Add(this.ButtonEdit);
            this.panel5.Location = new System.Drawing.Point(80, 140);
            this.panel5.Margin = new System.Windows.Forms.Padding(10);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(20);
            this.panel5.Size = new System.Drawing.Size(964, 643);
            this.panel5.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(964, 528);
            this.dataGridView1.TabIndex = 23;
            // 
            // ClearFieldsButton
            // 
            this.ClearFieldsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearFieldsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearFieldsButton.Location = new System.Drawing.Point(211, 39);
            this.ClearFieldsButton.Name = "ClearFieldsButton";
            this.ClearFieldsButton.Size = new System.Drawing.Size(166, 33);
            this.ClearFieldsButton.TabIndex = 24;
            this.ClearFieldsButton.Text = "Clear";
            this.ClearFieldsButton.UseVisualStyleBackColor = true;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAdd.FlatAppearance.BorderSize = 0;
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdd.ForeColor = System.Drawing.SystemColors.Window;
            this.ButtonAdd.Location = new System.Drawing.Point(39, 39);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(166, 33);
            this.ButtonAdd.TabIndex = 25;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDelete.Location = new System.Drawing.Point(555, 38);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(166, 33);
            this.ButtonDelete.TabIndex = 26;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEdit.Location = new System.Drawing.Point(383, 39);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(166, 33);
            this.ButtonEdit.TabIndex = 27;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1122, 80);
            this.panel4.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(42, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 30);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "Search Name or Student ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 1041);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HeaderPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox InputStudentID;
        private System.Windows.Forms.TextBox InputFullName;
        private System.Windows.Forms.TextBox InputGender;
        private System.Windows.Forms.TextBox InputYearLevel;
        private System.Windows.Forms.TextBox InputProgram;
        private System.Windows.Forms.TextBox InputContactNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox DropDownA;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ClearFieldsButton;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.ComboBox DropDownB;
        private System.Windows.Forms.TextBox textBox1;
    }
}

