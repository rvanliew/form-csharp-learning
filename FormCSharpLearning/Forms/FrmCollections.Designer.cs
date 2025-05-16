namespace FormCSharpLearning.Forms
{
    partial class FrmCollections
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbState = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetCustomerData = new System.Windows.Forms.Button();
            this.tbCustomerListCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label28 = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tbCustomerDisplay = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panelHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 787);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbCustomerDisplay);
            this.panel3.Controls.Add(this.tbState);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnGetCustomerData);
            this.panel3.Controls.Add(this.tbCustomerListCount);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1148, 499);
            this.panel3.TabIndex = 6;
            // 
            // tbState
            // 
            this.tbState.Location = new System.Drawing.Point(287, 37);
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(100, 20);
            this.tbState.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search State";
            // 
            // btnGetCustomerData
            // 
            this.btnGetCustomerData.Location = new System.Drawing.Point(394, 37);
            this.btnGetCustomerData.Name = "btnGetCustomerData";
            this.btnGetCustomerData.Size = new System.Drawing.Size(94, 23);
            this.btnGetCustomerData.TabIndex = 3;
            this.btnGetCustomerData.Text = "Customer Data";
            this.btnGetCustomerData.UseVisualStyleBackColor = true;
            this.btnGetCustomerData.Click += new System.EventHandler(this.btnGetCustomerCount_Click);
            // 
            // tbCustomerListCount
            // 
            this.tbCustomerListCount.Enabled = false;
            this.tbCustomerListCount.Location = new System.Drawing.Point(105, 36);
            this.tbCustomerListCount.Name = "tbCustomerListCount";
            this.tbCustomerListCount.Size = new System.Drawing.Size(100, 20);
            this.tbCustomerListCount.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Customers";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.Controls.Add(this.label28);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1148, 32);
            this.panel4.TabIndex = 0;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label28.Location = new System.Drawing.Point(12, 6);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(130, 20);
            this.label28.TabIndex = 2;
            this.label28.Text = "Customer Data";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1148, 32);
            this.panelHeader.TabIndex = 3;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(6, 1);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(189, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Form Collections";
            // 
            // tbCustomerDisplay
            // 
            this.tbCustomerDisplay.Location = new System.Drawing.Point(19, 67);
            this.tbCustomerDisplay.Multiline = true;
            this.tbCustomerDisplay.Name = "tbCustomerDisplay";
            this.tbCustomerDisplay.Size = new System.Drawing.Size(469, 417);
            this.tbCustomerDisplay.TabIndex = 6;
            // 
            // FrmCollections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 787);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCollections";
            this.Text = "FrmCollections";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnGetCustomerData;
        private System.Windows.Forms.TextBox tbCustomerListCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox tbState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCustomerDisplay;
    }
}