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
            picLogo = new System.Windows.Forms.PictureBox();
            BtnLogin = new CyberButton();
            label3 = new System.Windows.Forms.Label();
            passwordInput = new CyberTextBox();
            label2 = new System.Windows.Forms.Label();
            usernameInput = new CyberTextBox();
            Subtitle = new System.Windows.Forms.Label();
            Title = new System.Windows.Forms.Label();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = System.Drawing.Color.White;
            roundedPanel1.Controls.Add(picLogo);
            roundedPanel1.Controls.Add(BtnLogin);
            roundedPanel1.Controls.Add(label3);
            roundedPanel1.Controls.Add(passwordInput);
            roundedPanel1.Controls.Add(label2);
            roundedPanel1.Controls.Add(usernameInput);
            roundedPanel1.Controls.Add(Subtitle);
            roundedPanel1.Controls.Add(Title);
            roundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            roundedPanel1.Location = new System.Drawing.Point(350, 120);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new System.Drawing.Size(484, 621);
            roundedPanel1.TabIndex = 7;
            // 
            // picLogo
            // 
            picLogo.BackColor = System.Drawing.Color.Transparent;
            picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            picLogo.Image = Properties.Resources._10_150x150;
            picLogo.Location = new System.Drawing.Point(182, 20);
            picLogo.Name = "picLogo";
            picLogo.Size = new System.Drawing.Size(128, 128);
            picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 53;
            picLogo.TabStop = false;
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
            // usernameInput
            // 
            usernameInput.Alpha = 20;
            usernameInput.BackColor = System.Drawing.Color.Transparent;
            usernameInput.Background_WidthPen = 1F;
            usernameInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            usernameInput.BackgroundPen = true;
            usernameInput.ColorBackground = System.Drawing.Color.White;
            usernameInput.ColorBackground_Pen = System.Drawing.Color.FromArgb(29, 78, 216);
            usernameInput.ColorLighting = System.Drawing.Color.FromArgb(29, 200, 238);
            usernameInput.ColorPen_1 = System.Drawing.Color.FromArgb(29, 200, 238);
            usernameInput.ColorPen_2 = System.Drawing.Color.FromArgb(37, 52, 68);
            usernameInput.Cursor = System.Windows.Forms.Cursors.Hand;
            usernameInput.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            usernameInput.Font = new System.Drawing.Font("Segoe UI", 8F);
            usernameInput.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            usernameInput.Lighting = false;
            usernameInput.LinearGradientPen = false;
            usernameInput.Location = new System.Drawing.Point(58, 241);
            usernameInput.Name = "usernameInput";
            usernameInput.PenWidth = 15;
            usernameInput.RGB = false;
            usernameInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            usernameInput.Rounding = true;
            usernameInput.RoundingInt = 30;
            usernameInput.Size = new System.Drawing.Size(353, 34);
            usernameInput.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            usernameInput.TabIndex = 31;
            usernameInput.Tag = "Cyber";
            usernameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            usernameInput.TextButton = "";
            usernameInput.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            usernameInput.Timer_RGB = 300;
            // 
            // Subtitle
            // 
            Subtitle.AutoSize = true;
            Subtitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Subtitle.ForeColor = System.Drawing.Color.FromArgb(15, 42, 74);
            Subtitle.Location = new System.Drawing.Point(147, 183);
            Subtitle.Name = "Subtitle";
            Subtitle.Size = new System.Drawing.Size(204, 21);
            Subtitle.TabIndex = 48;
            Subtitle.Text = "Student Information System";
            Subtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Title.ForeColor = System.Drawing.Color.FromArgb(15, 42, 74);
            Title.Location = new System.Drawing.Point(136, 151);
            Title.Name = "Title";
            Title.Size = new System.Drawing.Size(225, 32);
            Title.TabIndex = 47;
            Title.Text = "College Of Science";
            Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Resources.Components.RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Subtitle;
        private System.Windows.Forms.Label label3;
        private CyberTextBox passwordInput;
        private System.Windows.Forms.Label label2;
        private CyberTextBox usernameInput;
        private CyberButton BtnLogin;
        private System.Windows.Forms.PictureBox picLogo;
    }
}