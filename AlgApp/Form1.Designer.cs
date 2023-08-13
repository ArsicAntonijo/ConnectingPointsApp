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
            labelY = new Label();
            labelX = new Label();
            ConnectBtn = new Button();
            SuspendLayout();
            // 
            // labelY
            // 
            labelY.AutoSize = true;
            labelY.Location = new Point(725, 434);
            labelY.Name = "labelY";
            labelY.Size = new Size(25, 20);
            labelY.TabIndex = 0;
            labelY.Text = "10";
            labelY.Click += labelY_Click;
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Location = new Point(3, 29);
            labelX.Name = "labelX";
            labelX.Size = new Size(25, 20);
            labelX.TabIndex = 1;
            labelX.Text = "10";
            // 
            // ConnectBtn
            // 
            ConnectBtn.Location = new Point(297, 486);
            ConnectBtn.Name = "ConnectBtn";
            ConnectBtn.Size = new Size(147, 29);
            ConnectBtn.TabIndex = 2;
            ConnectBtn.Text = "Connect dots";
            ConnectBtn.UseVisualStyleBackColor = true;
            ConnectBtn.Click += ConnectBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 517);
            Controls.Add(ConnectBtn);
            Controls.Add(labelX);
            Controls.Add(labelY);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            MouseClick += mouseClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelY;
        private Label labelX;
        private Button ConnectBtn;
    }
}