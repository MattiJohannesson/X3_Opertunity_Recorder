namespace X3_Opertunity_Recorder
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addOpertunityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addResourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(966, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.addOpertunityToolStripMenuItem,
            this.addResourceToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addOpertunityToolStripMenuItem
            // 
            this.addOpertunityToolStripMenuItem.Name = "addOpertunityToolStripMenuItem";
            this.addOpertunityToolStripMenuItem.Size = new System.Drawing.Size(247, 34);
            this.addOpertunityToolStripMenuItem.Text = "Add Opertunity";
            this.addOpertunityToolStripMenuItem.Click += new System.EventHandler(this.addOpertunityToolStripMenuItem_Click);
            // 
            // addResourceToolStripMenuItem
            // 
            this.addResourceToolStripMenuItem.Name = "addResourceToolStripMenuItem";
            this.addResourceToolStripMenuItem.Size = new System.Drawing.Size(247, 34);
            this.addResourceToolStripMenuItem.Text = "Add Resource";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(247, 34);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(247, 34);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.vScrollBar1);
            this.panel1.Location = new System.Drawing.Point(13, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 558);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(911, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(30, 558);
            this.vScrollBar1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 624);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "X3: Opertunity Recorder";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addOpertunityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addResourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}

