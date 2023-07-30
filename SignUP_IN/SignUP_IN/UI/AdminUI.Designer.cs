namespace GLMS.UI
{
    partial class AdminUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUI));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.home_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.view_btn = new System.Windows.Forms.Button();
            this.viewissued_btn = new System.Windows.Forms.Button();
            this.return_btn = new System.Windows.Forms.Button();
            this.viewStudents_btn = new System.Windows.Forms.Button();
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
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1173, 59);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(1122, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(51, 59);
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
            this.btn_Close.Margin = new System.Windows.Forms.Padding(4, 4, 100, 4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(39, 59);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(55, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "ADMIN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.Controls.Add(this.home_btn);
            this.flowLayoutPanel1.Controls.Add(this.add_btn);
            this.flowLayoutPanel1.Controls.Add(this.delete_btn);
            this.flowLayoutPanel1.Controls.Add(this.edit_btn);
            this.flowLayoutPanel1.Controls.Add(this.search_btn);
            this.flowLayoutPanel1.Controls.Add(this.view_btn);
            this.flowLayoutPanel1.Controls.Add(this.viewissued_btn);
            this.flowLayoutPanel1.Controls.Add(this.return_btn);
            this.flowLayoutPanel1.Controls.Add(this.viewStudents_btn);
            this.flowLayoutPanel1.Controls.Add(this.name_btn);
            this.flowLayoutPanel1.Controls.Add(this.logout_btn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 59);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(266, 699);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // home_btn
            // 
            this.home_btn.BackColor = System.Drawing.Color.Black;
            this.home_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.home_btn.FlatAppearance.BorderSize = 0;
            this.home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_btn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.home_btn.ForeColor = System.Drawing.Color.White;
            this.home_btn.Image = ((System.Drawing.Image)(resources.GetObject("home_btn.Image")));
            this.home_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_btn.Location = new System.Drawing.Point(3, 3);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(286, 55);
            this.home_btn.TabIndex = 5;
            this.home_btn.Text = "HOME";
            this.home_btn.UseVisualStyleBackColor = false;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.Black;
            this.add_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Image = ((System.Drawing.Image)(resources.GetObject("add_btn.Image")));
            this.add_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_btn.Location = new System.Drawing.Point(3, 64);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(286, 55);
            this.add_btn.TabIndex = 6;
            this.add_btn.Text = "ADD BOOK";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Black;
            this.delete_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.delete_btn.FlatAppearance.BorderSize = 0;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.delete_btn.ForeColor = System.Drawing.Color.White;
            this.delete_btn.Image = ((System.Drawing.Image)(resources.GetObject("delete_btn.Image")));
            this.delete_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete_btn.Location = new System.Drawing.Point(3, 125);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(286, 55);
            this.delete_btn.TabIndex = 7;
            this.delete_btn.Text = "DELETE BOOK";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.Black;
            this.edit_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.edit_btn.FlatAppearance.BorderSize = 0;
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.edit_btn.ForeColor = System.Drawing.Color.White;
            this.edit_btn.Image = ((System.Drawing.Image)(resources.GetObject("edit_btn.Image")));
            this.edit_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.edit_btn.Location = new System.Drawing.Point(3, 186);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(286, 55);
            this.edit_btn.TabIndex = 11;
            this.edit_btn.Text = "EDIT BOOK";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.Black;
            this.search_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.search_btn.FlatAppearance.BorderSize = 0;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.search_btn.ForeColor = System.Drawing.Color.White;
            this.search_btn.Image = ((System.Drawing.Image)(resources.GetObject("search_btn.Image")));
            this.search_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search_btn.Location = new System.Drawing.Point(3, 247);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(286, 55);
            this.search_btn.TabIndex = 8;
            this.search_btn.Text = "SEARCH";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // view_btn
            // 
            this.view_btn.BackColor = System.Drawing.Color.Black;
            this.view_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.view_btn.FlatAppearance.BorderSize = 0;
            this.view_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_btn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.view_btn.ForeColor = System.Drawing.Color.White;
            this.view_btn.Image = ((System.Drawing.Image)(resources.GetObject("view_btn.Image")));
            this.view_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.view_btn.Location = new System.Drawing.Point(3, 308);
            this.view_btn.Name = "view_btn";
            this.view_btn.Size = new System.Drawing.Size(286, 55);
            this.view_btn.TabIndex = 9;
            this.view_btn.Text = "VIEW BOOKS";
            this.view_btn.UseVisualStyleBackColor = false;
            this.view_btn.Click += new System.EventHandler(this.view_btn_Click);
            // 
            // viewissued_btn
            // 
            this.viewissued_btn.BackColor = System.Drawing.Color.Black;
            this.viewissued_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewissued_btn.FlatAppearance.BorderSize = 0;
            this.viewissued_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewissued_btn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.viewissued_btn.ForeColor = System.Drawing.Color.White;
            this.viewissued_btn.Image = ((System.Drawing.Image)(resources.GetObject("viewissued_btn.Image")));
            this.viewissued_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewissued_btn.Location = new System.Drawing.Point(3, 369);
            this.viewissued_btn.Name = "viewissued_btn";
            this.viewissued_btn.Size = new System.Drawing.Size(286, 55);
            this.viewissued_btn.TabIndex = 10;
            this.viewissued_btn.Text = "ISSUED BOOKS";
            this.viewissued_btn.UseVisualStyleBackColor = false;
            this.viewissued_btn.Click += new System.EventHandler(this.viewissued_btn_Click);
            // 
            // return_btn
            // 
            this.return_btn.BackColor = System.Drawing.Color.Black;
            this.return_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.return_btn.FlatAppearance.BorderSize = 0;
            this.return_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_btn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.return_btn.ForeColor = System.Drawing.Color.White;
            this.return_btn.Image = ((System.Drawing.Image)(resources.GetObject("return_btn.Image")));
            this.return_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.return_btn.Location = new System.Drawing.Point(3, 430);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(286, 55);
            this.return_btn.TabIndex = 12;
            this.return_btn.Text = "RETURN BOOK";
            this.return_btn.UseVisualStyleBackColor = false;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // viewStudents_btn
            // 
            this.viewStudents_btn.BackColor = System.Drawing.Color.Black;
            this.viewStudents_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewStudents_btn.FlatAppearance.BorderSize = 0;
            this.viewStudents_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewStudents_btn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.viewStudents_btn.ForeColor = System.Drawing.Color.White;
            this.viewStudents_btn.Image = ((System.Drawing.Image)(resources.GetObject("viewStudents_btn.Image")));
            this.viewStudents_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewStudents_btn.Location = new System.Drawing.Point(3, 491);
            this.viewStudents_btn.Name = "viewStudents_btn";
            this.viewStudents_btn.Size = new System.Drawing.Size(286, 55);
            this.viewStudents_btn.TabIndex = 13;
            this.viewStudents_btn.Text = "VIEW STUDENTS";
            this.viewStudents_btn.UseVisualStyleBackColor = false;
            this.viewStudents_btn.Click += new System.EventHandler(this.viewStudents_btn_Click);
            // 
            // name_btn
            // 
            this.name_btn.BackColor = System.Drawing.Color.Black;
            this.name_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.name_btn.FlatAppearance.BorderSize = 0;
            this.name_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.name_btn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.name_btn.ForeColor = System.Drawing.Color.White;
            this.name_btn.Image = ((System.Drawing.Image)(resources.GetObject("name_btn.Image")));
            this.name_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.name_btn.Location = new System.Drawing.Point(3, 552);
            this.name_btn.Name = "name_btn";
            this.name_btn.Size = new System.Drawing.Size(286, 55);
            this.name_btn.TabIndex = 14;
            this.name_btn.Text = "MY ACCOUNT\r\n";
            this.name_btn.UseVisualStyleBackColor = false;
            this.name_btn.Click += new System.EventHandler(this.name_btn_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.Black;
            this.logout_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Image = ((System.Drawing.Image)(resources.GetObject("logout_btn.Image")));
            this.logout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_btn.Location = new System.Drawing.Point(3, 613);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(286, 55);
            this.logout_btn.TabIndex = 16;
            this.logout_btn.Text = "LOGOUT";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click_1);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.Transparent;
            this.panelChildForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelChildForm.BackgroundImage")));
            this.panelChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(266, 59);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(907, 699);
            this.panelChildForm.TabIndex = 5;
            // 
            // AdminUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1173, 758);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminUI";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminUI_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button view_btn;
        private System.Windows.Forms.Button viewissued_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.Button viewStudents_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button name_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Panel panelChildForm;
    }
}