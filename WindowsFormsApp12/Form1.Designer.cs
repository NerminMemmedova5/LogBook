namespace WindowsFormsApp12
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
            this.logbookLbl = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.usernametxtB = new System.Windows.Forms.TextBox();
            this.passwordtxtB = new System.Windows.Forms.TextBox();
            this.signinBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logbookLbl
            // 
            this.logbookLbl.BackColor = System.Drawing.SystemColors.Highlight;
            this.logbookLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.logbookLbl.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logbookLbl.Location = new System.Drawing.Point(0, 0);
            this.logbookLbl.Name = "logbookLbl";
            this.logbookLbl.Size = new System.Drawing.Size(443, 125);
            this.logbookLbl.TabIndex = 0;
            this.logbookLbl.Text = "LogBook";
            this.logbookLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logbookLbl.Click += new System.EventHandler(this.logbookLbl_Click);
            // 
            // usernameLbl
            // 
            this.usernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.Location = new System.Drawing.Point(12, 222);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(160, 45);
            this.usernameLbl.TabIndex = 1;
            this.usernameLbl.Text = "Username";
            this.usernameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLbl
            // 
            this.passwordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.Location = new System.Drawing.Point(12, 294);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(160, 45);
            this.passwordLbl.TabIndex = 1;
            this.passwordLbl.Text = "Password";
            this.passwordLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernametxtB
            // 
            this.usernametxtB.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametxtB.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.usernametxtB.Location = new System.Drawing.Point(178, 227);
            this.usernametxtB.Name = "usernametxtB";
            this.usernametxtB.Size = new System.Drawing.Size(234, 35);
            this.usernametxtB.TabIndex = 2;
            this.usernametxtB.Text = "@gmail.com";
            this.usernametxtB.MouseEnter += new System.EventHandler(this.usernametxtB_MouseEnter);
            this.usernametxtB.MouseLeave += new System.EventHandler(this.usernametxtB_MouseLeave);
            // 
            // passwordtxtB
            // 
            this.passwordtxtB.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtxtB.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.passwordtxtB.Location = new System.Drawing.Point(178, 304);
            this.passwordtxtB.Name = "passwordtxtB";
            this.passwordtxtB.PasswordChar = '*';
            this.passwordtxtB.Size = new System.Drawing.Size(234, 35);
            this.passwordtxtB.TabIndex = 2;
            // 
            // signinBtn
            // 
            this.signinBtn.BackColor = System.Drawing.Color.Lime;
            this.signinBtn.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinBtn.Location = new System.Drawing.Point(306, 440);
            this.signinBtn.Name = "signinBtn";
            this.signinBtn.Size = new System.Drawing.Size(125, 64);
            this.signinBtn.TabIndex = 3;
            this.signinBtn.Text = "SignIn";
            this.signinBtn.UseVisualStyleBackColor = false;
            this.signinBtn.Click += new System.EventHandler(this.signinBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(443, 545);
            this.Controls.Add(this.signinBtn);
            this.Controls.Add(this.passwordtxtB);
            this.Controls.Add(this.usernametxtB);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.logbookLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logbookLbl;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox usernametxtB;
        private System.Windows.Forms.TextBox passwordtxtB;
        private System.Windows.Forms.Button signinBtn;
    }
}

