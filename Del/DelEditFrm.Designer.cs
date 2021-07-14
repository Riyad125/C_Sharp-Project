namespace Phamacy_Management_System
{
    partial class DelEditFrm
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
            this.delUpdatebtn = new System.Windows.Forms.Button();
            this.delEditPhone2txt = new System.Windows.Forms.TextBox();
            this.delEditPhone1txt = new System.Windows.Forms.TextBox();
            this.delEditAddtxt = new System.Windows.Forms.TextBox();
            this.delEditNametxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.delCanclebtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // delUpdatebtn
            // 
            this.delUpdatebtn.BackColor = System.Drawing.Color.Teal;
            this.delUpdatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delUpdatebtn.ForeColor = System.Drawing.Color.White;
            this.delUpdatebtn.Location = new System.Drawing.Point(171, 160);
            this.delUpdatebtn.Name = "delUpdatebtn";
            this.delUpdatebtn.Size = new System.Drawing.Size(97, 37);
            this.delUpdatebtn.TabIndex = 4;
            this.delUpdatebtn.Text = "Update";
            this.delUpdatebtn.UseVisualStyleBackColor = false;
            this.delUpdatebtn.Click += new System.EventHandler(this.delUpdatebtn_Click);
            // 
            // delEditPhone2txt
            // 
            this.delEditPhone2txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delEditPhone2txt.ForeColor = System.Drawing.Color.Black;
            this.delEditPhone2txt.Location = new System.Drawing.Point(377, 90);
            this.delEditPhone2txt.MaxLength = 15;
            this.delEditPhone2txt.Name = "delEditPhone2txt";
            this.delEditPhone2txt.Size = new System.Drawing.Size(152, 22);
            this.delEditPhone2txt.TabIndex = 3;
            this.delEditPhone2txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.delPhonesKeyPress);
            // 
            // delEditPhone1txt
            // 
            this.delEditPhone1txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delEditPhone1txt.ForeColor = System.Drawing.Color.Black;
            this.delEditPhone1txt.Location = new System.Drawing.Point(157, 103);
            this.delEditPhone1txt.MaxLength = 15;
            this.delEditPhone1txt.Name = "delEditPhone1txt";
            this.delEditPhone1txt.Size = new System.Drawing.Size(138, 22);
            this.delEditPhone1txt.TabIndex = 2;
            this.delEditPhone1txt.TextChanged += new System.EventHandler(this.delUpdateTextChanged);
            this.delEditPhone1txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.delPhonesKeyPress);
            this.delEditPhone1txt.Validating += new System.ComponentModel.CancelEventHandler(this.delUpdateTextValidating);
            // 
            // delEditAddtxt
            // 
            this.delEditAddtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delEditAddtxt.ForeColor = System.Drawing.Color.Black;
            this.delEditAddtxt.Location = new System.Drawing.Point(157, 73);
            this.delEditAddtxt.MaxLength = 60;
            this.delEditAddtxt.Name = "delEditAddtxt";
            this.delEditAddtxt.Size = new System.Drawing.Size(386, 22);
            this.delEditAddtxt.TabIndex = 1;
            this.delEditAddtxt.TextChanged += new System.EventHandler(this.delUpdateTextChanged);
            this.delEditAddtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.delEditAddtxt_KeyPress);
            this.delEditAddtxt.Validating += new System.ComponentModel.CancelEventHandler(this.delUpdateTextValidating);
            // 
            // delEditNametxt
            // 
            this.delEditNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delEditNametxt.ForeColor = System.Drawing.Color.Black;
            this.delEditNametxt.Location = new System.Drawing.Point(157, 40);
            this.delEditNametxt.MaxLength = 50;
            this.delEditNametxt.Name = "delEditNametxt";
            this.delEditNametxt.Size = new System.Drawing.Size(386, 22);
            this.delEditNametxt.TabIndex = 0;
            this.delEditNametxt.TextChanged += new System.EventHandler(this.delUpdateTextChanged);
            this.delEditNametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.delEditNametxt_KeyPress);
            this.delEditNametxt.Validating += new System.ComponentModel.CancelEventHandler(this.delUpdateTextValidating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(21, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Delegate Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(21, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Delegate Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(21, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Delegate Name";
            // 
            // delCanclebtn
            // 
            this.delCanclebtn.BackColor = System.Drawing.Color.Teal;
            this.delCanclebtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.delCanclebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delCanclebtn.ForeColor = System.Drawing.Color.White;
            this.delCanclebtn.Location = new System.Drawing.Point(286, 160);
            this.delCanclebtn.Name = "delCanclebtn";
            this.delCanclebtn.Size = new System.Drawing.Size(97, 37);
            this.delCanclebtn.TabIndex = 5;
            this.delCanclebtn.Text = "Cancle";
            this.delCanclebtn.UseVisualStyleBackColor = false;
            this.delCanclebtn.Click += new System.EventHandler(this.delCanclebtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.delEditPhone2txt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 129);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delegate Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(311, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Phone2";
            // 
            // DelEditFrm
            // 
            this.AcceptButton = this.delUpdatebtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.CancelButton = this.delCanclebtn;
            this.ClientSize = new System.Drawing.Size(571, 214);
            this.Controls.Add(this.delCanclebtn);
            this.Controls.Add(this.delUpdatebtn);
            this.Controls.Add(this.delEditPhone1txt);
            this.Controls.Add(this.delEditAddtxt);
            this.Controls.Add(this.delEditNametxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DelEditFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Delegate";
            this.Load += new System.EventHandler(this.DelEditFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delUpdatebtn;
        private System.Windows.Forms.TextBox delEditPhone2txt;
        private System.Windows.Forms.TextBox delEditPhone1txt;
        private System.Windows.Forms.TextBox delEditAddtxt;
        private System.Windows.Forms.TextBox delEditNametxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button delCanclebtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;

    }
}