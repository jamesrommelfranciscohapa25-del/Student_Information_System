namespace Student_Information_System.Forms.App
{
    partial class Dashboard
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
            roundedPanel1 = new Resources.Components.RoundedPanel();
            label11 = new System.Windows.Forms.Label();
            roundedPanel4 = new Resources.Components.RoundedPanel();
            InputContactNumber = new ReaLTaiizor.Controls.CyberTextBox();
            InputYearLevel = new ReaLTaiizor.Controls.CyberTextBox();
            InputFullName = new ReaLTaiizor.Controls.CyberTextBox();
            InputStudentID = new ReaLTaiizor.Controls.CyberTextBox();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            InputProgram = new ReaLTaiizor.Controls.CyberComboBox();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            InputGender = new ReaLTaiizor.Controls.CyberComboBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            TestButton = new ReaLTaiizor.Controls.CyberButton();
            roundedPanel3 = new Resources.Components.RoundedPanel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            roundedPanel2 = new Resources.Components.RoundedPanel();
            label8 = new System.Windows.Forms.Label();
            searchBar = new ReaLTaiizor.Controls.CyberTextBox();
            ButtonDelete = new ReaLTaiizor.Controls.CyberButton();
            ClearFieldsButton = new ReaLTaiizor.Controls.CyberButton();
            ButtonEdit = new ReaLTaiizor.Controls.CyberButton();
            ButtonAdd = new ReaLTaiizor.Controls.CyberButton();
            roundedPanel5 = new Resources.Components.RoundedPanel();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            label10 = new System.Windows.Forms.Label();
            sortYearLevel = new ReaLTaiizor.Controls.CyberComboBox();
            label9 = new System.Windows.Forms.Label();
            sortProgram = new ReaLTaiizor.Controls.CyberComboBox();
            roundedPanel6 = new Resources.Components.RoundedPanel();
            label1 = new System.Windows.Forms.Label();
            roundedPanel7 = new Resources.Components.RoundedPanel();
            roundedPanel1.SuspendLayout();
            roundedPanel4.SuspendLayout();
            roundedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            roundedPanel2.SuspendLayout();
            roundedPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            roundedPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = System.Drawing.Color.White;
            roundedPanel1.Controls.Add(label11);
            roundedPanel1.Controls.Add(roundedPanel4);
            roundedPanel1.Controls.Add(TestButton);
            roundedPanel1.Controls.Add(roundedPanel3);
            roundedPanel1.Location = new System.Drawing.Point(12, 108);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Padding = new System.Windows.Forms.Padding(12);
            roundedPanel1.Size = new System.Drawing.Size(302, 722);
            roundedPanel1.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label11.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            label11.Location = new System.Drawing.Point(98, 310);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(88, 13);
            label11.TabIndex = 45;
            label11.Text = "Maximum: 2MB.";
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = System.Drawing.Color.White;
            roundedPanel4.Controls.Add(InputContactNumber);
            roundedPanel4.Controls.Add(InputYearLevel);
            roundedPanel4.Controls.Add(InputFullName);
            roundedPanel4.Controls.Add(InputStudentID);
            roundedPanel4.Controls.Add(label7);
            roundedPanel4.Controls.Add(label6);
            roundedPanel4.Controls.Add(InputProgram);
            roundedPanel4.Controls.Add(label5);
            roundedPanel4.Controls.Add(label4);
            roundedPanel4.Controls.Add(InputGender);
            roundedPanel4.Controls.Add(label3);
            roundedPanel4.Controls.Add(label2);
            roundedPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            roundedPanel4.Location = new System.Drawing.Point(12, 326);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new System.Drawing.Size(278, 384);
            roundedPanel4.TabIndex = 31;
            // 
            // InputContactNumber
            // 
            InputContactNumber.Alpha = 20;
            InputContactNumber.BackColor = System.Drawing.Color.Transparent;
            InputContactNumber.Background_WidthPen = 1F;
            InputContactNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            InputContactNumber.BackgroundPen = true;
            InputContactNumber.ColorBackground = System.Drawing.Color.White;
            InputContactNumber.ColorBackground_Pen = System.Drawing.Color.FromArgb(29, 78, 216);
            InputContactNumber.ColorLighting = System.Drawing.Color.FromArgb(29, 200, 238);
            InputContactNumber.ColorPen_1 = System.Drawing.Color.FromArgb(29, 200, 238);
            InputContactNumber.ColorPen_2 = System.Drawing.Color.FromArgb(37, 52, 68);
            InputContactNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            InputContactNumber.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            InputContactNumber.Font = new System.Drawing.Font("Segoe UI", 8F);
            InputContactNumber.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            InputContactNumber.Lighting = false;
            InputContactNumber.LinearGradientPen = false;
            InputContactNumber.Location = new System.Drawing.Point(14, 304);
            InputContactNumber.Name = "InputContactNumber";
            InputContactNumber.PenWidth = 15;
            InputContactNumber.RGB = false;
            InputContactNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            InputContactNumber.Rounding = true;
            InputContactNumber.RoundingInt = 30;
            InputContactNumber.Size = new System.Drawing.Size(251, 34);
            InputContactNumber.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            InputContactNumber.TabIndex = 40;
            InputContactNumber.Tag = "Cyber";
            InputContactNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            InputContactNumber.TextButton = "";
            InputContactNumber.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            InputContactNumber.Timer_RGB = 300;
            // 
            // InputYearLevel
            // 
            InputYearLevel.Alpha = 20;
            InputYearLevel.BackColor = System.Drawing.Color.Transparent;
            InputYearLevel.Background_WidthPen = 1F;
            InputYearLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            InputYearLevel.BackgroundPen = true;
            InputYearLevel.ColorBackground = System.Drawing.Color.White;
            InputYearLevel.ColorBackground_Pen = System.Drawing.Color.FromArgb(29, 78, 216);
            InputYearLevel.ColorLighting = System.Drawing.Color.FromArgb(29, 200, 238);
            InputYearLevel.ColorPen_1 = System.Drawing.Color.FromArgb(29, 200, 238);
            InputYearLevel.ColorPen_2 = System.Drawing.Color.FromArgb(37, 52, 68);
            InputYearLevel.Cursor = System.Windows.Forms.Cursors.Hand;
            InputYearLevel.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            InputYearLevel.Font = new System.Drawing.Font("Segoe UI", 8F);
            InputYearLevel.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            InputYearLevel.Lighting = false;
            InputYearLevel.LinearGradientPen = false;
            InputYearLevel.Location = new System.Drawing.Point(14, 192);
            InputYearLevel.Name = "InputYearLevel";
            InputYearLevel.PenWidth = 15;
            InputYearLevel.RGB = false;
            InputYearLevel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            InputYearLevel.Rounding = true;
            InputYearLevel.RoundingInt = 30;
            InputYearLevel.Size = new System.Drawing.Size(251, 34);
            InputYearLevel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            InputYearLevel.TabIndex = 36;
            InputYearLevel.Tag = "Cyber";
            InputYearLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            InputYearLevel.TextButton = "";
            InputYearLevel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            InputYearLevel.Timer_RGB = 300;
            // 
            // InputFullName
            // 
            InputFullName.Alpha = 20;
            InputFullName.BackColor = System.Drawing.Color.Transparent;
            InputFullName.Background_WidthPen = 1F;
            InputFullName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            InputFullName.BackgroundPen = true;
            InputFullName.ColorBackground = System.Drawing.Color.White;
            InputFullName.ColorBackground_Pen = System.Drawing.Color.FromArgb(29, 78, 216);
            InputFullName.ColorLighting = System.Drawing.Color.FromArgb(29, 200, 238);
            InputFullName.ColorPen_1 = System.Drawing.Color.FromArgb(29, 200, 238);
            InputFullName.ColorPen_2 = System.Drawing.Color.FromArgb(37, 52, 68);
            InputFullName.Cursor = System.Windows.Forms.Cursors.Hand;
            InputFullName.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            InputFullName.Font = new System.Drawing.Font("Segoe UI", 8F);
            InputFullName.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            InputFullName.Lighting = false;
            InputFullName.LinearGradientPen = false;
            InputFullName.Location = new System.Drawing.Point(14, 82);
            InputFullName.Name = "InputFullName";
            InputFullName.PenWidth = 15;
            InputFullName.RGB = false;
            InputFullName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            InputFullName.Rounding = true;
            InputFullName.RoundingInt = 30;
            InputFullName.Size = new System.Drawing.Size(251, 34);
            InputFullName.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            InputFullName.TabIndex = 32;
            InputFullName.Tag = "Cyber";
            InputFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            InputFullName.TextButton = "";
            InputFullName.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            InputFullName.Timer_RGB = 300;
            // 
            // InputStudentID
            // 
            InputStudentID.Alpha = 20;
            InputStudentID.BackColor = System.Drawing.Color.Transparent;
            InputStudentID.Background_WidthPen = 1F;
            InputStudentID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            InputStudentID.BackgroundPen = true;
            InputStudentID.ColorBackground = System.Drawing.Color.White;
            InputStudentID.ColorBackground_Pen = System.Drawing.Color.FromArgb(29, 78, 216);
            InputStudentID.ColorLighting = System.Drawing.Color.FromArgb(29, 200, 238);
            InputStudentID.ColorPen_1 = System.Drawing.Color.FromArgb(29, 200, 238);
            InputStudentID.ColorPen_2 = System.Drawing.Color.FromArgb(37, 52, 68);
            InputStudentID.Cursor = System.Windows.Forms.Cursors.Hand;
            InputStudentID.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            InputStudentID.Font = new System.Drawing.Font("Segoe UI", 8F);
            InputStudentID.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            InputStudentID.Lighting = false;
            InputStudentID.LinearGradientPen = false;
            InputStudentID.Location = new System.Drawing.Point(14, 27);
            InputStudentID.Name = "InputStudentID";
            InputStudentID.PenWidth = 15;
            InputStudentID.RGB = false;
            InputStudentID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            InputStudentID.Rounding = true;
            InputStudentID.RoundingInt = 30;
            InputStudentID.Size = new System.Drawing.Size(251, 34);
            InputStudentID.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            InputStudentID.TabIndex = 30;
            InputStudentID.Tag = "Cyber";
            InputStudentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            InputStudentID.TextButton = "";
            InputStudentID.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            InputStudentID.Timer_RGB = 300;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            label7.Location = new System.Drawing.Point(14, 286);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(99, 15);
            label7.TabIndex = 39;
            label7.Text = "Contact Number:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            label6.Location = new System.Drawing.Point(14, 229);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(56, 15);
            label6.TabIndex = 38;
            label6.Text = "Program:";
            // 
            // InputProgram
            // 
            InputProgram.BackColor = System.Drawing.Color.White;
            InputProgram.Background_WidthPen = 1F;
            InputProgram.ColorArrow = System.Drawing.Color.FromArgb(29, 78, 216);
            InputProgram.ColorBackground = System.Drawing.Color.White;
            InputProgram.ColorBackground_Pen = System.Drawing.Color.FromArgb(29, 78, 216);
            InputProgram.ColorItemHover = System.Drawing.Color.FromArgb(234, 88, 12);
            InputProgram.ColorPen_1 = System.Drawing.Color.FromArgb(29, 78, 216);
            InputProgram.ColorPen_2 = System.Drawing.Color.FromArgb(37, 52, 68);
            InputProgram.CyberComboBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            InputProgram.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            InputProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            InputProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            InputProgram.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            InputProgram.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            InputProgram.FormattingEnabled = true;
            InputProgram.ItemHeight = 28;
            InputProgram.Items.AddRange(new object[] { "BS COMPUTER SCIENCE", "BS BIOLOGY", "BS METEOROLOGY", "BS CHEMISTRYBS INFORMATION TECHNOLOGY", "BS INFORMATION TECHNOLOGY" });
            InputProgram.Location = new System.Drawing.Point(14, 247);
            InputProgram.Name = "InputProgram";
            InputProgram.RGB = false;
            InputProgram.Size = new System.Drawing.Size(251, 34);
            InputProgram.TabIndex = 37;
            InputProgram.Timer_RGB = 300;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            label5.Location = new System.Drawing.Point(14, 174);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(62, 15);
            label5.TabIndex = 35;
            label5.Text = "Year Level:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            label4.Location = new System.Drawing.Point(14, 119);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(48, 15);
            label4.TabIndex = 34;
            label4.Text = "Gender:";
            // 
            // InputGender
            // 
            InputGender.BackColor = System.Drawing.Color.White;
            InputGender.Background_WidthPen = 1F;
            InputGender.ColorArrow = System.Drawing.Color.FromArgb(29, 78, 216);
            InputGender.ColorBackground = System.Drawing.Color.White;
            InputGender.ColorBackground_Pen = System.Drawing.Color.FromArgb(29, 78, 216);
            InputGender.ColorItemHover = System.Drawing.Color.FromArgb(234, 88, 12);
            InputGender.ColorPen_1 = System.Drawing.Color.FromArgb(29, 78, 216);
            InputGender.ColorPen_2 = System.Drawing.Color.FromArgb(37, 52, 68);
            InputGender.CyberComboBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            InputGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            InputGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            InputGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            InputGender.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            InputGender.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            InputGender.FormattingEnabled = true;
            InputGender.ItemHeight = 28;
            InputGender.Items.AddRange(new object[] { "Male", "Female", "Other", "Prefer not to say" });
            InputGender.Location = new System.Drawing.Point(14, 137);
            InputGender.Name = "InputGender";
            InputGender.RGB = false;
            InputGender.Size = new System.Drawing.Size(251, 34);
            InputGender.TabIndex = 33;
            InputGender.Timer_RGB = 300;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            label3.Location = new System.Drawing.Point(14, 64);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(86, 15);
            label3.TabIndex = 31;
            label3.Text = "Student Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            label2.Location = new System.Drawing.Point(14, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(65, 15);
            label2.TabIndex = 30;
            label2.Text = "Student ID:";
            // 
            // TestButton
            // 
            TestButton.Alpha = 20;
            TestButton.BackColor = System.Drawing.Color.Transparent;
            TestButton.Background = true;
            TestButton.Background_WidthPen = 0F;
            TestButton.BackgroundPen = true;
            TestButton.ColorBackground = System.Drawing.Color.FromArgb(249, 115, 22);
            TestButton.ColorBackground_1 = System.Drawing.Color.FromArgb(37, 52, 68);
            TestButton.ColorBackground_2 = System.Drawing.Color.FromArgb(41, 63, 86);
            TestButton.ColorBackground_Pen = System.Drawing.Color.FromArgb(29, 78, 216);
            TestButton.ColorLighting = System.Drawing.Color.FromArgb(29, 200, 238);
            TestButton.ColorPen_1 = System.Drawing.Color.FromArgb(37, 52, 68);
            TestButton.ColorPen_2 = System.Drawing.Color.FromArgb(41, 63, 86);
            TestButton.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            TestButton.Effect_1 = true;
            TestButton.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(29, 200, 238);
            TestButton.Effect_1_Transparency = 25;
            TestButton.Effect_2 = true;
            TestButton.Effect_2_ColorBackground = System.Drawing.Color.White;
            TestButton.Effect_2_Transparency = 20;
            TestButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            TestButton.ForeColor = System.Drawing.Color.FromArgb(245, 245, 245);
            TestButton.Lighting = false;
            TestButton.LinearGradient_Background = false;
            TestButton.LinearGradientPen = false;
            TestButton.Location = new System.Drawing.Point(83, 273);
            TestButton.Name = "TestButton";
            TestButton.PenWidth = 15;
            TestButton.Rounding = true;
            TestButton.RoundingInt = 70;
            TestButton.Size = new System.Drawing.Size(130, 34);
            TestButton.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            TestButton.TabIndex = 30;
            TestButton.Tag = "Cyber";
            TestButton.TextButton = "Change Photo";
            TestButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            TestButton.Timer_Effect_1 = 5;
            TestButton.Timer_RGB = 300;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            roundedPanel3.Controls.Add(pictureBox1);
            roundedPanel3.Location = new System.Drawing.Point(27, 17);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Padding = new System.Windows.Forms.Padding(10);
            roundedPanel3.Size = new System.Drawing.Size(250, 250);
            roundedPanel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new System.Drawing.Point(10, 10);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(230, 230);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = System.Drawing.Color.White;
            roundedPanel2.Controls.Add(label8);
            roundedPanel2.Controls.Add(searchBar);
            roundedPanel2.Controls.Add(ButtonDelete);
            roundedPanel2.Controls.Add(ClearFieldsButton);
            roundedPanel2.Controls.Add(ButtonEdit);
            roundedPanel2.Controls.Add(ButtonAdd);
            roundedPanel2.Controls.Add(roundedPanel5);
            roundedPanel2.Location = new System.Drawing.Point(320, 108);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Padding = new System.Windows.Forms.Padding(12);
            roundedPanel2.Size = new System.Drawing.Size(852, 722);
            roundedPanel2.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            label8.Location = new System.Drawing.Point(26, 38);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(124, 15);
            label8.TabIndex = 41;
            label8.Text = "Search Student Name:";
            // 
            // searchBar
            // 
            searchBar.Alpha = 20;
            searchBar.BackColor = System.Drawing.Color.Transparent;
            searchBar.Background_WidthPen = 1F;
            searchBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            searchBar.BackgroundPen = true;
            searchBar.ColorBackground = System.Drawing.Color.White;
            searchBar.ColorBackground_Pen = System.Drawing.Color.FromArgb(29, 78, 216);
            searchBar.ColorLighting = System.Drawing.Color.FromArgb(29, 200, 238);
            searchBar.ColorPen_1 = System.Drawing.Color.FromArgb(29, 200, 238);
            searchBar.ColorPen_2 = System.Drawing.Color.FromArgb(37, 52, 68);
            searchBar.Cursor = System.Windows.Forms.Cursors.Hand;
            searchBar.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            searchBar.Font = new System.Drawing.Font("Segoe UI", 8F);
            searchBar.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            searchBar.Lighting = false;
            searchBar.LinearGradientPen = false;
            searchBar.Location = new System.Drawing.Point(26, 56);
            searchBar.Name = "searchBar";
            searchBar.PenWidth = 15;
            searchBar.RGB = false;
            searchBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            searchBar.Rounding = true;
            searchBar.RoundingInt = 30;
            searchBar.Size = new System.Drawing.Size(220, 34);
            searchBar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            searchBar.TabIndex = 41;
            searchBar.Tag = "Cyber";
            searchBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            searchBar.TextButton = "";
            searchBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            searchBar.Timer_RGB = 300;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Alpha = 20;
            ButtonDelete.BackColor = System.Drawing.Color.Transparent;
            ButtonDelete.Background = true;
            ButtonDelete.Background_WidthPen = 0F;
            ButtonDelete.BackgroundPen = true;
            ButtonDelete.ColorBackground = System.Drawing.Color.FromArgb(249, 115, 22);
            ButtonDelete.ColorBackground_1 = System.Drawing.Color.FromArgb(37, 52, 68);
            ButtonDelete.ColorBackground_2 = System.Drawing.Color.FromArgb(41, 63, 86);
            ButtonDelete.ColorBackground_Pen = System.Drawing.Color.FromArgb(29, 78, 216);
            ButtonDelete.ColorLighting = System.Drawing.Color.FromArgb(29, 200, 238);
            ButtonDelete.ColorPen_1 = System.Drawing.Color.FromArgb(37, 52, 68);
            ButtonDelete.ColorPen_2 = System.Drawing.Color.FromArgb(41, 63, 86);
            ButtonDelete.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            ButtonDelete.Effect_1 = true;
            ButtonDelete.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(29, 200, 238);
            ButtonDelete.Effect_1_Transparency = 25;
            ButtonDelete.Effect_2 = true;
            ButtonDelete.Effect_2_ColorBackground = System.Drawing.Color.White;
            ButtonDelete.Effect_2_Transparency = 20;
            ButtonDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            ButtonDelete.ForeColor = System.Drawing.Color.FromArgb(245, 245, 245);
            ButtonDelete.Lighting = false;
            ButtonDelete.LinearGradient_Background = false;
            ButtonDelete.LinearGradientPen = false;
            ButtonDelete.Location = new System.Drawing.Point(701, 56);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.PenWidth = 15;
            ButtonDelete.Rounding = true;
            ButtonDelete.RoundingInt = 70;
            ButtonDelete.Size = new System.Drawing.Size(125, 34);
            ButtonDelete.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            ButtonDelete.TabIndex = 44;
            ButtonDelete.Tag = "Cyber";
            ButtonDelete.TextButton = "Delete";
            ButtonDelete.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            ButtonDelete.Timer_Effect_1 = 5;
            ButtonDelete.Timer_RGB = 300;
            // 
            // ClearFieldsButton
            // 
            ClearFieldsButton.Alpha = 20;
            ClearFieldsButton.BackColor = System.Drawing.Color.Transparent;
            ClearFieldsButton.Background = true;
            ClearFieldsButton.Background_WidthPen = 2F;
            ClearFieldsButton.BackgroundPen = true;
            ClearFieldsButton.ColorBackground = System.Drawing.Color.White;
            ClearFieldsButton.ColorBackground_1 = System.Drawing.Color.FromArgb(37, 52, 68);
            ClearFieldsButton.ColorBackground_2 = System.Drawing.Color.FromArgb(41, 63, 86);
            ClearFieldsButton.ColorBackground_Pen = System.Drawing.Color.FromArgb(29, 78, 216);
            ClearFieldsButton.ColorLighting = System.Drawing.Color.FromArgb(29, 200, 238);
            ClearFieldsButton.ColorPen_1 = System.Drawing.Color.FromArgb(37, 52, 68);
            ClearFieldsButton.ColorPen_2 = System.Drawing.Color.FromArgb(41, 63, 86);
            ClearFieldsButton.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            ClearFieldsButton.Effect_1 = true;
            ClearFieldsButton.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(29, 200, 238);
            ClearFieldsButton.Effect_1_Transparency = 25;
            ClearFieldsButton.Effect_2 = true;
            ClearFieldsButton.Effect_2_ColorBackground = System.Drawing.Color.White;
            ClearFieldsButton.Effect_2_Transparency = 20;
            ClearFieldsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            ClearFieldsButton.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            ClearFieldsButton.Lighting = false;
            ClearFieldsButton.LinearGradient_Background = false;
            ClearFieldsButton.LinearGradientPen = false;
            ClearFieldsButton.Location = new System.Drawing.Point(565, 56);
            ClearFieldsButton.Name = "ClearFieldsButton";
            ClearFieldsButton.PenWidth = 15;
            ClearFieldsButton.Rounding = true;
            ClearFieldsButton.RoundingInt = 70;
            ClearFieldsButton.Size = new System.Drawing.Size(130, 34);
            ClearFieldsButton.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            ClearFieldsButton.TabIndex = 43;
            ClearFieldsButton.Tag = "Cyber";
            ClearFieldsButton.TextButton = "Clear";
            ClearFieldsButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            ClearFieldsButton.Timer_Effect_1 = 5;
            ClearFieldsButton.Timer_RGB = 300;
            // 
            // ButtonEdit
            // 
            ButtonEdit.Alpha = 20;
            ButtonEdit.BackColor = System.Drawing.Color.Transparent;
            ButtonEdit.Background = true;
            ButtonEdit.Background_WidthPen = 2F;
            ButtonEdit.BackgroundPen = true;
            ButtonEdit.ColorBackground = System.Drawing.Color.White;
            ButtonEdit.ColorBackground_1 = System.Drawing.Color.FromArgb(37, 52, 68);
            ButtonEdit.ColorBackground_2 = System.Drawing.Color.FromArgb(41, 63, 86);
            ButtonEdit.ColorBackground_Pen = System.Drawing.Color.FromArgb(29, 78, 216);
            ButtonEdit.ColorLighting = System.Drawing.Color.FromArgb(29, 200, 238);
            ButtonEdit.ColorPen_1 = System.Drawing.Color.FromArgb(37, 52, 68);
            ButtonEdit.ColorPen_2 = System.Drawing.Color.FromArgb(41, 63, 86);
            ButtonEdit.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            ButtonEdit.Effect_1 = true;
            ButtonEdit.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(29, 200, 238);
            ButtonEdit.Effect_1_Transparency = 25;
            ButtonEdit.Effect_2 = true;
            ButtonEdit.Effect_2_ColorBackground = System.Drawing.Color.White;
            ButtonEdit.Effect_2_Transparency = 20;
            ButtonEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            ButtonEdit.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            ButtonEdit.Lighting = false;
            ButtonEdit.LinearGradient_Background = false;
            ButtonEdit.LinearGradientPen = false;
            ButtonEdit.Location = new System.Drawing.Point(429, 56);
            ButtonEdit.Name = "ButtonEdit";
            ButtonEdit.PenWidth = 15;
            ButtonEdit.Rounding = true;
            ButtonEdit.RoundingInt = 70;
            ButtonEdit.Size = new System.Drawing.Size(130, 34);
            ButtonEdit.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            ButtonEdit.TabIndex = 42;
            ButtonEdit.Tag = "Cyber";
            ButtonEdit.TextButton = "Update";
            ButtonEdit.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            ButtonEdit.Timer_Effect_1 = 5;
            ButtonEdit.Timer_RGB = 300;
            // 
            // ButtonAdd
            // 
            ButtonAdd.Alpha = 20;
            ButtonAdd.BackColor = System.Drawing.Color.Transparent;
            ButtonAdd.Background = true;
            ButtonAdd.Background_WidthPen = 0F;
            ButtonAdd.BackgroundPen = true;
            ButtonAdd.ColorBackground = System.Drawing.Color.FromArgb(29, 78, 216);
            ButtonAdd.ColorBackground_1 = System.Drawing.Color.FromArgb(37, 52, 68);
            ButtonAdd.ColorBackground_2 = System.Drawing.Color.FromArgb(41, 63, 86);
            ButtonAdd.ColorBackground_Pen = System.Drawing.Color.FromArgb(29, 78, 216);
            ButtonAdd.ColorLighting = System.Drawing.Color.FromArgb(29, 200, 238);
            ButtonAdd.ColorPen_1 = System.Drawing.Color.FromArgb(37, 52, 68);
            ButtonAdd.ColorPen_2 = System.Drawing.Color.FromArgb(41, 63, 86);
            ButtonAdd.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            ButtonAdd.Effect_1 = true;
            ButtonAdd.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(29, 200, 238);
            ButtonAdd.Effect_1_Transparency = 25;
            ButtonAdd.Effect_2 = true;
            ButtonAdd.Effect_2_ColorBackground = System.Drawing.Color.White;
            ButtonAdd.Effect_2_Transparency = 20;
            ButtonAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            ButtonAdd.ForeColor = System.Drawing.Color.FromArgb(245, 245, 245);
            ButtonAdd.Lighting = false;
            ButtonAdd.LinearGradient_Background = false;
            ButtonAdd.LinearGradientPen = false;
            ButtonAdd.Location = new System.Drawing.Point(298, 56);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.PenWidth = 15;
            ButtonAdd.Rounding = true;
            ButtonAdd.RoundingInt = 70;
            ButtonAdd.Size = new System.Drawing.Size(125, 34);
            ButtonAdd.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            ButtonAdd.TabIndex = 32;
            ButtonAdd.Tag = "Cyber";
            ButtonAdd.TextButton = "Add Student";
            ButtonAdd.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            ButtonAdd.Timer_Effect_1 = 5;
            ButtonAdd.Timer_RGB = 300;
            // 
            // roundedPanel5
            // 
            roundedPanel5.BackColor = System.Drawing.Color.White;
            roundedPanel5.Controls.Add(dataGridView1);
            roundedPanel5.Controls.Add(label10);
            roundedPanel5.Controls.Add(sortYearLevel);
            roundedPanel5.Controls.Add(label9);
            roundedPanel5.Controls.Add(sortProgram);
            roundedPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            roundedPanel5.Location = new System.Drawing.Point(12, 107);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Size = new System.Drawing.Size(828, 603);
            roundedPanel5.TabIndex = 41;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowDrop = true;
            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(226, 232, 240);
            dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridView1.Location = new System.Drawing.Point(17, 68);
            dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new System.Drawing.Size(800, 523);
            dataGridView1.TabIndex = 42;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            label10.Location = new System.Drawing.Point(266, 10);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(62, 15);
            label10.TabIndex = 41;
            label10.Text = "Year Level:";
            // 
            // sortYearLevel
            // 
            sortYearLevel.BackColor = System.Drawing.Color.White;
            sortYearLevel.Background_WidthPen = 1F;
            sortYearLevel.ColorArrow = System.Drawing.Color.FromArgb(29, 78, 216);
            sortYearLevel.ColorBackground = System.Drawing.Color.White;
            sortYearLevel.ColorBackground_Pen = System.Drawing.Color.FromArgb(29, 78, 216);
            sortYearLevel.ColorItemHover = System.Drawing.Color.FromArgb(234, 88, 12);
            sortYearLevel.ColorPen_1 = System.Drawing.Color.FromArgb(29, 78, 216);
            sortYearLevel.ColorPen_2 = System.Drawing.Color.FromArgb(37, 52, 68);
            sortYearLevel.CyberComboBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            sortYearLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            sortYearLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            sortYearLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            sortYearLevel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            sortYearLevel.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            sortYearLevel.FormattingEnabled = true;
            sortYearLevel.ItemHeight = 28;
            sortYearLevel.Items.AddRange(new object[] { "All Years", "1", "2", "3", "4", "5" });
            sortYearLevel.Location = new System.Drawing.Point(266, 28);
            sortYearLevel.Name = "sortYearLevel";
            sortYearLevel.RGB = false;
            sortYearLevel.Size = new System.Drawing.Size(220, 34);
            sortYearLevel.TabIndex = 41;
            sortYearLevel.Timer_RGB = 300;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            label9.Location = new System.Drawing.Point(17, 10);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(56, 15);
            label9.TabIndex = 41;
            label9.Text = "Program:";
            // 
            // sortProgram
            // 
            sortProgram.BackColor = System.Drawing.Color.White;
            sortProgram.Background_WidthPen = 1F;
            sortProgram.ColorArrow = System.Drawing.Color.FromArgb(29, 78, 216);
            sortProgram.ColorBackground = System.Drawing.Color.White;
            sortProgram.ColorBackground_Pen = System.Drawing.Color.FromArgb(29, 78, 216);
            sortProgram.ColorItemHover = System.Drawing.Color.FromArgb(234, 88, 12);
            sortProgram.ColorPen_1 = System.Drawing.Color.FromArgb(29, 78, 216);
            sortProgram.ColorPen_2 = System.Drawing.Color.FromArgb(37, 52, 68);
            sortProgram.CyberComboBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            sortProgram.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            sortProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            sortProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            sortProgram.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            sortProgram.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            sortProgram.FormattingEnabled = true;
            sortProgram.ItemHeight = 28;
            sortProgram.Items.AddRange(new object[] { "All Program", "BS COMPUTER SCIENCE", "BS BIOLOGY", "BS METEOROLOGY", "BS CHEMISTRY", "BS INFORMATION TECHNOLOGY" });
            sortProgram.Location = new System.Drawing.Point(17, 28);
            sortProgram.Name = "sortProgram";
            sortProgram.RGB = false;
            sortProgram.Size = new System.Drawing.Size(220, 34);
            sortProgram.TabIndex = 41;
            sortProgram.Timer_RGB = 300;
            // 
            // roundedPanel6
            // 
            roundedPanel6.BackColor = System.Drawing.Color.FromArgb(15, 42, 74);
            roundedPanel6.Controls.Add(label1);
            roundedPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            roundedPanel6.Location = new System.Drawing.Point(0, 0);
            roundedPanel6.Name = "roundedPanel6";
            roundedPanel6.Size = new System.Drawing.Size(1184, 100);
            roundedPanel6.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            label1.Location = new System.Drawing.Point(12, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(312, 32);
            label1.TabIndex = 45;
            label1.Text = "Student Infromation System";
            // 
            // roundedPanel7
            // 
            roundedPanel7.BackColor = System.Drawing.Color.FromArgb(15, 42, 74);
            roundedPanel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            roundedPanel7.Location = new System.Drawing.Point(0, 836);
            roundedPanel7.Name = "roundedPanel7";
            roundedPanel7.Size = new System.Drawing.Size(1184, 25);
            roundedPanel7.TabIndex = 46;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(244, 247, 251);
            ClientSize = new System.Drawing.Size(1184, 861);
            Controls.Add(roundedPanel7);
            Controls.Add(roundedPanel6);
            Controls.Add(roundedPanel2);
            Controls.Add(roundedPanel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "Dashboard";
            Text = "Dashboard";
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            roundedPanel4.ResumeLayout(false);
            roundedPanel4.PerformLayout();
            roundedPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            roundedPanel5.ResumeLayout(false);
            roundedPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            roundedPanel6.ResumeLayout(false);
            roundedPanel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Resources.Components.RoundedPanel roundedPanel1;
        private Resources.Components.RoundedPanel roundedPanel2;
        private Resources.Components.RoundedPanel roundedPanel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.CyberButton TestButton;
        private ReaLTaiizor.Controls.CyberTextBox InputStudentID;
        private System.Windows.Forms.Label label2;
        private Resources.Components.RoundedPanel roundedPanel4;
        private System.Windows.Forms.Label label3;
        private ReaLTaiizor.Controls.CyberTextBox InputFullName;
        private ReaLTaiizor.Controls.CyberComboBox InputGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private ReaLTaiizor.Controls.CyberTextBox InputYearLevel;
        private System.Windows.Forms.Label label6;
        private ReaLTaiizor.Controls.CyberComboBox InputProgram;
        private System.Windows.Forms.Label label7;
        private ReaLTaiizor.Controls.CyberTextBox InputContactNumber;
        private Resources.Components.RoundedPanel roundedPanel5;
        private ReaLTaiizor.Controls.CyberButton ButtonAdd;
        private ReaLTaiizor.Controls.CyberButton ButtonEdit;
        private ReaLTaiizor.Controls.CyberButton ClearFieldsButton;
        private ReaLTaiizor.Controls.CyberButton ButtonDelete;
        private System.Windows.Forms.Label label8;
        private ReaLTaiizor.Controls.CyberTextBox searchBar;
        private System.Windows.Forms.Label label10;
        private ReaLTaiizor.Controls.CyberComboBox sortYearLevel;
        private System.Windows.Forms.Label label9;
        private ReaLTaiizor.Controls.CyberComboBox sortProgram;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Resources.Components.RoundedPanel roundedPanel6;
        private Resources.Components.RoundedPanel roundedPanel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
    }
}