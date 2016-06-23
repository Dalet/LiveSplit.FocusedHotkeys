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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
			this.tlpSettings = new System.Windows.Forms.TableLayoutPanel();
			this.chkAllowManualToggle = new System.Windows.Forms.CheckBox();
			this.chkMatchCase = new System.Windows.Forms.CheckBox();
			this.gbPrograms = new System.Windows.Forms.GroupBox();
			this.tlpProgramList = new System.Windows.Forms.TableLayoutPanel();
			this.btnRemoveProgram = new System.Windows.Forms.Button();
			this.tlpAddProgram = new System.Windows.Forms.TableLayoutPanel();
			this.btnAddProgram = new System.Windows.Forms.Button();
			this.cbProgramTitle = new System.Windows.Forms.ComboBox();
			this.rbProcessName = new System.Windows.Forms.RadioButton();
			this.rbWindowTitle = new System.Windows.Forms.RadioButton();
			this.dgvPrograms = new System.Windows.Forms.DataGridView();
			this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tlpMain.SuspendLayout();
			this.tlpSettings.SuspendLayout();
			this.gbPrograms.SuspendLayout();
			this.tlpProgramList.SuspendLayout();
			this.tlpAddProgram.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPrograms)).BeginInit();
			this.SuspendLayout();
			// 
			// tlpMain
			// 
			this.tlpMain.AutoSize = true;
			this.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tlpMain.ColumnCount = 1;
			this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpMain.Controls.Add(this.tlpSettings, 0, 0);
			this.tlpMain.Controls.Add(this.gbPrograms, 0, 1);
			this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpMain.Location = new System.Drawing.Point(7, 7);
			this.tlpMain.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.tlpMain.Name = "tlpMain";
			this.tlpMain.RowCount = 2;
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpMain.Size = new System.Drawing.Size(462, 516);
			this.tlpMain.TabIndex = 0;
			// 
			// tlpSettings
			// 
			this.tlpSettings.AutoSize = true;
			this.tlpSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tlpSettings.ColumnCount = 1;
			this.tlpSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpSettings.Controls.Add(this.chkAllowManualToggle, 0, 0);
			this.tlpSettings.Controls.Add(this.chkMatchCase, 0, 1);
			this.tlpSettings.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpSettings.Location = new System.Drawing.Point(3, 3);
			this.tlpSettings.Name = "tlpSettings";
			this.tlpSettings.RowCount = 2;
			this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tlpSettings.Size = new System.Drawing.Size(456, 52);
			this.tlpSettings.TabIndex = 0;
			// 
			// chkAllowManualToggle
			// 
			this.chkAllowManualToggle.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.chkAllowManualToggle.AutoSize = true;
			this.chkAllowManualToggle.Location = new System.Drawing.Point(3, 4);
			this.chkAllowManualToggle.Name = "chkAllowManualToggle";
			this.chkAllowManualToggle.Size = new System.Drawing.Size(270, 17);
			this.chkAllowManualToggle.TabIndex = 0;
			this.chkAllowManualToggle.Text = "Allow manual Global Hotkeys toggling while in focus";
			this.chkAllowManualToggle.UseVisualStyleBackColor = true;
			// 
			// chkMatchCase
			// 
			this.chkMatchCase.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.chkMatchCase.AutoSize = true;
			this.chkMatchCase.Location = new System.Drawing.Point(3, 30);
			this.chkMatchCase.Name = "chkMatchCase";
			this.chkMatchCase.Size = new System.Drawing.Size(108, 17);
			this.chkMatchCase.TabIndex = 1;
			this.chkMatchCase.Text = "Match letter case";
			this.chkMatchCase.UseVisualStyleBackColor = true;
			// 
			// gbPrograms
			// 
			this.gbPrograms.AutoSize = true;
			this.gbPrograms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.gbPrograms.Controls.Add(this.tlpProgramList);
			this.gbPrograms.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbPrograms.Location = new System.Drawing.Point(3, 61);
			this.gbPrograms.Name = "gbPrograms";
			this.gbPrograms.Size = new System.Drawing.Size(456, 452);
			this.gbPrograms.TabIndex = 1;
			this.gbPrograms.TabStop = false;
			this.gbPrograms.Text = "Focused Programs";
			// 
			// tlpProgramList
			// 
			this.tlpProgramList.AutoSize = true;
			this.tlpProgramList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tlpProgramList.ColumnCount = 2;
			this.tlpProgramList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpProgramList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlpProgramList.Controls.Add(this.btnRemoveProgram, 1, 1);
			this.tlpProgramList.Controls.Add(this.tlpAddProgram, 0, 0);
			this.tlpProgramList.Controls.Add(this.dgvPrograms, 0, 1);
			this.tlpProgramList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpProgramList.Location = new System.Drawing.Point(3, 16);
			this.tlpProgramList.Name = "tlpProgramList";
			this.tlpProgramList.RowCount = 2;
			this.tlpProgramList.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpProgramList.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpProgramList.Size = new System.Drawing.Size(450, 433);
			this.tlpProgramList.TabIndex = 0;
			// 
			// btnRemoveProgram
			// 
			this.btnRemoveProgram.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnRemoveProgram.BackgroundImage = global::LiveSplit.FocusedHotkeys.Properties.Resources.Remove;
			this.btnRemoveProgram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnRemoveProgram.FlatAppearance.BorderSize = 0;
			this.btnRemoveProgram.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.btnRemoveProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnRemoveProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemoveProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRemoveProgram.Location = new System.Drawing.Point(418, 43);
			this.btnRemoveProgram.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.btnRemoveProgram.Name = "btnRemoveProgram";
			this.btnRemoveProgram.Size = new System.Drawing.Size(32, 32);
			this.btnRemoveProgram.TabIndex = 2;
			this.btnRemoveProgram.UseVisualStyleBackColor = true;
			this.btnRemoveProgram.Click += new System.EventHandler(this.btnRemoveProgram_Click);
			// 
			// tlpAddProgram
			// 
			this.tlpAddProgram.AutoSize = true;
			this.tlpAddProgram.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tlpAddProgram.ColumnCount = 4;
			this.tlpProgramList.SetColumnSpan(this.tlpAddProgram, 2);
			this.tlpAddProgram.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlpAddProgram.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlpAddProgram.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpAddProgram.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlpAddProgram.Controls.Add(this.btnAddProgram, 3, 0);
			this.tlpAddProgram.Controls.Add(this.cbProgramTitle, 2, 0);
			this.tlpAddProgram.Controls.Add(this.rbProcessName, 0, 0);
			this.tlpAddProgram.Controls.Add(this.rbWindowTitle, 1, 0);
			this.tlpAddProgram.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpAddProgram.Location = new System.Drawing.Point(3, 3);
			this.tlpAddProgram.Name = "tlpAddProgram";
			this.tlpAddProgram.RowCount = 2;
			this.tlpAddProgram.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpAddProgram.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpAddProgram.Size = new System.Drawing.Size(444, 27);
			this.tlpAddProgram.TabIndex = 0;
			// 
			// btnAddProgram
			// 
			this.btnAddProgram.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnAddProgram.AutoSize = true;
			this.btnAddProgram.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnAddProgram.Location = new System.Drawing.Point(401, 2);
			this.btnAddProgram.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.btnAddProgram.Name = "btnAddProgram";
			this.btnAddProgram.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.btnAddProgram.Size = new System.Drawing.Size(40, 23);
			this.btnAddProgram.TabIndex = 3;
			this.btnAddProgram.Text = "Add";
			this.btnAddProgram.UseVisualStyleBackColor = true;
			this.btnAddProgram.Click += new System.EventHandler(this.btnAddProgram_Click);
			// 
			// cbProgramTitle
			// 
			this.cbProgramTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.cbProgramTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cbProgramTitle.FormattingEnabled = true;
			this.cbProgramTitle.Location = new System.Drawing.Point(184, 3);
			this.cbProgramTitle.Name = "cbProgramTitle";
			this.cbProgramTitle.Size = new System.Drawing.Size(211, 21);
			this.cbProgramTitle.TabIndex = 2;
			this.cbProgramTitle.DropDown += new System.EventHandler(this.cbProgramTitle_DropDown);
			// 
			// rbProcessName
			// 
			this.rbProcessName.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.rbProcessName.AutoSize = true;
			this.rbProcessName.Checked = true;
			this.rbProcessName.Location = new System.Drawing.Point(0, 5);
			this.rbProcessName.Margin = new System.Windows.Forms.Padding(0);
			this.rbProcessName.Name = "rbProcessName";
			this.rbProcessName.Size = new System.Drawing.Size(94, 17);
			this.rbProcessName.TabIndex = 0;
			this.rbProcessName.TabStop = true;
			this.rbProcessName.Text = "Process Name";
			this.rbProcessName.UseVisualStyleBackColor = true;
			// 
			// rbWindowTitle
			// 
			this.rbWindowTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.rbWindowTitle.AutoSize = true;
			this.rbWindowTitle.Location = new System.Drawing.Point(94, 5);
			this.rbWindowTitle.Margin = new System.Windows.Forms.Padding(0);
			this.rbWindowTitle.Name = "rbWindowTitle";
			this.rbWindowTitle.Size = new System.Drawing.Size(87, 17);
			this.rbWindowTitle.TabIndex = 1;
			this.rbWindowTitle.Text = "Window Title";
			this.rbWindowTitle.UseVisualStyleBackColor = true;
			// 
			// dgvPrograms
			// 
			this.dgvPrograms.AllowUserToResizeColumns = false;
			this.dgvPrograms.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.dgvPrograms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvPrograms.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgvPrograms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPrograms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Type});
			this.dgvPrograms.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvPrograms.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvPrograms.Location = new System.Drawing.Point(3, 36);
			this.dgvPrograms.Name = "dgvPrograms";
			this.dgvPrograms.RowHeadersVisible = false;
			this.dgvPrograms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPrograms.Size = new System.Drawing.Size(412, 394);
			this.dgvPrograms.TabIndex = 1;
			this.dgvPrograms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrograms_CellClick);
			// 
			// Title
			// 
			this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Title.HeaderText = "Title";
			this.Title.Name = "Title";
			// 
			// Type
			// 
			this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Type.HeaderText = "Type";
			this.Type.MinimumWidth = 80;
			this.Type.Name = "Type";
			this.Type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Type.Width = 80;
			// 
			// FocusedHotkeysSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tlpMain);
			this.Name = "FocusedHotkeysSettings";
			this.Padding = new System.Windows.Forms.Padding(7);
			this.Size = new System.Drawing.Size(476, 530);
			this.tlpMain.ResumeLayout(false);
			this.tlpMain.PerformLayout();
			this.tlpSettings.ResumeLayout(false);
			this.tlpSettings.PerformLayout();
			this.gbPrograms.ResumeLayout(false);
			this.gbPrograms.PerformLayout();
			this.tlpProgramList.ResumeLayout(false);
			this.tlpProgramList.PerformLayout();
			this.tlpAddProgram.ResumeLayout(false);
			this.tlpAddProgram.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPrograms)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.GroupBox gbPrograms;
        private System.Windows.Forms.TableLayoutPanel tlpProgramList;
        private System.Windows.Forms.TableLayoutPanel tlpAddProgram;
        private System.Windows.Forms.Button btnRemoveProgram;
        private System.Windows.Forms.ComboBox cbProgramTitle;
        private System.Windows.Forms.CheckBox chkAllowManualToggle;
		private System.Windows.Forms.DataGridView dgvPrograms;
		private System.Windows.Forms.Button btnAddProgram;
		private System.Windows.Forms.RadioButton rbProcessName;
		private System.Windows.Forms.RadioButton rbWindowTitle;
		private System.Windows.Forms.TableLayoutPanel tlpSettings;
		private System.Windows.Forms.CheckBox chkMatchCase;
		private System.Windows.Forms.DataGridViewTextBoxColumn Title;
		private System.Windows.Forms.DataGridViewTextBoxColumn Type;
	}
}
