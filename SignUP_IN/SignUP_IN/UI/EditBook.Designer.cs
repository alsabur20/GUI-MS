namespace GLMS.UI
{
    partial class EditBook
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
            this.dG = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dG)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dG
            // 
            this.dG.BackgroundColor = System.Drawing.Color.White;
            this.dG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit});
            this.dG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dG.Location = new System.Drawing.Point(0, 68);
            this.dG.Name = "dG";
            this.dG.ReadOnly = true;
            this.dG.RowHeadersWidth = 62;
            this.dG.RowTemplate.Height = 28;
            this.dG.Size = new System.Drawing.Size(964, 544);
            this.dG.TabIndex = 11;
            this.dG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dG_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 8;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 150;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 68);
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
            // EditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 612);
            this.Controls.Add(this.dG);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditBook";
            this.Text = "EditBook";
            ((System.ComponentModel.ISupportInitialize)(this.dG)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dG;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}