
namespace WindowsFormsApp1
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
            this.listRoutes = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actions1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lengthOfRouteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.routeWithLengthInIntervalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByNumberOfStopsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.durationMoreThanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listRoutes
            // 
            this.listRoutes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listRoutes.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listRoutes.FormattingEnabled = true;
            this.listRoutes.ItemHeight = 15;
            this.listRoutes.Location = new System.Drawing.Point(18, 71);
            this.listRoutes.Name = "listRoutes";
            this.listRoutes.Size = new System.Drawing.Size(334, 349);
            this.listRoutes.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(63, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInput.Location = new System.Drawing.Point(21, 38);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(36, 16);
            this.lblInput.TabIndex = 2;
            this.lblInput.Text = "Input";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actions1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(375, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // actions1ToolStripMenuItem
            // 
            this.actions1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lengthOfRouteToolStripMenuItem,
            this.routeWithLengthInIntervalToolStripMenuItem,
            this.sortByNumberOfStopsToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.insertToolStripMenuItem,
            this.durationMoreThanToolStripMenuItem});
            this.actions1ToolStripMenuItem.Name = "actions1ToolStripMenuItem";
            this.actions1ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.actions1ToolStripMenuItem.Text = "Actions1";
            // 
            // lengthOfRouteToolStripMenuItem
            // 
            this.lengthOfRouteToolStripMenuItem.Name = "lengthOfRouteToolStripMenuItem";
            this.lengthOfRouteToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.lengthOfRouteToolStripMenuItem.Text = "Length of route";
            this.lengthOfRouteToolStripMenuItem.Click += new System.EventHandler(this.lengthOfRouteToolStripMenuItem_Click);
            // 
            // routeWithLengthInIntervalToolStripMenuItem
            // 
            this.routeWithLengthInIntervalToolStripMenuItem.Name = "routeWithLengthInIntervalToolStripMenuItem";
            this.routeWithLengthInIntervalToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.routeWithLengthInIntervalToolStripMenuItem.Text = "Route with length in interval";
            this.routeWithLengthInIntervalToolStripMenuItem.Click += new System.EventHandler(this.routeWithLengthInIntervalToolStripMenuItem_Click);
            // 
            // sortByNumberOfStopsToolStripMenuItem
            // 
            this.sortByNumberOfStopsToolStripMenuItem.Name = "sortByNumberOfStopsToolStripMenuItem";
            this.sortByNumberOfStopsToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.sortByNumberOfStopsToolStripMenuItem.Text = "Sort by number of stops";
            this.sortByNumberOfStopsToolStripMenuItem.Click += new System.EventHandler(this.sortByNumberOfStopsToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.insertToolStripMenuItem.Text = "Insert";
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.insertToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // durationMoreThanToolStripMenuItem
            // 
            this.durationMoreThanToolStripMenuItem.Name = "durationMoreThanToolStripMenuItem";
            this.durationMoreThanToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.durationMoreThanToolStripMenuItem.Text = "Duration more than ";
            this.durationMoreThanToolStripMenuItem.Click += new System.EventHandler(this.durationMoreThanToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 451);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listRoutes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Lab 1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listRoutes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actions1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lengthOfRouteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem routeWithLengthInIntervalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByNumberOfStopsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem durationMoreThanToolStripMenuItem;
    }
}

