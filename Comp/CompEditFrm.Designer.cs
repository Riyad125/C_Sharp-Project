namespace Phamacy_Management_System
{
    partial class CompEditFrm
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
            this.compShowInfobtn = new System.Windows.Forms.Button();
            this.compNameShowInfotxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.compEditPhone2txt = new System.Windows.Forms.TextBox();
            this.compEditEmailtxt = new System.Windows.Forms.TextBox();
            this.compEditPhone1txt = new System.Windows.Forms.TextBox();
            this.compEditAddtxt = new System.Windows.Forms.TextBox();
            this.compEditNametxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.compInfoUpdatebtn = new System.Windows.Forms.Button();
            this.compEditCanclebtn = new System.Windows.Forms.Button();
            this.compInfoDeletebtn = new System.Windows.Forms.Button();
            this.compDelcombox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.compIDShowInfotxt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // compShowInfobtn
            // 
            this.compShowInfobtn.BackColor = System.Drawing.Color.Teal;
            this.compShowInfobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compShowInfobtn.ForeColor = System.Drawing.Color.White;
            this.compShowInfobtn.Location = new System.Drawing.Point(467, 36);
            this.compShowInfobtn.Name = "compShowInfobtn";
            this.compShowInfobtn.Size = new System.Drawing.Size(84, 28);
            this.compShowInfobtn.TabIndex = 2;
            this.compShowInfobtn.Text = "Show info";
            this.compShowInfobtn.UseVisualStyleBackColor = false;
            this.compShowInfobtn.Click += new System.EventHandler(this.compShowInfobtn_Click);
            // 
            // compNameShowInfotxt
            // 
            this.compNameShowInfotxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.compNameShowInfotxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.compNameShowInfotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compNameShowInfotxt.ForeColor = System.Drawing.Color.Black;
            this.compNameShowInfotxt.Location = new System.Drawing.Point(169, 59);
            this.compNameShowInfotxt.MaxLength = 30;
            this.compNameShowInfotxt.Name = "compNameShowInfotxt";
            this.compNameShowInfotxt.Size = new System.Drawing.Size(278, 22);
            this.compNameShowInfotxt.TabIndex = 1;
            this.compNameShowInfotxt.TextChanged += new System.EventHandler(this.compEditTextChanged);
            this.compNameShowInfotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.compNameShowInfotxt_KeyPress);
            this.compNameShowInfotxt.Validating += new System.ComponentModel.CancelEventHandler(this.compEditTextValidating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(9, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Company Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.compEditPhone2txt);
            this.groupBox1.Controls.Add(this.compEditEmailtxt);
            this.groupBox1.Controls.Add(this.compEditPhone1txt);
            this.groupBox1.Controls.Add(this.compEditAddtxt);
            this.groupBox1.Controls.Add(this.compEditNametxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(11, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 161);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Company Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(331, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Phone2";
            // 
            // compEditPhone2txt
            // 
            this.compEditPhone2txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compEditPhone2txt.ForeColor = System.Drawing.Color.Black;
            this.compEditPhone2txt.Location = new System.Drawing.Point(400, 90);
            this.compEditPhone2txt.MaxLength = 15;
            this.compEditPhone2txt.Name = "compEditPhone2txt";
            this.compEditPhone2txt.Size = new System.Drawing.Size(144, 22);
            this.compEditPhone2txt.TabIndex = 6;
            this.compEditPhone2txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.compPhonesKeyPress);
            // 
            // compEditEmailtxt
            // 
            this.compEditEmailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compEditEmailtxt.ForeColor = System.Drawing.Color.Black;
            this.compEditEmailtxt.Location = new System.Drawing.Point(150, 121);
            this.compEditEmailtxt.MaxLength = 35;
            this.compEditEmailtxt.Name = "compEditEmailtxt";
            this.compEditEmailtxt.Size = new System.Drawing.Size(394, 22);
            this.compEditEmailtxt.TabIndex = 7;
            this.compEditEmailtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.compEditEmailtxt_KeyPress);
            // 
            // compEditPhone1txt
            // 
            this.compEditPhone1txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compEditPhone1txt.ForeColor = System.Drawing.Color.Black;
            this.compEditPhone1txt.Location = new System.Drawing.Point(150, 90);
            this.compEditPhone1txt.MaxLength = 15;
            this.compEditPhone1txt.Name = "compEditPhone1txt";
            this.compEditPhone1txt.Size = new System.Drawing.Size(144, 22);
            this.compEditPhone1txt.TabIndex = 5;
            this.compEditPhone1txt.TextChanged += new System.EventHandler(this.compInfoUpdateTextChanged);
            this.compEditPhone1txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.compPhonesKeyPress);
            this.compEditPhone1txt.Validating += new System.ComponentModel.CancelEventHandler(this.compInfoUpdateValidating);
            // 
            // compEditAddtxt
            // 
            this.compEditAddtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compEditAddtxt.ForeColor = System.Drawing.Color.Black;
            this.compEditAddtxt.Location = new System.Drawing.Point(150, 58);
            this.compEditAddtxt.MaxLength = 60;
            this.compEditAddtxt.Name = "compEditAddtxt";
            this.compEditAddtxt.Size = new System.Drawing.Size(394, 22);
            this.compEditAddtxt.TabIndex = 4;
            this.compEditAddtxt.TextChanged += new System.EventHandler(this.compInfoUpdateTextChanged);
            this.compEditAddtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.compEditAddtxt_KeyPress);
            this.compEditAddtxt.Validating += new System.ComponentModel.CancelEventHandler(this.compInfoUpdateValidating);
            // 
            // compEditNametxt
            // 
            this.compEditNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compEditNametxt.ForeColor = System.Drawing.Color.Black;
            this.compEditNametxt.Location = new System.Drawing.Point(150, 27);
            this.compEditNametxt.MaxLength = 30;
            this.compEditNametxt.Name = "compEditNametxt";
            this.compEditNametxt.Size = new System.Drawing.Size(394, 22);
            this.compEditNametxt.TabIndex = 3;
            this.compEditNametxt.TextChanged += new System.EventHandler(this.compInfoUpdateTextChanged);
            this.compEditNametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.compEditNametxt_KeyPress);
            this.compEditNametxt.Validating += new System.ComponentModel.CancelEventHandler(this.compInfoUpdateValidating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(11, 124);
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
            this.label3.Location = new System.Drawing.Point(11, 93);
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
            this.label2.Location = new System.Drawing.Point(11, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Company Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(11, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Company Name";
            // 
            // compInfoUpdatebtn
            // 
            this.compInfoUpdatebtn.BackColor = System.Drawing.Color.Teal;
            this.compInfoUpdatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compInfoUpdatebtn.ForeColor = System.Drawing.Color.White;
            this.compInfoUpdatebtn.Location = new System.Drawing.Point(129, 436);
            this.compInfoUpdatebtn.Name = "compInfoUpdatebtn";
            this.compInfoUpdatebtn.Size = new System.Drawing.Size(101, 33);
            this.compInfoUpdatebtn.TabIndex = 11;
            this.compInfoUpdatebtn.Text = "Update";
            this.compInfoUpdatebtn.UseVisualStyleBackColor = false;
            this.compInfoUpdatebtn.Click += new System.EventHandler(this.compInfoUpdatebtn_Click);
            // 
            // compEditCanclebtn
            // 
            this.compEditCanclebtn.BackColor = System.Drawing.Color.Teal;
            this.compEditCanclebtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.compEditCanclebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compEditCanclebtn.ForeColor = System.Drawing.Color.White;
            this.compEditCanclebtn.Location = new System.Drawing.Point(358, 436);
            this.compEditCanclebtn.Name = "compEditCanclebtn";
            this.compEditCanclebtn.Size = new System.Drawing.Size(101, 33);
            this.compEditCanclebtn.TabIndex = 13;
            this.compEditCanclebtn.Text = "Cancle";
            this.compEditCanclebtn.UseVisualStyleBackColor = false;
            this.compEditCanclebtn.Click += new System.EventHandler(this.compEditCanclebtn_Click);
            // 
            // compInfoDeletebtn
            // 
            this.compInfoDeletebtn.BackColor = System.Drawing.Color.Teal;
            this.compInfoDeletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compInfoDeletebtn.ForeColor = System.Drawing.Color.White;
            this.compInfoDeletebtn.Location = new System.Drawing.Point(244, 436);
            this.compInfoDeletebtn.Name = "compInfoDeletebtn";
            this.compInfoDeletebtn.Size = new System.Drawing.Size(101, 33);
            this.compInfoDeletebtn.TabIndex = 12;
            this.compInfoDeletebtn.Text = "Delete";
            this.compInfoDeletebtn.UseVisualStyleBackColor = false;
            this.compInfoDeletebtn.Click += new System.EventHandler(this.compInfoDeletebtn_Click);
            // 
            // compDelcombox
            // 
            this.compDelcombox.BackColor = System.Drawing.Color.Teal;
            this.compDelcombox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.compDelcombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.compDelcombox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compDelcombox.ForeColor = System.Drawing.Color.White;
            this.compDelcombox.FormattingEnabled = true;
            this.compDelcombox.Location = new System.Drawing.Point(164, 23);
            this.compDelcombox.Name = "compDelcombox";
            this.compDelcombox.Size = new System.Drawing.Size(138, 24);
            this.compDelcombox.TabIndex = 8;
            this.compDelcombox.SelectedIndexChanged += new System.EventHandler(this.compDelcombox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(13, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Company delegates";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.compDelcombox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox2.Location = new System.Drawing.Point(11, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 112);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delegates Data";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(295, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 31);
            this.button2.TabIndex = 10;
            this.button2.Text = "Edit Delegate";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(134, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "New Delegate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(9, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Enter Company ID";
            // 
            // compIDShowInfotxt
            // 
            this.compIDShowInfotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compIDShowInfotxt.ForeColor = System.Drawing.Color.Black;
            this.compIDShowInfotxt.Location = new System.Drawing.Point(169, 28);
            this.compIDShowInfotxt.Name = "compIDShowInfotxt";
            this.compIDShowInfotxt.Size = new System.Drawing.Size(278, 22);
            this.compIDShowInfotxt.TabIndex = 0;
            this.compIDShowInfotxt.TextChanged += new System.EventHandler(this.compEditTextChanged);
            this.compIDShowInfotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.compIDShowInfotxt_KeyPress);
            this.compIDShowInfotxt.Validating += new System.ComponentModel.CancelEventHandler(this.compEditTextValidating);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.compNameShowInfotxt);
            this.groupBox3.Controls.Add(this.compIDShowInfotxt);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.compShowInfobtn);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox3.Location = new System.Drawing.Point(12, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(560, 92);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search For Company";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(223, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "Company Edit";
            // 
            // CompEditFrm
            // 
            this.AcceptButton = this.compShowInfobtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.CancelButton = this.compEditCanclebtn;
            this.ClientSize = new System.Drawing.Size(584, 477);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.compInfoDeletebtn);
            this.Controls.Add(this.compEditCanclebtn);
            this.Controls.Add(this.compInfoUpdatebtn);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CompEditFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company Edit";
            this.Load += new System.EventHandler(this.CompEditFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button compShowInfobtn;
        private System.Windows.Forms.TextBox compNameShowInfotxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox compEditPhone2txt;
        private System.Windows.Forms.TextBox compEditEmailtxt;
        private System.Windows.Forms.TextBox compEditPhone1txt;
        private System.Windows.Forms.TextBox compEditAddtxt;
        private System.Windows.Forms.TextBox compEditNametxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button compInfoUpdatebtn;
        private System.Windows.Forms.Button compEditCanclebtn;
        private System.Windows.Forms.Button compInfoDeletebtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox compIDShowInfotxt;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox compDelcombox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
    }
}