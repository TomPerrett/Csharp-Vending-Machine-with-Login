namespace WindowsFormsApplication3
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.lblVendingMachine = new System.Windows.Forms.Label();
            this.lblCocaCola = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFanta = new System.Windows.Forms.Label();
            this.lblSprite = new System.Windows.Forms.Label();
            this.lblDairyMilk = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblGalaxy = new System.Windows.Forms.Label();
            this.lblMarsBar = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.lblNumberLabel = new System.Windows.Forms.Label();
            this.btnPurchaseOrder = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Location = new System.Drawing.Point(6, 27);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(112, 22);
            this.btnSaveAll.TabIndex = 0;
            this.btnSaveAll.Text = "Save All";
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblVendingMachine
            // 
            this.lblVendingMachine.AutoSize = true;
            this.lblVendingMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendingMachine.Location = new System.Drawing.Point(209, 49);
            this.lblVendingMachine.Name = "lblVendingMachine";
            this.lblVendingMachine.Size = new System.Drawing.Size(328, 46);
            this.lblVendingMachine.TabIndex = 3;
            this.lblVendingMachine.Text = "Vending Machine";
            this.lblVendingMachine.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblVendingMachine.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCocaCola
            // 
            this.lblCocaCola.AutoSize = true;
            this.lblCocaCola.Location = new System.Drawing.Point(111, 330);
            this.lblCocaCola.Name = "lblCocaCola";
            this.lblCocaCola.Size = new System.Drawing.Size(74, 13);
            this.lblCocaCola.TabIndex = 31;
            this.lblCocaCola.Text = "Coca-Cola: £1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(965, 24);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.openToolStripMenuItem.Text = "Save";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.editToolStripMenuItem.Text = "Logout";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // lblFanta
            // 
            this.lblFanta.AutoSize = true;
            this.lblFanta.Location = new System.Drawing.Point(344, 330);
            this.lblFanta.Name = "lblFanta";
            this.lblFanta.Size = new System.Drawing.Size(52, 13);
            this.lblFanta.TabIndex = 34;
            this.lblFanta.Text = "Fanta: £1";
            // 
            // lblSprite
            // 
            this.lblSprite.AutoSize = true;
            this.lblSprite.Location = new System.Drawing.Point(577, 330);
            this.lblSprite.Name = "lblSprite";
            this.lblSprite.Size = new System.Drawing.Size(52, 13);
            this.lblSprite.TabIndex = 35;
            this.lblSprite.Text = "Sprite: £1";
            // 
            // lblDairyMilk
            // 
            this.lblDairyMilk.AutoSize = true;
            this.lblDairyMilk.Location = new System.Drawing.Point(586, 518);
            this.lblDairyMilk.Name = "lblDairyMilk";
            this.lblDairyMilk.Size = new System.Drawing.Size(77, 13);
            this.lblDairyMilk.TabIndex = 38;
            this.lblDairyMilk.Text = "Dairy Milk: 89p";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(243, 131);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(245, 196);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(535, 131);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(113, 196);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 42;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(494, 380);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(231, 135);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 43;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(260, 356);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(228, 206);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 44;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(0, 356);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(254, 216);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 45;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // lblGalaxy
            // 
            this.lblGalaxy.AutoSize = true;
            this.lblGalaxy.Location = new System.Drawing.Point(358, 518);
            this.lblGalaxy.Name = "lblGalaxy";
            this.lblGalaxy.Size = new System.Drawing.Size(63, 13);
            this.lblGalaxy.TabIndex = 47;
            this.lblGalaxy.Text = "Galaxy: 89p";
            // 
            // lblMarsBar
            // 
            this.lblMarsBar.AutoSize = true;
            this.lblMarsBar.Location = new System.Drawing.Point(111, 518);
            this.lblMarsBar.Name = "lblMarsBar";
            this.lblMarsBar.Size = new System.Drawing.Size(73, 13);
            this.lblMarsBar.TabIndex = 48;
            this.lblMarsBar.Text = "Mars Bar: 89p";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(6, 55);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 23);
            this.btnClear.TabIndex = 50;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblTotalLabel
            // 
            this.lblTotalLabel.AutoSize = true;
            this.lblTotalLabel.Location = new System.Drawing.Point(784, 538);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Size = new System.Drawing.Size(43, 13);
            this.lblTotalLabel.TabIndex = 52;
            this.lblTotalLabel.Text = "Total: £";
            // 
            // lblNumberLabel
            // 
            this.lblNumberLabel.AutoSize = true;
            this.lblNumberLabel.Location = new System.Drawing.Point(752, 502);
            this.lblNumberLabel.Name = "lblNumberLabel";
            this.lblNumberLabel.Size = new System.Drawing.Size(69, 13);
            this.lblNumberLabel.TabIndex = 53;
            this.lblNumberLabel.Text = "No. of items: ";
            // 
            // btnPurchaseOrder
            // 
            this.btnPurchaseOrder.Location = new System.Drawing.Point(827, 567);
            this.btnPurchaseOrder.Name = "btnPurchaseOrder";
            this.btnPurchaseOrder.Size = new System.Drawing.Size(118, 51);
            this.btnPurchaseOrder.TabIndex = 54;
            this.btnPurchaseOrder.Text = "Purchase Order";
            this.btnPurchaseOrder.UseVisualStyleBackColor = true;
            this.btnPurchaseOrder.Click += new System.EventHandler(this.btnPurchaseOrder_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(6, 84);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(112, 24);
            this.btnLoad.TabIndex = 55;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveAll);
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Location = new System.Drawing.Point(749, 356);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 123);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orders";
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(749, 131);
            this.txtOrder.Multiline = true;
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(200, 212);
            this.txtOrder.TabIndex = 56;
            this.txtOrder.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(752, 115);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(33, 13);
            this.lblOrder.TabIndex = 59;
            this.lblOrder.Text = "Order";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(823, 538);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 13);
            this.lblTotal.TabIndex = 60;
            this.lblTotal.Text = "0";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(814, 502);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(13, 13);
            this.lblNumber.TabIndex = 61;
            this.lblNumber.Text = "0";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "\\\\weston.ac.uk\\home\\SkillsStudents\\WS257077\\My Documents\\Visual Studio 2012\\Proje" +
    "cts\\Vending machine with login system, assignment 3\\help.html";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(965, 635);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPurchaseOrder);
            this.Controls.Add(this.lblNumberLabel);
            this.Controls.Add(this.lblTotalLabel);
            this.Controls.Add(this.lblMarsBar);
            this.Controls.Add(this.lblGalaxy);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDairyMilk);
            this.Controls.Add(this.lblSprite);
            this.Controls.Add(this.lblFanta);
            this.Controls.Add(this.lblCocaCola);
            this.Controls.Add(this.lblVendingMachine);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Vending Machine";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.Label lblVendingMachine;
        private System.Windows.Forms.Label lblCocaCola;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.Label lblFanta;
        private System.Windows.Forms.Label lblSprite;
        private System.Windows.Forms.Label lblDairyMilk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblGalaxy;
        private System.Windows.Forms.Label lblMarsBar;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.Label lblNumberLabel;
        private System.Windows.Forms.Button btnPurchaseOrder;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

