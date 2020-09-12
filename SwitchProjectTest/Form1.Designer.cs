namespace SwitchProjectTest
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
            this.btn_atmo = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnGetRe = new System.Windows.Forms.Button();
            this.btn_check = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clb_appz = new System.Windows.Forms.CheckedListBox();
            this.rtb_releasebdy = new System.Windows.Forms.RichTextBox();
            this.btn_checkbox = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tb_workfolder = new System.Windows.Forms.TextBox();
            this.btn_workfolder = new System.Windows.Forms.Button();
            this.btn_checkreleases = new System.Windows.Forms.Button();
            this.btn_CheckAssets = new System.Windows.Forms.Button();
            this.tb_assetcount = new System.Windows.Forms.TextBox();
            this.btn_looparray = new System.Windows.Forms.Button();
            this.btn_testlatest = new System.Windows.Forms.Button();
            this.btn_printlatestrls = new System.Windows.Forms.Button();
            this.listBox_appz = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_atmo
            // 
            this.btn_atmo.Location = new System.Drawing.Point(12, 566);
            this.btn_atmo.Name = "btn_atmo";
            this.btn_atmo.Size = new System.Drawing.Size(138, 31);
            this.btn_atmo.TabIndex = 0;
            this.btn_atmo.Text = "Child_btn_atmos";
            this.btn_atmo.UseVisualStyleBackColor = true;
            this.btn_atmo.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(287, 612);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(347, 337);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 301);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(246, 172);
            this.treeView1.TabIndex = 2;
            // 
            // btnGetRe
            // 
            this.btnGetRe.Location = new System.Drawing.Point(12, 603);
            this.btnGetRe.Name = "btnGetRe";
            this.btnGetRe.Size = new System.Drawing.Size(139, 23);
            this.btnGetRe.TabIndex = 3;
            this.btnGetRe.Text = "Child_btn_hekate";
            this.btnGetRe.UseVisualStyleBackColor = true;
            this.btnGetRe.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(12, 632);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(180, 23);
            this.btn_check.TabIndex = 4;
            this.btn_check.Text = "Check Repository";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1484, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // clb_appz
            // 
            this.clb_appz.CheckOnClick = true;
            this.clb_appz.FormattingEnabled = true;
            this.clb_appz.Location = new System.Drawing.Point(12, 27);
            this.clb_appz.Name = "clb_appz";
            this.clb_appz.Size = new System.Drawing.Size(164, 214);
            this.clb_appz.TabIndex = 6;
            this.clb_appz.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clb_appz_ItemCheck);
            // 
            // rtb_releasebdy
            // 
            this.rtb_releasebdy.BackColor = System.Drawing.SystemColors.ControlDark;
            this.rtb_releasebdy.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_releasebdy.Location = new System.Drawing.Point(17, 19);
            this.rtb_releasebdy.Name = "rtb_releasebdy";
            this.rtb_releasebdy.ReadOnly = true;
            this.rtb_releasebdy.Size = new System.Drawing.Size(434, 478);
            this.rtb_releasebdy.TabIndex = 7;
            this.rtb_releasebdy.Text = "";
            // 
            // btn_checkbox
            // 
            this.btn_checkbox.BackColor = System.Drawing.SystemColors.Control;
            this.btn_checkbox.Enabled = false;
            this.btn_checkbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_checkbox.Location = new System.Drawing.Point(37, 247);
            this.btn_checkbox.Name = "btn_checkbox";
            this.btn_checkbox.Size = new System.Drawing.Size(75, 23);
            this.btn_checkbox.TabIndex = 9;
            this.btn_checkbox.Text = "Checkbox!";
            this.btn_checkbox.UseVisualStyleBackColor = false;
            this.btn_checkbox.Click += new System.EventHandler(this.btn_checkbox_Click);
            // 
            // tb_workfolder
            // 
            this.tb_workfolder.Enabled = false;
            this.tb_workfolder.Location = new System.Drawing.Point(763, 929);
            this.tb_workfolder.Name = "tb_workfolder";
            this.tb_workfolder.Size = new System.Drawing.Size(328, 20);
            this.tb_workfolder.TabIndex = 10;
            this.tb_workfolder.Text = "Working Folder";
            this.tb_workfolder.TextChanged += new System.EventHandler(this.tb_workfolder_TextChanged);
            // 
            // btn_workfolder
            // 
            this.btn_workfolder.Location = new System.Drawing.Point(1097, 926);
            this.btn_workfolder.Name = "btn_workfolder";
            this.btn_workfolder.Size = new System.Drawing.Size(75, 23);
            this.btn_workfolder.TabIndex = 11;
            this.btn_workfolder.Text = "Browse";
            this.btn_workfolder.UseVisualStyleBackColor = true;
            this.btn_workfolder.Click += new System.EventHandler(this.btn_workfolder_Click);
            // 
            // btn_checkreleases
            // 
            this.btn_checkreleases.Location = new System.Drawing.Point(13, 508);
            this.btn_checkreleases.Name = "btn_checkreleases";
            this.btn_checkreleases.Size = new System.Drawing.Size(138, 23);
            this.btn_checkreleases.TabIndex = 12;
            this.btn_checkreleases.Text = "Check Releases";
            this.btn_checkreleases.UseVisualStyleBackColor = true;
            this.btn_checkreleases.Click += new System.EventHandler(this.btn_checkreleases_Click);
            // 
            // btn_CheckAssets
            // 
            this.btn_CheckAssets.Location = new System.Drawing.Point(12, 537);
            this.btn_CheckAssets.Name = "btn_CheckAssets";
            this.btn_CheckAssets.Size = new System.Drawing.Size(138, 23);
            this.btn_CheckAssets.TabIndex = 13;
            this.btn_CheckAssets.Text = "Check Assets";
            this.btn_CheckAssets.UseVisualStyleBackColor = true;
            this.btn_CheckAssets.Click += new System.EventHandler(this.btn_CheckAssets_Click);
            // 
            // tb_assetcount
            // 
            this.tb_assetcount.Location = new System.Drawing.Point(156, 537);
            this.tb_assetcount.Name = "tb_assetcount";
            this.tb_assetcount.Size = new System.Drawing.Size(100, 20);
            this.tb_assetcount.TabIndex = 14;
            // 
            // btn_looparray
            // 
            this.btn_looparray.Location = new System.Drawing.Point(13, 479);
            this.btn_looparray.Name = "btn_looparray";
            this.btn_looparray.Size = new System.Drawing.Size(75, 23);
            this.btn_looparray.TabIndex = 15;
            this.btn_looparray.Text = "Loop Array";
            this.btn_looparray.UseVisualStyleBackColor = true;
            this.btn_looparray.Click += new System.EventHandler(this.btn_looparray_Click);
            // 
            // btn_testlatest
            // 
            this.btn_testlatest.Location = new System.Drawing.Point(640, 900);
            this.btn_testlatest.Name = "btn_testlatest";
            this.btn_testlatest.Size = new System.Drawing.Size(120, 23);
            this.btn_testlatest.TabIndex = 16;
            this.btn_testlatest.Text = "Test Latest Method";
            this.btn_testlatest.UseVisualStyleBackColor = true;
            this.btn_testlatest.Click += new System.EventHandler(this.btn_testlatest_Click);
            // 
            // btn_printlatestrls
            // 
            this.btn_printlatestrls.Location = new System.Drawing.Point(640, 926);
            this.btn_printlatestrls.Name = "btn_printlatestrls";
            this.btn_printlatestrls.Size = new System.Drawing.Size(120, 23);
            this.btn_printlatestrls.TabIndex = 17;
            this.btn_printlatestrls.Text = "Print Latest Rls";
            this.btn_printlatestrls.UseVisualStyleBackColor = true;
            this.btn_printlatestrls.Click += new System.EventHandler(this.btn_printlatestrls_Click);
            // 
            // listBox_appz
            // 
            this.listBox_appz.FormattingEnabled = true;
            this.listBox_appz.Location = new System.Drawing.Point(3, 3);
            this.listBox_appz.Name = "listBox_appz";
            this.listBox_appz.Size = new System.Drawing.Size(149, 498);
            this.listBox_appz.Sorted = true;
            this.listBox_appz.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtb_releasebdy);
            this.groupBox1.Location = new System.Drawing.Point(161, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 510);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patchnotes";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBox_appz, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(849, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(635, 595);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1484, 961);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_printlatestrls);
            this.Controls.Add(this.btn_testlatest);
            this.Controls.Add(this.btn_looparray);
            this.Controls.Add(this.tb_assetcount);
            this.Controls.Add(this.btn_CheckAssets);
            this.Controls.Add(this.btn_checkreleases);
            this.Controls.Add(this.btn_workfolder);
            this.Controls.Add(this.tb_workfolder);
            this.Controls.Add(this.btn_checkbox);
            this.Controls.Add(this.clb_appz);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.btnGetRe);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_atmo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1500, 1000);
            this.Name = "Form1";
            this.Text = "Github CnD";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_atmo;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnGetRe;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox clb_appz;
        private System.Windows.Forms.RichTextBox rtb_releasebdy;
        private System.Windows.Forms.Button btn_checkbox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox tb_workfolder;
        private System.Windows.Forms.Button btn_workfolder;
        private System.Windows.Forms.Button btn_checkreleases;
        private System.Windows.Forms.Button btn_CheckAssets;
        private System.Windows.Forms.TextBox tb_assetcount;
        private System.Windows.Forms.Button btn_looparray;
        private System.Windows.Forms.Button btn_testlatest;
        private System.Windows.Forms.Button btn_printlatestrls;
        private System.Windows.Forms.ListBox listBox_appz;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}