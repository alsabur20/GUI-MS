namespace GLMS.UI
{
    partial class StudentUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentUI));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.home_btn = new System.Windows.Forms.Button();
            this.issue_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.view_btn = new System.Windows.Forms.Button();
            this.return_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.name_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1119, 50);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(1051, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(68, 50);
            this.panel1.TabIndex = 4;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.BackgroundImage")));
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Location = new System.Drawing.Point(0, 0);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(5, 5, 133, 5);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(52, 50);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(73, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "STUDENT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.Controls.Add(this.home_btn);
            this.flowLayoutPanel1.Controls.Add(this.issue_btn);
            this.flowLayoutPanel1.Controls.Add(this.search_btn);
            this.flowLayoutPanel1.Controls.Add(this.view_btn);
            this.flowLayoutPanel1.Controls.Add(this.return_btn);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.name_btn);
            this.flowLayoutPanel1.Controls.Add(this.logout_btn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(268, 622);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // home_btn
            // 
            this.home_btn.BackColor = System.Drawing.Color.Black;
            this.home_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.home_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.home_btn.FlatAppearance.BorderSize = 0;
            this.home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_btn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.home_btn.ForeColor = System.Drawing.Color.White;
            this.home_btn.Image = ((System.Drawing.Image)(resources.GetObject("home_btn.Image")));
            this.home_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_btn.Location = new System.Drawing.Point(4, 4);
            this.home_btn.Margin = new System.Windows.Forms.Padding(4);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(318, 63);
            this.home_btn.TabIndex = 5;
            this.home_btn.Text = "HOME";
            this.home_btn.UseVisualStyleBackColor = false;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // issue_btn
            // 
            this.issue_btn.BackColor = System.Drawing.Color.Black;
            this.issue_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.issue_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.issue_btn.FlatAppearance.BorderSize = 0;
            this.issue_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issue_btn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.issue_btn.ForeColor = System.Drawing.Color.White;
            this.issue_btn.Image = ((System.Drawing.Image)(resources.GetObject("issue_btn.Image")));
            this.issue_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.issue_btn.Location = new System.Drawing.Point(4, 75);
            this.issue_btn.Margin = new System.Windows.Forms.Padding(4);
            this.issue_btn.Name = "issue_btn";
            this.issue_btn.Size = new System.Drawing.Size(318, 63);
            this.issue_btn.TabIndex = 6;
            this.issue_btn.Text = "ISSUE";
            this.issue_btn.UseVisualStyleBackColor = false;
            this.issue_btn.Click += new System.EventHandler(this.issue_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.Black;
            this.search_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.search_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.search_btn.FlatAppearance.BorderSize = 0;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.search_btn.ForeColor = System.Drawing.Color.White;
            this.search_btn.Image = ((System.Drawing.Image)(resources.GetObject("search_btn.Image")));
            this.search_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search_btn.Location = new System.Drawing.Point(4, 146);
            this.search_btn.Margin = new System.Windows.Forms.Padding(4);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(318, 63);
            this.search_btn.TabIndex = 8;
            this.search_btn.Text = "SEARCH";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // view_btn
            // 
            this.view_btn.BackColor = System.Drawing.Color.Black;
            this.view_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.view_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.view_btn.FlatAppearance.BorderSize = 0;
            this.view_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_btn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.view_btn.ForeColor = System.Drawing.Color.White;
            this.view_btn.Image = ((System.Drawing.Image)(resources.GetObject("view_btn.Image")));
            this.view_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.view_btn.Location = new System.Drawing.Point(4, 217);
            this.view_btn.Margin = new System.Windows.Forms.Padding(4);
            this.view_btn.Name = "view_btn";
            this.view_btn.Size = new System.Drawing.Size(318, 63);
            this.view_btn.TabIndex = 9;
            this.view_btn.Text = "VIEW BOOKS";
            this.view_btn.UseVisualStyleBackColor = false;
            this.view_btn.Click += new System.EventHandler(this.view_btn_Click);
            // 
            // return_btn
            // 
            this.return_btn.BackColor = System.Drawing.Color.Black;
            this.return_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.return_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.return_btn.FlatAppearance.BorderSize = 0;
            this.return_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_btn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.return_btn.ForeColor = System.Drawing.Color.White;
            this.return_btn.Image = ((System.Drawing.Image)(resources.GetObject("return_btn.Image")));
            this.return_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.return_btn.Location = new System.Drawing.Point(4, 288);
            this.return_btn.Margin = new System.Windows.Forms.Padding(4);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(318, 63);
            this.return_btn.TabIndex = 12;
            this.return_btn.Text = "RETURN BOOK";
            this.return_btn.UseVisualStyleBackColor = false;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(4, 359);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(318, 63);
            this.button1.TabIndex = 17;
            this.button1.Text = "MY BOOKS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // name_btn
            // 
            this.name_btn.BackColor = System.Drawing.Color.Black;
            this.name_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.name_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.name_btn.FlatAppearance.BorderSize = 0;
            this.name_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.name_btn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.name_btn.ForeColor = System.Drawing.Color.White;
            this.name_btn.Image = ((System.Drawing.Image)(resources.GetObject("name_btn.Image")));
            this.name_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.name_btn.Location = new System.Drawing.Point(4, 430);
            this.name_btn.Margin = new System.Windows.Forms.Padding(4);
            this.name_btn.Name = "name_btn";
            this.name_btn.Size = new System.Drawing.Size(318, 63);
            this.name_btn.TabIndex = 14;
            this.name_btn.Text = "MY ACCOUNT\r\n";
            this.name_btn.UseVisualStyleBackColor = false;
            this.name_btn.Click += new System.EventHandler(this.name_btn_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.Black;
            this.logout_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.logout_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Image = ((System.Drawing.Image)(resources.GetObject("logout_btn.Image")));
            this.logout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_btn.Location = new System.Drawing.Point(4, 501);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(4);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(318, 63);
            this.logout_btn.TabIndex = 16;
            this.logout_btn.Text = "LOGOUT";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.Transparent;
            this.panelChildForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelChildForm.BackgroundImage")));
            this.panelChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(268, 50);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(4);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(851, 622);
            this.panelChildForm.TabIndex = 6;
            // 
            // StudentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 672);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentUI";
            this.Text = "StudentUI";
            this.Load += new System.EventHandler(this.StudentUI_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Button issue_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button view_btn;
        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.Button name_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button button1;
    }
}