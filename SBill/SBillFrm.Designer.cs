namespace Phamacy_Management_System
{
    partial class SBillFrm
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
            this.sBillDebtNamecmbo = new System.Windows.Forms.ComboBox();
            this.sBillEmpNametxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sBillNolbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sBillCashrdb = new System.Windows.Forms.RadioButton();
            this.sBillPostrdb = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.maxDebtlbl = new System.Windows.Forms.Label();
            this.pendinglbl = new System.Windows.Forms.Label();
            this.sBillSellbtn = new System.Windows.Forms.Button();
            this.sBillCanclebtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.sBillTtlCostlbl = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
            this.itemTtlPricetxt = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.itemPricetxt = new System.Windows.Forms.TextBox();
            this.lab = new System.Windows.Forms.Label();
            this.itemQuanttxt = new System.Windows.Forms.TextBox();
            this.Unit = new System.Windows.Forms.Label();
            this.itemUnitcmbo = new System.Windows.Forms.ComboBox();
            this.sBilldgv = new System.Windows.Forms.DataGridView();
            this.sBillAddItembtn = new System.Windows.Forms.Button();
            this.sBillItemBartxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.sBillItemNametxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.sBillDatelbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sBilldgv)).BeginInit();
            this.SuspendLayout();
            // 
            // sBillDebtNamecmbo
            // 
            this.sBillDebtNamecmbo.BackColor = System.Drawing.Color.Teal;
            this.sBillDebtNamecmbo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sBillDebtNamecmbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sBillDebtNamecmbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sBillDebtNamecmbo.ForeColor = System.Drawing.Color.White;
            this.sBillDebtNamecmbo.FormattingEnabled = true;
            this.sBillDebtNamecmbo.Location = new System.Drawing.Point(640, 149);
            this.sBillDebtNamecmbo.Name = "sBillDebtNamecmbo";
            this.sBillDebtNamecmbo.Size = new System.Drawing.Size(259, 24);
            this.sBillDebtNamecmbo.TabIndex = 24;
            this.sBillDebtNamecmbo.Visible = false;
            this.sBillDebtNamecmbo.SelectedIndexChanged += new System.EventHandler(this.sBillDebtNamecmbo_SelectedIndexChanged);
            // 
            // sBillEmpNametxt
            // 
            this.sBillEmpNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sBillEmpNametxt.ForeColor = System.Drawing.Color.SkyBlue;
            this.sBillEmpNametxt.Location = new System.Drawing.Point(94, 154);
            this.sBillEmpNametxt.Name = "sBillEmpNametxt";
            this.sBillEmpNametxt.ReadOnly = true;
            this.sBillEmpNametxt.Size = new System.Drawing.Size(235, 22);
            this.sBillEmpNametxt.TabIndex = 22;
            this.sBillEmpNametxt.TextChanged += new System.EventHandler(this.sBillEmpNametxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(578, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Debtor";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(12, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Employee";
            // 
            // sBillNolbl
            // 
            this.sBillNolbl.AutoSize = true;
            this.sBillNolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sBillNolbl.ForeColor = System.Drawing.Color.SkyBlue;
            this.sBillNolbl.Location = new System.Drawing.Point(441, 123);
            this.sBillNolbl.Name = "sBillNolbl";
            this.sBillNolbl.Size = new System.Drawing.Size(51, 16);
            this.sBillNolbl.TabIndex = 18;
            this.sBillNolbl.Text = "label2";
            this.sBillNolbl.Click += new System.EventHandler(this.sBillNolbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(382, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Bill No.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(416, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Bill kind";
            // 
            // sBillCashrdb
            // 
            this.sBillCashrdb.AutoSize = true;
            this.sBillCashrdb.Checked = true;
            this.sBillCashrdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sBillCashrdb.ForeColor = System.Drawing.Color.Crimson;
            this.sBillCashrdb.Location = new System.Drawing.Point(360, 87);
            this.sBillCashrdb.Name = "sBillCashrdb";
            this.sBillCashrdb.Size = new System.Drawing.Size(64, 24);
            this.sBillCashrdb.TabIndex = 32;
            this.sBillCashrdb.TabStop = true;
            this.sBillCashrdb.Text = "Cash";
            this.sBillCashrdb.UseVisualStyleBackColor = true;
            this.sBillCashrdb.CheckedChanged += new System.EventHandler(this.sBillCashrdb_CheckedChanged);
            // 
            // sBillPostrdb
            // 
            this.sBillPostrdb.AutoSize = true;
            this.sBillPostrdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sBillPostrdb.ForeColor = System.Drawing.Color.Crimson;
            this.sBillPostrdb.Location = new System.Drawing.Point(457, 87);
            this.sBillPostrdb.Name = "sBillPostrdb";
            this.sBillPostrdb.Size = new System.Drawing.Size(94, 24);
            this.sBillPostrdb.TabIndex = 33;
            this.sBillPostrdb.Text = "Post Paid";
            this.sBillPostrdb.UseVisualStyleBackColor = true;
            this.sBillPostrdb.CheckedChanged += new System.EventHandler(this.sBillPostrdb_CheckedChanged);
            this.sBillPostrdb.TextChanged += new System.EventHandler(this.sBillPostrdb_TextChanged);
            this.sBillPostrdb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sBillPostrdb_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(578, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "Max debt";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(733, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 35;
            this.label9.Text = "Pending";
            this.label9.Visible = false;
            // 
            // maxDebtlbl
            // 
            this.maxDebtlbl.AutoSize = true;
            this.maxDebtlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxDebtlbl.ForeColor = System.Drawing.Color.SkyBlue;
            this.maxDebtlbl.Location = new System.Drawing.Point(651, 188);
            this.maxDebtlbl.Name = "maxDebtlbl";
            this.maxDebtlbl.Size = new System.Drawing.Size(59, 16);
            this.maxDebtlbl.TabIndex = 36;
            this.maxDebtlbl.Text = "label10";
            this.maxDebtlbl.Visible = false;
            // 
            // pendinglbl
            // 
            this.pendinglbl.AutoSize = true;
            this.pendinglbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendinglbl.ForeColor = System.Drawing.Color.SkyBlue;
            this.pendinglbl.Location = new System.Drawing.Point(806, 188);
            this.pendinglbl.Name = "pendinglbl";
            this.pendinglbl.Size = new System.Drawing.Size(59, 16);
            this.pendinglbl.TabIndex = 37;
            this.pendinglbl.Text = "label11";
            this.pendinglbl.Visible = false;
            // 
            // sBillSellbtn
            // 
            this.sBillSellbtn.BackColor = System.Drawing.Color.Teal;
            this.sBillSellbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sBillSellbtn.ForeColor = System.Drawing.Color.White;
            this.sBillSellbtn.Location = new System.Drawing.Point(367, 525);
            this.sBillSellbtn.Name = "sBillSellbtn";
            this.sBillSellbtn.Size = new System.Drawing.Size(85, 32);
            this.sBillSellbtn.TabIndex = 38;
            this.sBillSellbtn.Text = "Sell";
            this.sBillSellbtn.UseVisualStyleBackColor = false;
            this.sBillSellbtn.Click += new System.EventHandler(this.sBillSellbtn_Click);
            // 
            // sBillCanclebtn
            // 
            this.sBillCanclebtn.BackColor = System.Drawing.Color.Teal;
            this.sBillCanclebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sBillCanclebtn.ForeColor = System.Drawing.Color.White;
            this.sBillCanclebtn.Location = new System.Drawing.Point(477, 525);
            this.sBillCanclebtn.Name = "sBillCanclebtn";
            this.sBillCanclebtn.Size = new System.Drawing.Size(85, 32);
            this.sBillCanclebtn.TabIndex = 39;
            this.sBillCanclebtn.Text = "Cancle";
            this.sBillCanclebtn.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(25, 516);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 16);
            this.label10.TabIndex = 40;
            this.label10.Text = "Total cost";
            // 
            // sBillTtlCostlbl
            // 
            this.sBillTtlCostlbl.AutoSize = true;
            this.sBillTtlCostlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sBillTtlCostlbl.ForeColor = System.Drawing.Color.SkyBlue;
            this.sBillTtlCostlbl.Location = new System.Drawing.Point(103, 516);
            this.sBillTtlCostlbl.Name = "sBillTtlCostlbl";
            this.sBillTtlCostlbl.Size = new System.Drawing.Size(16, 16);
            this.sBillTtlCostlbl.TabIndex = 41;
            this.sBillTtlCostlbl.Text = "0";
            this.sBillTtlCostlbl.Click += new System.EventHandler(this.sBillTtlCostlbl_Click);
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.ForeColor = System.Drawing.Color.SteelBlue;
            this.lable.Location = new System.Drawing.Point(742, 237);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(83, 20);
            this.lable.TabIndex = 57;
            this.lable.Text = "Total Price";
            // 
            // itemTtlPricetxt
            // 
            this.itemTtlPricetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTtlPricetxt.ForeColor = System.Drawing.Color.SkyBlue;
            this.itemTtlPricetxt.Location = new System.Drawing.Point(730, 261);
            this.itemTtlPricetxt.Name = "itemTtlPricetxt";
            this.itemTtlPricetxt.ReadOnly = true;
            this.itemTtlPricetxt.Size = new System.Drawing.Size(111, 22);
            this.itemTtlPricetxt.TabIndex = 56;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.SteelBlue;
            this.label.Location = new System.Drawing.Point(636, 237);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(44, 20);
            this.label.TabIndex = 55;
            this.label.Text = "Price";
            // 
            // itemPricetxt
            // 
            this.itemPricetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPricetxt.ForeColor = System.Drawing.Color.SkyBlue;
            this.itemPricetxt.Location = new System.Drawing.Point(600, 261);
            this.itemPricetxt.Name = "itemPricetxt";
            this.itemPricetxt.Size = new System.Drawing.Size(127, 22);
            this.itemPricetxt.TabIndex = 54;
            this.itemPricetxt.TextChanged += new System.EventHandler(this.calcTotalPriceOnTextChanged);
            this.itemPricetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemPricetxt_KeyPress);
            this.itemPricetxt.Validating += new System.ComponentModel.CancelEventHandler(this.addItembtnValidating);
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.ForeColor = System.Drawing.Color.SteelBlue;
            this.lab.Location = new System.Drawing.Point(503, 237);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(68, 20);
            this.lab.TabIndex = 53;
            this.lab.Text = "Quantity";
            // 
            // itemQuanttxt
            // 
            this.itemQuanttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemQuanttxt.ForeColor = System.Drawing.Color.SkyBlue;
            this.itemQuanttxt.Location = new System.Drawing.Point(485, 261);
            this.itemQuanttxt.Name = "itemQuanttxt";
            this.itemQuanttxt.Size = new System.Drawing.Size(111, 22);
            this.itemQuanttxt.TabIndex = 52;
            this.itemQuanttxt.TextChanged += new System.EventHandler(this.calcTotalPriceOnTextChanged);
            this.itemQuanttxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemQuanttxt_KeyPress);
            this.itemQuanttxt.Validating += new System.ComponentModel.CancelEventHandler(this.addItembtnValidating);
            // 
            // Unit
            // 
            this.Unit.AutoSize = true;
            this.Unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unit.ForeColor = System.Drawing.Color.SteelBlue;
            this.Unit.Location = new System.Drawing.Point(401, 237);
            this.Unit.Name = "Unit";
            this.Unit.Size = new System.Drawing.Size(38, 20);
            this.Unit.TabIndex = 49;
            this.Unit.Text = "Unit";
            // 
            // itemUnitcmbo
            // 
            this.itemUnitcmbo.BackColor = System.Drawing.Color.Teal;
            this.itemUnitcmbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemUnitcmbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemUnitcmbo.ForeColor = System.Drawing.Color.White;
            this.itemUnitcmbo.FormattingEnabled = true;
            this.itemUnitcmbo.Location = new System.Drawing.Point(366, 260);
            this.itemUnitcmbo.Name = "itemUnitcmbo";
            this.itemUnitcmbo.Size = new System.Drawing.Size(117, 24);
            this.itemUnitcmbo.TabIndex = 48;
            this.itemUnitcmbo.SelectedIndexChanged += new System.EventHandler(this.itemUnitcmbo_SelectedIndexChanged);
            // 
            // sBilldgv
            // 
            this.sBilldgv.AllowUserToAddRows = false;
            this.sBilldgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sBilldgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sBilldgv.Location = new System.Drawing.Point(18, 290);
            this.sBilldgv.Name = "sBilldgv";
            this.sBilldgv.Size = new System.Drawing.Size(909, 201);
            this.sBilldgv.TabIndex = 47;
            this.sBilldgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sBilldgv_CellContentClick_1);
            this.sBilldgv.SelectionChanged += new System.EventHandler(this.sBilldgv_SelectionChanged);
            this.sBilldgv.Validating += new System.ComponentModel.CancelEventHandler(this.sBilldgv_Validating);
            // 
            // sBillAddItembtn
            // 
            this.sBillAddItembtn.BackColor = System.Drawing.Color.Teal;
            this.sBillAddItembtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sBillAddItembtn.ForeColor = System.Drawing.Color.White;
            this.sBillAddItembtn.Location = new System.Drawing.Point(849, 254);
            this.sBillAddItembtn.Name = "sBillAddItembtn";
            this.sBillAddItembtn.Size = new System.Drawing.Size(78, 30);
            this.sBillAddItembtn.TabIndex = 46;
            this.sBillAddItembtn.Text = "Add item";
            this.sBillAddItembtn.UseVisualStyleBackColor = false;
            this.sBillAddItembtn.Click += new System.EventHandler(this.sBillAddItembtn_Click);
            // 
            // sBillItemBartxt
            // 
            this.sBillItemBartxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sBillItemBartxt.ForeColor = System.Drawing.Color.SkyBlue;
            this.sBillItemBartxt.Location = new System.Drawing.Point(18, 260);
            this.sBillItemBartxt.Name = "sBillItemBartxt";
            this.sBillItemBartxt.Size = new System.Drawing.Size(116, 22);
            this.sBillItemBartxt.TabIndex = 45;
            this.sBillItemBartxt.TextChanged += new System.EventHandler(this.sBillItemBartxt_TextChanged);
            this.sBillItemBartxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sBillItemBartxt_KeyPress);
            this.sBillItemBartxt.Leave += new System.EventHandler(this.sBillItemBartxt_Leave);
            this.sBillItemBartxt.Validating += new System.ComponentModel.CancelEventHandler(this.addItembtnValidating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.SteelBlue;
            this.label11.Location = new System.Drawing.Point(23, 237);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 20);
            this.label11.TabIndex = 44;
            this.label11.Text = "Item Barcode";
            // 
            // sBillItemNametxt
            // 
            this.sBillItemNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sBillItemNametxt.ForeColor = System.Drawing.Color.SkyBlue;
            this.sBillItemNametxt.Location = new System.Drawing.Point(137, 260);
            this.sBillItemNametxt.Name = "sBillItemNametxt";
            this.sBillItemNametxt.Size = new System.Drawing.Size(228, 22);
            this.sBillItemNametxt.TabIndex = 43;
            this.sBillItemNametxt.TextChanged += new System.EventHandler(this.sBillItemNametxt_TextChanged);
            this.sBillItemNametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sBillItemNametxt_KeyPress);
            this.sBillItemNametxt.Leave += new System.EventHandler(this.sBillItemNametxt_Leave);
            this.sBillItemNametxt.Validating += new System.ComponentModel.CancelEventHandler(this.addItembtnValidating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.SteelBlue;
            this.label12.Location = new System.Drawing.Point(207, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 20);
            this.label12.TabIndex = 42;
            this.label12.Text = "Item Name";
            // 
            // sBillDatelbl
            // 
            this.sBillDatelbl.AutoSize = true;
            this.sBillDatelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sBillDatelbl.ForeColor = System.Drawing.Color.SkyBlue;
            this.sBillDatelbl.Location = new System.Drawing.Point(796, 516);
            this.sBillDatelbl.Name = "sBillDatelbl";
            this.sBillDatelbl.Size = new System.Drawing.Size(59, 16);
            this.sBillDatelbl.TabIndex = 59;
            this.sBillDatelbl.Text = "label10";
            this.sBillDatelbl.Click += new System.EventHandler(this.sBillDatelbl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(727, 516);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 58;
            this.label2.Text = "Bill Date";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label23.ForeColor = System.Drawing.Color.Teal;
            this.label23.Location = new System.Drawing.Point(393, 9);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(108, 24);
            this.label23.TabIndex = 60;
            this.label23.Text = "Selling Bill";
            // 
            // SBillFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(965, 561);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.sBillDatelbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.itemTtlPricetxt);
            this.Controls.Add(this.label);
            this.Controls.Add(this.itemPricetxt);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.itemQuanttxt);
            this.Controls.Add(this.Unit);
            this.Controls.Add(this.itemUnitcmbo);
            this.Controls.Add(this.sBilldgv);
            this.Controls.Add(this.sBillAddItembtn);
            this.Controls.Add(this.sBillItemBartxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.sBillItemNametxt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.sBillTtlCostlbl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.sBillCanclebtn);
            this.Controls.Add(this.sBillSellbtn);
            this.Controls.Add(this.pendinglbl);
            this.Controls.Add(this.maxDebtlbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sBillPostrdb);
            this.Controls.Add(this.sBillCashrdb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sBillDebtNamecmbo);
            this.Controls.Add(this.sBillEmpNametxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sBillNolbl);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SBillFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selling Bill";
            this.Load += new System.EventHandler(this.SBillFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sBilldgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sBillDebtNamecmbo;
        private System.Windows.Forms.TextBox sBillEmpNametxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sBillNolbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton sBillCashrdb;
        private System.Windows.Forms.RadioButton sBillPostrdb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label maxDebtlbl;
        private System.Windows.Forms.Label pendinglbl;
        private System.Windows.Forms.Button sBillSellbtn;
        private System.Windows.Forms.Button sBillCanclebtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label sBillTtlCostlbl;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.TextBox itemTtlPricetxt;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox itemPricetxt;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.TextBox itemQuanttxt;
        private System.Windows.Forms.Label Unit;
        private System.Windows.Forms.ComboBox itemUnitcmbo;
        private System.Windows.Forms.DataGridView sBilldgv;
        private System.Windows.Forms.Button sBillAddItembtn;
        private System.Windows.Forms.TextBox sBillItemBartxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox sBillItemNametxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label sBillDatelbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label23;

    }
}