namespace WindowsFormsApp12
{
    partial class Form2
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
            this.groupLbl = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.teacherGradioBtn = new Guna.UI2.WinForms.Guna2RadioButton();
            this.elaveteacherGradioBtn = new Guna.UI2.WinForms.Guna2RadioButton();
            this.movzuLbl = new System.Windows.Forms.Label();
            this.dersinmovzusutxtB = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupLbl
            // 
            this.groupLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupLbl.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupLbl.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupLbl.Location = new System.Drawing.Point(0, 0);
            this.groupLbl.Name = "groupLbl";
            this.groupLbl.Size = new System.Drawing.Size(986, 23);
            this.groupLbl.TabIndex = 0;
            this.groupLbl.Text = "FSDM_3912_az (Windows Forms and WPF)";
            // 
            // teacherGradioBtn
            // 
            this.teacherGradioBtn.AutoSize = true;
            this.teacherGradioBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.teacherGradioBtn.CheckedState.BorderThickness = 0;
            this.teacherGradioBtn.CheckedState.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.teacherGradioBtn.CheckedState.InnerColor = System.Drawing.Color.Blue;
            this.teacherGradioBtn.CheckedState.InnerOffset = -8;
            this.teacherGradioBtn.Font = new System.Drawing.Font("Arial", 14.25F);
            this.teacherGradioBtn.Location = new System.Drawing.Point(5, 26);
            this.teacherGradioBtn.Name = "teacherGradioBtn";
            this.teacherGradioBtn.Size = new System.Drawing.Size(141, 26);
            this.teacherGradioBtn.TabIndex = 1;
            this.teacherGradioBtn.Text = "Esas muellim";
            this.teacherGradioBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.teacherGradioBtn.UncheckedState.BorderThickness = 2;
            this.teacherGradioBtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.teacherGradioBtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // elaveteacherGradioBtn
            // 
            this.elaveteacherGradioBtn.AutoSize = true;
            this.elaveteacherGradioBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.elaveteacherGradioBtn.CheckedState.BorderThickness = 0;
            this.elaveteacherGradioBtn.CheckedState.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.elaveteacherGradioBtn.CheckedState.InnerColor = System.Drawing.Color.Blue;
            this.elaveteacherGradioBtn.CheckedState.InnerOffset = -8;
            this.elaveteacherGradioBtn.Font = new System.Drawing.Font("Arial", 14.25F);
            this.elaveteacherGradioBtn.Location = new System.Drawing.Point(167, 26);
            this.elaveteacherGradioBtn.Name = "elaveteacherGradioBtn";
            this.elaveteacherGradioBtn.Size = new System.Drawing.Size(193, 26);
            this.elaveteacherGradioBtn.TabIndex = 1;
            this.elaveteacherGradioBtn.Text = "Muellim evez olunur";
            this.elaveteacherGradioBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.elaveteacherGradioBtn.UncheckedState.BorderThickness = 2;
            this.elaveteacherGradioBtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.elaveteacherGradioBtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // movzuLbl
            // 
            this.movzuLbl.AutoSize = true;
            this.movzuLbl.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movzuLbl.Location = new System.Drawing.Point(498, 29);
            this.movzuLbl.Name = "movzuLbl";
            this.movzuLbl.Size = new System.Drawing.Size(133, 23);
            this.movzuLbl.TabIndex = 2;
            this.movzuLbl.Text = "Dersin movzusu";
            // 
            // dersinmovzusutxtB
            // 
            this.dersinmovzusutxtB.Enabled = false;
            this.dersinmovzusutxtB.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dersinmovzusutxtB.Location = new System.Drawing.Point(502, 55);
            this.dersinmovzusutxtB.Name = "dersinmovzusutxtB";
            this.dersinmovzusutxtB.Size = new System.Drawing.Size(268, 32);
            this.dersinmovzusutxtB.TabIndex = 3;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(776, 55);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 32);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(627, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 24);
            this.button1.TabIndex = 5;
            this.button1.Text = "*";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 523);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.dersinmovzusutxtB);
            this.Controls.Add(this.movzuLbl);
            this.Controls.Add(this.elaveteacherGradioBtn);
            this.Controls.Add(this.teacherGradioBtn);
            this.Controls.Add(this.groupLbl);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label groupLbl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private Guna.UI2.WinForms.Guna2RadioButton teacherGradioBtn;
        private Guna.UI2.WinForms.Guna2RadioButton elaveteacherGradioBtn;
        private System.Windows.Forms.Label movzuLbl;
        private System.Windows.Forms.TextBox dersinmovzusutxtB;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button button1;
    }
}