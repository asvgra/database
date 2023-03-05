namespace DateBazLibraru
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Registr_label = new System.Windows.Forms.Label();
            this.GoTu = new System.Windows.Forms.Button();
            this.BoxPass = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.BoxLog = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelavtr = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Registr_label);
            this.panel1.Controls.Add(this.GoTu);
            this.panel1.Controls.Add(this.BoxPass);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.BoxLog);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 283);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // Registr_label
            // 
            this.Registr_label.AutoSize = true;
            this.Registr_label.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registr_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Registr_label.Location = new System.Drawing.Point(0, 255);
            this.Registr_label.Name = "Registr_label";
            this.Registr_label.Size = new System.Drawing.Size(251, 17);
            this.Registr_label.TabIndex = 6;
            this.Registr_label.Text = "Зарегистрировать администратора";
            this.Registr_label.Click += new System.EventHandler(this.Registr_label_Click);
            // 
            // GoTu
            // 
            this.GoTu.BackColor = System.Drawing.Color.DarkKhaki;
            this.GoTu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoTu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.GoTu.FlatAppearance.BorderSize = 0;
            this.GoTu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.GoTu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.GoTu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoTu.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoTu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GoTu.Location = new System.Drawing.Point(147, 220);
            this.GoTu.Name = "GoTu";
            this.GoTu.Size = new System.Drawing.Size(87, 32);
            this.GoTu.TabIndex = 5;
            this.GoTu.Text = "Войти";
            this.GoTu.UseVisualStyleBackColor = false;
            this.GoTu.Click += new System.EventHandler(this.GoTu_Click);
            // 
            // BoxPass
            // 
            this.BoxPass.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxPass.Location = new System.Drawing.Point(73, 181);
            this.BoxPass.Name = "BoxPass";
            this.BoxPass.Size = new System.Drawing.Size(158, 32);
            this.BoxPass.TabIndex = 4;
            this.BoxPass.UseSystemPasswordChar = true;
            this.BoxPass.TextChanged += new System.EventHandler(this.BoxPass_TextChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DateBazLibraru.Properties.Resources.logI__1_;
            this.pictureBox4.Location = new System.Drawing.Point(3, 160);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 64);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // BoxLog
            // 
            this.BoxLog.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxLog.Location = new System.Drawing.Point(73, 108);
            this.BoxLog.Multiline = true;
            this.BoxLog.Name = "BoxLog";
            this.BoxLog.Size = new System.Drawing.Size(158, 27);
            this.BoxLog.TabIndex = 2;
            this.BoxLog.TextChanged += new System.EventHandler(this.BoxLog_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DateBazLibraru.Properties.Resources.us;
            this.pictureBox3.Location = new System.Drawing.Point(3, 90);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelavtr);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 64);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(218, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "х";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelavtr
            // 
            this.labelavtr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelavtr.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelavtr.Location = new System.Drawing.Point(3, 0);
            this.labelavtr.Name = "labelavtr";
            this.labelavtr.Size = new System.Drawing.Size(228, 51);
            this.labelavtr.TabIndex = 0;
            this.labelavtr.Text = "Авторизация";
            this.labelavtr.Click += new System.EventHandler(this.labelavtr_Click);
            // 
            // LoginForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(254, 283);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelavtr;
        private System.Windows.Forms.TextBox BoxPass;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox BoxLog;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button GoTu;
        private System.Windows.Forms.Label Registr_label;
    }
}