namespace Phamacy_Management_System
{
    partial class DelRegFrm
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
            this.delRegPhone2txt = new System.Windows.Forms.TextBox();
            this.delRegPhone1txt = new System.Windows.Forms.TextBox();
            this.delRegAddtxt = new System.Windows.Forms.TextBox();
            this.delRegNametxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.delRegbtn = new System.Windows.Forms.Button();
            this.delAddPhone2btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.compcmbo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // delRegPhone2txt
            // 
            this.delRegPhone2txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delRegPhone2txt.ForeColor = System.Drawing.Color.Black;
            this.delRegPhone2txt.Location = new System.Drawing.Point(368, 94);
            this.delRegPhone2txt.MaxLength = 15;
            this.delRegPhone2txt.Name = "delRegPhone2txt";
            this.delRegPhone2txt.Size = new System.Drawing.Size(166, 22);
            this.delRegPhone2txt.TabIndex = 4;
            this.delRegPhone2txt.Visible = false;
            this.delRegPhone2txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.delPhonesKeyPress);
            // 
            // delRegPhone1txt
            // 
            this.delRegPhone1txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delRegPhone1txt.ForeColor = System.Drawing.Color.Black;
            this.delRegPhone1txt.Location = new System.Drawing.Point(144, 94);
            this.delRegPhone1txt.MaxLength = 15;
            this.delRegPhone1txt.Name = "delRegPhone1txt";
            this.delRegPhone1txt.Size = new System.Drawing.Size(179, 22);
            this.delRegPhone1txt.TabIndex = 2;
            this.delRegPhone1txt.TextChanged += new System.EventHandler(this.delRegTextChanged);
            this.delRegPhone1txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.delPhonesKeyPress);
            this.delRegPhone1txt.Validating += new System.ComponentModel.CancelEventHandler(this.delRegTextValidating);
            // 
            // delRegAddtxt
            // 
            this.delRegAddtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delRegAddtxt.ForeColor = System.Drawing.Color.Black;
            this.delRegAddtxt.Location = new System.Drawing.Point(144, 61);
            this.delRegAddtxt.MaxLength = 60;
            this.delRegAddtxt.Name = "delRegAddtxt";
            this.delRegAddtxt.Size = new System.Drawing.Size(390, 22);
            this.delRegAddtxt.TabIndex = 1;
            this.delRegAddtxt.TextChanged += new System.EventHandler(this.delRegTextChanged);
            this.delRegAddtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.delRegAddtxt_KeyPress);
            this.delRegAddtxt.Validating += new System.ComponentModel.CancelEventHandler(this.delRegTextValidating);
            // 
            // delRegNametxt
            // 
            this.delRegNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delRegNametxt.ForeColor = System.Drawing.Color.Black;
            this.delRegNametxt.Location = new System.Drawing.Point(144, 26);
            this.delRegNametxt.MaxLength = 50;
            this.delRegNametxt.Name = "delRegNametxt";
            this.delRegNametxt.Size = new System.Drawing.Size(390, 22);
            this.delRegNametxt.TabIndex = 0;
            this.delRegNametxt.TextChanged += new System.EventHandler(this.delRegTextChanged);
            this.delRegNametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.delRegNametxt_KeyPress);
            this.delRegNametxt.Validating += new System.ComponentModel.CancelEventHandler(this.delRegTextValidating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(6, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Delegate Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(6, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Delegate Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Delegate Name";
            // 
            // delRegbtn
            // 
            this.delRegbtn.BackColor = System.Drawing.Color.Teal;
            this.delRegbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delRegbtn.ForeColor = System.Drawing.Color.White;
            this.delRegbtn.Location = new System.Drawing.Point(411, 132);
            this.delRegbtn.Name = "delRegbtn";
            this.delRegbtn.Size = new System.Drawing.Size(97, 37);
            this.delRegbtn.TabIndex = 6;
            this.delRegbtn.Text = "Register";
            this.delRegbtn.UseVisualStyleBackColor = false;
            this.delRegbtn.Click += new System.EventHandler(this.delRegbtn_Click);
            // 
            // delAddPhone2btn
            // 
            this.delAddPhone2btn.BackColor = System.Drawing.Color.Teal;
            this.delAddPhone2btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delAddPhone2btn.ForeColor = System.Drawing.Color.White;
            this.delAddPhone2btn.Location = new System.Drawing.Point(333, 92);
            this.delAddPhone2btn.Name = "delAddPhone2btn";
            this.delAddPhone2btn.Size = new System.Drawing.Size(25, 25);
            this.delAddPhone2btn.TabIndex = 3;
            this.delAddPhone2btn.Text = "+";
            this.delAddPhone2btn.UseVisualStyleBackColor = false;
            this.delAddPhone2btn.Click += new System.EventHandler(this.delAddPhone2btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(6, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Company";
            // 
            // compcmbo
            // 
            this.compcmbo.BackColor = System.Drawing.Color.Teal;
            this.compcmbo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.compcmbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.compcmbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compcmbo.ForeColor = System.Drawing.Color.White;
            this.compcmbo.FormattingEnabled = true;
            this.compcmbo.Location = new System.Drawing.Point(144, 129);
            this.compcmbo.Name = "compcmbo";
            this.compcmbo.Size = new System.Drawing.Size(214, 24);
            this.compcmbo.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.delRegbtn);
            this.groupBox1.Controls.Add(this.compcmbo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.delAddPhone2btn);
            this.groupBox1.Controls.Add(this.delRegNametxt);
            this.groupBox1.Controls.Add(this.delRegAddtxt);
            this.groupBox1.Controls.Add(this.delRegPhone2txt);
            this.groupBox1.Controls.Add(this.delRegPhone1txt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 201);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delegate Data";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(174, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(221, 24);
            this.label10.TabIndex = 27;
            this.label10.Text = "Delegate Registeration";
            // 
            // DelRegFrm
            // 
            this.AcceptButton = this.delRegbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(574, 261);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DelRegFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delegate Registeration";
            this.Load += new System.EventHandler(this.DelRegFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox delRegPhone2txt;
        private System.Windows.Forms.TextBox delRegPhone1txt;
        private System.Windows.Forms.TextBox delRegAddtxt;
        private System.Windows.Forms.TextBox delRegNametxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button delRegbtn;
        private System.Windows.Forms.Button delAddPhone2btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox compcmbo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;

    }
}