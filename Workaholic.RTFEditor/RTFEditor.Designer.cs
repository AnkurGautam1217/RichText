namespace Workaholic.RTFEditor
{
    partial class RTFEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RTFEditor));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.ts = new System.Windows.Forms.ToolStrip();
            this.tsBullet = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.ts.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.rtb);
            resources.ApplyResources(this.toolStripContainer1.ContentPanel, "toolStripContainer1.ContentPanel");
            resources.ApplyResources(this.toolStripContainer1, "toolStripContainer1");
            this.toolStripContainer1.Name = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.ts);
            // 
            // rtb
            // 
            resources.ApplyResources(this.rtb, "rtb");
            this.rtb.HideSelection = false;
            this.rtb.Name = "rtb";
            this.rtb.TabStop = false;
            this.rtb.SelectionChanged += new System.EventHandler(this.rtb_SelectionChanged);
            // 
            // ts
            // 
            this.ts.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.ts, "ts");
            this.ts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBullet});
            this.ts.Name = "ts";
            // 
            // tsBullet
            // 
            this.tsBullet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBullet.Image = global::Workaholic.RTFEditor.Properties.Resources.bullist;
            resources.ApplyResources(this.tsBullet, "tsBullet");
            this.tsBullet.Name = "tsBullet";
            this.tsBullet.Click += new System.EventHandler(this.tsBullet_Click);
            // 
            // RTFEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripContainer1);
            this.DoubleBuffered = true;
            this.Name = "RTFEditor";
            this.Load += new System.EventHandler(this.RTFEditor_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ts.ResumeLayout(false);
            this.ts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.ToolStrip ts;
        private System.Windows.Forms.ToolStripButton tsBullet;

    }
}
