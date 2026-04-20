namespace _2d_shapes
{
    partial class frmHome
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
            this.miGraphicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miExampleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miShapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miRectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miGraphicsToolStripMenuItem,
            this.miShapesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miGraphicsToolStripMenuItem
            // 
            this.miGraphicsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miExampleToolStripMenuItem});
            this.miGraphicsToolStripMenuItem.Name = "miGraphicsToolStripMenuItem";
            this.miGraphicsToolStripMenuItem.Size = new System.Drawing.Size(80, 26);
            this.miGraphicsToolStripMenuItem.Text = "Graphics";
            // 
            // miExampleToolStripMenuItem
            // 
            this.miExampleToolStripMenuItem.Name = "miExampleToolStripMenuItem";
            this.miExampleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.miExampleToolStripMenuItem.Text = "Example";
            this.miExampleToolStripMenuItem.Click += new System.EventHandler(this.miExampleToolStripMenuItem_Click);
            // 
            // miShapesToolStripMenuItem
            // 
            this.miShapesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miRectangleToolStripMenuItem});
            this.miShapesToolStripMenuItem.Name = "miShapesToolStripMenuItem";
            this.miShapesToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.miShapesToolStripMenuItem.Text = "Shapes";
            // 
            // miRectangleToolStripMenuItem
            // 
            this.miRectangleToolStripMenuItem.Name = "miRectangleToolStripMenuItem";
            this.miRectangleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.miRectangleToolStripMenuItem.Text = "Rectangle";
            this.miRectangleToolStripMenuItem.Click += new System.EventHandler(this.miRectangleToolStripMenuItem_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miGraphicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miExampleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miShapesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miRectangleToolStripMenuItem;
    }
}