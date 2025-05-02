namespace TestBench_Target_WinLegacy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LabelTime = new System.Windows.Forms.Label();
            this.LabelToday = new System.Windows.Forms.Label();
            this.ButtonOpenApp = new System.Windows.Forms.Button();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.BackColor = System.Drawing.Color.Transparent;
            this.LabelTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LabelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelTime.ForeColor = System.Drawing.Color.Black;
            this.LabelTime.Location = new System.Drawing.Point(92, 96);
            this.LabelTime.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(143, 37);
            this.LabelTime.TabIndex = 1;
            this.LabelTime.Text = "00:00:00";
            this.LabelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelToday
            // 
            this.LabelToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelToday.Location = new System.Drawing.Point(254, 96);
            this.LabelToday.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.LabelToday.Name = "LabelToday";
            this.LabelToday.Size = new System.Drawing.Size(183, 42);
            this.LabelToday.TabIndex = 2;
            this.LabelToday.Text = "00.00.0000";
            // 
            // ButtonOpenApp
            // 
            this.ButtonOpenApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonOpenApp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonOpenApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonOpenApp.Location = new System.Drawing.Point(0, 403);
            this.ButtonOpenApp.Name = "ButtonOpenApp";
            this.ButtonOpenApp.Size = new System.Drawing.Size(520, 77);
            this.ButtonOpenApp.TabIndex = 3;
            this.ButtonOpenApp.Text = "Open Application";
            this.ButtonOpenApp.UseVisualStyleBackColor = true;
            this.ButtonOpenApp.Click += new System.EventHandler(this.ButtonOpenApp_Click);
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(520, 33);
            this.MenuStrip1.TabIndex = 4;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(63, 29);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(135, 30);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 480);
            this.Controls.Add(this.ButtonOpenApp);
            this.Controls.Add(this.LabelToday);
            this.Controls.Add(this.LabelTime);
            this.Controls.Add(this.MenuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestBench Target WinLegacy - Window1";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Label LabelToday;
        private System.Windows.Forms.Button ButtonOpenApp;
        private System.Windows.Forms.MenuStrip MenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
    }


}

