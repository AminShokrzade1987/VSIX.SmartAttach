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
            this.tbpgWorkers = new System.Windows.Forms.TabPage();
            this.listBoxProcess = new System.Windows.Forms.ListBox();
            this.btnAttach = new System.Windows.Forms.Button();
            this.btnAttachToAll = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnOriginal = new System.Windows.Forms.Button();
            this.checkBoxExcludeMSharp = new System.Windows.Forms.CheckBox();
            this.txtSearchProcess = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.statusBar.SuspendLayout();
            this.tbpgWorkers.SuspendLayout();
            this.tabControl.SuspendLayout();
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
            // tbpgWorkers
            // 
            this.tbpgWorkers.Controls.Add(this.txtSearchProcess);
            this.tbpgWorkers.Controls.Add(this.checkBoxExcludeMSharp);
            this.tbpgWorkers.Controls.Add(this.btnOriginal);
            this.tbpgWorkers.Controls.Add(this.btnRefresh);
            this.tbpgWorkers.Controls.Add(this.btnAttachToAll);
            this.tbpgWorkers.Controls.Add(this.btnAttach);
            this.tbpgWorkers.Controls.Add(this.listBoxProcess);
            this.tbpgWorkers.Location = new System.Drawing.Point(4, 22);
            this.tbpgWorkers.Name = "tbpgWorkers";
            this.tbpgWorkers.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgWorkers.Size = new System.Drawing.Size(598, 337);
            this.tbpgWorkers.TabIndex = 0;
            this.tbpgWorkers.Text = "Worker Procs";
            this.tbpgWorkers.UseVisualStyleBackColor = true;
            // 
            // listBoxProcess
            // 
            this.listBoxProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxProcess.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProcess.FormattingEnabled = true;
            this.listBoxProcess.ItemHeight = 15;
            this.listBoxProcess.Location = new System.Drawing.Point(8, 37);
            this.listBoxProcess.Name = "listBoxProcess";
            this.listBoxProcess.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxProcess.Size = new System.Drawing.Size(582, 199);
            this.listBoxProcess.TabIndex = 4;
            this.listBoxProcess.SelectedIndexChanged += new System.EventHandler(this.listBoxProcess_SelectedIndexChanged);
            this.listBoxProcess.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxProcess_KeyDown);
            this.listBoxProcess.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxProcess_MouseDoubleClick);
            // 
            // btnAttach
            // 
            this.btnAttach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAttach.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAttach.Enabled = false;
            this.btnAttach.Location = new System.Drawing.Point(329, 306);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(75, 23);
            this.btnAttach.TabIndex = 5;
            this.btnAttach.Text = "A&ttach";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // btnAttachToAll
            // 
            this.btnAttachToAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAttachToAll.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAttachToAll.Location = new System.Drawing.Point(410, 306);
            this.btnAttachToAll.Name = "btnAttachToAll";
            this.btnAttachToAll.Size = new System.Drawing.Size(104, 23);
            this.btnAttachToAll.TabIndex = 6;
            this.btnAttachToAll.Text = "Attach to &All";
            this.btnAttachToAll.UseVisualStyleBackColor = true;
            this.btnAttachToAll.Click += new System.EventHandler(this.btnAttachToAll_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(520, 306);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(70, 23);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnOriginal
            // 
            this.btnOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOriginal.Location = new System.Drawing.Point(8, 306);
            this.btnOriginal.Name = "btnOriginal";
            this.btnOriginal.Size = new System.Drawing.Size(180, 23);
            this.btnOriginal.TabIndex = 8;
            this.btnOriginal.Text = "Original Attach to &Process...";
            this.btnOriginal.UseVisualStyleBackColor = true;
            this.btnOriginal.Click += new System.EventHandler(this.btnOriginal_Click);
            // 
            // checkBoxExcludeMSharp
            // 
            this.checkBoxExcludeMSharp.AutoSize = true;
            this.checkBoxExcludeMSharp.Checked = true;
            this.checkBoxExcludeMSharp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxExcludeMSharp.Location = new System.Drawing.Point(510, 9);
            this.checkBoxExcludeMSharp.Name = "checkBoxExcludeMSharp";
            this.checkBoxExcludeMSharp.Size = new System.Drawing.Size(83, 17);
            this.checkBoxExcludeMSharp.TabIndex = 9;
            this.checkBoxExcludeMSharp.Text = "Exclude M#";
            this.checkBoxExcludeMSharp.UseVisualStyleBackColor = true;
            this.checkBoxExcludeMSharp.CheckedChanged += new System.EventHandler(this.checkBoxExcludeMSharp_CheckedChanged);
            // 
            // txtSearchProcess
            // 
            this.txtSearchProcess.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSearchProcess.Location = new System.Drawing.Point(8, 6);
            this.txtSearchProcess.Name = "txtSearchProcess";
            this.txtSearchProcess.Size = new System.Drawing.Size(496, 20);
            this.txtSearchProcess.TabIndex = 10;
            this.txtSearchProcess.TextChanged += new System.EventHandler(this.txtSearchProcess_TextChanged);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tbpgWorkers);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(606, 363);
            this.tabControl.TabIndex = 4;
            // 
            // FormAttacher
            // 
            this.AcceptButton = this.btnAttach;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 385);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusBar);
            this.KeyPreview = true;
            this.Name = "FormAttacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Attach to w3wp processes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAttacher_KeyDown);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.tbpgWorkers.ResumeLayout(false);
            this.tbpgWorkers.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        System.ComponentModel.BackgroundWorker ProcessListLoader;
        System.Windows.Forms.StatusStrip statusBar;
        System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.TabPage tbpgWorkers;
        private System.Windows.Forms.TextBox txtSearchProcess;
        private System.Windows.Forms.CheckBox checkBoxExcludeMSharp;
        private System.Windows.Forms.Button btnOriginal;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAttachToAll;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.ListBox listBoxProcess;
        private System.Windows.Forms.TabControl tabControl;
    }
}