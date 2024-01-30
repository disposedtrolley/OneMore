﻿namespace River.OneMoreAddIn.Commands
{
	partial class FormulaDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormulaDialog));
			this.formatLabel = new System.Windows.Forms.Label();
			this.formatBox = new System.Windows.Forms.ComboBox();
			this.cancelButton = new River.OneMoreAddIn.UI.MoreButton();
			this.okButton = new River.OneMoreAddIn.UI.MoreButton();
			this.formulaLabel = new System.Windows.Forms.Label();
			this.formulaBox = new River.OneMoreAddIn.UI.MoreTextBox();
			this.selectedLabel = new System.Windows.Forms.Label();
			this.cellLabel = new System.Windows.Forms.Label();
			this.helpBox = new River.OneMoreAddIn.UI.MoreMultilineLabel();
			this.helpPanel = new System.Windows.Forms.Panel();
			this.helpButton = new River.OneMoreAddIn.UI.MoreCheckBox();
			this.validStatusLabel = new System.Windows.Forms.Label();
			this.statusLabel = new System.Windows.Forms.Label();
			this.tagBox = new River.OneMoreAddIn.UI.MoreCheckBox();
			this.decLabel = new System.Windows.Forms.Label();
			this.decimalBox = new System.Windows.Forms.NumericUpDown();
			this.helpPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.decimalBox)).BeginInit();
			this.SuspendLayout();
			// 
			// formatLabel
			// 
			this.formatLabel.AutoSize = true;
			this.formatLabel.Location = new System.Drawing.Point(13, 95);
			this.formatLabel.Name = "formatLabel";
			this.formatLabel.Size = new System.Drawing.Size(64, 20);
			this.formatLabel.TabIndex = 2;
			this.formatLabel.Text = "Format:";
			// 
			// formatBox
			// 
			this.formatBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.formatBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.formatBox.FormattingEnabled = true;
			this.formatBox.Items.AddRange(new object[] {
            "Number",
            "Currency",
            "Percentage"});
			this.formatBox.Location = new System.Drawing.Point(139, 92);
			this.formatBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.formatBox.Name = "formatBox";
			this.formatBox.Size = new System.Drawing.Size(261, 28);
			this.formatBox.TabIndex = 1;
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.cancelButton.ImageOver = null;
			this.cancelButton.Location = new System.Drawing.Point(504, 209);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.PreferredBack = null;
			this.cancelButton.PreferredFore = null;
			this.cancelButton.ShowBorder = true;
			this.cancelButton.Size = new System.Drawing.Size(100, 38);
			this.cancelButton.TabIndex = 5;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButton.Enabled = false;
			this.okButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.okButton.ImageOver = null;
			this.okButton.Location = new System.Drawing.Point(398, 209);
			this.okButton.Name = "okButton";
			this.okButton.PreferredBack = null;
			this.okButton.PreferredFore = null;
			this.okButton.ShowBorder = true;
			this.okButton.Size = new System.Drawing.Size(100, 38);
			this.okButton.TabIndex = 4;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			// 
			// formulaLabel
			// 
			this.formulaLabel.AutoSize = true;
			this.formulaLabel.Location = new System.Drawing.Point(13, 56);
			this.formulaLabel.Name = "formulaLabel";
			this.formulaLabel.Size = new System.Drawing.Size(71, 20);
			this.formulaLabel.TabIndex = 8;
			this.formulaLabel.Text = "Formula:";
			// 
			// formulaBox
			// 
			this.formulaBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.formulaBox.Location = new System.Drawing.Point(139, 53);
			this.formulaBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.formulaBox.Name = "formulaBox";
			this.formulaBox.PreferredBack = null;
			this.formulaBox.PreferredFore = null;
			this.formulaBox.Size = new System.Drawing.Size(382, 26);
			this.formulaBox.TabIndex = 0;
			this.formulaBox.TextChanged += new System.EventHandler(this.ChangedFormula);
			// 
			// selectedLabel
			// 
			this.selectedLabel.AutoSize = true;
			this.selectedLabel.Location = new System.Drawing.Point(13, 20);
			this.selectedLabel.Name = "selectedLabel";
			this.selectedLabel.Size = new System.Drawing.Size(111, 20);
			this.selectedLabel.TabIndex = 10;
			this.selectedLabel.Text = "Selected cells:";
			// 
			// cellLabel
			// 
			this.cellLabel.AutoSize = true;
			this.cellLabel.Location = new System.Drawing.Point(135, 20);
			this.cellLabel.Name = "cellLabel";
			this.cellLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.cellLabel.Size = new System.Drawing.Size(29, 30);
			this.cellLabel.TabIndex = 11;
			this.cellLabel.Text = "A1";
			// 
			// helpBox
			// 
			this.helpBox.AutoSize = true;
			this.helpBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.helpBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.helpBox.ForeColor = System.Drawing.SystemColors.ControlText;
			this.helpBox.Location = new System.Drawing.Point(7, 7);
			this.helpBox.MaximumSize = new System.Drawing.Size(576, 0);
			this.helpBox.Name = "helpBox";
			this.helpBox.PreferredBack = "ControlLightLight";
			this.helpBox.PreferredFore = "ControlText";
			this.helpBox.Size = new System.Drawing.Size(571, 240);
			this.helpBox.TabIndex = 12;
			this.helpBox.Text = resources.GetString("helpBox.Text");
			// 
			// helpPanel
			// 
			this.helpPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.helpPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.helpPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.helpPanel.Controls.Add(this.helpBox);
			this.helpPanel.Location = new System.Drawing.Point(17, 267);
			this.helpPanel.Name = "helpPanel";
			this.helpPanel.Padding = new System.Windows.Forms.Padding(7);
			this.helpPanel.Size = new System.Drawing.Size(587, 256);
			this.helpPanel.TabIndex = 13;
			this.helpPanel.Visible = false;
			// 
			// helpButton
			// 
			this.helpButton.Appearance = System.Windows.Forms.Appearance.Button;
			this.helpButton.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.helpButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.helpButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.helpButton.Location = new System.Drawing.Point(17, 213);
			this.helpButton.Name = "helpButton";
			this.helpButton.Size = new System.Drawing.Size(67, 30);
			this.helpButton.TabIndex = 6;
			this.helpButton.TabStop = false;
			this.helpButton.Text = "Help";
			this.helpButton.UseVisualStyleBackColor = false;
			this.helpButton.CheckedChanged += new System.EventHandler(this.ToggleHelp);
			// 
			// validStatusLabel
			// 
			this.validStatusLabel.AutoSize = true;
			this.validStatusLabel.Location = new System.Drawing.Point(211, 218);
			this.validStatusLabel.Name = "validStatusLabel";
			this.validStatusLabel.Size = new System.Drawing.Size(70, 20);
			this.validStatusLabel.TabIndex = 16;
			this.validStatusLabel.Text = "<empty>";
			// 
			// statusLabel
			// 
			this.statusLabel.AutoSize = true;
			this.statusLabel.Location = new System.Drawing.Point(135, 218);
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(60, 20);
			this.statusLabel.TabIndex = 17;
			this.statusLabel.Text = "Status:";
			// 
			// tagBox
			// 
			this.tagBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.tagBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.tagBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.tagBox.Location = new System.Drawing.Point(139, 172);
			this.tagBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.tagBox.Name = "tagBox";
			this.tagBox.Size = new System.Drawing.Size(161, 25);
			this.tagBox.TabIndex = 3;
			this.tagBox.Text = "Tag formula cells";
			this.tagBox.UseVisualStyleBackColor = true;
			// 
			// decLabel
			// 
			this.decLabel.AutoSize = true;
			this.decLabel.Location = new System.Drawing.Point(13, 135);
			this.decLabel.Name = "decLabel";
			this.decLabel.Size = new System.Drawing.Size(120, 20);
			this.decLabel.TabIndex = 18;
			this.decLabel.Text = "Decimal places:";
			// 
			// decimalBox
			// 
			this.decimalBox.Location = new System.Drawing.Point(139, 133);
			this.decimalBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.decimalBox.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
			this.decimalBox.Name = "decimalBox";
			this.decimalBox.Size = new System.Drawing.Size(99, 26);
			this.decimalBox.TabIndex = 2;
			// 
			// FormulaDialog
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(617, 536);
			this.Controls.Add(this.decimalBox);
			this.Controls.Add(this.decLabel);
			this.Controls.Add(this.tagBox);
			this.Controls.Add(this.statusLabel);
			this.Controls.Add(this.validStatusLabel);
			this.Controls.Add(this.helpButton);
			this.Controls.Add(this.helpPanel);
			this.Controls.Add(this.cellLabel);
			this.Controls.Add(this.selectedLabel);
			this.Controls.Add(this.formulaBox);
			this.Controls.Add(this.formulaLabel);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.formatBox);
			this.Controls.Add(this.formatLabel);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormulaDialog";
			this.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Formula";
			this.helpPanel.ResumeLayout(false);
			this.helpPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.decimalBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label formatLabel;
		private System.Windows.Forms.ComboBox formatBox;
		private UI.MoreButton cancelButton;
		private UI.MoreButton okButton;
		private System.Windows.Forms.Label formulaLabel;
		private UI.MoreTextBox formulaBox;
		private System.Windows.Forms.Label selectedLabel;
		private System.Windows.Forms.Label cellLabel;
		private UI.MoreMultilineLabel helpBox;
		private System.Windows.Forms.Panel helpPanel;
		private UI.MoreCheckBox helpButton;
		private System.Windows.Forms.Label validStatusLabel;
		private System.Windows.Forms.Label statusLabel;
		private UI.MoreCheckBox tagBox;
		private System.Windows.Forms.Label decLabel;
		private System.Windows.Forms.NumericUpDown decimalBox;
	}
}