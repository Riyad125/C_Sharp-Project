namespace Phamacy_Management_System
{
    partial class DebtRegFrm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.debtRegNametxt = new System.Windows.Forms.TextBox();
            this.debtRegAddtxt = new System.Windows.Forms.TextBox();
            this.debtRegPhone1txt = new System.Windows.Forms.TextBox();
            this.debtRegISSNtxt = new System.Windows.Forms.TextBox();
            this.debtRegMaxDebttxt = new System.Windows.Forms.TextBox();
            this.debtRegPhone2txt = new System.Windows.Forms.TextBox();
            this.debtRegRegbtn = new System.Windows.Forms.Button();
            this.debtRegCanclebtn = new System.Windows.Forms.Button();
            this.debtAddPhone2btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Debtor Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(22, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Debtor Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(22, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Debtor Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(22, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "SSN";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(22, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Max Debt";
            // 
            // debtRegNametxt
            // 
            this.debtRegNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debtRegNametxt.ForeColor = System.Drawing.Color.Black;
            this.debtRegNametxt.Location = new System.Drawing.Point(140, 21);
            this.debtRegNametxt.MaxLength = 50;
            this.debtRegNametxt.Name = "debtRegNametxt";
            this.debtRegNametxt.Size = new System.Drawing.Size(354, 22);
            this.debtRegNametxt.TabIndex = 0;
            this.debtRegNametxt.TextChanged += new System.EventHandler(this.debtRegTextChanged);
            this.debtRegNametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.debtRegNametxt_KeyPress);
            this.debtRegNametxt.Validating += new System.ComponentModel.CancelEventHandler(this.debtRegTextValidating);
            // 
            // debtRegAddtxt
            // 
            this.debtRegAddtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debtRegAddtxt.ForeColor = System.Drawing.Color.Black;
            this.debtRegAddtxt.Location = new System.Drawing.Point(140, 58);
            this.debtRegAddtxt.MaxLength = 60;
            this.debtRegAddtxt.Name = "debtRegAddtxt";
            this.debtRegAddtxt.Size = new System.Drawing.Size(354, 22);
            this.debtRegAddtxt.TabIndex = 1;
            this.debtRegAddtxt.TextChanged += new System.EventHandler(this.debtRegTextChanged);
            this.debtRegAddtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.debtRegAddtxt_KeyPress);
            this.debtRegAddtxt.Validating += new System.ComponentModel.CancelEventHandler(this.debtRegTextValidating);
            // 
            // debtRegPhone1txt
            // 
            this.debtRegPhone1txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debtRegPhone1txt.ForeColor = System.Drawing.Color.Black;
            this.debtRegPhone1txt.Location = new System.Drawing.Point(140, 96);
            this.debtRegPhone1txt.MaxLength = 15;
            this.debtRegPhone1txt.Name = "debtRegPhone1txt";
            this.debtRegPhone1txt.Size = new System.Drawing.Size(150, 22);
            this.debtRegPhone1txt.TabIndex = 2;
            this.debtRegPhone1txt.TextChanged += new System.EventHandler(this.debtRegTextChanged);
            this.debtRegPhone1txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.debtPhonesKeyPraess);
            this.debtRegPhone1txt.Validating += new System.ComponentModel.CancelEventHandler(this.debtRegTextValidating);
            // 
            // debtRegISSNtxt
            // 
            this.debtRegISSNtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debtRegISSNtxt.ForeColor = System.Drawing.Color.Black;
            this.debtRegISSNtxt.Location = new System.Drawing.Point(140, 132);
            this.debtRegISSNtxt.Name = "debtRegISSNtxt";
            this.debtRegISSNtxt.Size = new System.Drawing.Size(150, 22);
            this.debtRegISSNtxt.TabIndex = 5;
            this.debtRegISSNtxt.TextChanged += new System.EventHandler(this.debtRegTextChanged);
            this.debtRegISSNtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.debtRegISSNtxt_KeyPress);
            this.debtRegISSNtxt.Validating += new System.ComponentModel.CancelEventHandler(this.debtRegTextValidating);
            // 
            // debtRegMaxDebttxt
            // 
            this.debtRegMaxDebttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debtRegMaxDebttxt.ForeColor = System.Drawing.Color.Black;
            this.debtRegMaxDebttxt.Location = new System.Drawing.Point(140, 170);
            this.debtRegMaxDebttxt.Name = "debtRegMaxDebttxt";
            this.debtRegMaxDebttxt.Size = new System.Drawing.Size(150, 22);
            this.debtRegMaxDebttxt.TabIndex = 6;
            this.debtRegMaxDebttxt.TextChanged += new System.EventHandler(this.debtRegTextChanged);
            this.debtRegMaxDebttxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.debtMoneyKeyPress);
            this.debtRegMaxDebttxt.Validating += new System.ComponentModel.CancelEventHandler(this.debtRegTextValidating);
            // 
            // debtRegPhone2txt
            // 
            this.debtRegPhone2txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debtRegPhone2txt.ForeColor = System.Drawing.Color.Black;
            this.debtRegPhone2txt.Location = new System.Drawing.Point(344, 96);
            this.debtRegPhone2txt.MaxLength = 15;
            this.debtRegPhone2txt.Name = "debtRegPhone2txt";
            this.debtRegPhone2txt.Size = new System.Drawing.Size(150, 22);
            this.debtRegPhone2txt.TabIndex = 4;
            this.debtRegPhone2txt.Visible = false;
            this.debtRegPhone2txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.debtPhonesKeyPraess);
            // 
            // debtRegRegbtn
            // 
            this.debtRegRegbtn.BackColor = System.Drawing.Color.Teal;
            this.debtRegRegbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debtRegRegbtn.ForeColor = System.Drawing.Color.White;
            this.debtRegRegbtn.Location = new System.Drawing.Point(144, 219);
            this.debtRegRegbtn.Name = "debtRegRegbtn";
            this.debtRegRegbtn.Size = new System.Drawing.Size(104, 34);
            this.debtRegRegbtn.TabIndex = 7;
            this.debtRegRegbtn.Text = "Register";
            this.debtRegRegbtn.UseVisualStyleBackColor = false;
            this.debtRegRegbtn.Click += new System.EventHandler(this.debtRegRegbtn_Click);
            // 
            // debtRegCanclebtn
            // 
            this.debtRegCanclebtn.BackColor = System.Drawing.Color.Teal;
            this.debtRegCanclebtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.debtRegCanclebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debtRegCanclebtn.ForeColor = System.Drawing.Color.White;
            this.debtRegCanclebtn.Location = new System.Drawing.Point(267, 219);
            this.debtRegCanclebtn.Name = "debtRegCanclebtn";
            this.debtRegCanclebtn.Size = new System.Drawing.Size(104, 34);
            this.debtRegCanclebtn.TabIndex = 8;
            this.debtRegCanclebtn.Text = "Cancle";
            this.debtRegCanclebtn.UseVisualStyleBackColor = false;
            this.debtRegCanclebtn.Click += new System.EventHandler(this.debtRegCanclebtn_Click);
            // 
            // debtAddPhone2btn
            // 
            this.debtAddPhone2btn.BackColor = System.Drawing.Color.Teal;
            this.debtAddPhone2btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debtAddPhone2btn.ForeColor = System.Drawing.Color.White;
            this.debtAddPhone2btn.Location = new System.Drawing.Point(305, 94);
            this.debtAddPhone2btn.Name = "debtAddPhone2btn";
            this.debtAddPhone2btn.Size = new System.Drawing.Size(25, 25);
            this.debtAddPhone2btn.TabIndex = 3;
            this.debtAddPhone2btn.Text = "+";
            this.debtAddPhone2btn.UseVisualStyleBackColor = false;
            this.debtAddPhone2btn.Click += new System.EventHandler(this.debtAddPhone2btn_Click);
            // 
            // DebtRegFrm
            // 
            this.AcceptButton = this.debtRegRegbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.CancelButton = this.debtRegCanclebtn;
            this.ClientSize = new System.Drawing.Size(512, 263);
            this.Controls.Add(this.debtAddPhone2btn);
            this.Controls.Add(this.debtRegCanclebtn);
            this.Controls.Add(this.debtRegRegbtn);
            this.Controls.Add(this.debtRegPhone2txt);
            this.Controls.Add(this.debtRegMaxDebttxt);
            this.Controls.Add(this.debtRegISSNtxt);
            this.Controls.Add(this.debtRegPhone1txt);
            this.Controls.Add(this.debtRegAddtxt);
            this.Controls.Add(this.debtRegNametxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DebtRegFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Debtor Registeration";
            this.Load += new System.EventHandler(this.DebtRegFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox debtRegNametxt;
        private System.Windows.Forms.TextBox debtRegAddtxt;
        private System.Windows.Forms.TextBox debtRegPhone1txt;
        private System.Windows.Forms.TextBox debtRegISSNtxt;
        private System.Windows.Forms.TextBox debtRegMaxDebttxt;
        private System.Windows.Forms.TextBox debtRegPhone2txt;
        private System.Windows.Forms.Button debtRegRegbtn;
        private System.Windows.Forms.Button debtRegCanclebtn;
        private System.Windows.Forms.Button debtAddPhone2btn;
    }
}