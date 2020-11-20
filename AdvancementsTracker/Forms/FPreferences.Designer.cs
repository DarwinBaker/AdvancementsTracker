namespace AdvancementsTracker.Forms
{
    partial class FPreferences
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
            this.textCustomSavesFolder = new System.Windows.Forms.TextBox();
            this.numRefreshDelay = new System.Windows.Forms.NumericUpDown();
            this.labelCustomPath = new System.Windows.Forms.Label();
            this.labelRefresh = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.checkUseDefault = new System.Windows.Forms.CheckBox();
            this.colors = new System.Windows.Forms.ColorDialog();
            this.buttonBrowse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numRefreshDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // textCustomSavesFolder
            // 
            this.textCustomSavesFolder.Location = new System.Drawing.Point(12, 35);
            this.textCustomSavesFolder.Name = "textCustomSavesFolder";
            this.textCustomSavesFolder.Size = new System.Drawing.Size(359, 20);
            this.textCustomSavesFolder.TabIndex = 0;
            // 
            // numRefreshDelay
            // 
            this.numRefreshDelay.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numRefreshDelay.Location = new System.Drawing.Point(352, 84);
            this.numRefreshDelay.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numRefreshDelay.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numRefreshDelay.Name = "numRefreshDelay";
            this.numRefreshDelay.Size = new System.Drawing.Size(100, 20);
            this.numRefreshDelay.TabIndex = 3;
            this.numRefreshDelay.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // labelCustomPath
            // 
            this.labelCustomPath.AutoSize = true;
            this.labelCustomPath.Location = new System.Drawing.Point(9, 19);
            this.labelCustomPath.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.labelCustomPath.Name = "labelCustomPath";
            this.labelCustomPath.Size = new System.Drawing.Size(144, 13);
            this.labelCustomPath.TabIndex = 3;
            this.labelCustomPath.Text = "Minecraft Saves Folder Path:";
            // 
            // labelRefresh
            // 
            this.labelRefresh.AutoSize = true;
            this.labelRefresh.Location = new System.Drawing.Point(349, 68);
            this.labelRefresh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.labelRefresh.Name = "labelRefresh";
            this.labelRefresh.Size = new System.Drawing.Size(107, 13);
            this.labelRefresh.TabIndex = 7;
            this.labelRefresh.Text = "Refresh Interval (ms):";
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(12, 110);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 32);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(352, 110);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 32);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // checkUseDefault
            // 
            this.checkUseDefault.AutoSize = true;
            this.checkUseDefault.Location = new System.Drawing.Point(12, 61);
            this.checkUseDefault.Name = "checkUseDefault";
            this.checkUseDefault.Size = new System.Drawing.Size(264, 17);
            this.checkUseDefault.TabIndex = 6;
            this.checkUseDefault.Text = "Use Default (AppData\\Roaming\\.minecraft\\saves)";
            this.checkUseDefault.UseVisualStyleBackColor = true;
            this.checkUseDefault.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // colors
            // 
            this.colors.AnyColor = true;
            this.colors.Color = System.Drawing.SystemColors.Control;
            this.colors.SolidColorOnly = true;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(377, 33);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 24);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // FPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(464, 154);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.checkUseDefault);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelRefresh);
            this.Controls.Add(this.labelCustomPath);
            this.Controls.Add(this.numRefreshDelay);
            this.Controls.Add(this.textCustomSavesFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FPreferences";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preferences";
            ((System.ComponentModel.ISupportInitialize)(this.numRefreshDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCustomSavesFolder;
        private System.Windows.Forms.NumericUpDown numRefreshDelay;
        private System.Windows.Forms.Label labelCustomPath;
        private System.Windows.Forms.Label labelRefresh;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckBox checkUseDefault;
        private System.Windows.Forms.TextBox rgb;
        private System.Windows.Forms.ColorDialog colors;
        private System.Windows.Forms.Button buttonBrowse;
    }
}