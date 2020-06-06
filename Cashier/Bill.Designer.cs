namespace Cashier
{
    partial class Bill
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.txtTotal = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQty = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEachPrice = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtItemName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrderNo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClear = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnFinish = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAddToBill = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCalDisplay = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.panel4);
            this.bunifuCards1.Controls.Add(this.dataGridView1);
            this.bunifuCards1.Controls.Add(this.btnClear);
            this.bunifuCards1.Controls.Add(this.btnFinish);
            this.bunifuCards1.Controls.Add(this.btnAddToBill);
            this.bunifuCards1.Controls.Add(this.label5);
            this.bunifuCards1.Controls.Add(this.txtTotal);
            this.bunifuCards1.Controls.Add(this.label7);
            this.bunifuCards1.Controls.Add(this.txtQty);
            this.bunifuCards1.Controls.Add(this.comboBox2);
            this.bunifuCards1.Controls.Add(this.label4);
            this.bunifuCards1.Controls.Add(this.txtEachPrice);
            this.bunifuCards1.Controls.Add(this.label3);
            this.bunifuCards1.Controls.Add(this.txtItemName);
            this.bunifuCards1.Controls.Add(this.comboBox1);
            this.bunifuCards1.Controls.Add(this.label2);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.Controls.Add(this.txtOrderNo);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(1355, 794);
            this.bunifuCards1.TabIndex = 0;
            this.bunifuCards1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuCards1_Paint);
            // 
            // txtTotal
            // 
            this.txtTotal.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtTotal.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotal.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtTotal.BorderThickness = 3;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotal.isPassword = false;
            this.txtTotal.Location = new System.Drawing.Point(359, 240);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(288, 44);
            this.txtTotal.TabIndex = 117;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 116;
            this.label7.Text = "Qty :";
            // 
            // txtQty
            // 
            this.txtQty.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtQty.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQty.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtQty.BorderThickness = 3;
            this.txtQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQty.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQty.isPassword = false;
            this.txtQty.Location = new System.Drawing.Point(190, 240);
            this.txtQty.Margin = new System.Windows.Forms.Padding(4);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(153, 44);
            this.txtQty.TabIndex = 115;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQty.OnValueChanged += new System.EventHandler(this.txtQty_OnValueChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(97, 164);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(153, 21);
            this.comboBox2.TabIndex = 114;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 112;
            this.label4.Text = "Each Price :";
            // 
            // txtEachPrice
            // 
            this.txtEachPrice.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtEachPrice.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEachPrice.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtEachPrice.BorderThickness = 3;
            this.txtEachPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEachPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEachPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEachPrice.isPassword = false;
            this.txtEachPrice.Location = new System.Drawing.Point(493, 162);
            this.txtEachPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtEachPrice.Name = "txtEachPrice";
            this.txtEachPrice.Size = new System.Drawing.Size(153, 44);
            this.txtEachPrice.TabIndex = 111;
            this.txtEachPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 110;
            this.label3.Text = "Item Name :";
            // 
            // txtItemName
            // 
            this.txtItemName.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtItemName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtItemName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtItemName.BorderThickness = 3;
            this.txtItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtItemName.isPassword = false;
            this.txtItemName.Location = new System.Drawing.Point(359, 110);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(288, 44);
            this.txtItemName.TabIndex = 109;
            this.txtItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(97, 121);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 21);
            this.comboBox1.TabIndex = 108;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 107;
            this.label2.Text = "Item Code :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 106;
            this.label1.Text = "Order No :";
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtOrderNo.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOrderNo.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtOrderNo.BorderThickness = 3;
            this.txtOrderNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOrderNo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOrderNo.isPassword = false;
            this.txtOrderNo.Location = new System.Drawing.Point(97, 39);
            this.txtOrderNo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(210, 60);
            this.txtOrderNo.TabIndex = 105;
            this.txtOrderNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 118;
            this.label5.Text = "Size :";
            // 
            // btnClear
            // 
            this.btnClear.ActiveBorderThickness = 1;
            this.btnClear.ActiveCornerRadius = 20;
            this.btnClear.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnClear.ActiveForecolor = System.Drawing.Color.White;
            this.btnClear.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.ButtonText = "CLEAR";
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnClear.IdleBorderThickness = 1;
            this.btnClear.IdleCornerRadius = 20;
            this.btnClear.IdleFillColor = System.Drawing.Color.White;
            this.btnClear.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnClear.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnClear.Location = new System.Drawing.Point(655, 218);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(181, 41);
            this.btnClear.TabIndex = 121;
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFinish
            // 
            this.btnFinish.ActiveBorderThickness = 1;
            this.btnFinish.ActiveCornerRadius = 20;
            this.btnFinish.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnFinish.ActiveForecolor = System.Drawing.Color.White;
            this.btnFinish.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnFinish.BackColor = System.Drawing.Color.White;
            this.btnFinish.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFinish.BackgroundImage")));
            this.btnFinish.ButtonText = "FINISH";
            this.btnFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinish.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnFinish.IdleBorderThickness = 1;
            this.btnFinish.IdleCornerRadius = 20;
            this.btnFinish.IdleFillColor = System.Drawing.Color.White;
            this.btnFinish.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnFinish.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnFinish.Location = new System.Drawing.Point(655, 167);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(5);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(181, 41);
            this.btnFinish.TabIndex = 120;
            this.btnFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnAddToBill
            // 
            this.btnAddToBill.ActiveBorderThickness = 1;
            this.btnAddToBill.ActiveCornerRadius = 20;
            this.btnAddToBill.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAddToBill.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddToBill.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAddToBill.BackColor = System.Drawing.Color.White;
            this.btnAddToBill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddToBill.BackgroundImage")));
            this.btnAddToBill.ButtonText = "ADD TO BILL";
            this.btnAddToBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToBill.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToBill.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAddToBill.IdleBorderThickness = 1;
            this.btnAddToBill.IdleCornerRadius = 20;
            this.btnAddToBill.IdleFillColor = System.Drawing.Color.White;
            this.btnAddToBill.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnAddToBill.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAddToBill.Location = new System.Drawing.Point(655, 116);
            this.btnAddToBill.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddToBill.Name = "btnAddToBill";
            this.btnAddToBill.Size = new System.Drawing.Size(181, 41);
            this.btnAddToBill.TabIndex = 119;
            this.btnAddToBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddToBill.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(799, 270);
            this.dataGridView1.TabIndex = 122;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button18);
            this.panel4.Controls.Add(this.button17);
            this.panel4.Controls.Add(this.button13);
            this.panel4.Controls.Add(this.button14);
            this.panel4.Controls.Add(this.button15);
            this.panel4.Controls.Add(this.button16);
            this.panel4.Controls.Add(this.button9);
            this.panel4.Controls.Add(this.button10);
            this.panel4.Controls.Add(this.button11);
            this.panel4.Controls.Add(this.button12);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.button8);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.lblCalDisplay);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.lblTotal);
            this.panel4.Location = new System.Drawing.Point(890, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(444, 701);
            this.panel4.TabIndex = 123;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(37, 65);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(374, 111);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trajan Pro 3", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "Rs.";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblCalDisplay
            // 
            this.lblCalDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCalDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalDisplay.Location = new System.Drawing.Point(37, 246);
            this.lblCalDisplay.Name = "lblCalDisplay";
            this.lblCalDisplay.Size = new System.Drawing.Size(374, 60);
            this.lblCalDisplay.TabIndex = 4;
            this.lblCalDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(37, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 53);
            this.button1.TabIndex = 5;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(137, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 53);
            this.button2.TabIndex = 6;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(233, 338);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 53);
            this.button3.TabIndex = 7;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(331, 338);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 53);
            this.button4.TabIndex = 8;
            this.button4.Text = "=";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(331, 397);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 53);
            this.button5.TabIndex = 12;
            this.button5.Text = "/";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(233, 397);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 53);
            this.button6.TabIndex = 11;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(137, 397);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 53);
            this.button7.TabIndex = 10;
            this.button7.Text = "5";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(37, 397);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(80, 53);
            this.button8.TabIndex = 9;
            this.button8.Text = "4";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(331, 456);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(80, 53);
            this.button9.TabIndex = 16;
            this.button9.Text = "x";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(233, 456);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(80, 53);
            this.button10.TabIndex = 15;
            this.button10.Text = "9";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(137, 456);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(80, 53);
            this.button11.TabIndex = 14;
            this.button11.Text = "8";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(37, 456);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(80, 53);
            this.button12.TabIndex = 13;
            this.button12.Text = "7";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(331, 515);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(80, 53);
            this.button13.TabIndex = 20;
            this.button13.Text = "+";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(233, 515);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(80, 53);
            this.button14.TabIndex = 19;
            this.button14.Text = ".";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(137, 515);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(80, 53);
            this.button15.TabIndex = 18;
            this.button15.Text = "0";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(37, 515);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(80, 53);
            this.button16.TabIndex = 17;
            this.button16.Text = "*";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(331, 574);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(80, 53);
            this.button17.TabIndex = 21;
            this.button17.Text = "-";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(37, 574);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(276, 53);
            this.button18.TabIndex = 22;
            this.button18.Text = "C";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCards1);
            this.Name = "Bill";
            this.Size = new System.Drawing.Size(1355, 794);
            this.Load += new System.EventHandler(this.Bill_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClear;
        private Bunifu.Framework.UI.BunifuThinButton2 btnFinish;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddToBill;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTotal;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtQty;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtEachPrice;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtItemName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtOrderNo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCalDisplay;
    }
}
