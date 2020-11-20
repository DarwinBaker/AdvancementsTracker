namespace AdvancementsTracker.Controls
{
    partial class CAdvCriteria
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
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.group = new System.Windows.Forms.GroupBox();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPercent = new System.Windows.Forms.Label();
            this.labelProgress = new System.Windows.Forms.Label();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.icon = new AdvancementsTracker.Controls.CPixelBox();
            this.label = new System.Windows.Forms.Label();
            this.flow = new System.Windows.Forms.FlowLayoutPanel();
            this.group.SuspendLayout();
            this.panel1.SuspendLayout();
            this.table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.flow.SuspendLayout();
            this.SuspendLayout();
            // 
            // group
            // 
            this.group.AutoSize = true;
            this.group.Controls.Add(this.panel1);
            this.group.Controls.Add(this.progress);
            this.group.Controls.Add(this.flow);
            this.group.Location = new System.Drawing.Point(0, 0);
            this.group.Margin = new System.Windows.Forms.Padding(0, 3, 2, 0);
            this.group.Name = "group";
            this.group.Padding = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.group.Size = new System.Drawing.Size(116, 356);
            this.group.TabIndex = 0;
            this.group.TabStop = false;
            // 
            // progress
            // 
            this.progress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progress.Location = new System.Drawing.Point(3, 337);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(110, 15);
            this.progress.TabIndex = 84;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelPercent);
            this.panel1.Controls.Add(this.labelProgress);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 321);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 16);
            this.panel1.TabIndex = 85;
            // 
            // labelPercent
            // 
            this.labelPercent.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelPercent.Location = new System.Drawing.Point(71, 0);
            this.labelPercent.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.Size = new System.Drawing.Size(39, 16);
            this.labelPercent.TabIndex = 87;
            this.labelPercent.Text = "(0%)";
            this.labelPercent.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelProgress.Location = new System.Drawing.Point(0, 0);
            this.labelProgress.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(86, 13);
            this.labelProgress.TabIndex = 86;
            this.labelProgress.Text = "Completed: 0 / 0";
            // 
            // table
            // 
            this.table.AutoSize = true;
            this.table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.table.ColumnCount = 1;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table.Controls.Add(this.label, 0, 1);
            this.table.Controls.Add(this.icon, 0, 0);
            this.table.Location = new System.Drawing.Point(0, 10);
            this.table.Margin = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.table.Name = "table";
            this.table.RowCount = 2;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table.Size = new System.Drawing.Size(110, 85);
            this.table.TabIndex = 3;
            // 
            // icon
            // 
            this.icon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icon.Location = new System.Drawing.Point(29, 0);
            this.icon.Margin = new System.Windows.Forms.Padding(0);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(52, 52);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 1;
            this.icon.TabStop = false;
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(0, 55);
            this.label.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(110, 30);
            this.label.TabIndex = 0;
            this.label.Text = "Advancement Name";
            this.label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flow
            // 
            this.flow.AutoSize = true;
            this.flow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flow.Controls.Add(this.table);
            this.flow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flow.Location = new System.Drawing.Point(3, 16);
            this.flow.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.flow.MaximumSize = new System.Drawing.Size(0, 310);
            this.flow.MinimumSize = new System.Drawing.Size(0, 310);
            this.flow.Name = "flow";
            this.flow.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.flow.Size = new System.Drawing.Size(110, 310);
            this.flow.TabIndex = 5;
            // 
            // CAdvCriteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.group);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Name = "CAdvCriteria";
            this.Size = new System.Drawing.Size(119, 356);
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.flow.ResumeLayout(false);
            this.flow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPercent;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.FlowLayoutPanel flow;
        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Label label;
        private CPixelBox icon;
    }
}
