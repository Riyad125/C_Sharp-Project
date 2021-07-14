namespace Phamacy_Management_System
{
    partial class RestoreDatabaseFrm
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
            this.cancleBtn = new System.Windows.Forms.Button();
            this.restoreBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.brwoseBtn = new System.Windows.Forms.Button();
            this.restoretxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancleBtn
            // 
            this.cancleBtn.BackColor = System.Drawing.Color.Teal;
            this.cancleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancleBtn.ForeColor = System.Drawing.Color.White;
            this.cancleBtn.Location = new System.Drawing.Point(323, 114);
            this.cancleBtn.Name = "cancleBtn";
            this.cancleBtn.Size = new System.Drawing.Size(95, 34);
            this.cancleBtn.TabIndex = 5;
            this.cancleBtn.Text = "Cancle";
            this.cancleBtn.UseVisualStyleBackColor = false;
            this.cancleBtn.Click += new System.EventHandler(this.cancleBtn_Click);
            // 
            // restoreBtn
            // 
            this.restoreBtn.BackColor = System.Drawing.Color.Teal;
            this.restoreBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoreBtn.ForeColor = System.Drawing.Color.White;
            this.restoreBtn.Location = new System.Drawing.Point(203, 114);
            this.restoreBtn.Name = "restoreBtn";
            this.restoreBtn.Size = new System.Drawing.Size(95, 34);
            this.restoreBtn.TabIndex = 4;
            this.restoreBtn.Text = "Restore";
            this.restoreBtn.UseVisualStyleBackColor = false;
            this.restoreBtn.Click += new System.EventHandler(this.restoreBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.brwoseBtn);
            this.groupBox1.Controls.Add(this.restoretxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 89);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Backup";
            // 
            // brwoseBtn
            // 
            this.brwoseBtn.BackColor = System.Drawing.Color.Teal;
            this.brwoseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brwoseBtn.ForeColor = System.Drawing.Color.White;
            this.brwoseBtn.Location = new System.Drawing.Point(521, 30);
            this.brwoseBtn.Name = "brwoseBtn";
            this.brwoseBtn.Size = new System.Drawing.Size(83, 34);
            this.brwoseBtn.TabIndex = 2;
            this.brwoseBtn.Text = "Browse";
            this.brwoseBtn.UseVisualStyleBackColor = false;
            this.brwoseBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // restoretxt
            // 
            this.restoretxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoretxt.ForeColor = System.Drawing.Color.SkyBlue;
            this.restoretxt.Location = new System.Drawing.Point(103, 37);
            this.restoretxt.Name = "restoretxt";
            this.restoretxt.Size = new System.Drawing.Size(398, 22);
            this.restoretxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location";
            // 
            // RestoreDatabaseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 155);
            this.Controls.Add(this.cancleBtn);
            this.Controls.Add(this.restoreBtn);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "RestoreDatabaseFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restore Database";
            this.Load += new System.EventHandler(this.RestoreDatabaseFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancleBtn;
        private System.Windows.Forms.Button restoreBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button brwoseBtn;
        private System.Windows.Forms.TextBox restoretxt;
        private System.Windows.Forms.Label label1;
    }
}