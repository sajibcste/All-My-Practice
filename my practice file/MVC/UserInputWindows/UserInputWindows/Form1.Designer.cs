namespace UserInputWindows
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
            this.label1 = new System.Windows.Forms.Label();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.CancleButoon = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.oddCheckbox = new System.Windows.Forms.CheckBox();
            this.Evencheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // nametextbox
            // 
            this.nametextbox.Location = new System.Drawing.Point(103, 16);
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(100, 20);
            this.nametextbox.TabIndex = 1;
            this.nametextbox.Text = "name input";
            // 
            // CancleButoon
            // 
            this.CancleButoon.Location = new System.Drawing.Point(16, 53);
            this.CancleButoon.Name = "CancleButoon";
            this.CancleButoon.Size = new System.Drawing.Size(75, 23);
            this.CancleButoon.TabIndex = 2;
            this.CancleButoon.Text = "cancle";
            this.CancleButoon.UseVisualStyleBackColor = true;
            this.CancleButoon.Click += new System.EventHandler(this.CancleButoon_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(128, 53);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 3;
            this.showButton.Text = "show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.CancleButoon);
            this.groupBox1.Controls.Add(this.showButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nametextbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 237);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Name";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "vape",
            "vape juice",
            "eShisa",
            "vape luqied"});
            this.comboBox1.Location = new System.Drawing.Point(82, 116);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "select";
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(278, 169);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(75, 23);
            this.DisplayButton.TabIndex = 6;
            this.DisplayButton.Text = "Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // oddCheckbox
            // 
            this.oddCheckbox.AutoSize = true;
            this.oddCheckbox.Location = new System.Drawing.Point(315, 65);
            this.oddCheckbox.Name = "oddCheckbox";
            this.oddCheckbox.Size = new System.Drawing.Size(46, 17);
            this.oddCheckbox.TabIndex = 5;
            this.oddCheckbox.Text = "Odd";
            this.oddCheckbox.UseVisualStyleBackColor = true;
            // 
            // Evencheckbox
            // 
            this.Evencheckbox.AutoSize = true;
            this.Evencheckbox.Location = new System.Drawing.Point(315, 100);
            this.Evencheckbox.Name = "Evencheckbox";
            this.Evencheckbox.Size = new System.Drawing.Size(51, 17);
            this.Evencheckbox.TabIndex = 6;
            this.Evencheckbox.Text = "Even";
            this.Evencheckbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 298);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.Evencheckbox);
            this.Controls.Add(this.oddCheckbox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.Button CancleButoon;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox oddCheckbox;
        private System.Windows.Forms.CheckBox Evencheckbox;
    }
}

