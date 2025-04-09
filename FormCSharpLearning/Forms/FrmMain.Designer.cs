namespace FormCSharpLearning
{
    partial class FrmMain
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnStrings = new System.Windows.Forms.Button();
            this.btnNumbers = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelSidebar.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelSidebar.Controls.Add(this.btnStrings);
            this.panelSidebar.Controls.Add(this.btnNumbers);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(159, 540);
            this.panelSidebar.TabIndex = 0;
            // 
            // btnStrings
            // 
            this.btnStrings.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnStrings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStrings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStrings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStrings.Location = new System.Drawing.Point(0, 32);
            this.btnStrings.Name = "btnStrings";
            this.btnStrings.Size = new System.Drawing.Size(159, 32);
            this.btnStrings.TabIndex = 1;
            this.btnStrings.Text = "Strings";
            this.btnStrings.UseVisualStyleBackColor = false;
            this.btnStrings.Click += new System.EventHandler(this.btnStrings_Click);
            // 
            // btnNumbers
            // 
            this.btnNumbers.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNumbers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNumbers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumbers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNumbers.Location = new System.Drawing.Point(0, 0);
            this.btnNumbers.Name = "btnNumbers";
            this.btnNumbers.Size = new System.Drawing.Size(159, 32);
            this.btnNumbers.TabIndex = 0;
            this.btnNumbers.Text = "Numericals/Numbers";
            this.btnNumbers.UseVisualStyleBackColor = false;
            this.btnNumbers.Click += new System.EventHandler(this.btnNumbers_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelHeader);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(159, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1139, 540);
            this.panelMain.TabIndex = 1;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1139, 32);
            this.panelHeader.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(6, 1);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(143, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "CurrentForm";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 540);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSidebar);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.panelSidebar.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnNumbers;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnStrings;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
    }
}

