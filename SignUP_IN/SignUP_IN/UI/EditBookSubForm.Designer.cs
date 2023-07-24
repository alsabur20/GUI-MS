namespace GLMS.UI
{
    partial class EditBookSubForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.editBook_btn = new System.Windows.Forms.Button();
            this.bGenre = new System.Windows.Forms.TextBox();
            this.bAuthor = new System.Windows.Forms.TextBox();
            this.bName = new System.Windows.Forms.TextBox();
            this.bID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.editBook_btn);
            this.panel3.Controls.Add(this.bGenre);
            this.panel3.Controls.Add(this.bAuthor);
            this.panel3.Controls.Add(this.bName);
            this.panel3.Controls.Add(this.bID);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(405, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(317, 564);
            this.panel3.TabIndex = 11;
            // 
            // editBook_btn
            // 
            this.editBook_btn.AutoEllipsis = true;
            this.editBook_btn.BackColor = System.Drawing.Color.Transparent;
            this.editBook_btn.FlatAppearance.BorderSize = 2;
            this.editBook_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBook_btn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.editBook_btn.ForeColor = System.Drawing.Color.Black;
            this.editBook_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editBook_btn.Location = new System.Drawing.Point(5, 358);
            this.editBook_btn.Name = "editBook_btn";
            this.editBook_btn.Size = new System.Drawing.Size(286, 55);
            this.editBook_btn.TabIndex = 6;
            this.editBook_btn.Text = "EDIT BOOK";
            this.editBook_btn.UseVisualStyleBackColor = false;
            this.editBook_btn.Click += new System.EventHandler(this.editBook_btn_Click);
            // 
            // bGenre
            // 
            this.bGenre.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGenre.Location = new System.Drawing.Point(1, 235);
            this.bGenre.Name = "bGenre";
            this.bGenre.Size = new System.Drawing.Size(293, 45);
            this.bGenre.TabIndex = 3;
            // 
            // bAuthor
            // 
            this.bAuthor.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAuthor.Location = new System.Drawing.Point(1, 172);
            this.bAuthor.Name = "bAuthor";
            this.bAuthor.Size = new System.Drawing.Size(293, 45);
            this.bAuthor.TabIndex = 2;
            // 
            // bName
            // 
            this.bName.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bName.Location = new System.Drawing.Point(1, 114);
            this.bName.Name = "bName";
            this.bName.Size = new System.Drawing.Size(293, 45);
            this.bName.TabIndex = 1;
            // 
            // bID
            // 
            this.bID.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bID.Location = new System.Drawing.Point(0, 58);
            this.bID.Name = "bID";
            this.bID.Size = new System.Drawing.Size(293, 45);
            this.bID.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 564);
            this.panel2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(182, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 45);
            this.label3.TabIndex = 1;
            this.label3.Text = "BOOK NAME:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(174, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 45);
            this.label5.TabIndex = 3;
            this.label5.Text = "BOOK GENRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "BOOK ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(145, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 45);
            this.label4.TabIndex = 2;
            this.label4.Text = "BOOK AUTHOR:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 68);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(388, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "EDIT BOOK";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1014, 564);
            this.panel4.TabIndex = 13;
            // 
            // EditBookSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 632);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "EditBookSubForm";
            this.Text = "Edit Book";
            this.Load += new System.EventHandler(this.EditBookSubForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button editBook_btn;
        private System.Windows.Forms.TextBox bGenre;
        private System.Windows.Forms.TextBox bAuthor;
        private System.Windows.Forms.TextBox bName;
        private System.Windows.Forms.TextBox bID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
    }
}