
namespace SwitchProjectTest
{
    partial class MainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_checkbox = new System.Windows.Forms.Button();
            this.listBox_appz = new System.Windows.Forms.ListBox();
            this.clb_appz = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_workfolder = new System.Windows.Forms.TextBox();
            this.btn_workfolder = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rtb_console = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.patchNotes = new System.Windows.Forms.GroupBox();
            this.rtb_releasebdy = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rtb_description = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rtb_releasedate = new System.Windows.Forms.RichTextBox();
            this.btn_download = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.patchNotes.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btn_checkbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBox_appz, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.clb_appz, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_download, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1143, 590);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // btn_checkbox
            // 
            this.btn_checkbox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_checkbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_checkbox.Enabled = false;
            this.btn_checkbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_checkbox.Location = new System.Drawing.Point(153, 53);
            this.btn_checkbox.Name = "btn_checkbox";
            this.btn_checkbox.Size = new System.Drawing.Size(69, 399);
            this.btn_checkbox.TabIndex = 9;
            this.btn_checkbox.Text = "Click to Lock";
            this.btn_checkbox.UseVisualStyleBackColor = false;
            this.btn_checkbox.Click += new System.EventHandler(this.btn_checkbox_Click);
            // 
            // listBox_appz
            // 
            this.listBox_appz.BackColor = System.Drawing.SystemColors.ControlDark;
            this.listBox_appz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_appz.Enabled = false;
            this.listBox_appz.FormattingEnabled = true;
            this.listBox_appz.Location = new System.Drawing.Point(228, 53);
            this.listBox_appz.Name = "listBox_appz";
            this.listBox_appz.Size = new System.Drawing.Size(144, 399);
            this.listBox_appz.Sorted = true;
            this.listBox_appz.TabIndex = 18;
            this.listBox_appz.SelectedIndexChanged += new System.EventHandler(this.listBox_appz_SelectedIndexChanged);
            // 
            // clb_appz
            // 
            this.clb_appz.BackColor = System.Drawing.SystemColors.ControlDark;
            this.clb_appz.CheckOnClick = true;
            this.clb_appz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clb_appz.FormattingEnabled = true;
            this.clb_appz.Location = new System.Drawing.Point(3, 53);
            this.clb_appz.Name = "clb_appz";
            this.clb_appz.Size = new System.Drawing.Size(144, 399);
            this.clb_appz.Sorted = true;
            this.clb_appz.TabIndex = 6;
            this.clb_appz.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clb_appz_ItemCheck);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.tb_workfolder);
            this.groupBox2.Controls.Add(this.btn_workfolder);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(378, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(762, 44);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Work Folder";
            // 
            // tb_workfolder
            // 
            this.tb_workfolder.Dock = System.Windows.Forms.DockStyle.Left;
            this.tb_workfolder.Enabled = false;
            this.tb_workfolder.Location = new System.Drawing.Point(3, 16);
            this.tb_workfolder.Name = "tb_workfolder";
            this.tb_workfolder.Size = new System.Drawing.Size(196, 20);
            this.tb_workfolder.TabIndex = 10;
            this.tb_workfolder.Text = "This must be set";
            // 
            // btn_workfolder
            // 
            this.btn_workfolder.Location = new System.Drawing.Point(205, 13);
            this.btn_workfolder.Name = "btn_workfolder";
            this.btn_workfolder.Size = new System.Drawing.Size(75, 23);
            this.btn_workfolder.TabIndex = 11;
            this.btn_workfolder.Text = "Browse";
            this.btn_workfolder.UseVisualStyleBackColor = true;
            this.btn_workfolder.Click += new System.EventHandler(this.btn_workfolder_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rtb_console);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(378, 458);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(762, 129);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Console";
            // 
            // rtb_console
            // 
            this.rtb_console.BackColor = System.Drawing.Color.Salmon;
            this.rtb_console.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_console.Location = new System.Drawing.Point(3, 16);
            this.rtb_console.Name = "rtb_console";
            this.rtb_console.ReadOnly = true;
            this.rtb_console.Size = new System.Drawing.Size(756, 110);
            this.rtb_console.TabIndex = 0;
            this.rtb_console.Text = "";
            this.rtb_console.TextChanged += new System.EventHandler(this.rtb_console_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.patchNotes);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(378, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 399);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // patchNotes
            // 
            this.patchNotes.Controls.Add(this.rtb_releasebdy);
            this.patchNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patchNotes.Location = new System.Drawing.Point(3, 106);
            this.patchNotes.Name = "patchNotes";
            this.patchNotes.Size = new System.Drawing.Size(756, 290);
            this.patchNotes.TabIndex = 19;
            this.patchNotes.TabStop = false;
            this.patchNotes.Text = "Patchnotes";
            // 
            // rtb_releasebdy
            // 
            this.rtb_releasebdy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rtb_releasebdy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_releasebdy.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_releasebdy.Location = new System.Drawing.Point(3, 16);
            this.rtb_releasebdy.Name = "rtb_releasebdy";
            this.rtb_releasebdy.ReadOnly = true;
            this.rtb_releasebdy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rtb_releasebdy.Size = new System.Drawing.Size(750, 271);
            this.rtb_releasebdy.TabIndex = 7;
            this.rtb_releasebdy.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rtb_description);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(3, 61);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(756, 45);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Description";
            // 
            // rtb_description
            // 
            this.rtb_description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_description.Location = new System.Drawing.Point(3, 16);
            this.rtb_description.Name = "rtb_description";
            this.rtb_description.ReadOnly = true;
            this.rtb_description.Size = new System.Drawing.Size(750, 26);
            this.rtb_description.TabIndex = 0;
            this.rtb_description.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.rtb_releasedate);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(756, 45);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Release date";
            // 
            // rtb_releasedate
            // 
            this.rtb_releasedate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_releasedate.Location = new System.Drawing.Point(3, 16);
            this.rtb_releasedate.Name = "rtb_releasedate";
            this.rtb_releasedate.ReadOnly = true;
            this.rtb_releasedate.Size = new System.Drawing.Size(750, 26);
            this.rtb_releasedate.TabIndex = 0;
            this.rtb_releasedate.Text = "";
            // 
            // btn_download
            // 
            this.btn_download.Enabled = false;
            this.btn_download.Location = new System.Drawing.Point(153, 458);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(69, 23);
            this.btn_download.TabIndex = 24;
            this.btn_download.Text = "Download";
            this.btn_download.UseVisualStyleBackColor = true;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(228, 458);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(144, 23);
            this.progressBar1.TabIndex = 25;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 590);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "CnD";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.patchNotes.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_checkbox;
        private System.Windows.Forms.ListBox listBox_appz;
        private System.Windows.Forms.CheckedListBox clb_appz;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_workfolder;
        private System.Windows.Forms.Button btn_workfolder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtb_releasedate;
        private System.Windows.Forms.GroupBox patchNotes;
        private System.Windows.Forms.RichTextBox rtb_releasebdy;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox rtb_console;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox rtb_description;
        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}