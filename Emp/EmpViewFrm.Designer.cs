namespace Phamacy_Management_System
{
    partial class EmpViewFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.empViewdgv = new System.Windows.Forms.DataGridView();
            this.empViewcmbo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.empViewdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // empViewdgv
            // 
            this.empViewdgv.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empViewdgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.empViewdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.empViewdgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.empViewdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.empViewdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empViewdgv.Location = new System.Drawing.Point(1, 92);
            this.empViewdgv.Name = "empViewdgv";
            this.empViewdgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.empViewdgv.Size = new System.Drawing.Size(969, 247);
            this.empViewdgv.TabIndex = 0;
            this.empViewdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empViewdgv_CellContentClick);
            // 
            // empViewcmbo
            // 
            this.empViewcmbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empViewcmbo.FormattingEnabled = true;
            this.empViewcmbo.Location = new System.Drawing.Point(276, 60);
            this.empViewcmbo.Name = "empViewcmbo";
            this.empViewcmbo.Size = new System.Drawing.Size(129, 21);
            this.empViewcmbo.TabIndex = 2;
            this.empViewcmbo.SelectedIndexChanged += new System.EventHandler(this.empViewcmbo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(129, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "View employees by:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(434, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Specific Search :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(562, 62);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.EnabledChanged += new System.EventHandler(this.txtSearch_EnabledChanged);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // Searchbtn
            // 
            this.Searchbtn.BackColor = System.Drawing.Color.Teal;
            this.Searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Searchbtn.ForeColor = System.Drawing.Color.White;
            this.Searchbtn.Location = new System.Drawing.Point(668, 59);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(78, 26);
            this.Searchbtn.TabIndex = 4;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = false;
            this.Searchbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(387, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "View Emploies";
            // 
            // EmpViewFrm
            // 
            this.AcceptButton = this.Searchbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(968, 340);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.empViewcmbo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.empViewdgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EmpViewFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Emploies";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmpViewFrm_FormClosing);
            this.Load += new System.EventHandler(this.EmpViewFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empViewdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView empViewdgv;
        private System.Windows.Forms.ComboBox empViewcmbo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.Label label3;
    }
}