using ReaLTaiizor;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;

namespace Student_Information_System.Forms.Auth
{
    partial class Login
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
            poisonPanel3 = new PoisonPanel();
            poisonPanel4 = new PoisonPanel();
            BtnLogin = new CyberButton();
            poisonPanel7 = new PoisonPanel();
            passwordInput = new DreamTextBox();
            poisonPanel6 = new PoisonPanel();
            usernameIput = new DreamTextBox();
            poisonPanel5 = new PoisonPanel();
            bigLabel1 = new BigLabel();
            poisonPanel4.SuspendLayout();
            poisonPanel7.SuspendLayout();
            poisonPanel6.SuspendLayout();
            poisonPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // poisonPanel3
            // 
            poisonPanel3.BackColor = System.Drawing.SystemColors.Info;
            poisonPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            poisonPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            poisonPanel3.HorizontalScrollbarBarColor = true;
            poisonPanel3.HorizontalScrollbarHighlightOnWheel = false;
            poisonPanel3.HorizontalScrollbarSize = 10;
            poisonPanel3.Location = new System.Drawing.Point(0, 0);
            poisonPanel3.Name = "poisonPanel3";
            poisonPanel3.Size = new System.Drawing.Size(552, 771);
            poisonPanel3.TabIndex = 2;
            poisonPanel3.VerticalScrollbarBarColor = true;
            poisonPanel3.VerticalScrollbarHighlightOnWheel = false;
            poisonPanel3.VerticalScrollbarSize = 10;
            // 
            // poisonPanel4
            // 
            poisonPanel4.Controls.Add(BtnLogin);
            poisonPanel4.Controls.Add(poisonPanel7);
            poisonPanel4.Controls.Add(poisonPanel6);
            poisonPanel4.Controls.Add(poisonPanel5);
            poisonPanel4.Dock = System.Windows.Forms.DockStyle.Right;
            poisonPanel4.HorizontalScrollbarBarColor = true;
            poisonPanel4.HorizontalScrollbarHighlightOnWheel = false;
            poisonPanel4.HorizontalScrollbarSize = 10;
            poisonPanel4.Location = new System.Drawing.Point(550, 0);
            poisonPanel4.Name = "poisonPanel4";
            poisonPanel4.Size = new System.Drawing.Size(514, 771);
            poisonPanel4.TabIndex = 3;
            poisonPanel4.VerticalScrollbarBarColor = true;
            poisonPanel4.VerticalScrollbarHighlightOnWheel = false;
            poisonPanel4.VerticalScrollbarSize = 10;
            // 
            // BtnLogin
            // 
            BtnLogin.Alpha = 20;
            BtnLogin.BackColor = System.Drawing.Color.Transparent;
            BtnLogin.Background = true;
            BtnLogin.Background_WidthPen = 0F;
            BtnLogin.BackgroundPen = true;
            BtnLogin.ColorBackground = System.Drawing.Color.DimGray;
            BtnLogin.ColorBackground_1 = System.Drawing.Color.White;
            BtnLogin.ColorBackground_2 = System.Drawing.Color.White;
            BtnLogin.ColorBackground_Pen = System.Drawing.Color.White;
            BtnLogin.ColorLighting = System.Drawing.Color.White;
            BtnLogin.ColorPen_1 = System.Drawing.Color.White;
            BtnLogin.ColorPen_2 = System.Drawing.Color.White;
            BtnLogin.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            BtnLogin.Effect_1 = true;
            BtnLogin.Effect_1_ColorBackground = System.Drawing.Color.White;
            BtnLogin.Effect_1_Transparency = 25;
            BtnLogin.Effect_2 = true;
            BtnLogin.Effect_2_ColorBackground = System.Drawing.Color.White;
            BtnLogin.Effect_2_Transparency = 20;
            BtnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            BtnLogin.ForeColor = System.Drawing.Color.White;
            BtnLogin.Lighting = false;
            BtnLogin.LinearGradient_Background = false;
            BtnLogin.LinearGradientPen = false;
            BtnLogin.Location = new System.Drawing.Point(294, 468);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.PenWidth = 15;
            BtnLogin.Rounding = true;
            BtnLogin.RoundingInt = 70;
            BtnLogin.Size = new System.Drawing.Size(130, 38);
            BtnLogin.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BtnLogin.TabIndex = 6;
            BtnLogin.Tag = "Button";
            BtnLogin.TextButton = "Login";
            BtnLogin.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BtnLogin.Timer_Effect_1 = 5;
            BtnLogin.Timer_RGB = 300;
            // 
            // poisonPanel7
            // 
            poisonPanel7.Controls.Add(passwordInput);
            poisonPanel7.Dock = System.Windows.Forms.DockStyle.Top;
            poisonPanel7.HorizontalScrollbarBarColor = true;
            poisonPanel7.HorizontalScrollbarHighlightOnWheel = false;
            poisonPanel7.HorizontalScrollbarSize = 10;
            poisonPanel7.Location = new System.Drawing.Point(0, 376);
            poisonPanel7.Name = "poisonPanel7";
            poisonPanel7.Size = new System.Drawing.Size(514, 76);
            poisonPanel7.TabIndex = 5;
            poisonPanel7.VerticalScrollbarBarColor = true;
            poisonPanel7.VerticalScrollbarHighlightOnWheel = false;
            poisonPanel7.VerticalScrollbarSize = 10;
            // 
            // passwordInput
            // 
            passwordInput.BackColor = System.Drawing.Color.White;
            passwordInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            passwordInput.ColorA = System.Drawing.Color.FromArgb(31, 31, 31);
            passwordInput.ColorB = System.Drawing.Color.FromArgb(41, 41, 41);
            passwordInput.ColorC = System.Drawing.Color.FromArgb(51, 51, 51);
            passwordInput.ColorD = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            passwordInput.ColorE = System.Drawing.Color.FromArgb(25, 255, 255, 255);
            passwordInput.ColorF = System.Drawing.Color.Black;
            passwordInput.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            passwordInput.ForeColor = System.Drawing.Color.Black;
            passwordInput.Location = new System.Drawing.Point(71, 18);
            passwordInput.Name = "passwordInput";
            passwordInput.PlaceholderText = "  Enter Password";
            passwordInput.Size = new System.Drawing.Size(353, 29);
            passwordInput.TabIndex = 3;
            // 
            // poisonPanel6
            // 
            poisonPanel6.Controls.Add(usernameIput);
            poisonPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            poisonPanel6.HorizontalScrollbarBarColor = true;
            poisonPanel6.HorizontalScrollbarHighlightOnWheel = false;
            poisonPanel6.HorizontalScrollbarSize = 10;
            poisonPanel6.Location = new System.Drawing.Point(0, 305);
            poisonPanel6.Name = "poisonPanel6";
            poisonPanel6.Size = new System.Drawing.Size(514, 71);
            poisonPanel6.TabIndex = 4;
            poisonPanel6.VerticalScrollbarBarColor = true;
            poisonPanel6.VerticalScrollbarHighlightOnWheel = false;
            poisonPanel6.VerticalScrollbarSize = 10;
            // 
            // usernameIput
            // 
            usernameIput.BackColor = System.Drawing.Color.White;
            usernameIput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            usernameIput.ColorA = System.Drawing.Color.FromArgb(31, 31, 31);
            usernameIput.ColorB = System.Drawing.Color.FromArgb(41, 41, 41);
            usernameIput.ColorC = System.Drawing.Color.FromArgb(51, 51, 51);
            usernameIput.ColorD = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            usernameIput.ColorE = System.Drawing.Color.FromArgb(25, 255, 255, 255);
            usernameIput.ColorF = System.Drawing.Color.Black;
            usernameIput.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            usernameIput.ForeColor = System.Drawing.Color.Black;
            usernameIput.Location = new System.Drawing.Point(71, 18);
            usernameIput.Name = "usernameIput";
            usernameIput.PlaceholderText = "  Enter Username";
            usernameIput.Size = new System.Drawing.Size(353, 29);
            usernameIput.TabIndex = 2;
            // 
            // poisonPanel5
            // 
            poisonPanel5.Controls.Add(bigLabel1);
            poisonPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            poisonPanel5.HorizontalScrollbarBarColor = true;
            poisonPanel5.HorizontalScrollbarHighlightOnWheel = false;
            poisonPanel5.HorizontalScrollbarSize = 10;
            poisonPanel5.Location = new System.Drawing.Point(0, 0);
            poisonPanel5.Name = "poisonPanel5";
            poisonPanel5.Size = new System.Drawing.Size(514, 305);
            poisonPanel5.TabIndex = 3;
            poisonPanel5.VerticalScrollbarBarColor = true;
            poisonPanel5.VerticalScrollbarHighlightOnWheel = false;
            poisonPanel5.VerticalScrollbarSize = 10;
            // 
            // bigLabel1
            // 
            bigLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = System.Drawing.Color.Transparent;
            bigLabel1.Font = new System.Drawing.Font("Segoe UI Black", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = System.Drawing.Color.Black;
            bigLabel1.Location = new System.Drawing.Point(183, 245);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new System.Drawing.Size(126, 45);
            bigLabel1.TabIndex = 2;
            bigLabel1.Text = "LOGIN";
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1064, 771);
            Controls.Add(poisonPanel4);
            Controls.Add(poisonPanel3);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "Login";
            Text = "Login";
            poisonPanel4.ResumeLayout(false);
            poisonPanel7.ResumeLayout(false);
            poisonPanel7.PerformLayout();
            poisonPanel6.ResumeLayout(false);
            poisonPanel6.PerformLayout();
            poisonPanel5.ResumeLayout(false);
            poisonPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.PoisonPanel poisonPanel3;
        private ReaLTaiizor.Controls.PoisonPanel poisonPanel4;
        private BigLabel bigLabel1;
        private PoisonPanel poisonPanel7;
        private PoisonPanel poisonPanel5;
        private DreamTextBox usernameIput;
        private DreamTextBox passwordInput;
        private PoisonPanel poisonPanel6;
        private CyberButton BtnLogin;
    }
}