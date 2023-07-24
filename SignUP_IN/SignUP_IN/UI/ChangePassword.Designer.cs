namespace GLMS.UI
{
    partial class ChangePassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.MaskedTextBox();
            this.p2 = new System.Windows.Forms.MaskedTextBox();
            this.p3 = new System.Windows.Forms.MaskedTextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 46);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(270, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Old Password: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter New Password: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Re-Enter Old Password: ";
            // 
            // p1
            // 
            this.p1.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1.Location = new System.Drawing.Point(32, 39);
            this.p1.Name = "p1";
            this.p1.PasswordChar = '*';
            this.p1.Size = new System.Drawing.Size(278, 45);
            this.p1.TabIndex = 3;
            // 
            // p2
            // 
            this.p2.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2.Location = new System.Drawing.Point(32, 97);
            this.p2.Name = "p2";
            this.p2.PasswordChar = '*';
            this.p2.Size = new System.Drawing.Size(278, 45);
            this.p2.TabIndex = 4;
            // 
            // p3
            // 
            this.p3.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p3.Location = new System.Drawing.Point(32, 152);
            this.p3.Name = "p3";
            this.p3.PasswordChar = '*';
            this.p3.Size = new System.Drawing.Size(278, 45);
            this.p3.TabIndex = 5;
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
            this.save_btn.Location = new System.Drawing.Point(501, 23);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(286, 55);
            this.save_btn.TabIndex = 7;
            this.save_btn.Text = "SAVE";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.save_btn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 350);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 20, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 100);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.panel1);
            this.flowLayoutPanel2.Controls.Add(this.panel2);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(800, 350);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(3, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 234);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.p1);
            this.panel2.Controls.Add(this.p2);
            this.panel2.Controls.Add(this.p3);
            this.panel2.Location = new System.Drawing.Point(423, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 234);
            this.panel2.TabIndex = 11;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChangePassword_FormClosed);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox p1;
        private System.Windows.Forms.MaskedTextBox p2;
        private System.Windows.Forms.MaskedTextBox p3;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}