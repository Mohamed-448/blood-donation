
namespace blood_donation
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.domonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDDvTitile = new System.Windows.Forms.Label();
            this.panelOpositive = new System.Windows.Forms.Panel();
            this.IblName = new System.Windows.Forms.Label();
            this.IblOpositiveCount = new System.Windows.Forms.Label();
            this.IblBloodGroup = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.IblOnegativeCount = new System.Windows.Forms.Label();
            this.IblOnegative = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.IblAnegativeCount = new System.Windows.Forms.Label();
            this.IblAnegative = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.IblApositiveCounte = new System.Windows.Forms.Label();
            this.IblApositive = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.IblABnegativeCount = new System.Windows.Forms.Label();
            this.IblABnegative = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.IblABpositiveCount = new System.Windows.Forms.Label();
            this.IblABpositive = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.IblBnegativeCount = new System.Windows.Forms.Label();
            this.IblBnegative = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.IblBpositiveCount = new System.Windows.Forms.Label();
            this.IblBpositive = new System.Windows.Forms.Label();
            this.dgvDonors = new System.Windows.Forms.DataGridView();
            this.IblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.menuStripTop.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panelOpositive.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripTop
            // 
            this.menuStripTop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.domonsToolStripMenuItem});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Size = new System.Drawing.Size(1135, 25);
            this.menuStripTop.TabIndex = 0;
            this.menuStripTop.Text = "menuStrip1";
            this.menuStripTop.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // domonsToolStripMenuItem
            // 
            this.domonsToolStripMenuItem.Name = "domonsToolStripMenuItem";
            this.domonsToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.domonsToolStripMenuItem.Text = "Donors";
            this.domonsToolStripMenuItem.Click += new System.EventHandler(this.domonsToolStripMenuItem_Click);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.SystemColors.Control;
            this.panelFooter.Controls.Add(this.lblDeveloper);
            this.panelFooter.Controls.Add(this.label1);
            this.panelFooter.Controls.Add(this.lblDDvTitile);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 571);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1135, 39);
            this.panelFooter.TabIndex = 1;
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.BackColor = System.Drawing.Color.White;
            this.lblDeveloper.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeveloper.ForeColor = System.Drawing.Color.Blue;
            this.lblDeveloper.Location = new System.Drawing.Point(635, 7);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(135, 30);
            this.lblDeveloper.TabIndex = 2;
            this.lblDeveloper.Text = "VIJAY THAPA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.label1.Location = new System.Drawing.Point(132, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Blood Bank Mangement System";
            // 
            // lblDDvTitile
            // 
            this.lblDDvTitile.AutoSize = true;
            this.lblDDvTitile.BackColor = System.Drawing.Color.White;
            this.lblDDvTitile.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDDvTitile.ForeColor = System.Drawing.Color.Black;
            this.lblDDvTitile.Location = new System.Drawing.Point(470, 7);
            this.lblDDvTitile.Name = "lblDDvTitile";
            this.lblDDvTitile.Size = new System.Drawing.Size(148, 30);
            this.lblDDvTitile.TabIndex = 0;
            this.lblDDvTitile.Text = "Developid By -";
            // 
            // panelOpositive
            // 
            this.panelOpositive.BackColor = System.Drawing.SystemColors.Control;
            this.panelOpositive.Controls.Add(this.IblName);
            this.panelOpositive.Controls.Add(this.IblOpositiveCount);
            this.panelOpositive.Controls.Add(this.IblBloodGroup);
            this.panelOpositive.Location = new System.Drawing.Point(13, 62);
            this.panelOpositive.Name = "panelOpositive";
            this.panelOpositive.Size = new System.Drawing.Size(200, 100);
            this.panelOpositive.TabIndex = 2;
            // 
            // IblName
            // 
            this.IblName.AutoSize = true;
            this.IblName.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblName.Location = new System.Drawing.Point(111, 63);
            this.IblName.Name = "IblName";
            this.IblName.Size = new System.Drawing.Size(60, 21);
            this.IblName.TabIndex = 2;
            this.IblName.Text = "Donors";
            // 
            // IblOpositiveCount
            // 
            this.IblOpositiveCount.AutoSize = true;
            this.IblOpositiveCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblOpositiveCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.IblOpositiveCount.Location = new System.Drawing.Point(107, 16);
            this.IblOpositiveCount.Name = "IblOpositiveCount";
            this.IblOpositiveCount.Size = new System.Drawing.Size(77, 47);
            this.IblOpositiveCount.TabIndex = 1;
            this.IblOpositiveCount.Text = "100";
            // 
            // IblBloodGroup
            // 
            this.IblBloodGroup.AutoSize = true;
            this.IblBloodGroup.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblBloodGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.IblBloodGroup.Location = new System.Drawing.Point(3, 16);
            this.IblBloodGroup.Name = "IblBloodGroup";
            this.IblBloodGroup.Size = new System.Drawing.Size(98, 65);
            this.IblBloodGroup.TabIndex = 0;
            this.IblBloodGroup.Text = "O+";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.IblOnegativeCount);
            this.panel1.Controls.Add(this.IblOnegative);
            this.panel1.Location = new System.Drawing.Point(229, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Donors";
            // 
            // IblOnegativeCount
            // 
            this.IblOnegativeCount.AutoSize = true;
            this.IblOnegativeCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblOnegativeCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.IblOnegativeCount.Location = new System.Drawing.Point(107, 16);
            this.IblOnegativeCount.Name = "IblOnegativeCount";
            this.IblOnegativeCount.Size = new System.Drawing.Size(77, 47);
            this.IblOnegativeCount.TabIndex = 1;
            this.IblOnegativeCount.Text = "100";
            // 
            // IblOnegative
            // 
            this.IblOnegative.AutoSize = true;
            this.IblOnegative.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblOnegative.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.IblOnegative.Location = new System.Drawing.Point(3, 16);
            this.IblOnegative.Name = "IblOnegative";
            this.IblOnegative.Size = new System.Drawing.Size(83, 65);
            this.IblOnegative.TabIndex = 0;
            this.IblOnegative.Text = "O-";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.IblAnegativeCount);
            this.panel2.Controls.Add(this.IblAnegative);
            this.panel2.Location = new System.Drawing.Point(229, 195);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(111, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Donors";
            // 
            // IblAnegativeCount
            // 
            this.IblAnegativeCount.AutoSize = true;
            this.IblAnegativeCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblAnegativeCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.IblAnegativeCount.Location = new System.Drawing.Point(107, 16);
            this.IblAnegativeCount.Name = "IblAnegativeCount";
            this.IblAnegativeCount.Size = new System.Drawing.Size(77, 47);
            this.IblAnegativeCount.TabIndex = 1;
            this.IblAnegativeCount.Text = "100";
            // 
            // IblAnegative
            // 
            this.IblAnegative.AutoSize = true;
            this.IblAnegative.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblAnegative.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.IblAnegative.Location = new System.Drawing.Point(3, 16);
            this.IblAnegative.Name = "IblAnegative";
            this.IblAnegative.Size = new System.Drawing.Size(81, 65);
            this.IblAnegative.TabIndex = 0;
            this.IblAnegative.Text = "A-";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.IblApositiveCounte);
            this.panel3.Controls.Add(this.IblApositive);
            this.panel3.Location = new System.Drawing.Point(13, 195);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(111, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "Donors";
            // 
            // IblApositiveCounte
            // 
            this.IblApositiveCounte.AutoSize = true;
            this.IblApositiveCounte.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblApositiveCounte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.IblApositiveCounte.Location = new System.Drawing.Point(107, 16);
            this.IblApositiveCounte.Name = "IblApositiveCounte";
            this.IblApositiveCounte.Size = new System.Drawing.Size(77, 47);
            this.IblApositiveCounte.TabIndex = 1;
            this.IblApositiveCounte.Text = "100";
            // 
            // IblApositive
            // 
            this.IblApositive.AutoSize = true;
            this.IblApositive.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblApositive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.IblApositive.Location = new System.Drawing.Point(3, 16);
            this.IblApositive.Name = "IblApositive";
            this.IblApositive.Size = new System.Drawing.Size(96, 65);
            this.IblApositive.TabIndex = 0;
            this.IblApositive.Text = "A+";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.IblABnegativeCount);
            this.panel4.Controls.Add(this.IblABnegative);
            this.panel4.Location = new System.Drawing.Point(229, 452);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(111, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 21);
            this.label11.TabIndex = 2;
            this.label11.Text = "Donors";
            // 
            // IblABnegativeCount
            // 
            this.IblABnegativeCount.AutoSize = true;
            this.IblABnegativeCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblABnegativeCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.IblABnegativeCount.Location = new System.Drawing.Point(107, 16);
            this.IblABnegativeCount.Name = "IblABnegativeCount";
            this.IblABnegativeCount.Size = new System.Drawing.Size(77, 47);
            this.IblABnegativeCount.TabIndex = 1;
            this.IblABnegativeCount.Text = "100";
            // 
            // IblABnegative
            // 
            this.IblABnegative.AutoSize = true;
            this.IblABnegative.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblABnegative.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.IblABnegative.Location = new System.Drawing.Point(3, 16);
            this.IblABnegative.Name = "IblABnegative";
            this.IblABnegative.Size = new System.Drawing.Size(112, 65);
            this.IblABnegative.TabIndex = 0;
            this.IblABnegative.Text = "AB-";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.IblABpositiveCount);
            this.panel5.Controls.Add(this.IblABpositive);
            this.panel5.Location = new System.Drawing.Point(13, 452);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(111, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 21);
            this.label14.TabIndex = 2;
            this.label14.Text = "Donors";
            // 
            // IblABpositiveCount
            // 
            this.IblABpositiveCount.AutoSize = true;
            this.IblABpositiveCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblABpositiveCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.IblABpositiveCount.Location = new System.Drawing.Point(107, 16);
            this.IblABpositiveCount.Name = "IblABpositiveCount";
            this.IblABpositiveCount.Size = new System.Drawing.Size(77, 47);
            this.IblABpositiveCount.TabIndex = 1;
            this.IblABpositiveCount.Text = "100";
            // 
            // IblABpositive
            // 
            this.IblABpositive.AutoSize = true;
            this.IblABpositive.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblABpositive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.IblABpositive.Location = new System.Drawing.Point(3, 16);
            this.IblABpositive.Name = "IblABpositive";
            this.IblABpositive.Size = new System.Drawing.Size(127, 65);
            this.IblABpositive.TabIndex = 0;
            this.IblABpositive.Text = "AB+";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Controls.Add(this.label17);
            this.panel6.Controls.Add(this.IblBnegativeCount);
            this.panel6.Controls.Add(this.IblBnegative);
            this.panel6.Location = new System.Drawing.Point(229, 327);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 100);
            this.panel6.TabIndex = 7;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(111, 63);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 21);
            this.label17.TabIndex = 2;
            this.label17.Text = "Donors";
            // 
            // IblBnegativeCount
            // 
            this.IblBnegativeCount.AutoSize = true;
            this.IblBnegativeCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblBnegativeCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.IblBnegativeCount.Location = new System.Drawing.Point(107, 16);
            this.IblBnegativeCount.Name = "IblBnegativeCount";
            this.IblBnegativeCount.Size = new System.Drawing.Size(77, 47);
            this.IblBnegativeCount.TabIndex = 1;
            this.IblBnegativeCount.Text = "100";
            // 
            // IblBnegative
            // 
            this.IblBnegative.AutoSize = true;
            this.IblBnegative.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblBnegative.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.IblBnegative.Location = new System.Drawing.Point(3, 16);
            this.IblBnegative.Name = "IblBnegative";
            this.IblBnegative.Size = new System.Drawing.Size(78, 65);
            this.IblBnegative.TabIndex = 0;
            this.IblBnegative.Text = "B-";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.panel7.Controls.Add(this.label20);
            this.panel7.Controls.Add(this.IblBpositiveCount);
            this.panel7.Controls.Add(this.IblBpositive);
            this.panel7.Location = new System.Drawing.Point(13, 327);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 100);
            this.panel7.TabIndex = 6;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(111, 63);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(60, 21);
            this.label20.TabIndex = 2;
            this.label20.Text = "Donors";
            // 
            // IblBpositiveCount
            // 
            this.IblBpositiveCount.AutoSize = true;
            this.IblBpositiveCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblBpositiveCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.IblBpositiveCount.Location = new System.Drawing.Point(107, 16);
            this.IblBpositiveCount.Name = "IblBpositiveCount";
            this.IblBpositiveCount.Size = new System.Drawing.Size(77, 47);
            this.IblBpositiveCount.TabIndex = 1;
            this.IblBpositiveCount.Text = "100";
            // 
            // IblBpositive
            // 
            this.IblBpositive.AutoSize = true;
            this.IblBpositive.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblBpositive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.IblBpositive.Location = new System.Drawing.Point(3, 16);
            this.IblBpositive.Name = "IblBpositive";
            this.IblBpositive.Size = new System.Drawing.Size(93, 65);
            this.IblBpositive.TabIndex = 0;
            this.IblBpositive.Text = "B+";
            // 
            // dgvDonors
            // 
            this.dgvDonors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonors.Location = new System.Drawing.Point(475, 141);
            this.dgvDonors.Name = "dgvDonors";
            this.dgvDonors.Size = new System.Drawing.Size(533, 411);
            this.dgvDonors.TabIndex = 10;
            // 
            // IblSearch
            // 
            this.IblSearch.AutoSize = true;
            this.IblSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblSearch.Location = new System.Drawing.Point(459, 101);
            this.IblSearch.Name = "IblSearch";
            this.IblSearch.Size = new System.Drawing.Size(109, 21);
            this.IblSearch.TabIndex = 11;
            this.IblSearch.Text = "Search Donor";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(567, 97);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(441, 29);
            this.txtSearch.TabIndex = 12;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(966, 0);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(42, 25);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 13;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1135, 610);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.IblSearch);
            this.Controls.Add(this.dgvDonors);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelOpositive);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.menuStripTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.panelOpositive.ResumeLayout(false);
            this.panelOpositive.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripTop;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem domonsToolStripMenuItem;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDDvTitile;
        private System.Windows.Forms.Panel panelOpositive;
        private System.Windows.Forms.Label IblName;
        private System.Windows.Forms.Label IblOpositiveCount;
        private System.Windows.Forms.Label IblBloodGroup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IblOnegativeCount;
        private System.Windows.Forms.Label IblOnegative;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label IblAnegativeCount;
        private System.Windows.Forms.Label IblAnegative;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label IblApositiveCounte;
        private System.Windows.Forms.Label IblApositive;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label IblABnegativeCount;
        private System.Windows.Forms.Label IblABnegative;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label IblABpositiveCount;
        private System.Windows.Forms.Label IblABpositive;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label IblBnegativeCount;
        private System.Windows.Forms.Label IblBnegative;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label IblBpositiveCount;
        private System.Windows.Forms.Label IblBpositive;
        private System.Windows.Forms.DataGridView dgvDonors;
        private System.Windows.Forms.Label IblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBoxClose;
    }
}

