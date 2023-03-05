namespace DateBazLibraru
{
    partial class Registrs
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
            this.Registrsh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelavtr = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Registr_label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textFIOReg = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // Registrsh
            // 
            this.Registrsh.BackColor = System.Drawing.Color.DarkKhaki;
            this.Registrsh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Registrsh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Registrsh.FlatAppearance.BorderSize = 0;
            this.Registrsh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Registrsh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Registrsh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registrsh.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registrsh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Registrsh.Location = new System.Drawing.Point(147, 215);
            this.Registrsh.Name = "Registrsh";
            this.Registrsh.Size = new System.Drawing.Size(217, 32);
            this.Registrsh.TabIndex = 5;
            this.Registrsh.Text = "Зарегистрироваться";
            this.Registrsh.UseVisualStyleBackColor = false;
            this.Registrsh.Click += new System.EventHandler(this.Registrsh_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelavtr);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 64);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(339, 0);
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
            this.labelavtr.Location = new System.Drawing.Point(79, 0);
            this.labelavtr.Name = "labelavtr";
            this.labelavtr.Size = new System.Drawing.Size(222, 38);
            this.labelavtr.TabIndex = 0;
            this.labelavtr.Text = "Регистрация";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.Registr_label);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.textFIOReg);
            this.panel1.Controls.Add(this.Registrsh);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 280);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // Registr_label
            // 
            this.Registr_label.AutoSize = true;
            this.Registr_label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registr_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Registr_label.Location = new System.Drawing.Point(12, 249);
            this.Registr_label.Name = "Registr_label";
            this.Registr_label.Size = new System.Drawing.Size(162, 22);
            this.Registr_label.TabIndex = 7;
            this.Registr_label.Text = "Уже есть аккаунт";
            this.Registr_label.Click += new System.EventHandler(this.Registr_label_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DateBazLibraru.Properties.Resources.name;
            this.pictureBox2.Location = new System.Drawing.Point(16, 90);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // textBoxName
            // 
            this.textBoxName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(86, 104);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(241, 32);
            this.textBoxName.TabIndex = 7;
            this.textBoxName.Enter += new System.EventHandler(this.textBoxName_Enter);
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // textFIOReg
            // 
            this.textFIOReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textFIOReg.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFIOReg.Location = new System.Drawing.Point(86, 158);
            this.textFIOReg.Name = "textFIOReg";
            this.textFIOReg.Size = new System.Drawing.Size(241, 32);
            this.textFIOReg.TabIndex = 6;
            this.textFIOReg.TextChanged += new System.EventHandler(this.textFIO_TextChanged);
            this.textFIOReg.Enter += new System.EventHandler(this.textFIO_Enter);
            this.textFIOReg.Leave += new System.EventHandler(this.textFIO_Leave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DateBazLibraru.Properties.Resources.logI__1_;
            this.pictureBox4.Location = new System.Drawing.Point(16, 147);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 43);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // Registrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 280);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registrs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Registrsh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelavtr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textFIOReg;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Registr_label;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}