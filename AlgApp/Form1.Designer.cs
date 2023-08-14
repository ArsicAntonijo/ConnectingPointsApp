namespace AlgApp
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            findMinCostToolStripMenuItem = new ToolStripMenuItem();
            findMinLineNumberToolStripMenuItem = new ToolStripMenuItem();
            removeAllPointsToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            resultTextBox = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, findMinCostToolStripMenuItem, findMinLineNumberToolStripMenuItem, removeAllPointsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(935, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(116, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // findMinCostToolStripMenuItem
            // 
            findMinCostToolStripMenuItem.Name = "findMinCostToolStripMenuItem";
            findMinCostToolStripMenuItem.Size = new Size(111, 24);
            findMinCostToolStripMenuItem.Text = "Find min cost";
            findMinCostToolStripMenuItem.Click += findMinCostToolStripMenuItem_Click;
            // 
            // findMinLineNumberToolStripMenuItem
            // 
            findMinLineNumberToolStripMenuItem.Name = "findMinLineNumberToolStripMenuItem";
            findMinLineNumberToolStripMenuItem.Size = new Size(163, 24);
            findMinLineNumberToolStripMenuItem.Text = "Find min line number";
            findMinLineNumberToolStripMenuItem.Click += findMinLineNumberToolStripMenuItem_Click;
            // 
            // removeAllPointsToolStripMenuItem
            // 
            removeAllPointsToolStripMenuItem.Name = "removeAllPointsToolStripMenuItem";
            removeAllPointsToolStripMenuItem.Size = new Size(142, 24);
            removeAllPointsToolStripMenuItem.Text = "Remove all points";
            removeAllPointsToolStripMenuItem.Click += removeAllPointsToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(0, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(55, 624);
            panel1.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Location = new Point(117, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(742, 57);
            panel3.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Location = new Point(883, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(52, 624);
            panel2.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLight;
            panel4.Location = new Point(51, 609);
            panel4.Name = "panel4";
            panel4.Size = new Size(840, 46);
            panel4.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlLight;
            panel5.Location = new Point(51, 28);
            panel5.Name = "panel5";
            panel5.Size = new Size(840, 54);
            panel5.TabIndex = 7;
            // 
            // resultTextBox
            // 
            resultTextBox.Enabled = false;
            resultTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            resultTextBox.Location = new Point(263, 567);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(385, 34);
            resultTextBox.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 655);
            Controls.Add(resultTextBox);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Coordinate system problems";
            Load += Form1_Load;
            MouseClick += mouseClick;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem findMinCostToolStripMenuItem;
        private ToolStripMenuItem findMinLineNumberToolStripMenuItem;
        private ToolStripMenuItem removeAllPointsToolStripMenuItem;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private Panel panel5;
        private TextBox resultTextBox;
        private ContextMenuStrip contextMenuStrip1;
    }
}