namespace Phamacy_Management_System
{
    partial class DebtEditFrm
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
            this.debtShowInfobtn = new System.Windows.Forms.Button();
            this.debtNameShowInfotxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.debtEditPhone2txt = new System.Windows.Forms.TextBox();
            this.debtEditMaxDebttxt = new System.Windows.Forms.TextBox();
            this.debtEditIDcardtxt = new System.Windows.Forms.TextBox();
            this.debtEditPhone1txt = new System.Windows.Forms.TextBox();
            this.debtEditAddtxt = new System.Windows.Forms.TextBox();
            this.debtEditNametxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.debtInfoUpdatebtn = new System.Windows.Forms.Button();
            this.debtInfoDeletebtn = new System.Windows.Forms.Button();
            this.debtEditCanclebtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.debtIDShowInfotxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // debtShowInfobtn
            // 
            this.debtShowInfobtn.BackColor = System.Drawing.Color.Teal;
            this.debtShowInfobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debtShowInfobtn.ForeColor = System.Drawing.Color.White;
            this.debtShowInfobtn.Location = new System.Drawing.Point(401, 34);
            this.debtShowInfobtn.Name = "debtShowInfobtn";
            this.debtShowInfobtn.Size = new System.Drawing.Size(85, 34);
            this.debtShowInfobtn.TabIndex = 2;
            this.debtShowInfobtn.Text = "Show info";
            this.debtShowInfobtn.UseVisualStyleBackColor = false;
            this.debtShowInfobtn.Click += new System.EventHandler(this.debtShowInfobtn_Click);
            // 
            // debtNameShowInfotxt
            // 
            this.debtNameShowInfotxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.debtNameShowInfotxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.debtNameShowInfotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debtNameShowInfotxt.ForeColor = System.Drawing.Color.Black;
            this.debtNameShowInfotxt.Location = new System.Drawing.Point(148, 58);
            this.debtNameShowInfotxt.MaxLength = 50;
            this.debtNameShowInfotxt.Name = "debtNameShowInfotxt";
            this.debtNameShowInfotxt.Size = new System.Drawing.Size(242, 22);
            this.debtNameShowInfotxt.TabIndex = 0;
            this.debtNameShowInfotxt.TextChanged += new System.EventHandler(this.showInfoBtnValidation);
            this.debtNameShowInfotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.debtNameShowInfotxt_KeyPress);
            this.debtNameShowInfotxt.Validating += new System.ComponentModel.CancelEventHandler(this.debtShowInfoValidating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(4, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Debtor Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.debtEditPhone2txt);
            this.groupBox1.Controls.Add(this.debtEditMaxDebttxt);
            this.groupBox1.Controls.Add(this.debtEditIDcardtxt);
            this.groupBox1.Controls.Add(this.debtEditPhone1txt);
            this.groupBox1.Controls.Add(this.debtEditAddtxt);
            this.groupBox1.Controls.Add(this.debtEditNametxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(26, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 208);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Debtor Info";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(268, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Phone2";
            // 
            // debtEditPhone2txt
            // 
            this.debtEditPhone2txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debtEditPhone2txt.ForeColor = System.Drawing.Color.Black;
            this.debtEditPhone2txt.Location = new System.Drawing.Point(335, 99);
            this.debtEditPhone2txt.MaxLength = 15;
            this.debtEditPhone2txt.Name = "debtEditPhone2txt";
            this.debtEditPhone2txt.Size = new System.Drawing.Size(132, 22);
            this.debtEditPhone2txt.TabIndex = 6;
            this.debtEditPhone2txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.debtPhonesKeyPress);
            // 
            // debtEditMaxDebttxt
            // 
            this.debtEditMaxDebttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debtEditMaxDebttxt.ForeColor = System.Drawing.Color.Black;
            this.debtEditMaxDebttxt.Location = new System.Drawing.Point(113, 173);
            this.debtEditMaxDebttxt.Name = "debtEditMaxDebttxt";
            this.debtEditMaxDebttxt.Size = new System.Drawing.Size(150, 22);
            this.debtEditMaxDebttxt.TabIndex = 8;
            this.debtEditMaxDebttxt.TextChanged += new System.EventHandler(this.debtUpdateTextChanged);
            this.debtEditMaxDebttxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.debtMoneyKeyPress);
            this.debtEditMaxDebttxt.Validating += new System.ComponentModel.CancelEventHandler(this.debtUpdateValidating);
            // 
            // debtEditIDcardtxt
            // 
            this.debtEditIDcardtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debtEditIDcardtxt.ForeColor = System.Drawing.Color.Black;
            this.debtEditIDcardtxt.Location = new System.Drawing.Point(113, 135);
            this.debtEditIDcardtxt.Name = "debtEditIDcardtxt";
            this.debtEditIDcardtxt.Size = new System.Drawing.Size(150, 22);
            this.debtEditIDcardtxt.TabIndex = 7;
            this.debtEditIDcardtxt.TextChanged += new System.EventHandler(this.debtUpdateTextChanged);
            this.debtEditIDcardtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.debtEditIDcardtxt_KeyPress);
            this.debtEditIDcardtxt.Validating += new System.ComponentModel.CancelEventHandler(this.debtUpdateValidating);
            // 
            // debtEditPhone1txt
            // 
            this.debtEditPhone1txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debtEditPhone1txt.ForeColor = System.Drawing.Color.Black;
            this.debtEditPhone1txt.Location = new System.Drawing.Point(113, 99);
            this.debtEditPhone1txt.MaxLength = 15;
            this.debtEditPhone1txt.Name = "debtEditPhone1txt";
            this.debtEditPhone1txt.Size = new System.Drawing.Size(149, 22);
            this.debtEditPhone1txt.TabIndex = 5;
            this.debtEditPhone1txt.TextChanged += new System.EventHandler(this.debtUpdateTextChanged);
            this.debtEditPhone1txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.debtPhonesKeyPress);
            this.debtEditPhone1txt.Validating += new System.ComponentModel.CancelEventHandler(this.debtUpdateValidating);
            // 
            // debtEditAddtxt
            // 
            this.debtEditAddtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debtEditAddtxt.ForeColor = System.Drawing.Color.Black;
            this.debtEditAddtxt.Location = new System.Drawing.Point(113, 61);
            this.debtEditAddtxt.MaxLength = 60;
            this.debtEditAddtxt.Name = "debtEditAddtxt";
            this.debtEditAddtxt.Size = new System.Drawing.Size(354, 22);
            this.debtEditAddtxt.TabIndex = 4;
            this.debtEditAddtxt.TextChanged += new System.EventHandler(this.debtUpdateTextChanged);
            this.debtEditAddtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.debtEditAddtxt_KeyPress);
            this.debtEditAddtxt.Validating += new System.ComponentModel.CancelEventHandler(this.debtUpdateValidating);
            // 
            // debtEditNametxt
            // 
            this.debtEditNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debtEditNametxt.ForeColor = System.Drawing.Color.Black;
            this.debtEditNametxt.Location = new System.Drawing.Point(113, 24);
            this.debtEditNametxt.MaxLength = 50;
            this.debtEditNametxt.Name = "debtEditNametxt";
            this.debtEditNametxt.Size = new System.Drawing.Size(354, 22);
            this.debtEditNametxt.TabIndex = 3;
            this.debtEditNametxt.TextChanged += new System.EventHandler(this.debtUpdateTextChanged);
            this.debtEditNametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.debtEditNametxt_KeyPress);
            this.debtEditNametxt.Validating += new System.ComponentModel.CancelEventHandler(this.debtUpdateValidating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(7, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Max Debt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(7, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "SSN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(7, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Debtor Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Debtor Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(7, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Debtor Name";
            // 
            // debtInfoUpdatebtn
            // 
            this.debtInfoUpdatebtn.BackColor = System.Drawing.Color.Teal;
            this.debtInfoUpdatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debtInfoUpdatebtn.ForeColor = System.Drawing.Color.White;
            this.debtInfoUpdatebtn.Location = new System.Drawing.Point(113, 349);
            this.debtInfoUpdatebtn.Name = "debtInfoUpdatebtn";
            this.debtInfoUpdatebtn.Size = new System.Drawing.Size(91, 35);
            this.debtInfoUpdatebtn.TabIndex = 9;
            this.debtInfoUpdatebtn.Text = "Update";
            this.debtInfoUpdatebtn.UseVisualStyleBackColor = false;
            this.debtInfoUpdatebtn.Click += new System.EventHandler(this.debtInfoUpdatebtn_Click);
            // 
            // debtInfoDeletebtn
            // 
            this.debtInfoDeletebtn.BackColor = System.Drawing.Color.Teal;
            this.debtInfoDeletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debtInfoDeletebtn.ForeColor = System.Drawing.Color.White;
            this.debtInfoDeletebtn.Location = new System.Drawing.Point(220, 349);
            this.debtInfoDeletebtn.Name = "debtInfoDeletebtn";
            this.debtInfoDeletebtn.Size = new System.Drawing.Size(91, 35);
            this.debtInfoDeletebtn.TabIndex = 10;
            this.debtInfoDeletebtn.Text = "Delete";
            this.debtInfoDeletebtn.UseVisualStyleBackColor = false;
            this.debtInfoDeletebtn.Click += new System.EventHandler(this.debtInfoDeletebtn_Click);
            // 
            // debtEditCanclebtn
            // 
            this.debtEditCanclebtn.BackColor = System.Drawing.Color.Teal;
            this.debtEditCanclebtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.debtEditCanclebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debtEditCanclebtn.ForeColor = System.Drawing.Color.White;
            this.debtEditCanclebtn.Location = new System.Drawing.Point(327, 349);
            this.debtEditCanclebtn.Name = "debtEditCanclebtn";
            this.debtEditCanclebtn.Size = new System.Drawing.Size(91, 35);
            this.debtEditCanclebtn.TabIndex = 11;
            this.debtEditCanclebtn.Text = "Cancle";
            this.debtEditCanclebtn.UseVisualStyleBackColor = false;
            this.debtEditCanclebtn.Click += new System.EventHandler(this.debtEditCanclebtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(4, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Enter Debtor ID";
            // 
            // debtIDShowInfotxt
            // 
            this.debtIDShowInfotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debtIDShowInfotxt.ForeColor = System.Drawing.Color.Black;
            this.debtIDShowInfotxt.Location = new System.Drawing.Point(148, 30);
            this.debtIDShowInfotxt.Name = "debtIDShowInfotxt";
            this.debtIDShowInfotxt.Size = new System.Drawing.Size(242, 22);
            this.debtIDShowInfotxt.TabIndex = 1;
            this.debtIDShowInfotxt.TextChanged += new System.EventHandler(this.showInfoBtnValidation);
            this.debtIDShowInfotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.debtIDShowInfotxt_KeyPress);
            this.debtIDShowInfotxt.Validating += new System.ComponentModel.CancelEventHandler(this.debtShowInfoValidating);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.debtIDShowInfotxt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.debtNameShowInfotxt);
            this.groupBox2.Controls.Add(this.debtShowInfobtn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox2.Location = new System.Drawing.Point(29, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 100);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search For Debtor ";
            // 
            // DebtEditFrm
            // 
            this.AcceptButton = this.debtShowInfobtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.CancelButton = this.debtEditCanclebtn;
            this.ClientSize = new System.Drawing.Size(537, 397);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.debtEditCanclebtn);
            this.Controls.Add(this.debtInfoDeletebtn);
            this.Controls.Add(this.debtInfoUpdatebtn);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DebtEditFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Debtor";
            this.Load += new System.EventHandler(this.DebtEditFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button debtShowInfobtn;
        private System.Windows.Forms.TextBox debtNameShowInfotxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox debtEditPhone2txt;
        private System.Windows.Forms.TextBox debtEditMaxDebttxt;
        private System.Windows.Forms.TextBox debtEditIDcardtxt;
        private System.Windows.Forms.TextBox debtEditPhone1txt;
        private System.Windows.Forms.TextBox debtEditAddtxt;
        private System.Windows.Forms.TextBox debtEditNametxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button debtInfoUpdatebtn;
        private System.Windows.Forms.Button debtInfoDeletebtn;
        private System.Windows.Forms.Button debtEditCanclebtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox debtIDShowInfotxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}