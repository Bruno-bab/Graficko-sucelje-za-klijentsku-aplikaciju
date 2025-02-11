namespace Grafičko_sučelje_za_klijentsku_aplikaciju
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            fileToolStripMenuItem1 = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            fileViewToolStripMenuItem = new ToolStripMenuItem();
            treeViewToolStripMenuItem = new ToolStripMenuItem();
            finishedToolStripMenuItem = new ToolStripMenuItem();
            finishToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.Location = new Point(0, 31);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1079, 472);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // fileToolStripMenuItem1
            // 
            fileToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            fileToolStripMenuItem1.Size = new Size(46, 24);
            fileToolStripMenuItem1.Text = "File";
            fileToolStripMenuItem1.Click += fileToolStripMenuItem1_Click;
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(128, 26);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(128, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(128, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // fileViewToolStripMenuItem
            // 
            fileViewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { treeViewToolStripMenuItem });
            fileViewToolStripMenuItem.Name = "fileViewToolStripMenuItem";
            fileViewToolStripMenuItem.Size = new Size(80, 24);
            fileViewToolStripMenuItem.Text = "File view";
            fileViewToolStripMenuItem.Click += fileViewToolStripMenuItem_Click;
            // 
            // treeViewToolStripMenuItem
            // 
            treeViewToolStripMenuItem.Name = "treeViewToolStripMenuItem";
            treeViewToolStripMenuItem.Size = new Size(152, 26);
            treeViewToolStripMenuItem.Text = "TreeView";
            treeViewToolStripMenuItem.Click += treeViewToolStripMenuItem_Click;
            // 
            // finishedToolStripMenuItem
            // 
            finishedToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { finishToolStripMenuItem });
            finishedToolStripMenuItem.Name = "finishedToolStripMenuItem";
            finishedToolStripMenuItem.Size = new Size(77, 24);
            finishedToolStripMenuItem.Text = "Finished";
            finishedToolStripMenuItem.Click += finishedToolStripMenuItem_Click;
            // 
            // finishToolStripMenuItem
            // 
            finishToolStripMenuItem.Name = "finishToolStripMenuItem";
            finishToolStripMenuItem.Size = new Size(129, 26);
            finishToolStripMenuItem.Text = "Finish";
            finishToolStripMenuItem.Click += finishToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem1, fileViewToolStripMenuItem, finishedToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1079, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 500);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Client Application";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox richTextBox1;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem fileViewToolStripMenuItem;
        private ToolStripMenuItem treeViewToolStripMenuItem;
        private ToolStripMenuItem finishedToolStripMenuItem;
        private ToolStripMenuItem finishToolStripMenuItem;
        private MenuStrip menuStrip1;
    }
}
