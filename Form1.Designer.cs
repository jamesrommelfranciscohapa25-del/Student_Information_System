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
            this.InputContactNumber = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.InputGender = new System.Windows.Forms.ComboBox();
            this.InputYearLevel = new System.Windows.Forms.TextBox();
            this.InputProgram = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.DropDownB = new System.Windows.Forms.ComboBox();
            this.DropDownA = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClearFieldsButton = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // InputStudentID
            // 
            this.InputStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputStudentID.Location = new System.Drawing.Point(23, 352);
            this.InputStudentID.Name = "InputStudentID";
            this.InputStudentID.Size = new System.Drawing.Size(259, 26);
            this.InputStudentID.TabIndex = 0;
            this.InputStudentID.TextChanged += new System.EventHandler(this.InputStudentID_TextChanged);
            // 
            // InputFullName
            // 
            this.InputFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputFullName.Location = new System.Drawing.Point(23, 301);
            this.InputFullName.Name = "InputFullName";
            this.InputFullName.Size = new System.Drawing.Size(257, 26);
            this.InputFullName.TabIndex = 2;
            this.InputFullName.TextChanged += new System.EventHandler(this.InputFullName_TextChanged);
            // 
            // InputContactNumber
            // 
            this.InputContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputContactNumber.Location = new System.Drawing.Point(23, 573);
            this.InputContactNumber.Name = "InputContactNumber";
            this.InputContactNumber.Size = new System.Drawing.Size(259, 26);
            this.InputContactNumber.TabIndex = 10;
            this.InputContactNumber.TextChanged += new System.EventHandler(this.InputContactNumber_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.ImageLocation = "";
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
            this.panel2.Controls.Add(this.InputGender);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.InputStudentID);
            this.panel2.Controls.Add(this.InputFullName);
            this.panel2.Controls.Add(this.InputYearLevel);
            this.panel2.Controls.Add(this.InputProgram);
            this.panel2.Controls.Add(this.InputContactNumber);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 841);
            this.panel2.TabIndex = 21;
            // 
            // InputGender
            // 
            this.InputGender.Cursor = System.Windows.Forms.Cursors.Default;
            this.InputGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputGender.FormattingEnabled = true;
            this.InputGender.Items.AddRange(new object[] {
            "Cisgender",
            "Transgender",
            "Non-binary",
            "Agender",
            "Genderfluid",
            "Bigender/Trigender"});
            this.InputGender.Location = new System.Drawing.Point(23, 405);
            this.InputGender.Name = "InputGender";
            this.InputGender.Size = new System.Drawing.Size(257, 28);
            this.InputGender.TabIndex = 26;
            // 
            // InputYearLevel
            // 
            this.InputYearLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputYearLevel.Location = new System.Drawing.Point(23, 457);
            this.InputYearLevel.Name = "InputYearLevel";
            this.InputYearLevel.Size = new System.Drawing.Size(257, 26);
            this.InputYearLevel.TabIndex = 6;
            this.InputYearLevel.Text = "Year Level";
            this.InputYearLevel.TextChanged += new System.EventHandler(this.InputYearLevel_TextChanged);
            // 
            // InputProgram
            // 
            this.InputProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputProgram.Location = new System.Drawing.Point(23, 513);
            this.InputProgram.Name = "InputProgram";
            this.InputProgram.Size = new System.Drawing.Size(259, 26);
            this.InputProgram.TabIndex = 8;
            this.InputProgram.Text = "Program";
            this.InputProgram.TextChanged += new System.EventHandler(this.InputProgram_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(300, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1124, 841);
            this.panel3.TabIndex = 22;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Controls.Add(this.ClearFieldsButton);
            this.panel5.Controls.Add(this.ButtonAdd);
            this.panel5.Controls.Add(this.ButtonDelete);
            this.panel5.Controls.Add(this.ButtonEdit);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 80);
            this.panel5.Margin = new System.Windows.Forms.Padding(10);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(20);
            this.panel5.Size = new System.Drawing.Size(1122, 759);
            this.panel5.TabIndex = 24;
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
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(42, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 30);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "Search Name or Student ID";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.DropDownB);
            this.panel6.Controls.Add(this.DropDownA);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 80);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1122, 80);
            this.panel6.TabIndex = 26;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 768);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1122, 71);
            this.panel7.TabIndex = 27;
            // 
            // DropDownB
            // 
            this.DropDownB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DropDownB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropDownB.FormattingEnabled = true;
            this.DropDownB.Items.AddRange(new object[] {
            "Blocks "});
            this.DropDownB.Location = new System.Drawing.Point(320, 24);
            this.DropDownB.Name = "DropDownB";
            this.DropDownB.Size = new System.Drawing.Size(183, 28);
            this.DropDownB.TabIndex = 27;
            // 
            // DropDownA
            // 
            this.DropDownA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DropDownA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropDownA.FormattingEnabled = true;
            this.DropDownA.Items.AddRange(new object[] {
            "Program",
            "Year Level"});
            this.DropDownA.Location = new System.Drawing.Point(79, 24);
            this.DropDownA.Name = "DropDownA";
            this.DropDownA.Size = new System.Drawing.Size(183, 28);
            this.DropDownA.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(78, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(964, 528);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ClearFieldsButton
            // 
            this.ClearFieldsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearFieldsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearFieldsButton.Location = new System.Drawing.Point(291, 98);
            this.ClearFieldsButton.Name = "ClearFieldsButton";
            this.ClearFieldsButton.Size = new System.Drawing.Size(166, 33);
            this.ClearFieldsButton.TabIndex = 29;
            this.ClearFieldsButton.Text = "Clear";
            this.ClearFieldsButton.UseVisualStyleBackColor = true;
            this.ClearFieldsButton.Click += new System.EventHandler(this.ClearFieldsButton_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAdd.FlatAppearance.BorderSize = 0;
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdd.ForeColor = System.Drawing.SystemColors.Window;
            this.ButtonAdd.Location = new System.Drawing.Point(119, 98);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(166, 33);
            this.ButtonAdd.TabIndex = 30;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDelete.Location = new System.Drawing.Point(635, 98);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(166, 33);
            this.ButtonDelete.TabIndex = 31;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEdit.Location = new System.Drawing.Point(463, 98);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(166, 33);
            this.ButtonEdit.TabIndex = 32;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox InputStudentID;
        private System.Windows.Forms.TextBox InputFullName;
        private System.Windows.Forms.TextBox InputContactNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox InputGender;
        private System.Windows.Forms.TextBox InputYearLevel;
        private System.Windows.Forms.TextBox InputProgram;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox DropDownB;
        private System.Windows.Forms.ComboBox DropDownA;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ClearFieldsButton;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonEdit;
    }
}