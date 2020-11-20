namespace AdvancementsTracker.Controls
{
    partial class CPotion
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
            this.flow = new System.Windows.Forms.FlowLayoutPanel();
            this.group = new System.Windows.Forms.GroupBox();
            this.pic = new AdvancementsTracker.Controls.CPixelBox();
            this.group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // flow
            // 
            this.flow.Location = new System.Drawing.Point(42, 14);
            this.flow.Name = "flow";
            this.flow.Size = new System.Drawing.Size(182, 32);
            this.flow.TabIndex = 0;
            // 
            // group
            // 
            this.group.Controls.Add(this.pic);
            this.group.Controls.Add(this.flow);
            this.group.Location = new System.Drawing.Point(0, 0);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(226, 54);
            this.group.TabIndex = 2;
            this.group.TabStop = false;
            this.group.Text = "Potion Name";
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(4, 14);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(32, 32);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 1;
            this.pic.TabStop = false;
            // 
            // CPotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.group);
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.Name = "CPotion";
            this.Size = new System.Drawing.Size(230, 53);
            this.group.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flow;
        private CPixelBox pic;
        private System.Windows.Forms.GroupBox group;
    }
}
