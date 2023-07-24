namespace GLMS.UI
{
    partial class MyAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyAccount));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.save_btn = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.TextBox();
            this.uName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.editPasswordLabel = new System.Windows.Forms.PictureBox();
            this.editUsernameLabel = new System.Windows.Forms.PictureBox();
            this.editNameLabel = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.uPassword = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editPasswordLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editUsernameLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editNameLabel)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1157, 68);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(388, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "MY ACCOUNT";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 642);
            this.panel2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 45);
            this.label3.TabIndex = 1;
            this.label3.Text = "USERNAME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "NAME:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 45);
            this.label4.TabIndex = 2;
            this.label4.Text = "PASSWORD:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.uPassword);
            this.panel3.Controls.Add(this.save_btn);
            this.panel3.Controls.Add(this.userName);
            this.panel3.Controls.Add(this.uName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(419, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(407, 642);
            this.panel3.TabIndex = 14;
            // 
            // save_btn
            // 
            this.save_btn.AutoEllipsis = true;
            this.save_btn.BackColor = System.Drawing.Color.Transparent;
            this.save_btn.FlatAppearance.BorderSize = 2;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.save_btn.ForeColor = System.Drawing.Color.Black;
            this.save_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save_btn.Location = new System.Drawing.Point(72, 457);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(286, 55);
            this.save_btn.TabIndex = 6;
            this.save_btn.Text = "SAVE";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(68, 224);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(293, 45);
            this.userName.TabIndex = 1;
            // 
            // uName
            // 
            this.uName.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uName.Location = new System.Drawing.Point(67, 168);
            this.uName.Name = "uName";
            this.uName.Size = new System.Drawing.Size(293, 45);
            this.uName.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.editPasswordLabel);
            this.panel4.Controls.Add(this.editUsernameLabel);
            this.panel4.Controls.Add(this.editNameLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(826, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(331, 642);
            this.panel4.TabIndex = 15;
            // 
            // editPasswordLabel
            // 
            this.editPasswordLabel.Image = ((System.Drawing.Image)(resources.GetObject("editPasswordLabel.Image")));
            this.editPasswordLabel.Location = new System.Drawing.Point(6, 289);
            this.editPasswordLabel.Name = "editPasswordLabel";
            this.editPasswordLabel.Size = new System.Drawing.Size(39, 38);
            this.editPasswordLabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editPasswordLabel.TabIndex = 2;
            this.editPasswordLabel.TabStop = false;
            this.editPasswordLabel.Click += new System.EventHandler(this.editPasswordLabel_Click);
            // 
            // editUsernameLabel
            // 
            this.editUsernameLabel.Image = ((System.Drawing.Image)(resources.GetObject("editUsernameLabel.Image")));
            this.editUsernameLabel.Location = new System.Drawing.Point(6, 232);
            this.editUsernameLabel.Name = "editUsernameLabel";
            this.editUsernameLabel.Size = new System.Drawing.Size(39, 38);
            this.editUsernameLabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editUsernameLabel.TabIndex = 1;
            this.editUsernameLabel.TabStop = false;
            this.editUsernameLabel.Click += new System.EventHandler(this.editUsernameLabel_Click);
            // 
            // editNameLabel
            // 
            this.editNameLabel.Image = ((System.Drawing.Image)(resources.GetObject("editNameLabel.Image")));
            this.editNameLabel.Location = new System.Drawing.Point(6, 175);
            this.editNameLabel.Name = "editNameLabel";
            this.editNameLabel.Size = new System.Drawing.Size(39, 38);
            this.editNameLabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editNameLabel.TabIndex = 0;
            this.editNameLabel.TabStop = false;
            this.editNameLabel.Click += new System.EventHandler(this.editNameLabel_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(170, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(249, 642);
            this.panel5.TabIndex = 3;
            // 
            // uPassword
            // 
            this.uPassword.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uPassword.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.uPassword.Location = new System.Drawing.Point(68, 289);
            this.uPassword.Name = "uPassword";
            this.uPassword.PasswordChar = '*';
            this.uPassword.Size = new System.Drawing.Size(290, 45);
            this.uPassword.TabIndex = 7;
            // 
            // MyAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1157, 710);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyAccount";
            this.Text = "MyAccount";
            this.Load += new System.EventHandler(this.MyAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editPasswordLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editUsernameLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editNameLabel)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox uName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox editPasswordLabel;
        private System.Windows.Forms.PictureBox editUsernameLabel;
        private System.Windows.Forms.PictureBox editNameLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.MaskedTextBox uPassword;
    }
}