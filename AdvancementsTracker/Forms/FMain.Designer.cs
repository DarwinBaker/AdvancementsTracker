namespace AdvancementsTracker.Forms
{
    partial class FMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.groupStatus = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.divider1 = new System.Windows.Forms.GroupBox();
            this.buttonDonate = new System.Windows.Forms.Button();
            this.labelCurrentSave = new System.Windows.Forms.Label();
            this.labelDonate = new System.Windows.Forms.Label();
            this.labelPercent = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.labelProgress = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.groupNether = new System.Windows.Forms.GroupBox();
            this.flowNether = new System.Windows.Forms.FlowLayoutPanel();
            this.groupAbout = new System.Windows.Forms.GroupBox();
            this.labelMinecraftVersion = new System.Windows.Forms.Label();
            this.linkGitHub = new System.Windows.Forms.LinkLabel();
            this.richInfo = new System.Windows.Forms.RichTextBox();
            this.buttonPreferences = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupHusbandry = new System.Windows.Forms.GroupBox();
            this.flowHusbandry = new System.Windows.Forms.FlowLayoutPanel();
            this.groupPotions = new System.Windows.Forms.GroupBox();
            this.flowPotions = new System.Windows.Forms.FlowLayoutPanel();
            this.groupMinecraft = new System.Windows.Forms.GroupBox();
            this.flowMinecraft = new System.Windows.Forms.FlowLayoutPanel();
            this.groupAdventure = new System.Windows.Forms.GroupBox();
            this.flowAdventure = new System.Windows.Forms.FlowLayoutPanel();
            this.groupEnd = new System.Windows.Forms.GroupBox();
            this.flowEnd = new System.Windows.Forms.FlowLayoutPanel();
            this.flowCriteria = new System.Windows.Forms.FlowLayoutPanel();
            this.table.SuspendLayout();
            this.groupStatus.SuspendLayout();
            this.panel.SuspendLayout();
            this.groupNether.SuspendLayout();
            this.groupAbout.SuspendLayout();
            this.groupHusbandry.SuspendLayout();
            this.groupPotions.SuspendLayout();
            this.groupMinecraft.SuspendLayout();
            this.groupAdventure.SuspendLayout();
            this.groupEnd.SuspendLayout();
            this.SuspendLayout();
            // 
            // worker
            // 
            this.worker.WorkerReportsProgress = true;
            this.worker.WorkerSupportsCancellation = true;
            this.worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.OnDoWork);
            this.worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.OnProgressChanged);
            this.worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.OnWorkerCompleted);
            // 
            // table
            // 
            this.table.ColumnCount = 1;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table.Controls.Add(this.groupStatus, 0, 2);
            this.table.Controls.Add(this.panel, 0, 0);
            this.table.Controls.Add(this.flowCriteria, 0, 1);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(3, 3);
            this.table.Margin = new System.Windows.Forms.Padding(0);
            this.table.Name = "table";
            this.table.RowCount = 3;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 545F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 355F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.table.Size = new System.Drawing.Size(1793, 949);
            this.table.TabIndex = 80;
            // 
            // groupStatus
            // 
            this.groupStatus.Controls.Add(this.groupBox1);
            this.groupStatus.Controls.Add(this.divider1);
            this.groupStatus.Controls.Add(this.buttonDonate);
            this.groupStatus.Controls.Add(this.labelCurrentSave);
            this.groupStatus.Controls.Add(this.labelDonate);
            this.groupStatus.Controls.Add(this.labelPercent);
            this.groupStatus.Controls.Add(this.progress);
            this.groupStatus.Controls.Add(this.labelProgress);
            this.groupStatus.Location = new System.Drawing.Point(3, 900);
            this.groupStatus.Margin = new System.Windows.Forms.Padding(3, 0, 4, 2);
            this.groupStatus.Name = "groupStatus";
            this.groupStatus.Size = new System.Drawing.Size(1786, 47);
            this.groupStatus.TabIndex = 87;
            this.groupStatus.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(1082, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(2, 31);
            this.groupBox1.TabIndex = 85;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // divider1
            // 
            this.divider1.Location = new System.Drawing.Point(269, 9);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(2, 31);
            this.divider1.TabIndex = 84;
            this.divider1.TabStop = false;
            this.divider1.Text = "groupBox1";
            // 
            // buttonDonate
            // 
            this.buttonDonate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDonate.ForeColor = System.Drawing.Color.Blue;
            this.buttonDonate.Location = new System.Drawing.Point(1629, 9);
            this.buttonDonate.Name = "buttonDonate";
            this.buttonDonate.Size = new System.Drawing.Size(154, 33);
            this.buttonDonate.TabIndex = 4;
            this.buttonDonate.Text = "paypal.me/DarwinBaker";
            this.buttonDonate.UseVisualStyleBackColor = true;
            this.buttonDonate.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // labelCurrentSave
            // 
            this.labelCurrentSave.AutoSize = true;
            this.labelCurrentSave.Location = new System.Drawing.Point(284, 20);
            this.labelCurrentSave.Margin = new System.Windows.Forms.Padding(10, 0, 3, 3);
            this.labelCurrentSave.Name = "labelCurrentSave";
            this.labelCurrentSave.Size = new System.Drawing.Size(90, 13);
            this.labelCurrentSave.TabIndex = 81;
            this.labelCurrentSave.Text = "No Saves Found.";
            // 
            // labelDonate
            // 
            this.labelDonate.AutoSize = true;
            this.labelDonate.Location = new System.Drawing.Point(1097, 20);
            this.labelDonate.Margin = new System.Windows.Forms.Padding(10, 0, 3, 3);
            this.labelDonate.Name = "labelDonate";
            this.labelDonate.Size = new System.Drawing.Size(526, 13);
            this.labelDonate.TabIndex = 78;
            this.labelDonate.Text = "If you like this tool and want to support its continued development, please consi" +
    "der donating! Anything helps! :)";
            // 
            // labelPercent
            // 
            this.labelPercent.Location = new System.Drawing.Point(214, 9);
            this.labelPercent.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.Size = new System.Drawing.Size(39, 13);
            this.labelPercent.TabIndex = 82;
            this.labelPercent.Text = "(0%)";
            this.labelPercent.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(5, 26);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(250, 15);
            this.progress.TabIndex = 80;
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(5, 9);
            this.labelProgress.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(160, 13);
            this.labelProgress.TabIndex = 79;
            this.labelProgress.Text = "Advancements Completed: 0 / 0";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.groupNether);
            this.panel.Controls.Add(this.groupAbout);
            this.panel.Controls.Add(this.groupHusbandry);
            this.panel.Controls.Add(this.groupPotions);
            this.panel.Controls.Add(this.groupMinecraft);
            this.panel.Controls.Add(this.groupAdventure);
            this.panel.Controls.Add(this.groupEnd);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1793, 545);
            this.panel.TabIndex = 81;
            // 
            // groupNether
            // 
            this.groupNether.AutoSize = true;
            this.groupNether.Controls.Add(this.flowNether);
            this.groupNether.Location = new System.Drawing.Point(3, 152);
            this.groupNether.Name = "groupNether";
            this.groupNether.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.groupNether.Size = new System.Drawing.Size(508, 394);
            this.groupNether.TabIndex = 80;
            this.groupNether.TabStop = false;
            this.groupNether.Text = "Nether";
            // 
            // flowNether
            // 
            this.flowNether.Location = new System.Drawing.Point(8, 19);
            this.flowNether.Margin = new System.Windows.Forms.Padding(5, 3, 3, 0);
            this.flowNether.Name = "flowNether";
            this.flowNether.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.flowNether.Size = new System.Drawing.Size(494, 362);
            this.flowNether.TabIndex = 51;
            // 
            // groupAbout
            // 
            this.groupAbout.Controls.Add(this.labelMinecraftVersion);
            this.groupAbout.Controls.Add(this.linkGitHub);
            this.groupAbout.Controls.Add(this.richInfo);
            this.groupAbout.Controls.Add(this.buttonPreferences);
            this.groupAbout.Controls.Add(this.buttonExit);
            this.groupAbout.Location = new System.Drawing.Point(3, 3);
            this.groupAbout.Name = "groupAbout";
            this.groupAbout.Size = new System.Drawing.Size(508, 148);
            this.groupAbout.TabIndex = 79;
            this.groupAbout.TabStop = false;
            // 
            // labelMinecraftVersion
            // 
            this.labelMinecraftVersion.Location = new System.Drawing.Point(406, 129);
            this.labelMinecraftVersion.Name = "labelMinecraftVersion";
            this.labelMinecraftVersion.Size = new System.Drawing.Size(100, 14);
            this.labelMinecraftVersion.TabIndex = 73;
            this.labelMinecraftVersion.Text = "For Minecraft ";
            this.labelMinecraftVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // linkGitHub
            // 
            this.linkGitHub.AutoSize = true;
            this.linkGitHub.Location = new System.Drawing.Point(174, 129);
            this.linkGitHub.Name = "linkGitHub";
            this.linkGitHub.Size = new System.Drawing.Size(40, 13);
            this.linkGitHub.TabIndex = 3;
            this.linkGitHub.TabStop = true;
            this.linkGitHub.Text = "GitHub";
            this.linkGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLinkClicked);
            // 
            // richInfo
            // 
            this.richInfo.BackColor = System.Drawing.SystemColors.Control;
            this.richInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richInfo.Location = new System.Drawing.Point(5, 12);
            this.richInfo.Name = "richInfo";
            this.richInfo.ReadOnly = true;
            this.richInfo.Size = new System.Drawing.Size(410, 131);
            this.richInfo.TabIndex = 67;
            this.richInfo.Text = resources.GetString("richInfo.Text");
            // 
            // buttonPreferences
            // 
            this.buttonPreferences.Location = new System.Drawing.Point(427, 13);
            this.buttonPreferences.Name = "buttonPreferences";
            this.buttonPreferences.Size = new System.Drawing.Size(75, 23);
            this.buttonPreferences.TabIndex = 1;
            this.buttonPreferences.Text = "Preferences";
            this.buttonPreferences.UseVisualStyleBackColor = true;
            this.buttonPreferences.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(427, 42);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // groupHusbandry
            // 
            this.groupHusbandry.AutoSize = true;
            this.groupHusbandry.Controls.Add(this.flowHusbandry);
            this.groupHusbandry.Location = new System.Drawing.Point(1031, 319);
            this.groupHusbandry.Name = "groupHusbandry";
            this.groupHusbandry.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.groupHusbandry.Size = new System.Drawing.Size(508, 227);
            this.groupHusbandry.TabIndex = 78;
            this.groupHusbandry.TabStop = false;
            this.groupHusbandry.Text = "Husbandry";
            // 
            // flowHusbandry
            // 
            this.flowHusbandry.Location = new System.Drawing.Point(8, 19);
            this.flowHusbandry.Margin = new System.Windows.Forms.Padding(5, 3, 3, 0);
            this.flowHusbandry.Name = "flowHusbandry";
            this.flowHusbandry.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.flowHusbandry.Size = new System.Drawing.Size(492, 195);
            this.flowHusbandry.TabIndex = 54;
            // 
            // groupPotions
            // 
            this.groupPotions.AutoSize = true;
            this.groupPotions.Controls.Add(this.flowPotions);
            this.groupPotions.Location = new System.Drawing.Point(1545, 3);
            this.groupPotions.Name = "groupPotions";
            this.groupPotions.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.groupPotions.Size = new System.Drawing.Size(244, 543);
            this.groupPotions.TabIndex = 77;
            this.groupPotions.TabStop = false;
            this.groupPotions.Text = "How Did We Get Here Recipes";
            // 
            // flowPotions
            // 
            this.flowPotions.Location = new System.Drawing.Point(6, 19);
            this.flowPotions.Margin = new System.Windows.Forms.Padding(5, 3, 3, 0);
            this.flowPotions.Name = "flowPotions";
            this.flowPotions.Size = new System.Drawing.Size(230, 511);
            this.flowPotions.TabIndex = 49;
            // 
            // groupMinecraft
            // 
            this.groupMinecraft.AutoSize = true;
            this.groupMinecraft.Controls.Add(this.flowMinecraft);
            this.groupMinecraft.Location = new System.Drawing.Point(517, 3);
            this.groupMinecraft.Name = "groupMinecraft";
            this.groupMinecraft.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.groupMinecraft.Size = new System.Drawing.Size(508, 310);
            this.groupMinecraft.TabIndex = 76;
            this.groupMinecraft.TabStop = false;
            this.groupMinecraft.Text = "Minecraft";
            // 
            // flowMinecraft
            // 
            this.flowMinecraft.Location = new System.Drawing.Point(8, 19);
            this.flowMinecraft.Margin = new System.Windows.Forms.Padding(5, 3, 3, 0);
            this.flowMinecraft.Name = "flowMinecraft";
            this.flowMinecraft.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.flowMinecraft.Size = new System.Drawing.Size(492, 275);
            this.flowMinecraft.TabIndex = 48;
            // 
            // groupAdventure
            // 
            this.groupAdventure.AutoSize = true;
            this.groupAdventure.Controls.Add(this.flowAdventure);
            this.groupAdventure.Location = new System.Drawing.Point(1031, 3);
            this.groupAdventure.Name = "groupAdventure";
            this.groupAdventure.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.groupAdventure.Size = new System.Drawing.Size(508, 310);
            this.groupAdventure.TabIndex = 75;
            this.groupAdventure.TabStop = false;
            this.groupAdventure.Text = "Adventure";
            // 
            // flowAdventure
            // 
            this.flowAdventure.Location = new System.Drawing.Point(8, 19);
            this.flowAdventure.Margin = new System.Windows.Forms.Padding(5, 3, 3, 0);
            this.flowAdventure.Name = "flowAdventure";
            this.flowAdventure.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.flowAdventure.Size = new System.Drawing.Size(492, 275);
            this.flowAdventure.TabIndex = 54;
            // 
            // groupEnd
            // 
            this.groupEnd.AutoSize = true;
            this.groupEnd.Controls.Add(this.flowEnd);
            this.groupEnd.Location = new System.Drawing.Point(517, 319);
            this.groupEnd.Name = "groupEnd";
            this.groupEnd.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.groupEnd.Size = new System.Drawing.Size(508, 227);
            this.groupEnd.TabIndex = 74;
            this.groupEnd.TabStop = false;
            this.groupEnd.Text = "End";
            // 
            // flowEnd
            // 
            this.flowEnd.Location = new System.Drawing.Point(8, 19);
            this.flowEnd.Margin = new System.Windows.Forms.Padding(5, 3, 3, 0);
            this.flowEnd.Name = "flowEnd";
            this.flowEnd.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.flowEnd.Size = new System.Drawing.Size(492, 195);
            this.flowEnd.TabIndex = 49;
            // 
            // flowCriteria
            // 
            this.flowCriteria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowCriteria.Location = new System.Drawing.Point(0, 545);
            this.flowCriteria.Margin = new System.Windows.Forms.Padding(0);
            this.flowCriteria.Name = "flowCriteria";
            this.flowCriteria.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.flowCriteria.Size = new System.Drawing.Size(1793, 355);
            this.flowCriteria.TabIndex = 86;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1798, 955);
            this.Controls.Add(this.table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FMain";
            this.Padding = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.Text = "CTM\'s Advancement Tracker v1.2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.ResizeBegin += new System.EventHandler(this.OnResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.OnResizeEnd);
            this.table.ResumeLayout(false);
            this.groupStatus.ResumeLayout(false);
            this.groupStatus.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.groupNether.ResumeLayout(false);
            this.groupAbout.ResumeLayout(false);
            this.groupAbout.PerformLayout();
            this.groupHusbandry.ResumeLayout(false);
            this.groupPotions.ResumeLayout(false);
            this.groupMinecraft.ResumeLayout(false);
            this.groupAdventure.ResumeLayout(false);
            this.groupEnd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker worker;
        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.GroupBox groupNether;
        private System.Windows.Forms.FlowLayoutPanel flowNether;
        private System.Windows.Forms.GroupBox groupAbout;
        private System.Windows.Forms.Label labelMinecraftVersion;
        private System.Windows.Forms.LinkLabel linkGitHub;
        private System.Windows.Forms.RichTextBox richInfo;
        private System.Windows.Forms.Button buttonPreferences;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupHusbandry;
        private System.Windows.Forms.FlowLayoutPanel flowHusbandry;
        private System.Windows.Forms.GroupBox groupPotions;
        private System.Windows.Forms.FlowLayoutPanel flowPotions;
        private System.Windows.Forms.GroupBox groupMinecraft;
        private System.Windows.Forms.FlowLayoutPanel flowMinecraft;
        private System.Windows.Forms.GroupBox groupAdventure;
        private System.Windows.Forms.FlowLayoutPanel flowAdventure;
        private System.Windows.Forms.GroupBox groupEnd;
        private System.Windows.Forms.FlowLayoutPanel flowEnd;
        private System.Windows.Forms.FlowLayoutPanel flowCriteria;
        private System.Windows.Forms.GroupBox groupStatus;
        private System.Windows.Forms.Label labelCurrentSave;
        private System.Windows.Forms.Label labelDonate;
        private System.Windows.Forms.Label labelPercent;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.Button buttonDonate;
        private System.Windows.Forms.GroupBox divider1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

