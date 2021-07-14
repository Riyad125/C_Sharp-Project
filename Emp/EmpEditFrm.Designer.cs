namespace Phamacy_Management_System
{
    partial class EmpEditFrm
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
            this.empIDShowInfotxt = new System.Windows.Forms.TextBox();
            this.empShowInfobtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.empEditPhone2txt = new System.Windows.Forms.TextBox();
            this.empEditBdatePicker = new System.Windows.Forms.DateTimePicker();
            this.empEditQualftxt = new System.Windows.Forms.TextBox();
            this.empEditEmailtxt = new System.Windows.Forms.TextBox();
            this.empEditSSNtxt = new System.Windows.Forms.TextBox();
            this.empEditPhone1txt = new System.Windows.Forms.TextBox();
            this.empEditAddtxt = new System.Windows.Forms.TextBox();
            this.empEditNametxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.employPermrdb = new System.Windows.Forms.RadioButton();
            this.mangPermrdb = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.empEditPasstxt = new System.Windows.Forms.TextBox();
            this.empEditIdtxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.empInfoUpdatebtn = new System.Windows.Forms.Button();
            this.empEditCanclebtn = new System.Windows.Forms.Button();
            this.empInfoDeletebtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.empNameShowInfotxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Employee ID";
            // 
            // empIDShowInfotxt
            // 
            this.empIDShowInfotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empIDShowInfotxt.ForeColor = System.Drawing.Color.Black;
            this.empIDShowInfotxt.Location = new System.Drawing.Point(178, 24);
            this.empIDShowInfotxt.Name = "empIDShowInfotxt";
            this.empIDShowInfotxt.Size = new System.Drawing.Size(213, 22);
            this.empIDShowInfotxt.TabIndex = 0;
            this.empIDShowInfotxt.TextChanged += new System.EventHandler(this.showInfoTextValidating);
            this.empIDShowInfotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.empIDShowInfotxt_KeyPress);
            this.empIDShowInfotxt.Validating += new System.ComponentModel.CancelEventHandler(this.EmpEditFrm_Validating);
            // 
            // empShowInfobtn
            // 
            this.empShowInfobtn.BackColor = System.Drawing.Color.Teal;
            this.empShowInfobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empShowInfobtn.ForeColor = System.Drawing.Color.White;
            this.empShowInfobtn.Location = new System.Drawing.Point(425, 41);
            this.empShowInfobtn.Name = "empShowInfobtn";
            this.empShowInfobtn.Size = new System.Drawing.Size(78, 27);
            this.empShowInfobtn.TabIndex = 2;
            this.empShowInfobtn.Text = "Show info";
            this.empShowInfobtn.UseVisualStyleBackColor = false;
            this.empShowInfobtn.Click += new System.EventHandler(this.empShowInfobtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.empEditPhone2txt);
            this.groupBox1.Controls.Add(this.empEditBdatePicker);
            this.groupBox1.Controls.Add(this.empEditQualftxt);
            this.groupBox1.Controls.Add(this.empEditEmailtxt);
            this.groupBox1.Controls.Add(this.empEditSSNtxt);
            this.groupBox1.Controls.Add(this.empEditPhone1txt);
            this.groupBox1.Controls.Add(this.empEditAddtxt);
            this.groupBox1.Controls.Add(this.empEditNametxt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(48, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 290);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee  Data";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Teal;
            this.label12.Location = new System.Drawing.Point(283, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Phone2";
            // 
            // empEditPhone2txt
            // 
            this.empEditPhone2txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empEditPhone2txt.ForeColor = System.Drawing.Color.Black;
            this.empEditPhone2txt.Location = new System.Drawing.Point(355, 126);
            this.empEditPhone2txt.Name = "empEditPhone2txt";
            this.empEditPhone2txt.Size = new System.Drawing.Size(152, 22);
            this.empEditPhone2txt.TabIndex = 7;
            this.empEditPhone2txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.empPhonesKeyPress);
            // 
            // empEditBdatePicker
            // 
            this.empEditBdatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.empEditBdatePicker.Location = new System.Drawing.Point(110, 89);
            this.empEditBdatePicker.Name = "empEditBdatePicker";
            this.empEditBdatePicker.Size = new System.Drawing.Size(200, 26);
            this.empEditBdatePicker.TabIndex = 5;
            // 
            // empEditQualftxt
            // 
            this.empEditQualftxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empEditQualftxt.ForeColor = System.Drawing.Color.Black;
            this.empEditQualftxt.Location = new System.Drawing.Point(110, 226);
            this.empEditQualftxt.MaxLength = 50;
            this.empEditQualftxt.Multiline = true;
            this.empEditQualftxt.Name = "empEditQualftxt";
            this.empEditQualftxt.Size = new System.Drawing.Size(363, 49);
            this.empEditQualftxt.TabIndex = 10;
            this.empEditQualftxt.TextChanged += new System.EventHandler(this.empInfoTextChanged);
            this.empEditQualftxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.empEditQualftxt_KeyPress);
            this.empEditQualftxt.Validating += new System.ComponentModel.CancelEventHandler(this.empInfoTextValidating);
            // 
            // empEditEmailtxt
            // 
            this.empEditEmailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empEditEmailtxt.ForeColor = System.Drawing.Color.Black;
            this.empEditEmailtxt.Location = new System.Drawing.Point(110, 193);
            this.empEditEmailtxt.MaxLength = 35;
            this.empEditEmailtxt.Name = "empEditEmailtxt";
            this.empEditEmailtxt.Size = new System.Drawing.Size(363, 22);
            this.empEditEmailtxt.TabIndex = 9;
            this.empEditEmailtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.empEditEmailtxt_KeyPress);
            // 
            // empEditSSNtxt
            // 
            this.empEditSSNtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empEditSSNtxt.ForeColor = System.Drawing.Color.Black;
            this.empEditSSNtxt.Location = new System.Drawing.Point(110, 159);
            this.empEditSSNtxt.Name = "empEditSSNtxt";
            this.empEditSSNtxt.Size = new System.Drawing.Size(178, 22);
            this.empEditSSNtxt.TabIndex = 8;
            this.empEditSSNtxt.TextChanged += new System.EventHandler(this.empInfoTextChanged);
            this.empEditSSNtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.empEditSSNtxt_KeyPress);
            this.empEditSSNtxt.Validating += new System.ComponentModel.CancelEventHandler(this.empInfoTextValidating);
            // 
            // empEditPhone1txt
            // 
            this.empEditPhone1txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empEditPhone1txt.ForeColor = System.Drawing.Color.Black;
            this.empEditPhone1txt.Location = new System.Drawing.Point(110, 125);
            this.empEditPhone1txt.Name = "empEditPhone1txt";
            this.empEditPhone1txt.Size = new System.Drawing.Size(152, 22);
            this.empEditPhone1txt.TabIndex = 6;
            this.empEditPhone1txt.TextChanged += new System.EventHandler(this.empInfoTextChanged);
            this.empEditPhone1txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.empPhonesKeyPress);
            this.empEditPhone1txt.Validating += new System.ComponentModel.CancelEventHandler(this.empInfoTextValidating);
            // 
            // empEditAddtxt
            // 
            this.empEditAddtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empEditAddtxt.ForeColor = System.Drawing.Color.Black;
            this.empEditAddtxt.Location = new System.Drawing.Point(110, 57);
            this.empEditAddtxt.Name = "empEditAddtxt";
            this.empEditAddtxt.Size = new System.Drawing.Size(363, 22);
            this.empEditAddtxt.TabIndex = 4;
            this.empEditAddtxt.TextChanged += new System.EventHandler(this.empInfoTextChanged);
            this.empEditAddtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.empEditAddtxt_KeyPress);
            this.empEditAddtxt.Validating += new System.ComponentModel.CancelEventHandler(this.empInfoTextValidating);
            // 
            // empEditNametxt
            // 
            this.empEditNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empEditNametxt.ForeColor = System.Drawing.Color.Black;
            this.empEditNametxt.Location = new System.Drawing.Point(110, 27);
            this.empEditNametxt.Name = "empEditNametxt";
            this.empEditNametxt.Size = new System.Drawing.Size(363, 22);
            this.empEditNametxt.TabIndex = 3;
            this.empEditNametxt.TextChanged += new System.EventHandler(this.empInfoTextChanged);
            this.empEditNametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.empEditNametxt_KeyPress);
            this.empEditNametxt.Validating += new System.ComponentModel.CancelEventHandler(this.empInfoTextValidating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(14, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Qualification";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(14, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(14, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "SSN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(14, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(14, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bdate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(14, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(14, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.employPermrdb);
            this.groupBox3.Controls.Add(this.mangPermrdb);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox3.Location = new System.Drawing.Point(49, 497);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(522, 60);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Permissions";
            // 
            // employPermrdb
            // 
            this.employPermrdb.AutoSize = true;
            this.employPermrdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.employPermrdb.ForeColor = System.Drawing.Color.Teal;
            this.employPermrdb.Location = new System.Drawing.Point(315, 25);
            this.employPermrdb.Name = "employPermrdb";
            this.employPermrdb.Size = new System.Drawing.Size(96, 20);
            this.employPermrdb.TabIndex = 1;
            this.employPermrdb.Text = "Employee";
            this.employPermrdb.UseVisualStyleBackColor = true;
            // 
            // mangPermrdb
            // 
            this.mangPermrdb.AutoSize = true;
            this.mangPermrdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.mangPermrdb.ForeColor = System.Drawing.Color.Teal;
            this.mangPermrdb.Location = new System.Drawing.Point(123, 25);
            this.mangPermrdb.Name = "mangPermrdb";
            this.mangPermrdb.Size = new System.Drawing.Size(87, 20);
            this.mangPermrdb.TabIndex = 0;
            this.mangPermrdb.Text = "Manager";
            this.mangPermrdb.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.empEditPasstxt);
            this.groupBox2.Controls.Add(this.empEditIdtxt);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox2.Location = new System.Drawing.Point(49, 429);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(522, 63);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Login Data";
            // 
            // empEditPasstxt
            // 
            this.empEditPasstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empEditPasstxt.ForeColor = System.Drawing.Color.Black;
            this.empEditPasstxt.Location = new System.Drawing.Point(352, 24);
            this.empEditPasstxt.MaxLength = 10;
            this.empEditPasstxt.Name = "empEditPasstxt";
            this.empEditPasstxt.Size = new System.Drawing.Size(147, 22);
            this.empEditPasstxt.TabIndex = 11;
            this.empEditPasstxt.TextChanged += new System.EventHandler(this.empInfoTextChanged);
            this.empEditPasstxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.empEditPasstxt_KeyPress);
            this.empEditPasstxt.Validating += new System.ComponentModel.CancelEventHandler(this.empInfoTextValidating);
            // 
            // empEditIdtxt
            // 
            this.empEditIdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empEditIdtxt.ForeColor = System.Drawing.Color.Black;
            this.empEditIdtxt.Location = new System.Drawing.Point(111, 24);
            this.empEditIdtxt.Name = "empEditIdtxt";
            this.empEditIdtxt.ReadOnly = true;
            this.empEditIdtxt.Size = new System.Drawing.Size(147, 22);
            this.empEditIdtxt.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(272, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(13, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Employee ID";
            // 
            // empInfoUpdatebtn
            // 
            this.empInfoUpdatebtn.BackColor = System.Drawing.Color.Teal;
            this.empInfoUpdatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empInfoUpdatebtn.ForeColor = System.Drawing.Color.White;
            this.empInfoUpdatebtn.Location = new System.Drawing.Point(141, 568);
            this.empInfoUpdatebtn.Name = "empInfoUpdatebtn";
            this.empInfoUpdatebtn.Size = new System.Drawing.Size(110, 33);
            this.empInfoUpdatebtn.TabIndex = 6;
            this.empInfoUpdatebtn.Text = "Update";
            this.empInfoUpdatebtn.UseVisualStyleBackColor = false;
            this.empInfoUpdatebtn.Click += new System.EventHandler(this.empInfoUpdatebtn_Click);
            // 
            // empEditCanclebtn
            // 
            this.empEditCanclebtn.BackColor = System.Drawing.Color.Teal;
            this.empEditCanclebtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.empEditCanclebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empEditCanclebtn.ForeColor = System.Drawing.Color.White;
            this.empEditCanclebtn.Location = new System.Drawing.Point(379, 568);
            this.empEditCanclebtn.Name = "empEditCanclebtn";
            this.empEditCanclebtn.Size = new System.Drawing.Size(110, 33);
            this.empEditCanclebtn.TabIndex = 7;
            this.empEditCanclebtn.Text = "Cancle";
            this.empEditCanclebtn.UseVisualStyleBackColor = false;
            this.empEditCanclebtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // empInfoDeletebtn
            // 
            this.empInfoDeletebtn.BackColor = System.Drawing.Color.Teal;
            this.empInfoDeletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empInfoDeletebtn.ForeColor = System.Drawing.Color.White;
            this.empInfoDeletebtn.Location = new System.Drawing.Point(260, 568);
            this.empInfoDeletebtn.Name = "empInfoDeletebtn";
            this.empInfoDeletebtn.Size = new System.Drawing.Size(110, 33);
            this.empInfoDeletebtn.TabIndex = 8;
            this.empInfoDeletebtn.Text = "Delete";
            this.empInfoDeletebtn.UseVisualStyleBackColor = false;
            this.empInfoDeletebtn.Click += new System.EventHandler(this.empInfoDeletebtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Teal;
            this.label11.Location = new System.Drawing.Point(11, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "Enter Employee Name";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // empNameShowInfotxt
            // 
            this.empNameShowInfotxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.empNameShowInfotxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.empNameShowInfotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empNameShowInfotxt.ForeColor = System.Drawing.Color.Black;
            this.empNameShowInfotxt.Location = new System.Drawing.Point(178, 64);
            this.empNameShowInfotxt.Name = "empNameShowInfotxt";
            this.empNameShowInfotxt.Size = new System.Drawing.Size(213, 22);
            this.empNameShowInfotxt.TabIndex = 1;
            this.empNameShowInfotxt.TextChanged += new System.EventHandler(this.showInfoTextValidating);
            this.empNameShowInfotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.empNameShowInfotxt_KeyPress);
            this.empNameShowInfotxt.Validating += new System.ComponentModel.CancelEventHandler(this.EmpEditFrm_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label13.ForeColor = System.Drawing.Color.Teal;
            this.label13.Location = new System.Drawing.Point(239, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 24);
            this.label13.TabIndex = 10;
            this.label13.Text = "Edit Employee";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.empShowInfobtn);
            this.groupBox4.Controls.Add(this.empIDShowInfotxt);
            this.groupBox4.Controls.Add(this.empNameShowInfotxt);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox4.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox4.Location = new System.Drawing.Point(50, 33);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(521, 96);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search";
            // 
            // EmpEditFrm
            // 
            this.AcceptButton = this.empShowInfobtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.CancelButton = this.empEditCanclebtn;
            this.ClientSize = new System.Drawing.Size(633, 620);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.empInfoDeletebtn);
            this.Controls.Add(this.empEditCanclebtn);
            this.Controls.Add(this.empInfoUpdatebtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmpEditFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Employee";
            this.Load += new System.EventHandler(this.EmpEditFrm_Load);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.EmpEditFrm_Validating);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox empIDShowInfotxt;
        private System.Windows.Forms.Button empShowInfobtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox empEditPhone2txt;
        private System.Windows.Forms.DateTimePicker empEditBdatePicker;
        private System.Windows.Forms.TextBox empEditQualftxt;
        private System.Windows.Forms.TextBox empEditEmailtxt;
        private System.Windows.Forms.TextBox empEditSSNtxt;
        private System.Windows.Forms.TextBox empEditPhone1txt;
        private System.Windows.Forms.TextBox empEditAddtxt;
        private System.Windows.Forms.TextBox empEditNametxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox empEditPasstxt;
        private System.Windows.Forms.TextBox empEditIdtxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button empInfoUpdatebtn;
        private System.Windows.Forms.Button empEditCanclebtn;
        private System.Windows.Forms.Button empInfoDeletebtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox empNameShowInfotxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton employPermrdb;
        private System.Windows.Forms.RadioButton mangPermrdb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}