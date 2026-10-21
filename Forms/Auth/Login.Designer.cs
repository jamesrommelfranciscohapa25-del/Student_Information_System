namespace Student_Information_System.Forms
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
            poisonPanel1 = new ReaLTaiizor.Controls.PoisonPanel();
            poisonPanel2 = new ReaLTaiizor.Controls.PoisonPanel();
            poisonPanel3 = new ReaLTaiizor.Controls.PoisonPanel();
            poisonPanel4 = new ReaLTaiizor.Controls.PoisonPanel();
            SuspendLayout();
            // 
            // poisonPanel1
            // 
            poisonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            poisonPanel1.HorizontalScrollbarBarColor = true;
            poisonPanel1.HorizontalScrollbarHighlightOnWheel = false;
            poisonPanel1.HorizontalScrollbarSize = 10;
            poisonPanel1.Location = new System.Drawing.Point(0, 0);
            poisonPanel1.Name = "poisonPanel1";
            poisonPanel1.Size = new System.Drawing.Size(1080, 100);
            poisonPanel1.TabIndex = 0;
            poisonPanel1.VerticalScrollbarBarColor = true;
            poisonPanel1.VerticalScrollbarHighlightOnWheel = false;
            poisonPanel1.VerticalScrollbarSize = 10;
            // 
            // poisonPanel2
            // 
            poisonPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            poisonPanel2.HorizontalScrollbarBarColor = true;
            poisonPanel2.HorizontalScrollbarHighlightOnWheel = false;
            poisonPanel2.HorizontalScrollbarSize = 10;
            poisonPanel2.Location = new System.Drawing.Point(0, 710);
            poisonPanel2.Name = "poisonPanel2";
            poisonPanel2.Size = new System.Drawing.Size(1080, 100);
            poisonPanel2.TabIndex = 1;
            poisonPanel2.VerticalScrollbarBarColor = true;
            poisonPanel2.VerticalScrollbarHighlightOnWheel = false;
            poisonPanel2.VerticalScrollbarSize = 10;
            // 
            // poisonPanel3
            // 
            poisonPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            poisonPanel3.HorizontalScrollbarBarColor = true;
            poisonPanel3.HorizontalScrollbarHighlightOnWheel = false;
            poisonPanel3.HorizontalScrollbarSize = 10;
            poisonPanel3.Location = new System.Drawing.Point(0, 100);
            poisonPanel3.Name = "poisonPanel3";
            poisonPanel3.Size = new System.Drawing.Size(200, 610);
            poisonPanel3.TabIndex = 2;
            poisonPanel3.VerticalScrollbarBarColor = true;
            poisonPanel3.VerticalScrollbarHighlightOnWheel = false;
            poisonPanel3.VerticalScrollbarSize = 10;
            // 
            // poisonPanel4
            // 
            poisonPanel4.Dock = System.Windows.Forms.DockStyle.Right;
            poisonPanel4.HorizontalScrollbarBarColor = true;
            poisonPanel4.HorizontalScrollbarHighlightOnWheel = false;
            poisonPanel4.HorizontalScrollbarSize = 10;
            poisonPanel4.Location = new System.Drawing.Point(880, 100);
            poisonPanel4.Name = "poisonPanel4";
            poisonPanel4.Size = new System.Drawing.Size(200, 610);
            poisonPanel4.TabIndex = 3;
            poisonPanel4.VerticalScrollbarBarColor = true;
            poisonPanel4.VerticalScrollbarHighlightOnWheel = false;
            poisonPanel4.VerticalScrollbarSize = 10;
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1080, 810);
            Controls.Add(poisonPanel4);
            Controls.Add(poisonPanel3);
            Controls.Add(poisonPanel2);
            Controls.Add(poisonPanel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.PoisonPanel poisonPanel1;
        private ReaLTaiizor.Controls.PoisonPanel poisonPanel2;
        private ReaLTaiizor.Controls.PoisonPanel poisonPanel3;
        private ReaLTaiizor.Controls.PoisonPanel poisonPanel4;
    }
}