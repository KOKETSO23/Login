namespace Login
{
    partial class Form4
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
            this.learnersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teachersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewLearnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.learnerListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferFormsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.learnersToolStripMenuItem,
            this.teachersToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // learnersToolStripMenuItem
            // 
            this.learnersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewLearnerToolStripMenuItem,
            this.learnerListToolStripMenuItem,
            this.editRemoveToolStripMenuItem,
            this.transferFormsToolStripMenuItem});
            this.learnersToolStripMenuItem.Name = "learnersToolStripMenuItem";
            this.learnersToolStripMenuItem.Size = new System.Drawing.Size(125, 31);
            this.learnersToolStripMenuItem.Text = "Learners";
            // 
            // teachersToolStripMenuItem
            // 
            this.teachersToolStripMenuItem.Name = "teachersToolStripMenuItem";
            this.teachersToolStripMenuItem.Size = new System.Drawing.Size(128, 31);
            this.teachersToolStripMenuItem.Text = "Teachers";
            this.teachersToolStripMenuItem.Click += new System.EventHandler(this.teachersToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(114, 31);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // addNewLearnerToolStripMenuItem
            // 
            this.addNewLearnerToolStripMenuItem.Name = "addNewLearnerToolStripMenuItem";
            this.addNewLearnerToolStripMenuItem.Size = new System.Drawing.Size(288, 32);
            this.addNewLearnerToolStripMenuItem.Text = "Add new Learner";
            this.addNewLearnerToolStripMenuItem.Click += new System.EventHandler(this.addNewLearnerToolStripMenuItem_Click);
            // 
            // learnerListToolStripMenuItem
            // 
            this.learnerListToolStripMenuItem.Name = "learnerListToolStripMenuItem";
            this.learnerListToolStripMenuItem.Size = new System.Drawing.Size(288, 32);
            this.learnerListToolStripMenuItem.Text = "Learner List";
            // 
            // editRemoveToolStripMenuItem
            // 
            this.editRemoveToolStripMenuItem.Name = "editRemoveToolStripMenuItem";
            this.editRemoveToolStripMenuItem.Size = new System.Drawing.Size(288, 32);
            this.editRemoveToolStripMenuItem.Text = "Edit/Remove";
            // 
            // transferFormsToolStripMenuItem
            // 
            this.transferFormsToolStripMenuItem.Name = "transferFormsToolStripMenuItem";
            this.transferFormsToolStripMenuItem.Size = new System.Drawing.Size(288, 32);
            this.transferFormsToolStripMenuItem.Text = "Transfer Forms ";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem learnersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teachersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewLearnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem learnerListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRemoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferFormsToolStripMenuItem;
    }
}