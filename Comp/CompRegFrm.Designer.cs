namespace Phamacy_Management_System
{
    partial class CompRegFrm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.compAddPhonebtn = new System.Windows.Forms.Button();
            this.compRegPhone2txt = new System.Windows.Forms.TextBox();
            this.compRegEmailtxt = new System.Windows.Forms.TextBox();
            this.compRegPhone1txt = new System.Windows.Forms.TextBox();
            this.compRegAddtxt = new System.Windows.Forms.TextBox();
            this.compRegNametxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.compRegRegbtn = new System.Windows.Forms.Button();
            this.compRegCanclebtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.compAddPhonebtn);
            this.groupBox1.Controls.Add(this.compRegPhone2txt);
            this.groupBox1.Controls.Add(this.compRegEmailtxt);
            this.groupBox1.Controls.Add(this.compRegPhone1txt);
            this.groupBox1.Controls.Add(this.compRegAddtxt);
            this.groupBox1.Controls.Add(this.compRegNametxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Company Data";
            // 
            // compAddPhonebtn
            // 
            this.compAddPhonebtn.BackColor = System.Drawing.Color.Teal;
            this.compAddPhonebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compAddPhonebtn.ForeColor = System.Drawing.Color.White;
            this.compAddPhonebtn.Location = new System.Drawing.Point(337, 88);
            this.compAddPhonebtn.Name = "compAddPhonebtn";
            this.compAddPhonebtn.Size = new System.Drawing.Size(25, 25);
            this.compAddPhonebtn.TabIndex = 3;
            this.compAddPhonebtn.Text = "+";
            this.compAddPhonebtn.UseVisualStyleBackColor = false;
            this.compAddPhonebtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // compRegPhone2txt
            // 
            this.compRegPhone2txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compRegPhone2txt.ForeColor = System.Drawing.Color.Black;
            this.compRegPhone2txt.Location = new System.Drawing.Point(367, 90);
            this.compRegPhone2txt.MaxLength = 15;
            this.compRegPhone2txt.Name = "compRegPhone2txt";
            this.compRegPhone2txt.Size = new System.Drawing.Size(179, 22);
            this.compRegPhone2txt.TabIndex = 4;
            this.compRegPhone2txt.Visible = false;
            this.compRegPhone2txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.compPhonesKeyPress);
            // 
            // compRegEmailtxt
            // 
            this.compRegEmailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compRegEmailtxt.ForeColor = System.Drawing.Color.Black;
            this.compRegEmailtxt.Location = new System.Drawing.Point(151, 121);
            this.compRegEmailtxt.MaxLength = 35;
            this.compRegEmailtxt.Name = "compRegEmailtxt";
            this.compRegEmailtxt.Size = new System.Drawing.Size(395, 22);
            this.compRegEmailtxt.TabIndex = 5;
            this.compRegEmailtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.compRegEmailtxt_KeyPress);
            // 
            // compRegPhone1txt
            // 
            this.compRegPhone1txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compRegPhone1txt.ForeColor = System.Drawing.Color.Black;
            this.compRegPhone1txt.Location = new System.Drawing.Point(151, 90);
            this.compRegPhone1txt.MaxLength = 15;
            this.compRegPhone1txt.Name = "compRegPhone1txt";
            this.compRegPhone1txt.Size = new System.Drawing.Size(179, 22);
            this.compRegPhone1txt.TabIndex = 2;
            this.compRegPhone1txt.TextChanged += new System.EventHandler(this.compRegTextChanged);
            this.compRegPhone1txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.compPhonesKeyPress);
            this.compRegPhone1txt.Validating += new System.ComponentModel.CancelEventHandler(this.compRegValidating);
            // 
            // compRegAddtxt
            // 
            this.compRegAddtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compRegAddtxt.ForeColor = System.Drawing.Color.Black;
            this.compRegAddtxt.Location = new System.Drawing.Point(151, 58);
            this.compRegAddtxt.MaxLength = 60;
            this.compRegAddtxt.Name = "compRegAddtxt";
            this.compRegAddtxt.Size = new System.Drawing.Size(395, 22);
            this.compRegAddtxt.TabIndex = 1;
            this.compRegAddtxt.TextChanged += new System.EventHandler(this.compRegTextChanged);
            this.compRegAddtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.compRegAddtxt_KeyPress);
            this.compRegAddtxt.Validating += new System.ComponentModel.CancelEventHandler(this.compRegValidating);
            // 
            // compRegNametxt
            // 
            this.compRegNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compRegNametxt.ForeColor = System.Drawing.Color.Black;
            this.compRegNametxt.Location = new System.Drawing.Point(151, 27);
            this.compRegNametxt.MaxLength = 30;
            this.compRegNametxt.Name = "compRegNametxt";
            this.compRegNametxt.Size = new System.Drawing.Size(395, 22);
            this.compRegNametxt.TabIndex = 0;
            this.compRegNametxt.TextChanged += new System.EventHandler(this.compRegTextChanged);
            this.compRegNametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.compRegNametxt_KeyPress);
            this.compRegNametxt.Validating += new System.ComponentModel.CancelEventHandler(this.compRegValidating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(13, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Company Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company Name";
            // 
            // compRegRegbtn
            // 
            this.compRegRegbtn.BackColor = System.Drawing.Color.Teal;
            this.compRegRegbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compRegRegbtn.ForeColor = System.Drawing.Color.White;
            this.compRegRegbtn.Location = new System.Drawing.Point(162, 219);
            this.compRegRegbtn.Name = "compRegRegbtn";
            this.compRegRegbtn.Size = new System.Drawing.Size(115, 35);
            this.compRegRegbtn.TabIndex = 6;
            this.compRegRegbtn.Text = "Register";
            this.compRegRegbtn.UseVisualStyleBackColor = false;
            this.compRegRegbtn.Click += new System.EventHandler(this.compRegRegbtn_Click);
            // 
            // compRegCanclebtn
            // 
            this.compRegCanclebtn.BackColor = System.Drawing.Color.Teal;
            this.compRegCanclebtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.compRegCanclebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compRegCanclebtn.ForeColor = System.Drawing.Color.White;
            this.compRegCanclebtn.Location = new System.Drawing.Point(302, 219);
            this.compRegCanclebtn.Name = "compRegCanclebtn";
            this.compRegCanclebtn.Size = new System.Drawing.Size(115, 35);
            this.compRegCanclebtn.TabIndex = 7;
            this.compRegCanclebtn.Text = "Cancle";
            this.compRegCanclebtn.UseVisualStyleBackColor = false;
            this.compRegCanclebtn.Click += new System.EventHandler(this.compRegCanclebtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(191, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Company Registeration";
            // 
            // CompRegFrm
            // 
            this.AcceptButton = this.compRegRegbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.CancelButton = this.compRegCanclebtn;
            this.ClientSize = new System.Drawing.Size(584, 262);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.compRegCanclebtn);
            this.Controls.Add(this.compRegRegbtn);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CompRegFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company Registeration";
            this.Load += new System.EventHandler(this.CompRegFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox compRegPhone2txt;
        private System.Windows.Forms.TextBox compRegEmailtxt;
        private System.Windows.Forms.TextBox compRegPhone1txt;
        private System.Windows.Forms.TextBox compRegAddtxt;
        private System.Windows.Forms.TextBox compRegNametxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button compRegRegbtn;
        private System.Windows.Forms.Button compRegCanclebtn;
        private System.Windows.Forms.Button compAddPhonebtn;
        private System.Windows.Forms.Label label5;

    }
}