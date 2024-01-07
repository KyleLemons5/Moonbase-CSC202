namespace Moonbase
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxLI = new System.Windows.Forms.GroupBox();
            textBoxDesc = new System.Windows.Forms.RichTextBox();
            labelRD = new System.Windows.Forms.Label();
            textBoxName = new System.Windows.Forms.RichTextBox();
            labelRN = new System.Windows.Forms.Label();
            navBox = new System.Windows.Forms.GroupBox();
            southButton = new System.Windows.Forms.Button();
            eastButton = new System.Windows.Forms.Button();
            westButton = new System.Windows.Forms.Button();
            northButton = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            JobLabel = new System.Windows.Forms.Label();
            JobText = new System.Windows.Forms.TextBox();
            NameLabel = new System.Windows.Forms.Label();
            NameText = new System.Windows.Forms.TextBox();
            UserText = new System.Windows.Forms.Label();
            groupBoxLI.SuspendLayout();
            navBox.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxLI
            // 
            groupBoxLI.Controls.Add(textBoxDesc);
            groupBoxLI.Controls.Add(labelRD);
            groupBoxLI.Controls.Add(textBoxName);
            groupBoxLI.Controls.Add(labelRN);
            groupBoxLI.Location = new System.Drawing.Point(544, 217);
            groupBoxLI.Name = "groupBoxLI";
            groupBoxLI.Size = new System.Drawing.Size(397, 205);
            groupBoxLI.TabIndex = 0;
            groupBoxLI.TabStop = false;
            groupBoxLI.Text = "Location Information";
            // 
            // textBoxDesc
            // 
            textBoxDesc.Location = new System.Drawing.Point(6, 101);
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.ReadOnly = true;
            textBoxDesc.Size = new System.Drawing.Size(385, 98);
            textBoxDesc.TabIndex = 3;
            textBoxDesc.Text = resources.GetString("textBoxDesc.Text");
            // 
            // labelRD
            // 
            labelRD.AutoSize = true;
            labelRD.Location = new System.Drawing.Point(6, 83);
            labelRD.Name = "labelRD";
            labelRD.Size = new System.Drawing.Size(102, 15);
            labelRD.TabIndex = 2;
            labelRD.Text = "Room Description";
            // 
            // textBoxName
            // 
            textBoxName.Location = new System.Drawing.Point(6, 37);
            textBoxName.Name = "textBoxName";
            textBoxName.ReadOnly = true;
            textBoxName.Size = new System.Drawing.Size(385, 21);
            textBoxName.TabIndex = 1;
            textBoxName.Text = "Reading Room";
            // 
            // labelRN
            // 
            labelRN.AutoSize = true;
            labelRN.Location = new System.Drawing.Point(6, 19);
            labelRN.Name = "labelRN";
            labelRN.Size = new System.Drawing.Size(74, 15);
            labelRN.TabIndex = 0;
            labelRN.Text = "Room Name";
            // 
            // navBox
            // 
            navBox.Controls.Add(southButton);
            navBox.Controls.Add(eastButton);
            navBox.Controls.Add(westButton);
            navBox.Controls.Add(northButton);
            navBox.Location = new System.Drawing.Point(156, 217);
            navBox.Name = "navBox";
            navBox.Size = new System.Drawing.Size(200, 185);
            navBox.TabIndex = 1;
            navBox.TabStop = false;
            navBox.Text = "Personal Nav Device";
            // 
            // southButton
            // 
            southButton.Location = new System.Drawing.Point(66, 126);
            southButton.Name = "southButton";
            southButton.Size = new System.Drawing.Size(75, 46);
            southButton.TabIndex = 3;
            southButton.Text = "South";
            southButton.UseVisualStyleBackColor = true;
            southButton.Click += southButton_Click;
            // 
            // eastButton
            // 
            eastButton.Location = new System.Drawing.Point(119, 74);
            eastButton.Name = "eastButton";
            eastButton.Size = new System.Drawing.Size(75, 46);
            eastButton.TabIndex = 2;
            eastButton.Text = "East";
            eastButton.UseVisualStyleBackColor = true;
            eastButton.Click += eastButton_Click;
            // 
            // westButton
            // 
            westButton.Location = new System.Drawing.Point(6, 74);
            westButton.Name = "westButton";
            westButton.Size = new System.Drawing.Size(75, 46);
            westButton.TabIndex = 1;
            westButton.Text = "West";
            westButton.UseVisualStyleBackColor = true;
            westButton.Click += westButton_Click;
            // 
            // northButton
            // 
            northButton.Location = new System.Drawing.Point(66, 22);
            northButton.Name = "northButton";
            northButton.Size = new System.Drawing.Size(75, 46);
            northButton.TabIndex = 0;
            northButton.Text = "North";
            northButton.UseVisualStyleBackColor = true;
            northButton.Click += northButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(JobLabel);
            groupBox1.Controls.Add(JobText);
            groupBox1.Controls.Add(NameLabel);
            groupBox1.Controls.Add(NameText);
            groupBox1.Controls.Add(UserText);
            groupBox1.Location = new System.Drawing.Point(156, 444);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(238, 175);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Who's Here";
            // 
            // JobLabel
            // 
            JobLabel.AutoSize = true;
            JobLabel.Location = new System.Drawing.Point(119, 44);
            JobLabel.Name = "JobLabel";
            JobLabel.Size = new System.Drawing.Size(50, 15);
            JobLabel.TabIndex = 4;
            JobLabel.Text = "Job Title";
            // 
            // JobText
            // 
            JobText.Location = new System.Drawing.Point(119, 62);
            JobText.Multiline = true;
            JobText.Name = "JobText";
            JobText.ReadOnly = true;
            JobText.Size = new System.Drawing.Size(113, 107);
            JobText.TabIndex = 3;
            JobText.Text = "Librarian\r\n";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new System.Drawing.Point(6, 44);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new System.Drawing.Size(39, 15);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Name";
            // 
            // NameText
            // 
            NameText.Location = new System.Drawing.Point(6, 62);
            NameText.Multiline = true;
            NameText.Name = "NameText";
            NameText.ReadOnly = true;
            NameText.Size = new System.Drawing.Size(107, 107);
            NameText.TabIndex = 1;
            NameText.Text = "John\r\nJohnny";
            // 
            // UserText
            // 
            UserText.AutoSize = true;
            UserText.Location = new System.Drawing.Point(6, 19);
            UserText.Name = "UserText";
            UserText.Size = new System.Drawing.Size(51, 15);
            UserText.TabIndex = 0;
            UserText.Text = "UserText";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Moonbase_Room;
            ClientSize = new System.Drawing.Size(1904, 1041);
            Controls.Add(groupBox1);
            Controls.Add(navBox);
            Controls.Add(groupBoxLI);
            Name = "FormMain";
            Text = "Craterville";
            Load += FormMain_Load;
            groupBoxLI.ResumeLayout(false);
            groupBoxLI.PerformLayout();
            navBox.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLI;
        private System.Windows.Forms.RichTextBox textBoxDesc;
        private System.Windows.Forms.Label labelRD;
        private System.Windows.Forms.RichTextBox textBoxName;
        private System.Windows.Forms.Label labelRN;
        private System.Windows.Forms.GroupBox navBox;
        private System.Windows.Forms.Button southButton;
        private System.Windows.Forms.Button eastButton;
        private System.Windows.Forms.Button westButton;
        private System.Windows.Forms.Button northButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label UserText;
        private System.Windows.Forms.TextBox JobText;
        private System.Windows.Forms.Label JobLabel;
    }
}