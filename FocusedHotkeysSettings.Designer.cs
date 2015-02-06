namespace LiveSplit.FocusedHotkeys
{
    partial class FocusedHotkeysSettings
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.gbProcesses = new System.Windows.Forms.GroupBox();
            this.tlpProcessesList = new System.Windows.Forms.TableLayoutPanel();
            this.lbProcesses = new System.Windows.Forms.ListBox();
            this.tlpProcessListControls = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddProcess = new System.Windows.Forms.Button();
            this.lblProcessName = new System.Windows.Forms.Label();
            this.btnRemoveProcess = new System.Windows.Forms.Button();
            this.cbAllProcesses = new System.Windows.Forms.ComboBox();
            this.lblProcessListInfo = new System.Windows.Forms.Label();
            this.gbWindowTitles = new System.Windows.Forms.GroupBox();
            this.tlpWindowTitlesList = new System.Windows.Forms.TableLayoutPanel();
            this.tlpWindowTitlesListControls = new System.Windows.Forms.TableLayoutPanel();
            this.cbAllWindowTitles = new System.Windows.Forms.ComboBox();
            this.btnAddWindowTitle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbWindowTitles = new System.Windows.Forms.ListBox();
            this.btnRemoveWindowTitle = new System.Windows.Forms.Button();
            this.lblBottomInfo = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
            this.gbProcesses.SuspendLayout();
            this.tlpProcessesList.SuspendLayout();
            this.tlpProcessListControls.SuspendLayout();
            this.gbWindowTitles.SuspendLayout();
            this.tlpWindowTitlesList.SuspendLayout();
            this.tlpWindowTitlesListControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.AutoSize = true;
            this.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.gbProcesses, 0, 0);
            this.tlpMain.Controls.Add(this.gbWindowTitles, 0, 1);
            this.tlpMain.Controls.Add(this.lblBottomInfo, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpMain.Location = new System.Drawing.Point(7, 7);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.Size = new System.Drawing.Size(462, 474);
            this.tlpMain.TabIndex = 0;
            // 
            // gbProcesses
            // 
            this.gbProcesses.AutoSize = true;
            this.gbProcesses.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbProcesses.Controls.Add(this.tlpProcessesList);
            this.gbProcesses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbProcesses.Location = new System.Drawing.Point(3, 3);
            this.gbProcesses.Name = "gbProcesses";
            this.gbProcesses.Size = new System.Drawing.Size(456, 218);
            this.gbProcesses.TabIndex = 2;
            this.gbProcesses.TabStop = false;
            this.gbProcesses.Text = "Processes";
            // 
            // tlpProcessesList
            // 
            this.tlpProcessesList.AutoSize = true;
            this.tlpProcessesList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpProcessesList.ColumnCount = 2;
            this.tlpProcessesList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpProcessesList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpProcessesList.Controls.Add(this.lbProcesses, 0, 0);
            this.tlpProcessesList.Controls.Add(this.tlpProcessListControls, 1, 0);
            this.tlpProcessesList.Controls.Add(this.lblProcessListInfo, 0, 1);
            this.tlpProcessesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProcessesList.Location = new System.Drawing.Point(3, 16);
            this.tlpProcessesList.Name = "tlpProcessesList";
            this.tlpProcessesList.RowCount = 2;
            this.tlpProcessesList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpProcessesList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpProcessesList.Size = new System.Drawing.Size(450, 199);
            this.tlpProcessesList.TabIndex = 0;
            // 
            // lbProcesses
            // 
            this.lbProcesses.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbProcesses.FormattingEnabled = true;
            this.lbProcesses.Location = new System.Drawing.Point(3, 3);
            this.lbProcesses.Name = "lbProcesses";
            this.lbProcesses.ScrollAlwaysVisible = true;
            this.lbProcesses.Size = new System.Drawing.Size(174, 173);
            this.lbProcesses.TabIndex = 0;
            this.lbProcesses.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbProcesses_KeyDown);
            // 
            // tlpProcessListControls
            // 
            this.tlpProcessListControls.AutoSize = true;
            this.tlpProcessListControls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpProcessListControls.ColumnCount = 3;
            this.tlpProcessListControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpProcessListControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProcessListControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpProcessListControls.Controls.Add(this.btnAddProcess, 2, 0);
            this.tlpProcessListControls.Controls.Add(this.lblProcessName, 0, 0);
            this.tlpProcessListControls.Controls.Add(this.btnRemoveProcess, 0, 1);
            this.tlpProcessListControls.Controls.Add(this.cbAllProcesses, 1, 0);
            this.tlpProcessListControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProcessListControls.Location = new System.Drawing.Point(183, 3);
            this.tlpProcessListControls.Name = "tlpProcessListControls";
            this.tlpProcessListControls.RowCount = 2;
            this.tlpProcessListControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpProcessListControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProcessListControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpProcessListControls.Size = new System.Drawing.Size(264, 173);
            this.tlpProcessListControls.TabIndex = 1;
            // 
            // btnAddProcess
            // 
            this.btnAddProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProcess.AutoSize = true;
            this.btnAddProcess.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddProcess.Location = new System.Drawing.Point(221, 2);
            this.btnAddProcess.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnAddProcess.Name = "btnAddProcess";
            this.btnAddProcess.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnAddProcess.Size = new System.Drawing.Size(40, 23);
            this.btnAddProcess.TabIndex = 1;
            this.btnAddProcess.Text = "Add";
            this.btnAddProcess.UseVisualStyleBackColor = true;
            this.btnAddProcess.Click += new System.EventHandler(this.btnAddProcess_Click);
            // 
            // lblProcessName
            // 
            this.lblProcessName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblProcessName.AutoSize = true;
            this.lblProcessName.Location = new System.Drawing.Point(0, 7);
            this.lblProcessName.Margin = new System.Windows.Forms.Padding(0);
            this.lblProcessName.Name = "lblProcessName";
            this.lblProcessName.Size = new System.Drawing.Size(79, 13);
            this.lblProcessName.TabIndex = 2;
            this.lblProcessName.Text = "Process Name:";
            // 
            // btnRemoveProcess
            // 
            this.btnRemoveProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveProcess.AutoSize = true;
            this.btnRemoveProcess.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemoveProcess.Location = new System.Drawing.Point(3, 147);
            this.btnRemoveProcess.Name = "btnRemoveProcess";
            this.btnRemoveProcess.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnRemoveProcess.Size = new System.Drawing.Size(63, 23);
            this.btnRemoveProcess.TabIndex = 3;
            this.btnRemoveProcess.Text = "Remove";
            this.btnRemoveProcess.UseVisualStyleBackColor = true;
            this.btnRemoveProcess.Click += new System.EventHandler(this.btnRemoveProcess_Click);
            // 
            // cbAllProcesses
            // 
            this.cbAllProcesses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbAllProcesses.FormattingEnabled = true;
            this.cbAllProcesses.Location = new System.Drawing.Point(82, 3);
            this.cbAllProcesses.Name = "cbAllProcesses";
            this.cbAllProcesses.Size = new System.Drawing.Size(133, 21);
            this.cbAllProcesses.TabIndex = 4;
            this.cbAllProcesses.DropDown += new System.EventHandler(this.cbAllProcesses_DropDown);
            // 
            // lblProcessListInfo
            // 
            this.lblProcessListInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProcessListInfo.AutoSize = true;
            this.tlpProcessesList.SetColumnSpan(this.lblProcessListInfo, 2);
            this.lblProcessListInfo.Location = new System.Drawing.Point(3, 182);
            this.lblProcessListInfo.Name = "lblProcessListInfo";
            this.lblProcessListInfo.Size = new System.Drawing.Size(444, 13);
            this.lblProcessListInfo.TabIndex = 2;
            this.lblProcessListInfo.Text = "Do not include the extension in the name. \"game.exe\" isn\'t valid, while \"game\" is" +
    ".";
            this.lblProcessListInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbWindowTitles
            // 
            this.gbWindowTitles.AutoSize = true;
            this.gbWindowTitles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbWindowTitles.Controls.Add(this.tlpWindowTitlesList);
            this.gbWindowTitles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbWindowTitles.Location = new System.Drawing.Point(3, 227);
            this.gbWindowTitles.Name = "gbWindowTitles";
            this.gbWindowTitles.Size = new System.Drawing.Size(456, 231);
            this.gbWindowTitles.TabIndex = 3;
            this.gbWindowTitles.TabStop = false;
            this.gbWindowTitles.Text = "Window Titles";
            // 
            // tlpWindowTitlesList
            // 
            this.tlpWindowTitlesList.AutoSize = true;
            this.tlpWindowTitlesList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpWindowTitlesList.ColumnCount = 2;
            this.tlpWindowTitlesList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpWindowTitlesList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpWindowTitlesList.Controls.Add(this.tlpWindowTitlesListControls, 0, 0);
            this.tlpWindowTitlesList.Controls.Add(this.lbWindowTitles, 0, 1);
            this.tlpWindowTitlesList.Controls.Add(this.btnRemoveWindowTitle, 1, 1);
            this.tlpWindowTitlesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpWindowTitlesList.Location = new System.Drawing.Point(3, 16);
            this.tlpWindowTitlesList.Name = "tlpWindowTitlesList";
            this.tlpWindowTitlesList.RowCount = 2;
            this.tlpWindowTitlesList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpWindowTitlesList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpWindowTitlesList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpWindowTitlesList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpWindowTitlesList.Size = new System.Drawing.Size(450, 212);
            this.tlpWindowTitlesList.TabIndex = 0;
            // 
            // tlpWindowTitlesListControls
            // 
            this.tlpWindowTitlesListControls.AutoSize = true;
            this.tlpWindowTitlesListControls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpWindowTitlesListControls.ColumnCount = 3;
            this.tlpWindowTitlesList.SetColumnSpan(this.tlpWindowTitlesListControls, 2);
            this.tlpWindowTitlesListControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpWindowTitlesListControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpWindowTitlesListControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpWindowTitlesListControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpWindowTitlesListControls.Controls.Add(this.cbAllWindowTitles, 1, 0);
            this.tlpWindowTitlesListControls.Controls.Add(this.btnAddWindowTitle, 2, 0);
            this.tlpWindowTitlesListControls.Controls.Add(this.label2, 0, 0);
            this.tlpWindowTitlesListControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpWindowTitlesListControls.Location = new System.Drawing.Point(3, 3);
            this.tlpWindowTitlesListControls.Name = "tlpWindowTitlesListControls";
            this.tlpWindowTitlesListControls.RowCount = 1;
            this.tlpWindowTitlesListControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpWindowTitlesListControls.Size = new System.Drawing.Size(444, 27);
            this.tlpWindowTitlesListControls.TabIndex = 3;
            // 
            // cbAllWindowTitles
            // 
            this.cbAllWindowTitles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbAllWindowTitles.FormattingEnabled = true;
            this.cbAllWindowTitles.Location = new System.Drawing.Point(33, 3);
            this.cbAllWindowTitles.Name = "cbAllWindowTitles";
            this.cbAllWindowTitles.Size = new System.Drawing.Size(362, 21);
            this.cbAllWindowTitles.TabIndex = 3;
            this.cbAllWindowTitles.DropDown += new System.EventHandler(this.cbAllWindowTitles_DropDown);
            // 
            // btnAddWindowTitle
            // 
            this.btnAddWindowTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddWindowTitle.AutoSize = true;
            this.btnAddWindowTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddWindowTitle.Location = new System.Drawing.Point(401, 2);
            this.btnAddWindowTitle.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnAddWindowTitle.Name = "btnAddWindowTitle";
            this.btnAddWindowTitle.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnAddWindowTitle.Size = new System.Drawing.Size(40, 23);
            this.btnAddWindowTitle.TabIndex = 1;
            this.btnAddWindowTitle.Text = "Add";
            this.btnAddWindowTitle.UseVisualStyleBackColor = true;
            this.btnAddWindowTitle.Click += new System.EventHandler(this.btnAddWindowTitle_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Title:";
            // 
            // lbWindowTitles
            // 
            this.lbWindowTitles.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbWindowTitles.FormattingEnabled = true;
            this.lbWindowTitles.Location = new System.Drawing.Point(3, 36);
            this.lbWindowTitles.Name = "lbWindowTitles";
            this.lbWindowTitles.ScrollAlwaysVisible = true;
            this.lbWindowTitles.Size = new System.Drawing.Size(375, 173);
            this.lbWindowTitles.TabIndex = 0;
            this.lbWindowTitles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbWindowTitles_KeyDown);
            // 
            // btnRemoveWindowTitle
            // 
            this.btnRemoveWindowTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveWindowTitle.AutoSize = true;
            this.btnRemoveWindowTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemoveWindowTitle.Location = new System.Drawing.Point(384, 186);
            this.btnRemoveWindowTitle.Name = "btnRemoveWindowTitle";
            this.btnRemoveWindowTitle.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnRemoveWindowTitle.Size = new System.Drawing.Size(63, 23);
            this.btnRemoveWindowTitle.TabIndex = 2;
            this.btnRemoveWindowTitle.Text = "Remove";
            this.btnRemoveWindowTitle.UseVisualStyleBackColor = true;
            this.btnRemoveWindowTitle.Click += new System.EventHandler(this.btnRemoveWindowTitle_Click);
            // 
            // lblBottomInfo
            // 
            this.lblBottomInfo.AutoSize = true;
            this.lblBottomInfo.Location = new System.Drawing.Point(3, 461);
            this.lblBottomInfo.Name = "lblBottomInfo";
            this.lblBottomInfo.Size = new System.Drawing.Size(140, 13);
            this.lblBottomInfo.TabIndex = 4;
            this.lblBottomInfo.Text = "Everything is case sensitive.";
            this.lblBottomInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FocusedHotkeysSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "FocusedHotkeysSettings";
            this.Padding = new System.Windows.Forms.Padding(7, 7, 7, 0);
            this.Size = new System.Drawing.Size(476, 487);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.gbProcesses.ResumeLayout(false);
            this.gbProcesses.PerformLayout();
            this.tlpProcessesList.ResumeLayout(false);
            this.tlpProcessesList.PerformLayout();
            this.tlpProcessListControls.ResumeLayout(false);
            this.tlpProcessListControls.PerformLayout();
            this.gbWindowTitles.ResumeLayout(false);
            this.gbWindowTitles.PerformLayout();
            this.tlpWindowTitlesList.ResumeLayout(false);
            this.tlpWindowTitlesList.PerformLayout();
            this.tlpWindowTitlesListControls.ResumeLayout(false);
            this.tlpWindowTitlesListControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.GroupBox gbProcesses;
        private System.Windows.Forms.TableLayoutPanel tlpProcessesList;
        private System.Windows.Forms.ListBox lbProcesses;
        private System.Windows.Forms.TableLayoutPanel tlpProcessListControls;
        private System.Windows.Forms.Button btnAddProcess;
        private System.Windows.Forms.Label lblProcessName;
        private System.Windows.Forms.Button btnRemoveProcess;
        private System.Windows.Forms.Label lblProcessListInfo;
        private System.Windows.Forms.GroupBox gbWindowTitles;
        private System.Windows.Forms.TableLayoutPanel tlpWindowTitlesList;
        private System.Windows.Forms.ListBox lbWindowTitles;
        private System.Windows.Forms.Button btnRemoveWindowTitle;
        private System.Windows.Forms.Label lblBottomInfo;
        private System.Windows.Forms.TableLayoutPanel tlpWindowTitlesListControls;
        private System.Windows.Forms.ComboBox cbAllWindowTitles;
        private System.Windows.Forms.Button btnAddWindowTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAllProcesses;
    }
}
