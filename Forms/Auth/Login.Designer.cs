using ReaLTaiizor;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;

namespace Student_Information_System.Forms.Auth
{
    partial class Login : System.Windows.Forms.Form
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
            BtnLogin = new CyberButton();
            label3 = new System.Windows.Forms.Label();
            passwordInput = new CyberTextBox();
            label2 = new System.Windows.Forms.Label();
            usernameIput = new CyberTextBox();
            label1 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            roundedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = System.Drawing.Color.White;
            roundedPanel1.Controls.Add(BtnLogin);
            roundedPanel1.Controls.Add(label3);
            roundedPanel1.Controls.Add(passwordInput);
            roundedPanel1.Controls.Add(label2);
            roundedPanel1.Controls.Add(usernameIput);
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Controls.Add(label12);
            roundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            roundedPanel1.Location = new System.Drawing.Point(350, 120);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new System.Drawing.Size(484, 621);
            roundedPanel1.TabIndex = 7;
            // 
            // BtnLogin
            // 
            BtnLogin.Alpha = 20;
            BtnLogin.BackColor = System.Drawing.Color.Transparent;
            BtnLogin.Background = true;
            BtnLogin.Background_WidthPen = 0F;
            BtnLogin.BackgroundPen = true;
            BtnLogin.ColorBackground = System.Drawing.Color.FromArgb(249, 115, 22);
            BtnLogin.ColorBackground_1 = System.Drawing.Color.FromArgb(37, 52, 68);
            BtnLogin.ColorBackground_2 = System.Drawing.Color.FromArgb(41, 63, 86);
            BtnLogin.ColorBackground_Pen = System.Drawing.Color.FromArgb(29, 78, 216);
            BtnLogin.ColorLighting = System.Drawing.Color.FromArgb(29, 200, 238);
            BtnLogin.ColorPen_1 = System.Drawing.Color.FromArgb(37, 52, 68);
            BtnLogin.ColorPen_2 = System.Drawing.Color.FromArgb(41, 63, 86);
            BtnLogin.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            BtnLogin.Effect_1 = true;
            BtnLogin.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(29, 200, 238);
            BtnLogin.Effect_1_Transparency = 25;
            BtnLogin.Effect_2 = true;
            BtnLogin.Effect_2_ColorBackground = System.Drawing.Color.White;
            BtnLogin.Effect_2_Transparency = 20;
            BtnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            BtnLogin.ForeColor = System.Drawing.Color.FromArgb(245, 245, 245);
            BtnLogin.Lighting = false;
            BtnLogin.LinearGradient_Background = false;
            BtnLogin.LinearGradientPen = false;
            BtnLogin.Location = new System.Drawing.Point(58, 411);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.PenWidth = 15;
            BtnLogin.Rounding = true;
            BtnLogin.RoundingInt = 70;
            BtnLogin.Size = new System.Drawing.Size(353, 34);
            BtnLogin.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BtnLogin.TabIndex = 52;
            BtnLogin.Tag = "Fill";
            BtnLogin.TextButton = "Login";
            BtnLogin.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BtnLogin.Timer_Effect_1 = 5;
            BtnLogin.Timer_RGB = 300;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            label3.Location = new System.Drawing.Point(58, 293);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(90, 15);
            label3.TabIndex = 51;
            label3.Text = "Enter Password:";
            // 
            // passwordInput
            // 
            passwordInput.Alpha = 20;
            passwordInput.BackColor = System.Drawing.Color.Transparent;
            passwordInput.Background_WidthPen = 1F;
            passwordInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            passwordInput.BackgroundPen = true;
            passwordInput.ColorBackground = System.Drawing.Color.White;
            passwordInput.ColorBackground_Pen = System.Drawing.Color.FromArgb(29, 78, 216);
            passwordInput.ColorLighting = System.Drawing.Color.FromArgb(29, 200, 238);
            passwordInput.ColorPen_1 = System.Drawing.Color.FromArgb(29, 200, 238);
            passwordInput.ColorPen_2 = System.Drawing.Color.FromArgb(37, 52, 68);
            passwordInput.Cursor = System.Windows.Forms.Cursors.Hand;
            passwordInput.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            passwordInput.Font = new System.Drawing.Font("Segoe UI", 8F);
            passwordInput.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            passwordInput.Lighting = false;
            passwordInput.LinearGradientPen = false;
            passwordInput.Location = new System.Drawing.Point(58, 311);
            passwordInput.Name = "passwordInput";
            passwordInput.PenWidth = 15;
            passwordInput.RGB = false;
            passwordInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            passwordInput.Rounding = true;
            passwordInput.RoundingInt = 30;
            passwordInput.Size = new System.Drawing.Size(353, 34);
            passwordInput.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            passwordInput.TabIndex = 50;
            passwordInput.Tag = "Cyber";
            passwordInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            passwordInput.TextButton = "";
            passwordInput.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            passwordInput.Timer_RGB = 300;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            label2.Location = new System.Drawing.Point(58, 223);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(93, 15);
            label2.TabIndex = 49;
            label2.Text = "Enter Username:";
            // 
            // usernameIput
            // 
            usernameIput.Alpha = 20;
            usernameIput.BackColor = System.Drawing.Color.Transparent;
            usernameIput.Background_WidthPen = 1F;
            usernameIput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            usernameIput.BackgroundPen = true;
            usernameIput.ColorBackground = System.Drawing.Color.White;
            usernameIput.ColorBackground_Pen = System.Drawing.Color.FromArgb(29, 78, 216);
            usernameIput.ColorLighting = System.Drawing.Color.FromArgb(29, 200, 238);
            usernameIput.ColorPen_1 = System.Drawing.Color.FromArgb(29, 200, 238);
            usernameIput.ColorPen_2 = System.Drawing.Color.FromArgb(37, 52, 68);
            usernameIput.Cursor = System.Windows.Forms.Cursors.Hand;
            usernameIput.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            usernameIput.Font = new System.Drawing.Font("Segoe UI", 8F);
            usernameIput.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            usernameIput.Lighting = false;
            usernameIput.LinearGradientPen = false;
            usernameIput.Location = new System.Drawing.Point(58, 241);
            usernameIput.Name = "usernameIput";
            usernameIput.PenWidth = 15;
            usernameIput.RGB = false;
            usernameIput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            usernameIput.Rounding = true;
            usernameIput.RoundingInt = 30;
            usernameIput.Size = new System.Drawing.Size(353, 34);
            usernameIput.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            usernameIput.TabIndex = 31;
            usernameIput.Tag = "Cyber";
            usernameIput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            usernameIput.TextButton = "";
            usernameIput.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            usernameIput.Timer_RGB = 300;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(15, 42, 74);
            label1.Location = new System.Drawing.Point(58, 160);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(204, 21);
            label1.TabIndex = 48;
            label1.Text = "Student Information System";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label12.ForeColor = System.Drawing.Color.FromArgb(15, 42, 74);
            label12.Location = new System.Drawing.Point(58, 128);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(192, 32);
            label12.TabIndex = 47;
            label12.Text = "Bicol University";
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(244, 247, 251);
            ClientSize = new System.Drawing.Size(1184, 861);
            Controls.Add(roundedPanel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "Login";
            Padding = new System.Windows.Forms.Padding(350, 120, 350, 120);
            RightToLeftLayout = true;
            Text = "Login";
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Resources.Components.RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private CyberTextBox passwordInput;
        private System.Windows.Forms.Label label2;
        private CyberTextBox usernameIput;
        private CyberButton BtnLogin;
    }
}