namespace Phamacy_Management_System
{
    partial class EmpRegFrm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.empAddPhone2btn = new System.Windows.Forms.Button();
            this.empRegPhone2txt = new System.Windows.Forms.TextBox();
            this.empRegBdatePicker = new System.Windows.Forms.DateTimePicker();
            this.empRegQualftxt = new System.Windows.Forms.TextBox();
            this.empRegEmailtxt = new System.Windows.Forms.TextBox();
            this.empRegSSNtxt = new System.Windows.Forms.TextBox();
            this.empRegPhone1txt = new System.Windows.Forms.TextBox();
            this.empRegAddtxt = new System.Windows.Forms.TextBox();
            this.empRegNametxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.empRegPasstxt = new System.Windows.Forms.TextBox();
            this.empRegIdtxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.empPermrdb = new System.Windows.Forms.RadioButton();
            this.mangPermrdb = new System.Windows.Forms.RadioButton();
            this.empRegRegbtn = new System.Windows.Forms.Button();
            this.canclebtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.empAddPhone2btn);
            this.groupBox1.Controls.Add(this.empRegPhone2txt);
            this.groupBox1.Controls.Add(this.empRegBdatePicker);
            this.groupBox1.Controls.Add(this.empRegQualftxt);
            this.groupBox1.Controls.Add(this.empRegEmailtxt);
            this.groupBox1.Controls.Add(this.empRegSSNtxt);
            this.groupBox1.Controls.Add(this.empRegPhone1txt);
            this.groupBox1.Controls.Add(this.empRegAddtxt);
            this.groupBox1.Controls.Add(this.empRegNametxt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(13, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 299);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Data";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // empAddPhone2btn
            // 
            this.empAddPhone2btn.BackColor = System.Drawing.Color.Teal;
            this.empAddPhone2btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empAddPhone2btn.ForeColor = System.Drawing.Color.White;
            this.empAddPhone2btn.Location = new System.Drawing.Point(298, 127);
            this.empAddPhone2btn.Name = "empAddPhone2btn";
            this.empAddPhone2btn.Size = new System.Drawing.Size(25, 25);
            this.empAddPhone2btn.TabIndex = 17;
            this.empAddPhone2btn.Text = "+";
            this.empAddPhone2btn.UseVisualStyleBackColor = false;
            this.empAddPhone2btn.Click += new System.EventHandler(this.empAddPhone2btn_Click);
            // 
            // empRegPhone2txt
            // 
            this.empRegPhone2txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empRegPhone2txt.ForeColor = System.Drawing.Color.Black;
            this.empRegPhone2txt.Location = new System.Drawing.Point(330, 130);
            this.empRegPhone2txt.Name = "empRegPhone2txt";
            this.empRegPhone2txt.Size = new System.Drawing.Size(178, 22);
            this.empRegPhone2txt.TabIndex = 4;
            this.empRegPhone2txt.Visible = false;
            this.empRegPhone2txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.empPhonesKeyPress);
            // 
            // empRegBdatePicker
            // 
            this.empRegBdatePicker.CalendarForeColor = System.Drawing.Color.SkyBlue;
            this.empRegBdatePicker.CalendarTitleForeColor = System.Drawing.Color.SkyBlue;
            this.empRegBdatePicker.CalendarTrailingForeColor = System.Drawing.Color.DarkRed;
            this.empRegBdatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empRegBdatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.empRegBdatePicker.Location = new System.Drawing.Point(108, 91);
            this.empRegBdatePicker.Name = "empRegBdatePicker";
            this.empRegBdatePicker.Size = new System.Drawing.Size(200, 22);
            this.empRegBdatePicker.TabIndex = 2;
            // 
            // empRegQualftxt
            // 
            this.empRegQualftxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empRegQualftxt.ForeColor = System.Drawing.Color.Black;
            this.empRegQualftxt.Location = new System.Drawing.Point(108, 236);
            this.empRegQualftxt.Multiline = true;
            this.empRegQualftxt.Name = "empRegQualftxt";
            this.empRegQualftxt.Size = new System.Drawing.Size(363, 49);
            this.empRegQualftxt.TabIndex = 7;
            this.empRegQualftxt.TextChanged += new System.EventHandler(this.textChangedEvent);
            this.empRegQualftxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.empRegQualftxt_KeyPress);
            this.empRegQualftxt.Validating += new System.ComponentModel.CancelEventHandler(this.textValidatingEvent);
            // 
            // empRegEmailtxt
            // 
            this.empRegEmailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empRegEmailtxt.ForeColor = System.Drawing.Color.Black;
            this.empRegEmailtxt.Location = new System.Drawing.Point(108, 200);
            this.empRegEmailtxt.Name = "empRegEmailtxt";
            this.empRegEmailtxt.Size = new System.Drawing.Size(363, 22);
            this.empRegEmailtxt.TabIndex = 6;
            this.empRegEmailtxt.TextChanged += new System.EventHandler(this.empRegEmailtxt_TextChanged);
            this.empRegEmailtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.empRegEmailtxt_KeyPress);
            this.empRegEmailtxt.Leave += new System.EventHandler(this.empRegEmailtxt_Leave);
            this.empRegEmailtxt.MouseLeave += new System.EventHandler(this.empRegEmailtxt_MouseLeave);
            // 
            // empRegSSNtxt
            // 
            this.empRegSSNtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empRegSSNtxt.ForeColor = System.Drawing.Color.Black;
            this.empRegSSNtxt.Location = new System.Drawing.Point(108, 167);
            this.empRegSSNtxt.Name = "empRegSSNtxt";
            this.empRegSSNtxt.Size = new System.Drawing.Size(178, 22);
            this.empRegSSNtxt.TabIndex = 5;
            this.empRegSSNtxt.TextChanged += new System.EventHandler(this.textChangedEvent);
            this.empRegSSNtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.empRegSSNtxt_KeyPress);
            this.empRegSSNtxt.Validating += new System.ComponentModel.CancelEventHandler(this.textValidatingEvent);
            // 
            // empRegPhone1txt
            // 
            this.empRegPhone1txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empRegPhone1txt.ForeColor = System.Drawing.Color.Black;
            this.empRegPhone1txt.Location = new System.Drawing.Point(108, 130);
            this.empRegPhone1txt.Name = "empRegPhone1txt";
            this.empRegPhone1txt.Size = new System.Drawing.Size(178, 22);
            this.empRegPhone1txt.TabIndex = 3;
            this.empRegPhone1txt.TextChanged += new System.EventHandler(this.textChangedEvent);
            this.empRegPhone1txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.empPhonesKeyPress);
            this.empRegPhone1txt.Validating += new System.ComponentModel.CancelEventHandler(this.textValidatingEvent);
            // 
            // empRegAddtxt
            // 
            this.empRegAddtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empRegAddtxt.ForeColor = System.Drawing.Color.Black;
            this.empRegAddtxt.Location = new System.Drawing.Point(108, 57);
            this.empRegAddtxt.MaxLength = 60;
            this.empRegAddtxt.Name = "empRegAddtxt";
            this.empRegAddtxt.Size = new System.Drawing.Size(363, 22);
            this.empRegAddtxt.TabIndex = 1;
            this.empRegAddtxt.TextChanged += new System.EventHandler(this.textChangedEvent);
            this.empRegAddtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.empRegAddtxt_KeyPress);
            this.empRegAddtxt.Validating += new System.ComponentModel.CancelEventHandler(this.textValidatingEvent);
            // 
            // empRegNametxt
            // 
            this.empRegNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empRegNametxt.ForeColor = System.Drawing.Color.Black;
            this.empRegNametxt.Location = new System.Drawing.Point(108, 27);
            this.empRegNametxt.MaxLength = 50;
            this.empRegNametxt.Name = "empRegNametxt";
            this.empRegNametxt.Size = new System.Drawing.Size(363, 22);
            this.empRegNametxt.TabIndex = 0;
            this.empRegNametxt.TextChanged += new System.EventHandler(this.textChangedEvent);
            this.empRegNametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.empRegNametxt_KeyPress);
            this.empRegNametxt.Validating += new System.ComponentModel.CancelEventHandler(this.textValidatingEvent);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(12, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Qualification";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(13, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(13, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "SSN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(13, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(13, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bdate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.empRegPasstxt);
            this.groupBox2.Controls.Add(this.empRegIdtxt);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox2.Location = new System.Drawing.Point(13, 364);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(522, 63);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Login Data";
            // 
            // empRegPasstxt
            // 
            this.empRegPasstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empRegPasstxt.ForeColor = System.Drawing.Color.Black;
            this.empRegPasstxt.Location = new System.Drawing.Point(355, 26);
            this.empRegPasstxt.Name = "empRegPasstxt";
            this.empRegPasstxt.Size = new System.Drawing.Size(147, 22);
            this.empRegPasstxt.TabIndex = 8;
            this.empRegPasstxt.TextChanged += new System.EventHandler(this.textChangedEvent);
            this.empRegPasstxt.Validating += new System.ComponentModel.CancelEventHandler(this.textValidatingEvent);
            // 
            // empRegIdtxt
            // 
            this.empRegIdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empRegIdtxt.ForeColor = System.Drawing.Color.SkyBlue;
            this.empRegIdtxt.Location = new System.Drawing.Point(111, 26);
            this.empRegIdtxt.Name = "empRegIdtxt";
            this.empRegIdtxt.ReadOnly = true;
            this.empRegIdtxt.Size = new System.Drawing.Size(147, 22);
            this.empRegIdtxt.TabIndex = 2;
            this.empRegIdtxt.TextChanged += new System.EventHandler(this.empRegIdtxt_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(277, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(12, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Employee ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.empPermrdb);
            this.groupBox3.Controls.Add(this.mangPermrdb);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox3.Location = new System.Drawing.Point(13, 436);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(522, 53);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Permissions";
            // 
            // empPermrdb
            // 
            this.empPermrdb.AutoSize = true;
            this.empPermrdb.Checked = true;
            this.empPermrdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empPermrdb.ForeColor = System.Drawing.Color.Teal;
            this.empPermrdb.Location = new System.Drawing.Point(306, 22);
            this.empPermrdb.Name = "empPermrdb";
            this.empPermrdb.Size = new System.Drawing.Size(96, 20);
            this.empPermrdb.TabIndex = 9;
            this.empPermrdb.TabStop = true;
            this.empPermrdb.Text = "Employee";
            this.empPermrdb.UseVisualStyleBackColor = true;
            this.empPermrdb.CheckedChanged += new System.EventHandler(this.mangPermrdb_CheckedChanged_1);
            // 
            // mangPermrdb
            // 
            this.mangPermrdb.AutoSize = true;
            this.mangPermrdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mangPermrdb.ForeColor = System.Drawing.Color.Teal;
            this.mangPermrdb.Location = new System.Drawing.Point(131, 22);
            this.mangPermrdb.Name = "mangPermrdb";
            this.mangPermrdb.Size = new System.Drawing.Size(87, 20);
            this.mangPermrdb.TabIndex = 10;
            this.mangPermrdb.TabStop = true;
            this.mangPermrdb.Text = "Manager";
            this.mangPermrdb.UseVisualStyleBackColor = true;
            this.mangPermrdb.CheckedChanged += new System.EventHandler(this.mangPermrdb_CheckedChanged_1);
            // 
            // empRegRegbtn
            // 
            this.empRegRegbtn.BackColor = System.Drawing.Color.Teal;
            this.empRegRegbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empRegRegbtn.ForeColor = System.Drawing.Color.White;
            this.empRegRegbtn.Location = new System.Drawing.Point(110, 505);
            this.empRegRegbtn.Name = "empRegRegbtn";
            this.empRegRegbtn.Size = new System.Drawing.Size(140, 35);
            this.empRegRegbtn.TabIndex = 3;
            this.empRegRegbtn.Text = "Register";
            this.empRegRegbtn.UseVisualStyleBackColor = false;
            this.empRegRegbtn.Click += new System.EventHandler(this.empRegRegbtn_Click);
            // 
            // canclebtn
            // 
            this.canclebtn.BackColor = System.Drawing.Color.Teal;
            this.canclebtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.canclebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canclebtn.ForeColor = System.Drawing.Color.White;
            this.canclebtn.Location = new System.Drawing.Point(276, 505);
            this.canclebtn.Name = "canclebtn";
            this.canclebtn.Size = new System.Drawing.Size(140, 35);
            this.canclebtn.TabIndex = 4;
            this.canclebtn.Text = "Cancle";
            this.canclebtn.UseVisualStyleBackColor = false;
            this.canclebtn.Click += new System.EventHandler(this.canclebtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(179, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(220, 24);
            this.label10.TabIndex = 5;
            this.label10.Text = "Employee Registration";
            // 
            // EmpRegFrm
            // 
            this.AcceptButton = this.empRegRegbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.CancelButton = this.canclebtn;
            this.ClientSize = new System.Drawing.Size(547, 548);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.canclebtn);
            this.Controls.Add(this.empRegRegbtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmpRegFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Registeration";
            this.Load += new System.EventHandler(this.EmpRegFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox empRegQualftxt;
        private System.Windows.Forms.TextBox empRegEmailtxt;
        private System.Windows.Forms.TextBox empRegSSNtxt;
        private System.Windows.Forms.TextBox empRegPhone1txt;
        private System.Windows.Forms.TextBox empRegAddtxt;
        private System.Windows.Forms.TextBox empRegNametxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker empRegBdatePicker;
        private System.Windows.Forms.TextBox empRegPhone2txt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox empRegPasstxt;
        private System.Windows.Forms.TextBox empRegIdtxt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button empRegRegbtn;
        private System.Windows.Forms.Button canclebtn;
        private System.Windows.Forms.Button empAddPhone2btn;
        private System.Windows.Forms.RadioButton empPermrdb;
        private System.Windows.Forms.RadioButton mangPermrdb;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label10;
    }
}