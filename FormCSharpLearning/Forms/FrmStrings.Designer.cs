namespace FormCSharpLearning.Forms
{
    partial class FrmStrings
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnToLower = new System.Windows.Forms.Button();
            this.btnToUpper = new System.Windows.Forms.Button();
            this.btnDisplayString = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbStringOutput = new System.Windows.Forms.TextBox();
            this.tbStringInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConcatStrings = new System.Windows.Forms.Button();
            this.tbConcatStringOutput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbConcatInputTwo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbConcatInputOne = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label28 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnInterpolateString = new System.Windows.Forms.Button();
            this.tbInterpOutput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbInterpValueTwo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbInterpValueOne = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnGetLastName = new System.Windows.Forms.Button();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbCompanyName = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbWebsite = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbEmailSuffix = new System.Windows.Forms.TextBox();
            this.btnGetEmailSuffix = new System.Windows.Forms.Button();
            this.btnGetPrefix = new System.Windows.Forms.Button();
            this.tbEmailPrefix = new System.Windows.Forms.TextBox();
            this.panelHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1148, 32);
            this.panelHeader.TabIndex = 2;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(6, 1);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(146, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Form Strings";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnToLower);
            this.panel1.Controls.Add(this.btnToUpper);
            this.panel1.Controls.Add(this.btnDisplayString);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbStringOutput);
            this.panel1.Controls.Add(this.tbStringInput);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 62);
            this.panel1.TabIndex = 3;
            // 
            // btnToLower
            // 
            this.btnToLower.Location = new System.Drawing.Point(704, 6);
            this.btnToLower.Name = "btnToLower";
            this.btnToLower.Size = new System.Drawing.Size(75, 23);
            this.btnToLower.TabIndex = 6;
            this.btnToLower.Text = "To Lower";
            this.btnToLower.UseVisualStyleBackColor = true;
            this.btnToLower.Click += new System.EventHandler(this.btnToLower_Click);
            // 
            // btnToUpper
            // 
            this.btnToUpper.Location = new System.Drawing.Point(623, 6);
            this.btnToUpper.Name = "btnToUpper";
            this.btnToUpper.Size = new System.Drawing.Size(75, 23);
            this.btnToUpper.TabIndex = 5;
            this.btnToUpper.Text = "To Upper";
            this.btnToUpper.UseVisualStyleBackColor = true;
            this.btnToUpper.Click += new System.EventHandler(this.btnToUpper_Click);
            // 
            // btnDisplayString
            // 
            this.btnDisplayString.Location = new System.Drawing.Point(504, 6);
            this.btnDisplayString.Name = "btnDisplayString";
            this.btnDisplayString.Size = new System.Drawing.Size(113, 23);
            this.btnDisplayString.TabIndex = 4;
            this.btnDisplayString.Text = "Display String";
            this.btnDisplayString.UseVisualStyleBackColor = true;
            this.btnDisplayString.Click += new System.EventHandler(this.btnDisplayString_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output";
            // 
            // tbStringOutput
            // 
            this.tbStringOutput.Enabled = false;
            this.tbStringOutput.Location = new System.Drawing.Point(105, 32);
            this.tbStringOutput.Name = "tbStringOutput";
            this.tbStringOutput.Size = new System.Drawing.Size(393, 20);
            this.tbStringOutput.TabIndex = 2;
            // 
            // tbStringInput
            // 
            this.tbStringInput.Location = new System.Drawing.Point(105, 6);
            this.tbStringInput.Name = "tbStringInput";
            this.tbStringInput.Size = new System.Drawing.Size(393, 20);
            this.tbStringInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "String to Display:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnConcatStrings);
            this.panel2.Controls.Add(this.tbConcatStringOutput);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbConcatInputTwo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tbConcatInputOne);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1148, 73);
            this.panel2.TabIndex = 4;
            // 
            // btnConcatStrings
            // 
            this.btnConcatStrings.Location = new System.Drawing.Point(809, 37);
            this.btnConcatStrings.Name = "btnConcatStrings";
            this.btnConcatStrings.Size = new System.Drawing.Size(98, 23);
            this.btnConcatStrings.TabIndex = 7;
            this.btnConcatStrings.Text = "Concatenate";
            this.btnConcatStrings.UseVisualStyleBackColor = true;
            this.btnConcatStrings.Click += new System.EventHandler(this.btnConcatStrings_Click);
            // 
            // tbConcatStringOutput
            // 
            this.tbConcatStringOutput.Enabled = false;
            this.tbConcatStringOutput.Location = new System.Drawing.Point(547, 38);
            this.tbConcatStringOutput.Name = "tbConcatStringOutput";
            this.tbConcatStringOutput.Size = new System.Drawing.Size(256, 20);
            this.tbConcatStringOutput.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(437, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Concatenated String";
            // 
            // tbConcatInputTwo
            // 
            this.tbConcatInputTwo.Location = new System.Drawing.Point(305, 38);
            this.tbConcatInputTwo.Name = "tbConcatInputTwo";
            this.tbConcatInputTwo.Size = new System.Drawing.Size(100, 20);
            this.tbConcatInputTwo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "String Value Two";
            // 
            // tbConcatInputOne
            // 
            this.tbConcatInputOne.Location = new System.Drawing.Point(106, 38);
            this.tbConcatInputOne.Name = "tbConcatInputOne";
            this.tbConcatInputOne.Size = new System.Drawing.Size(100, 20);
            this.tbConcatInputOne.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "String Value One";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.label28);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1148, 32);
            this.panel3.TabIndex = 0;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label28.Location = new System.Drawing.Point(12, 6);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(227, 20);
            this.label28.TabIndex = 2;
            this.label28.Text = "C# Strings (Concatenation)";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnInterpolateString);
            this.panel4.Controls.Add(this.tbInterpOutput);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.tbInterpValueTwo);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.tbInterpValueOne);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 167);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1148, 95);
            this.panel4.TabIndex = 5;
            // 
            // btnInterpolateString
            // 
            this.btnInterpolateString.Location = new System.Drawing.Point(640, 61);
            this.btnInterpolateString.Name = "btnInterpolateString";
            this.btnInterpolateString.Size = new System.Drawing.Size(98, 23);
            this.btnInterpolateString.TabIndex = 7;
            this.btnInterpolateString.Text = "Interpolate";
            this.btnInterpolateString.UseVisualStyleBackColor = true;
            this.btnInterpolateString.Click += new System.EventHandler(this.btnInterpolateString_Click);
            // 
            // tbInterpOutput
            // 
            this.tbInterpOutput.Enabled = false;
            this.tbInterpOutput.Location = new System.Drawing.Point(106, 64);
            this.tbInterpOutput.Name = "tbInterpOutput";
            this.tbInterpOutput.Size = new System.Drawing.Size(528, 20);
            this.tbInterpOutput.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Interpolated String";
            // 
            // tbInterpValueTwo
            // 
            this.tbInterpValueTwo.Location = new System.Drawing.Point(305, 38);
            this.tbInterpValueTwo.Name = "tbInterpValueTwo";
            this.tbInterpValueTwo.Size = new System.Drawing.Size(100, 20);
            this.tbInterpValueTwo.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "String Value Two";
            // 
            // tbInterpValueOne
            // 
            this.tbInterpValueOne.Location = new System.Drawing.Point(106, 38);
            this.tbInterpValueOne.Name = "tbInterpValueOne";
            this.tbInterpValueOne.Size = new System.Drawing.Size(100, 20);
            this.tbInterpValueOne.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "String Value One";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel5.Controls.Add(this.label9);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1148, 32);
            this.panel5.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(12, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "C# Strings (Interpolation)";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnGetPrefix);
            this.panel6.Controls.Add(this.tbEmailPrefix);
            this.panel6.Controls.Add(this.btnGetEmailSuffix);
            this.panel6.Controls.Add(this.tbEmailSuffix);
            this.panel6.Controls.Add(this.tbWebsite);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.tbEmail);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.tbAddress);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.tbCompanyName);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.btnGetLastName);
            this.panel6.Controls.Add(this.tbLastName);
            this.panel6.Controls.Add(this.tbFullName);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 262);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1148, 178);
            this.panel6.TabIndex = 6;
            // 
            // btnGetLastName
            // 
            this.btnGetLastName.Location = new System.Drawing.Point(336, 38);
            this.btnGetLastName.Name = "btnGetLastName";
            this.btnGetLastName.Size = new System.Drawing.Size(99, 23);
            this.btnGetLastName.TabIndex = 5;
            this.btnGetLastName.Text = "Get Last Name";
            this.btnGetLastName.UseVisualStyleBackColor = true;
            this.btnGetLastName.Click += new System.EventHandler(this.btnGetLastName_Click);
            // 
            // tbLastName
            // 
            this.tbLastName.Enabled = false;
            this.tbLastName.Location = new System.Drawing.Point(230, 38);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 4;
            // 
            // tbFullName
            // 
            this.tbFullName.Enabled = false;
            this.tbFullName.Location = new System.Drawing.Point(66, 38);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(158, 20);
            this.tbFullName.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Full Name";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel7.Controls.Add(this.label10);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1148, 32);
            this.panel7.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(12, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "C# Access Strings";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Company";
            // 
            // tbCompanyName
            // 
            this.tbCompanyName.Enabled = false;
            this.tbCompanyName.Location = new System.Drawing.Point(66, 66);
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.Size = new System.Drawing.Size(158, 20);
            this.tbCompanyName.TabIndex = 7;
            // 
            // tbAddress
            // 
            this.tbAddress.Enabled = false;
            this.tbAddress.Location = new System.Drawing.Point(66, 92);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(369, 20);
            this.tbAddress.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Address";
            // 
            // tbEmail
            // 
            this.tbEmail.Enabled = false;
            this.tbEmail.Location = new System.Drawing.Point(66, 118);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(158, 20);
            this.tbEmail.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 121);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Email";
            // 
            // tbWebsite
            // 
            this.tbWebsite.Enabled = false;
            this.tbWebsite.Location = new System.Drawing.Point(66, 144);
            this.tbWebsite.Name = "tbWebsite";
            this.tbWebsite.Size = new System.Drawing.Size(158, 20);
            this.tbWebsite.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 144);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Website";
            // 
            // tbEmailSuffix
            // 
            this.tbEmailSuffix.Enabled = false;
            this.tbEmailSuffix.Location = new System.Drawing.Point(230, 118);
            this.tbEmailSuffix.Name = "tbEmailSuffix";
            this.tbEmailSuffix.Size = new System.Drawing.Size(158, 20);
            this.tbEmailSuffix.TabIndex = 14;
            // 
            // btnGetEmailSuffix
            // 
            this.btnGetEmailSuffix.Location = new System.Drawing.Point(394, 118);
            this.btnGetEmailSuffix.Name = "btnGetEmailSuffix";
            this.btnGetEmailSuffix.Size = new System.Drawing.Size(104, 23);
            this.btnGetEmailSuffix.TabIndex = 15;
            this.btnGetEmailSuffix.Text = "Get Email Suffix";
            this.btnGetEmailSuffix.UseVisualStyleBackColor = true;
            this.btnGetEmailSuffix.Click += new System.EventHandler(this.btnGetEmailSuffix_Click);
            // 
            // btnGetPrefix
            // 
            this.btnGetPrefix.Location = new System.Drawing.Point(668, 118);
            this.btnGetPrefix.Name = "btnGetPrefix";
            this.btnGetPrefix.Size = new System.Drawing.Size(104, 23);
            this.btnGetPrefix.TabIndex = 17;
            this.btnGetPrefix.Text = "Get Email Prefix";
            this.btnGetPrefix.UseVisualStyleBackColor = true;
            this.btnGetPrefix.Click += new System.EventHandler(this.btnGetPrefix_Click);
            // 
            // tbEmailPrefix
            // 
            this.tbEmailPrefix.Enabled = false;
            this.tbEmailPrefix.Location = new System.Drawing.Point(504, 118);
            this.tbEmailPrefix.Name = "tbEmailPrefix";
            this.tbEmailPrefix.Size = new System.Drawing.Size(158, 20);
            this.tbEmailPrefix.TabIndex = 16;
            // 
            // FrmStrings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1148, 787);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHeader);
            this.Name = "FrmStrings";
            this.Text = "FrmStrings";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDisplayString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbStringOutput;
        private System.Windows.Forms.TextBox tbStringInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnToLower;
        private System.Windows.Forms.Button btnToUpper;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox tbConcatInputOne;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbConcatStringOutput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbConcatInputTwo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConcatStrings;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnInterpolateString;
        private System.Windows.Forms.TextBox tbInterpOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbInterpValueTwo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbInterpValueOne;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnGetLastName;
        private System.Windows.Forms.TextBox tbWebsite;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbCompanyName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnGetEmailSuffix;
        private System.Windows.Forms.TextBox tbEmailSuffix;
        private System.Windows.Forms.Button btnGetPrefix;
        private System.Windows.Forms.TextBox tbEmailPrefix;
    }
}