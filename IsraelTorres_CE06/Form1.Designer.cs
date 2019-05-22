namespace IsraelTorres_CE06
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLeg = new System.Windows.Forms.TabPage();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBoxLeg = new System.Windows.Forms.GroupBox();
            this.labelMode = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelMiles = new System.Windows.Forms.Label();
            this.textBoxMode = new System.Windows.Forms.TextBox();
            this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMiles = new System.Windows.Forms.NumericUpDown();
            this.labelDirection = new System.Windows.Forms.Label();
            this.comboBoxDirection = new System.Windows.Forms.ComboBox();
            this.tabPageTotals = new System.Windows.Forms.TabPage();
            this.labelTotalLegs = new System.Windows.Forms.Label();
            this.labelTotalHours = new System.Windows.Forms.Label();
            this.labelTotalMiles = new System.Windows.Forms.Label();
            this.textBoxTotalLegs = new System.Windows.Forms.TextBox();
            this.textBoxTotalHours = new System.Windows.Forms.TextBox();
            this.textBoxTotalMiles = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageLeg.SuspendLayout();
            this.groupBoxLeg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMiles)).BeginInit();
            this.tabPageTotals.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::IsraelTorres_CE06.Properties.Resources.document;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + N";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(262, 38);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(259, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(262, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "rightArrow.jpg");
            this.imageList1.Images.SetKeyName(1, "leftArrow.jpg");
            this.imageList1.Images.SetKeyName(2, "upArrow.jpg");
            this.imageList1.Images.SetKeyName(3, "downArrow.jpg");
            this.imageList1.Images.SetKeyName(4, "gearIcon.png");
            this.imageList1.Images.SetKeyName(5, "document.png");
            this.imageList1.Images.SetKeyName(6, "plusSign.png");
            this.imageList1.Images.SetKeyName(7, "xIcon.png");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageLeg);
            this.tabControl1.Controls.Add(this.tabPageTotals);
            this.tabControl1.Location = new System.Drawing.Point(12, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(391, 549);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageLeg
            // 
            this.tabPageLeg.Controls.Add(this.buttonAdd);
            this.tabPageLeg.Controls.Add(this.groupBoxLeg);
            this.tabPageLeg.Location = new System.Drawing.Point(8, 39);
            this.tabPageLeg.Name = "tabPageLeg";
            this.tabPageLeg.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLeg.Size = new System.Drawing.Size(375, 502);
            this.tabPageLeg.TabIndex = 0;
            this.tabPageLeg.Text = "Leg";
            this.tabPageLeg.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(7, 424);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(362, 65);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBoxLeg
            // 
            this.groupBoxLeg.Controls.Add(this.labelMode);
            this.groupBoxLeg.Controls.Add(this.labelHours);
            this.groupBoxLeg.Controls.Add(this.labelMiles);
            this.groupBoxLeg.Controls.Add(this.textBoxMode);
            this.groupBoxLeg.Controls.Add(this.numericUpDownHours);
            this.groupBoxLeg.Controls.Add(this.numericUpDownMiles);
            this.groupBoxLeg.Controls.Add(this.labelDirection);
            this.groupBoxLeg.Controls.Add(this.comboBoxDirection);
            this.groupBoxLeg.Location = new System.Drawing.Point(7, 7);
            this.groupBoxLeg.Name = "groupBoxLeg";
            this.groupBoxLeg.Size = new System.Drawing.Size(362, 411);
            this.groupBoxLeg.TabIndex = 0;
            this.groupBoxLeg.TabStop = false;
            this.groupBoxLeg.Text = "Leg";
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Location = new System.Drawing.Point(6, 198);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(66, 25);
            this.labelMode.TabIndex = 7;
            this.labelMode.Text = "Mode";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(6, 143);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(69, 25);
            this.labelHours.TabIndex = 6;
            this.labelHours.Text = "Hours";
            // 
            // labelMiles
            // 
            this.labelMiles.AutoSize = true;
            this.labelMiles.Location = new System.Drawing.Point(6, 89);
            this.labelMiles.Name = "labelMiles";
            this.labelMiles.Size = new System.Drawing.Size(63, 25);
            this.labelMiles.TabIndex = 5;
            this.labelMiles.Text = "Miles";
            // 
            // textBoxMode
            // 
            this.textBoxMode.Location = new System.Drawing.Point(154, 195);
            this.textBoxMode.Name = "textBoxMode";
            this.textBoxMode.Size = new System.Drawing.Size(189, 31);
            this.textBoxMode.TabIndex = 4;
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.DecimalPlaces = 2;
            this.numericUpDownHours.Location = new System.Drawing.Point(154, 141);
            this.numericUpDownHours.Name = "numericUpDownHours";
            this.numericUpDownHours.Size = new System.Drawing.Size(189, 31);
            this.numericUpDownHours.TabIndex = 3;
            // 
            // numericUpDownMiles
            // 
            this.numericUpDownMiles.DecimalPlaces = 2;
            this.numericUpDownMiles.Location = new System.Drawing.Point(154, 87);
            this.numericUpDownMiles.Name = "numericUpDownMiles";
            this.numericUpDownMiles.Size = new System.Drawing.Size(189, 31);
            this.numericUpDownMiles.TabIndex = 2;
            // 
            // labelDirection
            // 
            this.labelDirection.AutoSize = true;
            this.labelDirection.Location = new System.Drawing.Point(6, 34);
            this.labelDirection.Name = "labelDirection";
            this.labelDirection.Size = new System.Drawing.Size(97, 25);
            this.labelDirection.TabIndex = 1;
            this.labelDirection.Text = "Direction";
            // 
            // comboBoxDirection
            // 
            this.comboBoxDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDirection.FormattingEnabled = true;
            this.comboBoxDirection.Items.AddRange(new object[] {
            "Nowhere",
            "East",
            "West",
            "North",
            "South"});
            this.comboBoxDirection.Location = new System.Drawing.Point(154, 31);
            this.comboBoxDirection.Name = "comboBoxDirection";
            this.comboBoxDirection.Size = new System.Drawing.Size(189, 33);
            this.comboBoxDirection.TabIndex = 0;
            // 
            // tabPageTotals
            // 
            this.tabPageTotals.Controls.Add(this.labelTotalLegs);
            this.tabPageTotals.Controls.Add(this.labelTotalHours);
            this.tabPageTotals.Controls.Add(this.labelTotalMiles);
            this.tabPageTotals.Controls.Add(this.textBoxTotalLegs);
            this.tabPageTotals.Controls.Add(this.textBoxTotalHours);
            this.tabPageTotals.Controls.Add(this.textBoxTotalMiles);
            this.tabPageTotals.Location = new System.Drawing.Point(8, 39);
            this.tabPageTotals.Name = "tabPageTotals";
            this.tabPageTotals.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTotals.Size = new System.Drawing.Size(375, 502);
            this.tabPageTotals.TabIndex = 1;
            this.tabPageTotals.Text = "Totals";
            this.tabPageTotals.UseVisualStyleBackColor = true;
            // 
            // labelTotalLegs
            // 
            this.labelTotalLegs.AutoSize = true;
            this.labelTotalLegs.Location = new System.Drawing.Point(6, 140);
            this.labelTotalLegs.Name = "labelTotalLegs";
            this.labelTotalLegs.Size = new System.Drawing.Size(59, 25);
            this.labelTotalLegs.TabIndex = 5;
            this.labelTotalLegs.Text = "Legs";
            // 
            // labelTotalHours
            // 
            this.labelTotalHours.AutoSize = true;
            this.labelTotalHours.Location = new System.Drawing.Point(6, 86);
            this.labelTotalHours.Name = "labelTotalHours";
            this.labelTotalHours.Size = new System.Drawing.Size(69, 25);
            this.labelTotalHours.TabIndex = 4;
            this.labelTotalHours.Text = "Hours";
            // 
            // labelTotalMiles
            // 
            this.labelTotalMiles.AutoSize = true;
            this.labelTotalMiles.Location = new System.Drawing.Point(6, 29);
            this.labelTotalMiles.Name = "labelTotalMiles";
            this.labelTotalMiles.Size = new System.Drawing.Size(63, 25);
            this.labelTotalMiles.TabIndex = 3;
            this.labelTotalMiles.Text = "Miles";
            // 
            // textBoxTotalLegs
            // 
            this.textBoxTotalLegs.Location = new System.Drawing.Point(137, 137);
            this.textBoxTotalLegs.Name = "textBoxTotalLegs";
            this.textBoxTotalLegs.ReadOnly = true;
            this.textBoxTotalLegs.Size = new System.Drawing.Size(212, 31);
            this.textBoxTotalLegs.TabIndex = 2;
            // 
            // textBoxTotalHours
            // 
            this.textBoxTotalHours.Location = new System.Drawing.Point(137, 83);
            this.textBoxTotalHours.Name = "textBoxTotalHours";
            this.textBoxTotalHours.ReadOnly = true;
            this.textBoxTotalHours.Size = new System.Drawing.Size(212, 31);
            this.textBoxTotalHours.TabIndex = 1;
            // 
            // textBoxTotalMiles
            // 
            this.textBoxTotalMiles.Location = new System.Drawing.Point(137, 26);
            this.textBoxTotalMiles.Name = "textBoxTotalMiles";
            this.textBoxTotalMiles.ReadOnly = true;
            this.textBoxTotalMiles.Size = new System.Drawing.Size(212, 31);
            this.textBoxTotalMiles.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(409, 57);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(413, 549);
            this.treeView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 618);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Travel Planner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageLeg.ResumeLayout(false);
            this.groupBoxLeg.ResumeLayout(false);
            this.groupBoxLeg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMiles)).EndInit();
            this.tabPageTotals.ResumeLayout(false);
            this.tabPageTotals.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageLeg;
        private System.Windows.Forms.GroupBox groupBoxLeg;
        private System.Windows.Forms.ComboBox comboBoxDirection;
        private System.Windows.Forms.TabPage tabPageTotals;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelDirection;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label labelMiles;
        private System.Windows.Forms.TextBox textBoxMode;
        private System.Windows.Forms.NumericUpDown numericUpDownHours;
        private System.Windows.Forms.NumericUpDown numericUpDownMiles;
        private System.Windows.Forms.TextBox textBoxTotalLegs;
        private System.Windows.Forms.TextBox textBoxTotalHours;
        private System.Windows.Forms.TextBox textBoxTotalMiles;
        private System.Windows.Forms.Label labelTotalLegs;
        private System.Windows.Forms.Label labelTotalHours;
        private System.Windows.Forms.Label labelTotalMiles;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

