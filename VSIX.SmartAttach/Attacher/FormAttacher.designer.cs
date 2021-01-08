namespace Geeks.VSIX.SmartAttach.Attacher
{
    partial class FormAttacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        System.ComponentModel.IContainer components = null;

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
        void InitializeComponent()
        {
            this.ProcessListLoader = new System.ComponentModel.BackgroundWorker();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtSearchProcess = new System.Windows.Forms.TextBox();
            this.checkBoxExcludeMSharp = new System.Windows.Forms.CheckBox();
            this.btnOriginal = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAttachToAll = new System.Windows.Forms.Button();
            this.btnAttach = new System.Windows.Forms.Button();
            this.listBoxProcess = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProcessListLoader
            // 
            this.ProcessListLoader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ProcessListLoader_DoWork);
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusBar.Location = new System.Drawing.Point(0, 363);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(606, 22);
            this.statusBar.TabIndex = 9;
            this.statusBar.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 17);
            this.lblStatus.Text = "Ready.";
            // 
            // txtSearchProcess
            // 
            this.txtSearchProcess.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSearchProcess.Location = new System.Drawing.Point(12, 15);
            this.txtSearchProcess.Name = "txtSearchProcess";
            this.txtSearchProcess.Size = new System.Drawing.Size(496, 20);
            this.txtSearchProcess.TabIndex = 10;
            this.txtSearchProcess.TextChanged += new System.EventHandler(this.txtSearchProcess_TextChanged);
            // 
            // checkBoxExcludeMSharp
            // 
            this.checkBoxExcludeMSharp.AutoSize = true;
            this.checkBoxExcludeMSharp.Enabled = false;
            this.checkBoxExcludeMSharp.Location = new System.Drawing.Point(520, 18);
            this.checkBoxExcludeMSharp.Name = "checkBoxExcludeMSharp";
            this.checkBoxExcludeMSharp.Size = new System.Drawing.Size(83, 17);
            this.checkBoxExcludeMSharp.TabIndex = 9;
            this.checkBoxExcludeMSharp.Text = "Exclude M#";
            this.checkBoxExcludeMSharp.UseVisualStyleBackColor = true;
            this.checkBoxExcludeMSharp.Visible = false;
            this.checkBoxExcludeMSharp.CheckedChanged += new System.EventHandler(this.checkBoxExcludeMSharp_CheckedChanged);
            // 
            // btnOriginal
            // 
            this.btnOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOriginal.Location = new System.Drawing.Point(420, 19);
            this.btnOriginal.Name = "btnOriginal";
            this.btnOriginal.Size = new System.Drawing.Size(150, 35);
            this.btnOriginal.TabIndex = 8;
            this.btnOriginal.Text = "Original Attach to &Process...";
            this.btnOriginal.UseVisualStyleBackColor = true;
            this.btnOriginal.Click += new System.EventHandler(this.btnOriginal_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.Location = new System.Drawing.Point(203, 19);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 35);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAttachToAll
            // 
            this.btnAttachToAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAttachToAll.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAttachToAll.Location = new System.Drawing.Point(93, 19);
            this.btnAttachToAll.Name = "btnAttachToAll";
            this.btnAttachToAll.Size = new System.Drawing.Size(104, 35);
            this.btnAttachToAll.TabIndex = 6;
            this.btnAttachToAll.Text = "Attach to &All";
            this.btnAttachToAll.UseVisualStyleBackColor = true;
            this.btnAttachToAll.Click += new System.EventHandler(this.btnAttachToAll_Click);
            // 
            // btnAttach
            // 
            this.btnAttach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAttach.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAttach.Enabled = false;
            this.btnAttach.Location = new System.Drawing.Point(12, 19);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(75, 35);
            this.btnAttach.TabIndex = 5;
            this.btnAttach.Text = "A&ttach";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // listBoxProcess
            // 
            this.listBoxProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxProcess.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProcess.FormattingEnabled = true;
            this.listBoxProcess.ItemHeight = 18;
            this.listBoxProcess.Location = new System.Drawing.Point(12, 46);
            this.listBoxProcess.Name = "listBoxProcess";
            this.listBoxProcess.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxProcess.Size = new System.Drawing.Size(582, 238);
            this.listBoxProcess.TabIndex = 4;
            this.listBoxProcess.SelectedIndexChanged += new System.EventHandler(this.listBoxProcess_SelectedIndexChanged);
            this.listBoxProcess.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxProcess_KeyDown);
            this.listBoxProcess.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxProcess_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtSearchProcess);
            this.panel1.Controls.Add(this.listBoxProcess);
            this.panel1.Controls.Add(this.checkBoxExcludeMSharp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 363);
            this.panel1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnAttach);
            this.groupBox1.Controls.Add(this.btnAttachToAll);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnOriginal);
            this.groupBox1.Location = new System.Drawing.Point(12, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 65);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operations";
            // 
            // FormAttacher
            // 
            this.AcceptButton = this.btnAttach;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 385);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusBar);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(622, 424);
            this.Name = "FormAttacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Attach to w3wp processes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAttacher_KeyDown);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        System.ComponentModel.BackgroundWorker ProcessListLoader;
        System.Windows.Forms.StatusStrip statusBar;
        System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.TextBox txtSearchProcess;
        private System.Windows.Forms.CheckBox checkBoxExcludeMSharp;
        private System.Windows.Forms.Button btnOriginal;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAttachToAll;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.ListBox listBoxProcess;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}