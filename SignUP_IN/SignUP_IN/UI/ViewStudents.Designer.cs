namespace GLMS.UI
{
    partial class ViewStudents
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.sName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.search_btn = new System.Windows.Forms.Button();
            this.dG = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dG)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 89);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(329, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "STUDENTS";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1073, 113);
            this.panel2.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.sName);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(627, 113);
            this.panel5.TabIndex = 16;
            // 
            // sName
            // 
            this.sName.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sName.Location = new System.Drawing.Point(281, 43);
            this.sName.Name = "sName";
            this.sName.Size = new System.Drawing.Size(293, 45);
            this.sName.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 45);
            this.label3.TabIndex = 12;
            this.label3.Text = "STUDENT NAME:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.search_btn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(855, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 113);
            this.panel3.TabIndex = 15;
            // 
            // search_btn
            // 
            this.search_btn.AutoEllipsis = true;
            this.search_btn.BackColor = System.Drawing.Color.Transparent;
            this.search_btn.FlatAppearance.BorderSize = 2;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.search_btn.ForeColor = System.Drawing.Color.Black;
            this.search_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search_btn.Location = new System.Drawing.Point(19, 33);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(172, 55);
            this.search_btn.TabIndex = 14;
            this.search_btn.Text = "SEARCH";
            this.search_btn.UseVisualStyleBackColor = false;
            // 
            // dG
            // 
            this.dG.BackgroundColor = System.Drawing.Color.White;
            this.dG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dG.Location = new System.Drawing.Point(0, 202);
            this.dG.Name = "dG";
            this.dG.RowHeadersWidth = 62;
            this.dG.RowTemplate.Height = 28;
            this.dG.Size = new System.Drawing.Size(1073, 366);
            this.dG.TabIndex = 3;
            // 
            // ViewStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1073, 568);
            this.Controls.Add(this.dG);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewStudents";
            this.Text = "ViewStudents";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox sName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.DataGridView dG;
    }
}